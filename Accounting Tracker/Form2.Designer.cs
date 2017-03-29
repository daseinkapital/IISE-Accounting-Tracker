namespace Accounting_Tracker
{
    partial class ViewEntriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.Button();
            this.FiscalYearDropdown = new System.Windows.Forms.ComboBox();
            this.FiscalYearLabel = new System.Windows.Forms.Label();
            this.EventDropdown = new System.Windows.Forms.ComboBox();
            this.EventLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 663);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(29, 641);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(364, 41);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Back to Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // FiscalYearDropdown
            // 
            this.FiscalYearDropdown.FormattingEnabled = true;
            this.FiscalYearDropdown.Location = new System.Drawing.Point(154, 41);
            this.FiscalYearDropdown.Name = "FiscalYearDropdown";
            this.FiscalYearDropdown.Size = new System.Drawing.Size(219, 24);
            this.FiscalYearDropdown.TabIndex = 2;
            this.FiscalYearDropdown.Text = "-- Please Select a Fiscal Year --";
            this.FiscalYearDropdown.SelectedValueChanged += new System.EventHandler(this.FiscalYearDropdown_SelectedValueChanged);
            // 
            // FiscalYearLabel
            // 
            this.FiscalYearLabel.AutoSize = true;
            this.FiscalYearLabel.Location = new System.Drawing.Point(46, 44);
            this.FiscalYearLabel.Name = "FiscalYearLabel";
            this.FiscalYearLabel.Size = new System.Drawing.Size(82, 17);
            this.FiscalYearLabel.TabIndex = 3;
            this.FiscalYearLabel.Text = "Fiscal Year:";
            // 
            // EventDropdown
            // 
            this.EventDropdown.FormattingEnabled = true;
            this.EventDropdown.Location = new System.Drawing.Point(154, 102);
            this.EventDropdown.Name = "EventDropdown";
            this.EventDropdown.Size = new System.Drawing.Size(219, 24);
            this.EventDropdown.TabIndex = 4;
            this.EventDropdown.Text = "-- Select an Event --";
            this.EventDropdown.Visible = false;
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Location = new System.Drawing.Point(80, 105);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(48, 17);
            this.EventLabel.TabIndex = 5;
            this.EventLabel.Text = "Event:";
            this.EventLabel.Visible = false;
            // 
            // ViewEntriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 702);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.EventDropdown);
            this.Controls.Add(this.FiscalYearLabel);
            this.Controls.Add(this.FiscalYearDropdown);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewEntriesForm";
            this.Text = "View Entries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.ComboBox FiscalYearDropdown;
        private System.Windows.Forms.Label FiscalYearLabel;
        private System.Windows.Forms.ComboBox EventDropdown;
        private System.Windows.Forms.Label EventLabel;
    }
}