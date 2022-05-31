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
    public partial class story : Form
    {
        SqlConnection con;
        SqlDataAdapter DA;
        SqlCommand command;

        public story()
        {
            InitializeComponent();
        }

        void kazanim()
        {
           
        }

        void agenda()
        {
            
        }
        private void ArchiveForm_Load(object sender, EventArgs e)
        {
            kazanim();
            agenda();
        }
    }
}
