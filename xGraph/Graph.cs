using System;
using System.Collections.Generic;
using System.Linq;

namespace xGraph
{
    class Graph
    {
        public Graph()
        { }

        public Graph(List<Element> elements)
        {
            Elements = elements;
        }

        public List<Element> Elements { get; }

        public void Add(Element element)
        {
            Elements.Add(element);
        }
    }
}
