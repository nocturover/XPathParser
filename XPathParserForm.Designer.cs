
namespace XPathParser
{
    partial class XPathParserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCopied = new System.Windows.Forms.TextBox();
            this.txtParsedStr = new System.Windows.Forms.TextBox();
            this.chkAutoCopy = new System.Windows.Forms.CheckBox();
            this.chkByXpath = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtCopied
            // 
            this.txtCopied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtCopied.ForeColor = System.Drawing.Color.White;
            this.txtCopied.Location = new System.Drawing.Point(12, 12);
            this.txtCopied.Name = "txtCopied";
            this.txtCopied.Size = new System.Drawing.Size(400, 23);
            this.txtCopied.TabIndex = 0;
            // 
            // txtParsedStr
            // 
            this.txtParsedStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtParsedStr.ForeColor = System.Drawing.Color.White;
            this.txtParsedStr.Location = new System.Drawing.Point(12, 41);
            this.txtParsedStr.Name = "txtParsedStr";
            this.txtParsedStr.Size = new System.Drawing.Size(400, 23);
            this.txtParsedStr.TabIndex = 0;
            // 
            // chkAutoCopy
            // 
            this.chkAutoCopy.AutoSize = true;
            this.chkAutoCopy.ForeColor = System.Drawing.Color.White;
            this.chkAutoCopy.Location = new System.Drawing.Point(12, 70);
            this.chkAutoCopy.Name = "chkAutoCopy";
            this.chkAutoCopy.Size = new System.Drawing.Size(84, 19);
            this.chkAutoCopy.TabIndex = 1;
            this.chkAutoCopy.Text = "Auto Copy";
            this.chkAutoCopy.UseVisualStyleBackColor = true;
            // 
            // chkByXpath
            // 
            this.chkByXpath.AutoSize = true;
            this.chkByXpath.ForeColor = System.Drawing.Color.White;
            this.chkByXpath.Location = new System.Drawing.Point(102, 70);
            this.chkByXpath.Name = "chkByXpath";
            this.chkByXpath.Size = new System.Drawing.Size(73, 19);
            this.chkByXpath.TabIndex = 2;
            this.chkByXpath.Text = "By.XPath";
            this.chkByXpath.UseVisualStyleBackColor = true;
            // 
            // XPathParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(428, 107);
            this.Controls.Add(this.chkByXpath);
            this.Controls.Add(this.chkAutoCopy);
            this.Controls.Add(this.txtParsedStr);
            this.Controls.Add(this.txtCopied);
            this.Name = "XPathParserForm";
            this.Text = "XPath Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCopied;
        private System.Windows.Forms.TextBox txtParsedStr;
        private System.Windows.Forms.CheckBox chkAutoCopy;
        private System.Windows.Forms.CheckBox chkByXpath;
    }
}

