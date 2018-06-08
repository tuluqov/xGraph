using System.Windows.Media;
using System.Windows.Shapes;

namespace xGraph.Edges
{
    public class BaseLine : Edge
    {
        public BaseLine(Point point1, Point point2) : base(point1, point2)
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

                StrokeThickness = 2
            };
        }
    }
}
