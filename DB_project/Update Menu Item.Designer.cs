namespace DB_project
{
    partial class Update_Menu_Item
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
            this.name_label = new System.Windows.Forms.Label();
            this.oldname = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.category_roleBtn = new System.Windows.Forms.ComboBox();
            this.info_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.desc_box = new System.Windows.Forms.TextBox();
            this.newname = new System.Windows.Forms.TextBox();
            this.category_label = new System.Windows.Forms.Label();
            this.nutritional_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(113)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 81);
            this.panel1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(243, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Update Menu Item";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.name_label.Location = new System.Drawing.Point(115, 108);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(177, 22);
            this.name_label.TabIndex = 42;
            this.name_label.Text = "Enter item to update";
            // 
            // oldname
            // 
            this.oldname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.oldname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.oldname.Location = new System.Drawing.Point(413, 108);
            this.oldname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldname.Name = "oldname";
            this.oldname.Size = new System.Drawing.Size(177, 21);
            this.oldname.TabIndex = 43;
            this.oldname.Text = "Enter Name";
            this.oldname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.name1);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.add_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.add_button.Location = new System.Drawing.Point(326, 357);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(82, 22);
            this.add_button.TabIndex = 61;
            this.add_button.Text = "Update Item";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // category_roleBtn
            // 
            this.category_roleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.category_roleBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.category_roleBtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.category_roleBtn.FormattingEnabled = true;
            this.category_roleBtn.Items.AddRange(new object[] {
            "1. Appetizer",
            "2. Main Course",
            "3. Dessert",
            "4. Side",
            "5. Beverage"});
            this.category_roleBtn.Location = new System.Drawing.Point(412, 313);
            this.category_roleBtn.Name = "category_roleBtn";
            this.category_roleBtn.Size = new System.Drawing.Size(177, 23);
            this.category_roleBtn.TabIndex = 60;
            this.category_roleBtn.Text = "Enter Category ID";
            // 
            // info_box
            // 
            this.info_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.info_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.info_box.Location = new System.Drawing.Point(412, 281);
            this.info_box.Name = "info_box";
            this.info_box.Size = new System.Drawing.Size(177, 21);
            this.info_box.TabIndex = 59;
            this.info_box.Text = "Enter Nutritional Information";
            this.info_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.info);
            // 
            // price_box
            // 
            this.price_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.price_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.price_box.Location = new System.Drawing.Point(412, 250);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(177, 21);
            this.price_box.TabIndex = 58;
            this.price_box.Text = "Enter Price";
            this.price_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.price);
            // 
            // desc_box
            // 
            this.desc_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.desc_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desc_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.desc_box.Location = new System.Drawing.Point(412, 217);
            this.desc_box.Name = "desc_box";
            this.desc_box.Size = new System.Drawing.Size(177, 21);
            this.desc_box.TabIndex = 57;
            this.desc_box.Text = "Enter Description";
            this.desc_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.desc_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.desc);
            // 
            // newname
            // 
            this.newname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.newname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.newname.Location = new System.Drawing.Point(412, 187);
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(177, 21);
            this.newname.TabIndex = 56;
            this.newname.Text = "Enter Name";
            this.newname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.name2);
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.category_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.category_label.Location = new System.Drawing.Point(115, 314);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(93, 19);
            this.category_label.TabIndex = 55;
            this.category_label.Text = "Category ID";
            // 
            // nutritional_label
            // 
            this.nutritional_label.AutoSize = true;
            this.nutritional_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nutritional_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.nutritional_label.Location = new System.Drawing.Point(115, 283);
            this.nutritional_label.Name = "nutritional_label";
            this.nutritional_label.Size = new System.Drawing.Size(163, 19);
            this.nutritional_label.TabIndex = 54;
            this.nutritional_label.Text = "Nutritional Information";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.price_label.Location = new System.Drawing.Point(115, 252);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(43, 19);
            this.price_label.TabIndex = 53;
            this.price_label.Text = "Price";
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.desc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.desc_label.Location = new System.Drawing.Point(115, 218);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(86, 19);
            this.desc_label.TabIndex = 52;
            this.desc_label.Text = "Description";
            // 
            // name_box
            // 
            this.name_box.AutoSize = true;
            this.name_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.name_box.Location = new System.Drawing.Point(115, 188);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(49, 19);
            this.name_box.TabIndex = 51;
            this.name_box.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(115, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Enter value(s) to update";
            // 
            // Update_Menu_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(700, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.category_roleBtn);
            this.Controls.Add(this.info_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.desc_box);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.nutritional_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.desc_label);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.oldname);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Update_Menu_Item";
            this.Text = "Update_Menu_Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label name_label;
        private TextBox oldname;
        private Button add_button;
        private ComboBox category_roleBtn;
        private TextBox info_box;
        private TextBox price_box;
        private TextBox desc_box;
        private TextBox newname;
        private Label category_label;
        private Label nutritional_label;
        private Label price_label;
        private Label desc_label;
        private Label name_box;
        private Label label1;
    }
}