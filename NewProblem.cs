using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace repair
{
    public partial class NewProblem : Form
    {
        int order_id;
        public NewProblem(int id_ord)
        {
            InitializeComponent();
            order_id = id_ord;
        }
        static string connString = @"Data Source=DESKTOP-MPV0NJU;Initial Catalog=BesRep;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        class Executor 
            {
            public int IDEx { get; set; }
            public string NameEx { get; set; }
        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "NewProblem";
            logRequst.Parameters.AddWithValue("@id_order ", order_id);
            logRequst.Parameters.AddWithValue("@desctiption", RTProblem.Text);
 
            logRequst.Parameters.AddWithValue("@id_priority", CBprior.SelectedIndex);

            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Заявка добавлена");

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

        private void NewProblem_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand($"select * from[dbo].[Ord] where id = {order_id}");
            logRequst.Connection = sqlConnect;
            SqlDataReader rd = logRequst.ExecuteReader();
            while (rd.Read())
            {
                
                groupBox1.Text += ' '+ rd["Номер заказа"].ToString();
                Ldevice.Text += ' ' + rd["Устройство"].ToString();
                int val = Convert.ToInt32(rd["Приоритет"]);
                CBprior.SelectedIndex = val - 1;
                

            }
            sqlConnect.Close();
            


            /*List<Executor> execut = new List<Executor>();
            SqlCommand logRequstspel = new SqlCommand("Select Surname +' '+ Name + ' '+ Patronymic from User", sqlConnect);
            logRequstspel.Connection = sqlConnect;
            SqlDataReader rdr = logRequstspel.ExecuteReader();
            while (rdr.Read())
            {
                execut.Add(new Executor { IDEx = rdr.GetInt32(0), NameEx = rdr.GetString(1) });

            }
            CBEx.DataSource = execut;
            CBEx.ValueMember = "IDspel";
            CBEx.DisplayMember = "Namespel";
            sqlConnect.Close();*/


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
