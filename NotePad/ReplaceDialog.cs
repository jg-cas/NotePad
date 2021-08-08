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
    public partial class ReplaceDialog : Form
    {
        Form1 form1;
        public ReplaceDialog(string text, Form callingform)
        {
            InitializeComponent();
            txtFind.Text = text;
            form1 = callingform as Form1;
        }

        private void findnext_Click(object sender, EventArgs e)
        {
            if (matchcase.Checked == false && wraparound.Checked == false)
            {
                if (this.form1.FindNextNoneNoWrapAround(this.txtFind.Text, this.form1.richTextBox1.SelectionStart + this.form1.richTextBox1.SelectedText.Length) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (matchcase.Checked == true && wraparound.Checked == false)
            {
                if (this.form1.FindNextNoWrapAround(this.txtFind.Text, this.form1.richTextBox1.SelectionStart + this.form1.richTextBox1.SelectedText.Length) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (matchcase.Checked == false && wraparound.Checked == true)
            {
                if (this.form1.FindNextNone(this.txtFind.Text, this.form1.richTextBox1.SelectionStart + this.txtFind.Text.Length) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (matchcase.Checked == true && wraparound.Checked == true)
            {
                if (this.form1.FindNext(this.txtFind.Text, this.form1.richTextBox1.SelectionStart + this.txtFind.Text.Length) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
        }

        private void replace_Click(object sender, EventArgs e)
        {
            if (txtReplace.Text == string.Empty)
            {
                MessageBox.Show("Enter Text to Replace");
            }
            else if (this.form1.richTextBox1.SelectedText == string.Empty)
            {
                MessageBox.Show("Select Text to Replace");
            }
            else
            {
                this.form1.richTextBox1.SelectedText = txtReplace.Text;
            }
            this.TopMost = true;
            this.form1.Activate();
        }

        private void replaceall_Click(object sender, EventArgs e)
        {
            if (txtReplace.Text != string.Empty)
            {
                while (this.form1.FindNext(this.txtFind.Text, this.form1.richTextBox1.SelectionLength) != -1)
                {
                        this.form1.richTextBox1.SelectedText = txtReplace.Text;
                }
                MessageBox.Show("No More to Replace");
            }
            else if (txtReplace.Text == string.Empty)
            {
                MessageBox.Show("Enter Text to Replace");
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
