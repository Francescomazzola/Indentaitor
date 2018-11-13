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
                pathTB.Text = percorso;
            }
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
