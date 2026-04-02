namespace ExpressionEvaluator.UI.Win;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        TxtDisplay = new TextBox();
        BtnClear = new Button();
        BtnClearEntry = new Button();
        BtnOpenParen = new Button();
        BtnCloseParen = new Button();
        Btn7 = new Button();
        Btn8 = new Button();
        Btn9 = new Button();
        BtnDiv = new Button();
        Btn4 = new Button();
        Btn5 = new Button();
        Btn6 = new Button();
        BtnMul = new Button();
        Btn1 = new Button();
        Btn2 = new Button();
        Btn3 = new Button();
        BtnSub = new Button();
        Btn0 = new Button();
        BtnDot = new Button();
        BtnPow = new Button();
        BtnAdd = new Button();
        BtnEquals = new Button();
        SuspendLayout();

        // TxtDisplay
        TxtDisplay.Location = new Point(12, 12);
        TxtDisplay.Size = new Size(360, 40);
        TxtDisplay.Font = new Font("Segoe UI", 16F);
        TxtDisplay.TextAlign = HorizontalAlignment.Right;
        TxtDisplay.ReadOnly = true;
        TxtDisplay.TabIndex = 0;

        // Fila 1: C  CE  (  )
        BtnClear.Text = "C";
        BtnClear.Location = new Point(12, 65);
        BtnClear.Size = new Size(80, 50);
        BtnClear.Font = new Font("Segoe UI", 12F);
        BtnClear.Click += BtnClear_Click;

        BtnClearEntry.Text = "CE";
        BtnClearEntry.Location = new Point(100, 65);
        BtnClearEntry.Size = new Size(80, 50);
        BtnClearEntry.Font = new Font("Segoe UI", 12F);
        BtnClearEntry.Click += BtnClearEntry_Click;

        BtnOpenParen.Text = "(";
        BtnOpenParen.Location = new Point(188, 65);
        BtnOpenParen.Size = new Size(80, 50);
        BtnOpenParen.Font = new Font("Segoe UI", 12F);
        BtnOpenParen.Click += BtnOperator_Click;

        BtnCloseParen.Text = ")";
        BtnCloseParen.Location = new Point(276, 65);
        BtnCloseParen.Size = new Size(96, 50);
        BtnCloseParen.Font = new Font("Segoe UI", 12F);
        BtnCloseParen.Click += BtnOperator_Click;

        // Fila 2: 7  8  9  /
        Btn7.Text = "7";
        Btn7.Location = new Point(12, 125);
        Btn7.Size = new Size(80, 50);
        Btn7.Font = new Font("Segoe UI", 12F);
        Btn7.Click += BtnNumber_Click;

        Btn8.Text = "8";
        Btn8.Location = new Point(100, 125);
        Btn8.Size = new Size(80, 50);
        Btn8.Font = new Font("Segoe UI", 12F);
        Btn8.Click += BtnNumber_Click;

        Btn9.Text = "9";
        Btn9.Location = new Point(188, 125);
        Btn9.Size = new Size(80, 50);
        Btn9.Font = new Font("Segoe UI", 12F);
        Btn9.Click += BtnNumber_Click;

        BtnDiv.Text = "/";
        BtnDiv.Location = new Point(276, 125);
        BtnDiv.Size = new Size(96, 50);
        BtnDiv.Font = new Font("Segoe UI", 12F);
        BtnDiv.Click += BtnOperator_Click;

        // Fila 3: 4  5  6  *
        Btn4.Text = "4";
        Btn4.Location = new Point(12, 185);
        Btn4.Size = new Size(80, 50);
        Btn4.Font = new Font("Segoe UI", 12F);
        Btn4.Click += BtnNumber_Click;

        Btn5.Text = "5";
        Btn5.Location = new Point(100, 185);
        Btn5.Size = new Size(80, 50);
        Btn5.Font = new Font("Segoe UI", 12F);
        Btn5.Click += BtnNumber_Click;

        Btn6.Text = "6";
        Btn6.Location = new Point(188, 185);
        Btn6.Size = new Size(80, 50);
        Btn6.Font = new Font("Segoe UI", 12F);
        Btn6.Click += BtnNumber_Click;

        BtnMul.Text = "*";
        BtnMul.Location = new Point(276, 185);
        BtnMul.Size = new Size(96, 50);
        BtnMul.Font = new Font("Segoe UI", 12F);
        BtnMul.Click += BtnOperator_Click;

        // Fila 4: 1  2  3  -
        Btn1.Text = "1";
        Btn1.Location = new Point(12, 245);
        Btn1.Size = new Size(80, 50);
        Btn1.Font = new Font("Segoe UI", 12F);
        Btn1.Click += BtnNumber_Click;

        Btn2.Text = "2";
        Btn2.Location = new Point(100, 245);
        Btn2.Size = new Size(80, 50);
        Btn2.Font = new Font("Segoe UI", 12F);
        Btn2.Click += BtnNumber_Click;

        Btn3.Text = "3";
        Btn3.Location = new Point(188, 245);
        Btn3.Size = new Size(80, 50);
        Btn3.Font = new Font("Segoe UI", 12F);
        Btn3.Click += BtnNumber_Click;

        BtnSub.Text = "-";
        BtnSub.Location = new Point(276, 245);
        BtnSub.Size = new Size(96, 50);
        BtnSub.Font = new Font("Segoe UI", 12F);
        BtnSub.Click += BtnOperator_Click;

        // Fila 5: 0  .  ^  +
        Btn0.Text = "0";
        Btn0.Location = new Point(12, 305);
        Btn0.Size = new Size(80, 50);
        Btn0.Font = new Font("Segoe UI", 12F);
        Btn0.Click += BtnNumber_Click;

        BtnDot.Text = ".";
        BtnDot.Location = new Point(100, 305);
        BtnDot.Size = new Size(80, 50);
        BtnDot.Font = new Font("Segoe UI", 12F);
        BtnDot.Click += BtnNumber_Click;

        BtnPow.Text = "^";
        BtnPow.Location = new Point(188, 305);
        BtnPow.Size = new Size(80, 50);
        BtnPow.Font = new Font("Segoe UI", 12F);
        BtnPow.Click += BtnOperator_Click;

        BtnAdd.Text = "+";
        BtnAdd.Location = new Point(276, 305);
        BtnAdd.Size = new Size(96, 50);
        BtnAdd.Font = new Font("Segoe UI", 12F);
        BtnAdd.Click += BtnOperator_Click;

        // Fila 6: = (ancho completo)
        BtnEquals.Text = "=";
        BtnEquals.Location = new Point(12, 365);
        BtnEquals.Size = new Size(360, 50);
        BtnEquals.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        BtnEquals.Click += BtnEquals_Click;

        // Form
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 430);
        Text = "Evaluador de Funciones";
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;

        Controls.Add(TxtDisplay);
        Controls.Add(BtnClear);
        Controls.Add(BtnClearEntry);
        Controls.Add(BtnOpenParen);
        Controls.Add(BtnCloseParen);
        Controls.Add(Btn7);
        Controls.Add(Btn8);
        Controls.Add(Btn9);
        Controls.Add(BtnDiv);
        Controls.Add(Btn4);
        Controls.Add(Btn5);
        Controls.Add(Btn6);
        Controls.Add(BtnMul);
        Controls.Add(Btn1);
        Controls.Add(Btn2);
        Controls.Add(Btn3);
        Controls.Add(BtnSub);
        Controls.Add(Btn0);
        Controls.Add(BtnDot);
        Controls.Add(BtnPow);
        Controls.Add(BtnAdd);
        Controls.Add(BtnEquals);

        ResumeLayout(false);
    }

    #endregion

    private TextBox TxtDisplay;
    private Button BtnClear;
    private Button BtnClearEntry;
    private Button BtnOpenParen;
    private Button BtnCloseParen;
    private Button Btn7, Btn8, Btn9, BtnDiv;
    private Button Btn4, Btn5, Btn6, BtnMul;
    private Button Btn1, Btn2, Btn3, BtnSub;
    private Button Btn0, BtnDot, BtnPow, BtnAdd;
    private Button BtnEquals;
}