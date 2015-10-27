namespace eForm.Win.Forms
{
    partial class TermAndConditionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkIsAgree = new System.Windows.Forms.CheckBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkIsAgree);
            this.panel3.Controls.Add(this.btnContinue);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(33, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 36);
            this.panel3.TabIndex = 3;
            // 
            // chkIsAgree
            // 
            this.chkIsAgree.AutoSize = true;
            this.chkIsAgree.Location = new System.Drawing.Point(7, 10);
            this.chkIsAgree.Name = "chkIsAgree";
            this.chkIsAgree.Size = new System.Drawing.Size(270, 17);
            this.chkIsAgree.TabIndex = 0;
            this.chkIsAgree.Text = "I have read and agreed to the Term and Conditions.";
            this.chkIsAgree.UseVisualStyleBackColor = true;
            this.chkIsAgree.CheckedChanged += new System.EventHandler(this.chkIsAgree_CheckedChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(283, 6);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 426);
            this.panel2.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(484, 426);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // TermAndConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TermAndConditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TermAndConditionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TermAndConditionForm_FormClosing);
            this.Load += new System.EventHandler(this.TermAndConditionForm_Load);
            this.VisibleChanged += new System.EventHandler(this.TermAndConditionForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkIsAgree;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}