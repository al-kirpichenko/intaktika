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

namespace intaktika
{
    public partial class CreateUser : Form
    {
        DataBase dataBase = new DataBase();
        public CreateUser()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxLogin.MaxLength = 50;
            textBoxPassword.MaxLength = 50;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            if (issetUser())
            {
                return;
            }
            string query = $"inser into users(login,password,role) values('{login}','{password}',2)";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1 ) 
            {
                MessageBox.Show("Пользователь добавлен!", "Успешно!");
                this.Close();
            }
            else 
            {
                MessageBox.Show("Произошла ошибка!", "Ошибка!");
            }

            dataBase.closeConnection();
        }

        private Boolean issetUser()
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select id, login, password from users where login = '{login}'";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка!");
                return true;
            }
            else return false;
        }
    }
}
