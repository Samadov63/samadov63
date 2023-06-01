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

namespace kursach
{
    public partial class Form4 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Логин LIKE '%{textBox1.Text}%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{textBox2.Text}%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Выйти?", "Оповешание о выходе", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}