using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Shapes;

namespace xGraph.Vertexes
{
    public class Square : Vertex
    {
        public Square(Point point) : base(point)
        { }

        public override Shape GetDrawingObject()
        {
            return new Rectangle
            {
                Fill = Brushes.BlueViolet,
                Width = 50,
                Height = 50
            };
        }
    }
}
