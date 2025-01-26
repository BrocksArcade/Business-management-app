using ComponentFactory.Krypton.Toolkit;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportAppServer.DataDefModel;
using CrystalDecisions.Windows.Forms;
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
    public partial class crystalreport : KryptonForm
    {
        private OleDbConnection connection;
      
        private OleDbDataAdapter dataAdapter;
        string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Chaitanya\Documents\Visual Studio 2022\DataSources\NGODB.accdb""";
        public void Setreport(string reportname, DataTable DT)
        {
            try
            {
                ReportDocument RPT = new ReportDocument();
                RPT.Load(reportname);
                RPT.SetDataSource(DT);
                crystalReportViewer1.ReportSource = RPT;
                crystalReportViewer1.Zoom(170);
               
                crystalReportViewer1.Refresh();
                crystalReportViewer1.Invalidate();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void disablebut(KryptonButton But)
        {
            KryptonButton[] buts = { DonorReport,FinancialReort,VOlreport,eventrepor,BeneficiaryReport};
            foreach (KryptonButton b in buts)
            {
                But.Enabled = false;
                if (b != But)
                {
                    b.Enabled = true;
                }
            }
        }
        private DataTable SetDT(string query)
        { DataTable Dt=new DataTable();
            dataAdapter = new OleDbDataAdapter(query, connection);
            dataAdapter.Fill(Dt);
            return Dt;
        }

        public crystalreport()
        {

            InitializeComponent();
            connection= new OleDbConnection(constr);
            crystalReportViewer1.Invalidate();


        }

        private void BeneficiaryReport_Click(object sender, EventArgs e)
        {
            Setreport("C:\\Users\\Chaitanya\\Documents\\Visual Studio 2022\\WindowsFormsApp1\\Beneficiary.rpt", SetDT("SELECT * FROM BeneficiaryTB"));disablebut((KryptonButton)sender);

        }

        private void DonorReport_Click(object sender, EventArgs e)
        {
            Setreport("C:\\Users\\Chaitanya\\Documents\\Visual Studio 2022\\WindowsFormsApp1\\DonationCRP.rpt", SetDT("SELECT DonorInfo.DonorID, DonorName, DonorAddress, PhoneNo,DonationType, DateOfDonation, DonationAmount FROM DonorInfo,DonationTB WHERE DonorInfo.DonorID=DonationTB.DonorID")); disablebut((KryptonButton)sender);
        }

       

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //Event
            Setreport("C:\\Users\\Chaitanya\\Documents\\Visual Studio 2022\\WindowsFormsApp1\\Events.rpt", SetDT("SELECT * FROM EventTB")); disablebut((KryptonButton)sender);
        }

        private void FinancialReort_Click(object sender, EventArgs e)
        {
            //Finance
            Setreport("C:\\Users\\Chaitanya\\Documents\\Visual Studio 2022\\WindowsFormsApp1\\FinancialReport.rpt", SetDT("SELECT * FROM FinancialTB")); disablebut((KryptonButton)sender);

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            //VOl
            Setreport("C:\\Users\\Chaitanya\\Documents\\Visual Studio 2022\\WindowsFormsApp1\\Volunteer.rpt", SetDT("SELECT * FROM VolunteersTB")); disablebut((KryptonButton)sender);
        }
    }
}
