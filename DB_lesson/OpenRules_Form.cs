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
    public partial class OpenRules_Form : Form
    {
        public static string strName = null;

        DataBase dataBase = new DataBase();
        public OpenRules_Form()
        {
            InitializeComponent();
        }

        private void OpenRules_Form_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        public void OutputRule(string str)
        {
            string queryString = $"select description from Rules where name_rule = '{str}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            richTextBox1.Text = reader.GetString(0);

            reader.Close();
            dataBase.CloseConnection();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            menuStrip1.Items.Add("Save");
            menuStrip1.Items[2].Click += saveToolStripMenuItem_Click;
            menuStrip1.Items[1].Enabled = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            menuStrip1.Items[1].Enabled = true;
            UpdateRule();
            menuStrip1.Items.Remove(menuStrip1.Items[2]);
        }

        private void UpdateRule()
        {
            dataBase.OpenConnection();

            var changeQuery = $"update Rules set name_rule ='{strName}', description = '{richTextBox1.Text}' where name_rule ='{strName}'";

            var command = new SqlCommand(changeQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            dataBase.CloseConnection();
        }

    }
}
