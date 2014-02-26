﻿using System.Collections.Generic;
using Mercraft.Infrastructure.Dependencies;
using Mercraft.Models.Algorithms;
using Mercraft.Models.Scene;
using UnityEngine;

namespace Mercraft.Models.Tiles
{
    public class TileProvider
    {
        private readonly ISceneBuilder _sceneBuilder;
        private readonly TileSettings _settings;
        private readonly Dictionary<Vector2, Tile> _tiles;

        [Dependency]
        public TileProvider(ISceneBuilder sceneBuilder, TileSettings settings)
        {
            _sceneBuilder = sceneBuilder;
            _settings = settings;
            _tiles = new Dictionary<Vector2, Tile>();
        }

        public Tile GetTile(Vector2 mapPoint)
        {
            // TODO mapPoint should be the center of tile!
            if (_tiles.ContainsKey(mapPoint))
                return _tiles[mapPoint];

            var coordinate = GeoProjection.ToGeoCoordinate(_settings.RelativeNullPoint, mapPoint);
            
            // TODO invesigate tile size/bbox radius optimal ratio
            var radius = _settings.Size / 2;

            var bbox = BoundingBox.CreateBoundingBox(coordinate, radius);

            var scene = _sceneBuilder.Build(coordinate, bbox);

            var tile = new Tile(scene, coordinate, mapPoint, _settings.Size);
            _tiles.Add(mapPoint, tile);

            return tile;
        }
    }
}
