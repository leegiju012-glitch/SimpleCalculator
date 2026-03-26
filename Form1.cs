using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string expressionInput = string.Empty;
        private string currentEntry = "0";
        private bool hasCalculated;
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

            if (hasCalculated)
            {
                ResetCalculator();
            }

            currentEntry = currentEntry == "0" ? digit : currentEntry + digit;
            UpdateDisplays();
            UpdateMessage("숫자를 입력하고 있습니다.");
        }

        private void DecimalButton_Click(object? sender, EventArgs e)
        {
            if (hasCalculated)
            {
                ResetCalculator();
            }

            if (string.IsNullOrEmpty(currentEntry))
            {
                currentEntry = "0.";
            }
            else if (!currentEntry.Contains('.'))
            {
                currentEntry += ".";
            }

            UpdateDisplays();
            UpdateMessage("소수점을 입력했습니다.");
        }

        private void OperatorButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (hasCalculated)
            {
                expressionInput = currentEntry;
                hasCalculated = false;
            }

            CommitCurrentEntryIfNeeded();

            if (string.IsNullOrEmpty(expressionInput))
            {
                expressionInput = "0";
            }

            if (EndsWithOperator(expressionInput))
            {
                expressionInput = expressionInput[..^3];
            }

            expressionInput += $" {button.Text} ";
            currentEntry = string.Empty;
            UpdateDisplays();
            UpdateMessage("연산자를 선택했습니다.");
        }

        private void BracketButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (hasCalculated)
            {
                ResetCalculator();
            }

            if (button.Text == "(")
            {
                if (!string.IsNullOrEmpty(currentEntry) && currentEntry != "0")
                {
                    expressionInput += currentEntry + " x ";
                    currentEntry = string.Empty;
                }
                else if (expressionInput.EndsWith(")"))
                {
                    expressionInput += " x ";
                }

                expressionInput += "(";
                UpdateDisplays();
                UpdateMessage("여는 괄호를 추가했습니다.");
                return;
            }

            CommitCurrentEntryIfNeeded();

            if (CanCloseBracket())
            {
                expressionInput += ")";
                UpdateDisplays();
                UpdateMessage("닫는 괄호를 추가했습니다.");
            }
        }

        private void EqualsButton_Click(object? sender, EventArgs e)
        {
            CommitCurrentEntryIfNeeded();

            if (string.IsNullOrWhiteSpace(expressionInput))
            {
                return;
            }

            try
            {
                string displayExpression = expressionInput;
                string calculationExpression = ToCalculationExpression(expressionInput);
                decimal result = Convert.ToDecimal(new DataTable().Compute(calculationExpression, string.Empty), CultureInfo.InvariantCulture);
                string resultText = FormatNumber(result);

                txtExpress.Text = displayExpression + " = " + resultText;
                txtResult.Text = resultText;
                lstHistory.Items.Insert(0, txtExpress.Text);
                currentEntry = resultText;
                expressionInput = string.Empty;
                hasCalculated = true;
                UpdateMessage(CreateFunMessage(displayExpression, result));
            }
            catch (DivideByZeroException)
            {
                ResetCalculator();
                UpdateMessage("그건 계산기도 곤란합니다");
            }
            catch
            {
                ResetCalculator();
                UpdateMessage("식을 다시 확인해보세요.");
            }
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

            currentEntry = "0";
            UpdateDisplays();
            UpdateMessage("마지막 피연산자를 통째로 지웠습니다.");
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            if (hasCalculated)
            {
                return;
            }

            if (string.IsNullOrEmpty(currentEntry) || currentEntry == "0")
            {
                return;
            }

            currentEntry = currentEntry.Length > 1 ? currentEntry[..^1] : "0";
            if (currentEntry == "-" || currentEntry == string.Empty)
            {
                currentEntry = "0";
            }

            UpdateDisplays();
            UpdateMessage("마지막 숫자 한 자리를 지웠습니다.");
        }

        private void SignButton_Click(object? sender, EventArgs e)
        {
            if (hasCalculated)
            {
                hasCalculated = false;
            }

            if (string.IsNullOrEmpty(currentEntry))
            {
                currentEntry = "-";
            }
            else if (currentEntry == "0")
            {
                return;
            }
            else
            {
                currentEntry = currentEntry.StartsWith("-")
                    ? currentEntry[1..]
                    : "-" + currentEntry;
            }

            UpdateDisplays();
            UpdateMessage("부호를 전환했습니다.");
        }

        private void btnHistory_Click(object? sender, EventArgs e)
        {
            isHistoryVisible = !isHistoryVisible;
            pnlHistory.Visible = isHistoryVisible;
            btnHistory.Text = isHistoryVisible ? "Hide" : "History";
        }

        private void CommitCurrentEntryIfNeeded()
        {
            if (string.IsNullOrEmpty(currentEntry))
            {
                return;
            }

            if (currentEntry == "-")
            {
                currentEntry = "-0";
            }

            if (expressionInput.EndsWith(")"))
            {
                expressionInput += " x ";
            }

            expressionInput += currentEntry;
            currentEntry = string.Empty;
        }

        private bool CanCloseBracket()
        {
            return expressionInput.Count(ch => ch == '(') > expressionInput.Count(ch => ch == ')')
                && !EndsWithOperator(expressionInput)
                && !expressionInput.EndsWith("(");
        }

        private static bool EndsWithOperator(string text)
        {
            return text.EndsWith(" + ")
                || text.EndsWith(" - ")
                || text.EndsWith(" x ")
                || text.EndsWith(" ÷ ");
        }

        private static string ToCalculationExpression(string expression)
        {
            string converted = expression
                .Replace("x", "*")
                .Replace("÷", "/");

            converted = Regex.Replace(converted, @"(\d|\))\s*\(", "$1*(");
            converted = Regex.Replace(converted, @"\)\s*(\d)", ")*$1");
            return converted;
        }

        private void UpdateDisplays()
        {
            if (hasCalculated)
            {
                return;
            }

            txtExpress.Text = expressionInput + currentEntry;
            txtResult.Text = string.IsNullOrEmpty(currentEntry) ? "0" : currentEntry;
        }

        private void UpdateMessage(string message)
        {
            lblMessage.Text = message;
        }

        private static string FormatNumber(decimal value)
        {
            return value.ToString("0.###############", CultureInfo.InvariantCulture);
        }

        private string CreateFunMessage(string displayExpression, decimal result)
        {
            decimal[] numbers = Regex.Matches(displayExpression, @"-?\d+(\.\d+)?")
                .Select(match => decimal.Parse(match.Value, CultureInfo.InvariantCulture))
                .ToArray();

            decimal n1 = numbers.Length > 0 ? numbers[0] : 0;
            decimal n2 = numbers.Length > 1 ? numbers[1] : 0;

            if (displayExpression.Contains('÷') && n2 != 0 && result == decimal.Truncate(result))
            {
                return "공평하게 잘 나눠졌습니다";
            }

            if (result == 100)
            {
                return "100점짜리 계산입니다";
            }

            if (numbers.Length >= 2 && Math.Abs(n1) < 10 && Math.Abs(n2) < 10)
            {
                return "이정돈 암산 하시죠";
            }

            if (numbers.Length >= 2 && Math.Abs(n1) < 10 && Math.Abs(n2) < 10 && result < 20)
            {
                return "너무 쉬운 거 아닌가요";
            }

            if (displayExpression.Contains('x') && Math.Abs(result) >= 1000)
            {
                return "숫자가 확 커졌네요";
            }

            if (result == decimal.Truncate(result))
            {
                return "깔끔한 결과네요";
            }

            if (displayExpression.Contains('x'))
            {
                return "곱셈 감각이 좋으신데요";
            }

            return "좋은 흐름입니다";
        }

        private void ResetCalculator()
        {
            expressionInput = string.Empty;
            currentEntry = "0";
            hasCalculated = false;
            txtExpress.Text = string.Empty;
            txtResult.Text = "0";
            lblMessage.Text = "계산을 시작해보세요.";
        }
    }
}
