namespace DB_project
{
    partial class Update_Inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.vendor_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.quant_box = new System.Windows.Forms.TextBox();
            this.newname = new System.Windows.Forms.TextBox();
            this.nutritional_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.Label();
            this.oldname = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.mgr_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(278, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Update Inventory Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(131, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Enter value(s) to update";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.add_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.add_button.Location = new System.Drawing.Point(373, 497);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(94, 29);
            this.add_button.TabIndex = 76;
            this.add_button.Text = "Update Item";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // vendor_box
            // 
            this.vendor_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.vendor_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vendor_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.vendor_box.Location = new System.Drawing.Point(471, 379);
            this.vendor_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vendor_box.Name = "vendor_box";
            this.vendor_box.Size = new System.Drawing.Size(202, 25);
            this.vendor_box.TabIndex = 74;
            this.vendor_box.Text = "Enter VendorID";
            this.vendor_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vendor_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vendor);
            // 
            // price_box
            // 
            this.price_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.price_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.price_box.Location = new System.Drawing.Point(471, 307);
            this.price_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(202, 25);
            this.price_box.TabIndex = 73;
            this.price_box.Text = "Enter Price";
            this.price_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.price);
            // 
            // quant_box
            // 
            this.quant_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.quant_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quant_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.quant_box.Location = new System.Drawing.Point(471, 343);
            this.quant_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quant_box.Name = "quant_box";
            this.quant_box.Size = new System.Drawing.Size(202, 25);
            this.quant_box.TabIndex = 72;
            this.quant_box.Text = "Enter Quantity";
            this.quant_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quant_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.quantity);
            // 
            // newname
            // 
            this.newname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.newname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.newname.Location = new System.Drawing.Point(471, 271);
            this.newname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(202, 25);
            this.newname.TabIndex = 71;
            this.newname.Text = "Enter Name";
            this.newname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.name2);
            // 
            // nutritional_label
            // 
            this.nutritional_label.AutoSize = true;
            this.nutritional_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nutritional_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.nutritional_label.Location = new System.Drawing.Point(131, 381);
            this.nutritional_label.Name = "nutritional_label";
            this.nutritional_label.Size = new System.Drawing.Size(91, 23);
            this.nutritional_label.TabIndex = 69;
            this.nutritional_label.Text = "VendorID";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.price_label.Location = new System.Drawing.Point(131, 309);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(54, 23);
            this.price_label.TabIndex = 68;
            this.price_label.Text = "Price";
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.desc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.desc_label.Location = new System.Drawing.Point(131, 344);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(85, 23);
            this.desc_label.TabIndex = 67;
            this.desc_label.Text = "Quantity";
            // 
            // name_box
            // 
            this.name_box.AutoSize = true;
            this.name_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.name_box.Location = new System.Drawing.Point(131, 272);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(59, 23);
            this.name_box.TabIndex = 66;
            this.name_box.Text = "Name";
            // 
            // oldname
            // 
            this.oldname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.oldname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.oldname.Location = new System.Drawing.Point(472, 165);
            this.oldname.Name = "oldname";
            this.oldname.Size = new System.Drawing.Size(202, 25);
            this.oldname.TabIndex = 65;
            this.oldname.Text = "Enter Name";
            this.oldname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.name1);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.name_label.Location = new System.Drawing.Point(131, 165);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(220, 25);
            this.name_label.TabIndex = 64;
            this.name_label.Text = "Enter item to update";
            // 
            // mgr_box
            // 
            this.mgr_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.mgr_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mgr_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mgr_box.Location = new System.Drawing.Point(471, 415);
            this.mgr_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mgr_box.Name = "mgr_box";
            this.mgr_box.Size = new System.Drawing.Size(202, 25);
            this.mgr_box.TabIndex = 79;
            this.mgr_box.Text = "Enter ManagerID";
            this.mgr_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mgr_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.managerID);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(131, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "ManagerID";
            // 
            // Update_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.mgr_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.vendor_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.quant_box);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.nutritional_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.desc_label);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.oldname);
            this.Controls.Add(this.name_label);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Update_Inventory";
            this.Text = "Update_Inventory";
            this.Load += new System.EventHandler(this.Update_Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Button add_button;
        private TextBox vendor_box;
        private TextBox price_box;
        private TextBox quant_box;
        private TextBox newname;
        private Label nutritional_label;
        private Label price_label;
        private Label desc_label;
        private Label name_box;
        private TextBox oldname;
        private Label name_label;
        private TextBox mgr_box;
        private Label label2;
    }
}