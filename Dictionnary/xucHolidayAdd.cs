using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucHolidayAdd : xucBaseAddH
    {
        private Guid m_HolidayID = Guid.Empty;
        public xucHolidayAdd()
        {
            InitializeComponent();
        }

       

        protected override void Add()
        {
            this.txtName.Focus();
            this.dtFromDate.DateTime = DateTime.Now;
            this.dtToDate.DateTime = DateTime.Now;
            base.Add();

   
        }

        public new void Clear()
        {
            this.txtName.Text = "";
            this.txtDescription.Text = "";
            this.dtFromDate.DateTime = DateTime.Now;
            this.dtToDate.DateTime = DateTime.Now;
        }

        protected override void Init()
        {
        }


        private void RaiseSuccessEventHander(DIC_HOLIDAY item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_HOLIDAY item)
        {
            this.m_HolidayID = item.HolidayID;
            SYS_LOG.Insert("Danh Mục Ngày Nghỉ", "Xem", this.m_HolidayID.ToString());
            this.txtName.Text = item.HolidayName;
            this.dtFromDate.DateTime = item.FromDate;
            this.dtToDate.DateTime = item.ToDate;
            this.txtDescription.Text = item.Description;
        }

        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            DIC_HOLIDAY dICHOLIDAY = new DIC_HOLIDAY()
            {
                HolidayID = this.m_HolidayID
            };
            string str = dICHOLIDAY.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICHOLIDAY);
            }
            return str;
        }

        protected override string uc_Save()
        {
            SYS_LOG.Insert("Danh Mục Ngày Nghỉ", "Thêm", this.m_HolidayID.ToString());
            base.SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            this.m_HolidayID = Guid.NewGuid();
            DIC_HOLIDAY dICHOLIDAY = new DIC_HOLIDAY(this.m_HolidayID, this.txtName.Text, this.dtFromDate.DateTime, this.dtToDate.DateTime, this.txtDescription.Text);
            string str = dICHOLIDAY.Insert();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICHOLIDAY);
            }
            Cursor.Current = Cursors.Default;
            this.DoHide();
            if (str != "OK")
            {
                XtraMessageBox.Show(str, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return str;
        }

        protected override string uc_Update()
        {
            SYS_LOG.Insert("Danh Mục Ngày Nghỉ", "Cập Nhật", this.m_HolidayID.ToString());
            base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            DIC_HOLIDAY dICHOLIDAY = new DIC_HOLIDAY(this.m_HolidayID, this.txtName.Text, this.dtFromDate.DateTime, this.dtToDate.DateTime, this.txtDescription.Text);
            string str = dICHOLIDAY.Update();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICHOLIDAY);
            }
            if (str != "OK")
            {
                XtraMessageBox.Show(str, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.DoHide();
            return str;
        }

        public event xucHolidayAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_HOLIDAY item);
    }
}
