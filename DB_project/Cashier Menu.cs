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
    public partial class Cashier_Menu : Form
    {
        public Cashier_Menu()
        {
            InitializeComponent();
        }

        private void take_order_Click(object sender, EventArgs e)
        {

        }

        private void view_order_Click(object sender, EventArgs e)
        {

        }

        private void update_order_Click(object sender, EventArgs e)
        {

        }

        private void delete_order_Click(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome wel = new Welcome();
            wel.Show();
        }
    }
}
