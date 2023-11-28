namespace DB_project
{
    partial class Add_Inventory
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
            this.add_button = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.Label();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.Vendor = new System.Windows.Forms.Label();
            this.ManagerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(113)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 81);
            this.panel1.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(243, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add Inventory Item";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.add_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.add_button.Location = new System.Drawing.Point(306, 303);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(82, 22);
            this.add_button.TabIndex = 62;
            this.add_button.Text = "Add Item";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.Quantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Quantity.Location = new System.Drawing.Point(386, 184);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(177, 21);
            this.Quantity.TabIndex = 59;
            this.Quantity.Text = "Enter Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.quantity_click);
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.price.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.price.Location = new System.Drawing.Point(386, 150);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(177, 21);
            this.price.TabIndex = 58;
            this.price.Text = "Enter Price";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.price_click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name.Location = new System.Drawing.Point(386, 120);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(177, 21);
            this.name.TabIndex = 57;
            this.name.Text = "Enter Name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.namee);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.price_label.Location = new System.Drawing.Point(158, 186);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(67, 19);
            this.price_label.TabIndex = 54;
            this.price_label.Text = "Quantity";
            this.price_label.Click += new System.EventHandler(this.price_label_Click);
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.desc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.desc_label.Location = new System.Drawing.Point(158, 152);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(75, 19);
            this.desc_label.TabIndex = 53;
            this.desc_label.Text = "Unit Price";
            // 
            // name_box
            // 
            this.name_box.AutoSize = true;
            this.name_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.name_box.Location = new System.Drawing.Point(158, 122);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(49, 19);
            this.name_box.TabIndex = 52;
            this.name_box.Text = "Name";
            // 
            // VendorID
            // 
            this.VendorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.VendorID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VendorID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.VendorID.Location = new System.Drawing.Point(386, 220);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(177, 21);
            this.VendorID.TabIndex = 64;
            this.VendorID.Text = "Enter VendorID";
            this.VendorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VendorID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Vend);
            // 
            // Vendor
            // 
            this.Vendor.AutoSize = true;
            this.Vendor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Vendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.Vendor.Location = new System.Drawing.Point(158, 222);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(75, 19);
            this.Vendor.TabIndex = 63;
            this.Vendor.Text = "VendorID";
            // 
            // ManagerID
            // 
            this.ManagerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ManagerID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManagerID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ManagerID.Location = new System.Drawing.Point(386, 257);
            this.ManagerID.Name = "ManagerID";
            this.ManagerID.Size = new System.Drawing.Size(177, 21);
            this.ManagerID.TabIndex = 66;
            this.ManagerID.Text = "Enter ManagerID";
            this.ManagerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ManagerID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mngr);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(158, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "ManagerID";
            // 
            // Add_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.ManagerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.Vendor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.desc_label);
            this.Controls.Add(this.name_box);
            this.Name = "Add_Inventory";
            this.Text = "Add_Inventory";
            this.Load += new System.EventHandler(this.Add_Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button add_button;
        private TextBox Quantity;
        private TextBox price;
        private TextBox name;
        private Label price_label;
        private Label desc_label;
        private Label name_box;
        private TextBox VendorID;
        private Label Vendor;
        private TextBox ManagerID;
        private Label label1;
    }
}