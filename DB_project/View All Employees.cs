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
    public partial class View_All_Employees : Form
    {
        public View_All_Employees()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_Menu menu = new Manager_Menu();
            menu.Show();
        }

        private void showitem_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True"))
            {
                con.Open();

                string query = "select * from EmployeeView1";

                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView2.DataSource = dataTable;

                con.Close();
            }
        }
    }
}
