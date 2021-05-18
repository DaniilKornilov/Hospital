using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Hospital
{
    public partial class Wards : Form
    {
        private readonly string connectionString = DBUtility.GetConnectionString();
        private readonly string selectSQL = "Select * from Wards";
        private readonly Form form;

        public Wards(Form form)
        {
            InitializeComponent();
            form.Hide();
            this.form = form;
        }

        private void Wards_Load(object sender, EventArgs e)
        {
            DBUtility.PopulateGridView(dataGridView, selectSQL);
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                try
                {
                    using OracleConnection connection = new OracleConnection(connectionString);
                    connection.Open();
                    DataGridViewRow gridViewRow = dataGridView.CurrentRow;
                    using OracleCommand oracleCommand = new OracleCommand("WardsAddOrEdit", connection);
                    oracleCommand.CommandType = CommandType.StoredProcedure;
                    if (gridViewRow.Cells["txtID"].Value == DBNull.Value)
                    {
                        oracleCommand.Parameters.Add("IDp", OracleDbType.Int32).Value = 0;
                    }
                    else
                    {
                        oracleCommand.Parameters.Add("IDp", OracleDbType.Int32).Value = Convert.ToInt32(gridViewRow.Cells["txtID"].Value);
                    }
                    oracleCommand.Parameters.Add("NAMEp", OracleDbType.Varchar2).Value = gridViewRow.Cells["txtName"].Value == DBNull.Value ? "" : gridViewRow.Cells["txtName"].Value.ToString();
                    oracleCommand.Parameters.Add("MCOUNTp", OracleDbType.Int32).Value = Convert.ToInt32(gridViewRow.Cells["txtMaxCount"].Value == DBNull.Value ? "0" : gridViewRow.Cells["txtMaxCount"].Value.ToString());
                    oracleCommand.ExecuteNonQuery();
                    DBUtility.PopulateGridView(dataGridView, selectSQL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView.CurrentRow.Cells["txtID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this ward?", "Wards", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using OracleConnection connection = new OracleConnection(connectionString);
                        connection.Open();
                        using OracleCommand oracleCommand = new OracleCommand("WardsDeleteByID", connection);
                        oracleCommand.CommandType = CommandType.StoredProcedure;
                        oracleCommand.Parameters.Add("IDp", OracleDbType.Int32).Value = Convert.ToInt32(dataGridView.CurrentRow.Cells["txtID"].Value);
                        oracleCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Enter number!");
        }

        private void Wards_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void dataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("Ward deleted!");
        }
    }
}
