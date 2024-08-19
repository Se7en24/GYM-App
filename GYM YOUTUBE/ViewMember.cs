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
            MembersList.ReadOnly = true;
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrontPage frontPage = new FrontPage();
            frontPage.Show();
            this.Hide();
        }

        private void filterbyname()
        {
            if (string.IsNullOrWhiteSpace(Searchname.Text))
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            Con.Open();

            // Use parameterized query to prevent SQL injection
            string query = "select * from Membertbl where MName ='" + Searchname.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@searchName", "%" + Searchname.Text.Trim() + "%");

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            MembersList.DataSource = dt;
            Con.Close();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No records found for the entered name.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            filterbyname();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
            Searchname.Text = "";
        }
    }
}
