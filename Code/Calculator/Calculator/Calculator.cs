using System.CodeDom.Compiler;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal FirstValue = 0.0m;
        private decimal SecondValue = 0.0m;
        private decimal Result = 0.0m;
        private string Operators = "";
        public Calculator()
        {
            InitializeComponent();
        }
        //So User can't enter Alphabets in textbox
        private void TxtBox_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void zerobtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text != "0")
            {
                TxtBox.Text += "0";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FirstValue = 0.0m;
            SecondValue = 0.0m;
            Operators = "";
            TxtBox.Text = "0";
            ExpressionBtn.Clear();
        }
        private void SaveToDatabase()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-TQ0TFOO;Initial Catalog=Calculator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Calculator values(@FirstValue,@SecondValue,@Operator,@Result)", con);
                    cmd.Parameters.AddWithValue("@FirstValue", FirstValue);
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
            }
            catch (Exception ex)
            {
                // Handle other potential errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the error for troubleshooting
            }
        }
        private async void PerformOperation(string newOperator)
        {
            if (FirstValue == 0)
            {
                FirstValue = decimal.Parse(TxtBox.Text);
                TxtBox.Clear();
                Operators = newOperator;
                if (ExpressionBtn.Text == "")
                    ExpressionBtn.Text = FirstValue + Operators;
                else
                    ExpressionBtn.Text = ExpressionBtn.Text + FirstValue + Operators;
            }
            else
            {
                SecondValue = decimal.Parse(TxtBox.Text);

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
                            TxtBox.Text = "Error:Can't Divide by 0";
                            await Task.Delay(1000);
                            FirstValue = 0.0m;
                            SecondValue = 0.0m;
                            Operators = "";
                            TxtBox.Text = "0";
                            ExpressionBtn.Clear();
                            return;
                        }
                        break;
                    default:
                        break;
                }

                SaveToDatabase();

                Operators = newOperator;
                TxtBox.Clear();
                ExpressionBtn.Text = ExpressionBtn.Text + SecondValue + Operators;
                FirstValue = Result;
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("*");
        }

        private async void SquareBtn_Click(object sender, EventArgs e)
        {
            SecondValue = decimal.Parse(TxtBox.Text);
            decimal temp = SecondValue;
            SecondValue = SecondValue * SecondValue;

            //Saving in Database
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-TQ0TFOO;Initial Catalog=Calculator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Calculator values(@FirstValue,@SecondValue,@Operator,@Result)", con);
                    cmd.Parameters.AddWithValue("@FirstValue", temp);
                    cmd.Parameters.Add("@SecondValue", SqlDbType.Int).Value = DBNull.Value;
                    cmd.Parameters.AddWithValue("@Operator", "x²");
                    cmd.Parameters.AddWithValue("@Result", SecondValue);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL-related errors here
                MessageBox.Show("Error saving results to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the error for troubleshooting
            }
            catch (Exception ex)
            {
                // Handle other potential errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the error for troubleshooting
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
                        TxtBox.Text = "Error:Can't Divide by 0";
                        await Task.Delay(1000);
                        FirstValue = 0.0m;
                        SecondValue = 0.0m;
                        Operators = "";
                        TxtBox.Text = "0";
                        ExpressionBtn.Clear();
                        return;
                    }
                    break;
                default:
                    Result = SecondValue;
                    break;
            }
            if (FirstValue != 0)
                SaveToDatabase();

            FirstValue = 0.0m;
            SecondValue = 0.0m;
            Operators = "";
            TxtBox.Text = Result.ToString();
            ExpressionBtn.Clear();
        }

        private async void SquareRootBtn_Click(object sender, EventArgs e)
        {
            SecondValue = decimal.Parse(TxtBox.Text);
            if (SecondValue < 0)
            {
                TxtBox.Text = "Undefined";
                await Task.Delay(1000);
                TxtBox.Text = "0";
                return;
            }
            else
            {
                double temp = Math.Sqrt((double)SecondValue);

                //Saving in Database
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-TQ0TFOO;Initial Catalog=Calculator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Calculator values(@FirstValue,@SecondValue,@Operator,@Result)", con);
                        cmd.Parameters.AddWithValue("@FirstValue", SecondValue);
                        cmd.Parameters.Add("@SecondValue", SqlDbType.Int).Value = DBNull.Value;
                        cmd.Parameters.AddWithValue("@Operator", "√");
                        cmd.Parameters.AddWithValue("@Result", temp);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    // Handle SQL-related errors here
                    MessageBox.Show("Error saving results to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Consider logging the error for troubleshooting
                }
                catch (Exception ex)
                {
                    // Handle other potential errors
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Consider logging the error for troubleshooting
                }


                SecondValue = (decimal)temp;

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
                            TxtBox.Text = "Error:Can't Divide by 0";
                            await Task.Delay(1000);
                            FirstValue = 0.0m;
                            SecondValue = 0.0m;
                            Operators = "";
                            TxtBox.Text = "0";
                            ExpressionBtn.Clear();
                            return;
                        }
                        break;
                    default:
                        break;
                }

                if (FirstValue != 0)
                    SaveToDatabase();

                if (Operators == "")
                {
                    TxtBox.Text = SecondValue.ToString();
                    Result = SecondValue;
                }
                else
                    TxtBox.Text = Result.ToString();
                FirstValue = 0.0m;
                SecondValue = 0.0m;
                Operators = "";
                ExpressionBtn.Clear();
            }
        }

        private async void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (Operators)
            {
                case "+":
                    SecondValue = decimal.Parse(TxtBox.Text);
                    Result = FirstValue + SecondValue;
                    TxtBox.Text = Result.ToString();
                    break;
                case "-":
                    SecondValue = decimal.Parse(TxtBox.Text);
                    Result = FirstValue - SecondValue;
                    TxtBox.Text = Result.ToString();
                    break;
                case "/":
                    SecondValue = decimal.Parse(TxtBox.Text);
                    if (SecondValue != 0)
                    {
                        Result = FirstValue / SecondValue;
                        TxtBox.Text = Result.ToString();
                    }
                    else
                    {
                        TxtBox.Text = "Error:Can't Divide by 0";
                        await Task.Delay(1000);
                        FirstValue = 0.0m;
                        SecondValue = 0.0m;
                        Operators = "";
                        TxtBox.Text = "0";
                        ExpressionBtn.Clear();
                        return;
                    }
                    break;
                case "*":
                    SecondValue = decimal.Parse(TxtBox.Text);
                    Result = FirstValue * SecondValue;
                    TxtBox.Text = Result.ToString();
                    break;
            }

            SaveToDatabase();

            FirstValue = 0.0m;
            SecondValue = 0.0m;
            Operators = "";
            ExpressionBtn.Text="";
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (History h1 = new History())
            {
                h1.ShowDialog();
            }
            this.Show();
        }

        
    }
}
