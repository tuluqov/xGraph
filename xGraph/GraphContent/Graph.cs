using System.Collections.Generic;
using System.Linq;
using xGraph.Vertexes;
using xGraph.Edges;


namespace xGraph.GraphContent
{
    public class Graph
    {
        public List<Vertex> Vertices { get; }
        public List<Edge> Edges { get; }

        public List<Element> Elements { get; set; }

        //пока еще думаю разделять на вершины и ребра либо сделать один список Elements

        public BitMatrix AdjacencyMatrix { get; set; }

        public int IdVertexesCounter { get; set; }


        //constructoкs
        public Graph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
            
            AdjacencyMatrix = new BitMatrix();

            IdVertexesCounter = 1;
        }

        public Graph(List<Vertex> vertices, List<Edge> edges)
        {
            Vertices = vertices;
            Edges = edges;

            AdjacencyMatrix = new BitMatrix();

            IdVertexesCounter = 1;
        }   

        public Graph(List<Element> elements)
        {
            Elements = elements;

            AdjacencyMatrix = new BitMatrix();

            IdVertexesCounter = 1;
        }


        //methods
        public void Add(Vertex element)
        {
            Vertices?.Add(element);

            element.Id = IdVertexesCounter;
            IdVertexesCounter++;

            AdjacencyMatrix.AddVertex();
        }

        public void Add(Edge edge, Vertex vertex1, Vertex vertex2)
        {
            Edges?.Add(edge);

            //добавить изменние в матрице инциндетности
            AdjacencyMatrix.AddEdge(vertex1.Id - 1, vertex2.Id - 1);
        }

        public Vertex GetLastVertex()
        {
            return Vertices.Last();
        }
    }
}
