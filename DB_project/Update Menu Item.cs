using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_project
{
    public partial class Update_Menu_Item : Form
    {
        public Update_Menu_Item()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string prevname = this.oldname.Text;
            string name = this.newname.Text;
            string description = this.desc_box.Text;
            int price = Convert.ToInt32(this.price_box.Text);
            string information = this.info_box.Text;
            string ID = category_roleBtn.Text;
            int categoryID = Convert.ToInt32(ID[0]) - 48;

            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            con.Open();
            string query;
            query = "Update MenuItem SET Name = @name, Description = @description, Price = @price, NutritionalInfo = @information, CategoryID = @categoryID WHERE Name = @prevname";

            SqlCommand cm = new SqlCommand(query, con);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@description", description);
            cm.Parameters.AddWithValue("@price", price);
            cm.Parameters.AddWithValue("@information", information);
            cm.Parameters.AddWithValue("@categoryID", categoryID);
            cm.Parameters.AddWithValue("@prevname", prevname);

            int result = cm.ExecuteNonQuery();

            if (result > 0)
            {
                // MessageBox.Show($"");
                MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                Manager_Menu menu = new Manager_Menu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Item not updated.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Manager_Menu menu = new Manager_Menu();
                menu.Show();
            }
            con.Close();
        }

        private void name1(object sender, MouseEventArgs e)
        {
            this.oldname.Text = "";
        }

        private void name2(object sender, MouseEventArgs e)
        {
            this.newname.Text = "";
        }

        private void desc(object sender, MouseEventArgs e)
        {
            this.desc_box.Text = "";
        }

        private void price(object sender, MouseEventArgs e)
        {
            this.price_box.Text = "";
        }

        private void info(object sender, MouseEventArgs e)
        {
            this.info_box.Text = "";
        }
    }
}
