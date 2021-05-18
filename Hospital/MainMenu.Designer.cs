
namespace Hospital
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.PeopleButton = new System.Windows.Forms.Button();
            this.DiagnosisButton = new System.Windows.Forms.Button();
            this.WardsButton = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleButton
            // 
            this.PeopleButton.Location = new System.Drawing.Point(366, 412);
            this.PeopleButton.Name = "PeopleButton";
            this.PeopleButton.Size = new System.Drawing.Size(159, 45);
            this.PeopleButton.TabIndex = 4;
            this.PeopleButton.Text = "People";
            this.PeopleButton.Click += new System.EventHandler(this.PeopleButton_Click);
            // 
            // DiagnosisButton
            // 
            this.DiagnosisButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagnosisButton.Location = new System.Drawing.Point(13, 412);
            this.DiagnosisButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DiagnosisButton.Name = "DiagnosisButton";
            this.DiagnosisButton.Size = new System.Drawing.Size(159, 45);
            this.DiagnosisButton.TabIndex = 1;
            this.DiagnosisButton.Text = "Diagnosis";
            this.DiagnosisButton.UseVisualStyleBackColor = true;
            this.DiagnosisButton.Click += new System.EventHandler(this.DiagnosisButton_Click);
            // 
            // WardsButton
            // 
            this.WardsButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WardsButton.Location = new System.Drawing.Point(190, 412);
            this.WardsButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.WardsButton.Name = "WardsButton";
            this.WardsButton.Size = new System.Drawing.Size(159, 45);
            this.WardsButton.TabIndex = 2;
            this.WardsButton.Text = "Wards";
            this.WardsButton.UseVisualStyleBackColor = true;
            this.WardsButton.Click += new System.EventHandler(this.WardsButton_Click);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatisticsButton.Location = new System.Drawing.Point(546, 413);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(159, 44);
            this.StatisticsButton.TabIndex = 3;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = true;
            this.StatisticsButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 390);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StatisticsButton);
            this.Controls.Add(this.WardsButton);
            this.Controls.Add(this.DiagnosisButton);
            this.Controls.Add(this.PeopleButton);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PeopleButton;
        private System.Windows.Forms.Button DiagnosisButton;
        private System.Windows.Forms.Button WardsButton;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}