namespace eForm.Win.Forms
{
    partial class ApplicationUpdateForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCheckForUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(241, 169);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Now";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 147);
            this.listBox1.TabIndex = 1;
            // 
            // btnCheckForUpdate
            // 
            this.btnCheckForUpdate.Location = new System.Drawing.Point(160, 169);
            this.btnCheckForUpdate.Name = "btnCheckForUpdate";
            this.btnCheckForUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCheckForUpdate.TabIndex = 0;
            this.btnCheckForUpdate.Text = "Details Update";
            this.btnCheckForUpdate.UseVisualStyleBackColor = true;
            this.btnCheckForUpdate.Click += new System.EventHandler(this.btnCheckForUpdate_Click);
            // 
            // ApplicationUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 204);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCheckForUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Name = "ApplicationUpdateForm";
            this.Text = "ApplicationUpdateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCheckForUpdate;
    }
}