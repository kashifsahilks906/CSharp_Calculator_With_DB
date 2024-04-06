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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class UpdateCal : Form
    {
        private int id = 0;
        private decimal FirstValue = 0.0m;
        private decimal SecondValue = 0.0m;
        private decimal Result = 0.0m;
        private string Operators = "";

        public UpdateCal()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            id          =   int.Parse(ID.Text);
            FirstValue  =   decimal.Parse(VALUE1.Text);
            if (!string.IsNullOrEmpty(VALUE2.Text))
                SecondValue = decimal.Parse(VALUE2.Text);
            else
                SecondValue = 0;
            Operators   =   Operator.Text;

            ;
            //check if ID exist or not
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-TQ0TFOO;Initial Catalog=Calculator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM Calculator WHERE ID = {id}", con);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if(count==0)
                { 
                    MessageBox.Show("ID not found!");
                    return;
                }
            }
            switch (Operators)
            {
                case "+":
                    Result = FirstValue + SecondValue;
                    break;
                case "-":
                    Result = FirstValue - SecondValue;
                    break;
                case "*":
                    Result = FirstValue * SecondValue;
                    break;
                case "/":
                    if (SecondValue != 0)
                        Result = FirstValue / SecondValue;
                    else
                    {
                        MessageBox.Show("Can't Update:Can't Divide by 0");
                        FirstValue = 0.0m;
                        SecondValue = 0.0m;
                        Operators = "";
                        return;
                    }
                    break;
                default:
                    if (Operators == "x²")
                        Result = FirstValue * FirstValue;
                    else if (Operators == "√")
                    {
                        if (FirstValue < 0)
                        {
                            MessageBox.Show("Undefined");
                            return;
                        }
                        else
                            Result = (decimal)Math.Sqrt((double)FirstValue);
                    }
                    else
                        MessageBox.Show($"{Operators} is Invalid!");
                    break;
            }

            //Saving in Database
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-TQ0TFOO;Initial Catalog=Calculator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Calculator set FirstValue=@FirstValue,SecondValue=@SecondValue,Operator=@Operator,Result=@Result where ID=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);  
                    cmd.Parameters.AddWithValue("@FirstValue", FirstValue);
                    if(Operators== "x²" || Operators == "√" )
                        cmd.Parameters.Add("@SecondValue", SqlDbType.Int).Value = DBNull.Value;
                    else 
                        cmd.Parameters.AddWithValue("@SecondValue", SecondValue);
                    cmd.Parameters.AddWithValue("@Operator", Operators);
                    cmd.Parameters.AddWithValue("@Result", Result);
                    cmd.ExecuteNonQuery();
                    con.Close();
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
            MessageBox.Show("Updated Successfully");
            this.Close();
        }

        //These all functions given below defined so user cannot write Alphabets in textbox
        private void ID_Press(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Value1_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Value2_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
