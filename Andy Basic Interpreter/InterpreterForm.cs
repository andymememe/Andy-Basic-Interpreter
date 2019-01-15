using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andy_Basic_Interpreter
{
    public partial class InterpreterForm : Form
    {
        private Interpreter interpreter;

        public InterpreterForm()
        {
            InitializeComponent();

            interpreter = new Interpreter();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            string code = codeBox.Text;
            string[] lines = code.Split('\n');

            interpreter.Reset();
            resultBox.Text = "";
            foreach (string line in lines)
            {
                interpreter.LoadLine(line);
            }

            resultBox.Text = interpreter.Run();
        }
    }
}
