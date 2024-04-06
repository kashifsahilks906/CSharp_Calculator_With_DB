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
    public partial class DeleteCal : Form
    {
        private int id;
        public DeleteCal()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            id = int.Parse(ID.Text);
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-TQ0TFOO;Initial Catalog=Calculator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM Calculator WHERE ID = {id}", con);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("ID not found!");
                        con.Close();
                        return;
                    }
                    
                    cmd = new SqlCommand($"DELETE FROM Calculator WHERE ID = {id}", con);
                    cmd.ExecuteNonQuery();  

                    con.Close();
                    MessageBox.Show("ID Deleted Successfully");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL-related errors here
                MessageBox.Show("Error saving results to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the error for troubleshooting
                return;
            }
            catch (Exception ex)
            {
                // Handle other potential errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                // Consider logging the error for troubleshooting
            }

        }

        private void ID_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))    
                e.Handled = true;
        }
    }
}
