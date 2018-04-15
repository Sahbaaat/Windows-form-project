namespace Project.UI
{
    partial class SuggestedActivityList
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
            this.chooseB = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            this.suggestedDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.suggestedDG)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseB
            // 
            this.chooseB.Location = new System.Drawing.Point(237, 327);
            this.chooseB.Name = "chooseB";
            this.chooseB.Size = new System.Drawing.Size(75, 23);
            this.chooseB.TabIndex = 2;
            this.chooseB.Text = "انتخاب";
            this.chooseB.UseVisualStyleBackColor = true;
            this.chooseB.Click += new System.EventHandler(this.chooseB_Click);
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(21, 327);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 34;
            this.backB.Text = "بازگشت";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // suggestedDG
            // 
            this.suggestedDG.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.suggestedDG.AllowUserToAddRows = false;
            this.suggestedDG.AllowUserToDeleteRows = false;
            this.suggestedDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suggestedDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.name,
            this.discription});
            this.suggestedDG.Location = new System.Drawing.Point(64, 12);
            this.suggestedDG.Name = "suggestedDG";
            this.suggestedDG.ReadOnly = true;
            this.suggestedDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suggestedDG.Size = new System.Drawing.Size(248, 284);
            this.suggestedDG.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // discription
            // 
            this.discription.HeaderText = "توضیحات";
            this.discription.Name = "discription";
            this.discription.ReadOnly = true;
            // 
            // SuggestedActivityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 362);
            this.Controls.Add(this.suggestedDG);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.chooseB);
            this.Name = "SuggestedActivityList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuggestedActivityList";
            this.Load += new System.EventHandler(this.SuggestedActivityList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suggestedDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button chooseB;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.DataGridView suggestedDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn discription;
    }
}