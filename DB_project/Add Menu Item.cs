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
           

            string name = this.name.Text;
            string description = this.desc_box.Text;
            int price = Convert.ToInt32(this.price_box.Text);
            string information = this.info_box.Text;
            string ID = category_roleBtn.Text;
            int categoryID = Convert.ToInt32(ID[0])-48;

            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            con.Open();
            string query;
            query = "insert into MenuItem values(@name,@description,@price,@info,@categoryID)";

            SqlCommand cm = new SqlCommand(query, con);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@description", description);
            cm.Parameters.AddWithValue("@price", price);
            cm.Parameters.AddWithValue("@info", information);
            cm.Parameters.AddWithValue("@categoryID", categoryID);

            int result = cm.ExecuteNonQuery();

            if(result>0)
            {
                // MessageBox.Show($"");
                MessageBox.Show("Item added successfully.", "Success",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Hide();
                Manager_Menu menu = new Manager_Menu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Item not added.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Manager_Menu menu = new Manager_Menu();
                menu.Show();
            }
            con.Close();

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
