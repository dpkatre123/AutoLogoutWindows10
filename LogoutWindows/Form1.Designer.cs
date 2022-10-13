namespace LogoutWindows
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLgout = new System.Windows.Forms.Label();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reset Time (Minutes)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(12, 38);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(150, 31);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "300";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time to Logout";
            // 
            // lblLgout
            // 
            this.lblLgout.AutoSize = true;
            this.lblLgout.Location = new System.Drawing.Point(174, 134);
            this.lblLgout.Name = "lblLgout";
            this.lblLgout.Size = new System.Drawing.Size(134, 25);
            this.lblLgout.TabIndex = 5;
            this.lblLgout.Text = "Time to Logout";
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.Location = new System.Drawing.Point(384, 44);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(0, 25);
            this.lblErrorText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.lblLgout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTime);
            this.Name = "Form1";
            this.Text = "Windows Logout";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLgout;
        private System.Windows.Forms.Label lblErrorText;
    }
}
