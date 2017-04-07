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
    public partial class LedgerCSVUpload : Form
    {
        public LedgerCSVUpload()
        {
            InitializeComponent();
        }

        public string FileName;

        private void FileChooser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChooseFile = new OpenFileDialog(); //create new instance of open file dialog when button is clicked
            ChooseFile.Filter = "(*.csv)|*.csv"; //only allow them to open CSVs
            ChooseFile.Multiselect = false; //only allow them to open one file

            if (ChooseFile.ShowDialog() == DialogResult.OK) //if everything is successful
            {
                string FileName = ChooseFile.FileName; //assign the FileName to a string
                CSVFileName.Text = FileName; //show the user the selected file path
                OldNewRadioBox.Visible = true; //show additional options
                BaseRadio.Visible = true;
                AddingRadio.Visible = true;
                OldNewQuestion.Visible = true;
            }
        }

        public bool Adding
        {
            get { return AddingRadio.Checked; }
        }

        public bool Base
        {
            get { return BaseRadio.Checked; }
        }

        public static string MostRecentDate(List<string> dateOldData)
        {
            int lastIndex = dateOldData.Count;
            string lastValue = dateOldData[lastIndex - 1];
            return lastValue;
        }

        List<string> listDate = new List<string>();
        List<string> listExpendType = new List<string>();
        List<string> listBudgetCat = new List<string>();
        List<string> listCheckNo = new List<string>();
        List<string> listDescription = new List<string>();
        List<string> listTransaction = new List<string>();
        List<string> listBalance = new List<string>();

        public static DataTable ConvertToDatatable(List<string> listDate, List<string> listExpendType, List<string> listBudgetCat, List<string> listCheckNo, List<string> listDescription, List<string> listTransaction, List<string> listBalance)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Date");
            dt.Columns.Add("Expenditure");
            dt.Columns.Add("Budget");
            dt.Columns.Add("CheckNo");
            dt.Columns.Add("Description");
            dt.Columns.Add("Transaction");
            dt.Columns.Add("Balance");

            int i = 0;
            while (i < listDate.Count)
            {
                var row = dt.NewRow();

                row["Date"] = listDate[i];
                row["Expenditure"] = listExpendType[i];
                row["Budget"] = listBudgetCat[i];
                row["CheckNo"] = listCheckNo[i];
                row["Description"] = listDescription[i];
                row["Transaction"] = listTransaction[i];
                row["Balance"] = listBalance[i];

                dt.Rows.Add(row);
                i++;
            }

            return dt;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("DataSource=LedgerTracking.sqlite; Version=3"); //establish database connection
            m_dbConnection.Open(); //Open connection to the database

            

            using (var fs = File.OpenRead(CSVFileName.Text))
            using (var reader = new StreamReader(fs)) //create the file reader
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listDate.Add(values[1]);
                    listExpendType.Add(values[4]);
                    listBudgetCat.Add(values[5]);
                    listCheckNo.Add(values[6]);
                    listDescription.Add(values[7]);
                    if (values[8] == string.Empty) //Check if the string is empty and if it is, assign the other column to the value in the list
                    {
                        listTransaction.Add(values[9]);
                    }
                    else
                    {
                        listTransaction.Add(values[8]);
                    }
                    listBalance.Add(values[11]);
                }
            }
            var RecentDate = MostRecentDate(listDate); //pull the last date

            DataTable dt = new DataTable();
            dt = ConvertToDatatable(listDate, listExpendType, listBudgetCat, listCheckNo, listDescription, listTransaction, listBalance);
            CheckHere.DataSource = dt;
            CheckHere.Refresh();
        }

        private void BaseRadio_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Visible = true;
        }

        private void AddingRadio_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Visible = true;
        }
    }
}
