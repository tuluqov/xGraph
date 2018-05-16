using System;

namespace xGraph.Vertexes
{
    public abstract class Vertex : Element
    {
        public byte Id { get; set; }
        public Point Point { get; set; }

        public static bool operator ==(Vertex vertex1, Vertex vertex2)
        {
            return (vertex1.Id == vertex2.Id
                    && vertex1.Point.X == vertex2.Point.X
                    && vertex1.Point.Y == vertex2.Point.Y);
        }

        public static bool operator !=(Vertex vertex1, Vertex vertex2)
        {
            return !(vertex1 == vertex2);
        }
    }
}
