namespace Project.UI
{
    partial class SuggestActivity
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.suggestB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advantageT = new System.Windows.Forms.TextBox();
            this.distanceT = new System.Windows.Forms.TextBox();
            this.timeT = new System.Windows.Forms.TextBox();
            this.costT = new System.Windows.Forms.TextBox();
            this.titleT = new System.Windows.Forms.TextBox();
            this.discriptionT = new System.Windows.Forms.RichTextBox();
            this.backB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "نام";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "توضیحات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "سودمندی";
            // 
            // suggestB
            // 
            this.suggestB.Location = new System.Drawing.Point(226, 318);
            this.suggestB.Name = "suggestB";
            this.suggestB.Size = new System.Drawing.Size(75, 23);
            this.suggestB.TabIndex = 27;
            this.suggestB.Text = "بیشنهاد";
            this.suggestB.UseVisualStyleBackColor = true;
            this.suggestB.Click += new System.EventHandler(this.suggestB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "هزینه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "زمان";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "مسافت";
            // 
            // advantageT
            // 
            this.advantageT.Location = new System.Drawing.Point(265, 277);
            this.advantageT.Name = "advantageT";
            this.advantageT.Size = new System.Drawing.Size(36, 20);
            this.advantageT.TabIndex = 22;
            // 
            // distanceT
            // 
            this.distanceT.Location = new System.Drawing.Point(265, 236);
            this.distanceT.Name = "distanceT";
            this.distanceT.Size = new System.Drawing.Size(36, 20);
            this.distanceT.TabIndex = 21;
            // 
            // timeT
            // 
            this.timeT.Location = new System.Drawing.Point(265, 193);
            this.timeT.Name = "timeT";
            this.timeT.Size = new System.Drawing.Size(36, 20);
            this.timeT.TabIndex = 20;
            // 
            // costT
            // 
            this.costT.Location = new System.Drawing.Point(265, 150);
            this.costT.Name = "costT";
            this.costT.Size = new System.Drawing.Size(36, 20);
            this.costT.TabIndex = 19;
            // 
            // titleT
            // 
            this.titleT.Location = new System.Drawing.Point(141, 21);
            this.titleT.Name = "titleT";
            this.titleT.Size = new System.Drawing.Size(100, 20);
            this.titleT.TabIndex = 18;
            // 
            // discriptionT
            // 
            this.discriptionT.Location = new System.Drawing.Point(79, 68);
            this.discriptionT.Name = "discriptionT";
            this.discriptionT.Size = new System.Drawing.Size(185, 60);
            this.discriptionT.TabIndex = 17;
            this.discriptionT.Text = "";
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(55, 332);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 32;
            this.backB.Text = "بازگشت";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // SuggestActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 367);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.suggestB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advantageT);
            this.Controls.Add(this.distanceT);
            this.Controls.Add(this.timeT);
            this.Controls.Add(this.costT);
            this.Controls.Add(this.titleT);
            this.Controls.Add(this.discriptionT);
            this.Name = "SuggestActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuggestActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button suggestB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox advantageT;
        private System.Windows.Forms.TextBox distanceT;
        private System.Windows.Forms.TextBox timeT;
        private System.Windows.Forms.TextBox costT;
        private System.Windows.Forms.TextBox titleT;
        private System.Windows.Forms.RichTextBox discriptionT;
        private System.Windows.Forms.Button backB;
    }
}