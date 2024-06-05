﻿using Microsoft.SqlServer.Server;
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
    public partial class User_windows : Form
    {
        int id_user;
        public User_windows(int id_u)
        {
            id_u = id_user;
            InitializeComponent();
        }
        static string connString = @"Data Source=DESKTOP-MPV0NJU;Initial Catalog=BesRep;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void User_windows_Load(object sender, EventArgs e)
        {
            SqlCommand logRequst = new SqlCommand();
             
            logRequst.CommandText = $"SELECT * FROM [dbo].[Order] Where id_client ={id_user}";
            logRequst.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(logRequst);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            employeesDG.DataSource = dataSet.Tables[0];
            employeesDG.Columns[0].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Аuth form = new Аuth();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            QRcod qrform = new QRcod();

            qrform.ShowDialog();
        }
    }
}

