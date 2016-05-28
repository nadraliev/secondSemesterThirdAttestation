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

        public bool DoSpin(GraphNode<T> currGear)   //you need to determine spin for first Node for this method to work
        {
            int result = 0;     //0 - for OK, go recursively, 1 - for nothing changed, means ability to do spin, -1 - for jamming
            bool changed = false;
            int newSpin = (currGear.Spin + 1) % 2;
            foreach (Connection<T> connection in currGear.OutConnections)
            {     
                if (connection.Destination.Spin != -1)
                {
                    if (connection.Destination.Spin != newSpin)
                    {
                        connection.Destination.Jammed = true;
                        result = -1;
                        break;
                    }
                }
                else
                {
                    changed = true;
                    connection.Destination.Spin = newSpin;
                }
            }
            if (result == -1) return false;
            if (!changed) result = 1;
            else result = 0;
            if (result == 1) return true;
            else
            {
                foreach (Connection<T> connection in currGear.OutConnections)
                {
                    if (DoSpin(connection.Destination)) return true;
                    else return false;
                }
            }
            return false;
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

        public int CountSpins()
        {
            int result = 0;
            foreach (GraphNode<T> node in Nodes) if (node.Spin != -1) result++;
            return result;
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

        public void ClearSpins()
        {
            foreach (GraphNode<T> node in Nodes) node.Spin = -1;
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

        public void RemoveConnection(Connection<T> connection)
        {
            int index = -1;
            for (int i = 0; i < Connections.Count; i++)
                if (Connections[i] == connection) index = i;
            Connections.RemoveAt(index);
            for (int i = 0; i < connection.Source.OutConnections.Count; i++)
                if (connection.Source.OutConnections[i] == connection) index = i;
            connection.Source.OutConnections.RemoveAt(index);
            for (int i = 0; i < connection.Destination.InConnections.Count; i++)
                if (connection.Destination.InConnections[i] == connection) index = i;
            connection.Destination.InConnections.RemoveAt(index);
        }

        public void RemoveNode(GraphNode<T> node)
        {
            while (node.OutConnections.Count > 0)
                RemoveConnection(node.OutConnections[0]);
            while (node.InConnections.Count > 0)
                RemoveConnection(node.InConnections[0]);
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i] == node) Nodes.RemoveAt(i);
            }
        }


    }
}
