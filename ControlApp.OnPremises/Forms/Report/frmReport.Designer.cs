namespace ControlApp.OnPremises.Forms.Report
{
    partial class frmReport
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
            this.txtidReceipt = new MetroFramework.Controls.MetroTextBox();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // txtidReceipt
            // 
            // 
            // 
            // 
            this.txtidReceipt.CustomButton.Image = null;
            this.txtidReceipt.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtidReceipt.CustomButton.Name = "";
            this.txtidReceipt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtidReceipt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtidReceipt.CustomButton.TabIndex = 1;
            this.txtidReceipt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtidReceipt.CustomButton.UseSelectable = true;
            this.txtidReceipt.CustomButton.Visible = false;
            this.txtidReceipt.Lines = new string[0];
            this.txtidReceipt.Location = new System.Drawing.Point(404, 31);
            this.txtidReceipt.MaxLength = 32767;
            this.txtidReceipt.Name = "txtidReceipt";
            this.txtidReceipt.PasswordChar = '\0';
            this.txtidReceipt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtidReceipt.SelectedText = "";
            this.txtidReceipt.SelectionLength = 0;
            this.txtidReceipt.SelectionStart = 0;
            this.txtidReceipt.ShortcutsEnabled = true;
            this.txtidReceipt.Size = new System.Drawing.Size(75, 23);
            this.txtidReceipt.TabIndex = 2;
            this.txtidReceipt.UseSelectable = true;
            this.txtidReceipt.Visible = false;
            this.txtidReceipt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtidReceipt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.Location = new System.Drawing.Point(20, 60);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ShowParameterPrompts = false;
            this.rptViewer.Size = new System.Drawing.Size(293, 368);
            this.rptViewer.TabIndex = 3;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 448);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.txtidReceipt);
            this.Name = "frmReport";
            this.Text = "Recibo ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroTextBox txtidReceipt;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
    }
}