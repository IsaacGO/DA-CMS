using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControlApp.OnPremises.Program;

namespace ControlApp.OnPremises.Forms.Report
{
    public partial class frmReport : MetroFramework.Forms.MetroForm
    {
        
        public frmReport()
        {
            InitializeComponent();
            ShowReport();
             
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.rptViewer.RefreshReport();
            
        }

        public void ShowReport()
        {
            try
            {
                var IdReceipt = MystaticValues.rptSsrs;
                string urlReportServer = "http://tronserver:8282/ReportServer";
                rptViewer.ProcessingMode = ProcessingMode.Remote; // ProcessingMode will be Either Remote or Local
                rptViewer.ServerReport.ReportServerUrl = new Uri(urlReportServer); //Set the ReportServer Url
                rptViewer.ServerReport.ReportPath = "/ControlApp.Report/NewReceipt"; //Passing the Report Path                

                ////Creating an ArrayList for combine the Parameters which will be passed into SSRS Report
                //ArrayList reportParam = new ArrayList();
                //reportParam = reportParam.Add(new ReportParameter (Convert.ToInt32(IdReceipt)));
                List<ReportParameter> param = new List<ReportParameter>();
                param.Add(new ReportParameter("pID_RECEIPT", IdReceipt.ToString()));



                //ReportParameter[] param = new ReportParameter[reportParam.Count];
                //for (int k = 0; k < reportParam.Count; k++)
                //{
                //    param[k] = (ReportParameter)reportParam[k];
                //}
                // pass crendentitilas
                //rptViewer.ServerReport.ReportServerCredentials = 
                //  new ReportServerCredentials("uName", "PassWORD", "doMain");

                //pass parmeters to report
                rptViewer.ServerReport.SetParameters(param); //Set Report Parameters
                rptViewer.ServerReport.Refresh();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
