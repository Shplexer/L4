using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4 {
    public partial class AddForm : Form {
        public SQLiteConnection? connection {get; private set;}
        public DataRow? returnRow { get; private set; }
        public AddForm(SQLiteConnection con) {
            InitializeComponent();

            priceNumericBox.Maximum = Decimal.MaxValue;
            ammountNumericBox.Maximum = Decimal.MaxValue;

            connection = con;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e) {
            //debugLbl.Text += CheckIfEmpty();
            //debugLbl.Text += CheckUniqueName(nameTextBox.Text);
            //debugLbl.Text += CheckUniqueName(nameTextBox.Text) && !CheckIfEmpty();
            if (CheckUniqueName(nameTextBox.Text) && !CheckIfEmpty()) {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Name", typeof(string)); // Define column 0 for Name
                dataTable.Columns.Add("Price", typeof(string)); // Define column 1 for Price
                dataTable.Columns.Add("Amount", typeof(string)); // Define column 2 for Amount
                DataRow newRow = dataTable.NewRow();
                newRow[1] = nameTextBox.Text; // Assuming name is in the first column (index 0)
                newRow[2] = priceNumericBox.Text; // Assuming price is in the second column (index 1)
                newRow[3] = ammountNumericBox.Text; // Assuming amount is in the third column (index 2)
                returnRow = newRow;
                DialogResult = DialogResult.OK;
                this.Close();

            }
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
    }
}
