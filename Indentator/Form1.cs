using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indentator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void indenterButton_Click(object sender, EventArgs e)
        {
            // Copied and pasted cafon style indentation
            TextBox rchTemp = new TextBox();
            foreach (string line in codeTBEditor.Lines)
            {
                rchTemp.AppendText("\r\n" + line.Trim());
            }

            TextBox rchTemp2 = new TextBox();
            int indentCount = 0;
            bool shouldIndent = false;
            foreach (string line in rchTemp.Lines)
            {
                if (shouldIndent)
                    indentCount++;

                if (line.Contains("}"))
                    indentCount--;

                if (indentCount == 0)
                {
                    rchTemp2.AppendText("\r\n" + line);
                    shouldIndent = line.Contains("{");
                    continue;
                }
                string blankSpace = string.Empty;
                for (int i = 0; i < indentCount; i++)
                {
                    blankSpace += "    ";
                }
                rchTemp2.AppendText("\r\n" + blankSpace + line);
                shouldIndent = line.Contains("{");
            }
            codeTBEditor.Text = rchTemp2.Text;
        }
    }
    
}
