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


namespace intaktika
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class FormMain : Form
    {
        DataBase dataBase = new DataBase();

        int selectedRow;

        public FormMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
            buttonEdit.HeaderText = "Действие";
            buttonEdit.Text = "Изменить";
            buttonEdit.UseColumnTextForButtonValue = true;
           

            dataGridViewBids.Columns.Add("id", "№ Заявки");
            dataGridViewBids.Columns.Add("client", "Клиент");
            dataGridViewBids.Columns.Add("description", "Описание");
            dataGridViewBids.Columns.Add("executor", "Исполнитель");
            dataGridViewBids.Columns.Add("status", "Статус");
            dataGridViewBids.Columns.Add("date_open", "Дата открытия");
            dataGridViewBids.Columns.Add("date_closed", "Дата закрытия");
            dataGridViewBids.Columns.Add(buttonEdit);

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            DateTime? dateClosed = record.IsDBNull(6) ? (DateTime?)null : record.GetDateTime(6);

            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetDateTime(5),
                dateClosed
            );
        }


        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"SELECT Bids.id, Clients.name, Bids.description, Staffs.name, Statuses.status, Bids.date_open, Bids.date_closed FROM Statuses INNER JOIN Clients INNER JOIN Staffs INNER JOIN Bids ON Staffs.id = Bids.executor ON Clients.id = Bids.client ON Statuses.id = Bids.status";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewBids);
        }

        private void buttonCreateBid_Click(object sender, EventArgs e)
        {
            AddBid addBid = new AddBid();
            addBid.Show();
        }

        private void dataGridViewBids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что событие вызвано кликом на ячейке типа кнопки
            if (dataGridViewBids.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Обработка нажатия на кнопку в строке e.RowIndex
                EditBid editBid = new EditBid();
                editBid.Show();
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }
    }
}
