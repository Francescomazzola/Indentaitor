using System;
using System.Windows.Forms;
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
        public string percorso;
        private object openFileDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        private void selectfileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "cs",
                Filter = "cs files (*.cs)|*.cs",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                percorso=openFileDialog1.FileName;
            }
        }
        private void indenterButton_Click(object sender, EventArgs e)
        {
            // Copied and pasted cafon style indentation
            List<string> lines = new List<string>();
            foreach (string line in codeTBEditor.Lines)
                lines.Add(line.Trim());

            string result = "";
            int indentCount = 0;
            bool shouldIndent = false;

            foreach (string line in lines)
            {
                if (shouldIndent)
                    indentCount++;

                if (line.Contains("}"))
                    indentCount--;

                if (indentCount == 0)
                {
                    result += "\r\n" + line;
                    shouldIndent = line.Contains("{");
                    continue;
                }

                string blankSpace = string.Empty;
                for (int i = 0; i < indentCount; i++)
                    blankSpace += "    ";

                result += "\r\n" + blankSpace + line;
                shouldIndent = line.Contains("{");
            }
            codeTBEditor.Text = result;
        }
    }
    
}
