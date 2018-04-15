namespace Project.UI
{
    partial class HomePage
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
            this.categorylistdg = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsB = new System.Windows.Forms.Button();
            this.recordsB = new System.Windows.Forms.Button();
            this.chooseB = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categorylistdg)).BeginInit();
            this.SuspendLayout();
            // 
            // categorylistdg
            // 
            this.categorylistdg.AllowUserToAddRows = false;
            this.categorylistdg.AllowUserToDeleteRows = false;
            this.categorylistdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorylistdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.categorylistdg.Location = new System.Drawing.Point(97, 12);
            this.categorylistdg.Name = "categorylistdg";
            this.categorylistdg.ReadOnly = true;
            this.categorylistdg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categorylistdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categorylistdg.Size = new System.Drawing.Size(145, 284);
            this.categorylistdg.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // detailsB
            // 
            this.detailsB.Location = new System.Drawing.Point(12, 153);
            this.detailsB.Name = "detailsB";
            this.detailsB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.detailsB.Size = new System.Drawing.Size(75, 23);
            this.detailsB.TabIndex = 1;
            this.detailsB.Text = "مشخصات";
            this.detailsB.UseVisualStyleBackColor = true;
            // 
            // recordsB
            // 
            this.recordsB.Location = new System.Drawing.Point(12, 244);
            this.recordsB.Name = "recordsB";
            this.recordsB.Size = new System.Drawing.Size(75, 23);
            this.recordsB.TabIndex = 2;
            this.recordsB.Text = "سوابق";
            this.recordsB.UseVisualStyleBackColor = true;
            this.recordsB.Click += new System.EventHandler(this.recordsB_Click);
            // 
            // chooseB
            // 
            this.chooseB.Location = new System.Drawing.Point(213, 310);
            this.chooseB.Name = "chooseB";
            this.chooseB.Size = new System.Drawing.Size(75, 23);
            this.chooseB.TabIndex = 3;
            this.chooseB.Text = "انتخاب";
            this.chooseB.UseVisualStyleBackColor = true;
            this.chooseB.Click += new System.EventHandler(this.chooseB_Click);
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(12, 310);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 33;
            this.backB.Text = "بازگشت";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 345);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.chooseB);
            this.Controls.Add(this.recordsB);
            this.Controls.Add(this.detailsB);
            this.Controls.Add(this.categorylistdg);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorylistdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView categorylistdg;
        private System.Windows.Forms.Button detailsB;
        private System.Windows.Forms.Button recordsB;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button chooseB;
        private System.Windows.Forms.Button backB;
    }
}