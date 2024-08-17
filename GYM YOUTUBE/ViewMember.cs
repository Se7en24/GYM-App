using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_YOUTUBE
{
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static readonly SqlConnection sqlConnection = new(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\LENOVO\Documents\GymDatabase.mdf;Integrated Security = True; Connect Timeout = 30");
        private readonly SqlConnection Con = sqlConnection;

        private void populate()
        {
            Con.Open();
            string query = "select * from Membertbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MembersList.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();  
            log.Show();
            this.Hide();
        }
    }
}
