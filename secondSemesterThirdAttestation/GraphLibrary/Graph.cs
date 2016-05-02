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

        public Graph()
        {
            Nodes = new List<GraphNode<T>>();
            Connections = new List<Connection<T>>();
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

        public void Draw(Graphics graphics, Brush nodeBackgroundBrush, Brush nodeTextBrush, Brush connectionTextBrush, Pen connectionPen, Font nodeFont, Font connectionFont, int width, int height)
        {
            BitmapGraph = new Bitmap(width, height);
            Graphics graphGraphics = Graphics.FromImage(BitmapGraph);
            foreach (GraphNode<T> node in Nodes)
            {
                DrawNode(node, nodeBackgroundBrush, nodeTextBrush, nodeFont, graphics);
            }

            foreach (Connection<T> connection in Connections)
            {
                DrawConnection(connection, connectionPen, connectionTextBrush, connectionFont, graphics);
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

        private void DrawNode(GraphNode<T> node, Brush backgroundBrush, Brush textBrush, Font font, Graphics graphics)
        {
            SizeF stringSize = graphics.MeasureString(node.Value.ToString(), font);
            node.BitmapNode = new Bitmap(Convert.ToInt32(stringSize.Width) + 10, Convert.ToInt32(stringSize.Height) + 10);
            Graphics nodeGraphics = Graphics.FromImage(node.BitmapNode);
            nodeGraphics.FillRectangle(backgroundBrush, 0, 0, Convert.ToInt32(stringSize.Width) + 10, Convert.ToInt32(stringSize.Height) + 10); //draw rectangle with size to wrap content
            nodeGraphics.DrawString(node.Value.ToString(), font, textBrush, 5, 5);  //draw string with padding 5
        }

        private void DrawConnection(Connection<T> connection, Pen linePen, Brush textBrush, Font font, Graphics graphics)
        {
            SizeF stringSize = graphics.MeasureString(connection.Weight.ToString(), font);
            //caclulate bitmap size (line size)
            int width = Math.Abs(connection.EndX - connection.StartX);
            int height = Math.Abs(connection.EndY - connection.StartY);
            connection.BitmapConnection = new Bitmap(width, height);
            Graphics connectionGraphics = Graphics.FromImage(connection.BitmapConnection);
            if (connection.EndY - connection.StartY + connection.EndX - connection.StartX > 0)  //line is going from top left corner to bottom right
                connectionGraphics.DrawLine(linePen, 0, 0, width, height);
            else connectionGraphics.DrawLine(linePen, width, height, 0, 0);
            connectionGraphics.DrawString(connection.Weight.ToString(), font, textBrush, width / 2, height / 2);
        }
    }
}
