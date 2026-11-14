using System;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class frmBasicCalculator : Form
    {
        public frmBasicCalculator()
        {
            InitializeComponent();

            cmbOperator.Items.Add("+");
            cmbOperator.Items.Add("-");
            cmbOperator.Items.Add("*");
            cmbOperator.Items.Add("/");

            cmbOperator.SelectedIndex = 0;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1, num2, result = 0;

            if (float.TryParse(txtNum1.Text, out num1) &&
                float.TryParse(txtNum2.Text, out num2))
            {
                switch (cmbOperator.Text)
                {
                    case "+":
                        result = BasicComputation.Addition(num1, num2);
                        break;

                    case "-":
                        result = BasicComputation.Subtraction(num1, num2);
                        break;

                    case "*":
                        result = BasicComputation.Multiplication(num1, num2);
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }

                        result = BasicComputation.Division(num1, num2);
                        break;

                    default:
                        MessageBox.Show("Please select an operator.");
                        return;
                }

                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}