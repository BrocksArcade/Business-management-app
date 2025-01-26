using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DashBoardForm : Form
    {
        public event EventHandler OpenNewFormRequested;
        public DashBoardForm()
        {
            InitializeComponent();
           
        }

        private void DonorManagementForm_Click(object sender, EventArgs e)
        {
           
                OpenNewFormRequested.Invoke(sender, e);
            
           
        }

        private void DonorManagementForm_Click_1(object sender, EventArgs e)
        {
            OpenNewFormRequested.Invoke(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenNewFormRequested.Invoke(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenNewFormRequested.Invoke(sender, e);
        }
    }
}
