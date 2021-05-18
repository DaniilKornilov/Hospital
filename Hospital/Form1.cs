using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        private readonly string select_wards_sql = "Select name, max_count from Wards";
        private Form form;

        public Form1(Form form)
        {
            InitializeComponent();
            form.Hide();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using OracleConnection connection = new OracleConnection(DBUtility.GetConnectionString());
                connection.Open();
                using OracleCommand cmd = new OracleCommand(select_wards_sql, connection);
                using OracleDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using OracleConnection connection = new OracleConnection(DBUtility.GetConnectionString());

            if (connection.State == ConnectionState.Closed)
                MessageBox.Show("Connection closed");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
