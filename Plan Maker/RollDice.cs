using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Plan_Maker
{
    public partial class RollDice : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter DA;
        public RollDice()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string sil = "DELETE FROM yaplist";
            command = new SqlCommand(sil, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

      

        private void AnalForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string sorgu = "insert into yaplist(yapilcaklist) VALUES (@yapilcaklist);";
            command = new SqlCommand(sorgu, con);
            command.Parameters.AddWithValue("@yapilcaklist", richTextBox1.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox3.Text == "4")
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 5);
                richTextBox2.Text = dice.ToString();
            }
            if (comboBox3.Text == "6")
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                richTextBox2.Text = dice.ToString();
            }
            if (comboBox3.Text == "8")
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 9);
                richTextBox2.Text = dice.ToString();
            }
            if (comboBox3.Text == "10")
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 11);
                richTextBox2.Text = dice.ToString();
            }
            if (comboBox3.Text == "12")
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 13);
                richTextBox2.Text = dice.ToString();
            }
            if (comboBox3.Text == "20")
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 21);
                richTextBox2.Text = dice.ToString();
            }
        }
    }
}
