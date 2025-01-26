using ComponentFactory.Krypton.Toolkit;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DonorManagement : Form
    {
        private bool CanPush = false;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private int NextDonorID = 0;
        private DataSet dataSet;
        DataTable OrgDT;
        string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Chaitanya\Documents\Visual Studio 2022\DataSources\NGODB.accdb""";

        public DonorManagement()
        {
            InitializeComponent();
            
         

            try
            {
                // Create a connection to the database
                connection = new OleDbConnection(constr);
                connection.Open();

                // Create a data adapter and configure it with the select command
                adapter = new OleDbDataAdapter("SELECT DonorInfo.DonorID, DonorName, DonorAddress, PhoneNo,Email,DonationType, DateOfDonation, DonationAmount FROM DonorInfo,DonationTB WHERE DonorInfo.DonorID=DonationTB.DonorID", connection);

                // Create a DataSet to hold the data
                dataSet = new DataSet();
             
                // Fill the DataSet with data from the database
                adapter.Fill(dataSet, "DonorInfo");
                DataGridDonor.DataSource = dataSet.Tables[0];
                DataGridDonor.ReadOnly = !Properties.Settings.Default.IsAdmin;
                DataGridDonor.AllowUserToDeleteRows = false;
                DataGridDonor.ReadOnly = !Program.IsAdminRole();
                
                DataGridDonor.Columns[0].ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //Events for handling insert and update
            DataGridDonor.CellValidating += DataGridView_CellValidating;
            DataGridDonor.RowValidated += DataGridDonor_RowValidated;
            DataGridDonor.Refresh();
        
            dataSet.AcceptChanges();
            OrgDT = dataSet.Tables[0];
            using (OleDbConnection connection = new OleDbConnection(constr))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand("SELECT MAX(DonorID) FROM DonorInfo", connection))
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

   
        //Row updating part
        private void DataGridDonor_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (sender != null)
                {
                    if (CanPush)
                    {
                        DataRowView rowview = (DataRowView)DataGridDonor.Rows[e.RowIndex].DataBoundItem;
                        if (rowview != null)
                        {
                            DataRow row = rowview.Row;
                         
                            if (row.RowState == DataRowState.Modified)
                            {
                                // Update DonorInfo
                                string updateQuery = $"UPDATE DonorInfo " +
                                                     $"SET DonorName = '{row["DonorName"]}', " +
                                                     $"DonorAddress = '{row["DonorAddress"]}', " +
                                                     $"Email = '{row["Email"]}', " +
                                                     $"PhoneNo = '{row["PhoneNo"]}' " +
                                                     $"WHERE DonorID = {row["DonorID"]};";
                                DateTime dateOfDonation = (DateTime)row["DateOfDonation"];
                                string updatefinance = $"UPDATE FinancialTB SET Income = {row["DonationAmount"]} , DateOfEntry = '{dateOfDonation:yyyy-MM-dd}' WHERE ID= {row["DonorID"]}";






                                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                                {
                                    int rowsEffected = command.ExecuteNonQuery();
                                  
                                }

                                using (OleDbCommand command = new OleDbCommand($"UPDATE DonationTB SET DonationType = '{row["DonationType"]}', DateOfDonation = #{dateOfDonation:yyyy-MM-dd}#, DonationAmount = {row["DonationAmount"]} WHERE DonorID = {row["DonorID"]}", connection))
                                {
                                    {
                                        int rowsEffected = command.ExecuteNonQuery();
                                       
                                    }
                                }
                                using (OleDbCommand command = new OleDbCommand(updatefinance,connection))
                                {
                                    {
                                        int rowsEffected = command.ExecuteNonQuery();

                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue != null || e.FormattedValue != DBNull.Value)
            {
                if (DataGridDonor.Rows[e.RowIndex].Cells["DonorID"].Value != null && DataGridDonor.Rows[e.RowIndex].Cells["DonorID"].Value != DBNull.Value)
                {

                    if (e.ColumnIndex == DataGridDonor.Columns["Phoneno"].Index)
                    {
                        string inputvalue = e.FormattedValue.ToString();
                        if (inputvalue.Length != 10)
                        {
                            DataGridDonor.Rows[e.RowIndex].ErrorText = "Phone No should be 10 Characters ONLY";
                            e.Cancel = true;

                        }
                        else { DataGridDonor.Rows[e.RowIndex].ErrorText = string.Empty; }

                    }
                    else if (e.ColumnIndex == DataGridDonor.Columns["DonorName"].Index) //Donor ID is numeric
                    {
                        string inputValue = e.FormattedValue.ToString();

                        if (inputValue.Length > 15)
                        {
                            // Show an error message and cancel the edit

                            DataGridDonor.Rows[e.RowIndex].ErrorText = "Please Enter less than 15 Chars";
                            e.Cancel = true;
                        }

                        else
                        {
                            // Clear any previous error message
                            DataGridDonor.Rows[e.RowIndex].ErrorText = string.Empty;
                        }
                    }
                    else if (e.ColumnIndex == DataGridDonor.Columns["DonationType"].Index) //Donor ID is numeric
                    {
                        string inputValue = e.FormattedValue.ToString();

                        if (inputValue.Length > 15)
                        {
                            // Show an error message and cancel the edit

                            DataGridDonor.Rows[e.RowIndex].ErrorText = "Please Enter Less than 15 Chars";
                            e.Cancel = true;

                        }

                        else
                        {
                            // Clear any previous error message
                            DataGridDonor.Rows[e.RowIndex].ErrorText = string.Empty;
                        }
                    }
                    else
                    {
                        CanPush = true;
                        e.Cancel = false;
                        DataGridDonor.Rows[e.RowIndex].ErrorText = string.Empty;

                    }
                }
            }
        }


    

        private void InsertRow_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new row and add it to the DataGridView
                DataRow newRow = dataSet.Tables["DonorInfo"].NewRow();
                newRow["DonorID"] = NextDonorID++; // Auto-increment DonorID
                dataSet.Tables["DonorInfo"].Rows.Add(newRow);
                using (OleDbConnection connection = new OleDbConnection(constr))
                {
                    connection.Open();
                    string insertQuery = $"INSERT INTO DonorInfo (DonorID) VALUES ({newRow["DonorID"]})";
                    using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                    
                    }
                    string insertquery2 = $"INSERT INTO DonationTB (DonorID) VALUES ({newRow["DonorID"]})";
                    using (OleDbCommand command = new OleDbCommand(insertquery2, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                     
                    }
                    string insertquery3 = $"INSERT INTO FinancialTB (ID) VALUES ({newRow["DonorID"]})";
                    string updt = $"UPDATE FinancialTB SET Notes = 'DonationIncome'  WHERE ID=({newRow["DonorID"]})";
                    using (OleDbCommand command = new OleDbCommand(insertquery3, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        command.CommandText = updt;
                        command.ExecuteNonQuery();

                    }
                }
                DataGridDonor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    
    }
}

