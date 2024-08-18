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

namespace GYM_YOUTUBE
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private static readonly SqlConnection sqlConnection = new(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\LENOVO\Documents\GymDatabase.mdf;Integrated Security = True; Connect Timeout = 30");
        private readonly SqlConnection Con = sqlConnection;

        private void FillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Mid, MName from Membertbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            NameCb.ValueMember = "Mid"; // Use the Pid (Mid) as the value
            NameCb.DisplayMember = "MName"; // Display the names
            NameCb.DataSource = dt;
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = @"
            SELECT P.PId, P.PMonth, M.MName as PMember, P.PAmount 
            FROM Paymentstbl P
            JOIN Membertbl M ON P.PMember = M.Mid";

            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            Paymentlist.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void filterbyname()
        {
            if (string.IsNullOrWhiteSpace(SearchName.Text))
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            Con.Open();

            // Use parameterized query to prevent SQL injection
            string query = @"
            SELECT P.PId, P.PMonth, M.MName as PMember, P.PAmount 
            FROM Paymentstbl P
            JOIN Membertbl M ON P.PMember = M.Mid
            WHERE M.MName LIKE @searchName";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@searchName", "%" + SearchName.Text.Trim() + "%");

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            Paymentlist.DataSource = dt;
            Con.Close();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No records found for the entered name.");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //Nametb.Text = "";
            Amounttb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrontPage frontPage = new FrontPage();
            frontPage.Show();
            this.Hide();
        }


        private void Payment_Load(object sender, EventArgs e)
        {
            Paymentlist.ReadOnly = true;
            FillName();
            populate();
            
        }

        int key = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameCb.Text == "" || Amounttb.Text == "")
            {
                MessageBox.Show("Choose a Member");
            }
            else
            {
                string payPeriod = Period.Value.Month.ToString() + Period.Value.Year.ToString();
                Con.Open();

                // Corrected query to check for existing payment
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Paymentstbl where PMember = '" + NameCb.SelectedValue.ToString() + "' and PMonth = '" + payPeriod + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already paid for this month");
                }
                else
                {
                    // Corrected INSERT query
                    string query = "insert into Paymentstbl (PMonth, PMember, PAmount) values('" + payPeriod + "','" + NameCb.Text + "'," + Amounttb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount paid successfully");
                }

                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filterbyname();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
            SearchName.Text = "";
        }

    }
}
