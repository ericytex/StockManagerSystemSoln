namespace StockManagerSystem
{
    partial class ViewPatients
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSearchForPatient = new System.Windows.Forms.Button();
            this.textBoxSearchForPatient = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewViewPatient = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 45);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonSearchForPatient);
            this.panel4.Controls.Add(this.textBoxSearchForPatient);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 45);
            this.panel4.TabIndex = 0;
            // 
            // buttonSearchForPatient
            // 
            this.buttonSearchForPatient.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSearchForPatient.FlatAppearance.BorderSize = 0;
            this.buttonSearchForPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchForPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchForPatient.ForeColor = System.Drawing.Color.White;
            this.buttonSearchForPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchForPatient.Location = new System.Drawing.Point(374, 6);
            this.buttonSearchForPatient.Name = "buttonSearchForPatient";
            this.buttonSearchForPatient.Size = new System.Drawing.Size(173, 29);
            this.buttonSearchForPatient.TabIndex = 12;
            this.buttonSearchForPatient.Text = "Patient Search";
            this.buttonSearchForPatient.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchForPatient
            // 
            this.textBoxSearchForPatient.Location = new System.Drawing.Point(3, 6);
            this.textBoxSearchForPatient.Name = "textBoxSearchForPatient";
            this.textBoxSearchForPatient.Size = new System.Drawing.Size(349, 29);
            this.textBoxSearchForPatient.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewViewPatient);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 334);
            this.panel3.TabIndex = 4;
            // 
            // dataGridViewViewPatient
            // 
            this.dataGridViewViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewViewPatient.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewViewPatient.Name = "dataGridViewViewPatient";
            this.dataGridViewViewPatient.Size = new System.Drawing.Size(853, 334);
            this.dataGridViewViewPatient.TabIndex = 0;
            // 
            // ViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 459);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewPatients";
            this.Text = "View All Patients";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewViewPatient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxSearchForPatient;
        private System.Windows.Forms.Button buttonSearchForPatient;
    }
}