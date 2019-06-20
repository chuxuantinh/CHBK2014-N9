using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Dictionnary;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core;
using CHBK2014_N9.HumanResource.Core.Class;
//using CHBK2014_N9.Utils.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Machine
{
    public partial class xucAtt : xucBase
    {

        private string m_MachineCode = "";

        private string m_IP = "";

        private string m_Port = "";

        private int m_CountConnectDeviceSuccess = 0;

        private int m_CountConnectDeviceFail = 0;

        private clsMachineOption clsMachineOption = new clsMachineOption();

        private int m_RowRefresh = 0;

        private DataTable EnrollDataTable = HRM_TIMEKEEPER_MACHINE.CreateNullEmployeesDataTable();
       // private RepositoryItemGridLookUpEdit repMachine;


        public xucAtt()
        {
            this.InitializeComponent();
            base.RestoreLayout(this.gbList, this);
            this.InitComponent();
            this.CreateNullDatabase();
            this.InitMachine();
            this.barManager1.SetPopupContextMenu(this.gcList, this.popupMenu1);
        }

        private void gcList_Click(object sender, EventArgs e)
        {

        }

        private void alertControl1_ButtonClick(object sender, AlertButtonClickEventArgs e)
        {
            if (e.ButtonName == "alertView")
            {
                this.InvokeCall();
            }
        }

        private void CreateNullDatabase()
        {
            HRM_TIMEKEEPER_MACHINE hRMTIMEKEEPERMACHINE = new HRM_TIMEKEEPER_MACHINE();
            this.gcList.DataSource = hRMTIMEKEEPERMACHINE.CreateNullDataTable();
        }

        private void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Import();
        }


        public void ImportText()
        {
            //xfmAttImportText _xfmAttImportText = new xfmAttImportText();
            //this.clsMachineOption = new clsMachineOption();
            //if (!this.clsMachineOption.IsAutomaticJoinDataImport)
            //{
            //    _xfmAttImportText.Imported += new xfmAttImportText.ImportedEventHander((object s, DataTable dt) => this.gcList.DataSource = dt);
            //}
            //else
            //{
            //    _xfmAttImportText.ImportedRow += new xfmAttImportText.ImportedRowEventHander((object s, DataRow dr) => this.machineItem_AddRowEvent(this, dr["EnrollNumber"].ToString(), dr["EmployeeCode"].ToString(), dr["EmployeeName"].ToString(), DateTime.Parse(dr["Date"].ToString()), DateTime.Parse(dr["Hour"].ToString()), int.Parse(dr["StateInOut"].ToString()), int.Parse(dr["MachineID"].ToString())));
            //}
         //   _xfmAttImportText.ShowDialog();
        }

        private void InitComponent()
        {
            (new DIC_MACHINE()).AddRepositoryGridLookupEdit(this.repMachine);
            this.repMachine.EditValueChanging += new ChangingEventHandler(this.repMachine_EditValueChanging);
            this.repMachine.EditValueChanged += new EventHandler(this.repMachine_EditValueChanged);
            this.repMachine.ButtonClick += new ButtonPressedEventHandler(this.repMachine_ButtonClick);
            this.bbeCC.EditValue = DateTime.Now;
            this.bbeCCTo.EditValue = DateTime.Now;
            this.dtCC.DateTime = DateTime.Now;
            this.dtCCTo.DateTime = DateTime.Now;
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.DoShowMenu(this.gbList.CalcHitInfo(new Point(e.X, e.Y)), this.gbList, this);
            }
        }

        private void gbList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle == -2147483648)
            {
                e.Handled = true;
                e.Painter.DrawObject(e.Info);
                Rectangle bounds = e.Bounds;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(63, 165, 165, 0)), bounds);
                bounds.Height = bounds.Height - 1;
                bounds.Width = bounds.Width - 1;
                e.Graphics.DrawRectangle(Pens.Blue, bounds);
            }
            int rowHandle = e.RowHandle;
            if (rowHandle >= 0)
            {
                rowHandle++;
                e.Info.DisplayText = rowHandle.ToString();
            }
        }

        private void FindMachine(bool IsResetAll, CHBK2014_N9.Common.Class.Actions Actions, DIC_MACHINE Machine)
        {
          //  xucMachineItem control = null;
            int num = 0;
            try
            {
                num = int.Parse(Machine.Password);
            }
            catch
            {
                num = 0;
            }
            if (!IsResetAll)
            {
                switch (Actions)
                {
                    case CHBK2014_N9.Common.Class.Actions.Add:
                        {
                            this.InitOneMachine(Machine);
                            break;
                        }
                    case CHBK2014_N9.Common.Class.Actions.Update:
                        {
                            foreach (xucMachineItem control in this.flowMachineItem.Controls)
                            {
                                if (Machine.MachineCode == control.MachineCode)
                                {
                                    if (control.IsConnected)
                                    {
                                        control.DisConnect();
                                    }
                                    control.MachineName = Machine.MachineName;
                                    control.IP = Machine.IP;
                                    control.Port = Machine.PortID;
                                    control.Password = num;
                                    control.LoadInterface(true);
                                }
                            }
                            break;
                        }
                    case CHBK2014_N9.Common.Class.Actions.Change:
                        {
                            break;
                        }
                    case CHBK2014_N9.Common.Class.Actions.Delete:
                        {
                            foreach (xucMachineItem _xucMachineItem in this.flowMachineItem.Controls)
                            {
                                if (Machine.MachineCode == _xucMachineItem.MachineCode)
                                {
                                    if (_xucMachineItem.IsConnected)
                                    {
                                        _xucMachineItem.DisConnect();
                                    }
                                    this.flowMachineItem.Controls.Remove(_xucMachineItem);
                                }
                            }
                            break;
                        }
                    default:
                        {
                            goto case CHBK2014_N9.Common.Class.Actions.Change;
                        }
                }
            }
            else
            {
                foreach (xucMachineItem control1 in this.flowMachineItem.Controls)
                {
                    if (!control1.IsConnected)
                    {
                        continue;
                    }
                    control1.DisConnect();
                }
                this.flowMachineItem.Controls.Clear();
                this.InitMachine();
            }
        }

       

        private void dtCC_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dtCC.DateTime != Convert.ToDateTime(this.bbeCC.EditValue.ToString()))
            {
                this.bbeCC.EditValue = this.dtCC.DateTime;
            }
        }

        private void bbeCC_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dtCC.DateTime != Convert.ToDateTime(this.bbeCC.EditValue.ToString()))
            {
                this.dtCC.DateTime = Convert.ToDateTime(this.bbeCC.EditValue.ToString());
            }
        }

        private void bbeCCTo_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dtCCTo.DateTime != Convert.ToDateTime(this.bbeCCTo.EditValue.ToString()))
            {
                this.dtCCTo.EditValue = Convert.ToDateTime(this.bbeCCTo.EditValue.ToString());
            }
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (base.ParentForm != null)
            {
                base.ParentForm.Close();
            }
        }

        private void bbiConnect_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ConnectMultipleDevice();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool flag = false;
            int[] selectedRows = this.gbList.GetSelectedRows();
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                for (int i = (int)selectedRows.Length; i > 0; i--)
                {
                    flag = true;
                    this.gbList.DeleteRow(selectedRows[i - 1]);
                }
                this.DoHide();
                if (!flag)
                {
                    try
                    {
                        this.gbList.DeleteRow(this.gbList.FocusedRowHandle);
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            this._exportView = this.gbList;
           // SYS_LOG.Insert("Danh Sách Nhân Viên", "Xuất");
            base.Export();
        }

        

        private void bbiImport_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Import();
        }

        private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.btUpdate_Click(sender, e);
        }

        private void bbiGetGeneralLogData_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.btGetGeneralLogData_Click(sender, e);
        }
        private void ConnectMultipleDevice()
        {
          //  xucMachineItem control = null;
            if (this.m_CountConnectDeviceSuccess != 0)
            {
                foreach (xucMachineItem control in this.flowMachineItem.Controls)
                {
                    if (control.IsConnected)
                    {
                        control.DisConnect();
                    }
                }
            }
            else
            {
                foreach (xucMachineItem _xucMachineItem in this.flowMachineItem.Controls)
                {
                    _xucMachineItem.Connect();
                }
            }
        }

        private void Count()
        {
            this.lbStatus.Text = "";
            foreach (xucMachineItem control in this.flowMachineItem.Controls)
            {
                if (control.IsConnected)
                {
                    LabelControl labelControl = this.lbStatus;
                    object[] text = new object[] { this.lbStatus.Text, " <color=blue>", control.MachineName, ":</color> <color=red><b>", control.Count(), "</b></color> <color=blue>(dòng)</color> " };
                    labelControl.Text = string.Concat(text);
                }
            }
        }

     
        private void dtCC_EditValueChanged_1(object sender, EventArgs e)
        {
            if (this.dtCC.DateTime != Convert.ToDateTime(this.bbeCC.EditValue.ToString()))
            {
                this.bbeCC.EditValue = this.dtCC.DateTime;
            }
        }

        private void dtCCTo_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dtCCTo.DateTime != Convert.ToDateTime(this.bbeCCTo.EditValue.ToString()))
            {
                this.bbeCCTo.EditValue = this.dtCCTo.DateTime;
            }
        }

     
        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Import()
        {
            //xfmAttImportExcel _xfmAttImportExcel = new xfmAttImportExcel();
            //this.clsMachineOption = new clsMachineOption();
            //if (!this.clsMachineOption.IsAutomaticJoinDataImport)
            //{
            //    _xfmAttImportExcel.Imported += new xfmAttImportExcel.ImportedEventHander((object s, DataTable dt) => this.gcList.DataSource = dt);
            //}
            //else
            //{
            //    _xfmAttImportExcel.ImportedRow += new xfmAttImportExcel.ImportedRowEventHander((object s, DataRow dr) => this.machineItem_AddRowEvent(this, dr["EnrollNumber"].ToString(), dr["EmployeeCode"].ToString(), dr["EmployeeName"].ToString(), DateTime.Parse(dr["Date"].ToString()), DateTime.Parse(dr["Hour"].ToString()), int.Parse(dr["StateInOut"].ToString()), int.Parse(dr["MachineID"].ToString())));
            //}
            //_xfmAttImportExcel.ShowDialog();
        }

        private void InitMachine()
        {
            foreach (DataRow row in (new DIC_MACHINE()).GetList().Rows)
            {
                DIC_MACHINE dICMACHINE = new DIC_MACHINE();
                dICMACHINE.Get(row["MachineCode"].ToString());
                this.InitOneMachine(dICMACHINE);
            }
        }

        private void InitOneMachine(DIC_MACHINE Machine)
        {
            int num = 0;
            try
            {
                num = int.Parse(Machine.Password);
            }
            catch
            {
                num = 0;
            }
            xucMachineItem _xucMachineItem = new xucMachineItem(Machine.MachineCode, Machine.MachineName, Machine.IP, Machine.PortID, num);
            _xucMachineItem.ConnectError += new xucMachineItem.ConnectErrorEventHander(this.machineItem_ConnectError);
            _xucMachineItem.ConnectComplete += new xucMachineItem.ConnectCompleteEventHander(this.machineItem_ConnectComplete);
            _xucMachineItem.DisConnectComplete += new xucMachineItem.DisConnectCompleteEventHander(this.machineItem_DisConnectComplete);
            _xucMachineItem.AddRowEvent += new xucMachineItem.AddRowEventHandler(this.machineItem_AddRowEvent);
            _xucMachineItem.OnTransactionEvent += new xucMachineItem.OnTransactionEventHandler(this.machineItem_OnTransactionEvent);
            _xucMachineItem.Dock = DockStyle.Top;
            _xucMachineItem.Width = this.flowMachineItem.Width - 38;
            this.flowMachineItem.Controls.Add(_xucMachineItem);
        }

        private void InvokeCall()
        {
            xucAtt.CallEventHandler callEventHandler = this.Call;
            if (callEventHandler != null)
            {
                callEventHandler();
            }
        }

        private bool IsExistEnrollDataTable(string EnrollNumber)
        {
            bool flag = false;
            foreach (DataRow row in this.EnrollDataTable.Rows)
            {
                if (row["EnrollNumber"].ToString() == EnrollNumber)
                {
                    flag = true;
                }
            }
            return flag;
        }

        private void LoadInterface()
        {
            this.Cursor = Cursors.Default;
            this.groupConnectInformation.Text = string.Concat("Đang Kết Nối: ", this.m_CountConnectDeviceSuccess, " (Máy)");
            this.groupConnectInformation.Refresh();
            if (this.m_CountConnectDeviceSuccess != 0)
            {
                this.bbiConnect.Caption = "Ngắt Kết Nối Tất Cả";
                this.bbiConnect.ImageIndex = 38;
                this.bbiConnect.Refresh();
                this.bbeCC.Enabled = true;
                this.bbeCCTo.Enabled = true;
                this.dtCC.Enabled = true;
                this.dtCCTo.Enabled = true;
            }
            else
            {
                this.bbiConnect.Caption = "Kết Nối Tất Cả Thiết Bị";
                this.bbiConnect.ImageIndex = 39;
                this.bbiConnect.Refresh();
                this.bbeCC.Enabled = false;
                this.bbeCCTo.Enabled = false;
                this.dtCC.Enabled = false;
                this.dtCCTo.Enabled = false;
            }
        }

        private void machineItem_AddRowEvent(object sender, string EnrollNumber, string EmployeeCode, string EmployeeName, DateTime Date, DateTime Hour, int StateInOut, int MachineID)
        {
            this.m_RowRefresh++;
            if (this.m_RowRefresh == 10)
            {
                this.gcList.Refresh();
                this.m_RowRefresh = 0;
            }
            this.gbList.AddNewRow();
            this.gbList.SetFocusedRowCellValue(this.colEnrollNumber, EnrollNumber);
            this.gbList.SetFocusedRowCellValue(this.colEmployeeCode, EmployeeCode);
            this.gbList.SetFocusedRowCellValue(this.colEmployeeName, EmployeeName);
            this.gbList.SetFocusedRowCellValue(this.colStateInOut, StateInOut);
            this.gbList.SetFocusedRowCellValue(this.colMachineID, MachineID);
            this.gbList.SetFocusedRowCellValue(this.colHour, Hour);
            this.gbList.SetFocusedRowCellValue(this.colDate, Date);
        }

        private void machineItem_ConnectComplete(object sender)
        {
            this.m_CountConnectDeviceSuccess++;
            this.Count();
            this.LoadInterface();
        }

        private void machineItem_ConnectError(object sender, string Message)
        {
            this.m_CountConnectDeviceFail++;
            XtraMessageBox.Show(Message, "Thông Báo");
            this.LoadInterface();
        }

        private void machineItem_DisConnectComplete(object sender)
        {
            this.m_CountConnectDeviceSuccess--;
            this.Count();
            this.LoadInterface();
        }

        private void machineItem_OnTransactionEvent(object sender, string EnrollNumber, string EmployeeCode, string EmployeeName, DateTime Date, DateTime Hour, int StateInOut, int MachineID)
        {
            string[] employeeName;
            this.gcList.Refresh();
            this.gbList.AddNewRow();
            this.gbList.SetFocusedRowCellValue(this.colEnrollNumber, EnrollNumber);
            this.gbList.SetFocusedRowCellValue(this.colEmployeeCode, EmployeeCode);
            this.gbList.SetFocusedRowCellValue(this.colEmployeeName, EmployeeName);
            this.gbList.SetFocusedRowCellValue(this.colStateInOut, StateInOut);
            this.gbList.SetFocusedRowCellValue(this.colMachineID, MachineID);
            this.gbList.SetFocusedRowCellValue(this.colHour, Hour);
            this.gbList.SetFocusedRowCellValue(this.colDate, Date);
            if (this.clsMachineOption.IsShowMessageInOut)
            {
                if (StateInOut != 0)
                {
                    AlertControl alertControl = this.alertControl1;
                    Form parent = base.Parent as Form;
                    employeeName = new string[] { "<color=blue><b>", EmployeeName, " (", EnrollNumber.ToString(), ")</b></color>   <color=blue> 'RA' </color>   lúc ", Hour.ToString() };
                    alertControl.Show(parent, "THông Báo", string.Concat(employeeName));
                }
                else
                {
                    AlertControl alertControl1 = this.alertControl1;
                    Form form = base.Parent as Form;
                    employeeName = new string[] { "<color=blue><b>", EmployeeName, " (", EnrollNumber.ToString(), ")</b></color>   <color=blue> 'VÀO' </color>   lúc ", Hour.ToString() };
                    alertControl1.Show(form, "THông Báo", string.Concat(employeeName));
                }
            }
        }

        private void repMachine_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                (new DIC_MACHINE()).AddRepositoryGridLookupEdit(this.repMachine);
            }
        }

        private void repMachine_EditValueChanged(object sender, EventArgs e)
        {
            DIC_MACHINE dICMACHINE = new DIC_MACHINE();
            dICMACHINE.Get(this.m_MachineCode);
            this.m_IP = dICMACHINE.IP;
            this.m_Port = dICMACHINE.PortID;
        }

        private void repMachine_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.m_MachineCode = e.NewValue.ToString();
        }

        private void UpdateTimekeeper()
        {
            //DataRow row = null;
            Thread thread;
            string[] firstName;
            Options.SetWaitDialogCaption("Đang xóa dữ liệu...");
            HRM_TIMEKEEPER_MACHINE hRMTIMEKEEPERMACHINE = new HRM_TIMEKEEPER_MACHINE();
            hRMTIMEKEEPERMACHINE.DeleteAll();
            int num = 0;
            this.EnrollDataTable.Rows.Clear();
            foreach (DataRow row in (this.gcList.DataSource as DataTable).Rows)
            {
                if (num % 100 == 0)
                {
                    Options.SetWaitDialogCaption(string.Concat("Đang thêm dữ liệu...", row["EnrollNumber"].ToString()));
                }
                num++;
                hRMTIMEKEEPERMACHINE.ID = Guid.NewGuid();
                hRMTIMEKEEPERMACHINE.EnrollNumber = row["EnrollNumber"].ToString();
                hRMTIMEKEEPERMACHINE.Date = Convert.ToDateTime(row["Date"].ToString());
                DateTime dateTime = Convert.ToDateTime(row["Date"].ToString());
                DateTime dateTime1 = Convert.ToDateTime(row["Hour"].ToString());
                hRMTIMEKEEPERMACHINE.Hour = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime1.Hour, dateTime1.Minute, dateTime1.Second);
                hRMTIMEKEEPERMACHINE.StateInOut = Convert.ToInt32(row["StateInOut"].ToString());
                hRMTIMEKEEPERMACHINE.MachineID = row["MachineID"].ToString();
                hRMTIMEKEEPERMACHINE.Insert();
                if (!this.IsExistEnrollDataTable(row["EnrollNumber"].ToString()))
                {
                    DataRowCollection rows = this.EnrollDataTable.Rows;
                    object[] str = new object[] { row["EnrollNumber"].ToString() };
                    rows.Add(str);
                }
            }
            Options.CloseDialog();
            DateTime dateTime2 = Convert.ToDateTime(this.bbeCC.EditValue.ToString());
            DateTime dateTime3 = Convert.ToDateTime(this.bbeCCTo.EditValue.ToString());
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            foreach (DataRow dataRow in this.EnrollDataTable.Rows)
            {
                hRMEMPLOYEE.GetByEnroll(dataRow["EnrollNumber"].ToString());
                HRM_EMPLOYEE_SCHEDULE hRMEMPLOYEESCHEDULE = new HRM_EMPLOYEE_SCHEDULE();
                hRMEMPLOYEESCHEDULE.Get(hRMEMPLOYEE.EmployeeCode);
                if (hRMEMPLOYEESCHEDULE.IsAutomatic)
                {
                    firstName = new string[] { "Đang nhận ca...", hRMEMPLOYEE.FirstName, " ", hRMEMPLOYEE.LastName, "(", hRMEMPLOYEE.EmployeeCode, ")" };
                    Options.SetWaitDialogCaption(string.Concat(firstName));
                    thread = new Thread(() => hRMTIMEKEEPERMACHINE.SetShift(new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day), new DateTime(dateTime3.Year, dateTime3.Month, dateTime3.Day), hRMEMPLOYEE.EmployeeCode));
                    thread.Start();
                    thread.Join();
                }
            }
            Options.CloseDialog();
            foreach (DataRow row1 in hRMEMPLOYEE.GetCompactList(MyLogin.Level, MyLogin.Code, 1, dateTime2, dateTime3).Rows)
            {
                firstName = new string[] { "Đang cập nhật...", row1["FirstName"].ToString(), " ", row1["LastName"].ToString(), "(", row1["EmployeeCode"].ToString(), ")" };
                Options.SetWaitDialogCaption(string.Concat(firstName));
                thread = new Thread(() => hRMTIMEKEEPERMACHINE.UpdateTimeKeeper(new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day), new DateTime(dateTime3.Year, dateTime3.Month, dateTime3.Day), row1["EmployeeCode"].ToString()));
                thread.Start();
                thread.Join();
            }
            Options.CloseDialog();
        }

        private void xtraScrollableControl1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void xucAtt_Load(object sender, EventArgs e)
        {
        }

        public event xucAtt.CallEventHandler Call;

        public delegate void CallEventHandler();

        private void btGetGeneralLogData_Click(object sender, EventArgs e)
        {
            if (this.m_CountConnectDeviceSuccess != 0)
            {
                this.CreateNullDatabase();
                foreach (xucMachineItem control in this.flowMachineItem.Controls)
                {
                    if (control.IsConnected)
                    {
                        control.GetGeneralLogData(true, Convert.ToDateTime(this.bbeCC.EditValue.ToString()), Convert.ToDateTime(this.bbeCCTo.EditValue.ToString()));
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa có thiết bị máy chấm công nào được kết nối!\r\nVui lòng kết nối 1 hoặc nhiều thiết bị bạn có trước khi tải dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (this.gbList.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để thực thi tác vụ này!\r\nVui lòng kết nối để tải dữ liệu từ máy chấm công về hoặc nạp dữ liệu từ tập tin (*.xls) hoặc (*.txt)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.m_CountConnectDeviceSuccess != 0)
            {
                this.UpdateTimekeeper();
            }
            else
            {
                xfmSelectFromDateToDate _xfmSelectFromDateToDate = new xfmSelectFromDateToDate(Convert.ToDateTime(this.bbeCC.EditValue.ToString()), Convert.ToDateTime(this.bbeCCTo.EditValue.ToString()));
                _xfmSelectFromDateToDate.Selected += new xfmSelectFromDateToDate.SelectedEventHander((object s, DateTime FromDate, DateTime ToDate) => {
                    (s as XtraForm).Close();
                    this.bbeCC.EditValue = FromDate;
                    this.bbeCCTo.EditValue = ToDate;
                    this.Refresh();
                    this.UpdateTimekeeper();
                });
                _xfmSelectFromDateToDate.ShowDialog();
            }
        }

        private void btMachine_Click(object sender, EventArgs e)
        {
            xfmMachine _xfmMachine = new xfmMachine();
            _xfmMachine.Added += new xfmMachine.AddedEventHander((object s, DIC_MACHINE i) => this.FindMachine(false, Actions.Add, i));
            _xfmMachine.Updated += new xfmMachine.UpdatedEventHander((object s, DIC_MACHINE i) => this.FindMachine(false, Actions.Update, i));
            _xfmMachine.Deleted += new xfmMachine.DeletedEventHandler((object s, DIC_MACHINE i, CHBK2014_N9.Common.Class.RowClickEventArgs ev) => this.FindMachine(false, Actions.Delete, i));
            _xfmMachine.ShowDialog();
        }
    }
}
