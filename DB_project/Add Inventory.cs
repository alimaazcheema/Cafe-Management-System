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
    public partial class Add_Inventory : Form
    {
        public Add_Inventory()
        {
            InitializeComponent();
        }

        private void Add_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void price_label_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }


        private void namee(object sender, MouseEventArgs e)
        {
            this.name.Text = "";
        }

        private void quantity_click(object sender, MouseEventArgs e)
        {
            this.Quantity.Text = "";
        }

        private void price_click(object sender, MouseEventArgs e)
        {
            this.price.Text = "";
        }

        private void Vend(object sender, MouseEventArgs e)
        {
            this.VendorID.Text = "";
        }

        private void Mngr(object sender, MouseEventArgs e)
        {
            this.ManagerID.Text = "";
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            string name = this.name.Text;
            int price = Convert.ToInt32(this.price.Text);
            int quant = Convert.ToInt32(this.Quantity.Text);
            string Vendor = this.VendorID.Text;
            string manager = this.ManagerID.Text;


            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            con.Open();
            string query;
            query = "insert into InventoryItem values(@name,@price,@quant, @Vendor, @manager)";

            SqlCommand cm = new SqlCommand(query, con);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@price", price);
            cm.Parameters.AddWithValue("@quant", quant);
            cm.Parameters.AddWithValue("@Vendor", Vendor);
            cm.Parameters.AddWithValue("@manager", manager);

            int result = cm.ExecuteNonQuery();

            if (result > 0)
            {
                // MessageBox.Show($"");
                MessageBox.Show("Item added to inventory successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Item not added.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();


        
            this.Hide();
            Inventory_Manager_Menu menu = new Inventory_Manager_Menu();
            menu.Show();
        }
    }
}
