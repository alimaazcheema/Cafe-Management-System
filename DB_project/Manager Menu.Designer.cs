namespace DB_project
{
    partial class Manager_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.Create_Report = new System.Windows.Forms.Button();
            this.Delete_menu = new System.Windows.Forms.Button();
            this.Update_menu = new System.Windows.Forms.Button();
            this.Add_menu = new System.Windows.Forms.Button();
            this.view_menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(113)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.logout_button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 109);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(658, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(280, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manager Menu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.logout_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logout_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.logout_button.Location = new System.Drawing.Point(694, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(94, 25);
            this.logout_button.TabIndex = 63;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // Create_Report
            // 
            this.Create_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.Create_Report.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Create_Report.Location = new System.Drawing.Point(177, 325);
            this.Create_Report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Create_Report.Name = "Create_Report";
            this.Create_Report.Size = new System.Drawing.Size(215, 57);
            this.Create_Report.TabIndex = 42;
            this.Create_Report.Text = "View all Menu Items";
            this.Create_Report.UseVisualStyleBackColor = false;
            this.Create_Report.Click += new System.EventHandler(this.create_report);
            // 
            // Delete_menu
            // 
            this.Delete_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.Delete_menu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete_menu.Location = new System.Drawing.Point(177, 244);
            this.Delete_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete_menu.Name = "Delete_menu";
            this.Delete_menu.Size = new System.Drawing.Size(215, 57);
            this.Delete_menu.TabIndex = 41;
            this.Delete_menu.Text = "Delete Menu Item";
            this.Delete_menu.UseVisualStyleBackColor = false;
            this.Delete_menu.Click += new System.EventHandler(this.delete_menu);
            // 
            // Update_menu
            // 
            this.Update_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.Update_menu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Update_menu.Location = new System.Drawing.Point(413, 244);
            this.Update_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update_menu.Name = "Update_menu";
            this.Update_menu.Size = new System.Drawing.Size(215, 57);
            this.Update_menu.TabIndex = 40;
            this.Update_menu.Text = "Update Menu Item";
            this.Update_menu.UseVisualStyleBackColor = false;
            this.Update_menu.Click += new System.EventHandler(this.update_menu);
            // 
            // Add_menu
            // 
            this.Add_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.Add_menu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_menu.Location = new System.Drawing.Point(413, 163);
            this.Add_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_menu.Name = "Add_menu";
            this.Add_menu.Size = new System.Drawing.Size(215, 57);
            this.Add_menu.TabIndex = 39;
            this.Add_menu.Text = "Add Menu Item";
            this.Add_menu.UseVisualStyleBackColor = false;
            this.Add_menu.Click += new System.EventHandler(this.add_menu);
            // 
            // view_menu
            // 
            this.view_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.view_menu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_menu.Location = new System.Drawing.Point(177, 163);
            this.view_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.view_menu.Name = "view_menu";
            this.view_menu.Size = new System.Drawing.Size(215, 57);
            this.view_menu.TabIndex = 43;
            this.view_menu.Text = "View Menu Item";
            this.view_menu.UseVisualStyleBackColor = false;
            this.view_menu.Click += new System.EventHandler(this.view_menu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(413, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 57);
            this.button1.TabIndex = 44;
            this.button1.Text = "View all Employees";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manager_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view_menu);
            this.Controls.Add(this.Create_Report);
            this.Controls.Add(this.Delete_menu);
            this.Controls.Add(this.Update_menu);
            this.Controls.Add(this.Add_menu);
            this.Controls.Add(this.panel1);
            this.Name = "Manager_Menu";
            this.Text = "Manager_Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button Create_Report;
        private Button Delete_menu;
        private Button Update_menu;
        private Button Add_menu;
        private Button view_menu;
        private Button logout_button;
        private PictureBox pictureBox1;
        private Button button1;
    }
}