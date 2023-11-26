namespace DB_project
{
    partial class Customer_Menu
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
            this.view_order = new System.Windows.Forms.Button();
            this.place_order = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(278, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer Menu";
            // 
            // view_order
            // 
            this.view_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.view_order.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_order.Location = new System.Drawing.Point(414, 233);
            this.view_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.view_order.Name = "view_order";
            this.view_order.Size = new System.Drawing.Size(215, 57);
            this.view_order.TabIndex = 50;
            this.view_order.Text = "View Order";
            this.view_order.UseVisualStyleBackColor = false;
            this.view_order.Click += new System.EventHandler(this.view_order_Click);
            // 
            // place_order
            // 
            this.place_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.place_order.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.place_order.Location = new System.Drawing.Point(181, 233);
            this.place_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.place_order.Name = "place_order";
            this.place_order.Size = new System.Drawing.Size(215, 57);
            this.place_order.TabIndex = 49;
            this.place_order.Text = "Place Order";
            this.place_order.UseVisualStyleBackColor = false;
            this.place_order.Click += new System.EventHandler(this.place_order_Click);
            // 
            // Customer_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_order);
            this.Controls.Add(this.place_order);
            this.Controls.Add(this.panel1);
            this.Name = "Customer_Menu";
            this.Text = "Customer_Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button view_order;
        private Button place_order;
    }
}