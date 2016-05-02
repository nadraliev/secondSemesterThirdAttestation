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
    }
}
