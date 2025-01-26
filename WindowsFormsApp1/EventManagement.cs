using CrystalDecisions.ReportAppServer.DataDefModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EventManagement : Form
    {
        private string date;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private int NextDonorID = 0;
        private System.Data.DataSet dataSet;
        string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Chaitanya\Documents\Visual Studio 2022\DataSources\NGODB.accdb""";
        public EventManagement()
        {
            InitializeComponent();
            try
            {
                // Create a connection to the database
                connection = new OleDbConnection(constr);
                connection.Open();

                // Create a data adapter and configure it with the select command
                adapter = new OleDbDataAdapter("SELECT * FROM EventTB", connection);

                // Create a DataSet to hold the data
                dataSet = new System.Data.DataSet();

                // Fill the DataSet with data from the database
                adapter.Fill(dataSet, "EventTB");
                DataGridEvent.DataSource = dataSet.Tables[0];

                DataGridEvent.AllowUserToDeleteRows = false;
                DataGridEvent.ReadOnly = !Program.IsAdminRole();
                DataGridEvent.Columns["EventDate"].ReadOnly = true;

                DataGridEvent.Columns[0].ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //Events for handling insert and update

            DataGridEvent.Refresh();
            DataGridEvent.CellEndEdit += DataGridEvent_CellEndEdit;
            DataGridEvent.RowValidating += DataGridEvent_RowValidating;
            DataTable OrgDT = dataSet.Tables[0];
            dataSet.AcceptChanges();
            //donor id incrementing
            using (OleDbConnection connection = new OleDbConnection(constr))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand("SELECT MAX(EventID) FROM EventTB", connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        NextDonorID = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        NextDonorID = 1; // Default starting value
                    }
                }
            }
        }

        private void DataGridEvent_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            string nameval = DataGridEvent.Rows[e.RowIndex].Cells["Eventname"].FormattedValue.ToString();
            if (string.IsNullOrEmpty(nameval))
            {
                MessageBox.Show("Cannot keep Event name EMpty");
                e.Cancel = true;
            }
            else { e.Cancel = false;
            
            }
        }

       

        private void DataGridEvent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCell cell = DataGridEvent.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int EventID = Convert.ToInt32(DataGridEvent.Rows[e.RowIndex].Cells["EventID"].Value);

                if (DataGridEvent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                  

                    string updatequery1;
                    if (e.ColumnIndex == DataGridEvent.Columns["AssignedVolunteer"].Index)
                    {  // Get the updated value
                        int newValue = Convert.ToInt32(cell.Value);
                        int AvailableVolunteers = GetAvailableVolunteers();
                        int TotalVolunteers = GetTotalVolunteers();
                        // Check if the updated value is greater than the available volunteers

                        if (newValue > AvailableVolunteers || newValue > TotalVolunteers)
                        {
                            MessageBox.Show("AssignedVolunteers cannot be greater than AvailableVolunteers or TotalVolunteers.\n Available Volunteers Are :" + AvailableVolunteers);

                            cell.Value = 0;
                            return;
                        }
                        else
                        {

                            updatequery1 = $"UPDATE EventTB SET {DataGridEvent.Columns[cell.ColumnIndex].Name} = {newValue} WHERE EventID={EventID}";
                            using (OleDbConnection connection = new OleDbConnection(constr))
                            {
                                connection.Open();
                                using (OleDbCommand command = new OleDbCommand(updatequery1, connection))
                                {
                                    int rowsAffected = command.ExecuteNonQuery();
                                    updatevolunteercount(newValue);
                                   // MessageBox.Show($"Row Updated in EventTB ({rowsAffected} rows affected)");
                                }
                            }
                        }

                    }
                    //Event name updates Expense table
                    else if (e.ColumnIndex == DataGridEvent.Columns["Expense"].Index)
                    {
                     
                        int newValue = Convert.ToInt32(cell.FormattedValue.ToString());
                        updatequery1 = $"UPDATE EventTB SET {DataGridEvent.Columns[cell.ColumnIndex].Name} = {newValue} WHERE EventID={EventID}";

                        using (OleDbConnection connection = new OleDbConnection(constr))
                        {
                            connection.Open();
                            using (OleDbCommand command = new OleDbCommand(updatequery1, connection))
                            {
                                int rowsAffected = command.ExecuteNonQuery();

                                //  MessageBox.Show($"Row Updated in EventTB ({rowsAffected} rows affected)");
                            }
                        }
                        string Eventnm = DataGridEvent.Rows[e.RowIndex].Cells["Eventname"].FormattedValue.ToString();
                        FinancialManagement FS = new FinancialManagement();
                        FS.AddExpenseUsingNote(Eventnm, newValue);
                     //   FS.Dispose();


                    }


                    //regular column
                    else
                    {
                        string newValue=cell.FormattedValue.ToString();
                        updatequery1 = $"UPDATE EventTB SET {DataGridEvent.Columns[cell.ColumnIndex].Name} = '{newValue}' WHERE EventID={EventID}";

                        using (OleDbConnection connection = new OleDbConnection(constr))
                        {
                            connection.Open();
                            using (OleDbCommand command = new OleDbCommand(updatequery1, connection))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                string nameval = DataGridEvent.Rows[e.RowIndex].Cells["Eventname"].FormattedValue.ToString();
                                FinancialManagement FS = new FinancialManagement();
                                MessageBox.Show("Adding a new row");
                                FS.addrow(nameval);
                                FS.Dispose();

                                //  MessageBox.Show($"Row Updated in EventTB ({rowsAffected} rows affected)");
                            }
                        }
                    }


                    // Update the database

                }
            }
            catch (Exception ex) { MessageBox.Show("Exception" + ex.Message); }
        }
        

        private int GetTotalVolunteers()
        {
            string query = "SELECT TotalVolunteers FROM VolunteersTB";
            int totalVolunteers = 0;

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Execute the query and retrieve the result
                object result = command.ExecuteScalar();



                totalVolunteers = Convert.ToInt32(result);
                return totalVolunteers;
            }
        }
        private void updatevolunteercount(int assigned)
        {
            string query = $"UPDATE VolunteersTB SET AssignedVolunteer = AssignedVolunteer + {assigned}";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
            string query2 = $"UPDATE VolunteersTB SET AvailableVolunteers = TotalVolunteers - AssignedVolunteer";
            using (OleDbCommand command = new OleDbCommand(query2, connection))
            {
                command.ExecuteNonQuery();
            }

        }
        private int GetAvailableVolunteers()
        {
            string query = "SELECT AvailableVolunteers FROM VolunteersTB";
            int Assigned = 0;

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Execute the query and retrieve the result
                object result = command.ExecuteScalar();



                Assigned = Convert.ToInt32(result);
                return Assigned;
            }
        }

        private void InsertRow_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new row and add it to the DataGridView
                DataRow newRow = dataSet.Tables["EventTB"].NewRow();
                newRow["EventID"] = NextDonorID++; // Auto-increment DonorID
                dataSet.Tables["EventTB"].Rows.Add(newRow);
                using (OleDbConnection connection = new OleDbConnection(constr))
                {
                    connection.Open();
                    string insertQuery = $"INSERT INTO EventTB (EventID) VALUES ({newRow["EventID"]})";
                    using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                    

                    }

                }
                DataGridEvent.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimeConverter cr = new DateTimeConverter();
            date = cr.ConvertToString(kryptonDateTimePicker1.Value.Date);
            int EventID = Convert.ToInt32(DataGridEvent.Rows[DataGridEvent.SelectedCells[0].OwningRow.Index].Cells["EventID"].Value);
            string Evname = Convert.ToString(DataGridEvent.Rows[DataGridEvent.SelectedCells[0].OwningRow.Index].Cells["Eventname"].Value);
            DataGridEvent.Rows[DataGridEvent.SelectedCells[0].OwningRow.Index].Cells["EventDate"].Value = date;
            string updatequery = $"UPDATE EventTB SET EventDate = '{date}' WHERE EventID={EventID}";
            using (OleDbConnection connection = new OleDbConnection(constr))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(updatequery, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    FinancialManagement FS = new FinancialManagement();

                    FS.UpdateDateViaName(Evname, date);
                    FS.Dispose();
                    //  MessageBox.Show($"New Row Added in DonationTB ({rowsAffected} rows affected)");
                    DataGridEvent.Refresh();
                }
            }


        }
    }
}

