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
            string role = "";

            string connect = "Data Source=DESKTOP-SMU66TS\\SQLEXPRESS01;Initial Catalog=eatly;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connect))
            {
                con.Open();

                string queryID = "SELECT Role FROM Userr WHERE username = @user AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(queryID, con))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    // Use ExecuteScalar safely with null check
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        role = result.ToString();

                        // Handle different roles
                        switch (role)
                        {
                            case "Customer":
                                this.Hide();
                                Customer_Menu cust = new Customer_Menu();
                                cust.Show();
                                break;

                            case "Cashier":
                                this.Hide();
                                Cashier_Menu cash = new Cashier_Menu();
                                cash.Show();
                                break;

                            case "Manager":
                                this.Hide();
                                Manager_Menu mgr = new Manager_Menu();
                                mgr.Show();
                                break;

                            default:
                                this.Hide();
                                Inventory_Manager_Menu inv = new Inventory_Manager_Menu();
                                inv.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
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
