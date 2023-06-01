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
    public partial class Form2 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close();
            DialogResult result = MessageBox.Show("Выйти?", "Оповешание о выходе", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database2"].ConnectionString);
            sqlConnection.Open();

            //if (sqlConnection.State == ConnectionState.Open)
            //{
              //  MessageBox.Show("Подключение установлено");
           // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [data](Имя, Фамилия, Логин, Пароль) VALUES(N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}', N'{textBox4.Text}')", sqlConnection);
            MessageBox.Show("Запись добавлена", command.ExecuteNonQuery().ToString());
        }
    }
    }

