using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4 {
    public partial class EditForm : Form {
        public DataRow? editRow { get; private set; }
        public SQLiteConnection? connection { get; private set; }
        public bool isDeleted { get; private set; }
        public EditForm(SQLiteConnection con, DataRow? inputRow) {
            InitializeComponent();

            priceNumericBox.Maximum = Decimal.MaxValue;
            ammountNumericBox.Maximum = Decimal.MaxValue;

            connection = con;
            editRow = inputRow;
            IDTextBox.Text = editRow[0].ToString();
            nameTextBox.Text = editRow[1].ToString();
            priceNumericBox.Value = Convert.ToDecimal(editRow[2]);
            ammountNumericBox.Value = Convert.ToDecimal(editRow[3]);
        }

        private bool CheckIfEmpty() {
            if (String.IsNullOrEmpty(nameTextBox.Text) ||
                String.IsNullOrEmpty(priceNumericBox.Text) ||
                String.IsNullOrEmpty(ammountNumericBox.Text)) {
                MessageBox.Show("Одно из полей не заполнено");
                // One or more fields are empty
                return true;
            }
            else {
                return false;
            }
        }
        private bool CheckUniqueName(string name) {

            if (connection.State != ConnectionState.Open)
                connection.Open();
            string query = @"SELECT
                    COUNT(*)
                    from products
                    where name = '@name';";
            SQLiteCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", name);

            int count = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
            if (count > 0) {
                MessageBox.Show("Поле с таким именем уже существует");
                return false;
            }
            else {
                return true;
            }

        }

        private void confirmBtn_Click(object sender, EventArgs e) {
            //debugLbl.Text += CheckIfEmpty();
            //debugLbl.Text += CheckUniqueName(nameTextBox.Text);
            //debugLbl.Text += CheckUniqueName(nameTextBox.Text) && !CheckIfEmpty();
            if (CheckUniqueName(nameTextBox.Text) && !CheckIfEmpty()) {
                editRow[0] = IDTextBox.Text;
                editRow[1] = nameTextBox.Text; // Assuming name is in the first column (index 0)
                editRow[2] = priceNumericBox.Text; // Assuming price is in the second column (index 1)
                editRow[3] = ammountNumericBox.Text; // Assuming amount is in the third column (index 2)
                isDeleted = false;
                DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            isDeleted = false;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            isDeleted = true;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
