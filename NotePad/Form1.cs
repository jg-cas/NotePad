using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace NotePad //Windows XP Notepad Copy cat application
{
    public partial class Form1 : Form
    {
        FindDialog finddialog;
        private string FileName = "Untitled.txt"; //empty container in order for save and saveas to work
        float zoom = 1.0f;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ZoomFactor = zoom;
            richTextBox1.Text = "Hello!";
            richTextBox1.Select(0, 6);
            StatusStrip();
            Title();
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) //right click on the text box open a drop down menu at cursor position
            {
                contextMenuStrip1.Show(Cursor.Position);
                StatusStrip();
            }
            StatusStrip(); //every click on the text box updates line and column
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName); //read all text from the file selected
                FileName = openFileDialog1.FileName; //filename container gets filled with the filename from file dialog box
            }
            Title();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FileName)) //if filename is not existent work as a saveas
            {
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.InitialDirectory = "C:\\Users\\jgcjc\\OneDrive\\Documents";
                saveFileDialog1.DefaultExt = ".txt";
                saveFileDialog1.Filter = "Text File|*.txt|Word Document|*.doc|PDF File|*.pdf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text); //open file from selected file in dialog box and write everything from text box
                    FileName = saveFileDialog1.FileName; //update filename container
                }
            }
            else
            {
                File.WriteAllText(FileName, richTextBox1.Text); //if filename is existent, open that file name and write all text
            }
            Title();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save File"; 
            saveFileDialog1.InitialDirectory = "C:\\Users\\jgcjc\\OneDrive\\Documents"; 
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|Word Document|*.doc|PDF File|*.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text); //open file from selected file in dialog box and write everything from text box
                FileName = saveFileDialog1.FileName; //update filename container
            }
            Title();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = string.Empty;
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var searchEngine = "https://www.bing.com/search?q="; 
                var item = richTextBox1.SelectedText;
                Process.Start($"{searchEngine}{item}"); //opens bing to search for the selected text
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finddialog = new FindDialog(richTextBox1.SelectedText, this);
            finddialog.Show();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FindNext(richTextBox1.SelectedText, (richTextBox1.SelectionStart + richTextBox1.SelectedText.Length)) == -1) //calling find next method
            {
                MessageBox.Show("No match found");
            }
        }

        private void findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FindPrevious(richTextBox1.SelectedText, 0, richTextBox1.SelectionStart) == -1) //calling find previous method
            {
                MessageBox.Show("No match found");
            }
            
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceDialog replace = new ReplaceDialog(richTextBox1.SelectedText, this);
            replace.Show();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoTo go = new GoTo(this);
            go.Show();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = DateTime.Now.ToString();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap == true)
            {
                wordWrapToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) //change the font to the one selected
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color; //change the font color to the one selected
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (zoom >= 0.015625f && zoom <= 64f) //between minimum and maximum zoom factor for a rich text box per reference
                {
                    zoom += 0.5f;
                    richTextBox1.ZoomFactor = zoom;
                    StatusStrip(); //update zoom on the status strip
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Zoom In Anymore");
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (zoom >= 0.015625f && zoom <= 64f)
                {
                    zoom -= 0.5f;
                    richTextBox1.ZoomFactor = zoom;
                    StatusStrip();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Zoom Out Anymore");
            }
        }

        private void restoreDefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.0f; //1 is the default zoom for the rich text box
        }

        private void diToolStripMenuItem_Click(object sender, EventArgs e) //status bar
        {
            if (diToolStripMenuItem.Checked == true)
            {
                diToolStripMenuItem.Checked = false;
                statusStrip1.Hide();
            }
            else
            {
                diToolStripMenuItem.Checked = true;
                statusStrip1.Show();
            }
        }

        private void aboutNotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new Form2();
            about.ShowDialog();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e) //left click drop down menu
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = ""; 
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            pageSetupDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            StatusStrip();
        }
        private void Title()
        {
            var file = FileName.Split('\\','.');
            var filename = file[file.Length - 2];
            this.Text = $"{filename} - NotePad";
            this.Update();
        }
        private int line()
        {
            // Get the line
            int index = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(index);
            return line;
        }
        private int column()
        {
            // Get the column
            int index = richTextBox1.SelectionStart;
            int firstChar = richTextBox1.GetFirstCharIndexFromLine(line());
            int column = index - firstChar;
            return column;
        }

        private void StatusStrip()
        {
            toolStripStatusLabel1.Text = $"Ln {line()}, Col{column()}";
            toolStripStatusLabel2.Text = $"{zoom * 100}%";
            toolStripStatusLabel3.Text = "Windows (CRLF)";
            toolStripStatusLabel4.Text = "UTF-8";
            toolStripStatusLabel5.Text = string.Empty; //this label combined with spring allows the other boxes to be aligned to the rights
        }
        
        public int FindNext(string text, int start)
        {
            int returnValue = -1;
            try
            {
                if (text.Length > 0 && start >= 0)
                {
                    int indexToText = richTextBox1.Find(text, start, RichTextBoxFinds.MatchCase); //matchcase
                    if (indexToText >= 0)
                    {
                        returnValue = indexToText;
                    }
                }

                return returnValue;
            }
            catch (ArgumentOutOfRangeException) //if the cursor is at the end of the document, go back to the beggining
            {
                if (text.Length > 0 && start >= 0)
                {
                    int indexToText = richTextBox1.Find(text, 0, RichTextBoxFinds.MatchCase); //matchcase
                    if (indexToText >= 0)
                    {
                        returnValue = indexToText;
                    }
                }
                return returnValue;
            }
            
        }

        public int FindPrevious(string text, int start, int stop)
        {
            int returnValue = -1;

            if (text.Length > 0 && start >= 0)
            {
                int indexToText = richTextBox1.Find(text, start, stop, RichTextBoxFinds.Reverse); //reverse
                if (indexToText >= 0)
                {
                    returnValue = indexToText;
                }
            }

            return returnValue;
        }
        public int FindNextNone(string text, int start)
        {
            int returnValue = -1;
            try
            {
                if (text.Length > 0 && start >= 0)
                {
                    int indexToText = richTextBox1.Find(text, start, RichTextBoxFinds.None); //matchcase
                    if (indexToText >= 0)
                    {
                        returnValue = indexToText;
                    }
                }

                return returnValue;
            }
            catch (ArgumentOutOfRangeException) //if the cursor is at the end of the document, go back to the beggining
            {
                if (text.Length > 0 && start >= 0)
                {
                    int indexToText = richTextBox1.Find(text, 0, RichTextBoxFinds.None); //matchcase
                    if (indexToText >= 0)
                    {
                        returnValue = indexToText;
                    }
                }
                return returnValue;
            }
        }
        public int FindNextNoneNoWrapAround(string text, int start)
        {
            int returnValue = -1;
            int index = richTextBox1.SelectionStart;

            if (text.Length > 0 && start >= index) //compares with index so there is no wrap around
            {
                int indexToText = richTextBox1.Find(text, start, RichTextBoxFinds.None);
                if (indexToText > index)
                {
                    returnValue = indexToText;
                }
            }

            return returnValue;
        }
        public int FindNextNoWrapAround(string text, int start)
        {
            int returnValue = -1;
            int index = richTextBox1.SelectionStart;

            if (text.Length > 0 && start >= index)
            {
                int indexToText = richTextBox1.Find(text, start, RichTextBoxFinds.MatchCase);
                if (indexToText > index)
                {
                    returnValue = indexToText;
                }
            }

            return returnValue;
        }

        public int FindPreviousNone(string text, int start, int stop)
        {
            int returnValue = -1;

            if (text.Length > 0 && start >= 0)
            {
                int indexToText = richTextBox1.Find(text, start, stop, RichTextBoxFinds.Reverse);
                if (indexToText >= 0)
                {
                    returnValue = indexToText;
                }
            }

            return returnValue;
        }
        public int FindPreviousNoWrapAround(string text, int start, int stop)
        {
            int returnValue = -1;

            if (text.Length > 0 && stop != 0)
            {
                int indexToText = richTextBox1.Find(text, start, stop, RichTextBoxFinds.Reverse);
                if (indexToText >= 0)
                {
                    returnValue = indexToText;
                }
            }

            return returnValue;
        }
    }
}
