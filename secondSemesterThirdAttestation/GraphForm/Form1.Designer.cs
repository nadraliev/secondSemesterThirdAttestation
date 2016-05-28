

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
            this.check_rbtn = new System.Windows.Forms.RadioButton();
            this.clear_highlights_btn = new System.Windows.Forms.Button();
            this.clear_graph_btn = new System.Windows.Forms.Button();
            this.add_element_tb = new System.Windows.Forms.TextBox();
            this.result_lbl = new System.Windows.Forms.Label();
            this.do_spin_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graph_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connection_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // add_node_button
            // 
            this.add_node_button.Location = new System.Drawing.Point(159, 35);
            this.add_node_button.Name = "add_node_button";
            this.add_node_button.Size = new System.Drawing.Size(75, 23);
            this.add_node_button.TabIndex = 2;
            this.add_node_button.Text = "Add";
            this.add_node_button.UseVisualStyleBackColor = true;
            this.add_node_button.Click += new System.EventHandler(this.add_node_button_Click);
            // 
            // graph_output
            // 
            this.graph_output.Location = new System.Drawing.Point(13, 103);
            this.graph_output.Name = "graph_output";
            this.graph_output.Size = new System.Drawing.Size(1284, 546);
            this.graph_output.TabIndex = 4;
            this.graph_output.TabStop = false;
            this.graph_output.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_box_paint);
            this.graph_output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_down);
            this.graph_output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_move);
            this.graph_output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_up);
            // 
            // connection_weight
            // 
            this.connection_weight.Location = new System.Drawing.Point(498, 37);
            this.connection_weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.connection_weight.Name = "connection_weight";
            this.connection_weight.Size = new System.Drawing.Size(120, 20);
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
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add element and then drag it";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(624, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter weight here and then select two nodes to create connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(349, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose selection action";
            // 
            // shortest_way_label
            // 
            this.shortest_way_label.Location = new System.Drawing.Point(495, 63);
            this.shortest_way_label.Name = "shortest_way_label";
            this.shortest_way_label.Size = new System.Drawing.Size(100, 14);
            this.shortest_way_label.TabIndex = 10;
            // 
            // create_connection_rbtn
            // 
            this.create_connection_rbtn.AutoSize = true;
            this.create_connection_rbtn.Location = new System.Drawing.Point(352, 37);
            this.create_connection_rbtn.Name = "create_connection_rbtn";
            this.create_connection_rbtn.Size = new System.Drawing.Size(112, 17);
            this.create_connection_rbtn.TabIndex = 11;
            this.create_connection_rbtn.TabStop = true;
            this.create_connection_rbtn.Text = "Create connection";
            this.create_connection_rbtn.UseVisualStyleBackColor = true;
            // 
            // check_rbtn
            // 
            this.check_rbtn.AutoSize = true;
            this.check_rbtn.Location = new System.Drawing.Point(352, 60);
            this.check_rbtn.Name = "check_rbtn";
            this.check_rbtn.Size = new System.Drawing.Size(56, 17);
            this.check_rbtn.TabIndex = 12;
            this.check_rbtn.TabStop = true;
            this.check_rbtn.Text = "Check";
            this.check_rbtn.UseVisualStyleBackColor = true;
            // 
            // clear_highlights_btn
            // 
            this.clear_highlights_btn.Location = new System.Drawing.Point(1034, 33);
            this.clear_highlights_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clear_highlights_btn.Name = "clear_highlights_btn";
            this.clear_highlights_btn.Size = new System.Drawing.Size(118, 25);
            this.clear_highlights_btn.TabIndex = 13;
            this.clear_highlights_btn.Text = "Clear highlights";
            this.clear_highlights_btn.UseVisualStyleBackColor = true;
            this.clear_highlights_btn.Click += new System.EventHandler(this.clear_highlights_btn_Click);
            // 
            // clear_graph_btn
            // 
            this.clear_graph_btn.Location = new System.Drawing.Point(1156, 33);
            this.clear_graph_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clear_graph_btn.Name = "clear_graph_btn";
            this.clear_graph_btn.Size = new System.Drawing.Size(73, 24);
            this.clear_graph_btn.TabIndex = 14;
            this.clear_graph_btn.Text = "Clear graph";
            this.clear_graph_btn.UseVisualStyleBackColor = true;
            this.clear_graph_btn.Click += new System.EventHandler(this.clear_graph_btn_Click);
            // 
            // add_element_tb
            // 
            this.add_element_tb.Location = new System.Drawing.Point(15, 37);
            this.add_element_tb.Margin = new System.Windows.Forms.Padding(2);
            this.add_element_tb.Name = "add_element_tb";
            this.add_element_tb.Size = new System.Drawing.Size(141, 20);
            this.add_element_tb.TabIndex = 15;
            // 
            // result_lbl
            // 
            this.result_lbl.Location = new System.Drawing.Point(498, 64);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(100, 23);
            this.result_lbl.TabIndex = 16;
            // 
            // do_spin_btn
            // 
            this.do_spin_btn.Location = new System.Drawing.Point(954, 33);
            this.do_spin_btn.Name = "do_spin_btn";
            this.do_spin_btn.Size = new System.Drawing.Size(75, 25);
            this.do_spin_btn.TabIndex = 17;
            this.do_spin_btn.Text = "Do spin";
            this.do_spin_btn.UseVisualStyleBackColor = true;
            this.do_spin_btn.Click += new System.EventHandler(this.do_spin_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 661);
            this.Controls.Add(this.do_spin_btn);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.add_element_tb);
            this.Controls.Add(this.clear_graph_btn);
            this.Controls.Add(this.clear_highlights_btn);
            this.Controls.Add(this.check_rbtn);
            this.Controls.Add(this.create_connection_rbtn);
            this.Controls.Add(this.shortest_way_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connection_weight);
            this.Controls.Add(this.graph_output);
            this.Controls.Add(this.add_node_button);
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
        private System.Windows.Forms.RadioButton check_rbtn;
        private System.Windows.Forms.Button clear_highlights_btn;
        private System.Windows.Forms.Button clear_graph_btn;
        private System.Windows.Forms.TextBox add_element_tb;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.Button do_spin_btn;
    }
}

