namespace L4 {
    partial class AddForm {
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
            nameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            priceNumericBox = new NumericUpDown();
            ammountNumericBox = new NumericUpDown();
            confirmBtn = new Button();
            cancelBtn = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)priceNumericBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ammountNumericBox).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(148, 61);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(110, 23);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 63);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Название товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 99);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 132);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Количество";
            // 
            // priceNumericBox
            // 
            priceNumericBox.Location = new Point(148, 97);
            priceNumericBox.Margin = new Padding(3, 2, 3, 2);
            priceNumericBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            priceNumericBox.Name = "priceNumericBox";
            priceNumericBox.Size = new Size(109, 23);
            priceNumericBox.TabIndex = 6;
            // 
            // ammountNumericBox
            // 
            ammountNumericBox.Location = new Point(148, 130);
            ammountNumericBox.Margin = new Padding(3, 2, 3, 2);
            ammountNumericBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ammountNumericBox.Name = "ammountNumericBox";
            ammountNumericBox.Size = new Size(109, 23);
            ammountNumericBox.TabIndex = 7;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(44, 168);
            confirmBtn.Margin = new Padding(3, 2, 3, 2);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(82, 22);
            confirmBtn.TabIndex = 8;
            confirmBtn.Text = "ОК";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(148, 168);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(82, 22);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(268, 30);
            label4.TabIndex = 11;
            label4.Text = "Добавление новой записи";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 213);
            Controls.Add(label4);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(ammountNumericBox);
            Controls.Add(priceNumericBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddForm";
            Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)priceNumericBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ammountNumericBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown priceNumericBox;
        private NumericUpDown ammountNumericBox;
        private Button confirmBtn;
        private Button cancelBtn;
        private Label label4;
    }
}