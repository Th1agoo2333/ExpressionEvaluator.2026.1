using ExpressionEvaluator.Core;
namespace ExpressionEvaluator.UI.Win;

public partial class Form1 : Form
{
    private string _expression = string.Empty;

    public Form1()
    {
        InitializeComponent();
    }

    private void BtnNumber_Click(object sender, EventArgs e)
    {
        var button = (Button)sender;
        _expression += button.Text;
        TxtDisplay.Text = _expression;
    }

    private void BtnOperator_Click(object sender, EventArgs e)
    {
        var button = (Button)sender;
        _expression += button.Text;
        TxtDisplay.Text = _expression;
    }

    private void BtnEquals_Click(object sender, EventArgs e)
    {
        try
        {
            var result = Evaluator.Evaluate(_expression);
            TxtDisplay.Text = result.ToString();
            _expression = result.ToString();
        }
        catch (Exception ex)
        {
            TxtDisplay.Text = ex.Message;
            _expression = string.Empty;
        }
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
        _expression = string.Empty;
        TxtDisplay.Text = string.Empty;
    }

    private void BtnClearEntry_Click(object sender, EventArgs e)
    {
        if (_expression.Length > 0)
        {
            _expression = _expression.Substring(0, _expression.Length - 1);
            TxtDisplay.Text = _expression;
        }
    }
}