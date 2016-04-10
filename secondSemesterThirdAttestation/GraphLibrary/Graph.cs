using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Graph
    {
        public List<GraphNode> Nodes { get; set; }
        public List<Connection> Connections { get; set; }
        public int Count { get; set; }

        public Graph()
        {
            Nodes = new List<GraphNode>();
            Count = 0;
        }

        public void AddNode(string value)
        {
            Nodes.Add(new GraphNode(Count, value));
            Count++;
        }

        public void AddConnection(GraphNode source, GraphNode destination, int weight)
        {
            Connection connection = new Connection(source, destination, weight);
            Connections.Add(connection);
            source.OutConnections.Add(connection);  //links to connection duplicates to node to reduce calculations during drawing
            destination.InConnections.Add(connection);
        }
    }
}
