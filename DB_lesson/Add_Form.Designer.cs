
namespace DB_lesson
{
    partial class Add_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxTranscription = new System.Windows.Forms.TextBox();
            this.textBoxRussian = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxExample, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxEnglish, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTranscription, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxRussian, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(546, 400);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(540, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(3, 323);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(540, 74);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxExample
            // 
            this.textBoxExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExample.Location = new System.Drawing.Point(3, 131);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(540, 27);
            this.textBoxExample.TabIndex = 2;
            this.textBoxExample.Enter += new System.EventHandler(this.textBoxExample_Enter);
            this.textBoxExample.Leave += new System.EventHandler(this.textBoxExample_Leave);
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnglish.Location = new System.Drawing.Point(3, 3);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(540, 27);
            this.textBoxEnglish.TabIndex = 0;
            this.textBoxEnglish.Enter += new System.EventHandler(this.textBoxEnglish_Enter);
            this.textBoxEnglish.Leave += new System.EventHandler(this.textBoxEnglish_Leave);
            // 
            // textBoxTranscription
            // 
            this.textBoxTranscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTranscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTranscription.Location = new System.Drawing.Point(3, 67);
            this.textBoxTranscription.Name = "textBoxTranscription";
            this.textBoxTranscription.Size = new System.Drawing.Size(540, 27);
            this.textBoxTranscription.TabIndex = 1;
            this.textBoxTranscription.Enter += new System.EventHandler(this.textBoxTranscription_Enter);
            this.textBoxTranscription.Leave += new System.EventHandler(this.textBoxTranscription_Leave);
            // 
            // textBoxRussian
            // 
            this.textBoxRussian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRussian.Location = new System.Drawing.Point(3, 195);
            this.textBoxRussian.Name = "textBoxRussian";
            this.textBoxRussian.Size = new System.Drawing.Size(540, 27);
            this.textBoxRussian.TabIndex = 3;
            this.textBoxRussian.Enter += new System.EventHandler(this.textBoxRussian_Enter);
            this.textBoxRussian.Leave += new System.EventHandler(this.textBoxRussian_Leave);
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 400);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxExample;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxTranscription;
        private System.Windows.Forms.TextBox textBoxRussian;
    }
}