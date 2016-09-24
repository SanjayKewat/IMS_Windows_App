using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using AMIT_FUNCTIONS;
using System.Data.SqlClient;

namespace IMS
{
    class ReportFunc
    {
        CrystalDecisions.CrystalReports.Engine.ReportDocument rpt;
        CrystalDecisions.Shared.TableLogOnInfo rptTLInfo;  
        CrystalDecisions.Shared.ParameterFields parameters = new CrystalDecisions.Shared.ParameterFields();
        CrystalDecisions.Shared.ParameterField parameter;
        CrystalDecisions.Shared.ParameterDiscreteValue paraValue;
        CrystalDecisions.Shared.ParameterDiscreteValue paraValue2;
        string RptAuthor = "";

        public void ViewReport(CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer, string Reportname, string rsSelectionformula, string paraname, string paravalue, int SendToPrinter, Form frm)
        {
            rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string REPORTSPATH = Application.StartupPath + ConfigurationManager.AppSettings["ShareFolder"];
            rpt.Load((REPORTSPATH + ("\\" + Reportname)));
            rpt.SetParameterValue(paraname, paravalue.ToString());
            //  CrystalDecisions.CrystalReports.Engine.Table tdCurr;

            foreach (CrystalDecisions.CrystalReports.Engine.Table tdCurr in rpt.Database.Tables)
            {
                rptTLInfo = new CrystalDecisions.Shared.TableLogOnInfo();
                rptTLInfo = tdCurr.LogOnInfo;
                // With...
                //SERVERNAME.Password = "SA";
                //dataBaseName.ServerName = "SA";
                rptTLInfo.ConnectionInfo.DatabaseName = "IMS";
                tdCurr.ApplyLogOnInfo(rptTLInfo);
            }
            rpt.SetDatabaseLogon("", "", ".", "IMS");
            rpt.SummaryInfo.ReportAuthor = RptAuthor;
            if ((rsSelectionformula != ""))
            {
                rpt.RecordSelectionFormula = rsSelectionformula;
            }

            if ((SendToPrinter == 1))
            {
                try
                {
                    rpt.PrintToPrinter(1, true, 1, 1);
                }
                catch (Exception ex)
                {
                    //  MsgBox(ex.Message);
                }

            }
            else
            {
                //if (((Para1 == null) 
                //            == false)) {
                //    CrViewer.ParameterFieldInfo = parameters;
                //}

                CrViewer.ReportSource = rpt;
                CrViewer.Refresh();
                if ((frm.Tag != "ALL BILL REPORT"))
                {
                    //    frm.Show();
                    //   SHOW_PLEASE_WAIT(false);
                }

            }


        }

        public void ViewReport(CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer, string Reportname, string rsSelectionformula, string paraname1, string paraname2, string paravalue1, string paravalue2, int SendToPrinter, Form frm)
        {
            rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string REPORTSPATH = Application.StartupPath + ConfigurationManager.AppSettings["ShareFolder"];
            rpt.Load((REPORTSPATH + ("\\" + Reportname)));
            rpt.SetParameterValue(paraname1, paravalue1);
            rpt.SetParameterValue(paraname2, paravalue2);
            //  CrystalDecisions.CrystalReports.Engine.Table tdCurr;

            foreach (CrystalDecisions.CrystalReports.Engine.Table tdCurr in rpt.Database.Tables)
            {
                rptTLInfo = new CrystalDecisions.Shared.TableLogOnInfo();
                rptTLInfo = tdCurr.LogOnInfo;
                // With...
                //SERVERNAME.Password = "SA";
                //dataBaseName.ServerName = "SA";
                rptTLInfo.ConnectionInfo.DatabaseName = "IMS";
                tdCurr.ApplyLogOnInfo(rptTLInfo);
            }
            rpt.SetDatabaseLogon("", "", ".", "IMS");
            rpt.SummaryInfo.ReportAuthor = RptAuthor;
            if ((rsSelectionformula != ""))
            {
                rpt.RecordSelectionFormula = rsSelectionformula;
            }

            if ((SendToPrinter == 1))
            {
                try
                {
                    rpt.PrintToPrinter(1, true, 1, 1);
                }
                catch (Exception ex)
                {
                    //  MsgBox(ex.Message);
                }

            }
            else
            {
                //if (((Para1 == null) 
                //            == false)) {
                //    CrViewer.ParameterFieldInfo = parameters;
                //}

                CrViewer.ReportSource = rpt;
                CrViewer.Refresh();
                if ((frm.Tag != "ALL BILL REPORT"))
                {
                    //    frm.Show();
                    //   SHOW_PLEASE_WAIT(false);
                }

            }


        }

        public void ViewReport(CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer, string Reportname, string rsSelectionformula, string paraname1, string paraname2, string paraname3, string paravalue1, string paravalue2, string paravalue3, int SendToPrinter, Form frm)
        {
            rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string REPORTSPATH = Application.StartupPath + ConfigurationManager.AppSettings["ShareFolder"];
            rpt.Load((REPORTSPATH + ("\\" + Reportname)));
            rpt.SetParameterValue(paraname1, paravalue1);
            rpt.SetParameterValue(paraname2, paravalue2);
            rpt.SetParameterValue(paraname3, paravalue3);
            //  CrystalDecisions.CrystalReports.Engine.Table tdCurr;

            foreach (CrystalDecisions.CrystalReports.Engine.Table tdCurr in rpt.Database.Tables)
            {
                rptTLInfo = new CrystalDecisions.Shared.TableLogOnInfo();
                rptTLInfo = tdCurr.LogOnInfo;
                // With...
                //SERVERNAME.Password = "SA";
                //dataBaseName.ServerName = "SA";
                rptTLInfo.ConnectionInfo.DatabaseName = "IMS";
                tdCurr.ApplyLogOnInfo(rptTLInfo);
            }
            rpt.SetDatabaseLogon("", "", ".", "IMS");
            rpt.SummaryInfo.ReportAuthor = RptAuthor;
            if ((rsSelectionformula != ""))
            {
                rpt.RecordSelectionFormula = rsSelectionformula;
            }

            if ((SendToPrinter == 1))
            {
                try
                {
                    rpt.PrintToPrinter(1, true, 1, 1);
                }
                catch (Exception ex)
                {
                    //  MsgBox(ex.Message);
                }

            }
            else
            {
                //if (((Para1 == null) 
                //            == false)) {
                //    CrViewer.ParameterFieldInfo = parameters;
                //}

                CrViewer.ReportSource = rpt;
                CrViewer.Refresh();
                if ((frm.Tag != "ALL BILL REPORT"))
                {
                    //    frm.Show();
                    //   SHOW_PLEASE_WAIT(false);
                }

            }


        }

        public void ViewReport(CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer, string Reportname, string rsSelectionformula, string paraname1,  string paraname2, string paraname3, string paraname4, string paravalue1, string paravalue2, string paravalue3, string paravalue4, int SendToPrinter, Form frm)
        {
            rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string REPORTSPATH = Application.StartupPath + ConfigurationManager.AppSettings["ShareFolder"];
            rpt.Load((REPORTSPATH + ("\\" + Reportname)));
            rpt.SetParameterValue(paraname1, paravalue1);
            rpt.SetParameterValue(paraname2, paravalue2);
            rpt.SetParameterValue(paraname3, paravalue3);
            rpt.SetParameterValue(paraname4, paravalue4);
            //  CrystalDecisions.CrystalReports.Engine.Table tdCurr;

            foreach (CrystalDecisions.CrystalReports.Engine.Table tdCurr in rpt.Database.Tables)
            {
                rptTLInfo = new CrystalDecisions.Shared.TableLogOnInfo();
                rptTLInfo = tdCurr.LogOnInfo;
                // With...
                //SERVERNAME.Password = "SA";
                //dataBaseName.ServerName = "SA";
                rptTLInfo.ConnectionInfo.DatabaseName = "IMS";
                tdCurr.ApplyLogOnInfo(rptTLInfo);
            }
            rpt.SetDatabaseLogon("", "", ".", "IMS");
            rpt.SummaryInfo.ReportAuthor = RptAuthor;
            if ((rsSelectionformula != ""))
            {
                rpt.RecordSelectionFormula = rsSelectionformula;
            }

            if ((SendToPrinter == 1))
            {
                try
                {
                    rpt.PrintToPrinter(1, true, 1, 1);
                }
                catch (Exception ex)
                {
                    //  MsgBox(ex.Message);
                }

            }
            else
            {
                //if (((Para1 == null) 
                //            == false)) {
                //    CrViewer.ParameterFieldInfo = parameters;
                //}

                CrViewer.ReportSource = rpt;
                CrViewer.Refresh();
                if ((frm.Tag != "ALL BILL REPORT"))
                {
                    //    frm.Show();
                    //   SHOW_PLEASE_WAIT(false);
                }

            }


        }

        public void ViewReport(CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer, string Reportname, string rsSelectionformula, string paraname1,  string paraname2, string paraname3, string paraname4, string paraname5, string paravalue1, string paravalue2, string paravalue3, string paravalue4, string paravalue5, int SendToPrinter, Form frm)
        {
            rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string REPORTSPATH = Application.StartupPath + ConfigurationManager.AppSettings["ShareFolder"];
            rpt.Load((REPORTSPATH + ("\\" + Reportname)));
            rpt.SetParameterValue(paraname1, paravalue1);
            rpt.SetParameterValue(paraname2, paravalue2);
            rpt.SetParameterValue(paraname3, paravalue3);
            rpt.SetParameterValue(paraname4, paravalue4);
            rpt.SetParameterValue(paraname5, paravalue5);
            //  CrystalDecisions.CrystalReports.Engine.Table tdCurr;

            foreach (CrystalDecisions.CrystalReports.Engine.Table tdCurr in rpt.Database.Tables)
            {
                rptTLInfo = new CrystalDecisions.Shared.TableLogOnInfo();
                rptTLInfo = tdCurr.LogOnInfo;
                // With...
                //SERVERNAME.Password = "SA";
                //dataBaseName.ServerName = "SA";
                rptTLInfo.ConnectionInfo.DatabaseName = "IMS";
                tdCurr.ApplyLogOnInfo(rptTLInfo);
            }
            rpt.SetDatabaseLogon("", "", ".", "IMS");
            rpt.SummaryInfo.ReportAuthor = RptAuthor;
            if ((rsSelectionformula != ""))
            {
                rpt.RecordSelectionFormula = rsSelectionformula;
            }

            if ((SendToPrinter == 1))
            {
                try
                {
                    rpt.PrintToPrinter(1, true, 1, 1);
                }
                catch (Exception ex)
                {
                    //  MsgBox(ex.Message);
                }

            }
            else
            {
                //if (((Para1 == null) 
                //            == false)) {
                //    CrViewer.ParameterFieldInfo = parameters;
                //}

                CrViewer.ReportSource = rpt;
                CrViewer.Refresh();
                if ((frm.Tag != "ALL BILL REPORT"))
                {
                    //    frm.Show();
                    //   SHOW_PLEASE_WAIT(false);
                }

            }


        }

        public void ViewReport(CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer, string Reportname, string rsSelectionformula, string paraname1, string paraname2, string paraname3, string paraname4, string paraname5, string paraname6, string paravalue1, string paravalue2, string paravalue3, string paravalue4, string paravalue5, string paravalue6, int SendToPrinter, Form frm)
        {
            rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string REPORTSPATH = Application.StartupPath + ConfigurationManager.AppSettings["ShareFolder"];
            rpt.Load((REPORTSPATH + ("\\" + Reportname)));
            rpt.SetParameterValue(paraname1, paravalue1);
            rpt.SetParameterValue(paraname2, paravalue2);
            rpt.SetParameterValue(paraname3, paravalue3);
            rpt.SetParameterValue(paraname4, paravalue4);
            rpt.SetParameterValue(paraname5, paravalue5);
            rpt.SetParameterValue(paraname6, paravalue6);
            //  CrystalDecisions.CrystalReports.Engine.Table tdCurr;

            foreach (CrystalDecisions.CrystalReports.Engine.Table tdCurr in rpt.Database.Tables)
            {
                rptTLInfo = new CrystalDecisions.Shared.TableLogOnInfo();
                rptTLInfo = tdCurr.LogOnInfo;
                // With...
                //SERVERNAME.Password = "SA";
                //dataBaseName.ServerName = "SA";
                rptTLInfo.ConnectionInfo.DatabaseName = "IMS";
                tdCurr.ApplyLogOnInfo(rptTLInfo);
            }
            rpt.SetDatabaseLogon("", "", ".", "IMS");
            rpt.SummaryInfo.ReportAuthor = RptAuthor;
            if ((rsSelectionformula != ""))
            {
                rpt.RecordSelectionFormula = rsSelectionformula;
            }

            if ((SendToPrinter == 1))
            {
                try
                {
                    rpt.PrintToPrinter(1, true, 1, 1);
                }
                catch (Exception ex)
                {
                    //  MsgBox(ex.Message);
                }

            }
            else
            {
                //if (((Para1 == null) 
                //            == false)) {
                //    CrViewer.ParameterFieldInfo = parameters;
                //}

                CrViewer.ReportSource = rpt;
                CrViewer.Refresh();
                if ((frm.Tag != "ALL BILL REPORT"))
                {
                    //    frm.Show();
                    //   SHOW_PLEASE_WAIT(false);
                }

            }


        }

        public void ViewReport(CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer, string Reportname, string rsSelectionformula, string paraname1, string paraname2, string paraname3, string paraname4, string paraname5, string paraname6, string paraname7, string paravalue1, string paravalue2, string paravalue3, string paravalue4, string paravalue5, string paravalue6, string paravalue7, int SendToPrinter, Form frm)
        {
            rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string REPORTSPATH = Application.StartupPath + ConfigurationManager.AppSettings["ShareFolder"];
            rpt.Load((REPORTSPATH + ("\\" + Reportname)));
            rpt.SetParameterValue(paraname1, paravalue1);
            rpt.SetParameterValue(paraname2, paravalue2);
            rpt.SetParameterValue(paraname3, paravalue3);
            rpt.SetParameterValue(paraname4, paravalue4);
            rpt.SetParameterValue(paraname5, paravalue5);
            rpt.SetParameterValue(paraname6, paravalue6);
            rpt.SetParameterValue(paraname7, paravalue7);
            //  CrystalDecisions.CrystalReports.Engine.Table tdCurr; 

            foreach (CrystalDecisions.CrystalReports.Engine.Table tdCurr in rpt.Database.Tables)
            {
                rptTLInfo = new CrystalDecisions.Shared.TableLogOnInfo();
                rptTLInfo = tdCurr.LogOnInfo;
                // With...
                //SERVERNAME.Password = "SA";
                //dataBaseName.ServerName = "SA";
                rptTLInfo.ConnectionInfo.DatabaseName = "IMS";
                tdCurr.ApplyLogOnInfo(rptTLInfo);
            }
            rpt.SetDatabaseLogon("", "", ".", "IMS");
            rpt.SummaryInfo.ReportAuthor = RptAuthor;
            if ((rsSelectionformula != ""))
            {
                rpt.RecordSelectionFormula = rsSelectionformula;
            }

            if ((SendToPrinter == 1))
            {
                try
                {
                    rpt.PrintToPrinter(1, true, 1, 1);
                }
                catch (Exception ex)
                {
                    //  MsgBox(ex.Message);
                }

            }
            else
            {
                //if (((Para1 == null) 
                //            == false)) {
                //    CrViewer.ParameterFieldInfo = parameters;
                //}

                CrViewer.ReportSource = rpt;
                CrViewer.Refresh();
                if ((frm.Tag != "ALL BILL REPORT"))
                {
                    //    frm.Show();
                    //   SHOW_PLEASE_WAIT(false);
                }

            }


        }
    }
}
