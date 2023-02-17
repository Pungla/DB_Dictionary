using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System;
using System.Net.NetworkInformation;

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

        static string eng_wrOld;

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

        private void ClearField()
        {
            textBoxNumber.Text = "";
            textBoxEnWr.Text = "";
            textBoxTranscr.Text = "";
            textBoxExam.Text = "";
            textBoxRusWr.Text = "";
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
            dataBase.CloseConnection();

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
                    var deleteQuery = $"delete from Dictionary where English_words = '{id}'";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    //var number = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var eng_wr = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var transcr = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var example = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var rus_wr = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update Dictionary set English_words = '{eng_wr}', Transcription = N'{transcr}', Example = '{example}', Russian_words = N'{rus_wr}' where English_words = '{eng_wrOld}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
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
            ClearField();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var number = textBoxNumber.Text;
            var eng_wr = textBoxEnWr.Text;
            eng_wrOld = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
            var transcr = textBoxTranscr.Text;
            var example = textBoxExam.Text;
            var rus_wr = textBoxRusWr.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(number, eng_wr, transcr, example, rus_wr);
                dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Change();
            ClearField();
        }

        private void yandexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
                System.Diagnostics.Process.Start("https://translate.yandex.ru/");
            else MessageBox.Show("Internet connection not available");
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
                System.Diagnostics.Process.Start("https://translate.google.ru/");
            else MessageBox.Show("Internet connection not available");
        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary_Form dictionary = new Dictionary_Form();
            dictionary.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test_Form test = new Test_Form();
            test.Show();
        }
    }
}
