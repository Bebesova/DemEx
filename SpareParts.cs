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
    public partial class SpareParts : Form
    {
        public SpareParts(int prob_id)
        {
            problem_id = prob_id;
            InitializeComponent();
        }
        int problem_id;
        static string connString = @"Data Source=DESKTOP-MPV0NJU;Initial Catalog=BesRep;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int Twork;
        private void SpareParts_Load(object sender, EventArgs e)
        {
            SqlCommand Problem = new SqlCommand();
            Problem.CommandText = $"Select* from [dbo].[Type_work] ";
            int a = Convert.ToInt32(Count.Value);
            label6.Text = Convert.ToString(a);
            Problem.Connection = sqlConnect;
            SqlDataAdapter Opopop = new SqlDataAdapter(Problem);
            DataSet dataSetp = new DataSet();
            Opopop.Fill(dataSetp);
            DGExecutor.DataSource = dataSetp.Tables[0];
            DGExecutor.Columns[0].Visible = false;

        }

        private void DGExecutor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Twork = Convert.ToInt32(DGExecutor.Rows[e.RowIndex].Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "OrderSpareParts";
            
            if ((Count.Value)>0)
            {
                logRequst.Parameters.AddWithValue("@id_order_problrm", problem_id);
                logRequst.Parameters.AddWithValue("@Quantity", Count.Value);
                logRequst.Parameters.AddWithValue("@id_type ", Twork);

            }
            else
            {
                MessageBox.Show("Укажите колличесвто");
            }
           
     

            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Запчасти заказаны ");



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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
