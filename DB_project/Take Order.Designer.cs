namespace DB_project
{
    partial class Take_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(113)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 108);
            this.panel1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(315, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Take Order";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name.Location = new System.Drawing.Point(469, 131);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(202, 25);
            this.name.TabIndex = 67;
            this.name.Text = "Enter Name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.name_label.Location = new System.Drawing.Point(128, 131);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(185, 25);
            this.name_label.TabIndex = 66;
            this.name_label.Text = "Enter item name ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(469, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 25);
            this.textBox1.TabIndex = 69;
            this.textBox1.Text = "Enter Quantity";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(128, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Enter quantity";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.add_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.add_button.Location = new System.Drawing.Point(315, 245);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(138, 29);
            this.add_button.TabIndex = 77;
            this.add_button.Text = "Add another Item";
            this.add_button.UseVisualStyleBackColor = false;
            // 
            // Take_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.panel1);
            this.Name = "Take_Order";
            this.Text = "Take_Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private TextBox name;
        private Label name_label;
        private TextBox textBox1;
        private Label label1;
        private Button add_button;
    }
}