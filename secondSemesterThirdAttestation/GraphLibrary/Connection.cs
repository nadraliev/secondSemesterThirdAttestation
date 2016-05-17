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

       
        public int Weight { get; set; }

        public bool Blocked { get; set; }

        public Connection(GraphNode<T> source, GraphNode<T> destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
            Highlighted = false;
            Blocked = false;
        }

      

        
    }
}
