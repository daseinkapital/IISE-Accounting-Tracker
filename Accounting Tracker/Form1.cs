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
        SQLiteConnection m_dbConnection = new SQLiteConnection("DataSource=LedgerTracking.sqlite; Version=3"); //establish database connection

        public HomeForm()
        {
            InitializeComponent();
            m_dbConnection.Open(); //Open connection to the database
            if (!File.Exists(@"LedgerTracking.sqlite")) //Check if our database doesn't exists
            {
                SQLiteConnection.CreateFile("LedgerTracking.sqlite"); //If the DB doesn't exist we want to create it
                string CreateTableQuery = "CREATE TABLE Ledger (TransactionNum INTEGER PRIMARY KEY AUTOINCREMENT, fiscal_yr VARCHAR(9), event VARCHAR(250), category VARCHAR(40), price REAL, purpose TEXT, CheckNo INT(4), Date VARCHAR(20))";
                SQLiteCommand CreateTable = new SQLiteCommand(CreateTableQuery, m_dbConnection);
                CreateTable.ExecuteNonQuery(); //creates the table after making the database
            };
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
