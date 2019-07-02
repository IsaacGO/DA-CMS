namespace ControlApp.OnPremises.Forms.Report
{
    partial class frmReportDaily
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
            this.rptviewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptviewer
            // 
            this.rptviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptviewer.Location = new System.Drawing.Point(20, 60);
            this.rptviewer.Name = "rptviewer";
            this.rptviewer.Size = new System.Drawing.Size(744, 433);
            this.rptviewer.TabIndex = 0;
            // 
            // frmReportDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 513);
            this.Controls.Add(this.rptviewer);
            this.Name = "frmReportDaily";
            this.Text = "Reporte";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmReportDaily_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptviewer;
    }
}