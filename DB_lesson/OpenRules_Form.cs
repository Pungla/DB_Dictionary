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
            ToolTip t = new ToolTip();
            t.SetToolTip(menuStrip1, "sdad");
        }
    }
}
