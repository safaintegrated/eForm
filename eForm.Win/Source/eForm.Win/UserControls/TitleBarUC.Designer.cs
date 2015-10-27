namespace eForm.Win.UserControls
{
    partial class TitleBarUC
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMyApp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnMyApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(399, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = global::eForm.Win.Properties.Resources.house;
            this.btnDashboard.Location = new System.Drawing.Point(132, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(130, 55);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMyApp
            // 
            this.btnMyApp.BackColor = System.Drawing.Color.White;
            this.btnMyApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMyApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyApp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyApp.Image = global::eForm.Win.Properties.Resources.window_layout1;
            this.btnMyApp.Location = new System.Drawing.Point(262, 0);
            this.btnMyApp.Name = "btnMyApp";
            this.btnMyApp.Size = new System.Drawing.Size(130, 55);
            this.btnMyApp.TabIndex = 1;
            this.btnMyApp.Text = "My \r\nPerformance";
            this.btnMyApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyApp.UseVisualStyleBackColor = false;
            this.btnMyApp.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 55);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(399, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleBarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TitleBarUC";
            this.Size = new System.Drawing.Size(791, 55);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMyApp;
    }
}
