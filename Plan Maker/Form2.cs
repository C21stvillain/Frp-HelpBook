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

    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter DA;
       

        

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            void yppxGetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT yppx FROM paralar", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();

            }
            void cppxGetir()
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT cppx FROM paralar", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView2.DataSource = table;
                con.Close();




            }

            void appxGetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT appx FROM paralar", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView4.DataSource = table;
                con.Close();

            }
            void sppxGetir()
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT sppx FROM paralar", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView5.DataSource = table;
                con.Close();
            }

            void uppxGetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT uppx FROM paralar", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView6.DataSource = table;
                con.Close();
            }

            void ycangetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT ycan FROM cantabb", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView7.DataSource = table;
                con.Close();
            }
            void ccangetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT ccan FROM cantabb", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView8.DataSource = table;
                con.Close();
            }
            void acangetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT acan FROM cantabb", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView9.DataSource = table;
                con.Close();
            }
            void scangetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT scan FROM cantabb", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView10.DataSource = table;
                con.Close();
            }
            void ucangetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT ucan FROM cantabb", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView11.DataSource = table;
                con.Close();
            }
            void yarmorgetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT yarmor FROM armortab", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView16.DataSource = table;
                con.Close();
            }
            void carmorgetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT carmor FROM armortab", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView15.DataSource = table;
                con.Close();
            }
            void aarmorgetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT aarmor FROM armortab", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView14.DataSource = table;
                con.Close();
            }
            void sarmorgetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT sarmor FROM armortab", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView13.DataSource = table;
                con.Close();
            }
            void uarmorgetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT uarmor FROM armortab", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView12.DataSource = table;
                con.Close();
            }
            void totalparahesap()
            {
                //con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True"));
                //string earning = "UPDATE earningss SET earning = @earning";
                //command = new SqlCommand(earning, con);
                //command.Parameters.AddWithValue("@earning", Convert.ToInt32(textBox1.Text));
                //con.Open();
                //command.ExecuteNonQuery();
                //con.Close();
                //string total = "UPDATE earningss SET total +=@earning";
                //command = new SqlCommand(total, con);
                //command.Parameters.AddWithValue("@earning", Convert.ToInt32(textBox1.Text));
                //con.Open();
                //command.ExecuteNonQuery();
                //con.Close();
            }
            void totalparagetir()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                con.Open();
                DA = new SqlDataAdapter("SELECT totalx FROM paralar", con);
                DataTable table = new DataTable();
                DA.Fill(table);
                dataGridView6.DataSource = table;
                con.Close();
            }
            yppxGetir();
            cppxGetir();
            appxGetir();
            sppxGetir();
            uppxGetir();
            ycangetir();
            ccangetir();
            acangetir();
            scangetir();
            ucangetir();
            yarmorgetir();
            carmorgetir();
            aarmorgetir();
            sarmorgetir();
            uarmorgetir();
            totalparahesap();
            totalparagetir();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Emre" && comboBox2.Text == "para")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into paralar(yppx) VALUES (@yppx);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@yppx", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Emre" && comboBox2.Text == "hp")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into cantabb(ycan) VALUES (@ycan);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@ycan", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Emre" && comboBox2.Text == "armor")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into armortab(yarmor) VALUES (@yarmor);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@yarmor", Convert.ToInt32(textBox1.Text));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Ersin" && comboBox2.Text == "para")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into paralar(cppx) VALUES (@cppx);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@cppx", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }

            if (comboBox1.Text == "Ersin" && comboBox2.Text == "hp")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into cantabb(ccan) VALUES (@ccan);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@ccan", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Ersin" && comboBox2.Text == "armor")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into armortab(carmor) VALUES (@carmor);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@carmor", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Efe" && comboBox2.Text == "para")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into paralar(appx) VALUES (@appx);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@appx", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Efe" && comboBox2.Text == "hp")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into cantabb(acan) VALUES (@acan);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@acan", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Efe" && comboBox2.Text == "armor")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into armortab(aarmor) VALUES (@aarmor);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@aarmor", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Anıl" && comboBox2.Text == "para")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into paralar(sppx) VALUES (@sppx);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@sppx", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Anıl" && comboBox2.Text == "hp")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into cantabb(scan) VALUES (@scan);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@scan", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Anıl" && comboBox2.Text == "armor")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into armortab(sarmor) VALUES (@sarmor);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@sarmor", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Özge" && comboBox2.Text == "paralar")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into paralar(uppx) VALUES (@uppx);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@uppx", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Özge" && comboBox2.Text == "hp")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into cantabb(scan) VALUES (@scan);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@scan", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
            if (comboBox1.Text == "Özge" && comboBox2.Text == "Armor")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                string sorgu = "insert into armortab(uarmor) VALUES (@uarmor);";
                command = new SqlCommand(sorgu, con);
                command.Parameters.AddWithValue("@uarmor", textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
            }
        }
            
        }
    }

