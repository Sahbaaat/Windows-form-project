namespace Project.UI
{
    partial class AdminLogin
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
            this.categorysuggestedlistdg = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseB = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categorysuggestedlistdg)).BeginInit();
            this.SuspendLayout();
            // 
            // categorysuggestedlistdg
            // 
            this.categorysuggestedlistdg.AllowUserToAddRows = false;
            this.categorysuggestedlistdg.AllowUserToDeleteRows = false;
            this.categorysuggestedlistdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorysuggestedlistdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.categorysuggestedlistdg.Location = new System.Drawing.Point(56, 25);
            this.categorysuggestedlistdg.Name = "categorysuggestedlistdg";
            this.categorysuggestedlistdg.ReadOnly = true;
            this.categorysuggestedlistdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categorysuggestedlistdg.Size = new System.Drawing.Size(144, 284);
            this.categorysuggestedlistdg.TabIndex = 1;
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
            // chooseB
            // 
            this.chooseB.Location = new System.Drawing.Point(174, 328);
            this.chooseB.Name = "chooseB";
            this.chooseB.Size = new System.Drawing.Size(75, 23);
            this.chooseB.TabIndex = 2;
            this.chooseB.Text = "انتخاب";
            this.chooseB.UseVisualStyleBackColor = true;
            this.chooseB.Click += new System.EventHandler(this.chooseB_Click);
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(12, 328);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 33;
            this.backB.Text = "بازگشت";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 363);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.chooseB);
            this.Controls.Add(this.categorysuggestedlistdg);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorysuggestedlistdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView categorysuggestedlistdg;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button chooseB;
        private System.Windows.Forms.Button backB;
    }
}