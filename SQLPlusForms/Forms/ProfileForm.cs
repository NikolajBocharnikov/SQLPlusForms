using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace SQLPlusForms.Forms
{
    public partial class ProfileForm : Form
    {
        private SqlConnection sqlConnection = null;
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            sqlConnection.Open();

            String quarry = UserBox.Text;
            SqlDataAdapter sqlData = new SqlDataAdapter(quarry,sqlConnection);

            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
