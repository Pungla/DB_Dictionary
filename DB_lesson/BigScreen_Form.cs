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

namespace DB_lesson
{
    public partial class BigScreen_Form : Form
    {
        DataBase dataBase = new DataBase();
        public BigScreen_Form()
        {
            InitializeComponent();
        }

        private void BigScreen_Form_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void CreateColumns() // create colums
        {
            dataGridView1.Columns.Add("Number", "Number");
            dataGridView1.Columns.Add("English_words", "English words");
            dataGridView1.Columns.Add("Transcription", "Transcription");
            dataGridView1.Columns.Add("Example", "Example");
            dataGridView1.Columns.Add("Russian_words", "Russian words");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT * from Dictionary";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader, i);
                i++;
            }
            reader.Close();
            dataBase.CloseConnection();

        }// выводит БД

        private void ReadSingleRow(DataGridView dgw, IDataRecord record, int i)
        {
            dgw.Rows.Add((i), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }// считывает каждую строку
    }
}
