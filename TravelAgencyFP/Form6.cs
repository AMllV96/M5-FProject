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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Common.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Destination SET Country=@Country, City=@City, Location=@Location, Weather=@Weather, Busyness=@Busyness where DestinationID = @DestinationID", con);
            cmd.Parameters.AddWithValue("@Country", countryTextBox.Text);
            cmd.Parameters.AddWithValue("@City", cityTextBox.Text);
            cmd.Parameters.AddWithValue("@Location", locationTextBox.Text);
            cmd.Parameters.AddWithValue("@Weather", weatherTextBox.Text);
            cmd.Parameters.AddWithValue("@Busyness", busynessTextBox.Text);
            cmd.Parameters.AddWithValue("@DestinationID", int.Parse(idTextBox.Text));
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Record was updated.");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Common.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Destination (DestinationID, Country, City, Location, Weather, Busyness) VALUES (@DestinationID, @Country, @City, @Location, @Weather, @Busyness)", con);
            cmd.Parameters.AddWithValue("@Country", countryTextBox.Text);
            cmd.Parameters.AddWithValue("@City", cityTextBox.Text);
            cmd.Parameters.AddWithValue("@Location", locationTextBox.Text);
            cmd.Parameters.AddWithValue("@Weather", weatherTextBox.Text);
            cmd.Parameters.AddWithValue("@Busyness", busynessTextBox.Text);
            cmd.Parameters.AddWithValue("@DestinationID", int.Parse(idTextBox.Text));
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Record was inserted");

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
    }
}
