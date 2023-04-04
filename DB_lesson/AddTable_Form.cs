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
    public partial class AddTable_Form : Form
    {
        private List<string> listName = new List<string>();
        private List<string> listType = new List<string>();

        DataBase dataBase = new DataBase();

        string tableName = null;

        public AddTable_Form()
        {
            InitializeComponent();
        }

        private void AddTable_Form_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            listName.Add(textBoxColumnName.Text);
            listType.Add(comboBoxType.Text);

            textBoxColumnName.Text = "";
            comboBoxType.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Stop")
            {
                listName.Add(textBoxColumnName.Text);
                listType.Add(comboBoxType.Text);

                textBoxColumnName.Text = "";
                comboBoxType.Text = "";

                button2.Text = "Complete!";
                label1.Text = "Table name:";
                label2.Visible = false;
                comboBoxType.Visible = false;
                button1.Enabled = false;
                textBoxColumnName.Text = "";
            }
            else
            {
                tableName = textBoxColumnName.Text;

                string str = GreateString();

                string createTable = $"CREATE TABLE {tableName} ({str})";
                dataBase.OpenConnection();
                var command = new SqlCommand(createTable, dataBase.getConnection());

                command.ExecuteNonQuery();

                dataBase.CloseConnection();

                this.Close();               
            }
        }

        private string GreateString()
        {
            string str = "Id INT IDENTITY (1, 1) NOT NULL, ";

            for (int i = 0; i < listName.Count; i++)
            {
                str = str + listName[i] + " " + listType[i] + " NOT NULL";
                if (i + 1 != listName.Count)
                {
                    str = str + ", ";
                }
            }

            return str;
        }
    }
}
