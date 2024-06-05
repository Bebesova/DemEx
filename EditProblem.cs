using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace repair
{
    public partial class EditProblem : Form
    {
        public int problem_id;
        public EditProblem(int id_prob)
        {
            problem_id = id_prob;
            InitializeComponent();
        }
        
        static string connString = @"Data Source=DESKTOP-MPV0NJU;Initial Catalog=BesRep;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void button1_Click(object sender, EventArgs e)
        {

            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "editProblem";
            logRequst.Parameters.AddWithValue("@@id_order_problrm", problem_id);
            logRequst.Parameters.AddWithValue("@desctiption", RTBDist.Text);
            logRequst.Parameters.AddWithValue("@Dstart", Dstart.Value);
            logRequst.Parameters.AddWithValue("@Dend", Dend.Value);
            logRequst.Parameters.AddWithValue("@id_status", Convert.ToInt32(CBStatus.SelectedValue));

            logRequst.Parameters.AddWithValue("@priority", Convert.ToInt32(CBPriority.SelectedValue));


            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Данные  изменены");

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
        class status
        {
            public int IDstat { get; set; }
            public string Namestat { get; set; }
        }
        private void EditProblem_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            
            SqlCommand prob = new SqlCommand($"select * from [dbo].[OrderProblem] where id_problem = {problem_id}");
            prob.Connection = sqlConnect;
            SqlDataReader rd = prob.ExecuteReader();
            while (rd.Read())
            {
                RTBDist.Text = rd["Проблема"].ToString();
                LDivace.Text += rd["Устройство"].ToString();     
                int val = Convert.ToInt32(rd["Приоритет"]);
                CBPriority.SelectedIndex = val - 1;
                Dstart.Value = rd.GetDateTime(7);
                Dend.Value = rd.GetDateTime(8);

            }

            sqlConnect.Close();
            sqlConnect.Open();
            List<status> stat = new List<status>();
            SqlCommand logRequstspel = new SqlCommand("Select * from Status", sqlConnect);
            logRequstspel.Connection = sqlConnect;
            SqlDataReader rdr = logRequstspel.ExecuteReader();
            while (rdr.Read())
            {
                stat.Add(new status { IDstat = rdr.GetInt32(0), Namestat = rdr.GetString(1) });

            }
            CBStatus.DataSource = stat;
            CBStatus.ValueMember = "IDstat";
            CBStatus.DisplayMember = "Namestat";
            sqlConnect.Close();



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
