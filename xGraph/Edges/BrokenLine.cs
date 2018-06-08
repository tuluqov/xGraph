using System.Windows.Media;
using System.Windows.Shapes;

namespace xGraph.Edges
{
    public class BrokenLine : Edge
    {
        public BrokenLine(Point point1, Point point2) : base(point1, point2)
        { }


        public override Shape GetDrawingObject()
        {
            return new Line
            {
                Stroke = Brushes.BlueViolet,
                X1 = Point1.X,
                Y1 = Point1.Y,
                X2 = Point2.X,
                Y2 = Point2.Y,

                StrokeDashArray = DoubleCollection.Parse("6 6"),
                StrokeThickness = 2
            };
        }
    }
}
