using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using zkemkeeper;

namespace CHBK2014_N9.HumanResource.Core.Machine
{
    public partial class xucReg : XtraUserControl
    {
        public CZKEMClass axCZKEM1 = new CZKEMClass();

        private CZKEMClass czkem;

        private string conn = SqlHelper.ConnectString;

        private int result;

        private bool status;
      

        public xucReg()
        {
            this.InitializeComponent();
            this.Init();
        }

        public xucReg(CZKEMClass czkemClass)
        {
            this.InitializeComponent();
            this.Init();
            this.czkem = czkemClass;
            this.czkem.OnEnrollFinger += new _IZKEMEvents_OnEnrollFingerEventHandler(this.czkem_OnEnrollFinger);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.czkem.CancelOperation();
            if (!(this.txtEnrollNumber.Text == ""))
            {
                this.status = this.czkem.StartEnroll(Convert.ToInt32(this.txtEnrollNumber.Text), 0);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng nhập mã", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtEnrollNumber.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MessageBox.Show("Thiết bị đang  khởi động lại !!", "Thông Báo");
            if (!this.czkem.RestartDevice(1))
            {
                XtraMessageBox.Show("Kiểm tra lại mã máy");
            }
            Application.Restart();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.txtEnrollNumber.Enabled = true;
            this.btnReg.Enabled = true;
        }

        private void czkem_OnEnrollFinger(int EnrollNumber, int FingerIndex, int ActionResult, int TemplateLength)
        {
            SqlConnection sqlConnection;
            SqlCommand text;
            if (ActionResult != 0)
            {
                this.lbStatus.Text = string.Concat(this.txtEmployeeCode.Text, " --- Đăng ký vân tay thất bại ---");
                if (XtraMessageBox.Show("Đăng ký thất bại, đăng ký lại ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.txtEnrollNumber.Enabled = true;
                    this.btnReg.Enabled = true;
                }
                else
                {
                    this.txtEnrollNumber.Enabled = false;
                    this.btnReg.Enabled = false;
                    this.lbStatus.Text = string.Concat(this.txtEmployeeCode.Text, " --- Đăng ký vân tay thất bại ---");
                }
            }
            else
            {
                this.lbStatus.Text = string.Concat(this.txtEmployeeCode.Text, " --- Tiến hành xác nhận vân tay ---");
                Thread.Sleep(1000);
                this.czkem.StartIdentify();
                this.gbList.SetFocusedRowCellValue("EnrollNumber", this.txtEnrollNumber.Text);
                if (XtraMessageBox.Show("Đăng ký thành công , tiếp tục đăng ký ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlConnection = new SqlConnection(this.conn);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "HRM_EMPLOYEE_UpdateEnrollNumber",
                        Connection = sqlConnection
                    };
                    text = sqlCommand;
                    text.Parameters.Add("@EmployeeCode", SqlDbType.VarChar).Value = this.txtEmployeeCode.Text;
                    text.Parameters.Add("@EnrollNumber", SqlDbType.VarChar).Value = this.txtEnrollNumber.Text;
                    text.ExecuteNonQuery();
                    this.txtEnrollNumber.Enabled = true;
                    this.btnReg.Enabled = true;
                }
                else
                {
                    sqlConnection = new SqlConnection(this.conn);
                    sqlConnection.Open();
                    SqlCommand sqlCommand1 = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "HRM_EMPLOYEE_UpdateEnrollNumber",
                        Connection = sqlConnection
                    };
                    text = sqlCommand1;
                    text.Parameters.Add("@EmployeeCode", SqlDbType.VarChar).Value = this.txtEmployeeCode.Text;
                    text.Parameters.Add("@EnrollNumber", SqlDbType.VarChar).Value = this.txtEnrollNumber.Text;
                    text.ExecuteNonQuery();
                    sqlConnection.Close();
                    this.txtEnrollNumber.Enabled = false;
                    this.btnReg.Enabled = false;
                    this.lbStatus.Text = string.Concat(this.txtEmployeeCode.Text, " --- Đăng ký vân tay thành công ---");
                }
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

        private void gbList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.txtEmployeeCode.Text = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
                this.txtEnrollNumber.Text = this.gbList.GetFocusedRowCellValue(this.colEnrollNumber).ToString();
            }
            catch
            {
            }
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (XtraMessageBox.Show("Bạn muốn xóa dữ liệu vân tay của nhân viên này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        int num = Convert.ToInt32(this.gbList.GetFocusedRowCellValue(this.colEnrollNumber));
                        if (!this.czkem.DelUserTmp(1, num, 0))
                        {
                            XtraMessageBox.Show("Không thành công");
                        }
                        else
                        {
                            this.czkem.RefreshData(1);
                            this.gbList.SetFocusedRowCellValue(this.colEnrollNumber, "");
                            SqlConnection sqlConnection = new SqlConnection(this.conn);
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand()
                            {
                                CommandType = CommandType.StoredProcedure,
                                CommandText = "HRM_EMPLOYEE_UpdateEnrollNumber",
                                Connection = sqlConnection
                            };
                            SqlCommand str = sqlCommand;
                            str.Parameters.Add("@EmployeeCode", SqlDbType.VarChar).Value = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
                            str.Parameters.Add("@EnrollNumber", SqlDbType.VarChar).Value = "";
                            str.ExecuteNonQuery();
                            XtraMessageBox.Show("Xóa thành công");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception exception)
            {
            }


        }

        private void Init()
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            this.gcList.DataSource = hRMEMPLOYEE.GetListCurrentNow(0, "", -1);
        }


        private void repositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("reset");
        }

        private void repositoryItemHyperLinkEdit1_OpenLink(object sender, OpenLinkEventArgs e)
        {
            XtraMessageBox.Show("reset");
        }
    }
}
