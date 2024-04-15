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
            editBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(175, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(613, 393);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValidating += dataGridView_CellValidating;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(12, 66);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(149, 23);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Обновить таблицу";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(12, 169);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(149, 38);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Сохранить изменения в базу данных";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(12, 272);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(157, 49);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Показать информацию при запуске";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // infoBtn
            // 
            infoBtn.Location = new Point(29, 243);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(99, 23);
            infoBtn.TabIndex = 7;
            infoBtn.Text = "Информация";
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(12, 95);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(149, 41);
            addBtn.TabIndex = 8;
            addBtn.Text = "Добавить новую строку";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // saveToTxtBtn
            // 
            saveToTxtBtn.Location = new Point(10, 213);
            saveToTxtBtn.Name = "saveToTxtBtn";
            saveToTxtBtn.Size = new Size(149, 23);
            saveToTxtBtn.TabIndex = 10;
            saveToTxtBtn.Text = "Сохранить в .txt файл";
            saveToTxtBtn.UseVisualStyleBackColor = true;
            saveToTxtBtn.Click += saveToTxtBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(12, 142);
            editBtn.Margin = new Padding(3, 2, 3, 2);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(149, 22);
            editBtn.TabIndex = 11;
            editBtn.Text = "Редактировать строку";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editBtn);
            Controls.Add(saveToTxtBtn);
            Controls.Add(addBtn);
            Controls.Add(infoBtn);
            Controls.Add(checkBox1);
            Controls.Add(saveBtn);
            Controls.Add(updateBtn);
            Controls.Add(dataGridView1);
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
        private Button editBtn;
    }
}
