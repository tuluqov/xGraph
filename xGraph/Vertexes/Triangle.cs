using System.Windows.Media;
using System.Windows.Shapes;

namespace xGraph.Vertexes
{
    public class Triangle : Vertex
    {
        public Triangle(Point point) : base(point)
        { }


        public override Shape GetDrawingObject()
        {
            return new Polygon
            {
                Fill = Brushes.BlueViolet,
                Points = PointCollection.Parse("-24, 50, 24, 1, 74, 50")
            };
        }
    }
}