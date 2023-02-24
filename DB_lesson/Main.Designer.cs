
namespace DB_lesson
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBigScreen = new System.Windows.Forms.Button();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearchForRules = new System.Windows.Forms.TextBox();
            this.buttonChangeRule = new System.Windows.Forms.Button();
            this.buttonDeleteRule = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yandexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForNote = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxRusWr = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelRusWr = new System.Windows.Forms.Label();
            this.textBoxExam = new System.Windows.Forms.TextBox();
            this.labelEnWr = new System.Windows.Forms.Label();
            this.textBoxTranscr = new System.Windows.Forms.TextBox();
            this.labelExample = new System.Windows.Forms.Label();
            this.textBoxEnWr = new System.Windows.Forms.TextBox();
            this.labelTranscr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNewNote = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Page2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelForNote.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Controls.Add(this.Page2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 348);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.tableLayoutPanel1);
            this.Page1.Location = new System.Drawing.Point(4, 25);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(776, 319);
            this.Page1.TabIndex = 1;
            this.Page1.Text = "Output";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSort, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonRefresh, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBigScreen, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 244);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(656, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSort
            // 
            this.textBoxSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSort.Location = new System.Drawing.Point(3, 284);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(656, 27);
            this.textBoxSort.TabIndex = 4;
            this.textBoxSort.TextChanged += new System.EventHandler(this.textBoxSort_TextChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.BackgroundImage")));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRefresh.Location = new System.Drawing.Point(718, 253);
            this.buttonRefresh.Name = "buttonRefresh";
            this.tableLayoutPanel1.SetRowSpan(this.buttonRefresh, 2);
            this.buttonRefresh.Size = new System.Drawing.Size(49, 57);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonBigScreen
            // 
            this.buttonBigScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBigScreen.BackgroundImage")));
            this.buttonBigScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBigScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBigScreen.Location = new System.Drawing.Point(665, 253);
            this.buttonBigScreen.Name = "buttonBigScreen";
            this.tableLayoutPanel1.SetRowSpan(this.buttonBigScreen, 2);
            this.buttonBigScreen.Size = new System.Drawing.Size(47, 57);
            this.buttonBigScreen.TabIndex = 8;
            this.buttonBigScreen.UseVisualStyleBackColor = true;
            this.buttonBigScreen.Click += new System.EventHandler(this.buttonBigScreen_Click);
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.tableLayoutPanel2);
            this.Page2.Location = new System.Drawing.Point(4, 25);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(776, 319);
            this.Page2.TabIndex = 0;
            this.Page2.Text = "Rules";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearchForRules, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonChangeRule, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteRule, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 313);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::DB_lesson.Properties.Resources.поиск_иконка_png_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchForRules
            // 
            this.textBoxSearchForRules.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchForRules.Location = new System.Drawing.Point(41, 3);
            this.textBoxSearchForRules.Name = "textBoxSearchForRules";
            this.textBoxSearchForRules.Size = new System.Drawing.Size(263, 27);
            this.textBoxSearchForRules.TabIndex = 1;
            // 
            // buttonChangeRule
            // 
            this.buttonChangeRule.BackgroundImage = global::DB_lesson.Properties.Resources.depositphotos;
            this.buttonChangeRule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChangeRule.Location = new System.Drawing.Point(695, 3);
            this.buttonChangeRule.Name = "buttonChangeRule";
            this.buttonChangeRule.Size = new System.Drawing.Size(32, 28);
            this.buttonChangeRule.TabIndex = 2;
            this.buttonChangeRule.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRule
            // 
            this.buttonDeleteRule.BackgroundImage = global::DB_lesson.Properties.Resources.clipart;
            this.buttonDeleteRule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteRule.Location = new System.Drawing.Point(733, 3);
            this.buttonDeleteRule.Name = "buttonDeleteRule";
            this.buttonDeleteRule.Size = new System.Drawing.Size(32, 28);
            this.buttonDeleteRule.TabIndex = 3;
            this.buttonDeleteRule.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.listBox1, 5);
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(3, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(764, 273);
            this.listBox1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.outputTableToolStripMenuItem,
            this.testToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTableToolStripMenuItem,
            this.dictionaryToolStripMenuItem,
            this.translateToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.addToolStripMenuItem.Text = "Action";
            // 
            // addTableToolStripMenuItem
            // 
            this.addTableToolStripMenuItem.Name = "addTableToolStripMenuItem";
            this.addTableToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.addTableToolStripMenuItem.Text = "Add table";
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            this.dictionaryToolStripMenuItem.Click += new System.EventHandler(this.dictionaryToolStripMenuItem_Click);
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yandexToolStripMenuItem,
            this.googleToolStripMenuItem});
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            this.translateToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.translateToolStripMenuItem.Text = "Translate";
            // 
            // yandexToolStripMenuItem
            // 
            this.yandexToolStripMenuItem.Name = "yandexToolStripMenuItem";
            this.yandexToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.yandexToolStripMenuItem.Text = "Yandex";
            this.yandexToolStripMenuItem.Click += new System.EventHandler(this.yandexToolStripMenuItem_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // outputTableToolStripMenuItem
            // 
            this.outputTableToolStripMenuItem.Name = "outputTableToolStripMenuItem";
            this.outputTableToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.outputTableToolStripMenuItem.Text = "Output Table";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panelForNote
            // 
            this.panelForNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForNote.Controls.Add(this.tableLayoutPanel3);
            this.panelForNote.Location = new System.Drawing.Point(14, 382);
            this.panelForNote.Name = "panelForNote";
            this.panelForNote.Size = new System.Drawing.Size(465, 279);
            this.panelForNote.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.labelNumber, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRusWr, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBoxNumber, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelRusWr, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBoxExam, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelEnWr, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxTranscr, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelExample, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxEnWr, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelTranscr, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(463, 277);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(107, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(75, 55);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Number:";
            // 
            // textBoxRusWr
            // 
            this.textBoxRusWr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRusWr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRusWr.Location = new System.Drawing.Point(188, 223);
            this.textBoxRusWr.Name = "textBoxRusWr";
            this.textBoxRusWr.Size = new System.Drawing.Size(272, 27);
            this.textBoxRusWr.TabIndex = 1;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(188, 3);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(272, 27);
            this.textBoxNumber.TabIndex = 1;
            // 
            // labelRusWr
            // 
            this.labelRusWr.AutoSize = true;
            this.labelRusWr.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelRusWr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRusWr.Location = new System.Drawing.Point(64, 220);
            this.labelRusWr.Name = "labelRusWr";
            this.labelRusWr.Size = new System.Drawing.Size(118, 57);
            this.labelRusWr.TabIndex = 0;
            this.labelRusWr.Text = "Russian Word:";
            // 
            // textBoxExam
            // 
            this.textBoxExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExam.Location = new System.Drawing.Point(188, 168);
            this.textBoxExam.Name = "textBoxExam";
            this.textBoxExam.Size = new System.Drawing.Size(272, 27);
            this.textBoxExam.TabIndex = 1;
            // 
            // labelEnWr
            // 
            this.labelEnWr.AutoSize = true;
            this.labelEnWr.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEnWr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnWr.Location = new System.Drawing.Point(65, 55);
            this.labelEnWr.Name = "labelEnWr";
            this.labelEnWr.Size = new System.Drawing.Size(117, 55);
            this.labelEnWr.TabIndex = 0;
            this.labelEnWr.Text = "English Word:";
            // 
            // textBoxTranscr
            // 
            this.textBoxTranscr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTranscr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTranscr.Location = new System.Drawing.Point(188, 113);
            this.textBoxTranscr.Name = "textBoxTranscr";
            this.textBoxTranscr.Size = new System.Drawing.Size(272, 27);
            this.textBoxTranscr.TabIndex = 1;
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelExample.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExample.Location = new System.Drawing.Point(103, 165);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(79, 55);
            this.labelExample.TabIndex = 0;
            this.labelExample.Text = "Example:";
            // 
            // textBoxEnWr
            // 
            this.textBoxEnWr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnWr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnWr.Location = new System.Drawing.Point(188, 58);
            this.textBoxEnWr.Name = "textBoxEnWr";
            this.textBoxEnWr.Size = new System.Drawing.Size(272, 27);
            this.textBoxEnWr.TabIndex = 1;
            // 
            // labelTranscr
            // 
            this.labelTranscr.AutoSize = true;
            this.labelTranscr.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTranscr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTranscr.Location = new System.Drawing.Point(65, 110);
            this.labelTranscr.Name = "labelTranscr";
            this.labelTranscr.Size = new System.Drawing.Size(117, 55);
            this.labelTranscr.TabIndex = 0;
            this.labelTranscr.Text = "Trancsription:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Location = new System.Drawing.Point(534, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 248);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Controls.Add(this.buttonNewNote, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonDelete, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonChange, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.buttonSave, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(198, 246);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // buttonNewNote
            // 
            this.buttonNewNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNewNote.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewNote.Location = new System.Drawing.Point(32, 3);
            this.buttonNewNote.Name = "buttonNewNote";
            this.buttonNewNote.Size = new System.Drawing.Size(132, 55);
            this.buttonNewNote.TabIndex = 0;
            this.buttonNewNote.Text = "New Note";
            this.buttonNewNote.UseVisualStyleBackColor = true;
            this.buttonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(32, 64);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(132, 55);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChange.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(32, 125);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(132, 55);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(32, 186);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 57);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(559, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Мanaging records:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForNote);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Page2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelForNote.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTableToolStripMenuItem;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.ToolStripMenuItem translateToolStripMenuItem;
        private System.Windows.Forms.Panel panelForNote;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label labelRusWr;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Label labelTranscr;
        private System.Windows.Forms.Label labelEnWr;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxRusWr;
        private System.Windows.Forms.TextBox textBoxExam;
        private System.Windows.Forms.TextBox textBoxTranscr;
        private System.Windows.Forms.TextBox textBoxEnWr;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonNewNote;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ToolStripMenuItem yandexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Button buttonBigScreen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSearchForRules;
        private System.Windows.Forms.Button buttonChangeRule;
        private System.Windows.Forms.Button buttonDeleteRule;
        private System.Windows.Forms.ListBox listBox1;
    }
}

