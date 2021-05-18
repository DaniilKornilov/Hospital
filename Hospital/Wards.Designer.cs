
namespace Hospital
{
    partial class Wards
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaxCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtName,
            this.txtMaxCount});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(468, 516);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            this.dataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserDeletedRow);
            this.dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView_UserDeletingRow);
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "ID";
            this.txtID.HeaderText = "ID";
            this.txtID.Name = "txtID";
            this.txtID.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "NAME";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.DataPropertyName = "MAX_COUNT";
            this.txtMaxCount.HeaderText = "Max count";
            this.txtMaxCount.Name = "txtMaxCount";
            // 
            // Wards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 516);
            this.Controls.Add(this.dataGridView);
            this.Name = "Wards";
            this.Text = "Wards";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Wards_FormClosed);
            this.Load += new System.EventHandler(this.Wards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaxCount;
    }
}