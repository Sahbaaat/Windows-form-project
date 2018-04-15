namespace Project.UI
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameT = new System.Windows.Forms.TextBox();
            this.passwordT = new System.Windows.Forms.TextBox();
            this.loginB = new System.Windows.Forms.Button();
            this.signupB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "رمز عبور";
            // 
            // usernameT
            // 
            this.usernameT.Location = new System.Drawing.Point(80, 51);
            this.usernameT.Name = "usernameT";
            this.usernameT.Size = new System.Drawing.Size(100, 20);
            this.usernameT.TabIndex = 2;
            // 
            // passwordT
            // 
            this.passwordT.Location = new System.Drawing.Point(80, 87);
            this.passwordT.Name = "passwordT";
            this.passwordT.Size = new System.Drawing.Size(100, 20);
            this.passwordT.TabIndex = 3;
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(90, 135);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(75, 23);
            this.loginB.TabIndex = 4;
            this.loginB.Text = "ورود";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // signupB
            // 
            this.signupB.Location = new System.Drawing.Point(90, 226);
            this.signupB.Name = "signupB";
            this.signupB.Size = new System.Drawing.Size(75, 23);
            this.signupB.TabIndex = 5;
            this.signupB.Text = "ثبت نام";
            this.signupB.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.signupB);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.passwordT);
            this.Controls.Add(this.usernameT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameT;
        private System.Windows.Forms.TextBox passwordT;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Button signupB;
    }
}