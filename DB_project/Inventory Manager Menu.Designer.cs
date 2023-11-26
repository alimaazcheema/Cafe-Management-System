namespace DB_project
{
    partial class Inventory_Manager_Menu
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
            this.delete_item = new System.Windows.Forms.Button();
            this.update_item = new System.Windows.Forms.Button();
            this.add_item = new System.Windows.Forms.Button();
            this.view_item = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(218, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Inventory Manager Menu";
            // 
            // delete_item
            // 
            this.delete_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.delete_item.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_item.Location = new System.Drawing.Point(411, 273);
            this.delete_item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_item.Name = "delete_item";
            this.delete_item.Size = new System.Drawing.Size(215, 57);
            this.delete_item.TabIndex = 46;
            this.delete_item.Text = "Delete Inventory Item";
            this.delete_item.UseVisualStyleBackColor = false;
            this.delete_item.Click += new System.EventHandler(this.delete_item_Click);
            // 
            // update_item
            // 
            this.update_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.update_item.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update_item.Location = new System.Drawing.Point(178, 273);
            this.update_item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_item.Name = "update_item";
            this.update_item.Size = new System.Drawing.Size(215, 57);
            this.update_item.TabIndex = 45;
            this.update_item.Text = "Update Inventory Item";
            this.update_item.UseVisualStyleBackColor = false;
            this.update_item.Click += new System.EventHandler(this.update_item_Click);
            // 
            // add_item
            // 
            this.add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.add_item.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_item.Location = new System.Drawing.Point(411, 190);
            this.add_item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(215, 57);
            this.add_item.TabIndex = 44;
            this.add_item.Text = "Add Inventory Item";
            this.add_item.UseVisualStyleBackColor = false;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // view_item
            // 
            this.view_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.view_item.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_item.Location = new System.Drawing.Point(178, 190);
            this.view_item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.view_item.Name = "view_item";
            this.view_item.Size = new System.Drawing.Size(215, 57);
            this.view_item.TabIndex = 43;
            this.view_item.Text = "View Inventory Item";
            this.view_item.UseVisualStyleBackColor = false;
            this.view_item.Click += new System.EventHandler(this.view_item_Click);
            // 
            // Inventory_Manager_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_item);
            this.Controls.Add(this.update_item);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.view_item);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory_Manager_Menu";
            this.Text = "Inventory_Manager_Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button delete_item;
        private Button update_item;
        private Button add_item;
        private Button view_item;
    }
}