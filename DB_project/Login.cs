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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.user.Text;
            string password = this.pass.Text;
            string role;
            string queryID;

            // string connect = "Data Source=DESKTOP-SMU66TS\\SQLEXPRESS01;Initial Catalog=eatly;Integrated Security=True";
            // SqlConnection con = new SqlConnection(connect);

            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");

            con.Open();

            SqlCommand cm; queryID = "select Role from Userr Where username = @user AND password = @pass";
            cm = new SqlCommand(queryID, con);
            role = cm.ExecuteScalar() as String;
            if (role == "Customer")
            {
                this.Hide();
                Customer_Menu cust = new Customer_Menu();
                cust.Show();
            }
            else if (role == "Cashier")
            {
                this.Hide();
                Cashier_Menu cash = new Cashier_Menu();
                cash.Show();
            }
            else if (role == "Manager")
            {
                this.Hide();
                Manager_Menu mgr = new Manager_Menu();
                mgr.Show();
            }
            else
            {
                this.Hide();
                Inventory_Manager_Menu Inv = new Inventory_Manager_Menu();
                Inv.Show();

                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup sign = new signup();
            sign.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void username(object sender, MouseEventArgs e)
        {
            this.user.Text = "";
        }

        private void password(object sender, MouseEventArgs e)
        {
            this.pass.Text = "";
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
