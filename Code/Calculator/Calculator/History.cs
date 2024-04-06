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

namespace Calculator
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TQ0TFOO;Initial Catalog=Calculator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Calculator", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void FormClosedHandler()
        {
            LoadData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCal h1 = new DeleteCal();
            h1.ShowDialog();

            LoadData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCal h1 = new UpdateCal();
            h1.ShowDialog();
            LoadData();
        }
    }
}
