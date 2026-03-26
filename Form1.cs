namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string operand1 = string.Empty;
        private string operand2 = string.Empty;
        private bool isAdding;
        private bool startNewNumber = true;

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

            if (startNewNumber || txtResult.Text == "0")
            {
                txtResult.Text = digit;
                startNewNumber = false;
            }
            else
            {
                txtResult.Text += digit;
            }

            if (isAdding)
            {
                operand2 = txtResult.Text;
                txtExpress.Text = operand1 + " + " + operand2;
            }
            else
            {
                txtExpress.Text = txtResult.Text;
            }
        }

        private void OperatorButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (button.Text != "+")
            {
                txtExpress.Text = "+ example only";
                return;
            }

            operand1 = txtResult.Text;
            operand2 = string.Empty;
            isAdding = true;
            startNewNumber = true;
            txtExpress.Text = operand1 + " +";
        }

        private void EqualsButton_Click(object? sender, EventArgs e)
        {
            if (!isAdding || string.IsNullOrWhiteSpace(operand1))
            {
                return;
            }

            operand2 = txtResult.Text;

            int n1 = int.Parse(operand1);
            int n2 = int.Parse(operand2);

            txtExpress.Text = operand1 + " + " + operand2 + " =";
            txtResult.Text = (n1 + n2).ToString();

            operand1 = string.Empty;
            operand2 = string.Empty;
            isAdding = false;
            startNewNumber = true;
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void CeButton_Click(object? sender, EventArgs e)
        {
            txtResult.Text = "0";
            startNewNumber = true;

            if (isAdding)
            {
                operand2 = string.Empty;
                txtExpress.Text = operand1 + " +";
            }
            else
            {
                txtExpress.Text = string.Empty;
            }
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            if (startNewNumber || string.IsNullOrEmpty(txtResult.Text))
            {
                return;
            }

            if (txtResult.Text.Length == 1)
            {
                txtResult.Text = "0";
                startNewNumber = true;
            }
            else
            {
                txtResult.Text = txtResult.Text[..^1];
            }

            if (isAdding)
            {
                operand2 = txtResult.Text == "0" && startNewNumber ? string.Empty : txtResult.Text;
                txtExpress.Text = string.IsNullOrEmpty(operand2)
                    ? operand1 + " +"
                    : operand1 + " + " + operand2;
            }
            else
            {
                txtExpress.Text = txtResult.Text;
            }
        }

        private void DecimalButton_Click(object? sender, EventArgs e)
        {
        }

        private void SignButton_Click(object? sender, EventArgs e)
        {
        }

        private void ResetCalculator()
        {
            operand1 = string.Empty;
            operand2 = string.Empty;
            isAdding = false;
            startNewNumber = true;
            txtExpress.Text = string.Empty;
            txtResult.Text = "0";
        }
    }
}
