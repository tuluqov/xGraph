using System;

namespace xGraph.Edges
{
    public abstract class Edge : Element
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        protected Edge(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
    }
}
