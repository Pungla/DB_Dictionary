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

namespace DB_lesson
{
    public partial class Add_Form : Form
    {
        DataBase dataBase = new DataBase();

        const string floatTextEnglish = "English word";
        const string floatTextTranscription = "Transcription";
        const string floatTextExample = "Example";
        const string floatTextRussian = "Russian word";

        public Add_Form()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            dataBase.OpenConnection();

            if (FloatText_True())
            {
                SqlCommand command = new SqlCommand(
                $"INSERT INTO [Dictionary] (English_words, Transcription, Example, Russian_words) VALUES (@English_words, @Transcription, @Example, @Russian_words)",
                dataBase.getConnection());

                command.Parameters.AddWithValue("English_words", textBoxEnglish.Text);
                command.Parameters.AddWithValue("Transcription", textBoxTranscription.Text);
                command.Parameters.AddWithValue("Example", textBoxExample.Text);
                command.Parameters.AddWithValue("Russian_words", textBoxRussian.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully!!!");                
            }
            else
                MessageBox.Show("Not all data is entered!");

            dataBase.CloseConnection();

            textBoxEnglish.Text = "";
            textBoxTranscription.Text = "";
            textBoxExample.Text = "";
            textBoxRussian.Text = "";
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

        private void Add_Form_Load(object sender, EventArgs e)
        {
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
    }
}
