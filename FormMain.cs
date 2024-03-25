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
        }

        private void CreateColumns()
        {
            dataGridViewBids.Columns.Add("number", "№ Заявки");
            dataGridViewBids.Columns.Add("client", "Клиент");
            dataGridViewBids.Columns.Add("description", "Описание");
            dataGridViewBids.Columns.Add("executor", "Исполнитель");
            dataGridViewBids.Columns.Add("status", "Статус");
            dataGridViewBids.Columns.Add("date_open", "Дата открытия");
            dataGridViewBids.Columns.Add("date_closed", "Дата закрытия");
            
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            DateTime? dateClosed = record.IsDBNull(6) ? (DateTime?)null : record.GetDateTime(6);

            dgw.Rows.Add(
                record.GetString(0),
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

            string query = $"SELECT Bids.number, Clients.name, Bids.description, Staffs.name, Statuses.status, Bids.date_open, Bids.date_closed FROM Statuses INNER JOIN Clients INNER JOIN Staffs INNER JOIN Bids ON Staffs.id = Bids.executor ON Clients.id = Bids.client ON Statuses.id = Bids.status";

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
    }
}
