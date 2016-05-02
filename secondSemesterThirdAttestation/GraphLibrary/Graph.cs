using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Graph<T>
    {
        public List<GraphNode<T>> Nodes { get; private set; }
        public List<Connection<T>> Connections { get; private set; }

        public int Count { get; private set; }

        public Graph()
        {
            Nodes = new List<GraphNode<T>>();
            Count = 0;
        }

        public void AddNode(T value)
        {
            Nodes.Add(new GraphNode<T>(Count, value));
            Count++;
        }

        public void AddConnection(GraphNode<T> source, GraphNode<T> destination, int weight)
        {
            Connection<T> connection = new Connection<T>(source, destination, weight);
            Connections.Add(connection);
            source.OutConnections.Add(connection);  //links to connection duplicates to node to reduce calculations during drawing
            destination.InConnections.Add(connection);
        }
    }
}
