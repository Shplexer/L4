using System.Windows.Forms;

namespace L4 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dataGridView1 = new DataGridView();
            updateBtn = new Button();
            saveBtn = new Button();
            checkBox1 = new CheckBox();
            infoBtn = new Button();
            addBtn = new Button();
            saveToTxtBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(200, 33);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(701, 524);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValidating += dataGridView_CellValidating;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(14, 88);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(170, 31);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Обновить таблицу";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(14, 190);
            saveBtn.Margin = new Padding(3, 4, 3, 4);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(170, 51);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Сохранить в базу данных";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(14, 328);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(179, 65);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Показать информацию при запуске";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // infoBtn
            // 
            infoBtn.Location = new Point(33, 289);
            infoBtn.Margin = new Padding(3, 4, 3, 4);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(113, 31);
            infoBtn.TabIndex = 7;
            infoBtn.Text = "Информация";
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(14, 127);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(170, 55);
            addBtn.TabIndex = 8;
            addBtn.Text = "Добавить новую строку";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // saveToTxtBtn
            // 
            saveToTxtBtn.Location = new Point(12, 249);
            saveToTxtBtn.Margin = new Padding(3, 4, 3, 4);
            saveToTxtBtn.Name = "saveToTxtBtn";
            saveToTxtBtn.Size = new Size(170, 31);
            saveToTxtBtn.TabIndex = 10;
            saveToTxtBtn.Text = "Сохранить в .txt файл";
            saveToTxtBtn.UseVisualStyleBackColor = true;
            saveToTxtBtn.Click += saveToTxtBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(saveToTxtBtn);
            Controls.Add(addBtn);
            Controls.Add(infoBtn);
            Controls.Add(checkBox1);
            Controls.Add(saveBtn);
            Controls.Add(updateBtn);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button updateBtn;
        private Button saveBtn;
        private CheckBox checkBox1;
        private Button infoBtn;
        private Button addBtn;
        private Button saveToTxtBtn;
        private SaveFileDialog saveFileDialog1;
    }
}
