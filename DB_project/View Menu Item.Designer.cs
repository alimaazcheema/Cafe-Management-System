namespace DB_project
{
    partial class View_Menu_Item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.showitem_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(113)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 109);
            this.panel1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(280, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "View Menu Item";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.name_label.Location = new System.Drawing.Point(81, 167);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(330, 25);
            this.name_label.TabIndex = 43;
            this.name_label.Text = "Enter item name to view details ";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.name_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name_box.Location = new System.Drawing.Point(438, 167);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(202, 25);
            this.name_box.TabIndex = 44;
            this.name_box.Text = "Enter Name";
            this.name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // showitem_button
            // 
            this.showitem_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.showitem_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showitem_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.showitem_button.Location = new System.Drawing.Point(668, 167);
            this.showitem_button.Name = "showitem_button";
            this.showitem_button.Size = new System.Drawing.Size(94, 25);
            this.showitem_button.TabIndex = 62;
            this.showitem_button.Text = "Show Item";
            this.showitem_button.UseVisualStyleBackColor = false;
            this.showitem_button.Click += new System.EventHandler(this.showitem_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.dataGridView1.Location = new System.Drawing.Point(81, 226);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(681, 89);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.exit_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.exit_button.Location = new System.Drawing.Point(312, 358);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(202, 25);
            this.exit_button.TabIndex = 64;
            this.exit_button.Text = "Proceed back to Menu";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // View_Menu_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showitem_button);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.panel1);
            this.Name = "View_Menu_Item";
            this.Text = "View_Menu_Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label name_label;
        private TextBox name_box;
        private Button showitem_button;
        private DataGridView dataGridView1;
        private Button exit_button;
    }
}