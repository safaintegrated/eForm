namespace eForm.Win.UserControls
{
    partial class TermAndConditionUC
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
            this.btnNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleBarUC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 50);
            this.panel1.TabIndex = 19;
            // 
            // titleBarUC1
            // 
            this.titleBarUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBarUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBarUC1.Location = new System.Drawing.Point(0, 0);
            this.titleBarUC1.Name = "titleBarUC1";
            this.titleBarUC1.Size = new System.Drawing.Size(891, 50);
            this.titleBarUC1.TabIndex = 0;
            this.titleBarUC1.Title = "Term && Condition";
            this.titleBarUC1.ButtonClick += new System.EventHandler<eForm.Win.ButtonClickEventArgs>(this.titleBarUC1_ButtonClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 50);
            this.panel2.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnNew);
            this.panel5.Controls.Add(this.btnNext);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(598, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 50);
            this.panel5.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(193, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 50);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Save";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 455);
            this.panel3.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::eForm.Win.Properties.Resources.end_user_term;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 455);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.Location = new System.Drawing.Point(93, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 50);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "MyKad";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // TermAndConditionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TermAndConditionUC";
            this.Size = new System.Drawing.Size(891, 555);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private TitleBarUC titleBarUC1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNew;
    }
}
