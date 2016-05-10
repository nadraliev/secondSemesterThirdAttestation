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

        public Bitmap BitmapGraph { get; private set; }

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
                if ((x > node.CoordX && x < node.CoordX + node.BitmapNode.Size.Width) && (y > node.CoordY && y < node.CoordY + node.BitmapNode.Size.Height))
                    return node;
            return null;
        }

        public void Draw(Graphics graphics, Brush nodeBackgroundBrush, Brush selectedNodeBrush, Brush highlightedNodeBrush, Brush nodeTextBrush, Brush connectionTextBrush, Pen connectionPen, Pen highlightedConnectionPen, Font nodeFont, Font connectionFont, int width, int height)
        {
            BitmapGraph = new Bitmap(width, height);
            Graphics graphGraphics = Graphics.FromImage(BitmapGraph);
            foreach (GraphNode<T> node in Nodes)
            {
                if (Selected == node) node.Draw(selectedNodeBrush, nodeTextBrush, nodeFont, graphics);
                else if (node.Highlighted) node.Draw(highlightedNodeBrush, nodeTextBrush, nodeFont, graphics);
                else node.Draw(nodeBackgroundBrush, nodeTextBrush, nodeFont, graphics);
            }

            foreach (Connection<T> connection in Connections)
            {
                if (connection.Highlighted) connection.Draw(highlightedConnectionPen, connectionTextBrush, connectionFont, graphics);
                else connection.Draw(connectionPen, connectionTextBrush, connectionFont, graphics);
            }

            foreach (Connection<T> connection in Connections)
            {
                graphGraphics.DrawImage(connection.BitmapConnection, Math.Min(connection.StartX, connection.EndX), Math.Min(connection.StartY, connection.EndY));
            }

            foreach (GraphNode<T> node in Nodes)
            {
                graphGraphics.DrawImage(node.BitmapNode, node.CoordX, node.CoordY);
            }
        }

        public int FindWayLength(List<Connection<T>> way)
        {
            int result = 0;
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
            }
        }

        public void ClearHighlights()
        {
            foreach (Connection<T> connection in Connections) connection.Highlighted = false;
            foreach (GraphNode<T> node in Nodes) node.Highlighted = false;
        }

        
    }
}
