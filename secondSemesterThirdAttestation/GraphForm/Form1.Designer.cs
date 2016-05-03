

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
            this.input_number_numeric = new System.Windows.Forms.NumericUpDown();
            this.add_node_button = new System.Windows.Forms.Button();
            this.graph_output = new System.Windows.Forms.PictureBox();
            this.connection_weight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_number_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connection_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // input_number_numeric
            // 
            this.input_number_numeric.Location = new System.Drawing.Point(13, 12);
            this.input_number_numeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.input_number_numeric.Name = "input_number_numeric";
            this.input_number_numeric.Size = new System.Drawing.Size(120, 20);
            this.input_number_numeric.TabIndex = 1;
            // 
            // add_node_button
            // 
            this.add_node_button.Location = new System.Drawing.Point(159, 12);
            this.add_node_button.Name = "add_node_button";
            this.add_node_button.Size = new System.Drawing.Size(75, 23);
            this.add_node_button.TabIndex = 2;
            this.add_node_button.Text = "Add";
            this.add_node_button.UseVisualStyleBackColor = true;
            this.add_node_button.Click += new System.EventHandler(this.add_node_button_Click);
            // 
            // graph_output
            // 
            this.graph_output.Location = new System.Drawing.Point(13, 67);
            this.graph_output.Name = "graph_output";
            this.graph_output.Size = new System.Drawing.Size(1284, 582);
            this.graph_output.TabIndex = 4;
            this.graph_output.TabStop = false;
            this.graph_output.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_box_paint);
            this.graph_output.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_click);
            this.graph_output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_down);
            this.graph_output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_move);
            this.graph_output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graph_output_mouse_up);
            // 
            // connection_weight
            // 
            this.connection_weight.Location = new System.Drawing.Point(382, 15);
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
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add element and then drag it";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(379, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter weight here and then select two nodes to create connection";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connection_weight);
            this.Controls.Add(this.graph_output);
            this.Controls.Add(this.add_node_button);
            this.Controls.Add(this.input_number_numeric);
            this.Name = "main_form";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.main_form_size_changed);
            ((System.ComponentModel.ISupportInitialize)(this.input_number_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connection_weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown input_number_numeric;
        private System.Windows.Forms.Button add_node_button;
        private System.Windows.Forms.PictureBox graph_output;
        private System.Windows.Forms.NumericUpDown connection_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

