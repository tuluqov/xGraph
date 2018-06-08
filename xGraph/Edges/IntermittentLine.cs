using System.Windows.Media;
using System.Windows.Shapes;

namespace xGraph.Edges
{
    public class IntermittentLine : Edge
    {
        public IntermittentLine(Point point1, Point point2) : base(point1, point2)
        { }

        public override Shape GetDrawingObject()
        {
            return new Polyline
            {
                Stroke = Brushes.BlueViolet,
                StrokeThickness = 2,

                Points = PointCollection.Parse(GetPoint())
            };
        }

        private string GetPoint()
        {
            string points = $"{Point1.X} {Point1.Y}, ";

            double counter = (Point2.X - Point1.X) * (Point2.Y - Point1.Y);

            if (counter < 0)
            {
                counter = counter * (-1);
            }

            Point tmp = new Point();

            tmp.X = Point1.X + 10;
            tmp.Y = Point1.Y + 10;



            for (int i = 0; i < counter/2; i++)
            {
                tmp.X = tmp.X + 10;
                tmp.Y = tmp.Y + 10;

                points += $"{ tmp.X} { tmp.Y}";

            }

            points += $"{ Point1.X} { Point1.Y}"; 

            return points;
        }
    }
}
