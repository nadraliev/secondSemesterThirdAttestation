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
        private Brush blockedNodeBrush = Brushes.AliceBlue;
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
                            if (create_connection_rbtn.Checked)
                            {
                                //creating two-way connection
                                graph.AddConnection(graph.Selected, temp, 1);
                                graph.AddConnection(temp, graph.Selected, 1);
                            }
                            //---Main mathod for number 12----------------------------//
                            else if (check_rbtn.Checked)
                            {
                                bool result = false;
                                foreach (Connection<string> firstConnection in graph.Connections)
                                {
                                    if (!result)
                                    {

                                        foreach (Connection<string> secondConnection in graph.Connections)
                                        {
                                            if (!result)
                                            {
                                                if (!(secondConnection.Source == firstConnection.Source && secondConnection.Destination == firstConnection.Destination) &&
                                                    !(secondConnection.Source == firstConnection.Destination && secondConnection.Destination == firstConnection.Source))
                                                    foreach (Connection<string> thirdConnection in graph.Connections)
                                                    {
                                                        if (!result)
                                                        {
                                                            graph.ClearBlocks();
                                                            if ((!(secondConnection.Source == thirdConnection.Source && secondConnection.Destination == thirdConnection.Destination) &&
                                                                !(secondConnection.Source == thirdConnection.Destination && secondConnection.Destination == thirdConnection.Source)) 
                                                                &&
                                                                !(thirdConnection.Source == firstConnection.Source && thirdConnection.Destination == firstConnection.Destination) &&
                                                                !(thirdConnection.Source == firstConnection.Destination && thirdConnection.Destination == firstConnection.Source))
                                                            {
                                                                graph.BlockConnections(new List<Connection<string>>() { firstConnection, secondConnection, thirdConnection });
                                                                if (graph.Selected.FindShortestWay(graph, temp).Count == 0)
                                                                    result = true;
                                                            }
                                                        }
                                                    }
                                            }
                                        }
                                    }
                                }
                                if (result)
                                {
                                    result_lbl.Text = "Possible";
                                    graph_output.Refresh();
                                }
                                else result_lbl.Text = "Not possible";
                            }
                            //-------------------------------//
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
            graph.ClearBlocks();
            graph_output.Refresh();
        }

        private void clear_graph_btn_Click(object sender, EventArgs e)
        {
            graph = new Graph<string>();
            graph_output.Refresh();
        }

        private void add_node_button_Click(object sender, EventArgs e)
        {
            if (graph == null) graph = new Graph<string>();
            graph.AddNode(add_element_tb.Text);
            graph_output.Refresh();
        }

        private void find_node_min_summ_btn_Click(object sender, EventArgs e)
        {
            if (graph != null)
            {
                int min = int.MaxValue;
                int summ = 0;
                GraphNode<string> result = null;
                foreach (GraphNode<string> node in graph.Nodes)
                {
                    summ = 0;
                    foreach (GraphNode<string> secondNode in graph.Nodes)
                    {
                        summ += graph.FindWayLength(node.FindShortestWay(graph, secondNode));
                        graph.ClearVisits();
                    }
                    if (min >= summ)
                    {
                        result = node;
                        min = summ;
                    }
                }
                if (result != null) result.Highlighted = true;
                graph_output.Refresh();
            }
        }


        //------------------------------------------------------//


        public void DrawGraphInt(Graph<string> graph, Graphics graphics)
        {
            graphics.Clear(BackColor);
            Bitmap graphBitmap = DrawingGraph<string>.DrawGraph(graph, graphics, nodeBackground, selectedNodeBrush, highlightedNodeBrush, blockedNodeBrush, nodeText, connectionText, connectionLine, highlightedConnectionPen, fontNode, fontConnection, graph_output.Width, graph_output.Height);
            graphics.DrawImage(graphBitmap, 0, 0);
        }

        private void picture_box_paint(object sender, PaintEventArgs e)
        {
            DrawGraphInt(graph, e.Graphics);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void do_spin_Click(object sender, EventArgs e)
        {
            if (graph.Selected != null)
            {
                graph.Selected.Spin = 0;
                if (graph.DoSpin(graph.Selected))
                {
                    MessageBox.Show("Possible. Moving gears: " + graph.CountSpins());
                }
                else
                {
                    int deleted = 0;
                    do
                    {
                        foreach (GraphNode<string> node in graph.Nodes)
                        {
                            if (node.Jammed)
                            {
                                graph.RemoveNode(node);
                                break;
                            }
                        }
                        deleted++;
                    } while (!graph.DoSpin(graph.Selected));
                    MessageBox.Show("Impossible, need to delete " + deleted + " node");
                    graph_output.Refresh();
                }
                graph.ClearSpins();
            }
        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }
    }
}
