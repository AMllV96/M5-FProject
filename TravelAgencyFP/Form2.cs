﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgencyFP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            UsernameErrorLabel.Visible = false;
            passwordMatchError.Visible = false;
            passwordErrorLabel.Visible = false;


            string password = passTextBox.Text;
            string Pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&?*])[A-Za-z0-9!@#$%_&?*]{8,}$";
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            if (Regex.IsMatch(usernameTextBox.Text, emailPattern))
            {
                if (Regex.IsMatch(password, Pattern))
                {
                    if (passTextBox.Text.Equals(confirmPassTextBox.Text))
                    {
                        // MessageBox.Show("Valid!");
                        string date = DateTime.Now.ToString();
                        string pass = passTextBox.Text;

                        hashPassword($"{pass}");
                        //MessageBox.Show(hashPassword(pass));
                        try
                        {
                            using (SqlConnection con = new SqlConnection(Common.connectionString))
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, role, DateReg) VALUES (@Username, @Password, @role, @DateReg)", con);

                                cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                                cmd.Parameters.AddWithValue("@Password", hashPassword($"{passTextBox.Text}{date}"));
                                cmd.Parameters.AddWithValue("@role", 1);
                                cmd.Parameters.AddWithValue("@DateReg", date);
                                cmd.ExecuteNonQuery();
                                Form3 form3 = new Form3();
                                form3.ShowDialog();
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("This email has already been signed up.");
                        }
                    }
                    else
                    {
                        passwordMatchError.Visible = true;
                    }
                }
                else
                {
                    passwordErrorLabel.Visible = true;
                }





                // MessageBox.Show("Record was inserted");

            }


            else
            {
                UsernameErrorLabel.Visible = true;
                // MessageBox.Show("Invalid!");

            }
        }

        string hashPassword(string pass)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(pass);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordMatchError_Click(object sender, EventArgs e)
        {

        }

        private void passwordErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
