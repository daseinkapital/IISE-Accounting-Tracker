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
    public partial class UpdateDataFrm : Form
    {
        public UpdateDataFrm()
        {
            InitializeComponent();
        }

        public bool CSVType;

        private void CSVLoadButton_Click(object sender, EventArgs e)
        {
            LedgerCSVUpload frm = new LedgerCSVUpload();
            frm.Show();
            frm.Activate();
        }


    }
}
