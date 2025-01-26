using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IdentityModel.Selectors;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NGOManagementSystem : KryptonForm
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Chaitanya\Documents\Visual Studio 2022\DataSources\NGODB.accdb";

        public NGOManagementSystem()
        {
            InitializeComponent();

        }



        public async void CheckEMPID()
        {
            int empId;
            if (!int.TryParse(EmpIDTB.Text, out empId))
            {
                NumericIndicator.BackColor = Color.Red;
                NumericIndicator.Text = "Invalid Input";
                NumericIndicator.Visible = true;
                NumericIndicator.Invalidate();
            }

            else if (EmpIDTB.TextLength == 7)
            {
                NumericIndicator.BackColor = Color.Green;
                NumericIndicator.Text = "Checking...";
                NumericIndicator.Visible = true; NumericIndicator.Invalidate();





                string empName = await GetEmpNameByIdAsync(empId);
                if (string.IsNullOrEmpty(empName))
                {
                    EmpNameTB.Text = "Not Found Username";
                    NumericIndicator.BackColor = Color.Red;
                    NumericIndicator.Text = "Not Found";
                    NumericIndicator.Visible = true; NumericIndicator.Invalidate();
                }
                else
                {
                    EmpNameTB.Text = empName;
                    NumericIndicator.BackColor = Color.Green;
                    NumericIndicator.Text = "Found";
                    NumericIndicator.Visible = true; NumericIndicator.Invalidate();

                }



            }
            else
            {
                NumericIndicator.Visible = false;
                EmpNameTB.Text = "";
            }
        }
        //Try finding existing empID
        private void EmpIDTB_TextChanged_1(object sender, EventArgs e)
        {
            CheckEMPID();
        }

        private async Task<string> GetEmpNameByIdAsync(int empId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                await connection.OpenAsync(); // Open the connection asynchronously

                using (OleDbCommand command = new OleDbCommand("SELECT EMPName FROM EmployeeTB WHERE EmpID = @EmpId", connection))
                {
                    command.Parameters.AddWithValue("@EmpId", empId);
                    object result = await command.ExecuteScalarAsync();
                    if (result != null && result != DBNull.Value)
                    {
                      
                        return result.ToString();
                    }
                    else
                    {
                        return null; // EMPID not found
                    }
                }
            }
        }
        private async Task<bool> DoesAlreadyExists(int empId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                await connection.OpenAsync(); // Open the connection asynchronously

                using (OleDbCommand command = new OleDbCommand("SELECT UserName FROM UserList WHERE UserID = @EmpId", connection))
                {
                    command.Parameters.AddWithValue("@EmpId", empId);
                    object result = await command.ExecuteScalarAsync();
                    if (result != null && result != DBNull.Value)
                    {
                        return true;
                    }
                    else
                    {
                        return false; // EMPID not found
                    }
                }
            }
        }
        protected async Task<bool?> IsAdmin(int empId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                await connection.OpenAsync(); // Open the connection asynchronously

                using (OleDbCommand command = new OleDbCommand("SELECT IsAdmin FROM UserList WHERE UserID = @EmpId", connection))
                {
                    command.Parameters.AddWithValue("@EmpId", empId);
                    object result = await command.ExecuteScalarAsync();
                    if (result != null && result != DBNull.Value)
                    {
                        // Convert the result to a boolean
                        if (bool.TryParse(result.ToString(), out bool isAdmin))
                        {
                            return isAdmin;
                        }
                        else
                        {
                            // Handle conversion failure
                            return null;
                        }
                    }
                    else
                    {
                        return null; // EMPID not found
                    }
                }
            }
        }

        public async Task<bool> LoginIntoDatabase()
        {
            OleDbConnection conobj = new OleDbConnection(connectionString);

            await conobj.OpenAsync();

            string insertquery;

            bool admin = false;
            OleDbCommand cmd = new OleDbCommand($"SELECT Designation FROM EmployeeTB WHERE EmpID = {EmpIDTB.Text}", conobj);
            Properties.Settings.Default.userid=Int32.Parse(EmpIDTB.Text);

            object desg = await cmd.ExecuteScalarAsync();
            if (desg != null)
            {
                if (Convert.ToString(desg) == "CEO")
                {
                    admin = true;
                    insertquery = $"INSERT INTO UserList (UserID, UserName, Pwd, Email, IsAdmin) VALUES ({EmpIDTB.Text}, '{UnameTB.Text}', '{PwdTB.Text}', '{EmailTB.Text}', true)";
                }
                else
                {
                    admin = false;
                    insertquery = $"INSERT INTO UserList (UserID, UserName, Pwd, Email, IsAdmin) VALUES ({EmpIDTB.Text}, '{UnameTB.Text}', '{PwdTB.Text}', '{EmailTB.Text}', false)";
                }

                cmd.CommandText = insertquery;
              int rowsAffected = await cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Rows affected: " + rowsAffected);

                Properties.Settings.Default.IsAdmin = admin;
                Properties.Settings.Default.Save();

                return true;
            }
            else
            {
                return false;
            }
        }



        private void RememberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberMe = RememberCheckBox.Checked;
            Properties.Settings.Default.Save();
        }
        //This is register button
        private async void LoginBut_Click(object sender, EventArgs e)
        {  //Empty Fields Error Showing
            bool AllFields = false;
            int empid; int.TryParse(EmpIDTB.Text, out empid);
          if(!String.IsNullOrWhiteSpace (EmpIDTB.Text)&&!String.IsNullOrWhiteSpace(UnameTB.Text)&&!String.IsNullOrWhiteSpace(PwdTB.Text ))
        {
                AllFields = true;
            
         }
            if (AllFields) {
                if (await DoesAlreadyExists(empid))
                {
                    MessageBox.Show("User Already Exists Cannot Register Again", "Try Changing ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {



                    // Pushing Code
                    bool ispushed = await LoginIntoDatabase();
                    if (ispushed)
                    {

                        LoginIndicator.Text = "Login Success";
                        LoginIndicator.BackColor = Color.Green;
                        LoginIndicator.Visible = true;
                     
                     
                        MainMenu mainMenu = new MainMenu();
                        this.Hide();
                        mainMenu.Show();
                    }
                    else
                    {
                        LoginIndicator.Text = "Login Failed";
                        LoginIndicator.BackColor = Color.Red;
                        LoginIndicator.Visible = true;
                    }
                }
            } }
        //Actual login button only check uname and pwd
        private void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmpIDTB.Text) || string.IsNullOrWhiteSpace(UnameTB.Text) || string.IsNullOrWhiteSpace(PwdTB.Text))
            {
                // Display an error message with an error icon to the user
                MessageBox.Show("Please fill in EmpID , Username and Password fields before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PwdTB.Text.Length < 8) {
                MessageBox.Show("Enter 8 characters of password","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                //Pushing To Database Code
                using (OleDbConnection conobj = new OleDbConnection(connectionString))
                {
                    conobj.Open();
                    string selectquery = "SELECT COUNT(*) FROM UserList WHERE UserName = @Username AND Pwd = @Password AND UserID=@EmpID";
                    using (OleDbCommand command = new OleDbCommand(selectquery, conobj))
                    {
                        {
                            command.Parameters.AddWithValue("@Username", UnameTB.Text);
                            command.Parameters.AddWithValue("@Password", PwdTB.Text);
                            command.Parameters.AddWithValue("@EmpID", EmpIDTB.Text);

                            int count = 0;
                            count = (int)command.ExecuteScalar();
                            if (count > 0)
                            {
                                LoginIndicator.Text = "Login Success";
                                LoginIndicator.BackColor = Color.Green;
                                LoginIndicator.Visible = true;
                                MainMenu mm = new MainMenu();
                                this.Hide();

                                mm.Show();
                               
                            }
                            else MessageBox.Show("Login Failed\nTry Changing username And Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                    }
                }
            }
        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            EmailIndi.Visible = !EmailTB.Text.Contains("@");
            

            
        }
    }
}

