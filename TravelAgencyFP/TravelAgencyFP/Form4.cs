using Microsoft.VisualBasic.ApplicationServices;
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

namespace TravelAgencyFP
{
    public partial class Form4 : Form
    {
        private User authenticatedUser;
        private DataTable resultTable;
        private int count;
        public Form4(User user)
        {
            InitializeComponent();
            authenticatedUser = user;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MessageBox.Show(authenticatedUser + "");

            using (SqlConnection con = new SqlConnection(Common.connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * from Profile where UserID = @UserID", con);
                cmd.Parameters.AddWithValue("@UserID", authenticatedUser.Id);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);
                if (resultTable.Rows.Count > 0)
                {
                    pictureBox1.Image = GetImage((byte[])resultTable.Rows[0]["Picture"]);
                    firstNameTextBox.Text = (string)resultTable.Rows[0]["FirstName"];
                    LastNameTextBox.Text = (string)resultTable.Rows[0]["FamilyName"];
                    countryTextBox.Text = (string)resultTable.Rows[0]["Country"];
                    string gender = (string)resultTable.Rows[0]["Gender"];
                    if (gender.Equals("male"))
                    {
                        maleRB.Checked = true;
                    }
                    else if (gender.Equals("female"))
                    {
                        femaleRB.Checked = true;
                    }
                }


            }


        }
        private Image GetImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            return Image.FromStream(ms);
        }


        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private byte[] savePhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderGB_Enter(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Common.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Profile VALUES (@UserID, @Picture, @FirstName, @FamilyName, @Country, @Gender)", con);//"INSERT INTO (photo) Photos VALUES (@photo)"
                    cmd.Parameters.AddWithValue("@UserID", authenticatedUser.Id);
                    cmd.Parameters.AddWithValue("@Picture", savePhoto());
                    cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@FamilyName", LastNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Country", countryTextBox.Text);
                    if (maleRB.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Gender", maleRB.Text);
                    }
                    else if (femaleRB.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Gender", femaleRB.Text);
                    }
                    else cmd.Parameters.AddWithValue("@Gender", "");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profile was saved");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error occurred. Please try again." + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error occurred. Please try again." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form5 form5 = new Form5();
            form5.ShowDialog();
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
