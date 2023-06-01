using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;


namespace kursach
{
    public partial class Form6 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveTable(dataGridView1);
            MessageBox.Show("База сохранена");
        }


        void SaveTable(DataGridView What_Save) 
        {
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Data.xlsx";


            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            for (int i = 1; i < What_Save.RowCount+1; i++)
            {
                for (int j = 1; j < What_Save.ColumnCount+1; j++)
                {
                    worksheet.Rows[i].Columns[j] = What_Save.Rows[i - 1].Cells[j - 1].Value;

                }
            }

            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            excelapp.Quit();
            

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database2"].ConnectionString);
            sqlConnection.Open();



            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM data", sqlConnection
                );


            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

            // if (sqlConnection.State == ConnectionState.Open)
            //{
            //MessageBox.Show("Подключение установлено");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Выйти?", "Оповешание о выходе", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
