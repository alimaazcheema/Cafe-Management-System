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
    public partial class Update_Menu_Item : Form
    {
        public Update_Menu_Item()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_Menu menu = new Manager_Menu();
            menu.Show(); 
        }

        private void name1(object sender, MouseEventArgs e)
        {
            this.oldname.Text = "";
        }

        private void name2(object sender, MouseEventArgs e)
        {
            this.newname.Text = "";
        }

        private void desc(object sender, MouseEventArgs e)
        {
            this.desc_box.Text = "";
        }

        private void price(object sender, MouseEventArgs e)
        {
            this.price_box.Text = "";
        }

        private void info(object sender, MouseEventArgs e)
        {
            this.info_box.Text = "";
        }
    }
}
