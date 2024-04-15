using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
namespace L4 {
    public partial class Form1 : Form {
        readonly SQLiteConnection connection = new(@"data source = D:\Prog_4_Sem\ProgSys_L4\L4\Products.db");
        public Form1() {

            InitializeComponent();

            DataTable table = GetAllData();
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].ReadOnly = true;

            if (CheckShowGreeting()) {
                checkBox1.Checked = true;
                ShowInfo();
            }
            else {
                checkBox1.Checked = false;
            }
        }
        private DataTable GetAllData() {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = @"SELECT
                    ID as ID,
                    name as 'Название',
                    price as 'Цена за ед.',
                    ammount as 'Количество'
                    from products;";
            SQLiteCommand command = new(query, connection);

            SQLiteDataAdapter adapter = new(command);

            DataTable dataTable = new();
            adapter.Fill(dataTable);

            command.Dispose();
            connection.Close();

            return dataTable;

        }
        private static bool CheckShowGreeting() {
            const string filePath = "ShowGreetingCheck.txt";
            using StreamReader reader = new(filePath);
            if (reader.ReadLine() == "1") {
                reader.Close();
                return true;
            }
            else {
                reader.Close();
                return false;
            }

        }
        private static void ShowInfo() {
            InfoForm info = new();
            info.ShowDialog();
        }

        private static void ChangeShowGreeting(bool isChecked) {
            const string filePath = "ShowGreetingCheck.txt";
            using StreamWriter writer = new(filePath);
            if (isChecked) {
                writer.WriteLine("1");
            }
            else {
                writer.WriteLine("0");
            }
        }
        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            DataGridView? dataGridView = sender as DataGridView;
            if (dataGridView != null) {
                object? value = e.FormattedValue;
                if (value == null || string.IsNullOrEmpty(value.ToString()) || (int.TryParse(value.ToString(), out int result) && result < 0)) {
                    e.Cancel = true;
                    try {
                        throw new FormatException();
                    }
                    catch (FormatException) {
                        // Handle the FormatException here
                        // For example, you can log the exception or show a message to the user
                        MessageBox.Show("Ошибка! Введены данные неверного формата!", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            if (e.Exception is FormatException) {
                MessageBox.Show("Ошибка! Введены данные неверного формата!", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Handle the error for a FormatException
                e.ThrowException = false; // Prevent the exception from being thrown
                e.Cancel = true; // Cancel the edit operation if desired
            }
            else {
                // Handle other exceptions or rethrow
                e.ThrowException = true;
            }
        }
        private void addBtn_Click(object sender, EventArgs e) {
            AddForm addWindow = new(connection);
            DialogResult result = addWindow.ShowDialog();
            if (result == DialogResult.OK) {
                if (dataGridView1.DataSource is DataTable dataTable) {
                    DataRow? newRow = dataTable.NewRow();
                    //newRow[0] = addWindow.returnRow[0];
                    newRow[1] = addWindow.returnRow[1];
                    newRow[2] = addWindow.returnRow[2];
                    newRow[3] = addWindow.returnRow[3];
                    int newValue = 1;
                    if (dataTable.Rows.Count > 0) {
                        DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];
                        if (lastRow[0] != DBNull.Value) {
                            newValue = Convert.ToInt32(lastRow[0]) + 1;
                        }
                    }
                    newRow[0] = newValue;
                    dataTable.Rows.Add(newRow);
                    dataGridView1.Refresh();
                }
                // Access the return values from Form2
            }
            //if (dataGridView1.DataSource is DataTable dataTable) {
            //    DataRow newRow = dataTable.NewRow();
            //    int newValue = 1;
            //    if (dataTable.Rows.Count > 0) {
            //        DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];
            //        if (lastRow[0] != DBNull.Value) {
            //            newValue = Convert.ToInt32(lastRow[0]) + 1;
            //        }
            //    }

            //    newRow[0] = newValue;

            //    dataTable.Rows.Add(newRow);
            //}
        }
        private void editBtn_Click(object sender, EventArgs e) {
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex <= dataGridView1.RowCount) {
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];
                if (selectedRow.DataBoundItem is DataRowView rowView) {
                    DataRow dataRow = rowView.Row;
                    EditForm edit = new(connection, dataRow);
                    DialogResult result = edit.ShowDialog();
                    if (result == DialogResult.OK) {
                        bool isDeleted = edit.isDeleted;
                        if (isDeleted) {
                            dataGridView1.Rows.RemoveAt(selectedIndex);
                        }
                        else {
                            DataRow? editRow = edit.editRow;
                            dataRow[0] = editRow[0];
                            dataRow[1] = editRow[1];
                            dataRow[2] = editRow[2];
                            dataRow[3] = editRow[3];
                            foreach (DataGridViewCell cell in selectedRow.Cells) {
                                cell.Value = dataRow[cell.ColumnIndex];
                            }
                        }
                    }
                }
            }
            else {
                MessageBox.Show("Выберите строку для редактирования");
            }
        }
        private void infoBtn_Click(object sender, EventArgs e) {
            ShowInfo();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            ChangeShowGreeting(checkBox1.Checked);
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            DataTable table = GetAllData();
            dataGridView1.DataSource = table;
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            try {
                CheckAndUpdateDB();
            }
            catch (SQLiteException ex) when (ex.Message.Contains("UNIQUE constraint failed: products.name")) {
                // Handle the unique constraint violation here
                MessageBox.Show("Название товара не должно повторяться", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SQLiteException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void CheckAndUpdateDB() {
            DataTable dbTable = GetAllData();

            int dbSize = dbTable.Rows.Count;
            int tableSize = dataGridView1.Rows.Count;

            List<string> dbTableIDs = [];
            List<string> dataGridIDs = [];

            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row.Cells[0].Value != null) {
                    //label1.Text += row.Cells[0].Value.ToString() + '\n';
                    dataGridIDs.Add(row.Cells[0].Value.ToString());
                }
            }

            foreach (DataRow row in dbTable.Rows) {
                dbTableIDs.Add(row[0].ToString());
            }

            for (int i = 0; i < tableSize; i++) {
                //debugLbl.Text += $"\n {dataGridIDs[i]} {dbTableIDs.Contains(dataGridIDs[i])} \n";
                if (!dbTableIDs.Contains(dataGridIDs[i])) {
                    //debugLbl.Text += $"\n !!! {dataGridIDs[i]} {dbTableIDs.Contains(dataGridIDs[i])} \n";
                    DataRow newRow = dbTable.NewRow();
                    newRow[0] = dataGridView1.Rows[i].Cells[0].Value;
                    newRow[1] = dataGridView1.Rows[i].Cells[1].Value;
                    newRow[2] = dataGridView1.Rows[i].Cells[2].Value;
                    newRow[3] = dataGridView1.Rows[i].Cells[3].Value;
                    //debugLbl.Text += $"ADDED {newRow[0]} {newRow[1]} {newRow[2]} {newRow[3]} \n";
                    dbTable.Rows.Add(newRow);
                    AddToDB(newRow);
                }
            }
            for (int i = 0; i < dbTableIDs.Count; i++) {
                if (!dataGridIDs.Contains(dbTableIDs[i])) {
                    DeleteFromDB(dbTableIDs[i]);
                    dbTable.Rows.RemoveAt(i);
                    //debugLbl.Text += "DELETED " + dbTableIDs[i] + "\n";
                }
            }
           // debugLbl.Text += $"{dbTable.Rows.Count} {dataGridView1.Rows.Count} \n";

            for (int i = 0; i < dbTable.Rows.Count; i++) {
                for (int j = 0; j < dbTable.Columns.Count; j++) {
                    if (!dbTable.Rows[i][j].Equals(dataGridView1.Rows[i].Cells[j].Value)) {
                        //debugLbl.Text += $"UDATED {dbTable.Rows[i][0]} = {dataGridView1.Rows[i].Cells[0].Value} \n {dbTable.Rows[i][1]} = {dataGridView1.Rows[i].Cells[1].Value}\n {dbTable.Rows[i][2]} = {dataGridView1.Rows[i].Cells[2].Value}\n {dbTable.Rows[i][3]} = {dataGridView1.Rows[i].Cells[3].Value} \n";
                        UpdateDBRow(dataGridView1.Rows[i]);
                        // You can break here if you only need to know if there is any difference
                    }
                }
            }
        }
        private void UpdateDBRow(DataGridViewRow row) {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = @"UPDATE products SET
                name = @name,
                price = @price,
                ammount = @ammount
                WHERE ID = @id";

            //debugLbl.Text += query;
            SQLiteCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", row.Cells[0].Value);
            command.Parameters.AddWithValue("@name", row.Cells[1].Value);
            command.Parameters.AddWithValue("@price", row.Cells[2].Value);
            command.Parameters.AddWithValue("@ammount", row.Cells[3].Value);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }
        private void DeleteFromDB(string id) {
            //MessageBox.Show("DELETED" + id);
            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = $"DELETE FROM products WHERE ID = @id";
            SQLiteCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();


        }
        private void AddToDB(DataRow newRow) {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string query = "INSERT INTO products VALUES (@id, @name, @price, @ammount)";
            //debugLbl.Text += $"INSERT INTO products VALUES ('{newRow[0].ToString()}', '{newRow[1].ToString()}', '{newRow[2].ToString()}', '{newRow[3].ToString()}')";
            SQLiteCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", newRow[0].ToString());
            command.Parameters.AddWithValue("@name", newRow[1].ToString());
            command.Parameters.AddWithValue("@price", newRow[2].ToString());
            command.Parameters.AddWithValue("@ammount", newRow[3].ToString());
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
            // MessageBox.Show("ADDED" + id);
        }

        private void saveToTxtBtn_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save to Text File";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog1.FileName;
                using StreamWriter writer = new(filePath);
                writer.WriteLine("Данные из таблицы:");
                foreach (DataGridViewRow row in dataGridView1.Rows) {
                    foreach (DataGridViewCell cell in row.Cells) {
                        writer.Write($"{cell.Value} ");
                    }
                    writer.WriteLine();
                }

                writer.Close();
                MessageBox.Show("Данные из таблицы успешно сохранены в файл: " + filePath);
            }
        }
    }
}
