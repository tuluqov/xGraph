using System.Collections.Generic;
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


        //constructoкs
        public Graph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
            
            AdjacencyMatrix = new BitMatrix();
        }

        public Graph(List<Vertex> vertices, List<Edge> edges)
        {
            Vertices = vertices;
            Edges = edges;
        }   

        public Graph(List<Element> elements)
        {
            Elements = elements;
        }


        //methods
        public void Add(Element element)
        {
            //Elements?.Add(element);

            if (element != null)
            {
                Elements.Add(element);
            }
        }

        public void Add(Vertex element)
        {
            Vertices?.Add(element);

            AdjacencyMatrix.AddVertex();
        }

        public void Add(Edge edge)
        {
            Edges?.Add(edge);
            
            //добавить изменние в матрице инциндетности
        }

        public void AddEdge(Vertex vertex1, Vertex vertex2, Edge edge)
        {
            edge.Point1 = vertex1.Point;
            edge.Point2 = vertex2.Point;
        }
    }
}
