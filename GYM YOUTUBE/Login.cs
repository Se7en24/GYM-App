namespace GYM_YOUTUBE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userid.Text = "";
            pswd.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(userid.Text =="" ||  pswd.Text =="")
            {
                MessageBox.Show("Credentials cannot be empty");
            }
            else if(userid.Text =="admin" &&  pswd.Text == "jinceaanudaivam")
                {
                    FrontPage frontPage = new FrontPage();
                    frontPage.Show();
                    this.Hide();
                }
            else
            {
                MessageBox.Show("Wrong Credentials!!");
            }
        }
    }
}
