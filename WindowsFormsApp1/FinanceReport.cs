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
    public partial class FinanceReport : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
    
        string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Chaitanya\Documents\Visual Studio 2022\DataSources\NGODB.accdb""";
        public FinanceReport()
        {
            DataSet DS=new DataSet();

        InitializeComponent();
            connection = new OleDbConnection(constr);
            connection.Open();
            adapter = new OleDbDataAdapter("SELECT * FROM FinancialTB Order by DateOfEntry", connection);
            adapter.Fill(DS,"FinancialTB");
            connection.Close();
            int totinc = DS.Tables[0].AsEnumerable().Sum(Row => Row.Field<int>("Income"));
            int totexp = DS.Tables[0].AsEnumerable().Sum(Row => Row.Field<int>("Expense"));
            int balance = totinc - totexp;


            chart1.DataSource= DS.Tables[0];
            enxpensechart.DataSource = DS.Tables[0];
            pie.DataSource = DS.Tables[0];
            barchart.DataSource = DS.Tables[0];
            chart1.Series[0].XValueMember = "DateOfEntry";
            chart1.Series[0].YValueMembers = "Income";
            barchart.Series[0].Name = "Incomes";
            barchart.Series[1].Name = "Expense";
           barchart.Series[0].XValueMember = "Notes";
           barchart.Series[0].YValueMembers = "Income";

            barchart.Series[1].XValueMember = "Notes";
            barchart.Series[1].YValueMembers = "Expense";

            enxpensechart.Series[0].XValueMember = "DateOfEntry";
            enxpensechart.Series[0].YValueMembers = "Expense";
            pie.Series[0].Name = "PIE Chart";
            pie.Series[0].Points.AddXY($"Income :Rs.{totinc}", totinc);
            pie.Series[0].Points.AddXY($"Expenses :Rs.{totexp}", totexp);
            pie.Series[0].Points.AddXY($"Balance :Rs.{balance}", balance);










        }
    }
}
