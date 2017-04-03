namespace Accounting_Tracker
{
    partial class UpdateDataFrm
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
            this.CSVLoadButton = new System.Windows.Forms.Button();
            this.ManualEnter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CSVLoadButton
            // 
            this.CSVLoadButton.Location = new System.Drawing.Point(58, 40);
            this.CSVLoadButton.Name = "CSVLoadButton";
            this.CSVLoadButton.Size = new System.Drawing.Size(286, 81);
            this.CSVLoadButton.TabIndex = 0;
            this.CSVLoadButton.Text = "Load Ledger CSV";
            this.CSVLoadButton.UseVisualStyleBackColor = true;
            this.CSVLoadButton.Click += new System.EventHandler(this.CSVLoadButton_Click);
            // 
            // ManualEnter
            // 
            this.ManualEnter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManualEnter.Location = new System.Drawing.Point(58, 271);
            this.ManualEnter.Name = "ManualEnter";
            this.ManualEnter.Size = new System.Drawing.Size(286, 81);
            this.ManualEnter.TabIndex = 1;
            this.ManualEnter.Text = "Manually Enter Entries";
            this.ManualEnter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(58, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Freedom First Print Screen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UpdateDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ManualEnter);
            this.Controls.Add(this.CSVLoadButton);
            this.Name = "UpdateDataFrm";
            this.Text = "Update Entries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CSVLoadButton;
        private System.Windows.Forms.Button ManualEnter;
        private System.Windows.Forms.Button button1;
    }
}