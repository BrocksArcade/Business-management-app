using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FinancialManagement : Form
    {
        private string date;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataTable dt;
        private int ID = 0;

        private DataSet dataSet;
        string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Chaitanya\Documents\Visual Studio 2022\DataSources\NGODB.accdb""";
        public FinancialManagement()
        {
            InitializeComponent();
            try
            {
                // Create a connection to the database
                connection = new OleDbConnection(constr);
                connection.Open();

                // Create a data adapter and configure it with the select command
                adapter = new OleDbDataAdapter("SELECT * FROM FinancialTB", connection);


                // Create a DataSet to hold the data
                dataSet = new System.Data.DataSet();

                // Fill the DataSet with data from the database


                adapter.Fill(dataSet, "FinancialTB");
                DataGridFinance.DataSource = dataSet.Tables[0];
                DataGridFinance.Rows[0].ReadOnly = true;
                DataGridFinance.AllowUserToDeleteRows = false;
                DataGridFinance.AllowUserToAddRows = false;
                DataGridFinance.ReadOnly = !Program.IsAdminRole();
                DataGridFinance.CellEndEdit += DataGridFinance_CellEndEdit;

                DataGridFinance.Columns[0].ReadOnly = true;
                DataGridFinance.Columns[1].ReadOnly = true;
                DataGridFinance.Columns[2].ReadOnly = true;
                DataGridFinance.Columns[3].ReadOnly = true;
                DataGridFinance.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
      


                DataGridFinance.Columns["Notes"].ReadOnly = false;
                //ID increment
                using (OleDbConnection connection = new OleDbConnection(constr))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand("SELECT MAX(ID) FROM FinancialTB", connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            ID = Convert.ToInt32(result) + 1;
                        }
                        else
                        {
                            ID = 1;
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void DataGridFinance_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string query = $"UPDATE FinancialTB SET Notes = '{DataGridFinance.Rows[DataGridFinance.SelectedCells[0].OwningRow.Index].Cells["Notes"].FormattedValue}' WHERE ID={DataGridFinance.Rows[DataGridFinance.SelectedCells[0].OwningRow.Index].Cells["ID"].FormattedValue}";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(constr))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        DataGridFinance.Refresh();
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void AddExpenseUsingNote(string note,int expense)
        {
            string query = $"UPDATE FinancialTB SET Expense = {expense} WHERE Notes = '{note}'";
            MessageBox.Show("Expense " +expense + "Note is " + note);
            try
            {
                using (OleDbConnection connection = new OleDbConnection(constr))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        DataGridFinance.Refresh();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimeConverter cr = new DateTimeConverter();
            date = cr.ConvertToString(kryptonDateTimePicker1.Value.Date);
            int ID = Convert.ToInt32(DataGridFinance.Rows[DataGridFinance.SelectedCells[0].OwningRow.Index].Cells["ID"].Value);
            DataGridFinance.Rows[DataGridFinance.SelectedCells[0].OwningRow.Index].Cells["DateOfEntry"].Value = date;
            string updatequery = $"UPDATE FinancialTB SET DateOfEntry = '{date}' WHERE ID={ID}";
            using (OleDbConnection connection = new OleDbConnection(constr))
            {
               connection.Open();

                using (OleDbCommand command = new OleDbCommand(updatequery, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                
                    DataGridFinance.Refresh();
                }
            }

        }
        public void addrow(string nm)
        {
            DataRow newrow = dataSet.Tables[0].NewRow();
            newrow["ID"] = ID++;
            newrow["Notes"] = nm;
            dataSet.Tables[0].Rows.Add(newrow);
          
            
           
               // connection.Open();
                string query = $"INSERT INTO FinancialTB (ID,Notes) VALUES ({newrow["ID"]},'{newrow["Notes"]}')";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                   // connection.Open();
                    MessageBox.Show("Query executed0" + command.ExecuteNonQuery());

                    DataGridFinance.Refresh();

               }
            
        }
        public void UpdateDateViaName(string nm,string date)
        {
            using (OleDbCommand command = new OleDbCommand($"UPDATE FinancialTB SET DateOfEntry = '{date}' WHERE Notes='{nm}'", connection))
            {
                // connection.Open();
                command.ExecuteNonQuery();
            

                DataGridFinance.Refresh();

            }

        }
  

        private void InsertRow_Click(object sender, EventArgs e)
        {
            DataRow newrow = dataSet.Tables[0].NewRow();
            newrow["ID"] = ID++;
            dataSet.Tables[0].Rows.Add(newrow);

            // connection.Open();
            string query = $"INSERT INTO FinancialTB (ID) VALUES ({newrow["ID"]})";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // connection.Open();
                MessageBox.Show("Query executed0" + command.ExecuteNonQuery());

                DataGridFinance.Refresh();

            }
        }
        
        private int GetCurrentRowValue(string cellvalue)
        {
            return (int)DataGridFinance.Rows[DataGridFinance.SelectedCells[0].OwningRow.Index].Cells["ID"].Value;
        }
        private void AddIncome_ValueChanged(object sender, EventArgs e)
        {
            Int64 num=Convert.ToInt64((AddIncome.Value));
            DataGridFinance.Rows[DataGridFinance.SelectedCells[0].OwningRow.Index].Cells["Income"].Value = num;

            string query = $"UPDATE FinancialTB SET Income={num} WHERE ID ={(GetCurrentRowValue("ID"))}";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {

                command.ExecuteNonQuery();
            }
            DataGridFinance.Refresh();
      

        }

        private void AddExpense_ValueChanged(object sender, EventArgs e)
        {
            Int64 num = Convert.ToInt64((AddExpense.Value));
            string query = $"UPDATE FinancialTB SET Expense={num} WHERE ID={(GetCurrentRowValue("ID"))}";
            DataGridFinance.Rows[DataGridFinance.SelectedCells[0].OwningRow.Index].Cells["Expense"].Value = num;
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
             
                command.ExecuteNonQuery();


            }
            DataGridFinance.Refresh();
        }

        private void GenerateReports_Click(object sender, EventArgs e)
        {
          


        }

        private void ShowTable_Click(object sender, EventArgs e)
        {
          
            FinanceReport FS = new FinanceReport()
            {
                FormBorderStyle = FormBorderStyle.Sizable,
                WindowState= FormWindowState.Maximized,

            };
            this.Hide();
            FS.Show();

        }

        private void DataGridFinance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
