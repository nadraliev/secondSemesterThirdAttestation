using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphLibrary;

namespace GraphForm
{
    public static class DrawingGraph<T>
    {
        //------------------------customization-------------//
        private static int padding = 10;
        //--------------------------------------------------//



        public static Bitmap DrawConnection(Connection<T> connection, Pen linePen, Brush textBrush, Font font, Graphics graphics)
        {
            SizeF stringSize = graphics.MeasureString(connection.Weight.ToString(), font);
            //caclulate bitmap size (line size)
            float width = Math.Abs(connection.Destination.CenterCoordX - connection.Source.CenterCoordX);
            float height = Math.Abs(connection.Destination.CenterCoordY - connection.Source.CenterCoordY);
            Bitmap BitmapConnection = new Bitmap(Convert.ToInt32(Math.Max(width, stringSize.Width)), Convert.ToInt32(Math.Max(height, stringSize.Height)));
            Graphics connectionGraphics = Graphics.FromImage(BitmapConnection);
            if ((connection.Destination.CenterCoordY - connection.Source.CenterCoordY > 0 && connection.Destination.CenterCoordX - connection.Source.CenterCoordX > 0) || (connection.Destination.CenterCoordY - connection.Source.CenterCoordY < 0 && connection.Destination.CenterCoordX - connection.Source.CenterCoordX < 0))  //line is going from top left corner to bottom right
                connectionGraphics.DrawLine(linePen, 0, 0, width, height);
            else connectionGraphics.DrawLine(linePen, 0, height, width, 0);
            connectionGraphics.DrawString(connection.Weight.ToString(), font, textBrush, width / 2, height / 2);
            return BitmapConnection;
        } 

        public static Bitmap DrawNode(GraphNode<T> node, Brush backgroundBrush, Brush textBrush, Font font, Graphics graphics)
        {
            SizeF stringSize = graphics.MeasureString(node.Value.ToString(), font);
            Bitmap BitmapNode = new Bitmap(Convert.ToInt32(stringSize.Width) + padding, Convert.ToInt32(stringSize.Height) + padding);
            Graphics nodeGraphics = Graphics.FromImage(BitmapNode);
            nodeGraphics.FillRectangle(backgroundBrush, 0, 0, Convert.ToInt32(stringSize.Width) + padding, Convert.ToInt32(stringSize.Height) + padding); //draw rectangle with size to wrap content
            nodeGraphics.DrawString(node.Value.ToString(), font, textBrush, padding / 2, padding / 2);
            node.CenterCoordX = node.CoordX + BitmapNode.Size.Width / 2;
            node.CenterCoordY = node.CoordY + BitmapNode.Size.Height / 2;
            return BitmapNode;
        }

        public static Bitmap DrawGraph(Graph<T> graph, Graphics graphics, Brush nodeBackgroundBrush, Brush selectedNodeBrush, Brush highlightedNodeBrush, Brush blockedNodeBrush, Brush nodeTextBrush, Brush connectionTextBrush, Pen connectionPen, Pen highlightedConnectionPen, Font nodeFont, Font connectionFont, int width, int height)
        {
            Bitmap BitmapGraph = new Bitmap(width, height);
            Graphics graphGraphics = Graphics.FromImage(BitmapGraph);
            List<Bitmap> nodesBitmap = new List<Bitmap>();
            List<float[]> nodesCoords = new List<float[]>();
            List<Bitmap> connectionsBitmap = new List<Bitmap>();
            List<float[]> connectionsCoord = new List<float[]>();
            foreach (GraphNode<T> node in graph.Nodes)
            {
                if (graph.Selected == node)  nodesBitmap.Add(DrawNode(node, selectedNodeBrush, nodeTextBrush, nodeFont, graphics)); 
                else if (node.Highlighted) nodesBitmap.Add(DrawNode(node, highlightedNodeBrush, nodeTextBrush, nodeFont, graphics));
                else if (node.Blocked) nodesBitmap.Add(DrawNode(node, blockedNodeBrush, nodeTextBrush, nodeFont, graphics));
                else nodesBitmap.Add(DrawNode(node, nodeBackgroundBrush, nodeTextBrush, nodeFont, graphics));
                nodesCoords.Add(new float[2] { node.CoordX, node.CoordY });
            }

            foreach (Connection<T> connection in graph.Connections)
            {
                if (connection.Highlighted) connectionsBitmap.Add(DrawConnection( connection, highlightedConnectionPen, connectionTextBrush, connectionFont, graphics));
                else connectionsBitmap.Add(DrawConnection( connection,connectionPen, connectionTextBrush, connectionFont, graphics));
                connectionsCoord.Add(new float[4] { connection.Source.CenterCoordX, connection.Source.CenterCoordY, connection.Destination.CenterCoordX, connection.Destination.CenterCoordY });
            }

            for (int i = 0; i < connectionsBitmap.Count; i++)
            {
                graphGraphics.DrawImage(connectionsBitmap[i], Math.Min(connectionsCoord[i][0], connectionsCoord[i][2]), Math.Min(connectionsCoord[i][1], connectionsCoord[i][3]));
            }

            for (int i =0; i < nodesBitmap.Count; i++)
            {
                graphGraphics.DrawImage(nodesBitmap[i], nodesCoords[i][0], nodesCoords[i][1]);
            }
            return BitmapGraph;
        }
    }
}
