namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if disposing managed resources; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtExpress = new TextBox();
            txtResult = new TextBox();
            btnCe = new Button();
            btnClear = new Button();
            btnOpenBracket = new Button();
            btnCloseBracket = new Button();
            btnDelete = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubtract = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btnSign = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnEqual = new Button();
            lblMessage = new Label();
            btnHistory = new Button();
            pnlHistory = new Panel();
            lstHistory = new ListBox();
            lblHistory = new Label();
            pnlHistory.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(34, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(338, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Simple Calculator";
            // 
            // txtExpress
            // 
            txtExpress.BackColor = Color.FromArgb(28, 28, 30);
            txtExpress.BorderStyle = BorderStyle.None;
            txtExpress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtExpress.ForeColor = Color.Gainsboro;
            txtExpress.Location = new Point(34, 95);
            txtExpress.Name = "txtExpress";
            txtExpress.ReadOnly = true;
            txtExpress.Size = new Size(475, 32);
            txtExpress.TabIndex = 1;
            txtExpress.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(28, 28, 30);
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtResult.ForeColor = Color.White;
            txtResult.Location = new Point(34, 132);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(475, 54);
            txtResult.TabIndex = 2;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCe
            // 
            btnCe.BackColor = Color.FromArgb(165, 165, 165);
            btnCe.FlatAppearance.BorderSize = 0;
            btnCe.FlatStyle = FlatStyle.Flat;
            btnCe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCe.ForeColor = Color.Black;
            btnCe.Location = new Point(34, 215);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(72, 58);
            btnCe.TabIndex = 3;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = false;
            btnCe.Click += CeButton_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(165, 165, 165);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(114, 215);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(72, 58);
            btnClear.TabIndex = 4;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += ClearButton_Click;
            // 
            // btnOpenBracket
            // 
            btnOpenBracket.BackColor = Color.FromArgb(165, 165, 165);
            btnOpenBracket.FlatAppearance.BorderSize = 0;
            btnOpenBracket.FlatStyle = FlatStyle.Flat;
            btnOpenBracket.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOpenBracket.ForeColor = Color.Black;
            btnOpenBracket.Location = new Point(194, 215);
            btnOpenBracket.Name = "btnOpenBracket";
            btnOpenBracket.Size = new Size(72, 58);
            btnOpenBracket.TabIndex = 5;
            btnOpenBracket.Text = "(";
            btnOpenBracket.UseVisualStyleBackColor = false;
            btnOpenBracket.Click += BracketButton_Click;
            // 
            // btnCloseBracket
            // 
            btnCloseBracket.BackColor = Color.FromArgb(165, 165, 165);
            btnCloseBracket.FlatAppearance.BorderSize = 0;
            btnCloseBracket.FlatStyle = FlatStyle.Flat;
            btnCloseBracket.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCloseBracket.ForeColor = Color.Black;
            btnCloseBracket.Location = new Point(274, 215);
            btnCloseBracket.Name = "btnCloseBracket";
            btnCloseBracket.Size = new Size(72, 58);
            btnCloseBracket.TabIndex = 6;
            btnCloseBracket.Text = ")";
            btnCloseBracket.UseVisualStyleBackColor = false;
            btnCloseBracket.Click += BracketButton_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(165, 165, 165);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(354, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 58);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += DeleteButton_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 149, 0);
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDivide.ForeColor = Color.White;
            btnDivide.Location = new Point(434, 215);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 58);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += OperatorButton_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(51, 51, 51);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(34, 287);
            btn7.Name = "btn7";
            btn7.Size = new Size(96, 58);
            btn7.TabIndex = 9;
            btn7.Tag = "7";
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += DigitButton_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(51, 51, 51);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(154, 287);
            btn8.Name = "btn8";
            btn8.Size = new Size(96, 58);
            btn8.TabIndex = 10;
            btn8.Tag = "8";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += DigitButton_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(51, 51, 51);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(274, 287);
            btn9.Name = "btn9";
            btn9.Size = new Size(96, 58);
            btn9.TabIndex = 11;
            btn9.Tag = "9";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += DigitButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 149, 0);
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMultiply.ForeColor = Color.White;
            btnMultiply.Location = new Point(394, 287);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(115, 58);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += OperatorButton_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(51, 51, 51);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(34, 359);
            btn4.Name = "btn4";
            btn4.Size = new Size(96, 58);
            btn4.TabIndex = 13;
            btn4.Tag = "4";
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += DigitButton_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(51, 51, 51);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(154, 359);
            btn5.Name = "btn5";
            btn5.Size = new Size(96, 58);
            btn5.TabIndex = 14;
            btn5.Tag = "5";
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += DigitButton_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(51, 51, 51);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(274, 359);
            btn6.Name = "btn6";
            btn6.Size = new Size(96, 58);
            btn6.TabIndex = 15;
            btn6.Tag = "6";
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += DigitButton_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(255, 149, 0);
            btnSubtract.FlatAppearance.BorderSize = 0;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSubtract.ForeColor = Color.White;
            btnSubtract.Location = new Point(394, 359);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(115, 58);
            btnSubtract.TabIndex = 16;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += OperatorButton_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(51, 51, 51);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(34, 431);
            btn1.Name = "btn1";
            btn1.Size = new Size(96, 58);
            btn1.TabIndex = 17;
            btn1.Tag = "1";
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += DigitButton_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(51, 51, 51);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(154, 431);
            btn2.Name = "btn2";
            btn2.Size = new Size(96, 58);
            btn2.TabIndex = 18;
            btn2.Tag = "2";
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += DigitButton_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(51, 51, 51);
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(274, 431);
            btn3.Name = "btn3";
            btn3.Size = new Size(96, 58);
            btn3.TabIndex = 19;
            btn3.Tag = "3";
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += DigitButton_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 149, 0);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(394, 431);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 58);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += OperatorButton_Click;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.FromArgb(51, 51, 51);
            btnSign.FlatAppearance.BorderSize = 0;
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSign.ForeColor = Color.White;
            btnSign.Location = new Point(34, 503);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(96, 58);
            btnSign.TabIndex = 21;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += SignButton_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(51, 51, 51);
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(154, 503);
            btn0.Name = "btn0";
            btn0.Size = new Size(96, 58);
            btn0.TabIndex = 22;
            btn0.Tag = "0";
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += DigitButton_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.FromArgb(51, 51, 51);
            btnDecimal.FlatAppearance.BorderSize = 0;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDecimal.ForeColor = Color.White;
            btnDecimal.Location = new Point(274, 503);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(96, 58);
            btnDecimal.TabIndex = 23;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += DecimalButton_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 149, 0);
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnEqual.ForeColor = Color.White;
            btnEqual.Location = new Point(394, 503);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(115, 58);
            btnEqual.TabIndex = 24;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += EqualsButton_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblMessage.ForeColor = Color.FromArgb(255, 204, 117);
            lblMessage.Location = new Point(34, 572);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(475, 30);
            lblMessage.TabIndex = 25;
            lblMessage.Text = "Ready";
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(28, 28, 30);
            btnHistory.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 73);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnHistory.ForeColor = Color.WhiteSmoke;
            btnHistory.Location = new Point(413, 34);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(96, 38);
            btnHistory.TabIndex = 26;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // pnlHistory
            // 
            pnlHistory.BackColor = Color.FromArgb(18, 18, 18);
            pnlHistory.Controls.Add(lstHistory);
            pnlHistory.Controls.Add(lblHistory);
            pnlHistory.Location = new Point(534, 24);
            pnlHistory.Name = "pnlHistory";
            pnlHistory.Size = new Size(180, 578);
            pnlHistory.TabIndex = 27;
            pnlHistory.Visible = false;
            // 
            // lstHistory
            // 
            lstHistory.BackColor = Color.FromArgb(28, 28, 30);
            lstHistory.BorderStyle = BorderStyle.None;
            lstHistory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstHistory.ForeColor = Color.WhiteSmoke;
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(12, 53);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(155, 506);
            lstHistory.TabIndex = 1;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblHistory.ForeColor = Color.WhiteSmoke;
            lblHistory.Location = new Point(12, 14);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(93, 32);
            lblHistory.TabIndex = 0;
            lblHistory.Text = "History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(734, 623);
            Controls.Add(pnlHistory);
            Controls.Add(btnHistory);
            Controls.Add(lblMessage);
            Controls.Add(btnEqual);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btnSign);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSubtract);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDivide);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseBracket);
            Controls.Add(btnOpenBracket);
            Controls.Add(btnClear);
            Controls.Add(btnCe);
            Controls.Add(txtResult);
            Controls.Add(txtExpress);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator v1.0";
            pnlHistory.ResumeLayout(false);
            pnlHistory.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtExpress;
        private TextBox txtResult;
        private Button btnCe;
        private Button btnClear;
        private Button btnOpenBracket;
        private Button btnCloseBracket;
        private Button btnDelete;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtract;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btnSign;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEqual;
        private Label lblMessage;
        private Button btnHistory;
        private Panel pnlHistory;
        private ListBox lstHistory;
        private Label lblHistory;
    }
}
