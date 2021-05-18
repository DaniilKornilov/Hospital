
namespace Hospital
{
    partial class Statistics
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
            this.wardComboBox = new System.Windows.Forms.ComboBox();
            this.wardTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wardsTabPage = new System.Windows.Forms.TabPage();
            this.wardsDataGridView = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.chartTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.occDataGridView = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaxCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.wardsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wardsDataGridView)).BeginInit();
            this.chartTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select ward:";
            // 
            // wardComboBox
            // 
            this.wardComboBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wardComboBox.FormattingEnabled = true;
            this.wardComboBox.Location = new System.Drawing.Point(196, 16);
            this.wardComboBox.Name = "wardComboBox";
            this.wardComboBox.Size = new System.Drawing.Size(256, 40);
            this.wardComboBox.TabIndex = 2;
            this.wardComboBox.SelectedValueChanged += new System.EventHandler(this.wardComboBox_SelectedValueChanged);
            // 
            // wardTextBox
            // 
            this.wardTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wardTextBox.Location = new System.Drawing.Point(196, 79);
            this.wardTextBox.Name = "wardTextBox";
            this.wardTextBox.ReadOnly = true;
            this.wardTextBox.Size = new System.Drawing.Size(256, 39);
            this.wardTextBox.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.wardsTabPage);
            this.tabControl1.Controls.Add(this.chartTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 555);
            this.tabControl1.TabIndex = 6;
            // 
            // wardsTabPage
            // 
            this.wardsTabPage.Controls.Add(this.wardsDataGridView);
            this.wardsTabPage.Controls.Add(this.label3);
            this.wardsTabPage.Controls.Add(this.wardTextBox);
            this.wardsTabPage.Controls.Add(this.label1);
            this.wardsTabPage.Controls.Add(this.wardComboBox);
            this.wardsTabPage.Location = new System.Drawing.Point(4, 24);
            this.wardsTabPage.Name = "wardsTabPage";
            this.wardsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wardsTabPage.Size = new System.Drawing.Size(460, 527);
            this.wardsTabPage.TabIndex = 0;
            this.wardsTabPage.Text = "Wards";
            this.wardsTabPage.UseVisualStyleBackColor = true;
            // 
            // wardsDataGridView
            // 
            this.wardsDataGridView.AllowUserToAddRows = false;
            this.wardsDataGridView.AllowUserToDeleteRows = false;
            this.wardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtFirstName,
            this.txtLastName,
            this.txtFatherName,
            this.txtDiagnosis});
            this.wardsDataGridView.Location = new System.Drawing.Point(7, 134);
            this.wardsDataGridView.Name = "wardsDataGridView";
            this.wardsDataGridView.ReadOnly = true;
            this.wardsDataGridView.RowTemplate.Height = 25;
            this.wardsDataGridView.Size = new System.Drawing.Size(445, 386);
            this.wardsDataGridView.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataPropertyName = "FIRST_NAME";
            this.txtFirstName.HeaderText = "First name";
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            // 
            // txtLastName
            // 
            this.txtLastName.DataPropertyName = "LAST_NAME";
            this.txtLastName.HeaderText = "Last name";
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            // 
            // txtFatherName
            // 
            this.txtFatherName.DataPropertyName = "FATHER_NAME";
            this.txtFatherName.HeaderText = "Father name";
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.ReadOnly = true;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.DataPropertyName = "DIAGNOSIS";
            this.txtDiagnosis.HeaderText = "Diagnosis";
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "People in ward:";
            // 
            // chartTabPage
            // 
            this.chartTabPage.Controls.Add(this.label2);
            this.chartTabPage.Controls.Add(this.occDataGridView);
            this.chartTabPage.Location = new System.Drawing.Point(4, 24);
            this.chartTabPage.Name = "chartTabPage";
            this.chartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.chartTabPage.Size = new System.Drawing.Size(460, 527);
            this.chartTabPage.TabIndex = 1;
            this.chartTabPage.Text = "Occupancy";
            this.chartTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(122, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Occupancy of wards";
            // 
            // occDataGridView
            // 
            this.occDataGridView.AllowUserToAddRows = false;
            this.occDataGridView.AllowUserToDeleteRows = false;
            this.occDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.occDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtName,
            this.txtMaxCount,
            this.txtRatio});
            this.occDataGridView.Location = new System.Drawing.Point(8, 50);
            this.occDataGridView.Name = "occDataGridView";
            this.occDataGridView.ReadOnly = true;
            this.occDataGridView.RowTemplate.Height = 25;
            this.occDataGridView.Size = new System.Drawing.Size(444, 469);
            this.occDataGridView.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.DataPropertyName = "MAX_COUNT";
            this.txtMaxCount.HeaderText = "Max count";
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.ReadOnly = true;
            // 
            // txtRatio
            // 
            this.txtRatio.DataPropertyName = "RATIO";
            this.txtRatio.HeaderText = "Occupancy, %";
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.ReadOnly = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 555);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Statistics_FormClosed);
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.tabControl1.ResumeLayout(false);
            this.wardsTabPage.ResumeLayout(false);
            this.wardsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wardsDataGridView)).EndInit();
            this.chartTabPage.ResumeLayout(false);
            this.chartTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wardComboBox;
        private System.Windows.Forms.TextBox wardTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage wardsTabPage;
        private System.Windows.Forms.DataGridView wardsDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage chartTabPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView occDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaxCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRatio;
    }
}