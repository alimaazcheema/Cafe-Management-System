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
    public partial class Customer_Menu : Form
    {
        public Customer_Menu()
        {
            InitializeComponent();
        }

        private void place_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Place_Order place= new Place_Order();
            place.Show();
        }

        private void view_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Order v= new View_Order();
            v.Show();
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
