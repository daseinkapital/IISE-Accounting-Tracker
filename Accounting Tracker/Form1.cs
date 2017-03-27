using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Accounting_Tracker
{
    public partial class HomeForm : Form
    {
        SQLiteConnection m_dbConnection; //establish database connection

        public HomeForm()
        {
            InitializeComponent();
            m_dbConnection = new SQLiteConnection("Data Source=LedgerTracking.sqlite; Version=3"); //Find data source
            m_dbConnection.Open(); //Open connection to the database
            if (File.Exists(@"LedgerTracking.sqlite")) //Check if our database exists
            {
                string query = "SELECT * FROM Ledger";
                SQLiteCommand Populate = new SQLiteCommand(query, m_dbConnection);
                Populate.CommandText = query;

            }
            else
            {
                SQLiteConnection.CreateFile("LedgerTracking.sqlite"); //If the DB doesn't exist we want to create it
            }

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
    }
}
