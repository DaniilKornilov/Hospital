using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Statistics(this).Show();
        }

        private void WardsButton_Click(object sender, EventArgs e)
        {
            new Wards(this).Show();
        }

        private void DiagnosisButton_Click(object sender, EventArgs e)
        {
            new Diagnosis(this).Show();
        }

        private void PeopleButton_Click(object sender, EventArgs e)
        {
            new People(this).Show();
        }
    }
}
