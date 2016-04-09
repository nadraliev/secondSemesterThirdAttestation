using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Connection
    {
        public GraphNode Source { get; set; }
        public GraphNode Destination { get; set; }
        public int Weight { get; set; }

        public Connection(GraphNode source, GraphNode destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }
}
