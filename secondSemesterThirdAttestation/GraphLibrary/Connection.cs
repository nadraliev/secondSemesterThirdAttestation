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

        public bool Highlighted { get; set; }

        public float StartX { get
            {
                return Source.CoordX + Source.BitmapNode.Size.Width / 2;
            }
        }
        public float StartY { get
            {
                return Source.CoordY + Source.BitmapNode.Size.Height / 2;
            }
        }
        public float EndX { get
            {
                return Destination.CoordX + Destination.BitmapNode.Size.Width / 2;
            }
        }
        public float EndY { get
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
            Highlighted = false;
        }

        public bool IsCrossing(Connection<T> connection)
        {
            return Area(StartX, StartY, EndX, EndY, connection.StartX, connection.StartY) *
                Area(StartX, StartY, EndX, EndY, connection.EndX, connection.EndY) <= 0 &&
                Area(connection.StartX, connection.StartY, connection.EndX, connection.EndY, StartX, StartY) *
                Area(connection.StartX, connection.StartY, connection.EndX, connection.EndY, EndX, EndY) <= 0;
        }

        public float Area(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            return (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);
        }

        internal void Draw(Pen linePen, Brush textBrush, Font font, Graphics graphics)
        {
            SizeF stringSize = graphics.MeasureString(Weight.ToString(), font);
            //caclulate bitmap size (line size)
            float width = Math.Abs(EndX - StartX);
            float height = Math.Abs(EndY - StartY);
            BitmapConnection = new Bitmap(Convert.ToInt32(Math.Max(width, stringSize.Width)), Convert.ToInt32(Math.Max(height, stringSize.Height)));
            Graphics connectionGraphics = Graphics.FromImage(BitmapConnection);
            if ((EndY - StartY > 0 && EndX - StartX > 0) || (EndY - StartY < 0 && EndX - StartX < 0))  //line is going from top left corner to bottom right
                connectionGraphics.DrawLine(linePen, 0, 0, width, height);
            else connectionGraphics.DrawLine(linePen, 0, height, width, 0);
            connectionGraphics.DrawString(Weight.ToString(), font, textBrush, width / 2, height / 2);
        }
    }
}
