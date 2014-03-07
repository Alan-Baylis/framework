﻿
using System.Collections.Generic;
using Mercraft.Core.Scene.Models;

namespace Mercraft.Core.Scene
{
    /// <summary>
    /// Represents map scene
    /// </summary>
    public interface IScene
    {
        void AddBuilding(Building building);
        IEnumerable<Building> Buildings { get; }
    }
}
