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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 34F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(42, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(473, 76);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Simple Calculator";
            // 
            // txtExpress
            // 
            txtExpress.Location = new Point(56, 146);
            txtExpress.Name = "txtExpress";
            txtExpress.ReadOnly = true;
            txtExpress.Size = new Size(450, 34);
            txtExpress.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(56, 195);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(450, 34);
            txtResult.TabIndex = 2;
            // 
            // btnCe
            // 
            btnCe.Location = new Point(56, 267);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(96, 58);
            btnCe.TabIndex = 3;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = true;
            btnCe.Click += CeButton_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(168, 267);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 58);
            btnClear.TabIndex = 4;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += ClearButton_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(280, 267);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 58);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "del";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += DeleteButton_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(392, 267);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(114, 58);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += OperatorButton_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(56, 341);
            btn7.Name = "btn7";
            btn7.Size = new Size(96, 58);
            btn7.TabIndex = 7;
            btn7.Tag = "7";
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += DigitButton_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(168, 341);
            btn8.Name = "btn8";
            btn8.Size = new Size(96, 58);
            btn8.TabIndex = 8;
            btn8.Tag = "8";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += DigitButton_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(280, 341);
            btn9.Name = "btn9";
            btn9.Size = new Size(96, 58);
            btn9.TabIndex = 9;
            btn9.Tag = "9";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += DigitButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(392, 341);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(114, 58);
            btnMultiply.TabIndex = 10;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += OperatorButton_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(56, 415);
            btn4.Name = "btn4";
            btn4.Size = new Size(96, 58);
            btn4.TabIndex = 11;
            btn4.Tag = "4";
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += DigitButton_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(168, 415);
            btn5.Name = "btn5";
            btn5.Size = new Size(96, 58);
            btn5.TabIndex = 12;
            btn5.Tag = "5";
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += DigitButton_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(280, 415);
            btn6.Name = "btn6";
            btn6.Size = new Size(96, 58);
            btn6.TabIndex = 13;
            btn6.Tag = "6";
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += DigitButton_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSubtract.ForeColor = Color.Red;
            btnSubtract.Location = new Point(392, 415);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(114, 58);
            btnSubtract.TabIndex = 14;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += OperatorButton_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(56, 489);
            btn1.Name = "btn1";
            btn1.Size = new Size(96, 58);
            btn1.TabIndex = 15;
            btn1.Tag = "1";
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += DigitButton_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(168, 489);
            btn2.Name = "btn2";
            btn2.Size = new Size(96, 58);
            btn2.TabIndex = 16;
            btn2.Tag = "2";
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += DigitButton_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(280, 489);
            btn3.Name = "btn3";
            btn3.Size = new Size(96, 58);
            btn3.TabIndex = 17;
            btn3.Tag = "3";
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += DigitButton_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(392, 489);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 58);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OperatorButton_Click;
            // 
            // btnSign
            // 
            btnSign.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSign.Location = new Point(56, 563);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(96, 58);
            btnSign.TabIndex = 19;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += SignButton_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(168, 563);
            btn0.Name = "btn0";
            btn0.Size = new Size(96, 58);
            btn0.TabIndex = 20;
            btn0.Tag = "0";
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += DigitButton_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnDecimal.Location = new Point(280, 563);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(96, 58);
            btnDecimal.TabIndex = 21;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += DecimalButton_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnEqual.Location = new Point(392, 563);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(114, 58);
            btnEqual.TabIndex = 22;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += EqualsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(564, 642);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtExpress;
        private TextBox txtResult;
        private Button btnCe;
        private Button btnClear;
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
    }
}
