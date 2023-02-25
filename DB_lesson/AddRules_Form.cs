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
    public partial class AddRules_Form : Form
    {
        DataBase dataBase = new DataBase();
        public AddRules_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameString = textBox1.Text;
            string ruleString = richTextBox1.Text;

            string addString = $"insert Rules values ('{nameString}', '{ruleString}')";

            var command = new SqlCommand(addString, dataBase.getConnection());
            dataBase.OpenConnection();

            command.ExecuteNonQuery();

            dataBase.CloseConnection();

            this.Close();
        }
    }
}
