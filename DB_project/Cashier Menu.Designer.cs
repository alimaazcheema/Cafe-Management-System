namespace DB_project
{
    partial class Cashier_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.delete_order = new System.Windows.Forms.Button();
            this.update_order = new System.Windows.Forms.Button();
            this.view_order = new System.Windows.Forms.Button();
            this.take_order = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(113)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logout_button);
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
            this.label6.Location = new System.Drawing.Point(294, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cashier Menu";
            // 
            // delete_order
            // 
            this.delete_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.delete_order.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_order.Location = new System.Drawing.Point(402, 269);
            this.delete_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_order.Name = "delete_order";
            this.delete_order.Size = new System.Drawing.Size(215, 57);
            this.delete_order.TabIndex = 50;
            this.delete_order.Text = "Delete Order";
            this.delete_order.UseVisualStyleBackColor = false;
            this.delete_order.Click += new System.EventHandler(this.delete_order_Click);
            // 
            // update_order
            // 
            this.update_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.update_order.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update_order.Location = new System.Drawing.Point(169, 269);
            this.update_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_order.Name = "update_order";
            this.update_order.Size = new System.Drawing.Size(215, 57);
            this.update_order.TabIndex = 49;
            this.update_order.Text = "Update Order";
            this.update_order.UseVisualStyleBackColor = false;
            this.update_order.Click += new System.EventHandler(this.update_order_Click);
            // 
            // view_order
            // 
            this.view_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.view_order.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_order.Location = new System.Drawing.Point(402, 186);
            this.view_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.view_order.Name = "view_order";
            this.view_order.Size = new System.Drawing.Size(215, 57);
            this.view_order.TabIndex = 48;
            this.view_order.Text = "View Order";
            this.view_order.UseVisualStyleBackColor = false;
            this.view_order.Click += new System.EventHandler(this.view_order_Click);
            // 
            // take_order
            // 
            this.take_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.take_order.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.take_order.Location = new System.Drawing.Point(169, 186);
            this.take_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.take_order.Name = "take_order";
            this.take_order.Size = new System.Drawing.Size(215, 57);
            this.take_order.TabIndex = 47;
            this.take_order.Text = "Take Order";
            this.take_order.UseVisualStyleBackColor = false;
            this.take_order.Click += new System.EventHandler(this.take_order_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(658, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.logout_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logout_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.logout_button.Location = new System.Drawing.Point(694, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(94, 25);
            this.logout_button.TabIndex = 65;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // Cashier_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_order);
            this.Controls.Add(this.update_order);
            this.Controls.Add(this.view_order);
            this.Controls.Add(this.take_order);
            this.Controls.Add(this.panel1);
            this.Name = "Cashier_Menu";
            this.Text = "Cashier_Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button delete_order;
        private Button update_order;
        private Button view_order;
        private Button take_order;
        private PictureBox pictureBox1;
        private Button logout_button;
    }
}