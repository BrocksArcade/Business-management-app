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

    public partial class Volunteers : Form
    {
        private OleDbConnection connection;

        string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Chaitanya\Documents\Visual Studio 2022\DataSources\NGODB.accdb""";
        private int GetAvailableVolunteers()
        {

     
            string query = "SELECT AvailableVolunteers FROM VolunteersTB";


            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Execute the query and retrieve the result
                object result = command.ExecuteScalar();



          
                return Convert.ToInt32(result);

            }

        }
        private int GetAssignedVolunteers()
        {
         
            string query = "SELECT AssignedVolunteer FROM VolunteersTB";


            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Execute the query and retrieve the result
                object result = command.ExecuteScalar();


          
                return Convert.ToInt32(result);

            }
        }
        private int GetTotalVolunteers()
        {
            string query = "SELECT TotalVolunteers FROM VolunteersTB";


            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Execute the query and retrieve the result
                object result = command.ExecuteScalar();

       

                return Convert.ToInt32(result);

            }
        }
        public Volunteers()
        {
            
          

            connection = new OleDbConnection(constr);
            connection.Open();
       
            
                InitializeComponent();
            AvailableV.Text = Convert.ToString(GetAvailableVolunteers());
            AV.Text = Convert.ToString(GetAssignedVolunteers());
            TV.Text = Convert.ToString(GetTotalVolunteers());
            chart1.Series["Piechart"].Points.AddXY("Assigned Volunteers", GetAssignedVolunteers());
            chart1.Series["Piechart"].Points.AddXY("Available Volunteers", GetAvailableVolunteers());
            chart1.Series["Piechart"].Points.AddXY("Total Volunteers", GetTotalVolunteers());
          

        }

      

        private void AddVolUpDown_ValueChanged(object sender, EventArgs e)
        {


            updatedb(true);

            AvailableV.Text = Convert.ToString(GetAvailableVolunteers());
            TV.Text = Convert.ToString(GetTotalVolunteers());
            chart1.Series[0].Points.Clear();
            chart1.Series["Piechart"].Points.AddXY("Assigned Volunteers", GetAssignedVolunteers());
            chart1.Series["Piechart"].Points.AddXY("Available Volunteers", GetAvailableVolunteers());
            chart1.Series["Piechart"].Points.AddXY("Total Volunteers", GetTotalVolunteers());

       




        }
        
  
        private void updatedb(bool add)
        {
            if (add)
            {
                string query = $"UPDATE VolunteersTB SET TotalVolunteers = TotalVolunteers + {AddVolUpDown.Value},AvailableVolunteers=AvailableVolunteers+{AddVolUpDown.Value}";
                using (OleDbCommand command = new OleDbCommand(query, connection)) { command.ExecuteNonQuery(); }
            }
            else 
            {
              
                        string query = $"UPDATE VolunteersTB SET TotalVolunteers = TotalVolunteers - {numericUpDown1.Value},AvailableVolunteers=AvailableVolunteers-{numericUpDown1.Value}";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
                    
                  
               }
            }
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string check = $"SELECT TotalVolunteers FROM VolunteersTB";
            using (OleDbCommand command = new OleDbCommand(check, connection))
            {

                object amt = command.ExecuteScalar();
                if (amt != null && Convert.ToInt32(amt) > 0) { numericUpDown1.Maximum = Convert.ToInt32(amt); }

                updatedb(false);


                AvailableV.Text = Convert.ToString(GetAvailableVolunteers());
                TV.Text = Convert.ToString(GetTotalVolunteers());
                chart1.Series[0].Points.Clear();
                chart1.Series["Piechart"].Points.AddXY("Assigned Volunteers", GetAssignedVolunteers());
                chart1.Series["Piechart"].Points.AddXY("Available Volunteers", GetAvailableVolunteers());
                chart1.Series["Piechart"].Points.AddXY("Total Volunteers", GetTotalVolunteers());
            }
        }
    }
}


