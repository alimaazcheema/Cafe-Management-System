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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = this.Fname.Text;
            string lastname = this.Lname.Text;
            string username = this.user.Text;
            string password1 = this.pass.Text;
            string phoneNumber = this.number.Text;
            string role = this.role.Text;

            // TODO: Add validation for required fields

            string connect = "Data Source=DESKTOP-SMU66TS\\SQLEXPRESS01;Initial Catalog=eatly;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connect))
            {
                con.Open();
                string query;

                if (role == "Customer")
                {
                    query = "INSERT INTO Customer (Fname, Lname, Username, Password, PhoneNumber) " +
                            "VALUES (@Fname, @Lname, @Username, @Password, @PhoneNumber)";
                }
                else if (role == "Cashier")
                {
                    query = "INSERT INTO Cashier (Fname, Lname, Username, Password, PhoneNumber) " +
                            "VALUES (@Fname, @Lname, @Username, @Password, @PhoneNumber)";
                }
                else if (role == "Manager")
                {
                    query = "INSERT INTO Manager (Fname, Lname, Username, Password, PhoneNumber) " +
                            "VALUES (@Fname, @Lname, @Username, @Password, @PhoneNumber)";
                }
                else
                {
                    query = "INSERT INTO InventoryManager (Fname, Lname, Username, Password, PhoneNumber) " +
                            "VALUES (@Fname, @Lname, @Username, @Password, @PhoneNumber)";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Fname", firstname);
                    cmd.Parameters.AddWithValue("@Lname", lastname);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password1);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("User added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void fname_click(object sender, MouseEventArgs e)
        {
            this.Fname.Text = "";
        }

        private void lname(object sender, MouseEventArgs e)
        {
            this.Lname.Text = "";
        }


        private void username(object sender, MouseEventArgs e)
        {
            this.user.Text = "";
        }

        private void password1(object sender, MouseEventArgs e)
        {
            this.pass.Text = "";
        }

        private void password2(object sender, MouseEventArgs e)
        {
            this.pass2.Text = "";
        }

        private void phone(object sender, MouseEventArgs e)
        {
            this.number.Text = "";
        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log=new Login();
            log.Show();
        }
    }
}