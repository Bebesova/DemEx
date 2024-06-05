using Microsoft.SqlServer.Server;
using Spire.Xls;
using System;

using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repair
{
    public partial class XslReport : Form
    {
        public XslReport()
        {
            InitializeComponent();
           
           
        }
        static string connString = @"Data Source=DESKTOP-MPV0NJU;Initial Catalog=BesRep;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void XslReport_Load(object sender, EventArgs e)
        {
            SqlCommand Order = new SqlCommand();
            Order.CommandText = $"SELECT * FROM XSLtable";
            Order.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(Order);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DGxsl.DataSource = dataSet.Tables[0];
            DGxsl.Columns[0].Visible = false;
        }
        int i = 1;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            ExcelPackage reportExcel = new ExcelPackage();
            ExcelWorksheet excelWorkSheet = reportExcel.Workbook.Worksheets.Add("NewFile");

            excelWorkSheet.Cells["A1:F1"].Style.Border.BorderAround(ExcelBorderStyle.Thick);
            excelWorkSheet.Cells["A1:F1"].Style.Font.Bold = true;
            //excelWorkSheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            excelWorkSheet.Cells["A1"].Value = "Заказ";
            excelWorkSheet.Cells["B1"].Value = "Устрйство";
            excelWorkSheet.Cells["C1"].Value = "Проблема";
            excelWorkSheet.Cells["D1"].Value = "ФИО исполнителя";
            excelWorkSheet.Cells["E1"].Value = "Дата начала работы";
            excelWorkSheet.Cells["F1"].Value = "Дата окончания работ";

            SqlCommand prob = new SqlCommand($"select * from XSLtable ");
            prob.Connection = sqlConnect;
            SqlDataReader rd = prob.ExecuteReader();
            while (rd.Read())
            {
                i++;
                excelWorkSheet.Cells[$"A{i}"].Value = rd["Заказ"].ToString();
                excelWorkSheet.Cells[$"B{i}"].Value = rd["Устрйсвтво"].ToString();
                excelWorkSheet.Cells[$"C{i}"].Value = rd["Проблема"].ToString();
                excelWorkSheet.Cells[$"D{i}"].Value = rd["Фио"].ToString();
                DateTime dstat = rd.GetDateTime(5);
                DateTime dend = rd.GetDateTime(6);
                excelWorkSheet.Cells[$"E{i}"].Style.Numberformat.Format = "yyyy-mm-dd";
                excelWorkSheet.Cells[$"F{i}"].Style.Numberformat.Format = "yyyy-mm-dd";
                excelWorkSheet.Cells[$"E{i}"].Value = dstat;
                excelWorkSheet.Cells[$"F{i}"].Value = dend;
                
                
                
            }
           
           
            reportExcel.SaveAs(new FileInfo("D:\\NewFile.xlsx"));
            MessageBox.Show("Новый файл сохранен на диск D");
            i = 1;
            sqlConnect.Close();
            
            
        }
    }
}
