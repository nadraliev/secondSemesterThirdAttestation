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
        
        public List<Connection> Connections { get; set; }

        public GraphNode(int id, string value)
        {
            Id = id;
            Value = value;
            Connections = new List<Connection>();
        }

        public void AddConnection(GraphNode destination, int weight)
        {
            Connections.Add(new Connection(this, destination, weight));
        }
    }
}
