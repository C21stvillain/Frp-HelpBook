using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Plan_Maker
{
    public partial class SettingsForm : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter DA;
        
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            if ( comboBox6.Text == "Yumurta")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into skillss(yskills) VALUES (@yskills);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@yskills", textBox3.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox3.Clear();
            }
            if (comboBox6.Text == "Cabbar")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into skillss(cskills) VALUES (@cskills);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@cskills", textBox3.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox3.Clear();
            }
            if (comboBox6.Text == "Agenya")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into skillss(askills) VALUES (@askills);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@askills", textBox3.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox3.Clear();
            }
            if (comboBox6.Text == "Sirius")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into skillss(sskills) VALUES (@sskills);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@sskills", textBox3.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox3.Clear();
            }
            if (comboBox6.Text == "Universe")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into skillss(uskills) VALUES (@uskills);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@uskills", textBox3.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox3.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sil = "DELETE FROM skillss";
                command = new SqlCommand(sil, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Yumurta")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into itemsss(yitems) VALUES (@yitems);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@yitems", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox4.Text == "Cabbar")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into itemsss(citems) VALUES (@citems);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@citems", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox4.Text == "Agenya")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into itemsss(aitems) VALUES (@aitems);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@aitems", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox4.Text == "Sirius")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into itemsss(sitems) VALUES (@sitems);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@sitems", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox4.Text == "Universe")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into itemsss(uitems) VALUES (@uitems);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@uitems", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Yumurta")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into eknott(yeknot) VALUES (@yeknot);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@yeknot", textBox4.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox4.Clear();
            }
            if (comboBox3.Text == "Cabbar")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into eknott(ceknot) VALUES (@ceknot);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@ceknot", textBox4.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox4.Clear();
            }
            if (comboBox3.Text == "Agenya")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into eknott(aeknot) VALUES (@aeknot);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@aeknot", textBox4.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox4.Clear();
            }
            if (comboBox3.Text == "Sirius")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into eknott(seknot) VALUES (@seknot);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@seknot", textBox4.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox4.Clear();
            }
            if (comboBox3.Text == "Universe")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into eknott(ueknot) VALUES (@ueknot);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@ueknot", textBox4.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox4.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
            string sil = "DELETE FROM eknott";
            command = new SqlCommand(sil, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
            string sil = "DELETE FROM itemsss";
            command = new SqlCommand(sil, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
