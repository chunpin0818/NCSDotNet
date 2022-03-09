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

namespace Q1___ADO.NET_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nCS2020DataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.nCS2020DataSet.Movie);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=NCS2020;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Movie SET actor_Id='" + textBox2.Text + "' ,movie_Name='" + textBox3.Text + "' ,movie_Year='" + textBox4.Text + "' WHERE movie_Id=" + textBox1.Text, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Records is Updated ! Please Display it Again !");
            }
            catch (Exception x)
            {
                MessageBox.Show("Not Updated \nReason: " + x.Message);
            }
            conn.Close();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=NCS2020;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Movie ON;INSERT INTO Movie(movie_Id, actor_Id, movie_Name, movie_Year) VALUES (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');SET IDENTITY_INSERT Movie OFF; ", conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Record is Inserted Sucessfully !");
            }
            catch (Exception x)
            {
                MessageBox.Show("Not Inserted \nReason: " + x.Message);
            }
            
            conn.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=NCS2020;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Movie WHERE movie_Id=" + textBox1.Text + " AND actor_Id='" + textBox2.Text + "' AND movie_Name='" + textBox3.Text + "' AND movie_Year='" + textBox4.Text+"';",conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Records is Deleted ! Please Display it Again !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Not Deleted \nReason: " + x.Message);
            }
            conn.Close();
        }
    }
}
