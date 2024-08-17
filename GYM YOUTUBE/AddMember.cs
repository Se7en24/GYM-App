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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GYM_YOUTUBE
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private static readonly SqlConnection sqlConnection = new(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\LENOVO\Documents\GymDatabase.mdf;Integrated Security = True; Connect Timeout = 30");
        private readonly SqlConnection Con = sqlConnection;


        private void AddMember_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (Nametb.Text == "" || Phonetb.Text == "" || Amounttb.Text == "" || Agetb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO Membertbl (MName, MPhone, MGen, MAge, MAmount) VALUES (@MName, @MPhone, @MGen, @MAge, @MAmount)";
                    SqlCommand cmd = new(query, Con);

                    // Add parameters with the correct column names
                    cmd.Parameters.AddWithValue("@MName", Nametb.Text);
                    cmd.Parameters.AddWithValue("@MPhone", Phonetb.Text);
                    cmd.Parameters.AddWithValue("@MGen", GenderCb.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@MAge", int.Parse(Agetb.Text));
                    cmd.Parameters.AddWithValue("@MAmount", int.Parse(Amounttb.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amounttb.Text = "";
            Phonetb.Text = "";
            Nametb.Text = "";
            Agetb.Text = "";
            GenderCb.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
