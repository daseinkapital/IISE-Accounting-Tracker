using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Accounting_Tracker
{
    public partial class ViewEntriesForm : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("DataSource=LedgerTracking.sqlite; Version=3"); //establish database connection

        public ViewEntriesForm()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            Home.Show();
            Home.Activate();
            Close();
        }

        private void FiscalYearDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            EventLabel.Visible = true; //Unhide additional data fields
            EventDropdown.Visible = true;
            string query = "SELECT * FROM Ledger WHERE fiscal_yr = @param1";
            SQLiteCommand Populate = new SQLiteCommand(query, m_dbConnection);
            Populate.CommandText = query;

        }
    }
}
