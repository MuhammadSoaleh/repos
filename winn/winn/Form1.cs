using OpenXmlPowerTools;
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

namespace winn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO forms (name, age, city, contact) VALUES (@name, @age, @city, @contact)";
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BVNQK11\\SQLEXPRESS;Initial Catalog=form;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters with values
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@age", txtage.Text);
                    cmd.Parameters.AddWithValue("@city", txtcity.Text);
                    cmd.Parameters.AddWithValue("@contact", txtcontact.Text);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Data inserted successfully!");
            }
        }
    }
}
