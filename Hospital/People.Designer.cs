
namespace Hospital
{
    partial class People
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
            this.txtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDiagnosis = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbxWard = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtFirstName,
            this.txtLastName,
            this.txtFatherName,
            this.cbxDiagnosis,
            this.cbxWard});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(544, 500);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
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
            // txtFirstName
            // 
            this.txtFirstName.DataPropertyName = "FIRST_NAME";
            this.txtFirstName.HeaderText = "First name";
            this.txtFirstName.Name = "txtFirstName";
            // 
            // txtLastName
            // 
            this.txtLastName.DataPropertyName = "LAST_NAME";
            this.txtLastName.HeaderText = "Last name";
            this.txtLastName.Name = "txtLastName";
            // 
            // txtFatherName
            // 
            this.txtFatherName.DataPropertyName = "FATHER_NAME";
            this.txtFatherName.HeaderText = "Father name";
            this.txtFatherName.Name = "txtFatherName";
            // 
            // cbxDiagnosis
            // 
            this.cbxDiagnosis.DataPropertyName = "DIAGNOSIS_ID";
            this.cbxDiagnosis.HeaderText = "Diagnosis";
            this.cbxDiagnosis.Name = "cbxDiagnosis";
            // 
            // cbxWard
            // 
            this.cbxWard.DataPropertyName = "WARD_ID";
            this.cbxWard.HeaderText = "Ward";
            this.cbxWard.Name = "cbxWard";
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 500);
            this.Controls.Add(this.dataGridView);
            this.Name = "People";
            this.Text = "People";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.People_FormClosed);
            this.Load += new System.EventHandler(this.People_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFatherName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxDiagnosis;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxWard;
    }
}