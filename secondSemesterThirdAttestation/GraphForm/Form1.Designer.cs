

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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_number_numeric)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_node_button);
            this.Controls.Add(this.input_number_numeric);
            this.Controls.Add(this.main_panel);
            this.Name = "main_form";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.main_form_size_changed);
            ((System.ComponentModel.ISupportInitialize)(this.input_number_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.NumericUpDown input_number_numeric;
        private System.Windows.Forms.Button add_node_button;
        private System.Windows.Forms.Label label1;
    }
}

