using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphLibrary
{
    public class GraphNode<T>
    {
        public T Value { get; set; }
        public int Id { get; internal set; }
        
        public List<Connection<T>> OutConnections { get; internal set; }
        public List<Connection<T>> InConnections { get; internal set; }

        public float CoordX { get; set; }
        public float CoordY { get; set; }

        public Bitmap BitmapNode { get; internal set; }

        //------------------------customization-------------//
        private int padding = 10;
        //--------------------------------------------------//

        public GraphNode(int id, T value)
        {
            Id = id;
            Value = value;
            OutConnections = new List<Connection<T>>();
            InConnections = new List<Connection<T>>();
            CoordX = 0;
            CoordY = 0;
        }

        internal void Draw(Brush backgroundBrush, Brush textBrush, Font font, Graphics graphics)
        {
            SizeF stringSize = graphics.MeasureString(Value.ToString(), font);
            BitmapNode = new Bitmap(Convert.ToInt32(stringSize.Width) + padding, Convert.ToInt32(stringSize.Height) + padding);
            Graphics nodeGraphics = Graphics.FromImage(BitmapNode);
            nodeGraphics.FillRectangle(backgroundBrush, 0, 0, Convert.ToInt32(stringSize.Width) + padding, Convert.ToInt32(stringSize.Height) + padding); //draw rectangle with size to wrap content
            nodeGraphics.DrawString(Value.ToString(), font, textBrush, padding/2, padding/2);
        }

    }
}
