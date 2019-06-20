using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.ERP;
//using CHBK2014_N9.Update.Process;
using CHBK2014_N9.Utils;
//using CHBK2014_N9.Utils.App;
//using CHBK2014_N9.Utils.Security2;
//using CHBK2014_N9.Utils.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace CHBK2014_N9.Logonui
{
    public partial class xfmLoginClassic : XtraForm
    {

        private readonly string _serverParameters = string.Concat(Application.StartupPath, "\\CHBK2014-N9.Data.SQLConfig"); // config/xml

        private string _mConnectString = "";

        private int solanDangNhap = 0;

        private bool _islogin = false;

        public string MConnectString
        {
            get
            {
                return this._mConnectString;
            }
        }


        //public xfmLoginClassic()
        //{
        //    InitializeComponent();
        //}


        public xfmLoginClassic()
        {
            this.InitializeComponent();
      //      this.InitMultiLanguages();
            xfmLoginClassic _xfmLoginClassic = this;
            _xfmLoginClassic.AddUser = (xfmLoginClassic.AddUserEventHander)Delegate.Combine(_xfmLoginClassic.AddUser, new xfmLoginClassic.AddUserEventHander(this.xfmLoginClassic_AddUser));
            xfmLoginClassic _xfmLoginClassic1 = this;
            _xfmLoginClassic1.UserAdded = (xfmLoginClassic.UserAddedEventHander)Delegate.Combine(_xfmLoginClassic1.UserAdded, new xfmLoginClassic.UserAddedEventHander(this.xfmLoginClassic_UserAdded));
           // this.Text = MyAssembly.AssemblyProduct;
            this.txtUserName.Focus();
            this.readRemember();
           // this.CheckUpdate();
        }

        public event xfmLoginClassic.AddUserEventHander AddUser;

        public event xfmLoginClassic.ErrorEventHander Error;

        public event xfmLoginClassic.FinishEventHander Finish;

        public event xfmLoginClassic.FirstEventHander First;

        public event xfmLoginClassic.LoginSuccessEventHander LoginSuccess;

        public event xfmLoginClassic.UserAddedEventHander UserAdded;

        public delegate void AddUserEventHander(object sender, string username);

        public delegate void ErrorEventHander(object sender, string message);

        public delegate void FinishEventHander(object sender, string connecstring);

        public delegate void FirstEventHander(object sender, string connectString);

        public delegate void LoginSuccessEventHander(object sender);

        public delegate void UserAddedEventHander(object sender);

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            MyLogin myLogin = new MyLogin();
            MyLogin.LoginDate = DateTime.Now;
            this.btnLogin.Enabled = false;
            if (this.txtUserName.Text.Trim() == "")
            {
                this.txtUserName.ErrorText = "Bạn chưa nhập tài khoản!";
                this.Err.SetIconAlignment(this.txtUserName, ErrorIconAlignment.MiddleRight);
                this.btnLogin.Enabled = true;
                this.txtUserName.Focus();
                Cursor.Current = Cursors.Default;
            }
            else if (this.CorrectConnection(SqlHelper.ConnectString))
            {
                string str = MyLogin.CheckAccount(this.txtUserName.Text, this.txtPassword.Text);
                if (!(str != "OK"))
                {
                    SYS_USER sYSUSER = new SYS_USER();
                    if (sYSUSER.Get_UserName(this.txtUserName.Text) == "OK")
                    {
                        MyLogin.UserId = sYSUSER.UserID;
                        MyLogin.Account = this.txtUserName.Text;
                        MyLogin.AccountName = sYSUSER.UserName;
                        MyLogin.RoleId = sYSUSER.Group_ID;
                        MyLogin.Level = sYSUSER.Management;
                        if (sYSUSER.Management == 0)
                        {
                            MyLogin.Code = "";
                        }
                        else if (sYSUSER.Management == 1)
                        {
                            MyLogin.Code = sYSUSER.SubsidiaryCode;
                        }
                        else if (sYSUSER.Management == 2)
                        {
                            MyLogin.Code = sYSUSER.BranchCode;
                        }
                        else if (sYSUSER.Management != 3)
                        {
                            MyLogin.Code = sYSUSER.GroupCode;
                        }
                        else
                        {
                            MyLogin.Code = sYSUSER.DepartmentCode;
                        }
                        MyLogin.EmployeeCode = sYSUSER.EmployeeCode;
                    }
                    if (!this.chxRemember.Checked)
                    {
                        this.saveNullRemember();
                    }
                    else
                    {
                        this.saveRemember();
                    }
                    base.Hide();
                    this._islogin = true;
                    Cursor.Current = Cursors.Default;
                    this.RaiseLoginSuccessEventHander();
                    base.Close();
                }
                else
                {
                    XtraMessageBox.Show(this, str, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.solanDangNhap++;
                    if (this.solanDangNhap >= 3)
                    {
                        XtraMessageBox.Show(this, "Bạn đã nhập sai quá số lần cho phép!\n\nPhần mềm sẽ tự động kết thúc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        base.Close();
                        Cursor.Current = Cursors.Default;
                        Environment.Exit(0);
                        Application.ExitThread();
                    }
                }
                this.btnLogin.Enabled = true;


            }
            else
            {
                this.btnLogin.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
          //  (new xfmDatabaseConfig()).Show(this);
        }


      
        public bool CorrectConnection(string serverConnectionString)
        {
            bool flag =true;
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection sqlConnection = new SqlConnection(serverConnectionString);
            try
            {
                try
                {
                    try
                    {
                        sqlConnection.Open();
                        sqlConnection.Close();
                    }
                    catch
                    {
                        XtraMessageBox.Show(this, "Không thể kết nối với máy chủ à cu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        flag = false;
                        return flag;
                    }
                }
                finally
                {
                    Cursor.Current = current;
                }
            }
            finally
            {
                if (sqlConnection != null)
                {
                    ((IDisposable)sqlConnection).Dispose();
                }
            }
            flag = true;
            return flag;
        }


        public void GetUsers()
        {
            DataTable list = (new SYS_USER()).GetList();
            if (list != null)
            {
                for (int i = 0; i < list.Rows.Count; i++)
                {
                    if (list.Rows[i]["Group_ID"].ToString() != "employee")
                    {
                        this.RaiseAddUserEventHander(list.Rows[i]["UserName"].ToString());
                    }
                }
            }
            this.RaiseUserAddedEventHander();
        }


        private void RaiseAddUserEventHander(string username)
        {
            xfmLoginClassic.AddUserEventHander addUserEventHander = this.AddUser;
            if (addUserEventHander != null)
            {
                addUserEventHander(this, username);
            }
        }

        private void RaiseErrorEventHander(string message)
        {
            if (this.Error != null)
            {
                this.Error(this, message);
            }
        }

        private void RaiseFinishEventHander(string connecstring)
        {
            if (this.Finish != null)
            {
                this.Finish(this, connecstring);
            }
        }

        private void RaiseFirstEventHander(string connectString)
        {
            if (this.First != null)
            {
                this.First(this, connectString);
            }
        }

        private void RaiseLoginSuccessEventHander()
        {
            if (this.LoginSuccess != null)
            {
                this.LoginSuccess(this);
            }
        }

        private void RaiseUserAddedEventHander()
        {
            xfmLoginClassic.UserAddedEventHander userAddedEventHander = this.UserAdded;
            if (userAddedEventHander != null)
            {
                userAddedEventHander(this);
            }
        }

        private string ReadCofig()
        {
            string connectionString;
            DataTable dataTable = new DataTable("SERVER");
            dataTable.Columns.Add("server");
            dataTable.Columns.Add("auth");
            dataTable.Columns.Add("user");
            dataTable.Columns.Add("pass");
            dataTable.Columns.Add("database");
            dataTable.Columns.Add("ConnectString");
            SqlHelper sqlHelper = new SqlHelper();
            if ((new FileInfo(this._serverParameters)).Exists)
            {
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dataTable);
                dataSet.ReadXml(this._serverParameters, XmlReadMode.Auto);
                try
                {
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        sqlHelper.Server = dataSet.Tables[0].Rows[0]["server"].ToString();
                        sqlHelper.Authentication = (Convert.ToInt32(dataSet.Tables[0].Rows[0]["auth"]) == 1 ? true : false);
                        sqlHelper.UserID = dataSet.Tables[0].Rows[0]["user"].ToString();
                        sqlHelper.Password = dataSet.Tables[0].Rows[0]["pass"].ToString();
                        sqlHelper.Database = dataSet.Tables[0].Rows[0]["database"].ToString();
                        sqlHelper.ConnectionString =dataSet.Tables[0].Rows[0]["ConnectString"].ToString();
                        connectionString = sqlHelper.ConnectionString;
                        return connectionString;
                    }
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    XtraMessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.RaiseErrorEventHander(exception.Message);
                }
                connectionString = "";
            }
            else
            {
                connectionString = "";
            }
            return connectionString;
        }

        private void readRemember()
        {
            DataTable dataTable = new DataTable("account");
            dataTable.Columns.Add("user");
            dataTable.Columns.Add("pass");
            if ((new FileInfo(string.Concat(Application.StartupPath, "\\account.xml"))).Exists)
            {
                this.chxRemember.Checked = true;
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dataTable);
                try
                {
                    dataSet.ReadXml(string.Concat(Application.StartupPath, "\\account.xml"));
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        this.txtUserName.Text = dataSet.Tables[0].Rows[0]["user"].ToString();
                        this.txtPassword.Text =dataSet.Tables[0].Rows[0]["pass"].ToString();
                    }
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    XtraMessageBox.Show(this, exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                if (!(this.txtPassword.Text != ""))
                {
                    this.chxRemember.Checked = false;
                }
                else
                {
                    this.chxRemember.Checked = true;
                }
            }
        }

        public void SaveConfig(string server, int auth, string user, string pass, string database, string connecstring)
        {
            try
            {
                DataSet dataSet = new DataSet();
                DataTable dataTable = new DataTable("SERVER");
                dataTable.Columns.Add("server");
                dataTable.Columns.Add("auth");
                dataTable.Columns.Add("user");
                dataTable.Columns.Add("pass");
                dataTable.Columns.Add("database");
                dataTable.Columns.Add("ConnectString");
                dataTable.Rows.Clear();
                DataRowCollection rows = dataTable.Rows;
                object[] objArray = new object[] { server, auth, user, pass, database,connecstring };
                rows.Add(objArray);
                dataSet.Tables.Add(dataTable);
                dataSet.WriteXml(this._serverParameters);
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                XtraMessageBox.Show(exception.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void saveNullRemember()
        {
            try
            {
                DataSet dataSet = new DataSet();
                DataTable dataTable = new DataTable("account");
                dataTable.Columns.Add("user");
                dataTable.Columns.Add("pass");
                dataTable.Rows.Clear();
                DataRowCollection rows = dataTable.Rows;
                object[] objArray = new object[] {this.txtUserName.Text, "" };
                rows.Add(objArray);
                dataSet.Tables.Add(dataTable);
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\account.xml"));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                XtraMessageBox.Show(this, exception.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void saveRemember()
        {
            try
            {
                DataSet dataSet = new DataSet();
                DataTable dataTable = new DataTable("account");
                dataTable.Columns.Add("user");
                dataTable.Columns.Add("pass");
                dataTable.Rows.Clear();
                DataRowCollection rows = dataTable.Rows;
                object[] objArray = new object[] {this.txtUserName.Text, this.txtPassword.Text };
                rows.Add(objArray);
                dataSet.Tables.Add(dataTable);
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\account.xml"));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                XtraMessageBox.Show(this, exception.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        //private void ShowUpdateStatus(bool Show)
        //{
        //    if (CheckUpdate.CheckUpdateVersion())
        //    {
        //        if (!Show)
        //        {
        //            this.Update();
        //        }
        //        else
        //        {
        //            base.Height = 244;
        //            this.pnUpdateContent.Visible = true;
        //        }
        //    }
        //}

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnLogin_Click(sender, e);
            }
        }

        private void txtUserName_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (this.txtUserName.Properties.Items.Count == 0)
            {
                if (e.Button.Index == 0)
                {
                    //this.spWait.Active = true;
                    //this.spWait.Visible = true;
                    this.txtUserName.Enabled = false;
                 //   this.lblWait.Visible = true;
                    (new Thread(() => this.GetUsers())).Start();
                }
            }
        }

        private void xfmLoginClassic_AddUser(object sender, string username)
        {
            if (!this.txtUserName.InvokeRequired)
            {
                this.txtUserName.Properties.Items.Add(username);
            }
            else
            {
                xfmLoginClassic.AddUserEventHander addUserEventHander = new xfmLoginClassic.AddUserEventHander(this.xfmLoginClassic_AddUser);
                object[] objArray = new object[] { sender, username };
                base.Invoke(addUserEventHander, objArray);
            }
        }


        private void xfmLoginClassic_UserAdded(object sender)
        {
            if (!this.txtUserName.InvokeRequired)
            {
                //this.spWait.Active = false;
                //this.spWait.Visible = false;
                this.txtUserName.Enabled = true;
              //  this.lblWait.Visible = false;
                this.txtUserName.SelectedIndex = 0;
            }
            else
            {
                xfmLoginClassic.UserAddedEventHander userAddedEventHander = new xfmLoginClassic.UserAddedEventHander(this.xfmLoginClassic_UserAdded);
                object[] objArray = new object[] { sender };
                base.Invoke(userAddedEventHander, objArray);
            }
        }
    }
}
