using System.Collections.Generic;
using xGraph.Vertexes;
using xGraph.Edges;


namespace xGraph.GraphContent
{
    class Graph
    {
        public List<Vertex> Vertices { get; }
        public List<Edge> Edges { get; }

        public Graph()
        { }

        public Graph(List<Vertex> vertices, List<Edge> edges)
        {
            Vertices = vertices;
            Edges = edges;
        }

        public void Add(Vertex element)
        {
            Vertices?.Add(element);
        }

        public void Add(Edge edge)
        {
            Edges?.Add(edge);
        }

        public void AddEdge(Vertex vertex1, Vertex vertex2, Edge edge)
        {
            edge.Point1 = vertex1.Point;
            edge.Point2 = vertex2.Point;
        }

        
    }
}
