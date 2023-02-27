using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
