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

namespace repair
{
    public partial class Order : Form
    {
       
        public Order()
        {
           
            InitializeComponent();
        }
        static string connString = @"Data Source=DESKTOP-MPV0NJU;Initial Catalog=BesRep;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        string num = "";
        int User_id;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        class device
        {
            public int IDdev { get; set; }
            public string Namedev { get; set; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Order_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();

            List<device> dev = new List<device>();
            SqlCommand logRequstspel = new SqlCommand("Select * from [dbo].[Device]", sqlConnect);
            logRequstspel.Connection = sqlConnect;
            SqlDataReader rdr = logRequstspel.ExecuteReader();
            while (rdr.Read())
            {
                dev.Add(new device { IDdev = rdr.GetInt32(0), Namedev = rdr.GetString(1) });

            }
            CBDevice.DataSource = dev;
            CBDevice.ValueMember = "IDdev";
            CBDevice.DisplayMember = "Namedev";
            sqlConnect.Close();

            LDate.Text += DateTime.Now.ToLongDateString();
            Random rand = new Random();
            string pool = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            
            int count = 1;
            while(count!=0)
            {
                for (int x = 0; x < 7; x++)
                {
                    num += pool[rand.Next(0, pool.Length)].ToString();
                }
                sqlConnect.Open();
                SqlCommand check = new SqlCommand($"SELECT COUNT(*) as con FROM [dbo].[Order] Where Number ='{num}' ");
                check.Connection = sqlConnect;
                SqlDataReader rd = check.ExecuteReader();
                while (rd.Read())
                {
                    count = Convert.ToInt32(rd["con"]);
                }

                sqlConnect.Close();

            }
            groupBox1.Text += num;

            //вывод клиента
            SqlCommand logRequst = new SqlCommand();
            logRequst.CommandText = $"SELECT * FROM Usss where id_role = 3";
            logRequst.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(logRequst);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DGUser.DataSource = dataSet.Tables[0];
            DGUser.Columns[0].Visible = false;
            DGUser.Columns[1].Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            

            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "AddOrder";


            logRequst.Parameters.AddWithValue("@id_device", Convert.ToInt32(CBDevice.SelectedValue));
            logRequst.Parameters.AddWithValue("@desctiption", RTBDist.Text);
            logRequst.Parameters.AddWithValue("@id_client", User_id);
            logRequst.Parameters.AddWithValue("@date_reg", DateTime.Now);
            logRequst.Parameters.AddWithValue("@id_priority", CBPriority.SelectedIndex); 
            logRequst.Parameters.AddWithValue("@number", num);

            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Заявка добавлена");
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

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CBDevice.SelectedIndex)
            {
                case 0:
                   break;
                case 1:
                   MessageBox.Show("Коэффициент оплаты увеличен в 2 раза");
                   break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            (DGUser.DataSource as DataTable).DefaultView.RowFilter = $"[Телефон] LIKE '%{PhoneUS.Text}%'";
        }

        private void DGUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewClient frm = new NewClient();
            
            frm.ShowDialog();
        }

        private void DGUser_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            User_id = Convert.ToInt32(DGUser.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
