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
    public partial class Update_Inventory : Form
    {
        public Update_Inventory()
        {
            InitializeComponent();
        }

        private void Update_Inventory_Load(object sender, EventArgs e)
        {

        }


        private void name1(object sender, MouseEventArgs e)
        {
            this.oldname.Text = "";
        }

        private void name2(object sender, MouseEventArgs e)
        {
            this.newname.Text = "";
        }

        private void quantity(object sender, MouseEventArgs e)
        {
            this.quant_box.Text = "";
        }

        private void price(object sender, MouseEventArgs e)
        {
            this.price_box.Text = "";
        }

        private void vendor(object sender, MouseEventArgs e)
        {
            this.vendor_box.Text = "";
        }

        private void managerID(object sender, MouseEventArgs e)
        {
            this.mgr_box.Text = "";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string prevname = this.oldname.Text;
            string name = this.newname.Text;
            int price = Convert.ToInt32(this.price_box.Text);
            int quantity = Convert.ToInt32(this.quant_box.Text);
            string vendor = this.vendor_box.Text;
            string manager = this.mgr_box.Text;

            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            con.Open();
            string query;
            query = "Update MenuItem SET Name = @name, ,UnitPrice = @price, AvailableQuantity = @quantity, VendorID = @vendor, ManagerID = @manager "
                +"WHERE Name = @prevname";

            SqlCommand cm = new SqlCommand(query, con);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@price", price);
            cm.Parameters.AddWithValue("@quantity", quantity);
            cm.Parameters.AddWithValue("@vendor", vendor);
            cm.Parameters.AddWithValue("@manager", manager);
            cm.Parameters.AddWithValue("@prevname", prevname);

            int result = cm.ExecuteNonQuery();

            if (result > 0)
            {
                // MessageBox.Show($"");
                MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                Inventory_Manager_Menu menu = new Inventory_Manager_Menu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Item not updated.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Inventory_Manager_Menu menu = new Inventory_Manager_Menu();
                menu.Show();
            }
            con.Close();
        }
    }
}
