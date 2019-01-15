using System;
using System.Collections.Generic;
using System.Linq;

namespace Andy_Basic_Interpreter
{
    class Interpreter
    {
        private List<string> lines;
        private List<Tuple<string, int>> labels;
        private List<Tuple<string, object>> variables;

        public Interpreter()
        {
            lines = new List<string>();
            labels = new List<Tuple<string, int>>();
            variables = new List<Tuple<string, object>>();
        }

        public void LoadLine(string line)
        {
            lines.Add(line.Trim());
        }

        public void Reset()
        {
            lines.Clear();
            labels.Clear();
            variables.Clear();
        }

        public string Run()
        {
            string result = "";
            int pc = 0;

            if(lines.Count == 1 && lines[0] == "")
            {
                return result;
            }

            while(pc < lines.Count)
            {
                string command = lines.ElementAt(pc);

                if(command.Contains(":"))
                {
                    string labelName = command.Split(':')[0];
                    labels.Add(new Tuple<string, int>(labelName, pc));
                }
                else
                {
                    List<string> dataPair = command.Split(' ').ToList();
                    switch(dataPair.ElementAt(0))
                    {
                        case "let":
                            break;
                        case "print":
                            result += Function.Function.Print(dataPair, pc, variables);
                            break;
                        case "bye":
                            return result;
                        case "rem":
                            break;
                        default:
                            return "Syntax Error: Line " + (pc + 1).ToString();
                    }
                }

                pc++;
            }

            return result;
        }

        private string _Calculate(string sta)
        {
            string result = "";
            return result;
        }
    }
}
