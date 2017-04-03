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
    public partial class LedgerCSVUpload : Form
    {
        public LedgerCSVUpload()
        {
            InitializeComponent();
        }

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
            }
        }
    }
}
