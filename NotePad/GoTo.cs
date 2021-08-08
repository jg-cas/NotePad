using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class GoTo : Form
    {
        Form1 form1;
        public GoTo(Form callingform)
        {
            InitializeComponent();
            form1 = callingform as Form1;
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (int.TryParse(linenumber.Text, out int line))
            {
                int totallines = this.form1.richTextBox1.Lines.Count();
                if (line <= totallines)
                {
                    int index = this.form1.richTextBox1.GetFirstCharIndexFromLine(line);
                    this.form1.richTextBox1.Select(index, 0);
                    this.form1.richTextBox1.ScrollToCaret();
                }
                else
                {
                    MessageBox.Show($"There is only {totallines} lines in your Document");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Number for Line");
            }
            this.TopMost = true;
            this.form1.Activate();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
