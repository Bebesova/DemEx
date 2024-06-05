using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repair
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }
        static string connString = @"Data Source=DESKTOP-MPV0NJU;Initial Catalog=BesRep;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void NewClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "NewUser";


            logRequst.Parameters.AddWithValue("@Name", NameUs.Text);
            logRequst.Parameters.AddWithValue("@Surname", Surname.Text);
            logRequst.Parameters.AddWithValue("@patronymic", patronymic.Text);
            logRequst.Parameters.AddWithValue("@Date_Birth", Birthday.Value);
            logRequst.Parameters.AddWithValue("@phone", Phone.Text);
            logRequst.Parameters.AddWithValue("@Login", TBLogin.Text);
            logRequst.Parameters.AddWithValue("@Password", TBPassword.Text);

            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Клиент добавлен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! : " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
