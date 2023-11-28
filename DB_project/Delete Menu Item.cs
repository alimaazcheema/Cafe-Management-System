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
    public partial class Delete_Menu_Item : Form
    {
        public Delete_Menu_Item()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;

            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            con.Open();
            string query;
            query = "Delete from MenuItem WHERE Name = @name";

            SqlCommand cm = new SqlCommand(query, con);
            cm.Parameters.AddWithValue("@name", name);

            int result = cm.ExecuteNonQuery();

            if (result > 0)
            {
                // MessageBox.Show($"");
                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                Manager_Menu menu = new Manager_Menu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Item not deleted.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Manager_Menu menu = new Manager_Menu();
                menu.Show();
            }
            con.Close();
        }

        private void name(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
