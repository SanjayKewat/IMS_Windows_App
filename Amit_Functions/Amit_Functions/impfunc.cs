using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
//using WIALib;

namespace AMIT_FUNCTIONS
{
    public class impfunc
    {
        public static SqlConnection cnn = new SqlConnection("Server=.;uid=sa;Database=pubs");

        public static SqlConnection cnn1 = new SqlConnection("Server=.;uid=sa;Database=pubs");

        public string _itemid = "1";

        public static string _servername;

        public static SqlCommand _Command = new SqlCommand();

        public static SqlDataAdapter _Adapter = new SqlDataAdapter();

        public static DataSet _DATASET = new DataSet();

        public static DataSet _DS = new DataSet();

        public static SqlDataReader _DR;

        public static SqlTransaction _TR;

        public static DataTable _DTABLE;

        public static DataView _DV;

        public static DataTable _TABLE;

        public static ListViewItem _LVITEM;

        public static bool _STATUS;

        public static double _TEMPQTY;

        public static double _TEMPCURRSTOCK;

        public static double _CURRBAL;

        public static long _ID;

        public static int _PURCHASEORDERID;

        public static int _SALEORDERID;

        public static int _PURCHASEMASTERID;

        public static int _PURCHASERETURNID;

        public static int _PACKINGPURCHASEID;

        public static int _PACKINGRETURNID;

        public static int _BILLNO;

        public static int _STOCKOUTMASTERID;

        public static int _COMPANYID;

        public static int _LEDGERID;

        public static int _FINISHGOODID;

        public static int _HEADID;

        public static int _PACKINGID;

        public static int _ROLLNO;

        public static int _ADMNNO;

        public static int _LOGINID;

        public static int _FYEARID;

        public static int _STUDENTID;

        public static int _CLASSID;

        public static int _SECTIONID;

        public static string dataBaseName;

        public static string _DATABASENAME;

        public static string _PURCHASEORDERNO;

        public static string _SALEORDERNO;

        public static string _RPTSTRING;

        public static string _MSGRESULT;

        public static string _USERTYPE;

        public static string _QRY;

        public static string _USERNAME;

        public static string _IMGPATH = "";

        public static string _INVOICENO;

        public static string _FYEAR;

        public static DateTime _BILLDATE;

        public static DateTime _REPORTDATE;

        public static DateTime _FROMDATE;

        public static DateTime _TODATE;

        public static DateTime _INVOICEDATE;

        public static DateTime _PURCHASEDATE;

        public static DateTime _FYEARFROMDATE;

        public static DateTime _FYEARTODATE;

        public static ErrorProvider ErpMsg = new ErrorProvider();

        public static string imageFileName;

        public static ReportDocument rpt;

        public static TableLogOnInfo rptTLInfo;

        public static string[] ArrParameters;

        public static string[] ArrParaInfo;

        public static object SetParaValue;

        public static ParameterFields Parameters;

        public static ParameterField ParameterInfo;

        public static ParameterDiscreteValue ParaValue;

        public static int i;

        public static int j;

        public static PrintDialog PrintDial = new PrintDialog();

        public static PrintDocument PrintDoc = new PrintDocument();

        public static ParameterField parameter;

        public static Type typ;

        public static string[] strArr;

        public static string RptAuthor = "";

        public static int _TRVNODE1;

        public static int _TRVNODE2;

        public static int _TRVNODE3;

        public static int _TRVNODE4;

        public static string[] _TRVNODE1_STRARR;

        public static string[] _TRVNODE2_STRARR;

        public static string[] _TRVNODE3_STRARR;

        public static string[] _TRVNODE4_STRARR;

        public static int[] _TRVNODE1_INTARR;

        public static int[] _TRVNODE2_INTARR;

        public static int[] _TRVNODE3_INTARR;

        public static int[] _TRVNODE4_INTARR;

        public static TreeNode _TRVNODE;

        public static void SET_CONNECTIONSTRING(string SERVER_NAME, string DATABASE)
        {
            try
            {
                impfunc.cnn.ConnectionString = string.Concat(new string[]
				{
					"workstation id=",
					SERVER_NAME,
					";packet size=4096;integrated security=SSPI;data source=",
					SERVER_NAME,
					";persist security info=False;initial catalog='",
					DATABASE,
					"'"
				});
               // impfunc.cnn.ConnectionString = "Server=.;uid=sa;Database=Pubs";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SET_CONNECTIONSTRING(SqlConnection con, string SERVER_NAME, string DATABASE)
        {
            try
            {
                con.ConnectionString = string.Concat(new string[]
				{
					"workstation id=",
					SERVER_NAME,
					";packet size=4096;integrated security=SSPI;data source=",
					SERVER_NAME,
					";persist security info=False;initial catalog='",
					DATABASE,
					"'"
				});
                impfunc.cnn.ConnectionString = "Server=.;uid=sa;Database=Pubs";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SET_CONNECTIONSTRING(string SERVER_NAME, string DATABASE, string USERNAME, string PASSWORD)
        {
            try
            {
                impfunc.cnn.ConnectionString = string.Concat(new string[]
				{
					"server=",
					SERVER_NAME,
					";uid='",
					USERNAME,
					"';pwd='",
					PASSWORD,
					"';Connect Timeout=9999;database='",
					DATABASE,
					"'"
				});
                impfunc.cnn.ConnectionString = "Server=.;uid=sa;Database=Pubs";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SET_CONNECTIONSTRING(SqlConnection con, string SERVER_NAME, string DATABASE, string USERNAME, string PASSWORD)
        {
            try
            {
                con.ConnectionString = string.Concat(new string[]
				{
					"server=",
					SERVER_NAME,
					";uid='",
					USERNAME,
					"';pwd='",
					PASSWORD,
					"';Connect Timeout=9999;database='",
					DATABASE,
					"'"
				});
                impfunc.cnn.ConnectionString = "Server=.;uid=sa;Database=Pubs";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void OPENCONNECTION()
        {
            if (impfunc.cnn.State == ConnectionState.Closed)
            {
                impfunc.cnn.Open();
            }
        }

        public static void OPENCONNECTION(SqlConnection con)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void CLOSECONNECTION()
        {
            if (impfunc.cnn.State == ConnectionState.Open)
            {
                impfunc.cnn.Close();
            }
        }

        public static void CLOSECONNECTION(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public static string GETSERVERNAME()
        {
            if (impfunc.cnn1.State == null)
            {
                impfunc.cnn1.Open();
            }
            try
            {
                impfunc._Command = new SqlCommand("select @@Servername as servername", impfunc.cnn1);
                impfunc._servername = Convert.ToString(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            impfunc.cnn1.Close();
            return impfunc._servername;
        }

        //public static void CHECK_NUMERIC_WITHOUT_DOT(KeyPressEventArgs e)
        //{
        //    if (e.get_KeyChar() != '\r' && !char.IsDigit(e.get_KeyChar()) && e.get_KeyChar() != '\b')
        //    {
        //        e.set_Handled(true);
        //    }
        //}

        public static void Remove_Child(Form frm)
        {
            frm.Close();

            //If tbContainer.TabCount = 0 Then
            //    Mainform.SET_VISIBILITY_FOR_TAB(True)
            //    Mainform.SET_CONTROLS()
            //Else
            //    tbContainer.SelectedIndex = tbContainer.TabPages.Count - 1
            //End If
        }

        public static void CHECK_NUMERIC_VALUE(TextBox txtTextBox, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        //public static void CHECK_NUMERIC_WITHOUT_DOT(KeyPressEventArgs e, bool IsAcceptNegative)
        //{
        //    if (IsAcceptNegative)
        //    {
        //        if (e.get_KeyChar() != '\r' && !char.IsDigit(e.get_KeyChar()) && e.get_KeyChar() != '\b' && e.get_KeyChar() != '-')
        //        {
        //            e.set_Handled(true);
        //        }
        //    }
        //    else if (e.get_KeyChar() != '\r' && !char.IsDigit(e.get_KeyChar()) && e.get_KeyChar() != '\b')
        //    {
        //        e.set_Handled(true);
        //    }
        //}

        public static void CHECK_NUMERIC_WITH_DOT(TextBox txtTextBox, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
&& !char.IsDigit(e.KeyChar)
&& e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (txtTextBox as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        //public static void CHECK_NUMERIC_WITH_DOT(TextBox txtTextBox, KeyPressEventArgs e, bool IsAcceptNegative)
        //{
        //    if (IsAcceptNegative)
        //    {
        //        if (e.get_KeyChar() != '\r')
        //        {
        //            if (!char.IsDigit(e.get_KeyChar()) && e.get_KeyChar() != '.' && e.get_KeyChar() != '\b' && e.get_KeyChar() != '-')
        //            {
        //                e.set_Handled(true);
        //            }
        //            else if (e.get_KeyChar() == '.')
        //            {
        //                int num = txtTextBox.get_Text().IndexOf(".");
        //                if (num > 0)
        //                {
        //                    e.set_Handled(true);
        //                }
        //            }
        //        }
        //    }
        //    else if (e.get_KeyChar() != '\r')
        //    {
        //        if (!char.IsDigit(e.get_KeyChar()) && e.get_KeyChar() != '.' && e.get_KeyChar() != '\b')
        //        {
        //            e.set_Handled(true);
        //        }
        //        else if (e.get_KeyChar() == '.')
        //        {
        //            int num2 = txtTextBox.get_Text().IndexOf(".");
        //            if (num2 > 0)
        //            {
        //                e.set_Handled(true);
        //            }
        //        }
        //    }
        //}

        public static void CHECK_CHARACTER(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r' && !char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled=true;
            }
        }

        //public static string TEST(string strTemp)
        //{
        //    string text = "";
        //    for (int i = 0; i < Convert.ToInt32(strTemp.get_Length()) - 1; i++)
        //    {
        //        for (int j = 0; j < strTemp.get_Length(); j++)
        //        {
        //            char c = strTemp.get_Chars(j);
        //            text += Convert.ToString((int)c + Convert.ToString(i));
        //        }
        //    }
        //    return text;
        //}

        //public static void PROPER_CASE(string inputstring)
        //{
        //    if (inputstring.get_Length() > 49)
        //    {
        //    }
        //    try
        //    {
        //        ArrayList arrayList = new ArrayList();
        //        char[] array = new char[200];
        //        inputstring.Split(array, array.Length);
        //        char[] array2 = array;
        //        for (int i = 0; i < array2.Length; i++)
        //        {
        //            char c = array2[i];
        //            MessageBox.Show(c.ToString());
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        public static bool VALIDATION_BLANK(Control Cont)
        {
            impfunc.ErpMsg.Dispose();
            bool result;
            if (Cont.Text == "")
            {
                ErpMsg.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                MessageBox.Show("REQUIRED FIELD IS EMPTY !!", "INFOTECH CONSULTANTS");
                impfunc.ErpMsg.SetError(Cont, "THIS FIELD CAN'T BE BLANK...");
                Cont.Focus();
                result = true;
            }
            else
            {
                impfunc.ErpMsg.Dispose();
                result = false;
            }
            return result;
        }

        public static bool VALIDATION_VALUE(Control Cont)
        {
            impfunc.ErpMsg.Dispose();
            if (Cont.Text == "")
            {
                Cont.Text = "0";
            }
            bool result;
            if (Convert.ToDouble(Cont.Text) == 0.0)
            {
                ErpMsg.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                MessageBox.Show("FIELD MUST BE GREATER THAN ZERO !!", "INFOTECH CONSULTANTS");
                impfunc.ErpMsg.SetError(Cont, "THIS FIELD MUST BE GREATER THAN ZERO...");
                Cont.Focus();
                result = true;
            }
            else
            {
                impfunc.ErpMsg.Dispose();
                result = false;
            }
            return result;
        }

        public static bool CHECK_IS_NOTHING(ComboBox cboCombo)
        {
            bool result;
            try
            {
                if (cboCombo.SelectedValue == null)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static bool CHECK_IS_NOTHING(ComboBox cboCombo, bool ShowMsg)
        {
            bool result;
            try
            {
                if (cboCombo.SelectedValue == null)
                {
                    if (ShowMsg)
                    {
                        //         impfunc.MSGBOX_INFORMATION("please select correct value !!");
                    }
                    cboCombo.Focus();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static int GENERATE_MAX(SqlConnection Con, string Table, string Field)
        {
            int result = 0;
            try
            {
                impfunc._Command = new SqlCommand("SELECT ISNULL(MAX(" + Field + " ),0)+1 FROM " + Table, Con);
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                result = Convert.ToInt32(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Con.Close();
            return result;
        }

        public static int GENERATE_MAX(SqlConnection Con, SqlTransaction tr, string Table, string Field)
        {
            int result = 0;
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "SELECT ISNULL(MAX(" + Field + " ),0)+1 FROM " + Table;
                result = Convert.ToInt32(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static int GENERATE_MAX(SqlConnection Con, SqlTransaction tr, string Table, string Field, string SqlCondition)
        {
            int result = 0;
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"SELECT ISNULL(MAX(",
					Field,
					" ),0)+1 FROM ",
					Table,
					" WHERE ",
					SqlCondition
				});
                result = Convert.ToInt32(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static int GENERATE_MAX(SqlConnection Con, string Table, string Field, string SqlCondition)
        {
            int result = 0;
            try
            {
                impfunc._Command = new SqlCommand(string.Concat(new string[]
				{
					"SELECT ISNULL(MAX(",
					Field,
					" ),0)+1 FROM ",
					Table,
					" WHERE ",
					SqlCondition
				}), Con);
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                result = Convert.ToInt32(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Con.Close();
            return result;
        }

        public static void ADD_EDIT_FUNCTION(string Command, Button btnAdd, Button btnEdit, Button btnDelete, GroupBox grpContaner)
        {
            if (Command.ToUpper() == "ADD")
            {
                btnAdd.Enabled=true;
                btnAdd.Text= "Save(F8)";
                btnEdit.Enabled = false;
                btnDelete.Enabled=false;
                grpContaner.Enabled=true;
            }
            else if (Command.ToUpper() == "EDIT")
            {
                btnAdd.Enabled=false;
                btnEdit.Enabled=true;
                btnEdit.Text="Update(F6)";
                btnDelete.Enabled=false;
                grpContaner.Enabled=true;
            }
            else if (Command.ToUpper() == "SAVE" || Command.ToUpper() == "UPDATE")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Add(F3)";
                btnEdit.Enabled=true;
                btnEdit.Text="Edit(F4)";
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
            }
            else if (Command.ToUpper() == "RESET")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Add(F3)";
                btnEdit.Enabled=true;
                btnEdit.Text="Edit(F4)";
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
            }
            else if (Command.ToUpper() == "DELETE")
            {
                btnAdd.Enabled=false;
                btnEdit.Enabled=false;
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
            }
        }

        public static void ADD_EDIT_FUNCTION(string Command, Button btnAdd, Button btnEdit, Button btnDelete, GroupBox grpContaner, GroupBox grpContaner1)
        {
            if (Command.ToUpper() == "ADD")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Save(F8)";
                btnEdit.Enabled=false;
                btnDelete.Enabled=false;
                grpContaner.Enabled=true;
                grpContaner1.Enabled=true;
            }
            else if (Command.ToUpper() == "EDIT")
            {
                btnAdd.Enabled=false;
                btnEdit.Enabled=true;
                btnEdit.Text="Update(F6)";
                btnDelete.Enabled=false;
                grpContaner.Enabled=true;
                grpContaner1.Enabled=true;
            }
            else if (Command.ToUpper() == "SAVE" || Command.ToUpper() == "UPDATE")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Add(F3)";
                btnEdit.Enabled=true;
                btnEdit.Text="Edit(F4)";
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
                grpContaner1.Enabled=false;
            }
            else if (Command.ToUpper() == "RESET")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Add(F3)";
                btnEdit.Enabled=true;
                btnEdit.Text="Edit(F4)";
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
                grpContaner1.Enabled=false;
            }
            else if (Command.ToUpper() == "DELETE")
            {
                btnAdd.Enabled=false;
                btnEdit.Enabled=false;
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
                grpContaner1.Enabled=false;
            }
        }

        public static void ADD_EDIT_FUNCTION(string Command, Button btnAdd, Button btnEdit, Button btnDelete, GroupBox grpContaner, GroupBox grpContaner1, GroupBox grpContaner2)
        {
            if (Command.ToUpper() == "ADD")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Save(F8)";
                btnEdit.Enabled=false;
                btnDelete.Enabled=false;
                grpContaner.Enabled=true;
                grpContaner1.Enabled=true;
                grpContaner2.Enabled=true;
            }
            else if (Command.ToUpper() == "EDIT")
            {
                btnAdd.Enabled=false;
                btnEdit.Enabled=true;
                btnEdit.Text="Update(F6)";
                btnDelete.Enabled=false;
                grpContaner.Enabled=true;
                grpContaner1.Enabled=true;
                grpContaner2.Enabled=true;
            }
            else if (Command.ToUpper() == "SAVE" || Command.ToUpper() == "UPDATE")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Add(F3)";
                btnEdit.Enabled=true;
                btnEdit.Text="Edit(F4)";
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
                grpContaner1.Enabled=false;
                grpContaner2.Enabled=false;
            }
            else if (Command.ToUpper() == "RESET")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Add(F3)";
                btnEdit.Enabled=true;
                btnEdit.Text="Edit(F4)";
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
                grpContaner1.Enabled=false;
                grpContaner2.Enabled=false;
            }
            else if (Command.ToUpper() == "DELETE")
            {
                btnAdd.Enabled=false;
                btnEdit.Enabled=false;
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
                grpContaner1.Enabled=false;
                grpContaner2.Enabled=false;
            }
        }

        public static void ADD_EDIT_FUNCTION(string Command, Button btnAdd, Button btnEdit, Button btnDelete, GroupBox grpContaner, GroupBox grpContaner1, GroupBox grpContaner2, GroupBox grpContaner3)
        {
            if (Command.ToUpper() == "ADD")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Save(F8)";
                btnEdit.Enabled=false;
                btnDelete.Enabled=false;
                grpContaner.Enabled=true;
                grpContaner1.Enabled=true;
                grpContaner2.Enabled=true;
                grpContaner3.Enabled=true;
            }
            else if (Command.ToUpper() == "EDIT")
            {
                btnAdd.Enabled=false;
                btnEdit.Enabled=true;
                btnEdit.Text="Update(F6)";
                btnDelete.Enabled=false;
                grpContaner.Enabled=true;
                grpContaner1.Enabled=true;
                grpContaner2.Enabled=true;
                grpContaner3.Enabled=true;
            }
            else if (Command.ToUpper() == "SAVE" || Command.ToUpper() == "UPDATE")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Add(F3)";
                btnEdit.Enabled=true;
                btnEdit.Text="Edit(F4)";
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
                grpContaner1.Enabled=false;
                grpContaner2.Enabled=false;
                grpContaner3.Enabled=false;
            }
            else if (Command.ToUpper() == "RESET")
            {
                btnAdd.Enabled=true;
                btnAdd.Text="Add(F3)";
                btnEdit.Enabled=true;
                btnEdit.Text="Edit(F4)";
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
                grpContaner1.Enabled=false;
                grpContaner2.Enabled=false;
                grpContaner3.Enabled=false;
            }
            else if (Command.ToUpper() == "DELETE")
            {
                btnAdd.Enabled=false;
                btnEdit.Enabled=false;
                btnDelete.Enabled=true;
                grpContaner.Enabled=false;
                grpContaner1.Enabled=false;
                grpContaner2.Enabled=false;
                grpContaner3.Enabled=false;
            }
        }

        public static void NEXTTAB(Form frm, KeyEventArgs e)
        {
            try
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CHECK_SPECIAL_CHR(Form frm, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '!' || e.KeyChar == '@' || e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' || e.KeyChar == '&' || e.KeyChar == '\'' || e.KeyChar == '*' || e.KeyChar == '`' || e.KeyChar == '~')
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool EXISTS_RECORD(SqlConnection con, string TableName, string FieldName, string Condition, bool DisplayMsg)
        {
            int num = 0;
            try
            {
                if (Condition == "")
                {
                    MessageBox.Show("PLEASE MUST ENTER CONDITION !!");
                }
                else
                {
                    impfunc._Command = new SqlCommand(string.Concat(new string[]
					{
						"SELECT COUNT(",
						FieldName,
						") FROM ",
						TableName,
						" WHERE ",
						Condition
					}), con);
                    con.Open();
                    if (Convert.ToInt32(impfunc._Command.ExecuteScalar()) > 0)
                    {
                        num = 1;
                    }
                    else
                    {
                        num = 0;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
            bool result;
            if (num == 1)
            {
                if (DisplayMsg)
                {
                    MessageBox.Show("RECORD ALREADY EXISTS !!", "INFOTECH CONSULTANTS");
                }
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool EXISTS_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string FieldName, string Condition, bool DisplayMsg)
        {
            int num = 0;
            try
            {
                if (Condition == "")
                {
                    MessageBox.Show("PLEASE MUST ENTER CONDITION !!");
                }
                else
                {
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = con;
                    impfunc._Command.Transaction = tr;
                    impfunc._Command.CommandText = string.Concat(new string[]
					{
						"SELECT COUNT(",
						FieldName,
						") FROM ",
						TableName,
						" WHERE ",
						Condition
					});
                    if (Convert.ToInt32(impfunc._Command.ExecuteScalar()) > 0)
                    {
                        num = 1;
                    }
                    else
                    {
                        num = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            bool result;
            if (num == 1)
            {
                if (DisplayMsg)
                {
                    MessageBox.Show("RECORD ALREADY EXISTS !!", "INFOTECH CONSULTANTS");
                }
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        //public static string ENCODE_PASSWORD(string strPass)
        //{
        //    string text = "";
        //    for (int i = 0; i <= Convert.ToInt32(strPass.get_Length() - 1); i++)
        //    {
        //        string text2 = Convert.ToString(strPass.ToCharArray(i, 0));
        //        text2 = Convert.ToString(Strings.Chr(Strings.Asc(text2) + strPass.get_Length() + 110 + i));
        //        text += text2;
        //    }
        //    return text;
        //}

        //public static string DECODE_PASSWORD(string strPass)
        //{
        //    string text = "";
        //    for (int i = 0; i <= Convert.ToInt32(strPass.get_Length() - 1); i++)
        //    {
        //        string text2 = Convert.ToString(strPass.IndexOf(strPass, i, 0));
        //        text2 = Convert.ToString(Strings.Chr(Strings.Asc(text2) - strPass.get_Length() + 110 + i));
        //        text += text2;
        //    }
        //    return text;
        //}

        //public static string CHECK_IF_NULL(object Value)
        //{
        //    return Convert.ToString(Interaction.IIf(Information.IsDBNull(Value), 0, Value));
        //}

        public static void FILL_COMBO(SqlConnection Con, ComboBox cboCombo, string tblTable, string DispMember)
        {
            DataSet dataSet = new DataSet();
            try
            {
                impfunc._Adapter = new SqlDataAdapter("Select * from " + tblTable + " ORDER BY " + DispMember, Con);
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource = dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO(SqlConnection Con, SqlTransaction Tr, ComboBox cboCombo, string tblTable, string DispMember)
        {
            DataSet dataSet = new DataSet();
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection=Con;
                impfunc._Command.Transaction=Tr;
                impfunc._Command.CommandText="Select * from " + tblTable + " ORDER BY " + DispMember;
                impfunc._Adapter = new SqlDataAdapter(impfunc._Command);
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO_ONEFLD_WITH_COND(SqlConnection Con, ComboBox cboCombo, string tblTable, string DispMember, string SqlCondition, string OrderByFld)
        {
            DataSet dataSet = new DataSet();
            try
            {
                if (SqlCondition == "")
                {
                    if (OrderByFld == "")
                    {
                        impfunc._Adapter = new SqlDataAdapter("Select * from " + tblTable + " ORDER BY " + DispMember, Con);
                    }
                    else
                    {
                        impfunc._Adapter = new SqlDataAdapter("Select * from " + tblTable + " ORDER BY " + OrderByFld, Con);
                    }
                }
                else if (OrderByFld == "")
                {
                    impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                    {
                        "Select * from ",
                        tblTable,
                        " WHERE ",
                        SqlCondition,
                        " ORDER BY ",
                        DispMember
                    }), Con);
                }
                else
                {
                    impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                    {
                        "Select * from ",
                        tblTable,
                        " WHERE ",
                        SqlCondition,
                        " ORDER BY ",
                        OrderByFld
                    }), Con);
                }
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO_DISTINCT(SqlConnection Con, ComboBox cboCombo, string tblTable, string DispMember)
        {
            DataSet dataSet = new DataSet();
            try
            {
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "Select DISTINCT ",
                    DispMember,
                    " FROM ",
                    tblTable,
                    " ORDER BY ",
                    DispMember
                }), Con);
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO(SqlConnection Con, ComboBox cboCombo, string tblTable, string DispMember, string ValMember)
        {
            DataSet dataSet = new DataSet();
            try
            {
                impfunc._Adapter = new SqlDataAdapter("Select * from " + tblTable + " ORDER BY " + DispMember, Con);
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
                cboCombo.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO(SqlConnection Con, SqlTransaction Tr, ComboBox cboCombo, string tblTable, string DispMember, string ValMember)
        {
            DataSet dataSet = new DataSet();
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection=Con;
                impfunc._Command.Transaction=Tr;
                impfunc._Command.CommandText="Select * from " + tblTable + " ORDER BY " + DispMember;
                impfunc._Adapter = new SqlDataAdapter(impfunc._Command);
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
                cboCombo.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO_DISTINCT(SqlConnection Con, ComboBox cboCombo, string tblTable, string DispMember, string ValMember)
        {
            DataSet dataSet = new DataSet();
            try
            {
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "Select DISTINCT ",
                    ValMember,
                    ",",
                    DispMember,
                    " from ",
                    tblTable,
                    " ORDER BY ",
                    DispMember
                }), Con);
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
                cboCombo.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO(SqlConnection Con, ComboBox cboCombo, string tblTable, string DispMember, string ValMember, string SqlCondition)
        {
            DataSet dataSet = new DataSet();
            try
            {
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "Select * from ",
                    tblTable,
                    " Where ",
                    SqlCondition,
                    " ORDER BY ",
                    DispMember
                }), Con);
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
                cboCombo.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO(SqlConnection Con, SqlTransaction Tr, ComboBox cboCombo, string tblTable, string DispMember, string ValMember, string SqlCondition)
        {
            DataSet dataSet = new DataSet();
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection=Con;
                impfunc._Command.Transaction=Tr;
                impfunc._Command.CommandText=string.Concat(new string[]
                {
                    "Select * from ",
                    tblTable,
                    " Where ",
                    SqlCondition,
                    " ORDER BY ",
                    DispMember
                });
                impfunc._Adapter = new SqlDataAdapter(impfunc._Command);
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
                cboCombo.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO(SqlConnection Con, ComboBox cboCombo, string tblTable, string DispMember, string ValMember, string SqlCondition, string OrderByFld)
        {
            DataSet dataSet = new DataSet();
            try
            {
                if (SqlCondition == "")
                {
                    if (OrderByFld == "")
                    {
                        impfunc._Adapter = new SqlDataAdapter("Select * from " + tblTable + " ORDER BY " + DispMember, Con);
                    }
                    else
                    {
                        impfunc._Adapter = new SqlDataAdapter("Select * from " + tblTable + " ORDER BY " + OrderByFld, Con);
                    }
                }
                else if (OrderByFld == "")
                {
                    impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                    {
                        "Select * from ",
                        tblTable,
                        " Where ",
                        SqlCondition,
                        " ORDER BY ",
                        DispMember
                    }), Con);
                }
                else
                {
                    impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                    {
                        "Select * from ",
                        tblTable,
                        " Where ",
                        SqlCondition,
                        " ORDER BY ",
                        OrderByFld
                    }), Con);
                }
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
                cboCombo.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_COMBO_DISTINCT(SqlConnection Con, ComboBox cboCombo, string tblTable, string DispMember, string ValMember, string SqlCondition)
        {
            DataSet dataSet = new DataSet();
            try
            {
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "Select DISTINCT ",
                    ValMember,
                    ",",
                    DispMember,
                    " from ",
                    tblTable,
                    " Where ",
                    SqlCondition,
                    " ORDER BY ",
                    DispMember
                }), Con);
                impfunc._Adapter.Fill(dataSet, "tblTable");
                cboCombo.DataSource=dataSet.Tables[0];
                cboCombo.DisplayMember=DispMember;
                cboCombo.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_LISTBOX(SqlConnection Con, ListBox lbListBox, string tblTable, string DispMember)
        {
            DataTable dt = new DataTable();
            try
            {
                impfunc._Adapter = new SqlDataAdapter("Select * from " + tblTable + " ORDER BY " + DispMember, Con);
                impfunc._Adapter.Fill(dt);
                lbListBox.DataSource=dt;
                lbListBox.DisplayMember = DispMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_LISTBOX_DISTINCT(SqlConnection Con, ListBox lbListBox, string tblTable, string DispMember)
        {
            DataTable dt = new DataTable();
            try
            {
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "Select DISTINCT ",
                    DispMember,
                    " FROM ",
                    tblTable,
                    " ORDER BY ",
                    DispMember
                }), Con);
                impfunc._Adapter.Fill(dt);
                lbListBox.DataSource=dt;
                lbListBox.DisplayMember=DispMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_LISTBOX(SqlConnection Con, ListBox lbListBox, string tblTable, string DispMember, string ValMember)
        {
            DataTable dt = new DataTable();
            try
            {
                impfunc._Adapter = new SqlDataAdapter("Select * from " + tblTable + " ORDER BY " + DispMember, Con);
                impfunc._Adapter.Fill(dt);
                lbListBox.DataSource=dt;
                lbListBox.DisplayMember=DispMember;
                lbListBox.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_LISTBOX_DISTINCT(SqlConnection Con, ListBox lbListBox, string tblTable, string DispMember, string ValMember)
        {
            DataTable dt = new DataTable();
            try
            {
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "Select DISTINCT ",
                    ValMember,
                    ",",
                    DispMember,
                    " from ",
                    tblTable,
                    " ORDER BY ",
                    DispMember
                }), Con);
                impfunc._Adapter.Fill(dt);
                lbListBox.DataSource=dt;
                lbListBox.DisplayMember=DispMember;
                lbListBox.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_LISTBOX(SqlConnection Con, ListBox lbListBox, string tblTable, string DispMember, string ValMember, string SqlCondition)
        {
            DataTable dt = new DataTable();
            try
            {
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "Select * from ",
                    tblTable,
                    " Where ",
                    SqlCondition,
                    " ORDER BY ",
                    DispMember
                }), Con);
                impfunc._Adapter.Fill(dt);
                lbListBox.DataSource=dt;
                lbListBox.DisplayMember=DispMember;
                lbListBox.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_LISTBOX_DISTINCT(SqlConnection Con, ListBox lbListBox, string tblTable, string DispMember, string ValMember, string SqlCondition)
        {
            DataTable dt = new DataTable();
            try
            {
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "Select DISTINCT ",
                    ValMember,
                    ",",
                    DispMember,
                    " from ",
                    tblTable,
                    " Where ",
                    SqlCondition,
                    " ORDER BY ",
                    DispMember
                }), Con);
                impfunc._Adapter.Fill(dt);
                lbListBox.DataSource=dt;
                lbListBox.DisplayMember=DispMember;
                lbListBox.ValueMember=ValMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9)
        {

            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col12 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col12]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col12 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col12]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col13 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col13]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col12 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col12]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col13 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col13]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col14 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col14]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                  
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col12 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col12]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col13 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col13]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col14 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col14]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col15 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col15]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
               
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col12 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col12]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col13 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col13]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col14 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col14]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col15 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col15]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col16 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col16]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
              
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col12 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col12]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col13 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col13]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col14 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col14]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col15 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col15]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col16 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col16]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col17 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col17]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
              
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col12 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col12]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col13 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col13]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col14 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col14]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col15 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col15]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col16 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col16]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col17 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col17]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col18 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col18]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col12 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col12]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col13 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col13]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col14 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col14]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col15 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col15]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col16 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col16]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col17 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col17]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col18 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col18]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col19 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col19]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }

        public static void FILL_LIST_VIEW(SqlConnection Con, ListView lvDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20)
        {
            lvDetails.Items.Clear();
            try
            {
                if (SqlCondition == "")
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
                }
                else
                {
                    impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
                }
                Con.Open();
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    if (Col1 != "")
                    {
                        impfunc._LVITEM = lvDetails.Items.Add(Convert.ToString(impfunc._DR[Col1]));
                    }
                    else
                    {
                        impfunc._LVITEM = lvDetails.Items.Add("");
                    }
                    if (Col2 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col2]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col3 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col3]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col4 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col4]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col5 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col5]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col6 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col6]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col7 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col7]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col8 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col8]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col9 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col9]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col10 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col10]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col11 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col11]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col12 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col12]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col13 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col13]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col14 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col14]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col15 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col15]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col16 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col16]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col17 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col17]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col18 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col18]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col19 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col19]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                    if (Col20 != "")
                    {
                        impfunc._LVITEM.SubItems.Add(Convert.ToString(impfunc._DR[Col20]));
                    }
                    else
                    {
                        impfunc._LVITEM.SubItems.Add("");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                impfunc._DR.Close();
            }
        }


        //public static void FORMAT_LISTVIEW_COLUMN(ListView lv, int lvColIndex, string ValType, int TotalRow)
        //{
        //    for (int i = 0; i <= TotalRow; i++)
        //    {
        //        if (ValType == "DATE")
        //        {
        //            lv.get_Items().get_Item(i).get_SubItems().get_Item(lvColIndex).set_Text(Strings.Format(Convert.ToDateTime(lv.get_Items().get_Item(i).get_SubItems().get_Item(lvColIndex).get_Text()), "dd/MMM/yyyy"));
        //        }
        //        else if (ValType == "NUMBER")
        //        {
        //            lv.get_Items().get_Item(i).get_SubItems().get_Item(lvColIndex).set_Text(Strings.Format(Convert.ToDouble(lv.get_Items().get_Item(i).get_SubItems().get_Item(lvColIndex).get_Text()), "00.00"));
        //        }
        //        else
        //        {
        //            MessageBox.Show("HERE VALUE TYPE ONLY (DATE AND NUMBER),PLEASE INSERT CURRECT VALUE TYPE PARAMETER");
        //        }
        //    }
        //}

        //public static void FORMAT_LISTVIEW_COLUMN(ListView lv, int lvColIndex, string ValType)
        //{
        //    for (int i = 0; i <= lv.get_Items().get_Count() - 1; i++)
        //    {
        //        if (ValType.ToUpper() == "DATE")
        //        {
        //            lv.get_Items().get_Item(i).get_SubItems().get_Item(lvColIndex).set_Text(Strings.Format(Convert.ToDateTime(lv.get_Items().get_Item(i).get_SubItems().get_Item(lvColIndex).get_Text()), "dd/MMM/yyyy"));
        //        }
        //        else if (ValType.ToUpper() == "NUMBER")
        //        {
        //            lv.get_Items().get_Item(i).get_SubItems().get_Item(lvColIndex).set_Text(Strings.Format(Convert.ToDouble(lv.get_Items().get_Item(i).get_SubItems().get_Item(lvColIndex).get_Text()), "00.00"));
        //        }
        //        else
        //        {
        //            MessageBox.Show("HERE VALUE TYPE ONLY (DATE AND NUMBER),PLEASE INSERT CURRECT VALUE TYPE PARAMETER");
        //        }
        //    }
        //}

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					") VALUES (@Col1)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Value1, string Value2)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					") VALUES (@Col1,@Col2)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Value1, string Value2, string Value3)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					") VALUES (@Col1,@Col2,@Col3)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Value1, string Value2, string Value3, string Value4)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					") VALUES (@Col1,@Col2,@Col3,@Col4)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Value1, string Value2, string Value3, string Value4, string Value5)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					",",
					Col24,
					") VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23,@Col24)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);
                impfunc._Command.Parameters.Add("@Col24", Value24);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24, string Value25)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					",",
					Col24,
					",",
					Col25,
					")  VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23,@Col24,@Col25)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);
                impfunc._Command.Parameters.Add("@Col24", Value24);
                impfunc._Command.Parameters.Add("@Col25", Value25);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24, string Value25, string Value26)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					",",
					Col24,
					",",
					Col25,
					",",
					Col26,
					")  VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23,@Col24,@Col25 ,@Col26)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);
                impfunc._Command.Parameters.Add("@Col24", Value24);
                impfunc._Command.Parameters.Add("@Col25", Value25);
                impfunc._Command.Parameters.Add("@Col26", Value26);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24, string Value25, string Value26, string Value27)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					",",
					Col24,
					",",
					Col25,
					",",
					Col26,
					",",
					Col27,
					")  VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23,@Col24,@Col25 ,@Col26,@Col27)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);
                impfunc._Command.Parameters.Add("@Col24", Value24);
                impfunc._Command.Parameters.Add("@Col25", Value25);
                impfunc._Command.Parameters.Add("@Col26", Value26);
                impfunc._Command.Parameters.Add("@Col27", Value27);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24, string Value25, string Value26, string Value27, string Value28)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					",",
					Col24,
					",",
					Col25,
					",",
					Col26,
					",",
					Col27,
					",",
					Col28,
					")  VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23,@Col24,@Col25 ,@Col26,@Col27,@Col28)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);
                impfunc._Command.Parameters.Add("@Col24", Value24);
                impfunc._Command.Parameters.Add("@Col25", Value25);
                impfunc._Command.Parameters.Add("@Col26", Value26);
                impfunc._Command.Parameters.Add("@Col27", Value27);
                impfunc._Command.Parameters.Add("@Col28", Value28);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28, string Col29, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24, string Value25, string Value26, string Value27, string Value28, string Value29)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					",",
					Col24,
					",",
					Col25,
					",",
					Col26,
					",",
					Col27,
					",",
					Col28,
					",",
					Col29,
					")  VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23,@Col24,@Col25 ,@Col26,@Col27,@Col28,@Col29)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);
                impfunc._Command.Parameters.Add("@Col24", Value24);
                impfunc._Command.Parameters.Add("@Col25", Value25);
                impfunc._Command.Parameters.Add("@Col26", Value26);
                impfunc._Command.Parameters.Add("@Col27", Value27);
                impfunc._Command.Parameters.Add("@Col28", Value28);
                impfunc._Command.Parameters.Add("@Col29", Value29);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28, string Col29, string Col30, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24, string Value25, string Value26, string Value27, string Value28, string Value29, string Value30)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					",",
					Col24,
					",",
					Col25,
					",",
					Col26,
					",",
					Col27,
					",",
					Col28,
					",",
					Col29,
					",",
					Col30,
					")  VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23,@Col24,@Col25 ,@Col26,@Col27,@Col28,@Col29,@Col30)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);
                impfunc._Command.Parameters.Add("@Col24", Value24);
                impfunc._Command.Parameters.Add("@Col25", Value25);
                impfunc._Command.Parameters.Add("@Col26", Value26);
                impfunc._Command.Parameters.Add("@Col27", Value27);
                impfunc._Command.Parameters.Add("@Col28", Value28);
                impfunc._Command.Parameters.Add("@Col29", Value29);
                impfunc._Command.Parameters.Add("@Col30", Value30);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28, string Col29, string Col30, string Col31, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24, string Value25, string Value26, string Value27, string Value28, string Value29, string Value30, string Value31)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					",",
					Col24,
					",",
					Col25,
					",",
					Col26,
					",",
					Col27,
					",",
					Col28,
					",",
					Col29,
					",",
					Col30,
					",",
					Col31,
					")  VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23,@Col24,@Col25 ,@Col26,@Col27,@Col28,@Col29,@Col30,@Col31)"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);
                impfunc._Command.Parameters.Add("@Col24", Value24);
                impfunc._Command.Parameters.Add("@Col25", Value25);
                impfunc._Command.Parameters.Add("@Col26", Value26);
                impfunc._Command.Parameters.Add("@Col27", Value27);
                impfunc._Command.Parameters.Add("@Col28", Value28);
                impfunc._Command.Parameters.Add("@Col29", Value29);
                impfunc._Command.Parameters.Add("@Col30", Value30);
                impfunc._Command.Parameters.Add("@Col31", Value31);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28, string Col29, string Col30, string Col31, string Col32, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24, string Value25, string Value26, string Value27, string Value28, string Value29, string Value30, string Value31, string Value32)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"INSERT INTO ",
					TableName,
					"( ",
					Col1,
					",",
					Col2,
					",",
					Col3,
					",",
					Col4,
					",",
					Col5,
					",",
					Col6,
					",",
					Col7,
					",",
					Col8,
					",",
					Col9,
					",",
					Col10,
					",",
					Col11,
					",",
					Col12,
					",",
					Col13,
					",",
					Col14,
					",",
					Col15,
					",",
					Col16,
					",",
					Col17,
					",",
					Col18,
					",",
					Col19,
					",",
					Col20,
					",",
					Col21,
					",",
					Col22,
					",",
					Col23,
					",",
					Col24,
					",",
					Col25,
					",",
					Col26,
					",",
					Col27,
					",",
					Col28,
					",",
					Col29,
					",",
					Col30,
					",",
					Col31,
					",",
					Col32,
					")  VALUES (@Col1,@Col2,@Col3,@Col4,@Col5,@Col6,@Col7,@Col8,@Col9,@Col10,@Col11,@Col12,@Col13,@Col14,@Col15,@Col16,@Col17,@Col18,@Col19,@Col20,@Col21,@Col22,@Col23,@Col24,@Col25 ,@Col26,@Col27,@Col28,@Col29,@Col30,@Col31,@Col32)"
				});

                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@Col21", Value21);
                impfunc._Command.Parameters.Add("@Col22", Value22);
                impfunc._Command.Parameters.Add("@Col23", Value23);
                impfunc._Command.Parameters.Add("@Col24", Value24);
                impfunc._Command.Parameters.Add("@Col25", Value25);
                impfunc._Command.Parameters.Add("@Col26", Value26);
                impfunc._Command.Parameters.Add("@Col27", Value27);
                impfunc._Command.Parameters.Add("@Col28", Value28);
                impfunc._Command.Parameters.Add("@Col29", Value29);
                impfunc._Command.Parameters.Add("@Col30", Value30);
                impfunc._Command.Parameters.Add("@Col31", Value31);
                impfunc._Command.Parameters.Add("@Col32", Value32);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static long GET_ID_AFTER_SAVE(SqlConnection Con, string TableName, SqlTransaction tr)
        {
            long result = 0L;
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "SELECT @@IDENTITY FROM " + TableName;
                result = Convert.ToInt64(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                result = 0L;
                throw ex;
            }
            return result;
        }

        public static string GET_ONEFIELD(SqlConnection Con, string TableName, string FieldName)
        {
            string result = "";
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.CommandText = "SELECT " + FieldName + " FROM " + TableName;
                impfunc.OPENCONNECTION(Con);
                result = Convert.ToString(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                result = "";
                throw ex;
            }
            impfunc.CLOSECONNECTION(Con);
            return result;
        }

        public static string GET_ONEFIELD(SqlConnection Con, string TableName, string FieldName, string SqlCondition)
        {
            string result = "";
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"SELECT ",
					FieldName,
					" FROM ",
					TableName,
					" WHERE ",
					SqlCondition
				});
                impfunc.OPENCONNECTION(Con);
                result = Convert.ToString(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                result = "";
                throw ex;
            }
            impfunc.CLOSECONNECTION(Con);
            return result;
        }

        public static string GET_ONEFIELD(SqlConnection Con, SqlTransaction tr, string TableName, string FieldName)
        {
            string result = "";
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "SELECT " + FieldName + " FROM " + TableName;
                result = Convert.ToString(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                result = "";
                throw ex;
            }
            return result;
        }

        public static string GET_ONEFIELD(SqlConnection Con, SqlTransaction tr, string TableName, string FieldName, string SqlCondition)
        {
            string result = "";
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"SELECT ",
					FieldName,
					" FROM ",
					TableName,
					" WHERE ",
					SqlCondition
				});
                result = Convert.ToString(impfunc._Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                result = "";
                throw ex;
            }
            return result;
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Value1, string Value2, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Value1, string Value2, string Value3, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Value1, string Value2, string Value3, string Value4, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Value1, string Value2, string Value3, string Value4, string Value5, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string Col7, string Value7, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string Col7, string Value7, string Col8, string Value8, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string Col7, string Value7, string Col8, string Value8, string Col9, string Value9, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string Col7, string Value7, string Col8, string Value8, string Col9, string Value9, string Col10, string Value10, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string Col7, string Value7, string Col8, string Value8, string Col9, string Value9, string Col10, string Value10, string Col11, string Value11, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12  WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string Col7, string Value7, string Col8, string Value8, string Col9, string Value9, string Col10, string Value10, string Col11, string Value11, string Col12, string Value12, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13  WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string Col7, string Value7, string Col8, string Value8, string Col9, string Value9, string Col10, string Value10, string Col11, string Value11, string Col12, string Value12, string Col13, string Value13, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13,",
					Col14,
					"=@Col14  WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string Col7, string Value7, string Col8, string Value8, string Col9, string Value9, string Col10, string Value10, string Col11, string Value11, string Col12, string Value12, string Col13, string Value13, string Col14, string Value14, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13,",
					Col14,
					"=@Col14 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13,",
					Col14,
					"=@Col14,",
					Col15,
					"=@Col15  WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Value1, string Col2, string Value2, string Col3, string Value3, string Col4, string Value4, string Col5, string Value5, string Col6, string Value6, string Col7, string Value7, string Col8, string Value8, string Col9, string Value9, string Col10, string Value10, string Col11, string Value11, string Col12, string Value12, string Col13, string Value13, string Col14, string Value14, string Col15, string Value15, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13,",
					Col14,
					"=@Col14,",
					Col15,
					"=@Col15 WHERE ",
					SqlCondition
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);

                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13,",
					Col14,
					"=@Col14,",
					Col15,
					"=@Col15,",
					Col16,
					"=@Col16 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13,",
					Col14,
					"=@Col14,",
					Col15,
					"=@Col15,",
					Col16,
					"=@Col16,",
					Col17,
					"=@Col17 WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13,",
					Col14,
					"=@Col14,",
					Col15,
					"=@Col15,",
					Col16,
					"=@Col16,",
					Col17,
					"=@Col17,",
					Col18,
					"=@Col18  WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13,",
					Col14,
					"=@Col14,",
					Col15,
					"=@Col15,",
					Col16,
					"=@Col16,",
					Col17,
					"=@Col17,",
					Col18,
					"=@Col18,",
					Col19,
					"=@Col19   WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);

                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string CondField, int CondValue)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"UPDATE ",
					TableName,
					" SET ",
					Col1,
					"=@Col1,",
					Col2,
					"=@Col2,",
					Col3,
					"=@Col3,",
					Col4,
					"=@Col4,",
					Col5,
					"=@Col5,",
					Col6,
					"=@Col6,",
					Col7,
					"=@Col7,",
					Col8,
					"=@Col8,",
					Col9,
					"=@Col9,",
					Col10,
					"=@Col10,",
					Col11,
					"=@Col11,",
					Col12,
					"=@Col12,",
					Col13,
					"=@Col13,",
					Col14,
					"=@Col14,",
					Col15,
					"=@Col15,",
					Col16,
					"=@Col16,",
					Col17,
					"=@Col17,",
					Col18,
					"=@Col18,",
					Col19,
					"=@Col19,",
					Col20,
					"=@Col20  WHERE ",
					CondField,
					"=@CondField"
				});
                impfunc._Command.Parameters.Add("@Col1", Value1);
                impfunc._Command.Parameters.Add("@Col2", Value2);
                impfunc._Command.Parameters.Add("@Col3", Value3);
                impfunc._Command.Parameters.Add("@Col4", Value4);
                impfunc._Command.Parameters.Add("@Col5", Value5);
                impfunc._Command.Parameters.Add("@Col6", Value6);
                impfunc._Command.Parameters.Add("@Col7", Value7);
                impfunc._Command.Parameters.Add("@Col8", Value8);
                impfunc._Command.Parameters.Add("@Col9", Value9);
                impfunc._Command.Parameters.Add("@Col10", Value10);
                impfunc._Command.Parameters.Add("@Col11", Value11);
                impfunc._Command.Parameters.Add("@Col12", Value12);
                impfunc._Command.Parameters.Add("@Col13", Value13);
                impfunc._Command.Parameters.Add("@Col14", Value14);
                impfunc._Command.Parameters.Add("@Col15", Value15);
                impfunc._Command.Parameters.Add("@Col16", Value16);
                impfunc._Command.Parameters.Add("@Col17", Value17);
                impfunc._Command.Parameters.Add("@Col18", Value18);
                impfunc._Command.Parameters.Add("@Col19", Value19);
                impfunc._Command.Parameters.Add("@Col20", Value20);
                impfunc._Command.Parameters.Add("@CondField", CondValue);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void UPDATE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string SqlStringWithCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "UPDATE " + TableName + " " + SqlStringWithCondition;
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DELETE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col, int Id_Value)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"DELETE FROM ",
					TableName,
					" WHERE ",
					Col,
					"=@Col"
				});
                impfunc._Command.Parameters.Add("@Col", Id_Value);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DELETE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string Col, string Id_Value)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = string.Concat(new string[]
				{
					"DELETE FROM ",
					TableName,
					" WHERE ",
					Col,
					"=@Col"
				});
                impfunc._Command.Parameters.Add("@Col", Id_Value);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DELETE_RECORDS(SqlConnection Con, string TableName, SqlTransaction tr, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;

                if (SqlCondition == "")
                {
                    impfunc._Command.CommandText = "DELETE FROM " + TableName;
                }
                else
                {
                    impfunc._Command.CommandText = "DELETE FROM " + TableName + " WHERE " + SqlCondition;
                }
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, Control txtCont, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.SelectedItems[0];
        //        txtCont.Text=listViewItem.SubItems.get_Item(colSubItem).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, Control txtCont, Control txtCont1, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, Control txtCont, Control txtCont1, Control txtCont2, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, int colSubItem21, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, Control txtCont21, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        txtCont21.set_Text(listViewItem.get_SubItems().get_Item(colSubItem21).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, int colSubItem21, int colSubItem22, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, Control txtCont21, Control txtCont22, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        txtCont21.set_Text(listViewItem.get_SubItems().get_Item(colSubItem21).get_Text());
        //        txtCont22.set_Text(listViewItem.get_SubItems().get_Item(colSubItem22).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, int colSubItem21, int colSubItem22, int colSubItem23, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, Control txtCont21, Control txtCont22, Control txtCont23, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        txtCont21.set_Text(listViewItem.get_SubItems().get_Item(colSubItem21).get_Text());
        //        txtCont22.set_Text(listViewItem.get_SubItems().get_Item(colSubItem22).get_Text());
        //        txtCont23.set_Text(listViewItem.get_SubItems().get_Item(colSubItem23).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, int colSubItem21, int colSubItem22, int colSubItem23, int colSubItem24, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, Control txtCont21, Control txtCont22, Control txtCont23, Control txtCont24, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        txtCont21.set_Text(listViewItem.get_SubItems().get_Item(colSubItem21).get_Text());
        //        txtCont22.set_Text(listViewItem.get_SubItems().get_Item(colSubItem22).get_Text());
        //        txtCont23.set_Text(listViewItem.get_SubItems().get_Item(colSubItem23).get_Text());
        //        txtCont24.set_Text(listViewItem.get_SubItems().get_Item(colSubItem24).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, int colSubItem21, int colSubItem22, int colSubItem23, int colSubItem24, int colSubItem25, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, Control txtCont21, Control txtCont22, Control txtCont23, Control txtCont24, Control txtCont25, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        txtCont21.set_Text(listViewItem.get_SubItems().get_Item(colSubItem21).get_Text());
        //        txtCont22.set_Text(listViewItem.get_SubItems().get_Item(colSubItem22).get_Text());
        //        txtCont23.set_Text(listViewItem.get_SubItems().get_Item(colSubItem23).get_Text());
        //        txtCont24.set_Text(listViewItem.get_SubItems().get_Item(colSubItem24).get_Text());
        //        txtCont25.set_Text(listViewItem.get_SubItems().get_Item(colSubItem25).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, int colSubItem21, int colSubItem22, int colSubItem23, int colSubItem24, int colSubItem25, int colSubItem26, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, Control txtCont21, Control txtCont22, Control txtCont23, Control txtCont24, Control txtCont25, Control txtCont26, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        txtCont21.set_Text(listViewItem.get_SubItems().get_Item(colSubItem21).get_Text());
        //        txtCont22.set_Text(listViewItem.get_SubItems().get_Item(colSubItem22).get_Text());
        //        txtCont23.set_Text(listViewItem.get_SubItems().get_Item(colSubItem23).get_Text());
        //        txtCont24.set_Text(listViewItem.get_SubItems().get_Item(colSubItem24).get_Text());
        //        txtCont25.set_Text(listViewItem.get_SubItems().get_Item(colSubItem25).get_Text());
        //        txtCont26.set_Text(listViewItem.get_SubItems().get_Item(colSubItem26).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, int colSubItem21, int colSubItem22, int colSubItem23, int colSubItem24, int colSubItem25, int colSubItem26, int colSubItem27, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, Control txtCont21, Control txtCont22, Control txtCont23, Control txtCont24, Control txtCont25, Control txtCont26, Control txtCont27, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        txtCont21.set_Text(listViewItem.get_SubItems().get_Item(colSubItem21).get_Text());
        //        txtCont22.set_Text(listViewItem.get_SubItems().get_Item(colSubItem22).get_Text());
        //        txtCont23.set_Text(listViewItem.get_SubItems().get_Item(colSubItem23).get_Text());
        //        txtCont24.set_Text(listViewItem.get_SubItems().get_Item(colSubItem24).get_Text());
        //        txtCont25.set_Text(listViewItem.get_SubItems().get_Item(colSubItem25).get_Text());
        //        txtCont26.set_Text(listViewItem.get_SubItems().get_Item(colSubItem26).get_Text());
        //        txtCont27.set_Text(listViewItem.get_SubItems().get_Item(colSubItem27).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, int colSubItem21, int colSubItem22, int colSubItem23, int colSubItem24, int colSubItem25, int colSubItem26, int colSubItem27, int colSubItem28, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, Control txtCont21, Control txtCont22, Control txtCont23, Control txtCont24, Control txtCont25, Control txtCont26, Control txtCont27, Control txtCont28, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        txtCont21.set_Text(listViewItem.get_SubItems().get_Item(colSubItem21).get_Text());
        //        txtCont22.set_Text(listViewItem.get_SubItems().get_Item(colSubItem22).get_Text());
        //        txtCont23.set_Text(listViewItem.get_SubItems().get_Item(colSubItem23).get_Text());
        //        txtCont24.set_Text(listViewItem.get_SubItems().get_Item(colSubItem24).get_Text());
        //        txtCont25.set_Text(listViewItem.get_SubItems().get_Item(colSubItem25).get_Text());
        //        txtCont26.set_Text(listViewItem.get_SubItems().get_Item(colSubItem26).get_Text());
        //        txtCont27.set_Text(listViewItem.get_SubItems().get_Item(colSubItem27).get_Text());
        //        txtCont28.set_Text(listViewItem.get_SubItems().get_Item(colSubItem28).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void LIST_VIEW_SELECTION(ListView lv, int colSubItem, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, int colSubItem6, int colSubItem7, int colSubItem8, int colSubItem9, int colSubItem10, int colSubItem11, int colSubItem12, int colSubItem13, int colSubItem14, int colSubItem15, int colSubItem16, int colSubItem17, int colSubItem18, int colSubItem19, int colSubItem20, int colSubItem21, int colSubItem22, int colSubItem23, int colSubItem24, int colSubItem25, int colSubItem26, int colSubItem27, int colSubItem28, int colSubItem29, Control txtCont, Control txtCont1, Control txtCont2, Control txtCont3, Control txtCont4, Control txtCont5, Control txtCont6, Control txtCont7, Control txtCont8, Control txtCont9, Control txtCont10, Control txtCont11, Control txtCont12, Control txtCont13, Control txtCont14, Control txtCont15, Control txtCont16, Control txtCont17, Control txtCont18, Control txtCont19, Control txtCont20, Control txtCont21, Control txtCont22, Control txtCont23, Control txtCont24, Control txtCont25, Control txtCont26, Control txtCont27, Control txtCont28, Control txtCont29, int colSubItemTag, Control Id_In_Tag)
        //{
        //    ListViewItem listViewItem = new ListViewItem();
        //    try
        //    {
        //        listViewItem = lv.get_SelectedItems().get_Item(0);
        //        txtCont.set_Text(listViewItem.get_SubItems().get_Item(colSubItem).get_Text());
        //        txtCont1.set_Text(listViewItem.get_SubItems().get_Item(colSubItem1).get_Text());
        //        txtCont2.set_Text(listViewItem.get_SubItems().get_Item(colSubItem2).get_Text());
        //        txtCont3.set_Text(listViewItem.get_SubItems().get_Item(colSubItem3).get_Text());
        //        txtCont4.set_Text(listViewItem.get_SubItems().get_Item(colSubItem4).get_Text());
        //        txtCont5.set_Text(listViewItem.get_SubItems().get_Item(colSubItem5).get_Text());
        //        txtCont6.set_Text(listViewItem.get_SubItems().get_Item(colSubItem6).get_Text());
        //        txtCont7.set_Text(listViewItem.get_SubItems().get_Item(colSubItem7).get_Text());
        //        txtCont8.set_Text(listViewItem.get_SubItems().get_Item(colSubItem8).get_Text());
        //        txtCont9.set_Text(listViewItem.get_SubItems().get_Item(colSubItem9).get_Text());
        //        txtCont10.set_Text(listViewItem.get_SubItems().get_Item(colSubItem10).get_Text());
        //        txtCont11.set_Text(listViewItem.get_SubItems().get_Item(colSubItem11).get_Text());
        //        txtCont12.set_Text(listViewItem.get_SubItems().get_Item(colSubItem12).get_Text());
        //        txtCont13.set_Text(listViewItem.get_SubItems().get_Item(colSubItem13).get_Text());
        //        txtCont14.set_Text(listViewItem.get_SubItems().get_Item(colSubItem14).get_Text());
        //        txtCont15.set_Text(listViewItem.get_SubItems().get_Item(colSubItem15).get_Text());
        //        txtCont16.set_Text(listViewItem.get_SubItems().get_Item(colSubItem16).get_Text());
        //        txtCont17.set_Text(listViewItem.get_SubItems().get_Item(colSubItem17).get_Text());
        //        txtCont18.set_Text(listViewItem.get_SubItems().get_Item(colSubItem18).get_Text());
        //        txtCont19.set_Text(listViewItem.get_SubItems().get_Item(colSubItem19).get_Text());
        //        txtCont20.set_Text(listViewItem.get_SubItems().get_Item(colSubItem20).get_Text());
        //        txtCont21.set_Text(listViewItem.get_SubItems().get_Item(colSubItem21).get_Text());
        //        txtCont22.set_Text(listViewItem.get_SubItems().get_Item(colSubItem22).get_Text());
        //        txtCont23.set_Text(listViewItem.get_SubItems().get_Item(colSubItem23).get_Text());
        //        txtCont24.set_Text(listViewItem.get_SubItems().get_Item(colSubItem24).get_Text());
        //        txtCont25.set_Text(listViewItem.get_SubItems().get_Item(colSubItem25).get_Text());
        //        txtCont26.set_Text(listViewItem.get_SubItems().get_Item(colSubItem26).get_Text());
        //        txtCont27.set_Text(listViewItem.get_SubItems().get_Item(colSubItem27).get_Text());
        //        txtCont28.set_Text(listViewItem.get_SubItems().get_Item(colSubItem28).get_Text());
        //        txtCont29.set_Text(listViewItem.get_SubItems().get_Item(colSubItem29).get_Text());
        //        Id_In_Tag.set_Tag(listViewItem.get_SubItems().get_Item(colSubItemTag).get_Text());
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void UPDATE_COLUMN_IN_LISTVIEW(ListView lv, int colSubItem1, int colSubItem2, int colSubItem3, int colSubItem4, int colSubItem5, string Value1, string Value2, string Value3, string Value4, string Value5, int totalRow)
        //{
        //    try
        //    {
        //        for (int i = 0; i < totalRow; i++)
        //        {
        //            if (Value1 != "")
        //            {
        //                lv.get_Items().get_Item(i).get_SubItems().get_Item(colSubItem1).set_Text(Value1);
        //            }
        //            if (Value2 != "")
        //            {
        //                lv.get_Items().get_Item(i).get_SubItems().get_Item(colSubItem2).set_Text(Value2);
        //            }
        //            if (Value3 != "")
        //            {
        //                lv.get_Items().get_Item(i).get_SubItems().get_Item(colSubItem3).set_Text(Value3);
        //            }
        //            if (Value4 != "")
        //            {
        //                lv.get_Items().get_Item(i).get_SubItems().get_Item(colSubItem4).set_Text(Value4);
        //            }
        //            if (Value5 != "")
        //            {
        //                lv.get_Items().get_Item(i).get_SubItems().get_Item(colSubItem5).set_Text(Value5);
        //            }
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //        listViewItem.get_SubItems().Add(Col21);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //        listViewItem.get_SubItems().Add(Col21);
        //        listViewItem.get_SubItems().Add(Col22);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //        listViewItem.get_SubItems().Add(Col21);
        //        listViewItem.get_SubItems().Add(Col22);
        //        listViewItem.get_SubItems().Add(Col23);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //        listViewItem.get_SubItems().Add(Col21);
        //        listViewItem.get_SubItems().Add(Col22);
        //        listViewItem.get_SubItems().Add(Col23);
        //        listViewItem.get_SubItems().Add(Col24);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //        listViewItem.get_SubItems().Add(Col21);
        //        listViewItem.get_SubItems().Add(Col22);
        //        listViewItem.get_SubItems().Add(Col23);
        //        listViewItem.get_SubItems().Add(Col24);
        //        listViewItem.get_SubItems().Add(Col25);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //        listViewItem.get_SubItems().Add(Col21);
        //        listViewItem.get_SubItems().Add(Col22);
        //        listViewItem.get_SubItems().Add(Col23);
        //        listViewItem.get_SubItems().Add(Col24);
        //        listViewItem.get_SubItems().Add(Col25);
        //        listViewItem.get_SubItems().Add(Col26);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //        listViewItem.get_SubItems().Add(Col21);
        //        listViewItem.get_SubItems().Add(Col22);
        //        listViewItem.get_SubItems().Add(Col23);
        //        listViewItem.get_SubItems().Add(Col24);
        //        listViewItem.get_SubItems().Add(Col25);
        //        listViewItem.get_SubItems().Add(Col26);
        //        listViewItem.get_SubItems().Add(Col27);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //        listViewItem.get_SubItems().Add(Col21);
        //        listViewItem.get_SubItems().Add(Col22);
        //        listViewItem.get_SubItems().Add(Col23);
        //        listViewItem.get_SubItems().Add(Col24);
        //        listViewItem.get_SubItems().Add(Col25);
        //        listViewItem.get_SubItems().Add(Col26);
        //        listViewItem.get_SubItems().Add(Col27);
        //        listViewItem.get_SubItems().Add(Col28);
        //    }
        //    catch
        //    {
        //    }
        //}

        //public static void INSERT_INTO_LISTVIEW(ListView lvDet, string Col, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28, string Col29)
        //{
        //    try
        //    {
        //        ListViewItem listViewItem = lvDet.get_Items().Add(Col);
        //        listViewItem.get_SubItems().Add(Col1);
        //        listViewItem.get_SubItems().Add(Col2);
        //        listViewItem.get_SubItems().Add(Col3);
        //        listViewItem.get_SubItems().Add(Col4);
        //        listViewItem.get_SubItems().Add(Col5);
        //        listViewItem.get_SubItems().Add(Col6);
        //        listViewItem.get_SubItems().Add(Col7);
        //        listViewItem.get_SubItems().Add(Col8);
        //        listViewItem.get_SubItems().Add(Col9);
        //        listViewItem.get_SubItems().Add(Col10);
        //        listViewItem.get_SubItems().Add(Col11);
        //        listViewItem.get_SubItems().Add(Col12);
        //        listViewItem.get_SubItems().Add(Col13);
        //        listViewItem.get_SubItems().Add(Col14);
        //        listViewItem.get_SubItems().Add(Col15);
        //        listViewItem.get_SubItems().Add(Col16);
        //        listViewItem.get_SubItems().Add(Col17);
        //        listViewItem.get_SubItems().Add(Col18);
        //        listViewItem.get_SubItems().Add(Col19);
        //        listViewItem.get_SubItems().Add(Col20);
        //        listViewItem.get_SubItems().Add(Col21);
        //        listViewItem.get_SubItems().Add(Col22);
        //        listViewItem.get_SubItems().Add(Col23);
        //        listViewItem.get_SubItems().Add(Col24);
        //        listViewItem.get_SubItems().Add(Col25);
        //        listViewItem.get_SubItems().Add(Col26);
        //        listViewItem.get_SubItems().Add(Col27);
        //        listViewItem.get_SubItems().Add(Col28);
        //        listViewItem.get_SubItems().Add(Col29);
        //    }
        //    catch
        //    {
        //    }
        //}

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection=con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
             
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);

                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
        
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                  
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
          
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
        
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
   
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
           
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);

                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
            
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                  
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
  
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);

                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
  
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
      
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
          
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
     
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
         
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
          
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
       
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
       
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
          
                }
                impfunc._DR.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
        
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
               
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
            
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText = "SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text = Convert.ToString(impfunc._DR[Field26]);
            
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text = Convert.ToString(impfunc._DR[Field26]);
                    cont27.Text = Convert.ToString(impfunc._DR[Field27]);
      
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text = Convert.ToString(impfunc._DR[Field26]);
                    cont27.Text = Convert.ToString(impfunc._DR[Field27]);
                    cont28.Text = Convert.ToString(impfunc._DR[Field28]);
          
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28, string Field29, Control cont29)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text = Convert.ToString(impfunc._DR[Field26]);
                    cont27.Text = Convert.ToString(impfunc._DR[Field27]);
                    cont28.Text = Convert.ToString(impfunc._DR[Field28]);
                    cont29.Text = Convert.ToString(impfunc._DR[Field29]);
     
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28, string Field29, Control cont29, string Field30, Control cont30)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text = Convert.ToString(impfunc._DR[Field26]);
                    cont27.Text = Convert.ToString(impfunc._DR[Field27]);
                    cont28.Text = Convert.ToString(impfunc._DR[Field28]);
                    cont29.Text = Convert.ToString(impfunc._DR[Field29]);
                    cont30.Text = Convert.ToString(impfunc._DR[Field30]);
             
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28, string Field29, Control cont29, string Field30, Control cont30, string Field31, Control cont31)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text = Convert.ToString(impfunc._DR[Field26]);
                    cont27.Text = Convert.ToString(impfunc._DR[Field27]);
                    cont28.Text = Convert.ToString(impfunc._DR[Field28]);
                    cont29.Text = Convert.ToString(impfunc._DR[Field29]);
                    cont30.Text = Convert.ToString(impfunc._DR[Field30]);
                    cont31.Text = Convert.ToString(impfunc._DR[Field31]);
             
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28, string Field29, Control cont29, string Field30, Control cont30, string Field31, Control cont31, string Field32, Control cont32)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text = Convert.ToString(impfunc._DR[Field26]);
                    cont27.Text = Convert.ToString(impfunc._DR[Field27]);
                    cont28.Text = Convert.ToString(impfunc._DR[Field28]);
                    cont29.Text = Convert.ToString(impfunc._DR[Field29]);
                    cont30.Text = Convert.ToString(impfunc._DR[Field30]);
                    cont31.Text = Convert.ToString(impfunc._DR[Field31]);
                    cont32.Text = Convert.ToString(impfunc._DR[Field32]);
                
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28, string Field29, Control cont29, string Field30, Control cont30, string Field31, Control cont31, string Field32, Control cont32, string Field33, Control cont33)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text = Convert.ToString(impfunc._DR[Field26]);
                    cont27.Text = Convert.ToString(impfunc._DR[Field27]);
                    cont28.Text = Convert.ToString(impfunc._DR[Field28]);
                    cont29.Text = Convert.ToString(impfunc._DR[Field29]);
                    cont30.Text = Convert.ToString(impfunc._DR[Field30]);
                    cont31.Text = Convert.ToString(impfunc._DR[Field31]);
                    cont32.Text = Convert.ToString(impfunc._DR[Field32]);
                    cont33.Text = Convert.ToString(impfunc._DR[Field33]);
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28, string Field29, Control cont29, string Field30, Control cont30, string Field31, Control cont31, string Field32, Control cont32, string Field33, Control cont33, string Field34, Control cont34)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text=Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text=Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text=Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text=Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text=Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text=Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text=Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text=Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text=Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text=Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text=Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text=Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text=Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text=Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text=Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text=Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text=Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text=Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text=Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text=Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text=Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text=Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text=Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text=Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text=Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text=Convert.ToString(impfunc._DR[Field26]);
                    cont27.Text=Convert.ToString(impfunc._DR[Field27]);
                    cont28.Text=Convert.ToString(impfunc._DR[Field28]);
                    cont29.Text=Convert.ToString(impfunc._DR[Field29]);
                    cont30.Text=Convert.ToString(impfunc._DR[Field30]);
                    cont31.Text=Convert.ToString(impfunc._DR[Field31]);
                    cont32.Text=Convert.ToString(impfunc._DR[Field32]);
                    cont33.Text=Convert.ToString(impfunc._DR[Field33]);
                    cont34.Text=Convert.ToString(impfunc._DR[Field34]);
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void FILL_RECORD(SqlConnection con, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28, string Field29, Control cont29, string Field30, Control cont30, string Field31, Control cont31, string Field32, Control cont32, string Field33, Control cont33, string Field34, Control cont34, string Field35, Control cont35)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = con;
                impfunc.OPENCONNECTION(con);
                if (SqlCondition != "")
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName + " WHERE " + SqlCondition;
                }
                else
                {
                    impfunc._Command.CommandText="SELECT * FROM " + TableName;
                }
                impfunc._DR = impfunc._Command.ExecuteReader();
                while (impfunc._DR.Read())
                {
                    cont1.Text = Convert.ToString(impfunc._DR[Field1]);
                    cont2.Text = Convert.ToString(impfunc._DR[Field2]);
                    cont3.Text = Convert.ToString(impfunc._DR[Field3]);
                    cont4.Text = Convert.ToString(impfunc._DR[Field4]);
                    cont5.Text = Convert.ToString(impfunc._DR[Field5]);
                    cont6.Text = Convert.ToString(impfunc._DR[Field6]);
                    cont7.Text = Convert.ToString(impfunc._DR[Field7]);
                    cont8.Text = Convert.ToString(impfunc._DR[Field8]);
                    cont9.Text = Convert.ToString(impfunc._DR[Field9]);
                    cont10.Text = Convert.ToString(impfunc._DR[Field10]);
                    cont11.Text = Convert.ToString(impfunc._DR[Field11]);
                    cont12.Text = Convert.ToString(impfunc._DR[Field12]);
                    cont13.Text = Convert.ToString(impfunc._DR[Field13]);
                    cont14.Text = Convert.ToString(impfunc._DR[Field14]);
                    cont15.Text = Convert.ToString(impfunc._DR[Field15]);
                    cont16.Text = Convert.ToString(impfunc._DR[Field16]);
                    cont17.Text = Convert.ToString(impfunc._DR[Field17]);
                    cont18.Text = Convert.ToString(impfunc._DR[Field18]);
                    cont19.Text = Convert.ToString(impfunc._DR[Field19]);
                    cont20.Text = Convert.ToString(impfunc._DR[Field20]);
                    cont21.Text = Convert.ToString(impfunc._DR[Field21]);
                    cont22.Text = Convert.ToString(impfunc._DR[Field22]);
                    cont23.Text = Convert.ToString(impfunc._DR[Field23]);
                    cont24.Text = Convert.ToString(impfunc._DR[Field24]);
                    cont25.Text = Convert.ToString(impfunc._DR[Field25]);
                    cont26.Text = Convert.ToString(impfunc._DR[Field26]);
                    cont27.Text = Convert.ToString(impfunc._DR[Field27]);
                    cont28.Text = Convert.ToString(impfunc._DR[Field28]);
                    cont29.Text = Convert.ToString(impfunc._DR[Field29]);
                    cont30.Text = Convert.ToString(impfunc._DR[Field30]);
                    cont31.Text = Convert.ToString(impfunc._DR[Field31]);
                    cont32.Text = Convert.ToString(impfunc._DR[Field32]);
                    cont33.Text = Convert.ToString(impfunc._DR[Field33]);
                    cont34.Text = Convert.ToString(impfunc._DR[Field34]);
                    cont35.Text=Convert.ToString(impfunc._DR[Field35]);
                }
                impfunc._DR.Close();
            }
            catch
            {
            }
            impfunc.CLOSECONNECTION(con);
        }

        public static void SAVE_IN_JOURNAL(SqlConnection Con, SqlTransaction tr, int Companyid, int Ledgerid, int Srno, string TranDate, int Vno, string Narration, string Vtype, string Dr, string Cr, int TranId, int Jno, int Fyearid, string BankDate)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "INSERT INTO JOURNAL  VALUES (@CompId,@LedgerId,@SrNo,@TranDate,@Vno,@Narration,@Vtype,@Dr,@Cr,@TranId,@Jno,@ChkNo,@ChkDate,@Bank,@FyearId,@BankDate )";
                impfunc._Command.Parameters.Add("@CompId", Convert.ToInt32(Companyid));
                impfunc._Command.Parameters.Add("@LedgerID", Convert.ToInt32(Ledgerid));
                impfunc._Command.Parameters.Add("@Srno", Srno);
                impfunc._Command.Parameters.Add("@TranDate", TranDate);
                impfunc._Command.Parameters.Add("@Vno", Convert.ToInt32(Vno));
                impfunc._Command.Parameters.Add("@Narration", Narration);
                impfunc._Command.Parameters.Add("@Vtype", Vtype);
                impfunc._Command.Parameters.Add("@Dr", Dr);
                impfunc._Command.Parameters.Add("@Cr", Cr);
                impfunc._Command.Parameters.Add("@TranId", Convert.ToInt32(TranId));
                impfunc._Command.Parameters.Add("@Jno", Jno);
                impfunc._Command.Parameters.Add("@ChkNo", "");
                impfunc._Command.Parameters.Add("@ChkDate", "1/1/1990");
                impfunc._Command.Parameters.Add("@Bank", "");
                impfunc._Command.Parameters.Add("@FyearId", Convert.ToInt32(Fyearid));
                impfunc._Command.Parameters.Add("@BankDate", BankDate);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_IN_JOURNAL(SqlConnection Con, SqlTransaction tr, int Companyid, int Ledgerid, int Srno, string TranDate, int Vno, string Narration, string Vtype, string TransactionType, string Dr, string Cr, int TranId, int Jno, int Fyearid, string BankDate)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "INSERT INTO JOURNAL  VALUES (@CompId,@LedgerId,@SrNo,@TranDate,@Vno,@Narration,@Vtype,@TType,@Dr,@Cr,@TranId,@Jno,@ChkNo,@ChkDate,@Bank,@FyearId,@BankDate )";
                impfunc._Command.Parameters.Add("@CompId", Convert.ToInt32(Companyid));
                impfunc._Command.Parameters.Add("@LedgerID", Convert.ToInt32(Ledgerid));
                impfunc._Command.Parameters.Add("@Srno", Srno);
                impfunc._Command.Parameters.Add("@TranDate", TranDate);
                impfunc._Command.Parameters.Add("@Vno", Convert.ToInt32(Vno));
                impfunc._Command.Parameters.Add("@Narration", Narration);
                impfunc._Command.Parameters.Add("@Vtype", Vtype);
                impfunc._Command.Parameters.Add("@TType", TransactionType);
                impfunc._Command.Parameters.Add("@Dr", Dr);
                impfunc._Command.Parameters.Add("@Cr", Cr);
                impfunc._Command.Parameters.Add("@TranId", Convert.ToInt32(TranId));
                impfunc._Command.Parameters.Add("@Jno", Jno);
                impfunc._Command.Parameters.Add("@ChkNo", "");
                impfunc._Command.Parameters.Add("@ChkDate", "1/1/1990");
                impfunc._Command.Parameters.Add("@Bank", "");
                impfunc._Command.Parameters.Add("@FyearId", Convert.ToInt32(Fyearid));
                impfunc._Command.Parameters.Add("@BankDate", BankDate);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_IN_JOURNAL(SqlConnection Con, SqlTransaction tr, int Companyid, int Ledgerid, int Srno, string TranDate, int Vno, string Narration, string Vtype, string TransactionType, string Dr, string Cr, int TranId, int Jno, int Fyearid, int AdditionalId, string BankDate)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "INSERT INTO JOURNAL  VALUES (@CompId,@LedgerId,@SrNo,@TranDate,@Vno,@Narration,@Vtype,@TType,@Dr,@Cr,@TranId,@Jno,@ChkNo,@ChkDate,@Bank,@FyearId ,@AddId,@BankDate)";
                impfunc._Command.Parameters.Add("@CompId", Convert.ToInt32(Companyid));
                impfunc._Command.Parameters.Add("@LedgerID", Convert.ToInt32(Ledgerid));
                impfunc._Command.Parameters.Add("@Srno", Srno);
                impfunc._Command.Parameters.Add("@TranDate", TranDate);
                impfunc._Command.Parameters.Add("@Vno", Convert.ToInt32(Vno));
                impfunc._Command.Parameters.Add("@Narration", Narration);
                impfunc._Command.Parameters.Add("@Vtype", Vtype);
                impfunc._Command.Parameters.Add("@TType", TransactionType);
                impfunc._Command.Parameters.Add("@Dr", Dr);
                impfunc._Command.Parameters.Add("@Cr", Cr);
                impfunc._Command.Parameters.Add("@TranId", Convert.ToInt32(TranId));
                impfunc._Command.Parameters.Add("@Jno", Jno);
                impfunc._Command.Parameters.Add("@ChkNo", "");
                impfunc._Command.Parameters.Add("@ChkDate", "1/1/1990");
                impfunc._Command.Parameters.Add("@Bank", "");
                impfunc._Command.Parameters.Add("@FyearId", Convert.ToInt32(Fyearid));
                impfunc._Command.Parameters.Add("@AddId", Convert.ToInt32(AdditionalId));
                impfunc._Command.Parameters.Add("@BankDate", BankDate);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_IN_JOURNAL(SqlConnection Con, SqlTransaction tr, int Companyid, int Ledgerid, int Srno, string TranDate, int Vno, string Narration, string Vtype, string Dr, string Cr, int TranId, int Jno, string ChkNo, string ChkDate, string Bank, int Fyearid, string BankDate)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "INSERT INTO JOURNAL  VALUES (@CompId,@LedgerId,@SrNo,@TranDate,@Vno,@Narration,@Vtype,@Dr,@Cr,@TranId,@Jno,@ChkNo,@ChkDate,@Bank,@FyearId,@BankDate )";
                impfunc._Command.Parameters.Add("@CompId", Convert.ToInt32(Companyid));
                impfunc._Command.Parameters.Add("@LedgerID", Convert.ToInt32(Ledgerid));
                impfunc._Command.Parameters.Add("@Srno", Srno);
                impfunc._Command.Parameters.Add("@TranDate", TranDate);
                impfunc._Command.Parameters.Add("@Vno", Convert.ToInt32(Vno));
                impfunc._Command.Parameters.Add("@Narration", Narration);
                impfunc._Command.Parameters.Add("@Vtype", Vtype);
                impfunc._Command.Parameters.Add("@Dr", Dr);
                impfunc._Command.Parameters.Add("@Cr", Cr);
                impfunc._Command.Parameters.Add("@TranId", Convert.ToInt32(TranId));
                impfunc._Command.Parameters.Add("@Jno", Jno);
                impfunc._Command.Parameters.Add("@ChkNo", ChkNo);
                impfunc._Command.Parameters.Add("@ChkDate", ChkDate);
                impfunc._Command.Parameters.Add("@Bank", Bank);
                impfunc._Command.Parameters.Add("@FyearId", Convert.ToInt32(Fyearid));
                impfunc._Command.Parameters.Add("@BankDate", BankDate);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_IN_JOURNAL(SqlConnection Con, SqlTransaction tr, int Companyid, int Ledgerid, int Srno, string TranDate, int Vno, string Narration, string Vtype, string TransactionType, string Dr, string Cr, int TranId, int Jno, string ChkNo, string ChkDate, string Bank, int Fyearid, string BankDate)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "INSERT INTO JOURNAL  VALUES (@CompId,@LedgerId,@SrNo,@TranDate,@Vno,@Narration,@Vtype,@TType,@Dr,@Cr,@TranId,@Jno,@ChkNo,@ChkDate,@Bank,@FyearId,@BankDate )";
                impfunc._Command.Parameters.Add("@CompId", Convert.ToInt32(Companyid));
                impfunc._Command.Parameters.Add("@LedgerID", Convert.ToInt32(Ledgerid));
                impfunc._Command.Parameters.Add("@Srno", Srno);
                impfunc._Command.Parameters.Add("@TranDate", TranDate);
                impfunc._Command.Parameters.Add("@Vno", Convert.ToInt32(Vno));
                impfunc._Command.Parameters.Add("@Narration", Narration);
                impfunc._Command.Parameters.Add("@Vtype", Vtype);
                impfunc._Command.Parameters.Add("@TType", TransactionType);
                impfunc._Command.Parameters.Add("@Dr", Dr);
                impfunc._Command.Parameters.Add("@Cr", Cr);
                impfunc._Command.Parameters.Add("@TranId", Convert.ToInt32(TranId));
                impfunc._Command.Parameters.Add("@Jno", Jno);
                impfunc._Command.Parameters.Add("@ChkNo", ChkNo);
                impfunc._Command.Parameters.Add("@ChkDate", ChkDate);
                impfunc._Command.Parameters.Add("@Bank", Bank);
                impfunc._Command.Parameters.Add("@FyearId", Convert.ToInt32(Fyearid));
                impfunc._Command.Parameters.Add("@BankDate", BankDate);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_IN_JOURNAL(SqlConnection Con, SqlTransaction tr, int Companyid, int Ledgerid, int Srno, string TranDate, int Vno, string Narration, string Vtype, string TransactionType, string Dr, string Cr, int TranId, int Jno, string ChkNo, string ChkDate, string Bank, int Fyearid, int AdditionalId, string BankDate)
        {
            try
            {

                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "INSERT INTO JOURNAL  VALUES (@CompId,@LedgerId,@SrNo,@TranDate,@Vno,@Narration,@Vtype,@TType,@Dr,@Cr,@TranId,@Jno,@ChkNo,@ChkDate,@Bank,@FyearId,@AddId,@BankDate)";
                impfunc._Command.Parameters.Add("@CompId", Convert.ToInt32(Companyid));
                impfunc._Command.Parameters.Add("@LedgerID", Convert.ToInt32(Ledgerid));
                impfunc._Command.Parameters.Add("@Srno", Srno);
                impfunc._Command.Parameters.Add("@TranDate", TranDate);
                impfunc._Command.Parameters.Add("@Vno", Convert.ToInt32(Vno));
                impfunc._Command.Parameters.Add("@Narration", Narration);
                impfunc._Command.Parameters.Add("@Vtype", Vtype);
                impfunc._Command.Parameters.Add("@TType", TransactionType);
                impfunc._Command.Parameters.Add("@Dr", Dr);
                impfunc._Command.Parameters.Add("@Cr", Cr);
                impfunc._Command.Parameters.Add("@TranId", Convert.ToInt32(TranId));
                impfunc._Command.Parameters.Add("@Jno", Jno);
                impfunc._Command.Parameters.Add("@ChkNo", ChkNo);
                impfunc._Command.Parameters.Add("@ChkDate", ChkDate);
                impfunc._Command.Parameters.Add("@Bank", Bank);
                impfunc._Command.Parameters.Add("@FyearId", Fyearid);
                impfunc._Command.Parameters.Add("@AddId", AdditionalId);
                impfunc._Command.Parameters.Add("@BankDate", BankDate);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_IN_JOURNAL_WITHOUT_TTYPE(SqlConnection Con, SqlTransaction tr, int Companyid, int Ledgerid, int Srno, string TranDate, int Vno, string Narration, string Vtype, string Dr, string Cr, int TranId, int Jno, int Fyearid, int AdditionalId, string BankDate)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "INSERT INTO JOURNAL  VALUES (@CompId,@LedgerId,@SrNo,@TranDate,@Vno,@Narration,@Vtype,@Dr,@Cr,@TranId,@Jno,@ChkNo,@ChkDate,@Bank,@FyearId,@AddId,@BankDate)";
                impfunc._Command.Parameters.Add("@CompId", Convert.ToInt32(Companyid));
                impfunc._Command.Parameters.Add("@LedgerID", Convert.ToInt32(Ledgerid));
                impfunc._Command.Parameters.Add("@Srno", Srno);
                impfunc._Command.Parameters.Add("@TranDate", TranDate);
                impfunc._Command.Parameters.Add("@Vno", Convert.ToInt32(Vno));
                impfunc._Command.Parameters.Add("@Narration", Narration);
                impfunc._Command.Parameters.Add("@Vtype", Vtype);
                impfunc._Command.Parameters.Add("@Dr", Dr);
                impfunc._Command.Parameters.Add("@Cr", Cr);
                impfunc._Command.Parameters.Add("@TranId", Convert.ToInt32(TranId));
                impfunc._Command.Parameters.Add("@Jno", Jno);
                impfunc._Command.Parameters.Add("@ChkNo", "");
                impfunc._Command.Parameters.Add("@ChkDate", "1/1/1990");
                impfunc._Command.Parameters.Add("@Bank", "");
                impfunc._Command.Parameters.Add("@FyearId", Fyearid);
                impfunc._Command.Parameters.Add("@AddId", AdditionalId);
                impfunc._Command.Parameters.Add("@BankDate", BankDate);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_IN_JOURNAL_WITHOUT_TTYPE(SqlConnection Con, SqlTransaction tr, int Companyid, int Ledgerid, int Srno, string TranDate, int Vno, string Narration, string Vtype, string Dr, string Cr, int TranId, int Jno, string ChkNo, string ChkDate, string Bank, int Fyearid, int AdditionalId, string BankDate)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "INSERT INTO JOURNAL  VALUES (@CompId,@LedgerId,@SrNo,@TranDate,@Vno,@Narration,@Vtype,@Dr,@Cr,@TranId,@Jno,@ChkNo,@ChkDate,@Bank,@FyearId,@AddId,@BankDate)";
                impfunc._Command.Parameters.Add("@CompId", Convert.ToInt32(Companyid));
                impfunc._Command.Parameters.Add("@LedgerID", Convert.ToInt32(Ledgerid));
                impfunc._Command.Parameters.Add("@Srno", Srno);
                impfunc._Command.Parameters.Add("@TranDate", TranDate);
                impfunc._Command.Parameters.Add("@Vno", Convert.ToInt32(Vno));
                impfunc._Command.Parameters.Add("@Narration", Narration);
                impfunc._Command.Parameters.Add("@Vtype", Vtype);
                impfunc._Command.Parameters.Add("@Dr", Dr);
                impfunc._Command.Parameters.Add("@Cr", Cr);
                impfunc._Command.Parameters.Add("@TranId", Convert.ToInt32(TranId));
                impfunc._Command.Parameters.Add("@Jno", Jno);
                impfunc._Command.Parameters.Add("@ChkNo", ChkNo);
                impfunc._Command.Parameters.Add("@ChkDate", ChkDate);
                impfunc._Command.Parameters.Add("@Bank", Bank);
                impfunc._Command.Parameters.Add("@FyearId", Convert.ToInt32(Fyearid));
                impfunc._Command.Parameters.Add("@AddId", Convert.ToInt32(AdditionalId));
                impfunc._Command.Parameters.Add("@BankDate", BankDate);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SAVE_IN_JOURNAL(SqlConnection Con, SqlTransaction tr, int Companyid, int Ledgerid, int Srno, string TranDate, int Vno, string Narration, string Vtype, string TransactionType, string Dr, string Cr, int TranId, int Jno, string ChkNo, string ChkDate, string Bank, int Fyearid, int AdditionalId, string BankDate, int Branchmasterid)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "INSERT INTO JOURNAL  VALUES (@CompId,@LedgerId,@SrNo,@TranDate,@Vno,@Narration,@Vtype,@TType,@Dr,@Cr,@TranId,@Jno,@ChkNo,@ChkDate,@Bank,@FyearId,@AddId,@BankDate,@BranchMasterId)";
                impfunc._Command.Parameters.Add("@CompId", Convert.ToInt32(Companyid));
                impfunc._Command.Parameters.Add("@LedgerID", Convert.ToInt32(Ledgerid));
                impfunc._Command.Parameters.Add("@Srno", Srno);
                impfunc._Command.Parameters.Add("@TranDate", TranDate);
                impfunc._Command.Parameters.Add("@Vno", Convert.ToInt32(Vno));
                impfunc._Command.Parameters.Add("@Narration", Narration);
                impfunc._Command.Parameters.Add("@Vtype", Vtype);
                impfunc._Command.Parameters.Add("@TType", TransactionType);
                impfunc._Command.Parameters.Add("@Dr", Dr);
                impfunc._Command.Parameters.Add("@Cr", Cr);
                impfunc._Command.Parameters.Add("@TranId", Convert.ToInt32(TranId));
                impfunc._Command.Parameters.Add("@Jno", Jno);
                impfunc._Command.Parameters.Add("@ChkNo", ChkNo);
                impfunc._Command.Parameters.Add("@ChkDate", ChkDate);
                impfunc._Command.Parameters.Add("@Bank", Bank);
                impfunc._Command.Parameters.Add("@FyearId", Fyearid);
                impfunc._Command.Parameters.Add("@AddId", AdditionalId);
                impfunc._Command.Parameters.Add("@BankDate", BankDate);
                impfunc._Command.Parameters.Add("@BranchMasterId", Branchmasterid);
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DELETE_FROM_JOURNAL(SqlConnection Con, SqlTransaction tr, string SqlCondition)
        {
            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = Con;
                impfunc._Command.Transaction = tr;
                impfunc._Command.CommandText = "DELETE FROM JOURNAL WHERE " + SqlCondition;
                impfunc._Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public static double LIST_VIEW_COL_TOTAL(ListView lvDetails, int ColIndex)
        //{
        //    double num = 0.0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            num += Convert.ToDouble(lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text());
        //        }
        //    }
        //    catch
        //    {
        //    }
        //    return num;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, int ColIndex1, string Matching_With1, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex1).get_Text() == Matching_With1)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, int ColIndex1, string Matching_With1, int ColIndex2, string Matching_With2, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex1).get_Text() == Matching_With1 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex2).get_Text() == Matching_With2)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, int ColIndex1, string Matching_With1, int ColIndex2, string Matching_With2, int ColIndex3, string Matching_With3, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex1).get_Text() == Matching_With1 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex2).get_Text() == Matching_With2 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex3).get_Text() == Matching_With3)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, int ColIndex1, string Matching_With1, int ColIndex2, string Matching_With2, int ColIndex3, string Matching_With3, int ColIndex4, string Matching_With4, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex1).get_Text() == Matching_With1 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex2).get_Text() == Matching_With2 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex3).get_Text() == Matching_With3 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex4).get_Text() == Matching_With4)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, int ColIndex1, string Matching_With1, int ColIndex2, string Matching_With2, int ColIndex3, string Matching_With3, int ColIndex4, string Matching_With4, int ColIndex5, string Matching_With5, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex1).get_Text() == Matching_With1 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex2).get_Text() == Matching_With2 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex3).get_Text() == Matching_With3 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex4).get_Text() == Matching_With4 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex5).get_Text() == Matching_With5)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, int ColIndex1, string Matching_With1, int ColIndex2, string Matching_With2, int ColIndex3, string Matching_With3, int ColIndex4, string Matching_With4, int ColIndex5, string Matching_With5, int ColIndex6, string Matching_With6, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex1).get_Text() == Matching_With1 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex2).get_Text() == Matching_With2 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex3).get_Text() == Matching_With3 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex4).get_Text() == Matching_With4 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex5).get_Text() == Matching_With5 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex6).get_Text() == Matching_With6)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, int ColIndex1, string Matching_With1, int ColIndex2, string Matching_With2, int ColIndex3, string Matching_With3, int ColIndex4, string Matching_With4, int ColIndex5, string Matching_With5, int ColIndex6, string Matching_With6, int ColIndex7, string Matching_With7, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex1).get_Text() == Matching_With1 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex2).get_Text() == Matching_With2 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex3).get_Text() == Matching_With3 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex4).get_Text() == Matching_With4 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex5).get_Text() == Matching_With5 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex6).get_Text() == Matching_With6 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex7).get_Text() == Matching_With7)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, int ColIndex1, string Matching_With1, int ColIndex2, string Matching_With2, int ColIndex3, string Matching_With3, int ColIndex4, string Matching_With4, int ColIndex5, string Matching_With5, int ColIndex6, string Matching_With6, int ColIndex7, string Matching_With7, int ColIndex8, string Matching_With8, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex1).get_Text() == Matching_With1 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex2).get_Text() == Matching_With2 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex3).get_Text() == Matching_With3 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex4).get_Text() == Matching_With4 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex5).get_Text() == Matching_With5 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex6).get_Text() == Matching_With6 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex7).get_Text() == Matching_With7 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex8).get_Text() == Matching_With8)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool CHECK_EXISTS_IN_LISTVIEW(ListView lvDetails, int ColIndex, string Matching_With, int ColIndex1, string Matching_With1, int ColIndex2, string Matching_With2, int ColIndex3, string Matching_With3, int ColIndex4, string Matching_With4, int ColIndex5, string Matching_With5, int ColIndex6, string Matching_With6, int ColIndex7, string Matching_With7, int ColIndex8, string Matching_With8, int ColIndex9, string Matching_With9, bool ShowMsg, Control FocusOn)
        //{
        //    int num = 0;
        //    try
        //    {
        //        for (int i = 0; i <= lvDetails.get_Items().get_Count() - 1; i++)
        //        {
        //            if (lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex).get_Text() == Matching_With && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex1).get_Text() == Matching_With1 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex2).get_Text() == Matching_With2 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex3).get_Text() == Matching_With3 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex4).get_Text() == Matching_With4 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex5).get_Text() == Matching_With5 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex6).get_Text() == Matching_With6 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex7).get_Text() == Matching_With7 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex8).get_Text() == Matching_With8 && lvDetails.get_Items().get_Item(i).get_SubItems().get_Item(ColIndex9).get_Text() == Matching_With9)
        //            {
        //                num = 1;
        //                break;
        //            }
        //            num = 0;
        //        }
        //    }
        //    catch
        //    {
        //        num = 1;
        //    }
        //    bool result;
        //    if (num == 1)
        //    {
        //        if (ShowMsg)
        //        {
        //            impfunc.MSGBOX_INFORMATION("record already exists in list !!");
        //        }
        //        FocusOn.Focus();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static void FILL_IMAGE_FROM_TABLE(SqlConnection Con, string tblTable, string Field, string SqlCondition, PictureBox pb)
        //{
        //    try
        //    {
        //        if (SqlCondition == "")
        //        {
        //            impfunc._Adapter = new SqlDataAdapter("SELECT " + Field + " FROM " + tblTable, Con);
        //        }
        //        else
        //        {
        //            impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
        //            {
        //                "SELECT ",
        //                Field,
        //                " FROM ",
        //                tblTable,
        //                " WHERE ",
        //                SqlCondition
        //            }), Con);
        //        }
        //        DataSet dataSet = new DataSet();
        //        impfunc._Adapter.Fill(dataSet, tblTable);
        //        int count = dataSet.get_Tables().get_Item(tblTable).get_Rows().get_Count();
        //        if (count > 0)
        //        {
        //            byte[] array = new byte[0];
        //            DataRow dataRow = dataSet.get_Tables().get_Item(tblTable).get_Rows().get_Item(count - 1);
        //            array = (byte[])dataRow.get_Item(Field);
        //            MemoryStream memoryStream = new MemoryStream(array);
        //            pb.set_Image(Image.FromStream(memoryStream));
        //        }
        //        else
        //        {
        //            pb.set_Image(null);
        //        }
        //    }
        //    catch
        //    {
        //        pb.set_Image(null);
        //    }
        //}

        //public static void UPDATE_IMAGE_IN_TABLE(SqlConnection Con, SqlTransaction tr, string TableName, string Col1, string SqlCondition, PictureBox pb, string ImagePath)
        //{
        //    if (!(ImagePath == ""))
        //    {
        //        try
        //        {
        //            impfunc._Command = new SqlCommand();
        //            impfunc._Command.Connection=Con;
        //            impfunc._Command.Transaction=tr;
        //            impfunc._Command.CommandText=string.Concat(new string[]
        //            {
        //                "UPDATE ",
        //                TableName,
        //                " SET ",
        //                Col1,
        //                "=@Col1 WHERE ",
        //                SqlCondition
        //            });
        //            MemoryStream memoryStream = new MemoryStream();
        //            pb.Image.Save(memoryStream,ImageFormat.JPEGImage());
        //            byte[] array = memoryStream.ToArray();
        //            impfunc._Command.Parameters.Add("@Col1", array);
        //            impfunc._Command.ExecuteNonQuery();
        //            pb.set_Image(null);
        //        }
        //        catch (Exception ex)
        //        {
        //            pb.set_Image(null);
        //            throw ex;
        //        }
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //            cont22.set_Text(Convert.ToString(impfunc._DR.get_Item(Field22)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //            cont22.set_Text(Convert.ToString(impfunc._DR.get_Item(Field22)));
        //            cont23.set_Text(Convert.ToString(impfunc._DR.get_Item(Field23)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //            cont22.set_Text(Convert.ToString(impfunc._DR.get_Item(Field22)));
        //            cont23.set_Text(Convert.ToString(impfunc._DR.get_Item(Field23)));
        //            cont24.set_Text(Convert.ToString(impfunc._DR.get_Item(Field24)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //            cont22.set_Text(Convert.ToString(impfunc._DR.get_Item(Field22)));
        //            cont23.set_Text(Convert.ToString(impfunc._DR.get_Item(Field23)));
        //            cont24.set_Text(Convert.ToString(impfunc._DR.get_Item(Field24)));
        //            cont25.set_Text(Convert.ToString(impfunc._DR.get_Item(Field25)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //            cont22.set_Text(Convert.ToString(impfunc._DR.get_Item(Field22)));
        //            cont23.set_Text(Convert.ToString(impfunc._DR.get_Item(Field23)));
        //            cont24.set_Text(Convert.ToString(impfunc._DR.get_Item(Field24)));
        //            cont25.set_Text(Convert.ToString(impfunc._DR.get_Item(Field25)));
        //            cont26.set_Text(Convert.ToString(impfunc._DR.get_Item(Field26)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //            cont22.set_Text(Convert.ToString(impfunc._DR.get_Item(Field22)));
        //            cont23.set_Text(Convert.ToString(impfunc._DR.get_Item(Field23)));
        //            cont24.set_Text(Convert.ToString(impfunc._DR.get_Item(Field24)));
        //            cont25.set_Text(Convert.ToString(impfunc._DR.get_Item(Field25)));
        //            cont26.set_Text(Convert.ToString(impfunc._DR.get_Item(Field26)));
        //            cont27.set_Text(Convert.ToString(impfunc._DR.get_Item(Field27)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //            cont22.set_Text(Convert.ToString(impfunc._DR.get_Item(Field22)));
        //            cont23.set_Text(Convert.ToString(impfunc._DR.get_Item(Field23)));
        //            cont24.set_Text(Convert.ToString(impfunc._DR.get_Item(Field24)));
        //            cont25.set_Text(Convert.ToString(impfunc._DR.get_Item(Field25)));
        //            cont26.set_Text(Convert.ToString(impfunc._DR.get_Item(Field26)));
        //            cont27.set_Text(Convert.ToString(impfunc._DR.get_Item(Field27)));
        //            cont28.set_Text(Convert.ToString(impfunc._DR.get_Item(Field28)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28, string Field29, Control cont29)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //            cont22.set_Text(Convert.ToString(impfunc._DR.get_Item(Field22)));
        //            cont23.set_Text(Convert.ToString(impfunc._DR.get_Item(Field23)));
        //            cont24.set_Text(Convert.ToString(impfunc._DR.get_Item(Field24)));
        //            cont25.set_Text(Convert.ToString(impfunc._DR.get_Item(Field25)));
        //            cont26.set_Text(Convert.ToString(impfunc._DR.get_Item(Field26)));
        //            cont27.set_Text(Convert.ToString(impfunc._DR.get_Item(Field27)));
        //            cont28.set_Text(Convert.ToString(impfunc._DR.get_Item(Field28)));
        //            cont29.set_Text(Convert.ToString(impfunc._DR.get_Item(Field29)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        //public static void FILL_RECORD(SqlConnection con, SqlTransaction tr, string TableName, string SqlCondition, string Field1, Control cont1, string Field2, Control cont2, string Field3, Control cont3, string Field4, Control cont4, string Field5, Control cont5, string Field6, Control cont6, string Field7, Control cont7, string Field8, Control cont8, string Field9, Control cont9, string Field10, Control cont10, string Field11, Control cont11, string Field12, Control cont12, string Field13, Control cont13, string Field14, Control cont14, string Field15, Control cont15, string Field16, Control cont16, string Field17, Control cont17, string Field18, Control cont18, string Field19, Control cont19, string Field20, Control cont20, string Field21, Control cont21, string Field22, Control cont22, string Field23, Control cont23, string Field24, Control cont24, string Field25, Control cont25, string Field26, Control cont26, string Field27, Control cont27, string Field28, Control cont28, string Field29, Control cont29, string Field30, Control cont30)
        //{
        //    try
        //    {
        //        impfunc._Command = new SqlCommand();
        //        impfunc._Command.set_Connection(con);
        //        impfunc._Command.set_Transaction(tr);
        //        if (SqlCondition != "")
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName + " WHERE " + SqlCondition);
        //        }
        //        else
        //        {
        //            impfunc._Command.set_CommandText("SELECT * FROM " + TableName);
        //        }
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        while (impfunc._DR.Read())
        //        {
        //            cont1.set_Text(Convert.ToString(impfunc._DR.get_Item(Field1)));
        //            cont2.set_Text(Convert.ToString(impfunc._DR.get_Item(Field2)));
        //            cont3.set_Text(Convert.ToString(impfunc._DR.get_Item(Field3)));
        //            cont4.set_Text(Convert.ToString(impfunc._DR.get_Item(Field4)));
        //            cont5.set_Text(Convert.ToString(impfunc._DR.get_Item(Field5)));
        //            cont6.set_Text(Convert.ToString(impfunc._DR.get_Item(Field6)));
        //            cont7.set_Text(Convert.ToString(impfunc._DR.get_Item(Field7)));
        //            cont8.set_Text(Convert.ToString(impfunc._DR.get_Item(Field8)));
        //            cont9.set_Text(Convert.ToString(impfunc._DR.get_Item(Field9)));
        //            cont10.set_Text(Convert.ToString(impfunc._DR.get_Item(Field10)));
        //            cont11.set_Text(Convert.ToString(impfunc._DR.get_Item(Field11)));
        //            cont12.set_Text(Convert.ToString(impfunc._DR.get_Item(Field12)));
        //            cont13.set_Text(Convert.ToString(impfunc._DR.get_Item(Field13)));
        //            cont14.set_Text(Convert.ToString(impfunc._DR.get_Item(Field14)));
        //            cont15.set_Text(Convert.ToString(impfunc._DR.get_Item(Field15)));
        //            cont16.set_Text(Convert.ToString(impfunc._DR.get_Item(Field16)));
        //            cont17.set_Text(Convert.ToString(impfunc._DR.get_Item(Field17)));
        //            cont18.set_Text(Convert.ToString(impfunc._DR.get_Item(Field18)));
        //            cont19.set_Text(Convert.ToString(impfunc._DR.get_Item(Field19)));
        //            cont20.set_Text(Convert.ToString(impfunc._DR.get_Item(Field20)));
        //            cont21.set_Text(Convert.ToString(impfunc._DR.get_Item(Field21)));
        //            cont22.set_Text(Convert.ToString(impfunc._DR.get_Item(Field22)));
        //            cont23.set_Text(Convert.ToString(impfunc._DR.get_Item(Field23)));
        //            cont24.set_Text(Convert.ToString(impfunc._DR.get_Item(Field24)));
        //            cont25.set_Text(Convert.ToString(impfunc._DR.get_Item(Field25)));
        //            cont26.set_Text(Convert.ToString(impfunc._DR.get_Item(Field26)));
        //            cont27.set_Text(Convert.ToString(impfunc._DR.get_Item(Field27)));
        //            cont28.set_Text(Convert.ToString(impfunc._DR.get_Item(Field28)));
        //            cont29.set_Text(Convert.ToString(impfunc._DR.get_Item(Field29)));
        //            cont30.set_Text(Convert.ToString(impfunc._DR.get_Item(Field30)));
        //        }
        //        impfunc._DR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        impfunc._DR.Close();
        //        throw ex;
        //    }
        //}

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter("SELECT " + Col1 + " FROM " + tblTable, con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    ",",
                    Col22,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    ",",
                    Col22,
                    ",",
                    Col23,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    ",",
                    Col22,
                    ",",
                    Col23,
                    ",",
                    Col24,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    ",",
                    Col22,
                    ",",
                    Col23,
                    ",",
                    Col24,
                    ",",
                    Col25,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    ",",
                    Col22,
                    ",",
                    Col23,
                    ",",
                    Col24,
                    ",",
                    Col25,
                    ",",
                    Col26,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    ",",
                    Col22,
                    ",",
                    Col23,
                    ",",
                    Col24,
                    ",",
                    Col25,
                    ",",
                    Col26,
                    ",",
                    Col27,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    ",",
                    Col22,
                    ",",
                    Col23,
                    ",",
                    Col24,
                    ",",
                    Col25,
                    ",",
                    Col26,
                    ",",
                    Col27,
                    ",",
                    Col28,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28, string Col29, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    ",",
                    Col22,
                    ",",
                    Col23,
                    ",",
                    Col24,
                    ",",
                    Col25,
                    ",",
                    Col26,
                    ",",
                    Col27,
                    ",",
                    Col28,
                    ",",
                    Col29,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter = SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort = SortField;
                }
                dgDetails.DataSource = impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FILL_DATAGRID(SqlConnection con, DataGrid dgDetails, string tblTable, string SqlCondition, string Col1, string Col2, string Col3, string Col4, string Col5, string Col6, string Col7, string Col8, string Col9, string Col10, string Col11, string Col12, string Col13, string Col14, string Col15, string Col16, string Col17, string Col18, string Col19, string Col20, string Col21, string Col22, string Col23, string Col24, string Col25, string Col26, string Col27, string Col28, string Col29, string Col30, string SortField)
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Adapter = new SqlDataAdapter(string.Concat(new string[]
                {
                    "SELECT ",
                    Col1,
                    ",",
                    Col2,
                    ",",
                    Col3,
                    ",",
                    Col4,
                    ",",
                    Col5,
                    ",",
                    Col6,
                    ",",
                    Col7,
                    ",",
                    Col8,
                    ",",
                    Col9,
                    ",",
                    Col10,
                    ",",
                    Col11,
                    ",",
                    Col12,
                    ",",
                    Col13,
                    ",",
                    Col14,
                    ",",
                    Col15,
                    ",",
                    Col16,
                    ",",
                    Col17,
                    ",",
                    Col18,
                    ",",
                    Col19,
                    ",",
                    Col20,
                    ",",
                    Col21,
                    ",",
                    Col22,
                    ",",
                    Col23,
                    ",",
                    Col24,
                    ",",
                    Col25,
                    ",",
                    Col26,
                    ",",
                    Col27,
                    ",",
                    Col28,
                    ",",
                    Col29,
                    ",",
                    Col30,
                    " FROM ",
                    tblTable
                }), con);
                impfunc._DTABLE = new DataTable(tblTable);
                impfunc._Adapter.Fill(impfunc._DTABLE);
                impfunc._DV = new DataView(impfunc._DTABLE);
                if (SqlCondition != "")
                {
                    impfunc._DV.RowFilter=SqlCondition;
                }
                if (SortField != "")
                {
                    impfunc._DV.Sort=SortField;
                }
                dgDetails.DataSource=impfunc._DV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

   

        public static void MSGBOX_INFORMATION(string YourMessage,string header)
        {
            MessageBox.Show(YourMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //public static bool MSGBOX_QUESTION(string YourMessage, string header)
        //{
        //    return MessageBox.Show(YourMessage, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //}

        //public static void MSGBOX_UNDERPROCESS()
        //{
        //    MessageBox.Show("UNDER PROCESS !!", "INFOTECH CONSULTANTS", 0, 16);
        //}

        //public static void MSGBOX_CRITICAL(string YourMessage)
        //{
        //    MessageBox.Show(YourMessage.ToUpper(), "INFOTECH CONSULTANTS", 0, 16);
        //}



        //public static void REGISTER_SOFTWARE(string str)
        //{
        //    try
        //    {
        //        RegistryKey registryKey = Registry.Users.CreateSubKey(".Default\\Software\\Microsoft\\Windows\\CurrentVersion\\System32");
        //        registryKey.SetValue("OSI", str);
        //        impfunc.MSGBOX_INFORMATION("Software Registered");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public static void MBX_IC(Color BackColor, Color ForColor, string Caption, string Message)
        //{
        //    try
        //    {
        //        Form form = new MBX_IC();
        //        if (Caption == "")
        //        {
        //            form.set_Text("INFOTECH CONSULTANTS");
        //        }
        //        else
        //        {
        //            form.set_Text(Caption.ToUpper());
        //        }
        //        form.set_BackColor(BackColor);
        //        form.set_ForeColor(ForColor);
        //        form.set_Tag(Message.ToUpper());
        //        form.ShowDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public static void CONNECT_TO_CAMERA(PictureBox pictureBox)
        //{
        //    WiaClass wiaClass = null;
        //    CollectionClass collectionClass = null;
        //    ItemClass itemClass = null;
        //    CollectionClass collectionClass2 = null;
        //    ItemClass itemClass2 = null;
        //    try
        //    {
        //        wiaClass = new WiaClass();
        //        collectionClass = (wiaClass.get_Devices() as CollectionClass);
        //        if (collectionClass == null || collectionClass.get_Count() == 0)
        //        {
        //            MessageBox.Show("No WIA devices found!", "WIA", 0, 16);
        //        }
        //        else
        //        {
        //            object value = Missing.Value;
        //            itemClass = (ItemClass)wiaClass.Create(ref value);
        //            if (itemClass != null)
        //            {
        //                collectionClass2 = (itemClass.GetItemsFromUI(2, 1) as CollectionClass);
        //                if (collectionClass2 != null)
        //                {
        //                    bool flag = true;
        //                    using (IEnumerator enumerator = collectionClass2.GetEnumerator())
        //                    {
        //                        while (enumerator.MoveNext())
        //                        {
        //                            object current = enumerator.get_Current();
        //                            if (flag)
        //                            {
        //                                impfunc.DISPOSEIMAGE(pictureBox);
        //                                itemClass2 = (ItemClass)Marshal.CreateWrapperOfType(current, typeof(ItemClass));
        //                                impfunc.imageFileName = Path.GetTempFileName();
        //                                Cursor.set_Current(Cursors.get_WaitCursor());
        //                                itemClass2.Transfer(impfunc.imageFileName, false);
        //                                pictureBox.set_Image(Image.FromFile(impfunc.imageFileName));
        //                                flag = false;
        //                            }
        //                            Marshal.ReleaseComObject(current);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Acquire from WIA Imaging failed\r\n" + ex.get_Message(), "WIA", 0, 16);
        //    }
        //    finally
        //    {
        //        if (itemClass2 != null)
        //        {
        //            Marshal.ReleaseComObject(itemClass2);
        //        }
        //        if (collectionClass2 != null)
        //        {
        //            Marshal.ReleaseComObject(collectionClass2);
        //        }
        //        if (itemClass != null)
        //        {
        //            Marshal.ReleaseComObject(itemClass);
        //        }
        //        if (collectionClass != null)
        //        {
        //            Marshal.ReleaseComObject(collectionClass);
        //        }
        //        if (wiaClass != null)
        //        {
        //            Marshal.ReleaseComObject(wiaClass);
        //        }
        //        Cursor.set_Current(Cursors.get_Default());
        //    }
        //}

        //public static void DISPOSEIMAGE(PictureBox pictureBox)
        //{
        //    Image image = pictureBox.get_Image();
        //    pictureBox.set_Image(null);
        //    if (image != null)
        //    {
        //        image.Dispose();
        //    }
        //    if (impfunc.imageFileName != null)
        //    {
        //        try
        //        {
        //            File.Delete(impfunc.imageFileName);
        //        }
        //        catch (Exception)
        //        {
        //        }
        //    }
        //}

        //public static void FILL_TREE_VIEW(SqlConnection Con, TreeView trvDetails, string tblTable, string SqlCondition, string Col1, string Col2)
        //{
        //    trvDetails.get_Nodes().Clear();
        //    impfunc._TRVNODE1 = 0;
        //    try
        //    {
        //        if (SqlCondition == "")
        //        {
        //            impfunc._Command = new SqlCommand("Select * From " + tblTable, Con);
        //        }
        //        else
        //        {
        //            impfunc._Command = new SqlCommand("Select * From " + tblTable + " Where " + SqlCondition, Con);
        //        }
        //        Con.Open();
        //        impfunc._DR = impfunc._Command.ExecuteReader();
        //        trvDetails.BeginUpdate();
        //        while (impfunc._DR.Read())
        //        {
        //            if (Col1 != "")
        //            {
        //                trvDetails.get_Nodes().Add(Convert.ToString(impfunc._DR.get_Item(Col1)));
        //            }
        //            else
        //            {
        //                trvDetails.get_Nodes().Add("");
        //            }
        //            if (Col2 != "")
        //            {
        //                trvDetails.get_Nodes().get_Item(impfunc._TRVNODE1).set_Tag(impfunc._DR.get_Item(Col2));
        //            }
        //            else
        //            {
        //                trvDetails.get_Nodes().get_Item(0).set_Tag("");
        //            }
        //            impfunc._TRVNODE1++;
        //        }
        //        trvDetails.EndUpdate();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        Con.Close();
        //        impfunc._DR.Close();
        //    }
        //}
    }
}
