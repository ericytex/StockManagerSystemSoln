namespace StockManagerSystem
{
    partial class SplashMain
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
            this.stkpatientMngtlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stkpatientMngtlabel
            // 
            this.stkpatientMngtlabel.AutoSize = true;
            this.stkpatientMngtlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stkpatientMngtlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.stkpatientMngtlabel.Location = new System.Drawing.Point(38, 39);
            this.stkpatientMngtlabel.Name = "stkpatientMngtlabel";
            this.stkpatientMngtlabel.Size = new System.Drawing.Size(348, 30);
            this.stkpatientMngtlabel.TabIndex = 0;
            this.stkpatientMngtlabel.Text = "Stock & Patient Management Systems";
            this.stkpatientMngtlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stkpatientMngtlabel.Click += new System.EventHandler(this.stkpatientMngtlabel_Click);
            // 
            // SplashMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 201);
            this.Controls.Add(this.stkpatientMngtlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "SplashMain";
            this.Opacity = 0.8D;
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stkpatientMngtlabel;
    }
}

