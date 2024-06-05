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
    public partial class Executor_menu : Form
    {
        int id_user;
        public Executor_menu(int id_us)
        {
            InitializeComponent();
            id_user = id_us;
        }
        static string connString = @"Data Source=DESKTOP-MPV0NJU;Initial Catalog=BesRep;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int problem_id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Executor_menu_Load(object sender, EventArgs e)
        {
            SqlCommand Problem = new SqlCommand();
            Problem.CommandText = $"Select* from [dbo].[Problem] where id_user ={id_user} ";

            Problem.Connection = sqlConnect;
            SqlDataAdapter Opopop = new SqlDataAdapter(Problem);
            DataSet dataSetp = new DataSet();
            Opopop.Fill(dataSetp);
            DGExecutor.DataSource = dataSetp.Tables[0];
            DGExecutor.Columns[8].Visible = false;

        }

        private void CBfilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBfilterStatus.SelectedIndex)
            {
                case 0:
                    (DGExecutor.DataSource as DataTable).DefaultView.RowFilter = $"[Cтатус] = 'Не начато ";
                    break;
                case 1:
                    (DGExecutor.DataSource as DataTable).DefaultView.RowFilter = $"[Cтатус] = 'В работе' ";
                    break;
                case 2:
                    (DGExecutor.DataSource as DataTable).DefaultView.RowFilter = $"[Cтатус] >= 'Выполнен'";
                    break;
                case 3:
                    (DGExecutor.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }
        }

        private void BEditStatus_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand editstat = new SqlCommand();
            editstat.Connection = sqlConnect;
            editstat.CommandType = CommandType.StoredProcedure;
            editstat.CommandText = "EdStatusProblem";

            editstat.Parameters.AddWithValue("@id_status", CBStatus.SelectedIndex);
            editstat.Parameters.AddWithValue("@id_Order_problem", problem_id);

        }

        private void DGExecutor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            problem_id = Convert.ToInt32(DGExecutor.Rows[e.RowIndex].Cells[8].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpareParts rm = new SpareParts(problem_id);
            rm.ShowDialog();
        }
    }
}
