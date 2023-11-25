namespace DB_project
{
    partial class Welcome
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
            this.label2 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Button();
            this.Cashier = new System.Windows.Forms.Button();
            this.Manager = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(113)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 82);
            this.panel1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(288, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Welcome to EATLY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(381, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Continue as";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Customer
            // 
            this.Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.Customer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer.Location = new System.Drawing.Point(226, 210);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(188, 43);
            this.Customer.TabIndex = 35;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = false;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Cashier
            // 
            this.Cashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.Cashier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cashier.Location = new System.Drawing.Point(430, 210);
            this.Cashier.Name = "Cashier";
            this.Cashier.Size = new System.Drawing.Size(188, 43);
            this.Cashier.TabIndex = 36;
            this.Cashier.Text = "Cashier";
            this.Cashier.UseVisualStyleBackColor = false;
            this.Cashier.Click += new System.EventHandler(this.Cashier_Click);
            // 
            // Manager
            // 
            this.Manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.Manager.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manager.Location = new System.Drawing.Point(226, 272);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(188, 43);
            this.Manager.TabIndex = 37;
            this.Manager.Text = "Manager";
            this.Manager.UseVisualStyleBackColor = false;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.Inventory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Inventory.Location = new System.Drawing.Point(430, 272);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(188, 43);
            this.Inventory.TabIndex = 38;
            this.Inventory.Text = "Inventory Manager";
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.Cashier);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label2;
        private Button Customer;
        private Button Cashier;
        private Button Manager;
        private Button Inventory;
    }
}