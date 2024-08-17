namespace GYM_YOUTUBE
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMember addmem = new AddMember(); 
            addmem.Show();
            this.Hide();
        }
    }
}
