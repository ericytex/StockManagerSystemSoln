namespace StockManagerSystem
{
    partial class BankingLog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCloseLogBankDetailsForm = new System.Windows.Forms.Label();
            this.lblLogBankingDetails = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtChequeNumber = new System.Windows.Forms.TextBox();
            this.lableChequeNumber = new System.Windows.Forms.Label();
            this.labelBankingDate = new System.Windows.Forms.Label();
            this.txtAmountBanked = new System.Windows.Forms.TextBox();
            this.labelAmountBanked = new System.Windows.Forms.Label();
            this.textBoxOtherNotes = new System.Windows.Forms.TextBox();
            this.labelOtherNotes = new System.Windows.Forms.Label();
            this.labelPersonelIncharge = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ChecqueDetails = new System.Windows.Forms.GroupBox();
            this.comboBoxPersonelIncharge = new System.Windows.Forms.ComboBox();
            this.dateBankingDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSaveCheque = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ChecqueDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.labelCloseLogBankDetailsForm);
            this.panel1.Controls.Add(this.lblLogBankingDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 47);
            this.panel1.TabIndex = 0;
            // 
            // labelCloseLogBankDetailsForm
            // 
            this.labelCloseLogBankDetailsForm.AutoSize = true;
            this.labelCloseLogBankDetailsForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCloseLogBankDetailsForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseLogBankDetailsForm.Location = new System.Drawing.Point(637, 0);
            this.labelCloseLogBankDetailsForm.Name = "labelCloseLogBankDetailsForm";
            this.labelCloseLogBankDetailsForm.Size = new System.Drawing.Size(20, 21);
            this.labelCloseLogBankDetailsForm.TabIndex = 3;
            this.labelCloseLogBankDetailsForm.Text = "X";
            this.labelCloseLogBankDetailsForm.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblLogBankingDetails
            // 
            this.lblLogBankingDetails.AutoSize = true;
            this.lblLogBankingDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLogBankingDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogBankingDetails.Location = new System.Drawing.Point(0, 0);
            this.lblLogBankingDetails.Name = "lblLogBankingDetails";
            this.lblLogBankingDetails.Size = new System.Drawing.Size(130, 21);
            this.lblLogBankingDetails.TabIndex = 2;
            this.lblLogBankingDetails.Text = "Log Bank Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txtChequeNumber);
            this.panel2.Controls.Add(this.lableChequeNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 36);
            this.panel2.TabIndex = 1;
            // 
            // txtChequeNumber
            // 
            this.txtChequeNumber.Location = new System.Drawing.Point(243, 3);
            this.txtChequeNumber.Name = "txtChequeNumber";
            this.txtChequeNumber.Size = new System.Drawing.Size(409, 29);
            this.txtChequeNumber.TabIndex = 1;
            // 
            // lableChequeNumber
            // 
            this.lableChequeNumber.AutoSize = true;
            this.lableChequeNumber.Location = new System.Drawing.Point(120, 9);
            this.lableChequeNumber.Name = "lableChequeNumber";
            this.lableChequeNumber.Size = new System.Drawing.Size(122, 21);
            this.lableChequeNumber.TabIndex = 0;
            this.lableChequeNumber.Text = "Cheque number";
            // 
            // labelBankingDate
            // 
            this.labelBankingDate.AutoSize = true;
            this.labelBankingDate.Location = new System.Drawing.Point(20, 137);
            this.labelBankingDate.Name = "labelBankingDate";
            this.labelBankingDate.Size = new System.Drawing.Size(109, 21);
            this.labelBankingDate.TabIndex = 2;
            this.labelBankingDate.Text = "Banking Date :";
            // 
            // txtAmountBanked
            // 
            this.txtAmountBanked.Location = new System.Drawing.Point(154, 181);
            this.txtAmountBanked.Name = "txtAmountBanked";
            this.txtAmountBanked.Size = new System.Drawing.Size(493, 29);
            this.txtAmountBanked.TabIndex = 3;
            // 
            // labelAmountBanked
            // 
            this.labelAmountBanked.AutoSize = true;
            this.labelAmountBanked.Location = new System.Drawing.Point(20, 184);
            this.labelAmountBanked.Name = "labelAmountBanked";
            this.labelAmountBanked.Size = new System.Drawing.Size(128, 21);
            this.labelAmountBanked.TabIndex = 4;
            this.labelAmountBanked.Text = "Amount Banked :";
            // 
            // textBoxOtherNotes
            // 
            this.textBoxOtherNotes.Location = new System.Drawing.Point(24, 316);
            this.textBoxOtherNotes.Multiline = true;
            this.textBoxOtherNotes.Name = "textBoxOtherNotes";
            this.textBoxOtherNotes.Size = new System.Drawing.Size(621, 122);
            this.textBoxOtherNotes.TabIndex = 7;
            // 
            // labelOtherNotes
            // 
            this.labelOtherNotes.AutoSize = true;
            this.labelOtherNotes.Location = new System.Drawing.Point(24, 282);
            this.labelOtherNotes.Name = "labelOtherNotes";
            this.labelOtherNotes.Size = new System.Drawing.Size(102, 21);
            this.labelOtherNotes.TabIndex = 8;
            this.labelOtherNotes.Text = "Other Notes :";
            // 
            // labelPersonelIncharge
            // 
            this.labelPersonelIncharge.AutoSize = true;
            this.labelPersonelIncharge.Location = new System.Drawing.Point(20, 235);
            this.labelPersonelIncharge.Name = "labelPersonelIncharge";
            this.labelPersonelIncharge.Size = new System.Drawing.Size(140, 21);
            this.labelPersonelIncharge.TabIndex = 6;
            this.labelPersonelIncharge.Text = "Personel Incharge :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(41, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(219, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save Cheque";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ChecqueDetails
            // 
            this.ChecqueDetails.Controls.Add(this.comboBoxPersonelIncharge);
            this.ChecqueDetails.Controls.Add(this.dateBankingDate);
            this.ChecqueDetails.Controls.Add(this.panel3);
            this.ChecqueDetails.Controls.Add(this.button2);
            this.ChecqueDetails.Controls.Add(this.button1);
            this.ChecqueDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChecqueDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChecqueDetails.Location = new System.Drawing.Point(0, 0);
            this.ChecqueDetails.Name = "ChecqueDetails";
            this.ChecqueDetails.Size = new System.Drawing.Size(657, 565);
            this.ChecqueDetails.TabIndex = 9;
            this.ChecqueDetails.TabStop = false;
            this.ChecqueDetails.Text = "Cheque Details";
            // 
            // comboBoxPersonelIncharge
            // 
            this.comboBoxPersonelIncharge.FormattingEnabled = true;
            this.comboBoxPersonelIncharge.Location = new System.Drawing.Point(166, 234);
            this.comboBoxPersonelIncharge.Name = "comboBoxPersonelIncharge";
            this.comboBoxPersonelIncharge.Size = new System.Drawing.Size(481, 29);
            this.comboBoxPersonelIncharge.TabIndex = 4;
            // 
            // dateBankingDate
            // 
            this.dateBankingDate.Location = new System.Drawing.Point(135, 137);
            this.dateBankingDate.Name = "dateBankingDate";
            this.dateBankingDate.Size = new System.Drawing.Size(512, 29);
            this.dateBankingDate.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.buttonSaveCheque);
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Location = new System.Drawing.Point(24, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 63);
            this.panel3.TabIndex = 2;
            // 
            // buttonSaveCheque
            // 
            this.buttonSaveCheque.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSaveCheque.FlatAppearance.BorderSize = 0;
            this.buttonSaveCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveCheque.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveCheque.ForeColor = System.Drawing.Color.White;
            this.buttonSaveCheque.Location = new System.Drawing.Point(414, 22);
            this.buttonSaveCheque.Name = "buttonSaveCheque";
            this.buttonSaveCheque.Size = new System.Drawing.Size(154, 38);
            this.buttonSaveCheque.TabIndex = 1;
            this.buttonSaveCheque.Text = "Save Cheque";
            this.buttonSaveCheque.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Silver;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(64, 22);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(154, 38);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // BankingLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 565);
            this.Controls.Add(this.textBoxOtherNotes);
            this.Controls.Add(this.labelOtherNotes);
            this.Controls.Add(this.labelPersonelIncharge);
            this.Controls.Add(this.txtAmountBanked);
            this.Controls.Add(this.labelAmountBanked);
            this.Controls.Add(this.labelBankingDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChecqueDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BankingLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankingLog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ChecqueDetails.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCloseLogBankDetailsForm;
        private System.Windows.Forms.Label lblLogBankingDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtChequeNumber;
        private System.Windows.Forms.Label lableChequeNumber;
        private System.Windows.Forms.Label labelBankingDate;
        private System.Windows.Forms.TextBox txtAmountBanked;
        private System.Windows.Forms.Label labelAmountBanked;
        private System.Windows.Forms.TextBox textBoxOtherNotes;
        private System.Windows.Forms.Label labelOtherNotes;
        private System.Windows.Forms.Label labelPersonelIncharge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox ChecqueDetails;
        private System.Windows.Forms.Button buttonSaveCheque;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateBankingDate;
        private System.Windows.Forms.ComboBox comboBoxPersonelIncharge;
    }
}