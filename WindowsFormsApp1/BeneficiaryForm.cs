using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BeneficiaryForm : Form
    {
     
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataSet;
        string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Chaitanya\Documents\Visual Studio 2022\DataSources\NGODB.accdb""";


        public BeneficiaryForm()
        {
            InitializeComponent();



            // Create a connection to the database
            connection = new OleDbConnection(constr);
            connection.Open();

            // Create a data adapter and configure it with the select command
            adapter = new OleDbDataAdapter("SELECT * FROM BeneficiaryTB", connection);

            // Create a DataSet to hold the data
            dataSet = new DataSet();

            // Fill the DataSet with data from the database
            adapter.Fill(dataSet, "BeneficiaryTB");
            
            DataGridBen.DataSource = dataSet.Tables[0];
            DataGridBen.ReadOnly = !Properties.Settings.Default.IsAdmin;
            DataGridBen.AllowUserToDeleteRows = false;
            
            DataGridBen.Columns[0].ReadOnly = true;
            DataGridBen.CellEndEdit += DataGridBen_CellEndEdit;





        }

     

        private void DataGridBen_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dataGridView = (DataGridView)sender;

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewCell cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string columnName = dataGridView.Columns[e.ColumnIndex].Name;

                    if (cell.Value != null)
                    {
                        string newValue = cell.Value.ToString();
                        int beneficiaryID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["BeneficiaryID"].Value);

                        // Construct and execute an update query
                        string updateQuery = $"UPDATE BeneficiaryTB SET {columnName} = '{newValue}' WHERE BeneficiaryID = {beneficiaryID}";

                        using (OleDbConnection connection = new OleDbConnection(constr))
                        {
                            connection.Open();

                            using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                MessageBox.Show($"Row Updated. Rows Affected: {rowsAffected}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }





        //Is unique ID
        private void ErrorIndicaor(string message,int rowindex)
        {
            DataGridBen.Rows[rowindex].ErrorText= message;
            
            
        }


        public static bool ValidateDataGridView(DataGridView dataGridView)
        {
            // Create a HashSet to store unique beneficiary IDs
            HashSet<int> uniqueBeneficiaryIDs = new HashSet<int>();

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Check if the row is not empty 
                if (!row.IsNewRow)
                {
                    // Validate BeneficiaryID
                    if (row.Cells["BeneficiaryID"].Value == null || string.IsNullOrWhiteSpace(row.Cells["BeneficiaryID"].Value.ToString()))
                    {
                        MessageBox.Show("BeneficiaryID cannot be null or empty.");
                        return false; // Validation failed
                    }

                    // Check if BeneficiaryID is a valid number
                    if (!int.TryParse(row.Cells["BeneficiaryID"].Value.ToString(), out int beneficiaryID))
                    {
                        MessageBox.Show("BeneficiaryID must be a valid number.");
                        return false; // Validation failed
                    }

                    // Check if BeneficiaryID is unique
                    if (uniqueBeneficiaryIDs.Contains(beneficiaryID))
                    {
                        MessageBox.Show("BeneficiaryID must be unique.");
                        return false; // Validation failed
                    }

                    // Add the BeneficiaryID to the HashSet to check for duplicates
                    uniqueBeneficiaryIDs.Add(beneficiaryID);
                }
            }

            // All validation checks passed
            return true;
        }

        private void InsertRow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BID.Text))
            {
                if (!Int32.TryParse(BID.Text, out int beneficiaryID))
                {
                    MessageBox.Show("Enter Numeric Value Only in BeneficiaryID", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (PHNOTB.Text.Length == 10)
                    {
                        // Insert data into the "BeneficiaryTB" table
                        string insertQuery = $"INSERT INTO BeneficiaryTB (BeneficiaryID, BeneficiaryName, SupportProvided, PhoneNo,Email) " +
                                             $"VALUES ({beneficiaryID}, '{BNTB.Text}','{SPTB.Text}',  '{PHNOTB.Text}','{EmailTB.Text}')";

                        using (OleDbConnection connection = new OleDbConnection(constr))
                        {
                            try
                            {
                                connection.Open();

                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    int rowsAffected = command.ExecuteNonQuery();


                                    // Refresh the DataGridView after the insert
                                    RefreshDataGridView();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error: {ex.Message}", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else { MessageBox.Show("Phone no should be 10 digits"); }
                }
            }
            else
            {
                MessageBox.Show("Enter a value in BeneficiaryID", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            // Refresh the DataGridView with updated data from the "BeneficiaryTB" table
            dataSet.Tables[0].Clear(); // Clear the existing data
            adapter.Fill(dataSet, "BeneficiaryTB"); // Fill with updated data
            DataGridBen.Refresh();
        }

        private void PHNOTB_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(PHNOTB.Text,out int num))
            { MessageBox.Show("Enter Only Numbers "); }
      
        }
    }
}
