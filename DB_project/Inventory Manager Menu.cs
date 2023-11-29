using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project
{
    public partial class Inventory_Manager_Menu : Form
    {
        public Inventory_Manager_Menu()
        {
            InitializeComponent();
        }

        private void update_item_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Inventory temp = new Update_Inventory();
            temp.Show();
        }

        private void view_item_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Inventory temp = new View_Inventory();
            temp.Show();
        }

        private void add_item_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Inventory temp = new Add_Inventory();
            temp.Show();
        }

        //private void delete_item_Click(object sender, EventArgs e)
        //{

        //}

        private void delete_item_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Inventory_Item temp = new Delete_Inventory_Item();
            temp.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome wel = new Welcome();
            wel.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
