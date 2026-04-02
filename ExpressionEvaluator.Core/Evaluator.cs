namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return EvaluatePostfix(postfix);
    }

    private static Queue<string> Tokenize(string infix)
    {
        var tokens = new Queue<string>();
        var i = 0;

        while (i < infix.Length)
        {
            var c = infix[i];

            if (char.IsDigit(c) || c == '.')
            {
                var number = string.Empty;
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    number += infix[i];
                    i++;
                }
                tokens.Enqueue(number);
            }
            else if (IsOperator(c))
            {
                tokens.Enqueue(c.ToString());
                i++;
            }
            else
            {
                throw new Exception("Sintax error.");
            }
        }

        return tokens;
    }

    private static Queue<string> InfixToPostfix(string infix)
    {
        var postfix = new Queue<string>();
        var stack = new Stack<string>();
        var tokens = Tokenize(infix);

        while (tokens.Count > 0)
        {
            var token = tokens.Dequeue();

            if (IsOperatorStr(token))
            {
                if (stack.Count == 0)
                {
                    stack.Push(token);
                }
                else
                {
                    if (token == ")")
                    {
                        while (stack.Peek() != "(")
                        {
                            postfix.Enqueue(stack.Pop());
                        }
                        stack.Pop();
                    }
                    else
                    {
                        if (PriorityInfix(token) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(token);
                        }
                        else
                        {
                            postfix.Enqueue(stack.Pop());
                            stack.Push(token);
                        }
                    }
                }
            }
            else
            {
                postfix.Enqueue(token);
            }
        }

        while (stack.Count > 0)
        {
            postfix.Enqueue(stack.Pop());
        }

        return postfix;
    }

    private static int PriorityStack(string item) => item switch
    {
        "^" => 3,
        "*" => 2,
        "/" => 2,
        "+" => 1,
        "-" => 1,
        "(" => 0,
        _ => throw new Exception("Sintax error."),
    };

    private static int PriorityInfix(string item) => item switch
    {
        "^" => 4,
        "*" => 2,
        "/" => 2,
        "+" => 1,
        "-" => 1,
        "(" => 5,
        _ => throw new Exception("Sintax error."),
    };

    private static double EvaluatePostfix(Queue<string> postfix)
    {
        var stack = new Stack<double>();

        while (postfix.Count > 0)
        {
            var token = postfix.Dequeue();

            if (IsOperatorStr(token))
            {
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(token switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => a / b,
                    "^" => Math.Pow(a, b),
                    _ => throw new Exception("Sintax error."),
                });
            }
            else
            {
                stack.Push(double.Parse(token, System.Globalization.CultureInfo.InvariantCulture));
            }
        }

        return stack.Pop();
    }

    private static bool IsOperator(char item) => "+-*/^()".Contains(item);

    private static bool IsOperatorStr(string item) => item.Length == 1 && IsOperator(item[0]);
}

