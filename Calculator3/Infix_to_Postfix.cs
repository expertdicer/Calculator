using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{
    class Infix_to_Postfix
    {
        private static List<int> GetPriority(List<string> enumer)
        {
            List<int> Priority = new List<int>();
            int open_sub_close_breacket = 0;
            for (int i = 0; i < enumer.Count; i++)
            {
                if (IsOperand(enumer[i]))
                {
                    Priority.Add(0);
                }
                else if (enumer[i] == "(")
                {
                    Priority.Add(0);
                    open_sub_close_breacket += 1;
                }
                else if (enumer[i] == ")")
                {
                    Priority.Add(0);
                    open_sub_close_breacket -= 1;
                    if (open_sub_close_breacket < 0)
                        throw new Exception();
                }
                else
                {
                    if (enumer[i] == "+" || enumer[i] == "-")
                    {
                        if (i == 0 || enumer[i - 1] == "(")
                            Priority.Add(4);
                        else if (Priority[i - 1] >= 1)
                        {
                            Priority.Add(Priority[i - 1] + 3);
                        }
                        else
                        {
                            Priority.Add(1);
                        }
                    }
                    else if (enumer[i] == "√")
                    {
                        if (i == 0)
                            Priority.Add(4);
                        else if (Priority[i - 1] >= 1)
                        {
                            Priority.Add(Priority[i - 1] + 3);
                        }
                        else throw new Exception();
                    }
                    else if (enumer[i] == "*" || enumer[i] == "/")
                    {
                        if (i != 0 && Priority[i - 1] == 0)
                            Priority.Add(2);
                        else throw new Exception();
                    }
                    else if (enumer[i] == "ᶰ√" || enumer[i] == "^")
                    {
                        if (i != 0 && Priority[i - 1] == 0)
                            Priority.Add(4);
                        else throw new Exception();
                    }
                }
            }
            if (open_sub_close_breacket != 0)
                throw new Exception();
            if ((!IsOperand(enumer[enumer.Count - 1])) && enumer[enumer.Count - 1] != ")")
                throw new Exception();
            return Priority;
        }
        private static bool IsOperand(string s)
        {
            double num;
            return double.TryParse(s, out num);
        }
        public static string Infix2Postfix(List<string> str)
        {

            Stack<int> stack = new Stack<int>();
            StringBuilder postfix = new StringBuilder();
            List<int> Priority = GetPriority(str);
            for (int i = 0; i < str.Count; i++)
            {
                if (IsOperand(str[i]))
                    postfix.Append(str[i]).Append(" ");
                else if (str[i] == "(")
                    stack.Push(i);
                else if (str[i] == ")")
                {
                    int x = stack.Pop();
                    while (str[x] != "(")
                    {
                        if (Priority[x] >= 4)
                            postfix.Append("." + str[x]).Append(" ");
                        else
                            postfix.Append(str[x]).Append(" ");
                        x = stack.Pop();
                    }
                }
                else// IsOperator(s)
                {
                    while (stack.Count > 0 && Priority[i] <= Priority[stack.Peek()])
                    {
                        if (Priority[stack.Peek()] >= 4)
                            postfix.Append("." + str[stack.Pop()]).Append(" ");
                        else
                            postfix.Append(str[stack.Pop()]).Append(" ");
                    }
                    stack.Push(i);
                }
            }

            while (stack.Count > 0)
            {
                if (Priority[stack.Peek()] >= 4)
                    postfix.Append("." + str[stack.Pop()]).Append(" ");
                else
                    postfix.Append(str[stack.Pop()]).Append(" ");
            }

            return postfix.ToString();
        }
        public static double EvaluatePostfix(string postfix)
        {
            Stack<double> stack = new Stack<double>();
            double x, y = 0;
            postfix = postfix.Trim();

            string[] enumer = postfix.Split(' ');

            foreach (string s in enumer)
            {
                if (IsOperand(s))
                    stack.Push(double.Parse(s));
                else
                {
                    switch (s)
                    {
                        case "+":
                            {
                                x = stack.Pop();
                                y = stack.Pop();
                                y += x;
                                break;
                            }
                        case "-":
                            {
                                x = stack.Pop();
                                y = stack.Pop();
                                y -= x;
                                break;
                            }
                        case "*":
                            {

                                x = stack.Pop();
                                y = stack.Pop();
                                y *= x;
                                break;

                            }
                        case "/":
                            {
                                x = stack.Pop();
                                y = stack.Pop();
                                y /= x;
                                break;
                            }
                        case ".+":
                            {
                                y = stack.Pop();
                                break;
                            }
                        case ".-":
                            {
                                y = -stack.Pop();
                                break;
                            }
                        case ".√":
                            {
                                y = Math.Sqrt(stack.Pop());
                                break;
                            }
                        case ".^":
                            {
                                x = stack.Pop();
                                y = stack.Pop();
                                y = Math.Pow(y, x);
                                break;
                            }
                        case ".ᶰ√":
                            {
                                x = stack.Pop();
                                y = stack.Pop();
                                y = Math.Pow(x, 1 / y);
                                break;
                            }
                    }
                    stack.Push(y);
                }
            }
            if (stack.Count > 1)
                throw new Exception();
            return stack.Pop();
        }
    }
}
