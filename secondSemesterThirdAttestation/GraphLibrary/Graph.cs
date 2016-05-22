using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphLibrary
{
    public class Graph
    {
        public List<GraphNode> Nodes { get; private set; }
        public List<Connection> Connections { get; private set; }

        public int Count { get; private set; }


        public GraphNode Selected { get; set; }

        public bool IsDragging;


        public Graph()
        {
            Nodes = new List<GraphNode>();
            Connections = new List<Connection>();
            Count = 0;
            IsDragging = false;
        }

        public void AddNode(string value)
        {
            Nodes.Add(new GraphNode(Count, value));
            Count++;
        }

        public void AddNode(string value, int X, int Y)
        {
            Nodes.Add(new GraphNode(Count, value, X, Y));
            Count++;
        }

        public void AddConnection(GraphNode source, GraphNode destination, int weight)
        {
            if (source != null && destination != null)
            {
                Connection connection = new Connection(source, destination, weight);
                Connections.Add(connection);
                source.OutConnections.Add(connection);  //links to connection duplicates to node to reduce calculations during drawing
                destination.InConnections.Add(connection);
            }
        }

        public GraphNode FindNode(double x, double y)
        {
            foreach (GraphNode node in Nodes)
                if ((x > node.CoordX && x < node.CoordX + 2 * (node.CenterCoordX - node.CoordX)) && (y > node.CoordY && y < node.CoordY + 2 * (node.CenterCoordY - node.CoordY)))
                    return node;
            return null;
        }



        public int FindWayLength(List<Connection> way)
        {
            int result = 0;
            if (way != null)
                foreach (Connection connection in way) result += connection.Weight;
            return result;
        }

        public void ClearVisits()
        {
            foreach (GraphNode node in Nodes) node.Visisted = false;
        }

        public void HighlightWay(List<Connection> way)
        {
            foreach (Connection connection in way)
            {
                connection.Highlighted = true;
                connection.Source.Highlighted = true;
                connection.Destination.Highlighted = true;
                foreach (Connection second in Connections) if (connection.Source == second.Destination && connection.Destination == second.Source) second.Highlighted = true;
            }
        }

        public void ClearBlocks()
        {
            foreach (GraphNode node in Nodes) node.Blocked = false;
            foreach (Connection connection in Connections) connection.Blocked = false;
        }

        public void BlockConnections(List<Connection> way)
        {
            foreach (Connection connection in way)
            {
                connection.Blocked = true;
                foreach (Connection second in Connections)
                    if (connection.Source == second.Destination && connection.Destination == second.Source) second.Blocked = true;
            }
        }

        public void BlockNodes(List<Connection> way)
        {
            foreach (Connection connection in way)
            {
                connection.Source.Blocked = true;
                connection.Destination.Blocked = true;
            }
        }

        public void ClearHighlights()
        {
            foreach (Connection connection in Connections) connection.Highlighted = false;
            foreach (GraphNode node in Nodes) node.Highlighted = false;
        }


    }
}
