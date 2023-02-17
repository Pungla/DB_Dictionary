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
    public partial class Test_Form : Form
    {
        private int count = 0;
        private SqlDataReader reader = null;
        private SqlCommand command = null;

        public string english = null;
        public string russian = null;

        DataBase dataBase = new DataBase();
        public Test_Form()
        {
            InitializeComponent();
        }

        private void StartCommand()
        {
            string queryString = $"select English_words, Russian_words from Dictionary order by newid()";
            command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.OpenConnection();

            reader = command.ExecuteReader();
            if (reader.Read())
            {
                ReadSingle(reader);
            }

            if (radioButtonEn_Ru.Checked)
            {
                label1.Text = "English:";
                label2.Text = "Russian:";
            }
            else
            {
                label1.Text = "Russian:";
                label2.Text = "English:";
            }
        }

        private void TestUpdate()
        {
            if (radioButtonEn_Ru.Checked)
            {
                if (textBox2.Text != russian)
                {
                    MessageBox.Show("Wrong!");
                }   
                else
                {
                    textBox2.Text = "";
                    textBox1.Text = "";

                    if (reader.Read())
                    {
                        ReadSingle(reader);
                    }
                    else
                    {
                        MessageBox.Show("There are no words(");
                        disablingButton(true);
                        reader.Close();
                        dataBase.CloseConnection();
                    }
                }
            }
            else
            {
                if (textBox2.Text != english)
                {
                    MessageBox.Show("Wrong!");
                }
                else
                {
                    textBox2.Text = "";
                    textBox1.Text = "";

                    if (reader.Read())
                    {
                        ReadSingle(reader);
                    }
                    else
                    {
                        MessageBox.Show("There are no words(");
                        disablingButton(true);
                        reader.Close();
                        dataBase.CloseConnection();
                    }
                }
            }
        }

        private void ReadSingle(IDataRecord record)
        {
            english = record.GetString(0);
            russian = record.GetString(1);
            if (radioButtonEn_Ru.Checked == true)
            {
                textBox1.Text = english.ToString();
            }
            else
            {
                textBox1.Text = russian.ToString();
            }            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            disablingButton(false);

            StartCommand();
        }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            buttonStop.Enabled = false;
            buttonNext.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            disablingButton(true);

            reader.Close();
            dataBase.CloseConnection();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            TestUpdate();
        }

        private void disablingButton(bool b)
        {
            if (b)
            {
                buttonStart.Enabled = true;
                numericUpDown1.Enabled = true;
                radioButtonEn_Ru.Enabled = true;
                radioButtonRu_En.Enabled = true;

                textBox1.Enabled = false;
                textBox2.Enabled = false;

                buttonStop.Enabled = false;
                buttonNext.Enabled = false;

                label1.Text = "";
                label2.Text = "";
            }
            else
            {
                buttonStart.Enabled = false;
                numericUpDown1.Enabled = false;
                radioButtonEn_Ru.Enabled = false;
                radioButtonRu_En.Enabled = false;

                textBox1.Enabled = true;
                textBox2.Enabled = true;

                buttonStop.Enabled = true;
                buttonNext.Enabled = true;
            }
        }
    }
}
