using System;
using System.Collections.Generic;
using System.Linq;
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
            string pointsString = GetPointsString(this.Point);

            return new Polygon
            {
                Fill = Brushes.BlueViolet,
                Points = PointCollection.Parse("0, 50, 50, 0, 100, 50")
            };
        }

        public string GetPointsString(Point point)
        {
            double leftPointX = point.X - 25;
            double leftPointY = point.Y - 25;

            double rightPointX = point.X + 25;
            double rightPointY = point.Y - 25;

            double centerPointX = point.X;
            double centerPointY = point.Y + 25;

            return String.Format(
                $"{leftPointX} {leftPointY} {rightPointX} {rightPointY} {centerPointX} {centerPointY}");
        }
    }
}