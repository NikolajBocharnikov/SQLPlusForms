using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using SQLPlusForms.Forms;

namespace SQLPlusForms
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            sqlConnection.Open();
        }

        private void ShowChildFormInWindow(object Form)
        {
            Form form = Form as Form;
            form.Show();
        }
        private void ShowChildFormInPanel(object Form)
        {
            if (this.panelDesctop.Controls.Count > 0)
            {
                LoginBox.Visible = false;
                PassBox.Visible = false;
                LoginBtn.Visible = false;
                RegBtn.Visible = false;
            }
            Form form = Form as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelDesctop.Controls.Add(form);
            form.Show();
        }
        private void ShowHomeBtnBox()
        {
            LoginBox.Visible = true;
            PassBox.Visible = true;
            LoginBtn.Visible = true;
            RegBtn.Visible = true;
        }
        public void SubBackBtnPresedE()
        {

            if (Data.SubBackBtnPresed == true)
            {
                ShowHomeBtnBox();
                Data.SubBackBtnPresed = false;
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            ShowChildFormInWindow(new RegForm());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ShowHomeBtnBox();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            sqlConnection.Open();

            String login, password;
            login = LoginBox.Text;
            password = PassBox.Text;

            try
            {
                String quarry = "SELECT Login,Password FROM Clients WHERE Login = '" + LoginBox.Text + "'AND Password = '" + PassBox.Text + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(quarry, sqlConnection);

                DataTable data = new DataTable();
                sqlData.Fill(data);

                if (data.Rows.Count > 0)
                {
                    login = LoginBox.Text;
                    password = PassBox.Text;

                    ShowChildFormInPanel(new ProfileForm());
                }
                else
                {
                    MessageBox.Show("Wrong Login or Password","  ",MessageBoxButtons.OK);
                    LoginBox.Clear();
                    PassBox.Clear();

                    LoginBox.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
                ShowHomeBtnBox();
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
