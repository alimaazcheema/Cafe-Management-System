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
    public partial class View_Menu_Item : Form
    {
        public View_Menu_Item()
        {
            InitializeComponent();
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void showitem_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True"))
            {
                con.Open();

                string prodname = name_box.Text;

                string query = "select ItemID,Name,Description,Price,NutritionalInfo from MenuItem where name = @prodname";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@prodname", prodname);
               
                var reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;

                con.Close();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_Menu menu = new Manager_Menu();
            menu.Show();
        }
    }
}
