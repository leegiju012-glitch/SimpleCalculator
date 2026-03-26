namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string operand1 = string.Empty;
        private string operand2 = string.Empty;
        private string op = string.Empty;
        private bool isOperating;
        private bool startNewNumber = true;
        private bool hasCalculated;

        public Form1()
        {
            InitializeComponent();
            ResetCalculator();
        }

        private void DigitButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button || button.Tag is not string digit)
            {
                return;
            }

            if (hasCalculated)
            {
                ResetCalculator();
            }

            if (startNewNumber || txtResult.Text == "0")
            {
                txtResult.Text = digit;
                startNewNumber = false;
            }
            else
            {
                txtResult.Text += digit;
            }

            UpdateCurrentOperand();
            UpdateExpressionText();
        }

        private void OperatorButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (string.IsNullOrEmpty(operand1) || hasCalculated)
            {
                operand1 = txtResult.Text;
                hasCalculated = false;
            }

            op = button.Text;
            isOperating = true;
            startNewNumber = true;
            operand2 = string.Empty;
            UpdateExpressionText();
        }

        private void EqualsButton_Click(object? sender, EventArgs e)
        {
            if (!isOperating || string.IsNullOrWhiteSpace(operand1) || string.IsNullOrWhiteSpace(op))
            {
                return;
            }

            operand2 = txtResult.Text;

            int n1 = int.Parse(operand1);
            int n2 = int.Parse(operand2);
            int result;

            if (op == "+")
            {
                result = n1 + n2;
            }
            else if (op == "-")
            {
                result = n1 - n2;
            }
            else if (op == "x")
            {
                result = n1 * n2;
            }
            else
            {
                if (n2 == 0)
                {
                    ResetCalculator();
                    txtExpress.Text = "Cannot divide by zero.";
                    return;
                }

                result = n1 / n2;
            }

            txtExpress.Text = operand1 + " " + op + " " + operand2 + " = " + result;
            txtResult.Text = result.ToString();

            operand1 = txtResult.Text;
            operand2 = string.Empty;
            op = string.Empty;
            isOperating = false;
            startNewNumber = true;
            hasCalculated = true;
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void CeButton_Click(object? sender, EventArgs e)
        {
            if (hasCalculated)
            {
                ResetCalculator();
                return;
            }

            txtResult.Text = "0";
            startNewNumber = true;

            if (isOperating)
            {
                operand2 = string.Empty;
            }
            else
            {
                operand1 = string.Empty;
            }

            UpdateExpressionText();
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            if (hasCalculated || startNewNumber)
            {
                return;
            }

            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text[..^1];
            }
            else
            {
                txtResult.Text = "0";
                startNewNumber = true;
            }

            UpdateCurrentOperand();
            UpdateExpressionText();
        }

        private void DecimalButton_Click(object? sender, EventArgs e)
        {
        }

        private void SignButton_Click(object? sender, EventArgs e)
        {
        }

        private void UpdateCurrentOperand()
        {
            if (isOperating)
            {
                operand2 = txtResult.Text;
            }
            else
            {
                operand1 = txtResult.Text;
            }
        }

        private void UpdateExpressionText()
        {
            if (isOperating)
            {
                txtExpress.Text = string.IsNullOrEmpty(operand2)
                    ? operand1 + " " + op
                    : operand1 + " " + op + " " + operand2;
            }
            else
            {
                txtExpress.Text = startNewNumber && txtResult.Text == "0"
                    ? string.Empty
                    : txtResult.Text;
            }
        }

        private void ResetCalculator()
        {
            operand1 = string.Empty;
            operand2 = string.Empty;
            op = string.Empty;
            isOperating = false;
            startNewNumber = true;
            hasCalculated = false;
            txtExpress.Text = string.Empty;
            txtResult.Text = "0";
        }
    }
}
