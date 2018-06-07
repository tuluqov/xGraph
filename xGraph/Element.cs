using System;
using System.Windows.Shapes;

namespace xGraph
{
    public abstract class Element : IElement
    {
        public abstract Shape GetDrawingObject();
    }
}
