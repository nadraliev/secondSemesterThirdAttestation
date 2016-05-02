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
        public int Id { get; protected set; }
        
        public List<Connection<T>> OutConnections { get; protected set; }
        public List<Connection<T>> InConnections { get; protected set; }

        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public bool IsSelected { get; set; }

        public Bitmap bitmap { get; private set; }

        public GraphNode(int id, T value)
        {
            Id = id;
            Value = value;
            OutConnections = new List<Connection<T>>();
            InConnections = new List<Connection<T>>();
            CoordX = 0;
            CoordY = 0;
            IsSelected = false;
        }

        
    }
}
