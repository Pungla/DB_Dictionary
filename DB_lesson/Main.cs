using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace DB_lesson
{
    public partial class Main : Form
    {
        private SqlConnection sqlConnection = null;

        const string floatTextEnglish = "English word";
        const string floatTextTranscription = "Transcription";
        const string floatTextExample = "Example";
        const string floatTextRussian = "Russian word";

        static int width = 0;
        static int height = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            width = Width;
            height = Height;
            

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DictionaryDB"].ConnectionString);

            sqlConnection.Open();

            { 
                textBoxEnglish.Text = floatTextEnglish;
                textBoxEnglish.ForeColor = Color.Gray;

                textBoxTranscription.Text = floatTextTranscription;
                textBoxTranscription.ForeColor = Color.Gray;

                textBoxExample.Text = floatTextExample;
                textBoxExample.ForeColor = Color.Gray;

                textBoxRussian.Text = floatTextRussian;
                textBoxRussian.ForeColor = Color.Gray;
            } //подсказки

            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT ROW_NUMBER() OVER (ORDER BY English_words DESC) AS [Number], English_words, Transcription, Example, Russian_words FROM Dictionary", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }
              
        private void textBoxEnglish_Enter(object sender, System.EventArgs e)
        {
            textBoxEnglish.Text = null;
            textBoxEnglish.ForeColor = Color.Black;
        }

        private void textBoxTranscription_Enter(object sender, System.EventArgs e)
        {
            textBoxTranscription.Text = null;
            textBoxTranscription.ForeColor = Color.Black;
        }

        private void textBoxExample_Enter(object sender, System.EventArgs e)
        {
            textBoxExample.Text = null;
            textBoxExample.ForeColor = Color.Black;
        }

        private void textBoxRussian_Enter(object sender, System.EventArgs e)
        {
            textBoxRussian.Text = null;
            textBoxRussian.ForeColor = Color.Black;
        }

        private void textBoxEnglish_Leave(object sender, System.EventArgs e)
        {
            if (textBoxEnglish.Text == "")
            {
                textBoxEnglish.Text = floatTextEnglish;
                textBoxEnglish.ForeColor = Color.Gray;
            }
        }

        private void textBoxTranscription_Leave(object sender, System.EventArgs e)
        {
            if (textBoxTranscription.Text == "")
            {
                textBoxTranscription.Text = floatTextTranscription;
                textBoxTranscription.ForeColor = Color.Gray;
            }
        }

        private void textBoxExample_Leave(object sender, System.EventArgs e)
        {
            if (textBoxExample.Text == "")
            {
                textBoxExample.Text = floatTextExample;
                textBoxExample.ForeColor = Color.Gray;
            }
        }

        private void textBoxRussian_Leave(object sender, System.EventArgs e)
        {
            if (textBoxRussian.Text == "")
            {
                textBoxRussian.Text = floatTextRussian;
                textBoxRussian.ForeColor = Color.Gray;
            }
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {

            if (FloatText_True())
            {
                SqlCommand command = new SqlCommand(
                $"INSERT INTO [Dictionary] (English_words, Transcription, Example, Russian_words) VALUES (@English_words, @Transcription, @Example, @Russian_words)",
                sqlConnection);

                command.Parameters.AddWithValue("English_words", textBoxEnglish.Text);
                command.Parameters.AddWithValue("Transcription", textBoxTranscription.Text);
                command.Parameters.AddWithValue("Example", textBoxExample.Text);
                command.Parameters.AddWithValue("Russian_words", textBoxRussian.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString());
            }
            else
                MessageBox.Show("Not all data is entered!");

        }

        private bool FloatText_True()
        {
            if (textBoxEnglish.Text == floatTextEnglish ||
                textBoxTranscription.Text == floatTextTranscription ||
                textBoxExample.Text == floatTextExample ||
                textBoxRussian.Text == floatTextRussian)
                return false;

            else return true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //Main main = new Main();

            if (tabControl1.SelectedTab == Page1)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    "SELECT ROW_NUMBER() OVER (ORDER BY English_words DESC) AS [Number], English_words, Transcription, Example, Russian_words FROM Dictionary", sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

                AutoSizeMode = AutoSizeMode.GrowOnly;
                MaximizeBox = true;
            }
            else
            {
                AutoSizeMode = AutoSizeMode.GrowAndShrink;
                WindowState = FormWindowState.Normal;
                Width = width;
                Height = height;
                MaximizeBox = false;
            }

        }

        private void textBoxSort_TextChanged(object sender, System.EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"English_words LIKE '%{textBoxSort.Text}%'"; 
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            switch (comboBoxSelect.SelectedIndex)
            {
                case 0:
                    dataAdapter = new SqlDataAdapter("SELECT ROW_NUMBER() OVER (ORDER BY English_words DESC) AS [Number], English_words, Transcription, Example, Russian_words " +
                        "FROM Dictionary ORDER BY English_words", sqlConnection); // output by english words
                    break;

                case 1:
                    dataAdapter = new SqlDataAdapter("SELECT ROW_NUMBER() OVER (ORDER BY English_words DESC) AS [Number], English_words, Transcription, Example, Russian_words " +
                        "FROM Dictionary ORDER BY Russian_words", sqlConnection); // russian words
                    break;

                case 2:
                    dataAdapter = new SqlDataAdapter("SELECT ROW_NUMBER() OVER (ORDER BY English_words DESC) AS [Number], English_words, Transcription, Example, Russian_words" +
                        " FROM Dictionary ORDER BY Example", sqlConnection); // example
                    break;

                case 3:
                    dataAdapter = new SqlDataAdapter("SELECT ROW_NUMBER() OVER (ORDER BY English_words DESC) AS [Number], English_words, Transcription, Example, Russian_words" +
                        " FROM Dictionary", sqlConnection); // all
                    break;
            }
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
