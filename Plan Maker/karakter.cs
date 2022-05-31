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
    public partial class karakter : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter DA;
        public karakter()
        {
            InitializeComponent();
        }

        private void CalenderForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yumurta")
            {
                void yskilgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT yskills FROM skillss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                }

                void yitemgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT yitems FROM itemsss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView3.DataSource = table;
                    con.Close();
                }
                void yeknotgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT yeknot FROM eknott", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView2.DataSource = table;
                    con.Close();
                }
                yitemgetir();
                yeknotgetir();
                yskilgetir();

            }

            if(comboBox1.Text == "Cabbar")
            {
                void cskilgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT cskills FROM skillss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                }

                void citemgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT citems FROM itemsss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView3.DataSource = table;
                    con.Close();
                }

                void ceknotgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT ceknot FROM eknott", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView2.DataSource = table;
                    con.Close();
                }
                ceknotgetir();
                cskilgetir();
                citemgetir();
            }
            if (comboBox1.Text == "Agenya")
            {
                void askilgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT askills FROM skillss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                }
                
                void aitemgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT aitems FROM itemsss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView3.DataSource = table;
                    con.Close();
                }
                void aeknotgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT aeknot FROM eknott", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView2.DataSource = table;
                    con.Close();
                }
                aeknotgetir();
                aitemgetir();
                askilgetir();
            }
            if (comboBox1.Text == "Sirius")
            {
                void sskilgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT sskills FROM skillss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                }
               
                void sitemgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT sitems FROM itemsss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView3.DataSource = table;
                    con.Close();
                }

                void seknokgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT seknot FROM eknott", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView2.DataSource = table;
                    con.Close();
                }
                seknokgetir();
                sitemgetir();
                sskilgetir();


                
            }
            if (comboBox1.Text == "Universe")
            {
                void uskilgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT uskills FROM skillss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                }
                
                void uitemgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT uitems FROM itemsss", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView3.DataSource = table;
                    con.Close();
                }
                void ueknotgetir()
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Frp Handbook\Plan Maker\frpdata.mdf;Integrated Security=True");
                    con.Open();
                    DA = new SqlDataAdapter("SELECT ueknot FROM eknott", con);
                    DataTable table = new DataTable();
                    DA.Fill(table);
                    dataGridView2.DataSource = table;
                    con.Close();
                }

                ueknotgetir();
                uskilgetir();
                uitemgetir();
                
            }
        }
    }
}
