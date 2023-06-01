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
    public partial class Form5 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form5()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (label2.Visible)
                label2.Visible = false;
            if (!string.IsNullOrEmpty(textBox1.Text)&& !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM[data] WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox1.Text);
                await command.ExecuteNonQueryAsync();
                   
            }
            else
            {
                label2.Visible = true;
                label2.Text = "ID должен быть заполненными";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database2"].ConnectionString);
            sqlConnection.Open();

           // if (sqlConnection.State == ConnectionState.Open)
           // {
             // MessageBox.Show("Подключение установлено");
             //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
               "SELECT * FROM data", sqlConnection
               );


            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
