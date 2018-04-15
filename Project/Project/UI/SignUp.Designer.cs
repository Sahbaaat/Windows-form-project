namespace Project.UI
{
    partial class SignUp
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
            this.signupB = new System.Windows.Forms.Button();
            this.passwordT = new System.Windows.Forms.TextBox();
            this.usernameT = new System.Windows.Forms.TextBox();
            this.emailT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signupB
            // 
            this.signupB.Location = new System.Drawing.Point(103, 213);
            this.signupB.Name = "signupB";
            this.signupB.Size = new System.Drawing.Size(75, 23);
            this.signupB.TabIndex = 0;
            this.signupB.Text = "ثبت";
            this.signupB.UseVisualStyleBackColor = true;
            this.signupB.Click += new System.EventHandler(this.signupB_Click);
            // 
            // passwordT
            // 
            this.passwordT.Location = new System.Drawing.Point(89, 148);
            this.passwordT.Name = "passwordT";
            this.passwordT.Size = new System.Drawing.Size(100, 20);
            this.passwordT.TabIndex = 1;
            // 
            // usernameT
            // 
            this.usernameT.Location = new System.Drawing.Point(89, 95);
            this.usernameT.Name = "usernameT";
            this.usernameT.Size = new System.Drawing.Size(100, 20);
            this.usernameT.TabIndex = 2;
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(89, 48);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(100, 20);
            this.emailT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ایمیل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "نام کاربری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "رمز عبور";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailT);
            this.Controls.Add(this.usernameT);
            this.Controls.Add(this.passwordT);
            this.Controls.Add(this.signupB);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signupB;
        private System.Windows.Forms.TextBox passwordT;
        private System.Windows.Forms.TextBox usernameT;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}