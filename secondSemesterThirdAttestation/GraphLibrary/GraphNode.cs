using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class GraphNode
    {
        public string Value { get; set; }
        public int Id { get; set; }
        
        public List<Connection> OutConnections { get; set; }
        public List<Connection> InConnections { get; set; }

        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public bool Selected { get; set; }

        public GraphNode(int id, string value)
        {
            Id = id;
            Value = value;
            OutConnections = new List<Connection>();
            InConnections = new List<Connection>();
            CoordX = 0;
            CoordY = 0;
            Selected = false;
        }

        
    }
}
