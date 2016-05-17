

namespace GraphForm
{
    partial class main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_node_button = new System.Windows.Forms.Button();
            this.graph_output = new System.Windows.Forms.PictureBox();
            this.connection_weight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shortest_way_label = new System.Windows.Forms.Label();
            this.create_connection_rbtn = new System.Windows.Forms.RadioButton();
            this.find_shortest_way_rbtn = new System.Windows.Forms.RadioButton();
            this.clear_highlights_btn = new System.Windows.Forms.Button();
            this.clear_graph_btn = new System.Windows.Forms.Button();
            this.add_element_tb = new System.Windows.Forms.TextBox();
            this.find_node_min_summ_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graph_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connection_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // add_node_button
            // 
            this.add_node_button.Location = new System.Drawing.Point(239, 54);
            this.add_node_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_node_button.Name = "add_node_button";
            this.add_node_button.Size = new System.Drawing.Size(112, 35);
            this.add_node_button.TabIndex = 2;
            this.add_node_button.Text = "Add";
            this.add_node_button.UseVisualStyleBackColor = true;
            this.add_node_button.Click += new System.EventHandler(this.add_node_button_Click);
            // 
            // graph_output
            // 
            this.graph_output.Location = new System.Drawing.Point(20, 158);
            this.graph_output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graph_output.Name = "graph_output";
            this.graph_output.Size = new System.Drawing.Size(1926, 840);
            this.graph_output.TabIndex = 4;
            this.graph_output.TabStop = false;
            this.graph_output.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_box_paint);
            this.graph_output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_down);
            this.graph_output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_move);
            this.graph_output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_up);
            // 
            // connection_weight
            // 
            this.connection_weight.Location = new System.Drawing.Point(747, 57);
            this.connection_weight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connection_weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.connection_weight.Name = "connection_weight";
            this.connection_weight.Size = new System.Drawing.Size(180, 26);
            this.connection_weight.TabIndex = 5;
            this.connection_weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add element and then drag it";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(936, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter weight here and then select two nodes to create connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(524, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose selection action";
            // 
            // shortest_way_label
            // 
            this.shortest_way_label.Location = new System.Drawing.Point(742, 97);
            this.shortest_way_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shortest_way_label.Name = "shortest_way_label";
            this.shortest_way_label.Size = new System.Drawing.Size(150, 22);
            this.shortest_way_label.TabIndex = 10;
            // 
            // create_connection_rbtn
            // 
            this.create_connection_rbtn.AutoSize = true;
            this.create_connection_rbtn.Location = new System.Drawing.Point(528, 57);
            this.create_connection_rbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_connection_rbtn.Name = "create_connection_rbtn";
            this.create_connection_rbtn.Size = new System.Drawing.Size(164, 24);
            this.create_connection_rbtn.TabIndex = 11;
            this.create_connection_rbtn.TabStop = true;
            this.create_connection_rbtn.Text = "Create connection";
            this.create_connection_rbtn.UseVisualStyleBackColor = true;
            // 
            // find_shortest_way_rbtn
            // 
            this.find_shortest_way_rbtn.AutoSize = true;
            this.find_shortest_way_rbtn.Location = new System.Drawing.Point(528, 92);
            this.find_shortest_way_rbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.find_shortest_way_rbtn.Name = "find_shortest_way_rbtn";
            this.find_shortest_way_rbtn.Size = new System.Drawing.Size(158, 24);
            this.find_shortest_way_rbtn.TabIndex = 12;
            this.find_shortest_way_rbtn.TabStop = true;
            this.find_shortest_way_rbtn.Text = "Find shortest way";
            this.find_shortest_way_rbtn.UseVisualStyleBackColor = true;
            // 
            // clear_highlights_btn
            // 
            this.clear_highlights_btn.Location = new System.Drawing.Point(1551, 54);
            this.clear_highlights_btn.Name = "clear_highlights_btn";
            this.clear_highlights_btn.Size = new System.Drawing.Size(177, 30);
            this.clear_highlights_btn.TabIndex = 13;
            this.clear_highlights_btn.Text = "Clear highlights";
            this.clear_highlights_btn.UseVisualStyleBackColor = true;
            this.clear_highlights_btn.Click += new System.EventHandler(this.clear_highlights_btn_Click);
            // 
            // clear_graph_btn
            // 
            this.clear_graph_btn.Location = new System.Drawing.Point(1747, 54);
            this.clear_graph_btn.Name = "clear_graph_btn";
            this.clear_graph_btn.Size = new System.Drawing.Size(110, 30);
            this.clear_graph_btn.TabIndex = 14;
            this.clear_graph_btn.Text = "Clear graph";
            this.clear_graph_btn.UseVisualStyleBackColor = true;
            this.clear_graph_btn.Click += new System.EventHandler(this.clear_graph_btn_Click);
            // 
            // add_element_tb
            // 
            this.add_element_tb.Location = new System.Drawing.Point(22, 57);
            this.add_element_tb.Name = "add_element_tb";
            this.add_element_tb.Size = new System.Drawing.Size(210, 26);
            this.add_element_tb.TabIndex = 15;
            // 
            // find_node_min_summ_btn
            // 
            this.find_node_min_summ_btn.Location = new System.Drawing.Point(1551, 97);
            this.find_node_min_summ_btn.Name = "find_node_min_summ_btn";
            this.find_node_min_summ_btn.Size = new System.Drawing.Size(306, 33);
            this.find_node_min_summ_btn.TabIndex = 16;
            this.find_node_min_summ_btn.Text = "Find node with min summ of length";
            this.find_node_min_summ_btn.UseVisualStyleBackColor = true;
            this.find_node_min_summ_btn.Click += new System.EventHandler(this.find_node_min_summ_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1017);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.find_node_min_summ_btn);
            this.Controls.Add(this.add_element_tb);
            this.Controls.Add(this.clear_graph_btn);
            this.Controls.Add(this.clear_highlights_btn);
            this.Controls.Add(this.find_shortest_way_rbtn);
            this.Controls.Add(this.create_connection_rbtn);
            this.Controls.Add(this.shortest_way_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connection_weight);
            this.Controls.Add(this.graph_output);
            this.Controls.Add(this.add_node_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_form";
            this.Text = "Graph";
            this.SizeChanged += new System.EventHandler(this.main_form_size_changed);
            ((System.ComponentModel.ISupportInitialize)(this.graph_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connection_weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_node_button;
        private System.Windows.Forms.PictureBox graph_output;
        private System.Windows.Forms.NumericUpDown connection_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label shortest_way_label;
        private System.Windows.Forms.RadioButton create_connection_rbtn;
        private System.Windows.Forms.RadioButton find_shortest_way_rbtn;
        private System.Windows.Forms.Button clear_highlights_btn;
        private System.Windows.Forms.Button clear_graph_btn;
        private System.Windows.Forms.TextBox add_element_tb;
        private System.Windows.Forms.Button find_node_min_summ_btn;
        private System.Windows.Forms.Button button1;
    }
}

