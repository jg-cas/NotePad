
namespace NotePad
{
    partial class FindDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.RadioButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.findnext = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Direction = new System.Windows.Forms.GroupBox();
            this.down = new System.Windows.Forms.RadioButton();
            this.matchcase = new System.Windows.Forms.CheckBox();
            this.wraparound = new System.Windows.Forms.CheckBox();
            this.Direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.Location = new System.Drawing.Point(6, 19);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(39, 17);
            this.Up.TabIndex = 1;
            this.Up.TabStop = true;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.AcceptsReturn = true;
            this.txtFind.Location = new System.Drawing.Point(74, 6);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(197, 20);
            this.txtFind.TabIndex = 2;
            // 
            // findnext
            // 
            this.findnext.Location = new System.Drawing.Point(277, 6);
            this.findnext.Name = "findnext";
            this.findnext.Size = new System.Drawing.Size(75, 23);
            this.findnext.TabIndex = 3;
            this.findnext.Text = "Find Next";
            this.findnext.UseVisualStyleBackColor = true;
            this.findnext.Click += new System.EventHandler(this.findnext_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(277, 35);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Direction
            // 
            this.Direction.Controls.Add(this.down);
            this.Direction.Controls.Add(this.Up);
            this.Direction.Location = new System.Drawing.Point(154, 35);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(117, 43);
            this.Direction.TabIndex = 5;
            this.Direction.TabStop = false;
            this.Direction.Text = "Direction";
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.Location = new System.Drawing.Point(58, 20);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(53, 17);
            this.down.TabIndex = 6;
            this.down.TabStop = true;
            this.down.Text = "Down";
            this.down.UseVisualStyleBackColor = true;
            // 
            // matchcase
            // 
            this.matchcase.AutoSize = true;
            this.matchcase.Location = new System.Drawing.Point(0, 61);
            this.matchcase.Name = "matchcase";
            this.matchcase.Size = new System.Drawing.Size(82, 17);
            this.matchcase.TabIndex = 6;
            this.matchcase.Text = "Match case";
            this.matchcase.UseVisualStyleBackColor = true;
            // 
            // wraparound
            // 
            this.wraparound.AutoSize = true;
            this.wraparound.Location = new System.Drawing.Point(0, 84);
            this.wraparound.Name = "wraparound";
            this.wraparound.Size = new System.Drawing.Size(88, 17);
            this.wraparound.TabIndex = 7;
            this.wraparound.Text = "Wrap around";
            this.wraparound.UseVisualStyleBackColor = true;
            // 
            // FindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 119);
            this.Controls.Add(this.wraparound);
            this.Controls.Add(this.matchcase);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.findnext);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindDialog";
            this.Text = "Find";
            this.Direction.ResumeLayout(false);
            this.Direction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Up;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button findnext;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox Direction;
        private System.Windows.Forms.RadioButton down;
        private System.Windows.Forms.CheckBox matchcase;
        private System.Windows.Forms.CheckBox wraparound;
    }
}