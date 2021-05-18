using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Statistics : Form
    {
        private readonly string selectWards = "Select * from Wards";
        private readonly Form form;

        public Statistics(Form form)
        {
            InitializeComponent();
            form.Hide();
            this.form = form;
        }

        private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private string getPeopleInWardSQL(string ward)
        {
            return "SELECT FIRST_NAME, LAST_NAME, FATHER_NAME, D.NAME as DIAGNOSIS " +
                    "from PEOPLE join DIAGNOSIS D on D.ID = PEOPLE.DIAGNOSIS_ID " +
                    "where WARD_ID = (SELECT ID From WARDS where NAME = " +
                    "\'" + ward + "\')";
        }

        private string getOccupancySQL()
        {
            return "SELECT WARDS.NAME, MAX_COUNT, Round(COUNT(PEOPLE.ID) / WARDS.MAX_COUNT, 4) * 100 as Ratio " +
                   "FROM WARDS JOIN PEOPLE on WARDS.ID = PEOPLE.WARD_ID " +
                    "GROUP BY WARDS.NAME, WARDS.MAX_COUNT";
        }

        private void updateWards()
        {
            string sValue = string.Empty;

            if (wardComboBox.SelectedItem is DataRowView oDataRowView)
            {
                sValue = oDataRowView.Row["Name"] as string;
            }

            DBUtility.PopulateGridView(wardsDataGridView, getPeopleInWardSQL(sValue));
        }

        private void updateCounter()
        {
            string sValue = string.Empty;

            if (wardComboBox.SelectedItem is DataRowView oDataRowView)
            {
                sValue = oDataRowView.Row["Name"] as string;
            }

            try
            {
                using OracleConnection connection = new OracleConnection(DBUtility.GetConnectionString());
                connection.Open();
                using OracleCommand oracleCommand = new OracleCommand("getPeopleInWardCount", connection);
                oracleCommand.CommandType = CommandType.StoredProcedure;
                oracleCommand.Parameters.Add("count", OracleDbType.Int32, 32, ParameterDirection.Output);
                oracleCommand.Parameters.Add("NAMEp", OracleDbType.Varchar2, ParameterDirection.Input).Value = sValue;
                oracleCommand.ExecuteNonQuery();
                int counter = Convert.ToInt32(oracleCommand.Parameters["count"].Value.ToString());
                wardTextBox.Text = counter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            DBUtility.PopulateComboBox(wardComboBox, selectWards);
            updateWards();
            updateCounter();
            DBUtility.PopulateGridView(occDataGridView, getOccupancySQL());
        }

        private void wardComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            updateWards();
            updateCounter();
        }
    }
}
