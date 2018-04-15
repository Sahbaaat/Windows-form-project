namespace Project.UI
{
    partial class AddActivity
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
            this.acceptB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advantageT = new System.Windows.Forms.TextBox();
            this.distanceT = new System.Windows.Forms.TextBox();
            this.timeT = new System.Windows.Forms.TextBox();
            this.costT = new System.Windows.Forms.TextBox();
            this.titleT = new System.Windows.Forms.TextBox();
            this.discriptionT = new System.Windows.Forms.RichTextBox();
            this.declineB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "نام";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "توضیحات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "سودمندی";
            // 
            // acceptB
            // 
            this.acceptB.Location = new System.Drawing.Point(230, 321);
            this.acceptB.Name = "acceptB";
            this.acceptB.Size = new System.Drawing.Size(75, 23);
            this.acceptB.TabIndex = 27;
            this.acceptB.Text = "قبول";
            this.acceptB.UseVisualStyleBackColor = true;
            this.acceptB.Click += new System.EventHandler(this.acceptB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "هزینه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "زمان";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "مسافت";
            // 
            // advantageT
            // 
            this.advantageT.Location = new System.Drawing.Point(269, 279);
            this.advantageT.Name = "advantageT";
            this.advantageT.ReadOnly = true;
            this.advantageT.Size = new System.Drawing.Size(36, 20);
            this.advantageT.TabIndex = 22;
            // 
            // distanceT
            // 
            this.distanceT.Location = new System.Drawing.Point(269, 238);
            this.distanceT.Name = "distanceT";
            this.distanceT.ReadOnly = true;
            this.distanceT.Size = new System.Drawing.Size(36, 20);
            this.distanceT.TabIndex = 21;
            // 
            // timeT
            // 
            this.timeT.Location = new System.Drawing.Point(269, 195);
            this.timeT.Name = "timeT";
            this.timeT.ReadOnly = true;
            this.timeT.Size = new System.Drawing.Size(36, 20);
            this.timeT.TabIndex = 20;
            // 
            // costT
            // 
            this.costT.Location = new System.Drawing.Point(269, 152);
            this.costT.Name = "costT";
            this.costT.ReadOnly = true;
            this.costT.Size = new System.Drawing.Size(36, 20);
            this.costT.TabIndex = 19;
            // 
            // titleT
            // 
            this.titleT.Location = new System.Drawing.Point(145, 23);
            this.titleT.Name = "titleT";
            this.titleT.ReadOnly = true;
            this.titleT.Size = new System.Drawing.Size(100, 20);
            this.titleT.TabIndex = 18;
            // 
            // discriptionT
            // 
            this.discriptionT.Location = new System.Drawing.Point(83, 70);
            this.discriptionT.Name = "discriptionT";
            this.discriptionT.ReadOnly = true;
            this.discriptionT.Size = new System.Drawing.Size(185, 60);
            this.discriptionT.TabIndex = 17;
            this.discriptionT.Text = "";
            // 
            // declineB
            // 
            this.declineB.Location = new System.Drawing.Point(107, 321);
            this.declineB.Name = "declineB";
            this.declineB.Size = new System.Drawing.Size(75, 23);
            this.declineB.TabIndex = 32;
            this.declineB.Text = "رد";
            this.declineB.UseVisualStyleBackColor = true;
            this.declineB.Click += new System.EventHandler(this.declineB_Click);
            // 
            // AddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 371);
            this.Controls.Add(this.declineB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.acceptB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advantageT);
            this.Controls.Add(this.distanceT);
            this.Controls.Add(this.timeT);
            this.Controls.Add(this.costT);
            this.Controls.Add(this.titleT);
            this.Controls.Add(this.discriptionT);
            this.Name = "AddActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddActivity";
            this.Load += new System.EventHandler(this.AddActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button acceptB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox advantageT;
        private System.Windows.Forms.TextBox distanceT;
        private System.Windows.Forms.TextBox timeT;
        private System.Windows.Forms.TextBox costT;
        private System.Windows.Forms.TextBox titleT;
        private System.Windows.Forms.RichTextBox discriptionT;
        private System.Windows.Forms.Button declineB;
    }
}