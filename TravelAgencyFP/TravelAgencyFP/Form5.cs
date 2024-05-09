﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgencyFP
{
    public partial class Form5 : Form
    {
        private DataTable resultTable;
        private string filters = "";

        public Form5()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(Common.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ORDINAL_POSITION,COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Destination'", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable townsTable = new DataTable();

                adapter.Fill(townsTable);
                //columnsComboBox.DataSource = townsTable;
                columnsComboBox.DisplayMember = "COLUMN_NAME";
                columnsComboBox.ValueMember = "ORDINAL_POSITION";
                columnsComboBox.DataSource = townsTable;
                columnsComboBox.Enabled = true;
                filterTextBox.Enabled = false;
                //  columnsComboBox.SelectionChangeCommitted += columnsComboBox_SelectionChangeCommitted;
                filters = string.Empty;
                //columnsComboBox.SelectedIndexChanged += columnsComboBox_SelectedIndexChanged_1;
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Common.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Destination", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                resultTable = new DataTable();
                adapter.Fill(resultTable);
                dataGridView1.DataSource = resultTable;
            }
            filters = string.Empty;
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            andButton.Enabled = true;
            orButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Text = string.Empty;
            filters = string.Empty;
            filterTextBox.Enabled = false;
            andButton.Enabled = false;
            orButton.Enabled = false;
            columnsComboBox.Enabled = true;
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(""))
            {
                filters += " Like '%" + filterTextBox.Text + "%'";
                MessageBox.Show(filters);
                filters += " AND ";
                filterTextBox.Text = "";
                filterTextBox.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                columnsComboBox.Enabled = true;
            }
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(""))
            {
                filters += " Like '%" + filterTextBox.Text + "%'";
                MessageBox.Show(filters);
                filters += " OR ";
                filterTextBox.Text = "";
                filterTextBox.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                columnsComboBox.Enabled = true;
            }
        }

        private void columnsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filters += columnsComboBox.GetItemText(columnsComboBox.SelectedItem).Trim();
            columnsComboBox.Enabled = false;
            filterTextBox.Enabled = true;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(string.Empty))
            {
                filters += " Like '%" + filterTextBox.Text + "%'";
                MessageBox.Show(filters);
                DataView dv = resultTable.DefaultView;
                dv.RowFilter = filters;

                filterTextBox.Text = string.Empty;
                //filters = string.Empty;
                filterTextBox.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                columnsComboBox.Enabled = true;
            }
        }
    }
}
