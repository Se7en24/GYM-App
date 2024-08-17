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
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void MembersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MembersList.Rows.Count - 1) // Ensure the user clicked a valid row
            {
                // Get the selected row using the RowIndex from the event args
                DataGridViewRow selectedRow = MembersList.Rows[e.RowIndex];

                // Set the text boxes with the values from the selected row
                key = Convert.ToInt32(selectedRow.Cells["Mid"].Value); // Correctly set key to the "Mid" value
                Nametb.Text = selectedRow.Cells["MName"].Value.ToString();
                Phonetb.Text = selectedRow.Cells["MPhone"].Value.ToString();
                GenderCb.Text = selectedRow.Cells["MGen"].Value.ToString();
                Agetb.Text = selectedRow.Cells["MAge"].Value.ToString();
                Amounttb.Text = selectedRow.Cells["MAmount"].Value.ToString();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Nametb.Text = "";
            Phonetb.Text = "";
            GenderCb.Text = "";
            Agetb.Text = "";
            Amounttb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("Select member to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Membertbl where Mid = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully deleted ");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
