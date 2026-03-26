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
        private int completedCalculations;
        private bool isHistoryVisible;

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

            if (hasCalculated && !isOperating)
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
            UpdateMessage("숫자를 입력하고 있습니다.");
        }

        private void OperatorButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (string.IsNullOrEmpty(op) && !isOperating)
            {
                operand1 = txtResult.Text;
            }
            else if (!startNewNumber && !string.IsNullOrWhiteSpace(operand1))
            {
                EvaluateCurrentExpression(false);
            }

            op = button.Text;
            isOperating = true;
            startNewNumber = true;
            hasCalculated = false;
            operand2 = string.Empty;
            UpdateExpressionText();
            UpdateMessage("연산자를 선택했습니다.");
        }

        private void EqualsButton_Click(object? sender, EventArgs e)
        {
            EvaluateCurrentExpression(true);
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            ResetCalculator();
            UpdateMessage("전체 내용을 초기화했습니다.");
        }

        private void CeButton_Click(object? sender, EventArgs e)
        {
            if (hasCalculated)
            {
                ResetCalculator();
                UpdateMessage("계산이 끝난 값을 지우고 다시 시작합니다.");
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
            UpdateMessage("마지막 피연산자를 통째로 지웠습니다.");
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
            UpdateMessage("마지막 숫자 한 자리를 지웠습니다.");
        }

        private void DecimalButton_Click(object? sender, EventArgs e)
        {
            if (hasCalculated && !isOperating)
            {
                ResetCalculator();
            }

            if (startNewNumber)
            {
                txtResult.Text = "0.";
                startNewNumber = false;
            }
            else if (!txtResult.Text.Contains('.'))
            {
                txtResult.Text += ".";
            }

            UpdateCurrentOperand();
            UpdateExpressionText();
            UpdateMessage("소수점을 입력했습니다.");
        }

        private void SignButton_Click(object? sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                return;
            }

            txtResult.Text = txtResult.Text.StartsWith("-")
                ? txtResult.Text[1..]
                : "-" + txtResult.Text;

            startNewNumber = false;
            UpdateCurrentOperand();
            UpdateExpressionText();
            UpdateMessage("부호를 전환했습니다.");
        }

        private void EvaluateCurrentExpression(bool finalResult)
        {
            if (!isOperating || string.IsNullOrWhiteSpace(operand1) || string.IsNullOrWhiteSpace(op))
            {
                return;
            }

            if (startNewNumber && string.IsNullOrEmpty(operand2))
            {
                return;
            }

            operand2 = txtResult.Text;

            decimal n1 = decimal.Parse(operand1);
            decimal n2 = decimal.Parse(operand2);
            decimal result;

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
                    UpdateMessage("그건 계산기도 곤란합니다");
                    return;
                }

                result = n1 / n2;
            }

            string expression = operand1 + " " + op + " " + operand2 + " = " + FormatNumber(result);

            txtExpress.Text = expression;
            txtResult.Text = FormatNumber(result);

            if (finalResult)
            {
                lstHistory.Items.Insert(0, expression);
                completedCalculations++;
                UpdateMessage(CreateFunMessage(n1, n2, result, op));
                hasCalculated = true;
                isOperating = false;
                op = string.Empty;
                operand1 = txtResult.Text;
                operand2 = string.Empty;
                startNewNumber = true;
            }
            else
            {
                operand1 = FormatNumber(result);
                operand2 = string.Empty;
                txtResult.Text = operand1;
                startNewNumber = true;
                hasCalculated = false;
            }
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

        private void UpdateMessage(string message)
        {
            lblMessage.Text = message;
        }

        private static string FormatNumber(decimal value)
        {
            return value.ToString("0.###############");
        }

        private string CreateFunMessage(decimal n1, decimal n2, decimal result, string currentOperator)
        {
            if (currentOperator == "÷" && n2 != 0 && result == decimal.Truncate(result))
            {
                return "공평하게 잘 나눠졌습니다";
            }

            if (result == 100)
            {
                return "100점짜리 계산입니다";
            }

            if (Math.Abs(n1) < 10 && Math.Abs(n2) < 10)
            {
                return "이정돈 암산 하시죠";
            }

            if (Math.Abs(n1) < 10 && Math.Abs(n2) < 10 && result < 20)
            {
                return "너무 쉬운 거 아닌가요";
            }

            if (currentOperator == "x" && Math.Abs(result) >= 1000)
            {
                return "숫자가 확 커졌네요";
            }

            if (result == decimal.Truncate(result))
            {
                return "깔끔한 결과네요";
            }

            if (currentOperator == "x")
            {
                return "곱셈 감각이 좋으신데요";
            }

            return "좋은 흐름입니다";
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
            lblMessage.Text = "계산을 시작해보세요.";
        }

        private void btnHistory_Click(object? sender, EventArgs e)
        {
            isHistoryVisible = !isHistoryVisible;
            pnlHistory.Visible = isHistoryVisible;
            btnHistory.Text = isHistoryVisible ? "Hide" : "History";
        }
    }
}
