namespace Accounting_Tracker
{
    partial class LedgerCSVUpload
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
            this.FileUploadLabel = new System.Windows.Forms.Label();
            this.CSVFileName = new System.Windows.Forms.TextBox();
            this.FileChooser = new System.Windows.Forms.Button();
            this.OldNewQuestion = new System.Windows.Forms.Label();
            this.BaseRadio = new System.Windows.Forms.RadioButton();
            this.AddingRadio = new System.Windows.Forms.RadioButton();
            this.OldNewRadioBox = new System.Windows.Forms.GroupBox();
            this.Submit = new System.Windows.Forms.Button();
            this.CheckHere = new System.Windows.Forms.DataGridView();
            this.OldNewRadioBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckHere)).BeginInit();
            this.SuspendLayout();
            // 
            // FileUploadLabel
            // 
            this.FileUploadLabel.AutoSize = true;
            this.FileUploadLabel.Location = new System.Drawing.Point(60, 58);
            this.FileUploadLabel.Name = "FileUploadLabel";
            this.FileUploadLabel.Size = new System.Drawing.Size(172, 20);
            this.FileUploadLabel.TabIndex = 0;
            this.FileUploadLabel.Text = "Choose a Ledger CSV:";
            // 
            // CSVFileName
            // 
            this.CSVFileName.Location = new System.Drawing.Point(238, 55);
            this.CSVFileName.Name = "CSVFileName";
            this.CSVFileName.ReadOnly = true;
            this.CSVFileName.Size = new System.Drawing.Size(336, 26);
            this.CSVFileName.TabIndex = 1;
            // 
            // FileChooser
            // 
            this.FileChooser.Location = new System.Drawing.Point(604, 51);
            this.FileChooser.Name = "FileChooser";
            this.FileChooser.Size = new System.Drawing.Size(163, 40);
            this.FileChooser.TabIndex = 2;
            this.FileChooser.Text = "Choose File";
            this.FileChooser.UseVisualStyleBackColor = true;
            this.FileChooser.Click += new System.EventHandler(this.FileChooser_Click);
            // 
            // OldNewQuestion
            // 
            this.OldNewQuestion.AutoSize = true;
            this.OldNewQuestion.Location = new System.Drawing.Point(6, 22);
            this.OldNewQuestion.Name = "OldNewQuestion";
            this.OldNewQuestion.Size = new System.Drawing.Size(377, 20);
            this.OldNewQuestion.TabIndex = 3;
            this.OldNewQuestion.Text = "Is this the base ledger or adding to previous entries?";
            this.OldNewQuestion.Visible = false;
            // 
            // BaseRadio
            // 
            this.BaseRadio.AutoSize = true;
            this.BaseRadio.Location = new System.Drawing.Point(440, 18);
            this.BaseRadio.Name = "BaseRadio";
            this.BaseRadio.Size = new System.Drawing.Size(71, 24);
            this.BaseRadio.TabIndex = 4;
            this.BaseRadio.TabStop = true;
            this.BaseRadio.Text = "Base";
            this.BaseRadio.UseVisualStyleBackColor = true;
            this.BaseRadio.Visible = false;
            this.BaseRadio.CheckedChanged += new System.EventHandler(this.BaseRadio_CheckedChanged);
            // 
            // AddingRadio
            // 
            this.AddingRadio.AutoSize = true;
            this.AddingRadio.Location = new System.Drawing.Point(541, 18);
            this.AddingRadio.Name = "AddingRadio";
            this.AddingRadio.Size = new System.Drawing.Size(84, 24);
            this.AddingRadio.TabIndex = 5;
            this.AddingRadio.TabStop = true;
            this.AddingRadio.Text = "Adding";
            this.AddingRadio.UseVisualStyleBackColor = true;
            this.AddingRadio.Visible = false;
            this.AddingRadio.CheckedChanged += new System.EventHandler(this.AddingRadio_CheckedChanged);
            // 
            // OldNewRadioBox
            // 
            this.OldNewRadioBox.Controls.Add(this.AddingRadio);
            this.OldNewRadioBox.Controls.Add(this.BaseRadio);
            this.OldNewRadioBox.Controls.Add(this.OldNewQuestion);
            this.OldNewRadioBox.Location = new System.Drawing.Point(63, 128);
            this.OldNewRadioBox.Name = "OldNewRadioBox";
            this.OldNewRadioBox.Size = new System.Drawing.Size(684, 67);
            this.OldNewRadioBox.TabIndex = 6;
            this.OldNewRadioBox.TabStop = false;
            this.OldNewRadioBox.Visible = false;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(550, 359);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(216, 46);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // CheckHere
            // 
            this.CheckHere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckHere.Location = new System.Drawing.Point(795, 11);
            this.CheckHere.Name = "CheckHere";
            this.CheckHere.RowTemplate.Height = 28;
            this.CheckHere.Size = new System.Drawing.Size(965, 487);
            this.CheckHere.TabIndex = 8;
            // 
            // LedgerCSVUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 593);
            this.Controls.Add(this.CheckHere);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.OldNewRadioBox);
            this.Controls.Add(this.FileChooser);
            this.Controls.Add(this.CSVFileName);
            this.Controls.Add(this.FileUploadLabel);
            this.Name = "LedgerCSVUpload";
            this.Text = "Ledger CSV Upload";
            this.OldNewRadioBox.ResumeLayout(false);
            this.OldNewRadioBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckHere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileUploadLabel;
        private System.Windows.Forms.TextBox CSVFileName;
        private System.Windows.Forms.Button FileChooser;
        private System.Windows.Forms.Label OldNewQuestion;
        private System.Windows.Forms.RadioButton BaseRadio;
        private System.Windows.Forms.RadioButton AddingRadio;
        private System.Windows.Forms.GroupBox OldNewRadioBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.DataGridView CheckHere;
    }
}