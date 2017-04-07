using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.IO;

namespace Accounting_Tracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseCheck();
            Application.Run(new HomeForm());
        }

        static void DatabaseCheck()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("DataSource=LedgerTracking.sqlite; Version=3"); //establish database connection
            m_dbConnection.Open(); //Open connection to the database
            if (!File.Exists(@"LedgerTracking.sqlite")) //Check if our database doesn't exists
            {
                SQLiteConnection.CreateFile("LedgerTracking.sqlite"); //If the DB doesn't exist we want to create it
                string CreateLedgerTableQuery = "CREATE TABLE Ledger (TransactionNum INTEGER PRIMARY KEY AUTOINCREMENT, fiscal_yr VARCHAR(9), event VARCHAR(250), price REAL, purpose TEXT, CheckNo INT(4), Date VARCHAR(20))";
                string CreateCategoryTableQuery = "CREATE TABLE Category (event VARCHAR(250), expenditure VARCHAR(100), budget VARCHAR(100));";
                SQLiteCommand CreateLedgerTable = new SQLiteCommand(CreateLedgerTableQuery, m_dbConnection);
                SQLiteCommand CreateCategoryTable = new SQLiteCommand(CreateCategoryTableQuery, m_dbConnection);
                CreateLedgerTable.ExecuteNonQuery(); //creates the table for the ledger
                CreateCategoryTable.ExecuteNonQuery(); //creates the table for the budget/expenditure category
            };


        }
    }
}
