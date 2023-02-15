using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System;

namespace DB_lesson
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Main : Form
    {
        DataBase dataBase = new DataBase();

        static int widthNew = 0;
        static int heightNew = 0;
        static int widthOld = 0;
        static int heightOld = 0;

        private int selectedRow;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            widthNew = Width;
            heightNew = Height;
            widthOld = Width;
            heightOld = Height;

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

        private void ReadSingleRow(DataGridView dgw, IDataRecord record , int i)
        {
            dgw.Rows.Add((i), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }// считывает каждую строку

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

        }// выводит БД

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {           

            if (tabControl1.SelectedTab == Page1)
            {
                Width = widthOld;
                Height = heightOld;

                RefreshDataGrid(dataGridView1);
                AutoSizeMode = AutoSizeMode.GrowOnly;
                MaximizeBox = true;
            }
            else
            {
                widthOld = Width;
                heightOld = Height;
                AutoSizeMode = AutoSizeMode.GrowAndShrink;
                WindowState = FormWindowState.Normal;
                Width = widthNew;
                Height = heightNew;
                MaximizeBox = false;
            }

        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void UpdateTable()
        {
            dataBase.OpenConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
                    var deleteQuery = $"delete from Dictionary where English_words = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            dataBase.CloseConnection();
        }

        private void Search(DataGridView dgw) // активный поиск
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Dictionary where concat (English_words, Transcription, Example, Russian_words) like '%" + textBoxSort.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.OpenConnection();

            SqlDataReader dataReader = command.ExecuteReader();

            int i = 1;
            while (dataReader.Read())
            {
                ReadSingleRow(dgw, dataReader, i);
                i++;
            }
            dataReader.Close();

            dataBase.CloseConnection();
        }

        private void textBoxSort_TextChanged(object sender, System.EventArgs e)
        {
            Search(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // вывод в записи 
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxNumber.Text = row.Cells[0].Value.ToString();
                textBoxEnWr.Text = row.Cells[1].Value.ToString();
                textBoxTranscr.Text = row.Cells[2].Value.ToString();
                textBoxExam.Text = row.Cells[3].Value.ToString();
                textBoxRusWr.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonNewNote_Click(object sender, System.EventArgs e)
        {
            Add_Form add_Form = new Add_Form();
            add_Form.Show();
        }

        private void buttonRefresh_Click(object sender, System.EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            deleteRow();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
