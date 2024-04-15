namespace L4 {
    partial class EditForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            priceNumericBox = new NumericUpDown();
            ammountNumericBox = new NumericUpDown();
            IDTextBox = new TextBox();
            nameTextBox = new TextBox();
            confirmBtn = new Button();
            cancelBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)priceNumericBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ammountNumericBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 64);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 97);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Название товара";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 130);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(31, 18);
            label4.Name = "label4";
            label4.Size = new Size(242, 30);
            label4.TabIndex = 3;
            label4.Text = "Редактирование записи";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 163);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 4;
            label5.Text = "Количество";
            // 
            // priceNumericBox
            // 
            priceNumericBox.Location = new Point(152, 128);
            priceNumericBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            priceNumericBox.Name = "priceNumericBox";
            priceNumericBox.Size = new Size(121, 23);
            priceNumericBox.TabIndex = 5;
            // 
            // ammountNumericBox
            // 
            ammountNumericBox.Location = new Point(152, 161);
            ammountNumericBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ammountNumericBox.Name = "ammountNumericBox";
            ammountNumericBox.Size = new Size(121, 23);
            ammountNumericBox.TabIndex = 6;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(152, 61);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(121, 23);
            IDTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(152, 94);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(121, 23);
            nameTextBox.TabIndex = 8;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(55, 223);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 23);
            confirmBtn.TabIndex = 9;
            confirmBtn.Text = "ОК";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(156, 223);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(95, 194);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(107, 23);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Удалить запись";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 268);
            Controls.Add(deleteBtn);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(nameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(ammountNumericBox);
            Controls.Add(priceNumericBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)priceNumericBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ammountNumericBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown priceNumericBox;
        private NumericUpDown ammountNumericBox;
        private TextBox IDTextBox;
        private TextBox nameTextBox;
        private Button confirmBtn;
        private Button cancelBtn;
        private Button deleteBtn;
    }
}