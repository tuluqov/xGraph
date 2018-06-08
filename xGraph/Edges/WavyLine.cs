//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Ink;
//using System.Windows.Media;
//using System.Windows.Shapes;

//namespace xGraph.Edges
//{
//    public class WavyLine : Edge
//    {
//        public WavyLine(Point point1, Point point2) : base(point1, point2)
//        { }


//        public override Shape GetDrawingObject()
//        {
//            BezierSegment segment = new BezierSegment
//            {
//                Point1 = new System.Windows.Point(Point1.X, Point1.Y),
//                Point2 = new System.Windows.Point(Point1.X / 2, Point1.Y / 2),
//                Point3 = new System.Windows.Point(Point2.X, Point2.Y)
//            };

//            return segment;

//            //return new Polyline
//            //{
//            //    Stroke = Brushes.BlueViolet,
//            //    //X1 = Point1.X,
//            //    //Y1 = Point1.Y,
//            //    //X2 = Point2.X,
//            //    //Y2 = Point2.Y,

//            //    StrokeThickness = 2,

//            //    Points = GetPoints()
//            //};
//        }

//        public PointCollection GetPoints()
//        {
//            PointCollection points = new PointCollection();

//            for (int i = 0; i < 90; i++)
//            {
//                points.Add(new System.Windows.Point(this.Point1.X, 50 + 50 * Math.Sin(Point2.Y / Math.PI)));
//            }


//            return points;
//        }
//    }
//}
