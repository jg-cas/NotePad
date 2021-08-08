
namespace NotePad
{
    partial class ReplaceDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceDialog));
            this.wraparound = new System.Windows.Forms.CheckBox();
            this.matchcase = new System.Windows.Forms.CheckBox();
            this.replace = new System.Windows.Forms.Button();
            this.findnext = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceall = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wraparound
            // 
            this.wraparound.AutoSize = true;
            this.wraparound.Location = new System.Drawing.Point(188, 99);
            this.wraparound.Name = "wraparound";
            this.wraparound.Size = new System.Drawing.Size(88, 17);
            this.wraparound.TabIndex = 14;
            this.wraparound.Text = "Wrap around";
            this.wraparound.UseVisualStyleBackColor = true;
            // 
            // matchcase
            // 
            this.matchcase.AutoSize = true;
            this.matchcase.Location = new System.Drawing.Point(88, 99);
            this.matchcase.Name = "matchcase";
            this.matchcase.Size = new System.Drawing.Size(82, 17);
            this.matchcase.TabIndex = 13;
            this.matchcase.Text = "Match case";
            this.matchcase.UseVisualStyleBackColor = true;
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(291, 41);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(75, 23);
            this.replace.TabIndex = 11;
            this.replace.Text = "Replace";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // findnext
            // 
            this.findnext.Location = new System.Drawing.Point(291, 12);
            this.findnext.Name = "findnext";
            this.findnext.Size = new System.Drawing.Size(75, 23);
            this.findnext.TabIndex = 10;
            this.findnext.Text = "Find Next";
            this.findnext.UseVisualStyleBackColor = true;
            this.findnext.Click += new System.EventHandler(this.findnext_Click);
            // 
            // txtFind
            // 
            this.txtFind.AcceptsReturn = true;
            this.txtFind.Location = new System.Drawing.Point(88, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(197, 20);
            this.txtFind.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find what:";
            // 
            // replaceall
            // 
            this.replaceall.Location = new System.Drawing.Point(291, 70);
            this.replaceall.Name = "replaceall";
            this.replaceall.Size = new System.Drawing.Size(75, 23);
            this.replaceall.TabIndex = 15;
            this.replaceall.Text = "Replace All";
            this.replaceall.UseVisualStyleBackColor = true;
            this.replaceall.Click += new System.EventHandler(this.replaceall_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(291, 99);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.AcceptsReturn = true;
            this.txtReplace.Location = new System.Drawing.Point(88, 41);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(197, 20);
            this.txtReplace.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Replace with:";
            // 
            // ReplaceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 135);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.replaceall);
            this.Controls.Add(this.wraparound);
            this.Controls.Add(this.matchcase);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.findnext);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplaceDialog";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox wraparound;
        private System.Windows.Forms.CheckBox matchcase;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Button findnext;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button replaceall;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label label2;
    }
}