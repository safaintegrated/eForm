namespace eForm.Win.Forms
{
    partial class WebApiTestForm
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
            this.btnGetAllApplication = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPushApplication = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetAllApplication
            // 
            this.btnGetAllApplication.Location = new System.Drawing.Point(21, 12);
            this.btnGetAllApplication.Name = "btnGetAllApplication";
            this.btnGetAllApplication.Size = new System.Drawing.Size(117, 23);
            this.btnGetAllApplication.TabIndex = 0;
            this.btnGetAllApplication.Text = "Get All Application";
            this.btnGetAllApplication.UseVisualStyleBackColor = true;
            this.btnGetAllApplication.Click += new System.EventHandler(this.btnGetAllApplication_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Authenticate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPushApplication
            // 
            this.btnPushApplication.Location = new System.Drawing.Point(21, 41);
            this.btnPushApplication.Name = "btnPushApplication";
            this.btnPushApplication.Size = new System.Drawing.Size(117, 23);
            this.btnPushApplication.TabIndex = 2;
            this.btnPushApplication.Text = "Push Application";
            this.btnPushApplication.UseVisualStyleBackColor = true;
            this.btnPushApplication.Click += new System.EventHandler(this.btnPushApplication_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Activate";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Get Authorize User";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Get Authorize Reader";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // WebApiTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 262);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPushApplication);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGetAllApplication);
            this.Name = "WebApiTestForm";
            this.Text = "WebApiTestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllApplication;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPushApplication;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}