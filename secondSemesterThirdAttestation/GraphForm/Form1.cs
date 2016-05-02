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
        private Graphics graphics;

        private int CircleDiameter = 40;

        private Font font = new Font("Arial", 16);

        public main_form()
        {
            InitializeComponent();
            graphics = main_panel.CreateGraphics();
            graph = new Graph<int>();
        }

        public void ResizeElements()
        {
            main_panel.Width = this.Width -30;
            main_panel.Height = this.Height - 30;
        }

        private void main_form_size_changed(object sender, EventArgs e)
        {
            ResizeElements();
        }

        private void add_node_button_Click(object sender, EventArgs e)  //depricated
        {
            if (graph == null) graph = new Graph<int>();
            graph.AddNode((int)input_number_numeric.Value);
            DrawNode(graph.Nodes.Last());
        }

        private void main_panel_mouse_click(object sender, MouseEventArgs eventArgs)    //depricated
        {
            for (int i =0; i < graph.Count; i++)
            {
                if (eventArgs.X - graph.Nodes[i].CoordX <= CircleDiameter-5 && eventArgs.Y - graph.Nodes[i].CoordY <= CircleDiameter-5 )
                {
                    graph.Nodes[i].IsSelected = !graph.Nodes[i].IsSelected; //TODO make sure there is only one selected node
                }
            }
            Draw();
        }

        private void Draw() //depricated
        {
            for (int i = 0; i < graph.Count; i++)
            {
                DrawNode(graph.Nodes[i]);
            }
        }

        private void DrawNode(GraphNode<int> node)  //depricated
        {
            graphics.DrawEllipse(Pens.Black, node.CoordX, node.CoordY, CircleDiameter, CircleDiameter);
            if (node.IsSelected)
                graphics.FillEllipse(Brushes.MediumPurple, node.CoordX, node.CoordY, CircleDiameter, CircleDiameter);
            else
                graphics.FillEllipse(Brushes.Purple, node.CoordX, node.CoordY, CircleDiameter, CircleDiameter);
            graphics.DrawString(node.Value.ToString(), font, Brushes.White, CircleDiameter / 4, CircleDiameter / 4);
        }
    }
}
