using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphLibrary
{
    public class Graph<T>
    {
        public List<GraphNode<T>> Nodes { get; private set; }
        public List<Connection<T>> Connections { get; private set; }

        public int Count { get; private set; }


        public GraphNode<T> Selected { get; set; }

        public bool IsDragging;


        public Graph()
        {
            Nodes = new List<GraphNode<T>>();
            Connections = new List<Connection<T>>();
            Count = 0;
            IsDragging = false;
        }

        public void AddNode(T value)
        {
            Nodes.Add(new GraphNode<T>(Count, value));
            Count++;
        }

        public void AddConnection(GraphNode<T> source, GraphNode<T> destination, int weight)
        {
            if (source != null && destination != null)
            {
                Connection<T> connection = new Connection<T>(source, destination, weight);
               

                Connections.Add(connection);
                source.OutConnections.Add(connection);  //links to connection duplicates to node to reduce calculations during drawing
                destination.InConnections.Add(connection);
            }
        }

        public GraphNode<T> FindNode(double x, double y)
        {
            foreach (GraphNode<T> node in Nodes)
                if ((x > node.CoordX && x < node.CoordX + 2 * (node.CenterCoordX - node.CoordX)) && (y > node.CoordY && y < node.CoordY + 2 * (node.CenterCoordY - node.CoordY)))
                    return node;
            return null;
        }



        public int FindWayLength(List<Connection<T>> way)
        {
            int result = 0;
            if (way != null)
                foreach (Connection<T> connection in way) result += connection.Weight;
            return result;
        }

        public void ClearVisits()
        {
            foreach (GraphNode<T> node in Nodes) node.Visisted = false;
        }

        public void HighlightWay(List<Connection<T>> way)
        {
            foreach (Connection<T> connection in way)
            {
                connection.Highlighted = true;
                connection.Source.Highlighted = true;
                connection.Destination.Highlighted = true;
                foreach (Connection<T> second in Connections) if (connection.Source == second.Destination && connection.Destination == second.Source) second.Highlighted = true;
            }
        }

        public void ClearBlocks()
        {
            foreach (GraphNode<T> node in Nodes) node.Blocked = false;
            foreach (Connection<T> connection in Connections) connection.Blocked = false;
        }

        public void BlockConnections(List<Connection<T>> way)
        {
            foreach (Connection<T> connection in way)
            {
                connection.Blocked = true;
                foreach (Connection<T> second in Connections)
                    if (connection.Source == second.Destination && connection.Destination == second.Source) second.Blocked = true;
            }
        }

        public void BlockNodes(List<Connection<T>> way)
        {
            foreach (Connection<T> connection in way)
            {
                connection.Source.Blocked = true;
                connection.Destination.Blocked = true;
            }
        }

        public void ClearHighlights()
        {
            foreach (Connection<T> connection in Connections) connection.Highlighted = false;
            foreach (GraphNode<T> node in Nodes) node.Highlighted = false;
            Selected = null;
        }

        public void DFS()
        {
            Stack<GraphNode<T>> s = new Stack<GraphNode<T>>();
            s.Push(Nodes[0]);
            Nodes[0].Visisted = true;
            while (s.Count > 0)
            {
                //--------------------------------------------//
                GraphNode<T>[] path = s.ToArray();
                for (int k = 0; k < path.Length; k++)
                    Console.Write(path[k].Value.ToString() + " ");
                Console.WriteLine();
                //--------------------------------------------//

                GraphNode<T> v = s.Pop();
                for (int i = 0; i < v.OutConnections.Count; ++i)
                {
                    if (!v.OutConnections[i].Destination.Visisted)
                    {
                        s.Push(v.OutConnections[i].Destination);
                        v.OutConnections[i].Destination.Visisted = true;
                    }


                }
            }
            ClearVisits();
        }

        public void WFS()
        {
            Queue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            queue.Enqueue(Nodes[0]);
            while (queue.Count > 0)
            {

                //------------------------------------------//
                GraphNode<T>[] path = queue.ToArray();
                for (int k = 0; k < path.Length; k++)
                    Console.Write(path[k].Value.ToString() + " ");
                Console.WriteLine();
                //----------------------------------------//


                GraphNode<T> p = queue.Dequeue();
                if (!p.Visisted)
                {
                    p.Visisted = true;
                    foreach (Connection<T> connection in p.OutConnections)
                    {
                        queue.Enqueue(connection.Destination);
                    }
                }
            }
            ClearVisits();
        }


    }
}
