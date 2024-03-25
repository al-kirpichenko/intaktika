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
    public partial class Login : Form
    {
        DataBase dataBase = new DataBase();
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxLogin.MaxLength = 50;
            textBoxPassword.MaxLength = 50;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();  
            DataTable table = new DataTable();

            string query = $"select id, login, password from users where login = '{login}' and password = '{password}' ";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вход выполнен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain formMain = new FormMain();
                this.Hide();
                formMain.ShowDialog();
            } else
                MessageBox.Show("Пользователь не найден!", "Пользователь не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
