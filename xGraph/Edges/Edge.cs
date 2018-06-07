using System;

namespace xGraph.Edges
{
    public enum EdgeType
    {
        BaseLine,
        WavyLine,
        IntermittentLine
    }

    public abstract class Edge : Element
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        protected Edge(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        #region Opertors

        public static bool operator ==(Edge edge1, Edge edge2)
        {
            return (edge1?.Point1 == edge2?.Point1 && edge1?.Point2 == edge2?.Point2);
        }

        public static bool operator !=(Edge edge1, Edge edge2)
        {
            return !(edge1 == edge2);
        }

        #endregion
    }
}
