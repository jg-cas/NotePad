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
    public partial class FindDialog : Form
    {
        Form1 form1; //global variable
        public FindDialog(string text, Form callingform) //constructor that takes a string so it's possible to pass strings from one form to the other and a form to call as reference
        {
            InitializeComponent();
            txtFind.Text = text;
            down.Checked = true;
            //Form1 passed as a reference instead of creating a new instance
            form1 = callingform as Form1;
        }
        public FindDialog()
        {
            InitializeComponent();
        }

        private void findnext_Click(object sender, EventArgs e)
        {
            if (down.Checked == true && matchcase.Checked == false && wraparound.Checked == false)
            {
                if (form1.FindNextNoneNoWrapAround(this.txtFind.Text, this.form1.richTextBox1.SelectionStart + this.form1.richTextBox1.SelectedText.Length) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (down.Checked == true && matchcase.Checked == true && wraparound.Checked == false)
            {
                if (form1.FindNextNoWrapAround(this.txtFind.Text, this.form1.richTextBox1.SelectionStart + this.form1.richTextBox1.SelectedText.Length) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (down.Checked == true && matchcase.Checked == false && wraparound.Checked == true)
            {
                if (form1.FindNextNone(this.txtFind.Text, this.form1.richTextBox1.SelectionStart + this.form1.richTextBox1.SelectedText.Length) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (down.Checked == true && matchcase.Checked == true && wraparound.Checked == true)
            {
                if (this.form1.FindNext(this.txtFind.Text, this.form1.richTextBox1.SelectionStart + this.form1.richTextBox1.SelectedText.Length) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (Up.Checked == true && matchcase.Checked == false && wraparound.Checked == false)
            {
                if (form1.FindPreviousNoWrapAround(this.txtFind.Text, 0, this.form1.richTextBox1.SelectionStart) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (Up.Checked == true && matchcase.Checked == true && wraparound.Checked == false)
            {
                if (form1.FindPreviousNoWrapAround(this.txtFind.Text, 0, this.form1.richTextBox1.SelectionStart) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (Up.Checked == true && matchcase.Checked == false && wraparound.Checked == true)
            {
                if (form1.FindPreviousNone(this.txtFind.Text, 0, this.form1.richTextBox1.SelectionStart) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            else if (Up.Checked == true && matchcase.Checked == true && wraparound.Checked == true)
            {
                if (form1.FindPrevious(this.txtFind.Text, 0, this.form1.richTextBox1.SelectionStart) == -1)
                {
                    MessageBox.Show("No match found");
                }
                this.TopMost = true;
                this.form1.Activate();
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
