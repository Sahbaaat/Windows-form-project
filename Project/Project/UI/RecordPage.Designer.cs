namespace Project.UI
{
    partial class RecordPage
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
            this.recordlistDG = new System.Windows.Forms.DataGridView();
            this.backB = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advantage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.recordlistDG)).BeginInit();
            this.SuspendLayout();
            // 
            // recordlistDG
            // 
            this.recordlistDG.AllowUserToAddRows = false;
            this.recordlistDG.AllowUserToDeleteRows = false;
            this.recordlistDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordlistDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.discription,
            this.cost,
            this.time,
            this.distance,
            this.advantage});
            this.recordlistDG.Location = new System.Drawing.Point(12, 12);
            this.recordlistDG.Name = "recordlistDG";
            this.recordlistDG.ReadOnly = true;
            this.recordlistDG.Size = new System.Drawing.Size(613, 249);
            this.recordlistDG.TabIndex = 1;
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(12, 298);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 2;
            this.backB.Text = "بازگشت";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
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
            // discription
            // 
            this.discription.HeaderText = "توضیح";
            this.discription.Name = "discription";
            this.discription.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.HeaderText = "هزینه";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "زمان";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // distance
            // 
            this.distance.HeaderText = "فاصله";
            this.distance.Name = "distance";
            this.distance.ReadOnly = true;
            // 
            // advantage
            // 
            this.advantage.HeaderText = "سودمندی";
            this.advantage.Name = "advantage";
            this.advantage.ReadOnly = true;
            // 
            // RecordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 326);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.recordlistDG);
            this.Name = "RecordPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordPage";
            this.Load += new System.EventHandler(this.RecordPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordlistDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView recordlistDG;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn advantage;
    }
}