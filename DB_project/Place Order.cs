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
    public partial class Place_Order : Form
    {
        public Place_Order()
        {
            InitializeComponent();
        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string ID = comboBox.Text;
            int categoryID = Convert.ToInt32(ID[0]) - 48;

            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            //con.Open();
            string query;
            query = "select name from MenuItem where CategoryID=@categoryID";

            //SqlCommand cm = new SqlCommand(query, con);
            

            //int result = cm.ExecuteNonQuery();
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.Parameters.AddWithValue("@categoryID", categoryID);
            cm.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.ResetText();
            total_box.Clear();
            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            name.Text= text;
            string query = "select Price from MenuItem where Name = @text";
            
            
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.Parameters.AddWithValue("@text", text);
            cm.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            try
            {
                priceBox.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int64 quant =Int64.Parse(numericUpDown1.Value.ToString());
            Int64 price=Int64.Parse(priceBox.Text);

            total_box.Text=(quant*price).ToString();
        }
        int i;
        int total = 0;
        private void addtocart_button_Click(object sender, EventArgs e)
        {
            if (total_box.Text != "0" && total_box.Text != "")
            {
                i = dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = name.Text;
                dataGridView2.Rows[i].Cells[1].Value = priceBox.Text;
                dataGridView2.Rows[i].Cells[2].Value = numericUpDown1.Text;
                dataGridView2.Rows[i].Cells[3].Value = total_box.Text;

                
                total = total + int.Parse(total_box.Text);
                label_total.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Quantity cannot be 0.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int amt;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amt=int.Parse(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
            }
            catch
            {

            }
            total = total - amt;
            label_total.Text = "Rs. " + total;
        }
        private int getCustomerID()
        {
            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            con.Open();
            string query;
            string valueFromForm = SharedData.SharedVariable;
            query = "select CustomerID from Customer where Username = (select @valueFromForm as Username)";
            
            SqlCommand cm = new SqlCommand(query, con);
            cm.Parameters.AddWithValue("@valueFromForm", valueFromForm);
            int result = Convert.ToInt32(cm.ExecuteScalar());

            return result;
        }

        private int getOrderID()
        {
            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            con.Open();
            string query;
            query = "select top 1 OrderID from Orders order by OrderID desc ";

            SqlCommand cm = new SqlCommand(query, con);
            int result = Convert.ToInt32(cm.ExecuteScalar());

            return result;
        }

        private void completeorder_Click(object sender, EventArgs e)
        {
            int orderID = getOrderID();
            orderID++;
            SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-JL2TMLJA\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True");
            con.Open();
            string query;
            int amount = total;
            int CustomerID=getCustomerID();
            int CashierID = 1;
            query = "insert into Orders values(@orderID,@timev,@datev,@amount,@CustomerID,@CashierID)";

            SqlCommand cm = new SqlCommand(query, con);
            cm.Parameters.AddWithValue("@orderID", orderID);
            cm.Parameters.AddWithValue("@timev", DateTime.Now.TimeOfDay);
            cm.Parameters.AddWithValue("@datev", DateTime.Now.Date);
            cm.Parameters.AddWithValue("@amount", amount);
            cm.Parameters.AddWithValue("@CustomerID", CustomerID);
            cm.Parameters.AddWithValue("@CashierID", CashierID);

            int result = cm.ExecuteNonQuery();

        
            string query2;
            
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow)
                {
                    string value1 = row.Cells["Column1"].Value.ToString();
                    string value2 = row.Cells["Column2"].Value.ToString();
                    string value3 = row.Cells["Column3"].Value.ToString();


                    query2 = "insert into OrderItem values (@value1, @value2, @value3, @orderID)";

                    SqlCommand cm2 = new SqlCommand(query2, con);

                    cm2.Parameters.AddWithValue("@value1", value1);
                    cm2.Parameters.AddWithValue("@value2", value2);
                    cm2.Parameters.AddWithValue("@value3", value3);
                    cm2.Parameters.AddWithValue("@orderID", orderID);


                    int result2= cm2.ExecuteNonQuery();
                    
                }
            }

            MessageBox.Show("Order added successfully. Proceed to payment counter.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Hide();
            Customer_Menu menu = new Customer_Menu();
            menu.Show();
        }

        private void Place_Order_Load(object sender, EventArgs e)
        {

        }
    }
}

