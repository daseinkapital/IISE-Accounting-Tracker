using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Accounting_Tracker
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void ViewEntries_Click(object sender, EventArgs e) //Button allows you to open the view entries form
        {
            ViewEntriesForm frm = new ViewEntriesForm();
            frm.Show();
            frm.Activate();
            this.Hide(); 
        }

        private void UpdateEntries_Click(object sender, EventArgs e)
        {
            UpdateDataFrm frm = new UpdateDataFrm();
            frm.Show();
            frm.Activate();
            this.Hide();
        }
    }
}
