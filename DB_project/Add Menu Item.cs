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
    public partial class Add_Menu_Item : Form
    {
        public Add_Menu_Item()
        {
            InitializeComponent();
        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void Add_Menu_Item_Load(object sender, EventArgs e)
        {

        }

        private void info_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void category_roleBtn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void desc_label_Click(object sender, EventArgs e)
        {

        }

        private void price_label_Click(object sender, EventArgs e)
        {

        }

        private void nutritional_label_Click(object sender, EventArgs e)
        {

        }

        private void category_label_Click(object sender, EventArgs e)
        {

        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_Menu mngr = new Manager_Menu();
            mngr.Show();
        }

        private void namee(object sender, MouseEventArgs e)
        {
            this.name.Text = "";
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
