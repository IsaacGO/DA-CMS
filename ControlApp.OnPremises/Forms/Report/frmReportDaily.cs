using Microsoft.Reporting.WinForms;
using System;
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
    public partial class frmReportDaily : MetroFramework.Forms.MetroForm
    {
        public frmReportDaily()
        {
            InitializeComponent();
            ShowReport();
        }

        private void frmReportDaily_Load(object sender, EventArgs e)
        {

            this.rptviewer.RefreshReport();
        }

        private void ShowReport()
        {
            try
            {
                var IdUser = MystaticValues.IdSession;
                var IdDateBegin = MystaticValues.rptSsrsDateBegin;
                var IdDateEnd = MystaticValues.rptSsrsDateEnd;
                string urlReportServer = "http://tronserver:8282/ReportServer";
                rptviewer.ProcessingMode = ProcessingMode.Remote; // ProcessingMode will be Either Remote or Local
                rptviewer.ServerReport.ReportServerUrl = new Uri(urlReportServer); //Set the ReportServer Url
                rptviewer.ServerReport.ReportPath = "/ControlApp.Report/DayReportByUser"; //Passing the Report Path                

                ////Creating an ArrayList for combine the Parameters which will be passed into SSRS Report
                //ArrayList reportParam = new ArrayList();
                //reportParam = reportParam.Add(new ReportParameter (Convert.ToInt32(IdReceipt)));
                List<ReportParameter> param = new List<ReportParameter>();
                param.Add(new ReportParameter("pID_BY", IdUser.ToString()));
                param.Add(new ReportParameter("pDATE_BEGIN", IdDateBegin.ToString()));
                param.Add(new ReportParameter("pDATE_END", IdDateEnd.ToString()));


                //ReportParameter[] param = new ReportParameter[reportParam.Count];
                //for (int k = 0; k < reportParam.Count; k++)
                //{
                //    param[k] = (ReportParameter)reportParam[k];
                //}
                // pass crendentitilas
                //rptViewer.ServerReport.ReportServerCredentials = 
                //  new ReportServerCredentials("uName", "PassWORD", "doMain");

                //pass parmeters to report
                rptviewer.ServerReport.SetParameters(param); //Set Report Parameters
                rptviewer.ServerReport.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }

    }
}
