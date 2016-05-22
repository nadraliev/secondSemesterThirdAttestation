

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
            this.graph_output = new System.Windows.Forms.PictureBox();
            this.shortest_way_label = new System.Windows.Forms.Label();
            this.clear_highlights_btn = new System.Windows.Forms.Button();
            this.clear_graph_btn = new System.Windows.Forms.Button();
            this.gen_field_btn = new System.Windows.Forms.Button();
            this.input_n_nud = new System.Windows.Forms.NumericUpDown();
            this.check_btn = new System.Windows.Forms.Button();
            this.result_lbl = new System.Windows.Forms.Label();
            this.check_rbtn = new System.Windows.Forms.RadioButton();
            this.delete_connection_rbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_n_nud)).BeginInit();
            this.SuspendLayout();
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
            this.graph_output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_up);
            // 
            // shortest_way_label
            // 
            this.shortest_way_label.Location = new System.Drawing.Point(495, 63);
            this.shortest_way_label.Name = "shortest_way_label";
            this.shortest_way_label.Size = new System.Drawing.Size(100, 14);
            this.shortest_way_label.TabIndex = 10;
            // 
            // clear_highlights_btn
            // 
            this.clear_highlights_btn.Location = new System.Drawing.Point(1034, 35);
            this.clear_highlights_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clear_highlights_btn.Name = "clear_highlights_btn";
            this.clear_highlights_btn.Size = new System.Drawing.Size(118, 19);
            this.clear_highlights_btn.TabIndex = 13;
            this.clear_highlights_btn.Text = "Clear highlights";
            this.clear_highlights_btn.UseVisualStyleBackColor = true;
            this.clear_highlights_btn.Click += new System.EventHandler(this.clear_highlights_btn_Click);
            // 
            // clear_graph_btn
            // 
            this.clear_graph_btn.Location = new System.Drawing.Point(1165, 35);
            this.clear_graph_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clear_graph_btn.Name = "clear_graph_btn";
            this.clear_graph_btn.Size = new System.Drawing.Size(73, 19);
            this.clear_graph_btn.TabIndex = 14;
            this.clear_graph_btn.Text = "Clear graph";
            this.clear_graph_btn.UseVisualStyleBackColor = true;
            this.clear_graph_btn.Click += new System.EventHandler(this.clear_graph_btn_Click);
            // 
            // gen_field_btn
            // 
            this.gen_field_btn.Location = new System.Drawing.Point(312, 35);
            this.gen_field_btn.Margin = new System.Windows.Forms.Padding(2);
            this.gen_field_btn.Name = "gen_field_btn";
            this.gen_field_btn.Size = new System.Drawing.Size(83, 27);
            this.gen_field_btn.TabIndex = 15;
            this.gen_field_btn.Text = "Generate field";
            this.gen_field_btn.UseVisualStyleBackColor = true;
            this.gen_field_btn.Click += new System.EventHandler(this.gen_field_btn_Click);
            // 
            // input_n_nud
            // 
            this.input_n_nud.Location = new System.Drawing.Point(203, 36);
            this.input_n_nud.Margin = new System.Windows.Forms.Padding(2);
            this.input_n_nud.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.input_n_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.input_n_nud.Name = "input_n_nud";
            this.input_n_nud.Size = new System.Drawing.Size(80, 20);
            this.input_n_nud.TabIndex = 16;
            this.input_n_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(655, 37);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 17;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // result_lbl
            // 
            this.result_lbl.Location = new System.Drawing.Point(765, 39);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(100, 23);
            this.result_lbl.TabIndex = 18;
            // 
            // check_rbtn
            // 
            this.check_rbtn.AutoSize = true;
            this.check_rbtn.Location = new System.Drawing.Point(533, 38);
            this.check_rbtn.Name = "check_rbtn";
            this.check_rbtn.Size = new System.Drawing.Size(56, 17);
            this.check_rbtn.TabIndex = 19;
            this.check_rbtn.TabStop = true;
            this.check_rbtn.Text = "Check";
            this.check_rbtn.UseVisualStyleBackColor = true;
            // 
            // delete_connection_rbtn
            // 
            this.delete_connection_rbtn.AutoSize = true;
            this.delete_connection_rbtn.Location = new System.Drawing.Point(533, 63);
            this.delete_connection_rbtn.Name = "delete_connection_rbtn";
            this.delete_connection_rbtn.Size = new System.Drawing.Size(112, 17);
            this.delete_connection_rbtn.TabIndex = 20;
            this.delete_connection_rbtn.TabStop = true;
            this.delete_connection_rbtn.Text = "Delete connection";
            this.delete_connection_rbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(533, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Click \"Check\" or choose node and click \"Choose\" or choose two nodes";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_connection_rbtn);
            this.Controls.Add(this.check_rbtn);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.input_n_nud);
            this.Controls.Add(this.gen_field_btn);
            this.Controls.Add(this.clear_graph_btn);
            this.Controls.Add(this.clear_highlights_btn);
            this.Controls.Add(this.shortest_way_label);
            this.Controls.Add(this.graph_output);
            this.Name = "main_form";
            this.Text = "Graph";
            this.SizeChanged += new System.EventHandler(this.main_form_size_changed);
            ((System.ComponentModel.ISupportInitialize)(this.graph_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_n_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox graph_output;
        private System.Windows.Forms.Label shortest_way_label;
        private System.Windows.Forms.Button clear_highlights_btn;
        private System.Windows.Forms.Button clear_graph_btn;
        private System.Windows.Forms.Button gen_field_btn;
        private System.Windows.Forms.NumericUpDown input_n_nud;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.RadioButton check_rbtn;
        private System.Windows.Forms.RadioButton delete_connection_rbtn;
        private System.Windows.Forms.Label label1;
    }
}

