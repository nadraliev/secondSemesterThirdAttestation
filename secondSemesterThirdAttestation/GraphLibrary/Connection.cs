using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphLibrary
{
    public class Connection<T>
    {
        public GraphNode<T> Source { get; set; }
        public GraphNode<T> Destination { get; set; }

        public int StartX { get
            {
                return Source.CoordX + Source.BitmapNode.Size.Width / 2;
            }
        }
        public int StartY { get
            {
                return Source.CoordY + Source.BitmapNode.Size.Height / 2;
            }
        }
        public int EndX { get
            {
                return Destination.CoordX + Destination.BitmapNode.Size.Width / 2;
            }
        }
        public int EndY { get
            {
                return Destination.CoordY + Destination.BitmapNode.Size.Height / 2;
            }
        }
        public int Weight { get; set; }

        public Bitmap BitmapConnection { get; internal set; }

        public Connection(GraphNode<T> source, GraphNode<T> destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }

        internal void Draw(Pen linePen, Brush textBrush, Font font, Graphics graphics)
        {
            SizeF stringSize = graphics.MeasureString(Weight.ToString(), font);
            //caclulate bitmap size (line size)
            int width = Math.Abs(EndX - StartX);
            int height = Math.Abs(EndY - StartY);
            BitmapConnection = new Bitmap(width, height);
            Graphics connectionGraphics = Graphics.FromImage(BitmapConnection);
            if (EndY - StartY + EndX - StartX > 0)  //line is going from top left corner to bottom right
                connectionGraphics.DrawLine(linePen, 0, 0, width, height);
            else connectionGraphics.DrawLine(linePen, width, height, 0, 0);
            connectionGraphics.DrawString(Weight.ToString(), font, textBrush, width / 2, height / 2);
        }
    }
}
