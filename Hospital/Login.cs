using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loginTextBox.Text = "doctor";
            passwordTextBox.Text = "test";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using OracleConnection connection = new OracleConnection(DBUtility.GetConnectionString());
                connection.Open();
                using OracleCommand oracleCommand = new OracleCommand("check_user", connection);
                oracleCommand.CommandType = CommandType.StoredProcedure;
                oracleCommand.Parameters.Add("is_user", OracleDbType.Boolean, 2, ParameterDirection.Output);
                oracleCommand.Parameters.Add("user_name", OracleDbType.Varchar2, ParameterDirection.Input).Value = loginTextBox.Text.ToString();
                oracleCommand.Parameters.Add("password", OracleDbType.Varchar2, ParameterDirection.Input).Value = passwordTextBox.Text.ToString();
                oracleCommand.ExecuteNonQuery();
                bool IsUser = Convert.ToBoolean(oracleCommand.Parameters["is_user"].Value.ToString());
                if (IsUser)
                {
                    new MainMenu().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
