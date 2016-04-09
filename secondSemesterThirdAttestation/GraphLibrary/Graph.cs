using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Graph
    {
        public List<GraphNode> Nodes;
        public int Count { get; set; }

        public Graph()
        {
            Nodes = new List<GraphNode>();
            Count = 0;
        }

        public void AddNode(int id, string value)
        {
            Nodes.Add(new GraphNode(id, value));
            Count++;
        }
    }
}
