﻿using System;
using System.Collections.Generic;
using ActionStreetMap.Core.Elevation;
using ActionStreetMap.Core.Scene.World.Buildings;
using ActionStreetMap.Core.Unity;
using ActionStreetMap.Infrastructure.Dependencies;
using ActionStreetMap.Infrastructure.Reactive;
using ActionStreetMap.Infrastructure.Utilities;
using ActionStreetMap.Models.Buildings.Roofs;
using ActionStreetMap.Models.Utils;
using UnityEngine;

namespace ActionStreetMap.Models.Buildings
{
    /// <summary>
    ///     Defines building builder logic.
    /// </summary>
    public interface IBuildingBuilder
    {
        /// <summary>
        ///     Builds building.
        /// </summary>
        /// <param name="heightMap">Heightmap.</param>
        /// <param name="building">Building.</param>
        /// <param name="style">Style.</param>
        void Build(HeightMap heightMap, Building building, BuildingStyle style);
    }

    /// <summary>
    ///     Default building builder.
    /// </summary>
    public class BuildingBuilder : IBuildingBuilder
    {
        private readonly IResourceProvider _resourceProvider;
        private readonly IObjectPool _objectPool;

        /// <summary>
        ///     Creates BuildingBuilder.
        /// </summary>
        /// <param name="resourceProvider">Resource provider.</param>
        /// <param name="objectPool">Object pool.</param>
        [Dependency]
        public BuildingBuilder(IResourceProvider resourceProvider, IObjectPool objectPool)
        {
            _resourceProvider = resourceProvider;
            _objectPool = objectPool;
        }

        /// <inheritdoc />
        public void Build(HeightMap heightMap, Building building, BuildingStyle style)
        {
            var facadeMeshData = style.Facade.Builders[RandomHelper
                .GetIndex(building.Id, style.Facade.Builders.Length)]
                .Build(building, style);

            var roofMeshData = GetRoofBuilder(building, style.Roof.Builders)
               .Build(building, style);

            // NOTE use different gameObject only to support different materials
            Scheduler.MainThread.Schedule(() => AttachChildGameObject(building.GameObject, "facade", facadeMeshData));
            Scheduler.MainThread.Schedule(() => AttachChildGameObject(building.GameObject, "roof", roofMeshData));
        }

        /// <summary>
        ///     Process unity's game object.
        /// </summary>
        protected virtual void AttachChildGameObject(IGameObject parent, string name, MeshData meshData)
        {
            GameObject gameObject = GetGameObject(meshData);
            gameObject.isStatic = true;
            gameObject.transform.parent = parent.GetComponent<GameObject>().transform;
            gameObject.name = name;
            gameObject.renderer.sharedMaterial = _resourceProvider
              .GetMatertial(meshData.MaterialKey);
        }

        private GameObject GetGameObject(MeshData meshData)
        {
            // GameObject was created directly in builder, so we can use it and ignore other meshData properties.
            // also we expect that all components are defined
            if (meshData.GameObject != null)
               return meshData.GameObject.GetComponent<GameObject>();

            var gameObject = new GameObject();
            var mesh = new Mesh();
            mesh.vertices = meshData.Vertices;
            mesh.triangles = meshData.Triangles;
            mesh.uv = meshData.UV;
            mesh.RecalculateNormals();

            gameObject.AddComponent<MeshFilter>().mesh = mesh;
            gameObject.AddComponent<MeshCollider>();
            gameObject.AddComponent<MeshRenderer>();

            return gameObject;
        }

        private IRoofBuilder GetRoofBuilder(Building building, IRoofBuilder[] roofBuildings)
        {
            // for most of buildings, roof type isn't defined, but we want to use different types
            // however, we have to check whether we can build roof using random roof builder
            // contains true for index of roof builder if it can build roof for given building
            var ids = _objectPool.NewList<int>();

            int count = 0;
            for (int i = 0; i < roofBuildings.Length; i++)
            {
                if (roofBuildings[i].CanBuild(building))
                {
                    // strong match
                    if (roofBuildings[i].Name == building.RoofType)
                    {
                        ids.Clear();
                        ids.Add(i);
                        count = 1;
                        break;
                    }

                    ids.Add(i);
                    count++;
                }
            }

            if (count == 0)
                throw new InvalidOperationException(String.Format(Strings.CannotFindRoofBuilder, building.Address));

            // however, we don't want to use first occurrence, use building Id as seed
            var index = ids[(int) building.Id % count];

            _objectPool.Store(ids);
            return roofBuildings[index];
        }
    }
}
