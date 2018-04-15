namespace Project.UI
{
    partial class CategoryPage
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
            this.activitylistdg = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscribeB = new System.Windows.Forms.Button();
            this.unsubscribeB = new System.Windows.Forms.Button();
            this.suggestB = new System.Windows.Forms.Button();
            this.chooseB = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activitylistdg)).BeginInit();
            this.SuspendLayout();
            // 
            // activitylistdg
            // 
            this.activitylistdg.AllowUserToAddRows = false;
            this.activitylistdg.AllowUserToDeleteRows = false;
            this.activitylistdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitylistdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.activitylistdg.Location = new System.Drawing.Point(83, 12);
            this.activitylistdg.Name = "activitylistdg";
            this.activitylistdg.ReadOnly = true;
            this.activitylistdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activitylistdg.Size = new System.Drawing.Size(156, 284);
            this.activitylistdg.TabIndex = 1;
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
            // SubscribeB
            // 
            this.SubscribeB.Location = new System.Drawing.Point(12, 314);
            this.SubscribeB.Name = "SubscribeB";
            this.SubscribeB.Size = new System.Drawing.Size(75, 23);
            this.SubscribeB.TabIndex = 2;
            this.SubscribeB.Text = "Subscribe";
            this.SubscribeB.UseVisualStyleBackColor = true;
            this.SubscribeB.Click += new System.EventHandler(this.SubscribeB_Click);
            // 
            // unsubscribeB
            // 
            this.unsubscribeB.Location = new System.Drawing.Point(93, 314);
            this.unsubscribeB.Name = "unsubscribeB";
            this.unsubscribeB.Size = new System.Drawing.Size(75, 23);
            this.unsubscribeB.TabIndex = 3;
            this.unsubscribeB.Text = "Unsubscribe";
            this.unsubscribeB.UseVisualStyleBackColor = true;
            this.unsubscribeB.Click += new System.EventHandler(this.unsubscribeB_Click);
            // 
            // suggestB
            // 
            this.suggestB.Location = new System.Drawing.Point(296, 264);
            this.suggestB.Name = "suggestB";
            this.suggestB.Size = new System.Drawing.Size(75, 23);
            this.suggestB.TabIndex = 4;
            this.suggestB.Text = "بیشنهاد";
            this.suggestB.UseVisualStyleBackColor = true;
            this.suggestB.Click += new System.EventHandler(this.suggestB_Click);
            // 
            // chooseB
            // 
            this.chooseB.Location = new System.Drawing.Point(296, 314);
            this.chooseB.Name = "chooseB";
            this.chooseB.Size = new System.Drawing.Size(75, 23);
            this.chooseB.TabIndex = 5;
            this.chooseB.Text = "انتخاب";
            this.chooseB.UseVisualStyleBackColor = true;
            this.chooseB.Click += new System.EventHandler(this.chooseB_Click);
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(2, 264);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 6;
            this.backB.Text = "بازگشت";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // CategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 358);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.chooseB);
            this.Controls.Add(this.suggestB);
            this.Controls.Add(this.unsubscribeB);
            this.Controls.Add(this.SubscribeB);
            this.Controls.Add(this.activitylistdg);
            this.Name = "CategoryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryPage";
            this.Load += new System.EventHandler(this.CategoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activitylistdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView activitylistdg;
        private System.Windows.Forms.Button SubscribeB;
        private System.Windows.Forms.Button unsubscribeB;
        private System.Windows.Forms.Button suggestB;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button chooseB;
        private System.Windows.Forms.Button backB;
    }
}