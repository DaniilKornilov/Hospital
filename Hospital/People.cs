using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Hospital
{
    public partial class People : Form
    {
        private readonly string connectionString = DBUtility.GetConnectionString();
        private readonly string selectSQL = "Select * from People";
        private readonly string selectDiagnosis = "Select * from Diagnosis";
        private readonly string selectWards = "Select * from Wards";
        private readonly Form form;

        public People(Form form)
        {
            InitializeComponent();
            form.Hide();
            this.form = form;
        }

        private void People_Load(object sender, EventArgs e)
        {
            DBUtility.PopulateComboBox(cbxDiagnosis, selectDiagnosis);
            DBUtility.PopulateComboBox(cbxWard, selectWards);
            DBUtility.PopulateGridView(dataGridView, selectSQL);
        }

        private void People_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView.CurrentRow.Cells["txtID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this person?", "People", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using OracleConnection connection = new OracleConnection(connectionString);
                        connection.Open();
                        using OracleCommand oracleCommand = new OracleCommand("PeopleDeleteByID", connection);
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

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                try
                {
                    using OracleConnection connection = new OracleConnection(connectionString);
                    connection.Open();
                    DataGridViewRow gridViewRow = dataGridView.CurrentRow;
                    using OracleCommand oracleCommand = new OracleCommand("PeopleAddOrEdit", connection);
                    oracleCommand.CommandType = CommandType.StoredProcedure;
                    if (gridViewRow.Cells["txtID"].Value == DBNull.Value)
                    {
                        oracleCommand.Parameters.Add("IDp", OracleDbType.Int32).Value = 0;
                    }
                    else
                    {
                        oracleCommand.Parameters.Add("IDp", OracleDbType.Int32).Value = Convert.ToInt32(gridViewRow.Cells["txtID"].Value);
                    }
                    oracleCommand.Parameters.Add("FNAMEp", OracleDbType.Varchar2).Value = gridViewRow.Cells["txtFirstName"].Value == DBNull.Value ? "" : gridViewRow.Cells["txtFirstName"].Value.ToString();
                    oracleCommand.Parameters.Add("LNAMEp", OracleDbType.Varchar2).Value = gridViewRow.Cells["txtLastName"].Value == DBNull.Value ? "" : gridViewRow.Cells["txtLastName"].Value.ToString();
                    oracleCommand.Parameters.Add("PNAMEp", OracleDbType.Varchar2).Value = gridViewRow.Cells["txtFatherName"].Value == DBNull.Value ? "" : gridViewRow.Cells["txtFatherName"].Value.ToString();
                    oracleCommand.Parameters.Add("DIDp", OracleDbType.Int32).Value = Convert.ToInt32(gridViewRow.Cells["cbxDiagnosis"].Value == DBNull.Value ? "0" : gridViewRow.Cells["cbxDiagnosis"].Value.ToString());
                    oracleCommand.Parameters.Add("WIDp", OracleDbType.Int32).Value = Convert.ToInt32(gridViewRow.Cells["cbxWard"].Value == DBNull.Value ? "0" : gridViewRow.Cells["cbxWard"].Value.ToString());
                    oracleCommand.ExecuteNonQuery();
                    DBUtility.PopulateGridView(dataGridView, selectSQL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("Person deleted!");
        }
    }
}
