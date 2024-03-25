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

            string query = $"inser into users(login,password,role) values('{login}','{password}',2)";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1 ) 
            {
                MessageBox.Show("Пользователь добавлен!", "Успешно!");

            }
        }
    }
}
