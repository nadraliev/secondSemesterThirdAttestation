

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
            ((System.ComponentModel.ISupportInitialize)(this.graph_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_n_nud)).BeginInit();
            this.SuspendLayout();
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
            // shortest_way_label
            // 
            this.shortest_way_label.Location = new System.Drawing.Point(742, 97);
            this.shortest_way_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shortest_way_label.Name = "shortest_way_label";
            this.shortest_way_label.Size = new System.Drawing.Size(150, 22);
            this.shortest_way_label.TabIndex = 10;
            // 
            // clear_highlights_btn
            // 
            this.clear_highlights_btn.Location = new System.Drawing.Point(1551, 54);
            this.clear_highlights_btn.Name = "clear_highlights_btn";
            this.clear_highlights_btn.Size = new System.Drawing.Size(177, 29);
            this.clear_highlights_btn.TabIndex = 13;
            this.clear_highlights_btn.Text = "Clear highlights";
            this.clear_highlights_btn.UseVisualStyleBackColor = true;
            this.clear_highlights_btn.Click += new System.EventHandler(this.clear_highlights_btn_Click);
            // 
            // clear_graph_btn
            // 
            this.clear_graph_btn.Location = new System.Drawing.Point(1748, 54);
            this.clear_graph_btn.Name = "clear_graph_btn";
            this.clear_graph_btn.Size = new System.Drawing.Size(110, 29);
            this.clear_graph_btn.TabIndex = 14;
            this.clear_graph_btn.Text = "Clear graph";
            this.clear_graph_btn.UseVisualStyleBackColor = true;
            this.clear_graph_btn.Click += new System.EventHandler(this.clear_graph_btn_Click);
            // 
            // gen_field_btn
            // 
            this.gen_field_btn.Location = new System.Drawing.Point(468, 54);
            this.gen_field_btn.Name = "gen_field_btn";
            this.gen_field_btn.Size = new System.Drawing.Size(124, 42);
            this.gen_field_btn.TabIndex = 15;
            this.gen_field_btn.Text = "Generate field";
            this.gen_field_btn.UseVisualStyleBackColor = true;
            this.gen_field_btn.Click += new System.EventHandler(this.gen_field_btn_Click);
            // 
            // input_n_nud
            // 
            this.input_n_nud.Location = new System.Drawing.Point(304, 56);
            this.input_n_nud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.input_n_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.input_n_nud.Name = "input_n_nud";
            this.input_n_nud.Size = new System.Drawing.Size(120, 26);
            this.input_n_nud.TabIndex = 16;
            this.input_n_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1017);
            this.Controls.Add(this.input_n_nud);
            this.Controls.Add(this.gen_field_btn);
            this.Controls.Add(this.clear_graph_btn);
            this.Controls.Add(this.clear_highlights_btn);
            this.Controls.Add(this.shortest_way_label);
            this.Controls.Add(this.graph_output);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_form";
            this.Text = "Graph";
            this.SizeChanged += new System.EventHandler(this.main_form_size_changed);
            ((System.ComponentModel.ISupportInitialize)(this.graph_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_n_nud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox graph_output;
        private System.Windows.Forms.Label shortest_way_label;
        private System.Windows.Forms.Button clear_highlights_btn;
        private System.Windows.Forms.Button clear_graph_btn;
        private System.Windows.Forms.Button gen_field_btn;
        private System.Windows.Forms.NumericUpDown input_n_nud;
    }
}

