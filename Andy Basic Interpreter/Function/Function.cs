using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andy_Basic_Interpreter.Function
{
    class Function
    {
        public static string Print(List<string> command, int pc, List<Tuple<string, object>> var)
        {
            string result = "";
            double number = 0.0;
            bool boolean = false;

            if (command.Count > 1)
            {
                string argument = string.Join(" ", command.GetRange(1, command.Count - 1));
                if (argument.Contains("\""))
                {
                    if (argument.IndexOf('"') != argument.LastIndexOf('"'))
                    {
                        string sentence = argument.Substring(1, argument.Length - 2);
                        result += sentence + "\n";
                    }
                    else
                    {
                        return "Quote Error: Line " + (pc + 1).ToString();
                    }
                }
                else if (double.TryParse(argument, out number))
                {
                    result += number.ToString() + "\n";
                }
                else if (bool.TryParse(argument, out boolean))
                {
                    result += boolean.ToString() + "\n";
                }
                else if (var.Where(t => t.Item1.Equals(argument)).Count() > 0)
                {
                    result += var.Find(t => t.Item1.Equals(argument)).Item2.ToString();
                }
                else
                {
                    return "Argument Error: Line " + (pc + 1).ToString();
                }
            }
            else
            {
                result += "\n";
            }

            return result;
        }

        public static string Let(List<string> command, int pc, List<Tuple<string, object>> var, out List<Tuple<string, object>> updated)
        {
            double number = 0.0;
            bool boolean = false;
            object insert = null;
            updated = var;

            if (command.Count > 1)
            {
                string argument = string.Join("", command.GetRange(1, command.Count - 1));
                string[] expr = argument.Split('=');
                if (expr[1].Contains("\""))
                {
                    if (argument.IndexOf('"') != argument.LastIndexOf('"'))
                    {
                        string sentence = argument.Substring(1, argument.Length - 2);
                        insert = sentence;
                    }
                    else
                    {
                        return "Quote Error: Line " + (pc + 1).ToString();
                    }
                }
                else if (double.TryParse(argument, out number))
                {
                    insert = number;
                }
                else if (bool.TryParse(argument, out boolean))
                {
                    insert = boolean;
                }
                else if (var.Where(t => t.Item1.Equals(argument)).Count() > 0)
                {
                    insert = var.Find(t => t.Item1.Equals(argument)).Item2;
                }
                else
                {
                    return "Quote Error: Line " + (pc + 1).ToString();
                }

                if (var.Where(t => t.Item1.Equals(expr[0])).Count() > 0)
                {
                    var.Remove(var.Find(t => t.Item1.Equals(expr[0])));
                    var.Add(new Tuple<string, object>(expr[0], insert));
                }
                else
                {
                    var.Add(new Tuple<string, object>(expr[0], insert));
                }
            }
            else
            {
                return "Argument Error: Line " + (pc + 1).ToString();
            }

            return "";
        }
    }
}
