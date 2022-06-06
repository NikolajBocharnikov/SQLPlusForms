using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace SQLPlusForms.Forms
{
    public partial class RegForm : Form
    {
        private SqlConnection sqlConnection = null;

        public RegForm()
        {
            InitializeComponent();
        }
        private void RegBtn_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [Clients] (Login, Password, Name, Surname, PhoneNumber)" +
                    $" VALUES (@Login, @Password, @Name, @Surname, @PhoneNumber)",sqlConnection);
                SqlCommand command1 = new SqlCommand($"INSERT INTO[Table](Name,PhoneNumber)" +
                    $"VALUES(@Name,@PhoneNumber)", sqlConnection);

                int PhoneNumber = int.Parse(PhoneBox.Text);

                command.Parameters.AddWithValue("Login", NewLoginBox.Text);
                command.Parameters.AddWithValue("Password", NewPassBox.Text);
                command.Parameters.AddWithValue("Name", NameBox.Text);
                command.Parameters.AddWithValue("Surname", SurnameBox.Text);
                command.Parameters.AddWithValue("PhoneNumber", PhoneNumber);

                command1.Parameters.AddWithValue("Name", NameBox.Text);
                command1.Parameters.AddWithValue("PhoneNumber", PhoneNumber);

                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                MessageBox.Show("Done");
            }
            else
                MessageBox.Show("NoConnection");
        }
        private void ChildFormClose(object Form)
        {
            Form form = Form as Form;
            form.Close();

        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            ChildFormClose(this.FindForm());
            Data.SubBackBtnPresed = true;
        }
    }
}
