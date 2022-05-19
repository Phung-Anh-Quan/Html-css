using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace form_1
{
    public partial class FrmDn : Form
    {
        public FrmDn()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlDataReader reader;
        private string sqlstr;


        private void button1_Click(object sender, EventArgs e)
        {
            FrmQL quanly = new FrmQL();
            quanly.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDk dangky = new FrmDk ();
            dangky.Show();
            this.Hide();
        }
    }
}
