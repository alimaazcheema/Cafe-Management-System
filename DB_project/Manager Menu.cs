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
    public partial class Manager_Menu : Form
    {
        public Manager_Menu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void add_menu(object sender, EventArgs e)
        {
            this.Hide();
            Add_Menu_Item menu_item = new Add_Menu_Item();
            menu_item.Show();
        }

        private void update_menu(object sender, EventArgs e)
        {
            this.Hide();
            Update_Menu_Item update = new Update_Menu_Item();
            update.Show();

        }

        private void delete_menu(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Menu_Item del = new Delete_Menu_Item();
            del.Show();
        }

        private void create_report(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void view_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Menu_Item men = new View_Menu_Item();
            men.Show();
        }
    }
}
