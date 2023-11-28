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
    public partial class View_Inventory : Form
    {
        public View_Inventory()
        {
            InitializeComponent();
        }

        private void View_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory_Manager_Menu menu = new Inventory_Manager_Menu();
            menu.Show();
        }

        private void showitem_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True"))
            {
                con.Open();

                string query = "select ID,Name,UnitPrice,AvailableQuantity from InventoryItem";

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
