namespace DB_project
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}