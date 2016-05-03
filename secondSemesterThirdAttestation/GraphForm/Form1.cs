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

namespace GraphForm
{
    public partial class main_form : Form
    {
        private Graph<int> graph;

        private int PressedX;
        private int PressedY;


        //------------------customization-----------------------------//
        private Font fontNode = new Font("Arial", 16);
        private Font fontConnection = new Font("Arial", 14);
        private Brush nodeBackground = Brushes.Brown;
        private Brush selectedNodeBrush = Brushes.SandyBrown;
        private Brush nodeText = Brushes.White;
        private Brush connectionText = Brushes.Purple;
        private Pen connectionLine = Pens.Black;
        //-----------------------------------------------------------//

        public main_form()
        {
            InitializeComponent();
            graph = new Graph<int>();
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

        private void add_node_button_Click(object sender, EventArgs e)
        {
            if (graph == null) graph = new Graph<int>();
            graph.AddNode((int)input_number_numeric.Value);
            graph_output.Refresh();
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
                    GraphNode<int> temp = graph.FindNode(args.X, args.Y);
                    if (temp != null)
                    {
                        if (temp != graph.Selected)
                        {
                            graph.AddConnection(graph.Selected, temp, (int)connection_weight.Value);
                            graph.Selected = null;
                        } else
                        {
                            //create loop
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
    

        //------------------------------------------------------//


        public void DrawGraphInt(Graph<int> graph, Graphics graphics)
        {
            graphics.Clear(BackColor);
            graph.Draw(graphics, nodeBackground, selectedNodeBrush, nodeText, connectionText, connectionLine, fontNode, fontConnection, graph_output.Width, graph_output.Height);
            graphics.DrawImage(graph.BitmapGraph, 0, 0);
        }

        private void picture_box_paint(object sender, PaintEventArgs e)
        {
            DrawGraphInt(graph, e.Graphics);
        }


    }
}
