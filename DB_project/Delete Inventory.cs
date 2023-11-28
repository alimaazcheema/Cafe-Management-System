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
    public partial class Delete_Inventory_Item : Form
    {
        public Delete_Inventory_Item()
        {
            InitializeComponent();
        }

        private void Delete_Inevntory_Load(object sender, EventArgs e)
        {

        }

        private void name(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;

            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            con.Open();
            string query;
            query = "Delete from InventoryItem WHERE Name = @name";

            SqlCommand cm = new SqlCommand(query, con);
            cm.Parameters.AddWithValue("@name", name);

            int result = cm.ExecuteNonQuery();

            if (result > 0)
            {
                // MessageBox.Show($"");
                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                Inventory_Manager_Menu menu = new Inventory_Manager_Menu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Item not deleted.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Inventory_Manager_Menu menu = new Inventory_Manager_Menu();
                menu.Show();
            }
            con.Close();
        }
    }
}
