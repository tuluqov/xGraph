using System;

namespace xGraph.Edges
{
    public abstract class Edge : Element
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
    }
}
