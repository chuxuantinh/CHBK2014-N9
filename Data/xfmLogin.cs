using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Microsoft.SqlServer.Management.Smo;
using CHBK2014_N9.Data.Helper;
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
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;


namespace CHBK2014_N9.Data
{
    public partial class xfmLogin : XtraForm
    {

        private string serverParameters = string.Concat(Application.StartupPath, "\\CHBK2014-N9.Data.SQLConfig.xml");

       
          



        public string ConnectionStringParameters
        {
            get
            {
                object[] text = new object[] { this.cbxServer.Text, this.rdgAuthentication.SelectedIndex, this.teLogin.Text, this.tePassword.Text, this.GetServerConnectionString() };
                return string.Format("{0};{1};{2};{3};{4}", text);
            }
        }

        public string MyServer
        {
            get
            {
                return this.cbxServer.Text;
            }
        }

        public string UserName
        {
            get
            {
                return this.cbxServer.Text;
            }
        }

        public xfmLogin()
        {
            this.InitializeComponent();
            xfmLogin _xfmLogin = this;
            _xfmLogin.Runbuzy = (xfmLogin.RunbuzyEventHander)Delegate.Combine(_xfmLogin.Runbuzy, new xfmLogin.RunbuzyEventHander(this.xfmLogin_Runbuzy));
            xfmLogin _xfmLogin1 = this;
            _xfmLogin1.Completed = (xfmLogin.CompleteEventHander)Delegate.Combine(_xfmLogin1.Completed, new xfmLogin.CompleteEventHander(this.xfmLogin_Completed));
            xfmLogin _xfmLogin2 = this;
            _xfmLogin2.Success = (xfmLogin.SuccessEventHander)Delegate.Combine(_xfmLogin2.Success, new xfmLogin.SuccessEventHander(this.xfmLogin_Success));
            this.cbxServer.Text = string.Concat(Environment.MachineName, "\\PERFECT");
            this.ReadCofig();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        //private void btnHelp_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        System.Diagnostics.Process.Start(string.Concat(Application.StartupPath, "\\SetupSQL.wmv"));
        //        base.Close();
        //    }
        //    catch (Exception exception1)
        //    {
        //        Exception exception = exception1;
        //        XtraMessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        //    }
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.btnLogin.Enabled = false;
            if (xfmLogin.CorrectConnection(this.GetServerConnectionString()))
            {
                this.btnLogin.Enabled = true;
                this.SaveConfig(this.cbxServer.Text, this.rdgAuthentication.SelectedIndex, this.teLogin.Text, this.tePassword.Text, "", this.GetServerConnectionString());
                this.RaiseLoginedEventHander(this.GetServerConnectionString());
                this.WriteXml(this.GetServerConnectionString());
                base.Close();
            }
            else
            {
                this.btnLogin.Enabled = true;
            }
        }

        private void btnOrther_Click(object sender, EventArgs e)
        {
            this.Reload();
        }

       

        private void CloseForm()
        {
            base.TopMost = false;
            if (xfmLogin.CorrectConnection(this.GetServerConnectionString()))
            {
                try
                {
                    XmlTextWriter xmlTextWriter = new XmlTextWriter(this.serverParameters, Encoding.UTF8);
                    try
                    {
                        xmlTextWriter.WriteElementString("Parameters", this.ConnectionStringParameters);
                    }
                    finally
                    {
                        if (xmlTextWriter != null)
                        {
                            ((IDisposable)xmlTextWriter).Dispose();
                        }
                    }
                }
                catch
                {
                }
            }
        }

        public static bool CorrectConnection(string serverConnectionString)
        {
            bool flag;
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

        private void Disable(bool disable)
        {
            this.trlServer.Enabled = disable;
            this.cbxServer.Enabled = disable;
            this.rdgAuthentication.Enabled = disable;
            this.btnLogin.Enabled = disable;
            this.btnCancel.Enabled = disable;
        //    this.btnHelp.Enabled = disable;
         //   this.picRefreshserver.Enabled = disable;
        }

        private void DisableSQLServerAuthentication(bool disable)
        {
            this.teLogin.Enabled = !disable;
            this.tePassword.Enabled = !disable;
        }

      

        public string GetDataBaseConnectionString()
        {
            return string.Concat(this.GetServerConnectionString(), ";");
        }

        private string GetServerConnectionString()
        {
            string str = string.Format("data source={0};integrated security=SSPI;Initial Catalog=HRMExample;", this.cbxServer.Text);
            if (this.rdgAuthentication.SelectedIndex == 1)
            {
                str = string.Format("server={0};user id={1};password={2};", this.cbxServer.Text, this.teLogin.Text, this.tePassword.Text);
            }
            return str;
        }

     

        private void loadserver()
        {
            if (xfmLogin.CorrectConnection(this.GetServerConnectionString()))
            {
                this.RaiseSuccessEventHander(this.GetServerConnectionString());
            }
            else
            {
                try
                {
                    this.RaiseDatabasedEventHander(SmoApplication.EnumAvailableSqlServers(true));
                }
                catch
                {
                }
                this.RaiseCompleteEventHander();
            }
        }

        public void login()
        {
            this.CloseForm();
            this.RaiseLoginedEventHander(this.GetServerConnectionString());
            base.Close();
        }

        private void picRefreshserver_MouseHover(object sender, EventArgs e)
        {
            this.picRefreshserver.BorderStyle = BorderStyles.UltraFlat;
        }

        private void picRefreshserver_MouseLeave(object sender, EventArgs e)
        {
            this.picRefreshserver.BorderStyle = BorderStyles.NoBorder;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DisableSQLServerAuthentication(this.rdgAuthentication.SelectedIndex == 0);
        }

        private void RaiseCompleteEventHander()
        {
            if (this.Completed != null)
            {
                this.Completed(this);
            }
        }

        private void RaiseDatabasedEventHander(DataTable data)
        {
            if (this.Databased != null)
            {
                this.Databased(this, data);
            }
        }

        private void RaiseDoShowEventHander()
        {
            if (this.DoShow != null)
            {
                this.DoShow(this);
            }
        }

        private void RaiseLoginedEventHander(string connecstring)
        {
            if (this.Logined != null)
            {
                this.Logined(this, connecstring);
            }
        }

        private void RaiseProcessEventHander(string Message)
        {
            if (this.Process != null)
            {
                this.Process(this, Message);
            }
        }

        private void RaiseRunbuzyEventHander()
        {
            if (this.Runbuzy != null)
            {
                this.Runbuzy(this);
            }
        }

        private void RaiseStartedEventHander()
        {
            if (this.Started != null)
            {
                this.Started(this);
            }
        }

        private void RaiseSuccessEventHander(string connectString)
        {
            if (this.Success != null)
            {
                this.Success(this, connectString);
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
            if ((new FileInfo(this.serverParameters)).Exists)
            {
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dataTable);
                dataSet.ReadXml(this.serverParameters, XmlReadMode.Auto);
                try
                {
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        sqlHelper.Server = dataSet.Tables[0].Rows[0]["server"].ToString();
                        sqlHelper.Authentication = (Convert.ToInt32(dataSet.Tables[0].Rows[0]["auth"]) == 0 ? true : false);
                        //   sqlHelper.UserID = MyEncryption.Decrypt(dataSet.Tables[0].Rows[0]["user"].ToString(), "963147", true);
                        // sqlHelper.Password = MyEncryption.Decrypt(dataSet.Tables[0].Rows[0]["pass"].ToString(), "963147", true);
                        // sqlHelper.Database = dataSet.Tables[0].Rows[0]["database"].ToString();
                        //  sqlHelper.ConnectionString = MyEncryption.Decrypt(dataSet.Tables[0].Rows[0]["ConnectString"].ToString(), "963147", true);

                           sqlHelper.UserID =dataSet.Tables[0].Rows[0]["user"].ToString();
                        sqlHelper.Password = dataSet.Tables[0].Rows[0]["pass"].ToString();
                         sqlHelper.Database = dataSet.Tables[0].Rows[0]["database"].ToString();
                          sqlHelper.ConnectionString = dataSet.Tables[0].Rows[0]["ConnectString"].ToString();


                        this.cbxServer.Text = sqlHelper.Server;
                        this.teLogin.Text = sqlHelper.UserID;
                        this.tePassword.Text = sqlHelper.Password;
                        this.rdgAuthentication.SelectedIndex = (sqlHelper.Authentication ? 0 : 1);
                        this.radioGroup1_SelectedIndexChanged(this.rdgAuthentication, EventArgs.Empty);
                        connectionString = sqlHelper.ConnectionString;
                        return connectionString;
                    }
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    XtraMessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                connectionString = "";
            }
            else
            {
                connectionString = "";
            }
            return connectionString;
        }

        public void Reload()
        {
            xfmLogin _xfmLogin = this;
            _xfmLogin.Completed = (xfmLogin.CompleteEventHander)Delegate.Combine(_xfmLogin.Completed, new xfmLogin.CompleteEventHander(this.xfmLogin_Completed));
            xfmLogin _xfmLogin1 = this;
            _xfmLogin1.Databased = (xfmLogin.DatabasedEventHander)Delegate.Combine(_xfmLogin1.Databased, new xfmLogin.DatabasedEventHander(this.xfmLogin_Databased));
            this.Disable(false);
          //  this.spWait.Active = true;
        //    this.spWait.Visible = true;
            (new Thread(new ThreadStart(this.loadserver))).Start();
        }

        private void RunRotate()
        {
            this.RaiseRunbuzyEventHander();
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
                object[] objArray = new object[] { server, auth, user, pass, database, connecstring };
                rows.Add(objArray);
                dataSet.Tables.Add(dataTable);
                dataSet.WriteXml(this.serverParameters);
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                XtraMessageBox.Show(exception.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ShowParameters()
        {
            if (File.Exists(this.serverParameters))
            {
                XmlDocument xmlDocument = new XmlDocument();
                try
                {
                    xmlDocument.Load(this.serverParameters);
                    if (xmlDocument.DocumentElement.Name == "Parameters")
                    {
                        string[] strArrays = xmlDocument.DocumentElement.InnerText.Split(new char[] { ';' });
                        this.cbxServer.Text = strArrays[0];
                        this.teLogin.Text = strArrays[2];
                        this.tePassword.Text = strArrays[3];
                    }
                }
                catch
                {
                    File.Delete(this.serverParameters);
                }
            }
        }

        private void tmrRotate_Tick(object sender, EventArgs e)
        {
            this.picRefreshserver.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
        }

        private void trlServer_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            string str = e.Node.GetValue(this.tlcServer).ToString();
            if (!(str == "Máy Chủ"))
            {
                this.cbxServer.Text = str;
            }
            else
            {
                this.cbxServer.Text = string.Concat(Environment.MachineName, "\\PERFECT");
                if (!e.Node.HasChildren)
                {
                    this.loadserver();
                    this.trlServer.ExpandAll();
                }
            }
        }

        public void WriteXml(string str)
        {
            try
            {
                string str1 = string.Concat(Application.StartupPath, "\\sqlconfig.xml");
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(str1);
                ((XmlElement)xmlDocument.SelectSingleNode("//SQL")).SetAttribute("ConnectionString", str);
                xmlDocument.Save(str1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void xfmLogin_Completed(object sender)
        {
            if (!this.trlServer.InvokeRequired)
            {
                this.trlServer.ExpandAll();
                this.Disable(true);
             //   this.spWait.Visible = false;
               // this.spWait.Active = false;
                this.RaiseDoShowEventHander();
            }
            else
            {
                xfmLogin.CompleteEventHander completeEventHander = new xfmLogin.CompleteEventHander(this.xfmLogin_Completed);
                object[] objArray = new object[] { sender };
                base.Invoke(completeEventHander, objArray);
            }
        }

        private void xfmLogin_Databased(object sender, DataTable data)
        {
            object[] item;
            if (!this.trlServer.InvokeRequired)
            {
                this.trlServer.Nodes[0].Nodes.Clear();
                DataTable dataTable = data;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    this.cbxServer.Properties.Items.Add(dataTable.Rows[i]["Name"]);
                    TreeList treeList = this.trlServer;
                    item = new object[] { dataTable.Rows[i]["Name"] };
                    treeList.AppendNode(item, 0, 41, 41, -1);
                }
                if (this.cbxServer.Properties.Items.Count > 0)
                {
                    this.cbxServer.SelectedIndex = 0;
                }
            //    this.spWait.Visible = false;
                this.Disable(true);
            }
            else
            {
                xfmLogin.DatabasedEventHander databasedEventHander = new xfmLogin.DatabasedEventHander(this.xfmLogin_Databased);
                item = new object[] { sender, data };
                base.Invoke(databasedEventHander, item);
            }
        }

        private void xfmLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void xfmLogin_Runbuzy(object sender)
        {
            if (!this.picRefreshserver.InvokeRequired)
            {
                this.picRefreshserver.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            }
            else
            {
                xfmLogin.RunbuzyEventHander runbuzyEventHander = new xfmLogin.RunbuzyEventHander(this.xfmLogin_Runbuzy);
                object[] objArray = new object[] { sender };
                base.Invoke(runbuzyEventHander, objArray);
            }
        }

        private void xfmLogin_Success(object sender, string connectString)
        {
            //if (!this.spWait.InvokeRequired)
            //{
            //    this.RaiseLoginedEventHander(connectString);
            //    base.Close();
            //}
            //else
            //{
                xfmLogin.SuccessEventHander successEventHander = new xfmLogin.SuccessEventHander(this.xfmLogin_Success);
                object[] objArray = new object[] { sender, connectString };
                base.Invoke(successEventHander, objArray);
           // }
        }

        public event xfmLogin.CompleteEventHander Completed;

        private event xfmLogin.DatabasedEventHander Databased;

        public event xfmLogin.DoShowEventHander DoShow;

        public event xfmLogin.LoginedEventHander Logined;

        private event xfmLogin.ProcessEventHander Process;

        public event xfmLogin.RunbuzyEventHander Runbuzy;

        private event xfmLogin.StartedEventHander Started;

        public event xfmLogin.SuccessEventHander Success;

        public delegate void CompleteEventHander(object sender);

        private delegate void DatabasedEventHander(object sender, DataTable data);

        public delegate void DoShowEventHander(object sender);

        public delegate void LoginedEventHander(object sender, string connecstring);

        private delegate void ProcessEventHander(object sender, string Message);

        public delegate void RunbuzyEventHander(object sender);

        private delegate void StartedEventHander(object sender);

        public delegate void SuccessEventHander(object sender, string connectString);

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.btnLogin.Enabled = false;
            if (xfmLogin.CorrectConnection(this.GetServerConnectionString()))
            {
                this.btnLogin.Enabled = true;
                this.SaveConfig(this.cbxServer.Text, this.rdgAuthentication.SelectedIndex, this.teLogin.Text, this.tePassword.Text, "", this.GetServerConnectionString());
                this.RaiseLoginedEventHander(this.GetServerConnectionString());
                this.WriteXml(this.GetServerConnectionString());
                base.Close();
            }
            else
            {
                this.btnLogin.Enabled = true;
            }
        }

        private void cbxServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnLogin_Click(this, null);
            }
        }

        private void picRefreshserver_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void trlServer_FocusedNodeChanged_1(object sender, FocusedNodeChangedEventArgs e)
        {
            string str = e.Node.GetValue(this.tlcServer).ToString();
            if (!(str == "Máy Chủ"))
            {
                this.cbxServer.Text = str;
            }
            else
            {
                this.cbxServer.Text = string.Concat(Environment.MachineName, "\\PERFECT");
                if (!e.Node.HasChildren)
                {
                    this.loadserver();
                    this.trlServer.ExpandAll();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
         
            if (this.IsConnecttion(this.cbxServer.Text, "HRMExample", this.teLogin.Text, this.tePassword.Text))
            {
                XtraMessageBox.Show("Kết nối đến máy chủ thành công!");
            }
          
            Cursor.Current = Cursors.Default;
        }

        private bool IsConnecttion(string server, string database, string user, string pass)
        {
            bool flag;
            SqlHelper sqlHelper = new SqlHelper(server, database, user, pass, (this.rdgAuthentication.SelectedIndex == 0 ? true : false));
            if (sqlHelper.Check())
            {
                flag = true;
            }
            else
            {
                XtraMessageBox.Show(string.Concat("Không thể kết nối đến máy chủ.", sqlHelper.Result), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = false;
            }
            return flag;
        }
    }
}
