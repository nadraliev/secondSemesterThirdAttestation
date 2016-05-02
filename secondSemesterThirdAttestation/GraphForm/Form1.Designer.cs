

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
            this.main_panel = new System.Windows.Forms.Panel();
            this.input_number_numeric = new System.Windows.Forms.NumericUpDown();
            this.add_node_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.input_number_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Location = new System.Drawing.Point(12, 67);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(732, 582);
            this.main_panel.TabIndex = 0;
            this.main_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_panel_mouse_click);
            // 
            // input_number_numeric
            // 
            this.input_number_numeric.Location = new System.Drawing.Point(13, 26);
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
            this.add_node_button.Location = new System.Drawing.Point(150, 22);
            this.add_node_button.Name = "add_node_button";
            this.add_node_button.Size = new System.Drawing.Size(75, 23);
            this.add_node_button.TabIndex = 2;
            this.add_node_button.Text = "Add";
            this.add_node_button.UseVisualStyleBackColor = true;
            this.add_node_button.Click += new System.EventHandler(this.add_node_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(768, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 582);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_box_paint);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_node_button);
            this.Controls.Add(this.input_number_numeric);
            this.Controls.Add(this.main_panel);
            this.Name = "main_form";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.main_form_size_changed);
            ((System.ComponentModel.ISupportInitialize)(this.input_number_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.NumericUpDown input_number_numeric;
        private System.Windows.Forms.Button add_node_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

