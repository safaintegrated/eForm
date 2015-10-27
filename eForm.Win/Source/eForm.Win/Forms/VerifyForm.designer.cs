namespace eForm.Win.Forms
{
    partial class VerifyForm
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
            this.components = new System.ComponentModel.Container();
            this.txtSMsg = new System.Windows.Forms.TextBox();
            this.txtAMsg = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.picViewer = new System.Windows.Forms.PictureBox();
            this.txtStat = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSMsg
            // 
            this.txtSMsg.Location = new System.Drawing.Point(436, 44);
            this.txtSMsg.Name = "txtSMsg";
            this.txtSMsg.Size = new System.Drawing.Size(100, 20);
            this.txtSMsg.TabIndex = 12;
            this.txtSMsg.Text = "textBox2";
            // 
            // txtAMsg
            // 
            this.txtAMsg.Location = new System.Drawing.Point(436, 20);
            this.txtAMsg.Name = "txtAMsg";
            this.txtAMsg.Size = new System.Drawing.Size(100, 20);
            this.txtAMsg.TabIndex = 11;
            this.txtAMsg.Text = "textBox2";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(114, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnScan.Location = new System.Drawing.Point(8, 285);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(100, 23);
            this.btnScan.TabIndex = 9;
            this.btnScan.Text = "Scan Again";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // picViewer
            // 
            this.picViewer.BackColor = System.Drawing.Color.White;
            this.picViewer.Location = new System.Drawing.Point(11, 40);
            this.picViewer.Name = "picViewer";
            this.picViewer.Size = new System.Drawing.Size(203, 202);
            this.picViewer.TabIndex = 8;
            this.picViewer.TabStop = false;
            // 
            // txtStat
            // 
            this.txtStat.BackColor = System.Drawing.Color.White;
            this.txtStat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtStat.Location = new System.Drawing.Point(8, 248);
            this.txtStat.Multiline = true;
            this.txtStat.Name = "txtStat";
            this.txtStat.ReadOnly = true;
            this.txtStat.Size = new System.Drawing.Size(206, 31);
            this.txtStat.TabIndex = 7;
            this.txtStat.TabStop = false;
            this.txtStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please place your finger print on reader";
            // 
            // VerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSMsg);
            this.Controls.Add(this.txtAMsg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.picViewer);
            this.Controls.Add(this.txtStat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "VerifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VerifyForm";
            this.Load += new System.EventHandler(this.VerifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSMsg;
        private System.Windows.Forms.TextBox txtAMsg;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox picViewer;
        private System.Windows.Forms.TextBox txtStat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}