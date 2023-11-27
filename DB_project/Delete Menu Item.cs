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
            this.Hide();
            Manager_Menu menu = new Manager_Menu();
            menu.Show();
        }

        private void name(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
        }
    }
}
