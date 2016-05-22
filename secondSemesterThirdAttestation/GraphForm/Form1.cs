using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphLibrary;
using System.IO;

namespace GraphForm
{
    public partial class main_form : Form
    {
        private Graph<string> graph;

        private int PressedX;
        private int PressedY;


        //------------------customization-----------------------------//
        private Font fontNode = new Font("Arial", 16);
        private Font fontConnection = new Font("Arial", 14);
        private Brush nodeBackground = Brushes.DarkCyan;
        private Brush selectedNodeBrush = Brushes.Cyan;
        private Brush highlightedNodeBrush = Brushes.Cyan;
        private Brush nodeText = Brushes.Black;
        private Brush connectionText = Brushes.Green;
        private Pen connectionLine = Pens.Black;
        private Pen highlightedConnectionPen = Pens.Cyan;
        //-----------------------------------------------------------//

        public main_form()
        {
            InitializeComponent();
            graph = new Graph<string>();
        }

        public void ResizeElements()
        {
            graph_output.Width = this.Width - 30;
            graph_output.Height = this.Height - 30;
        }

        private void main_form_size_changed(object sender, EventArgs e)
        {
            ResizeElements();
        }


        //--------------------handle mouse events---------------//

        private void graph_output_mouse_down(object sender, MouseEventArgs args)
        {
            if (graph != null)
            {
                if (graph.Selected == null)
                    graph.Selected = graph.FindNode(args.X, args.Y);
                graph.IsDragging = true;
                PressedX = args.X;
                PressedY = args.Y;
            }
        }

        private void graph_output_mouse_up(object sender, MouseEventArgs args)
        {
            if (graph != null)
            {
                if (graph.Selected != null)
                {
                    if (!(args.X == PressedX && args.Y == PressedY)) 
                        graph.Selected = null;
                    GraphNode<string> temp = graph.FindNode(args.X, args.Y);
                    if (temp != null)
                    {
                        if (temp != graph.Selected && graph.Selected != null)
                        {
                            //selected two nodes
                            graph.Selected = null;
                        } 
                    }
                    graph.IsDragging = false;
                    graph_output.Refresh();
                }
            }
        }

        private void graph_output_mouse_move(object sender, MouseEventArgs args)
        {
            if (graph != null)
            {
                if (graph.Selected != null && graph.IsDragging)
                {
                    graph.Selected.CoordX = args.X;
                    graph.Selected.CoordY = args.Y;
                    graph_output.Refresh();
                }
            }
        }

        private void clear_highlights_btn_Click(object sender, EventArgs e)
        {
            graph.ClearHighlights();
            graph_output.Refresh();
        }

        private void clear_graph_btn_Click(object sender, EventArgs e)
        {
            graph = new Graph<string>();
            graph_output.Refresh();
        }

       

       


        //------------------------------------------------------//


        public void DrawGraphInt(Graph<string> graph, Graphics graphics)
        {
            graphics.Clear(BackColor);
            Bitmap graphBitmap = DrawingGraph<string>.DrawGraph( graph, graphics, nodeBackground, selectedNodeBrush, highlightedNodeBrush, nodeText, connectionText, connectionLine, highlightedConnectionPen, fontNode, fontConnection, graph_output.Width, graph_output.Height);
            graphics.DrawImage(graphBitmap, 0, 0);
        }

        private void picture_box_paint(object sender, PaintEventArgs e)
        {
            DrawGraphInt(graph, e.Graphics);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void gen_field_btn_Click(object sender, EventArgs e)
        {
            graph = new Graph<string>();
            int n = (int)input_n_nud.Value;
            int nSqrt = Convert.ToInt32(Math.Sqrt(n));
            int curX = 0;
            int curY = 0;
            int offset = 20;
            GraphNode<string> prev = null;
            while (curX < graph_output.Width && n >0)
            {
                while (curY < graph_output.Height && curY/offset+1 <= nSqrt && n >0)
                {
                    graph.AddNode(String.Empty, curX, curY);
                    if (prev != null)
                    {
                        graph.AddConnection(graph.Nodes.Last(), prev, 0);
                        graph.AddConnection(prev, graph.Nodes.Last(), 0);
                    }
                    if (graph.Nodes.Count - 1 - nSqrt >= 0)
                    {
                        graph.AddConnection(graph.Nodes.Last(), graph.Nodes[graph.Count - 1 - nSqrt], 0);
                        graph.AddConnection(graph.Nodes[graph.Count - 1 - nSqrt], graph.Nodes.Last(), 0);
                    }
                    prev = graph.Nodes.Last();
                    n--;
                    curY += offset;
                }
                prev = null;
                curX += offset;
                curY = 0;
            }

            
            graph_output.Refresh();
        }
    }
}
