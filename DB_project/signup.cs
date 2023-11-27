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
            string role = roleBtn.Text;


            if (pass.Text != pass2.Text)
            {
                MessageBox.Show($"Passwords do not match");
            }
            else
            {


                // TODO: Add validation for required fields
                // connecting to sql and writing data in that
                string connect = "Data Source=DESKTOP-SMU66TS\\SQLEXPRESS01;Initial Catalog=eatly;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    string query;
                    string queryID;
                    int custID = 0;
                    int cashierID = 0;
                    int mgrID = 0;
                    int invmgrID = 0;
                    int userID = 0;

                    SqlCommand cm;


                    if (role == "Customer")
                    {
                        queryID = "select top 1 CustomerID from Customer order by CustomerID desc";
                         cm = new SqlCommand(queryID, con);
                        custID = Convert.ToInt32(cm.ExecuteScalar());

                        custID++;
                       
                        query = "INSERT INTO Customer (CustomerID,Fname, Lname, Username, Password, PhoneNumber) " +
                                "VALUES (@custID,@Fname, @Lname, @Username, @Password, @PhoneNumber);" +
                                "SELECT SCOPE_IDENTITY();";
                    }
                    else if (role == "Cashier")
                    {
                        queryID = "select top 1 CashierID from Cashier order by CashierID desc";
                         cm = new SqlCommand(queryID, con);
                        cashierID = Convert.ToInt32(cm.ExecuteScalar());
                        cashierID++;
                       
                        query = "INSERT INTO Cashier (CashierID,Fname, Lname, Username, Password, PhoneNumber) " +
                                "VALUES (@cashierID,@Fname, @Lname, @Username, @Password, @PhoneNumber);" +
                                "SELECT SCOPE_IDENTITY();";
                    }
                    else if (role == "Manager")
                    {
                        queryID = "select top 1 ManagerID from Manager order by ManagerID desc";
                         cm = new SqlCommand(queryID, con);
                        mgrID = Convert.ToInt32(cm.ExecuteScalar());
                        mgrID++;
                       
                        query = "INSERT INTO Manager (ManagerID,Fname, Lname, Username, Password, PhoneNumber) " +
                                "VALUES (@mgrID,@Fname, @Lname, @Username, @Password, @PhoneNumber);" +
                                "SELECT SCOPE_IDENTITY();";
                    }
                    else
                    {
                        queryID = "select top 1 ManagerID from InventoryManager order by ManagerID desc";
                         cm = new SqlCommand(queryID, con);
                        invmgrID = Convert.ToInt32(cm.ExecuteScalar());
                        invmgrID++;
                        
                        query = "INSERT INTO InventoryManager (ManagerID, Fname, Lname, Username, Password, PhoneNumber) " +
                                "VALUES (@invmgrID, @Fname, @Lname, @Username, @Password, @PhoneNumber);" +
                                "SELECT SCOPE_IDENTITY();";
                    }

                    queryID = "select top 1 UserID from Userr order by UserID desc";
                    cm = new SqlCommand(queryID, con);
                    userID = Convert.ToInt32(cm.ExecuteScalar());
                    userID++;

                    string queryyy;
                    // Insert into Userr table to get the generated userID
                    queryyy = "INSERT INTO Userr (UserID, Username, Password, Role) " +
                            "VALUES (@UserID, @Username, @Password, @Role);";

                    cm = new SqlCommand(queryyy, con);

                    // Set parameters for the Userr table
                    cm.Parameters.AddWithValue("@Userid", userID);
                    cm.Parameters.AddWithValue("@Username", username);
                    cm.Parameters.AddWithValue("@Password", password1);
                    cm.Parameters.AddWithValue("@Role", role);





                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@custID", custID);
                    cmd.Parameters.AddWithValue("@cashierID", cashierID);
                    cmd.Parameters.AddWithValue("@mgrID", mgrID);
                    cmd.Parameters.AddWithValue("@invmgrID", invmgrID);
                    //cmd.Parameters.AddWithValue("@Userid", userID);

                    cmd.Parameters.AddWithValue("@Fname", firstname);
                    cmd.Parameters.AddWithValue("@Lname", lastname);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password1);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                   // cmd.Parameters.AddWithValue("@Role", role);

                    // Use ExecuteScalar to get the generated identity value
                    int result = cmd.ExecuteNonQuery();
                    int result2 = cm.ExecuteNonQuery();

                    Console.WriteLine(result);

                    if (result > 0)
                    {
                        MessageBox.Show($"User added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
            }

            this.Hide();
            Login login = new Login();
            login.Show();
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
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
