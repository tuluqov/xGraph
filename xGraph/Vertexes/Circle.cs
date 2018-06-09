using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace xGraph.Vertexes
{
    public class Circle : Vertex
    {
        public Circle(Point point) : base(point)
        { }

        public override Shape GetDrawingObject()
        {
            return new Ellipse
            {
                Fill = Brushes.BlueViolet,
                Width = 50,
                Height = 50,
            };
        }
    }
}
