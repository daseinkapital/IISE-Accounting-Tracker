namespace Accounting_Tracker
{
    partial class HomeForm
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
            this.GenerateReport = new System.Windows.Forms.Button();
            this.UpdateEntries = new System.Windows.Forms.Button();
            this.ViewEntries = new System.Windows.Forms.Button();
            this.SettingHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateReport
            // 
            this.GenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateReport.AutoSize = true;
            this.GenerateReport.Location = new System.Drawing.Point(648, 380);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(400, 97);
            this.GenerateReport.TabIndex = 0;
            this.GenerateReport.Text = "Generate Report";
            this.GenerateReport.UseVisualStyleBackColor = true;
            // 
            // UpdateEntries
            // 
            this.UpdateEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateEntries.AutoSize = true;
            this.UpdateEntries.Location = new System.Drawing.Point(648, 96);
            this.UpdateEntries.Name = "UpdateEntries";
            this.UpdateEntries.Size = new System.Drawing.Size(400, 96);
            this.UpdateEntries.TabIndex = 1;
            this.UpdateEntries.Text = "Update Entries";
            this.UpdateEntries.UseVisualStyleBackColor = true;
            // 
            // ViewEntries
            // 
            this.ViewEntries.AutoSize = true;
            this.ViewEntries.Location = new System.Drawing.Point(71, 96);
            this.ViewEntries.Name = "ViewEntries";
            this.ViewEntries.Size = new System.Drawing.Size(410, 96);
            this.ViewEntries.TabIndex = 2;
            this.ViewEntries.Text = "View Entries";
            this.ViewEntries.UseVisualStyleBackColor = true;
            this.ViewEntries.Click += new System.EventHandler(this.ViewEntries_Click);
            // 
            // SettingHelp
            // 
            this.SettingHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingHelp.AutoSize = true;
            this.SettingHelp.Location = new System.Drawing.Point(71, 380);
            this.SettingHelp.Name = "SettingHelp";
            this.SettingHelp.Size = new System.Drawing.Size(410, 97);
            this.SettingHelp.TabIndex = 3;
            this.SettingHelp.Text = "Settings and Help";
            this.SettingHelp.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 688);
            this.Controls.Add(this.SettingHelp);
            this.Controls.Add(this.ViewEntries);
            this.Controls.Add(this.UpdateEntries);
            this.Controls.Add(this.GenerateReport);
            this.Name = "HomeForm";
            this.Text = "IISE Accounting Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateReport;
        private System.Windows.Forms.Button UpdateEntries;
        private System.Windows.Forms.Button ViewEntries;
        private System.Windows.Forms.Button SettingHelp;
    }
}

