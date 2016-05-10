using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphLibrary
{
    public class OrientedConnection<T> : Connection<T>
    {
        public OrientedConnection(GraphNode<T> source, GraphNode<T> destination, int weight) : base (source, destination, weight)
        {

        }

        internal void Draw(Pen linePen, Brush textBrush, Font font, Graphics graphics)
        {

        }
    }
}
