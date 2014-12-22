﻿using ActionStreetMap.Core;
using ActionStreetMap.Osm.Visitors;

namespace ActionStreetMap.Osm.Entities
{
    /// <summary>
    ///     Represents a simple node.
    /// </summary>
    public class Node : Element
    {
        /// <summary>
        ///     The coordinates of this node.
        /// </summary>
        public GeoCoordinate Coordinate { get; set; }

        /// <inheritdoc />
        public override void Accept(IElementVisitor elementVisitor)
        {
            elementVisitor.VisitNode(this);
        }
    }
}