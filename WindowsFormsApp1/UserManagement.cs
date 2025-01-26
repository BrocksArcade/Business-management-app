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
    public partial class UserManagement : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;

        private System.Data.DataSet dataSet;
        string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Chaitanya\Documents\Visual Studio 2022\DataSources\NGODB.accdb""";
        public UserManagement()
        {
            InitializeComponent();
            label1.Visible = Program.IsAdminRole();
            label2.Visible = Program.IsAdminRole();    
            SetAdminButton.Visible = Program.IsAdminRole();
            DeleteUser.Visible = Program.IsAdminRole();

            connection = new OleDbConnection(constr);
            connection.Open();
            int myempid = Properties.Settings.Default.userid;
            // Create a data adapter and configure it with the select command
            adapter = new OleDbDataAdapter($"SELECT UserID, UserName, PhoneNo, Email, IsAdmin FROM UserList WHERE UserID <> {myempid}", connection);

            // Create a DataSet to hold the data
            dataSet = new System.Data.DataSet();

            // Fill the DataSet with data from the database
            adapter.Fill(dataSet, "UserList");
            DataGridUser.DataSource = dataSet.Tables[0];



            DataGridUser.ReadOnly = true;

        }

        private void SetAdminButton_Click(object sender, EventArgs e)
        {
            if (DataGridUser.SelectedCells.Count > 0)
            {



                // Get the value of the 'IsAdmin' column for the selected row
                bool isAdmin = Convert.ToBoolean(DataGridUser.Rows[DataGridUser.SelectedCells[0].OwningRow.Index].Cells["IsAdmin"].Value);

                // Toggle the 'IsAdmin' value (from true to false or vice versa)

                isAdmin = !isAdmin;
                DataGridUser.Rows[DataGridUser.SelectedCells[0].OwningRow.Index].Cells["IsAdmin"].Value = isAdmin;
                int ID = (int)DataGridUser.Rows[DataGridUser.SelectedCells[0].OwningRow.Index].Cells["UserID"].Value;
                // Update the 'IsAdmin' value in the DataGridView

                string updatequery = $"UPDATE UserList SET IsAdmin ='{Convert.ToString(isAdmin)}' WHERE UserID= {ID}";
                using (OleDbCommand command = new OleDbCommand(updatequery, connection))
                {
                    int res = command.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Access Modified");
                    }
                }

                // Refresh the DataGridView to reflect the changes
                DataGridUser.Refresh();

            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (DataGridUser.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = DataGridUser.SelectedRows[0];

                // Get the UserID from the selected row
                int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                //Remove user
             




                    // Define the DELETE query to remove the user by UserId
                    string deleteQuery = $"DELETE FROM UserList WHERE UserID = {userId}";

                    using (OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection))
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User removed successfully.");
                        DataGridUser.Rows.RemoveAt(selectedRow.Index);
                            // Refresh the DataGridUser after removing the user
                            DataGridUser.Refresh(); // You may need to implement this method to load the data again.
                        }
                        else
                        {
                            MessageBox.Show("No user was removed. User not found.");
                        }
                    }
                
            }
            else
            {
                MessageBox.Show("Please select a user to remove.");
            } 
          
        }
    }
}


