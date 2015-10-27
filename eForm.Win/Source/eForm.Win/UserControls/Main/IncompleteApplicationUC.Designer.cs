namespace eForm.Win.UserControls
{
    partial class IncompleteApplicationUC
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleBarUC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 60);
            this.panel1.TabIndex = 16;
            // 
            // titleBarUC1
            // 
            this.titleBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.titleBarUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBarUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBarUC1.Location = new System.Drawing.Point(0, 0);
            this.titleBarUC1.Name = "titleBarUC1";
            this.titleBarUC1.Size = new System.Drawing.Size(902, 60);
            this.titleBarUC1.TabIndex = 0;
            this.titleBarUC1.Title = "Incomplete Application";
            // 
            // IncompleteApplicationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "IncompleteApplicationUC";
            this.Size = new System.Drawing.Size(902, 729);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private TitleBarUC titleBarUC1;
    }
}
