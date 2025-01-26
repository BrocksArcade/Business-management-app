using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ComponentFactory.Krypton.Toolkit;

namespace WindowsFormsApp1
{
    public partial class MainMenu : KryptonForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void OpenNewFormEventHandler(object sender, EventArgs e)
        {
            // Create a new instance of the form you want to open within the panel
            Button B = (Button)sender;
            if (Convert.ToString(B.Tag) == "DashBoard")
            {

                DonorManagement donorManagement = new DonorManagement();
                donorManagement.Dock = DockStyle.Fill;
                donorManagement.TopLevel = false;
                AddForm(donorManagement);
            }
            else if (Convert.ToString(B.Tag) == "Ben")
            {
                BeneficiaryForm beneficiaryForm = new BeneficiaryForm();
                beneficiaryForm.Dock = DockStyle.Fill;
                beneficiaryForm.TopLevel = false;
                AddForm(beneficiaryForm);
            }
            else if (Convert.ToString(B.Tag) == "Event")
            {
                EventManagement eventManagement = new EventManagement();
                eventManagement.Dock = DockStyle.Fill;
                eventManagement.TopLevel = false;
                AddForm(eventManagement);
            }
            else if ((Convert.ToString(B.Tag) == "User"))
            {
                UserManagement userManagement = new UserManagement();
                userManagement.Dock = DockStyle.Fill;
                userManagement.TopLevel = false;
                AddForm(userManagement);
            }
            else if(Convert.ToString(B.Tag)=="Vol")
            {
                Volunteers volunteers = new Volunteers();
                volunteers.Dock = DockStyle.Fill;
                volunteers.TopLevel = false;
                AddForm(volunteers);
            }
            else if((Convert.ToString(B.Tag)=="Finance"))
            {
                FinancialManagement financialManagement = new FinancialManagement();
                financialManagement.Dock = DockStyle.Fill;
                financialManagement.TopLevel = false;
                AddForm(financialManagement);
            }
        }

        public void AddForm(Object form)
        {
            if (mainpanel.Controls.Count > 0)
            {

                mainpanel.Controls.RemoveAt(0);
            }
            Form newform = form as Form;
            newform.TopLevel = false;
            newform.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(newform);
            this.mainpanel.Tag = form;
            newform.Show();

        }

        private void DashBut_Click(object sender, EventArgs e)
        {
            DashBoardForm newform = new DashBoardForm();
            //Event binding here:
            newform.OpenNewFormRequested += OpenNewFormEventHandler;
            //Adding DashBoard
            AddForm(newform);


        }


        private void LogOutBut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Save();
            //I am not able to get SignUPform here
            this.Close();




        }

        private void About_Click(object sender, EventArgs e)
        {
            //TODO : Add credits Made By Chaitanya ^_^ with RTX 3050 and 16Thread cpu
        }

        private void QuitBut_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            crystalreport CS = new crystalreport()
            {
                WindowState = FormWindowState.Maximized,
                TopLevel = true
            };
            this.Hide();
            CS.Show();
            CS.FormClosed += CS_FormClosed;
            
    
        }

        private void CS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
