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
    public partial class View_Order : Form
    {
        public View_Order()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Menu menu = new Customer_Menu();
            menu.Show();
        }

        private void showorder_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True"))
            {
                con.Open();
                string orderID = name_box.Text;
                string query = "select * from (select  * from OrderView1) AS Subquery where OrderID = @orderID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@orderID", orderID);

                var reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;

                con.Close();
            }
        }
    }
}
