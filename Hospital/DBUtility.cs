using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital
{
    static class DBUtility
    {
        static readonly string connectionString = "USER ID = c##test;DATA SOURCE=localhost:1521/xe;Password=testp";

        public static string GetConnectionString()
        {
            return connectionString;
        }

        public static void PopulateGridView(DataGridView dataGridView, string selectSQL)
        {
            try
            {
                using OracleConnection connection = new OracleConnection(connectionString);
                connection.Open();
                using OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(selectSQL, connection);
                DataTable dataTable = new DataTable();
                oracleDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void PopulateComboBox(DataGridViewComboBoxColumn comboBox, string selectSQL)
        {
            try
            {
                using OracleConnection connection = new OracleConnection(connectionString);
                connection.Open();
                using OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(selectSQL, connection);
                DataTable dataTable = new DataTable();
                oracleDataAdapter.Fill(dataTable);
                comboBox.ValueMember = "ID";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void PopulateComboBox(ComboBox comboBox, string selectSQL)
        {
            try
            {
                using OracleConnection connection = new OracleConnection(connectionString);
                connection.Open();
                using OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(selectSQL, connection);
                DataTable dataTable = new DataTable();
                oracleDataAdapter.Fill(dataTable);
                comboBox.ValueMember = "ID";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dataTable;
                comboBox.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
