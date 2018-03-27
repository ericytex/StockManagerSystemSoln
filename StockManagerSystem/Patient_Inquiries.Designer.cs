namespace StockManagerSystem
{
    partial class Patient_Inquiries
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
            this.metroPanelPatientIn = new MetroFramework.Controls.MetroPanel();
            this.metroPanelMenu = new MetroFramework.Controls.MetroPanel();
            this.metroPanelPatientInquiry = new MetroFramework.Controls.MetroPanel();
            this.metroPanelPatientIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelPatientIn
            // 
            this.metroPanelPatientIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanelPatientIn.Controls.Add(this.metroPanelPatientInquiry);
            this.metroPanelPatientIn.Controls.Add(this.metroPanelMenu);
            this.metroPanelPatientIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelPatientIn.HorizontalScrollbarBarColor = true;
            this.metroPanelPatientIn.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelPatientIn.HorizontalScrollbarSize = 10;
            this.metroPanelPatientIn.Location = new System.Drawing.Point(20, 60);
            this.metroPanelPatientIn.Name = "metroPanelPatientIn";
            this.metroPanelPatientIn.Size = new System.Drawing.Size(1241, 533);
            this.metroPanelPatientIn.TabIndex = 0;
            this.metroPanelPatientIn.UseCustomBackColor = true;
            this.metroPanelPatientIn.UseCustomForeColor = true;
            this.metroPanelPatientIn.VerticalScrollbarBarColor = true;
            this.metroPanelPatientIn.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelPatientIn.VerticalScrollbarSize = 10;
            // 
            // metroPanelMenu
            // 
            this.metroPanelMenu.HorizontalScrollbarBarColor = true;
            this.metroPanelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelMenu.HorizontalScrollbarSize = 10;
            this.metroPanelMenu.Location = new System.Drawing.Point(21, 21);
            this.metroPanelMenu.Name = "metroPanelMenu";
            this.metroPanelMenu.Size = new System.Drawing.Size(1202, 86);
            this.metroPanelMenu.TabIndex = 2;
            this.metroPanelMenu.VerticalScrollbarBarColor = true;
            this.metroPanelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelMenu.VerticalScrollbarSize = 10;
            // 
            // metroPanelPatientInquiry
            // 
            this.metroPanelPatientInquiry.HorizontalScrollbarBarColor = true;
            this.metroPanelPatientInquiry.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelPatientInquiry.HorizontalScrollbarSize = 10;
            this.metroPanelPatientInquiry.Location = new System.Drawing.Point(20, 122);
            this.metroPanelPatientInquiry.Name = "metroPanelPatientInquiry";
            this.metroPanelPatientInquiry.Size = new System.Drawing.Size(1202, 392);
            this.metroPanelPatientInquiry.TabIndex = 3;
            this.metroPanelPatientInquiry.VerticalScrollbarBarColor = true;
            this.metroPanelPatientInquiry.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelPatientInquiry.VerticalScrollbarSize = 10;
            // 
            // Patient_Inquiries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1281, 613);
            this.Controls.Add(this.metroPanelPatientIn);
            this.Movable = false;
            this.Name = "Patient_Inquiries";
            this.Resizable = false;
            this.Text = "Patient Inquiries";
            this.metroPanelPatientIn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelPatientIn;
        private MetroFramework.Controls.MetroPanel metroPanelMenu;
        private MetroFramework.Controls.MetroPanel metroPanelPatientInquiry;
    }
}