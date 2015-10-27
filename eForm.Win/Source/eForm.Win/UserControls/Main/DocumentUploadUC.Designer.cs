namespace eForm.Win.UserControls
{
    partial class DocumentUploadUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleBarUC1 = new eForm.Win.UserControls.TitleBarUC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleBarUC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 50);
            this.panel1.TabIndex = 19;
            // 
            // titleBarUC1
            // 
            this.titleBarUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBarUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBarUC1.Location = new System.Drawing.Point(0, 0);
            this.titleBarUC1.Name = "titleBarUC1";
            this.titleBarUC1.Size = new System.Drawing.Size(937, 50);
            this.titleBarUC1.TabIndex = 0;
            this.titleBarUC1.Title = "Document Upload";
            this.titleBarUC1.ButtonClick += new System.EventHandler<eForm.Win.ButtonClickEventArgs>(this.titleBarUC1_ButtonClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 50);
            this.panel2.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnUpload);
            this.panel5.Controls.Add(this.btnNext);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(644, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 50);
            this.panel5.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpload.Location = new System.Drawing.Point(93, 0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 50);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(193, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 50);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBrowse);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 406);
            this.panel3.TabIndex = 21;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(450, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. MyKad Scanned Copy";
            // 
            // DocumentUploadUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DocumentUploadUC";
            this.Size = new System.Drawing.Size(937, 506);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private TitleBarUC titleBarUC1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
