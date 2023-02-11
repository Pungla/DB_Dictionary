
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxRussian = new System.Windows.Forms.TextBox();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.textBoxTranscription = new System.Windows.Forms.TextBox();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.Page3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Controls.Add(this.Page2);
            this.tabControl1.Controls.Add(this.Page3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 338);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.tableLayoutPanel1);
            this.Page1.Location = new System.Drawing.Point(4, 25);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(464, 309);
            this.Page1.TabIndex = 1;
            this.Page1.Text = "Output";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSelect, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSort, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 303);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(232, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            "English words",
            "Russian words",
            "Exemple",
            "All"});
            this.comboBoxSelect.Location = new System.Drawing.Point(3, 275);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(223, 26);
            this.comboBoxSelect.TabIndex = 3;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelect_SelectedIndexChanged);
            // 
            // textBoxSort
            // 
            this.textBoxSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSort.Location = new System.Drawing.Point(232, 275);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(223, 27);
            this.textBoxSort.TabIndex = 4;
            this.textBoxSort.TextChanged += new System.EventHandler(this.textBoxSort_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort by";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.buttonAdd);
            this.Page2.Controls.Add(this.textBoxRussian);
            this.Page2.Controls.Add(this.textBoxExample);
            this.Page2.Controls.Add(this.textBoxTranscription);
            this.Page2.Controls.Add(this.textBoxEnglish);
            this.Page2.Location = new System.Drawing.Point(4, 25);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(464, 309);
            this.Page2.TabIndex = 0;
            this.Page2.Text = "Insert";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAdd.Location = new System.Drawing.Point(3, 239);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(458, 67);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxRussian
            // 
            this.textBoxRussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRussian.Location = new System.Drawing.Point(6, 174);
            this.textBoxRussian.Name = "textBoxRussian";
            this.textBoxRussian.Size = new System.Drawing.Size(194, 27);
            this.textBoxRussian.TabIndex = 3;
            this.textBoxRussian.Enter += new System.EventHandler(this.textBoxRussian_Enter);
            this.textBoxRussian.Leave += new System.EventHandler(this.textBoxRussian_Leave);
            // 
            // textBoxExample
            // 
            this.textBoxExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExample.Location = new System.Drawing.Point(6, 121);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(428, 27);
            this.textBoxExample.TabIndex = 2;
            this.textBoxExample.Enter += new System.EventHandler(this.textBoxExample_Enter);
            this.textBoxExample.Leave += new System.EventHandler(this.textBoxExample_Leave);
            // 
            // textBoxTranscription
            // 
            this.textBoxTranscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTranscription.Location = new System.Drawing.Point(6, 71);
            this.textBoxTranscription.Name = "textBoxTranscription";
            this.textBoxTranscription.Size = new System.Drawing.Size(194, 27);
            this.textBoxTranscription.TabIndex = 1;
            this.textBoxTranscription.Enter += new System.EventHandler(this.textBoxTranscription_Enter);
            this.textBoxTranscription.Leave += new System.EventHandler(this.textBoxTranscription_Leave);
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnglish.Location = new System.Drawing.Point(6, 25);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(194, 27);
            this.textBoxEnglish.TabIndex = 0;
            this.textBoxEnglish.Enter += new System.EventHandler(this.textBoxEnglish_Enter);
            this.textBoxEnglish.Leave += new System.EventHandler(this.textBoxEnglish_Leave);
            // 
            // Page3
            // 
            this.Page3.Location = new System.Drawing.Point(4, 25);
            this.Page3.Name = "Page3";
            this.Page3.Size = new System.Drawing.Size(464, 309);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "Select";
            this.Page3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 338);
            this.Controls.Add(this.tabControl1);
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
            this.Page2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxRussian;
        private System.Windows.Forms.TextBox textBoxExample;
        private System.Windows.Forms.TextBox textBoxTranscription;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

