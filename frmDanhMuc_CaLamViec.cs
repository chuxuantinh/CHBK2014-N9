using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHBK2014_N9
{
    public partial class frmDanhMuc_CaLamViec : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMuc_CaLamViec()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_CaLamViec_Load(object sender, EventArgs e)
        {
            CT_SHIFT_GetList();
            txtCode.Text= Get_Code_New();

            #region Khoa Phan quyen
            // thuc hien khoa phan quyen phan quyen
            for (int i = 0; i < barManager1.Items.Count; i++)
            {
                if (barManager1.Items[i].Tag != null)
                {
                    string txt = barManager1.Items[i].Tag.ToString();
                    if (txt.Length > 0)
                    {
                        barManager1.Items[i].Enabled = false;
                    }
                }

            }
            #endregion
            //-----------
            #region mo phan quyen
            for (int i = 0; i < barManager1.Items.Count; i++)
            {
                if (barManager1.Items[i].Tag != null)
                {
                    string txt = barManager1.Items[i].Tag.ToString();
                    if (txt.Length > 0)
                    {
                        for (int l = 0; l < Class.App.dtPermision.Rows.Count; l++)
                        {
                            string _Object_ID = Class.App.dtPermision.Rows[l]["Object_ID"].ToString();
                            if (_Object_ID == txt)
                            {
                                barManager1.Items[i].Enabled = true;
                            }
                        }

                    }
                }

            }
            #endregion
        }


        private  string Get_Code_New()
        {

            Class.DanhMuc_CaLamViec dmclv = new Class.DanhMuc_CaLamViec();
          return  dmclv.GetNewCode();

        }
        public void CT_SHIFT_GetList()
        {
            Class.DanhMuc_CaLamViec dm = new Class.DanhMuc_CaLamViec();
            gridItem.DataSource = dm.CT_SHIFT_GetList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Get_Code_New();
                Loadthongtin();
            UpdateSift();


            //frmDanhMucCaLamViec_Update frm = new frmDanhMucCaLamViec_Update(true, "Thêm Ca làm việc", "Ca", null);
            //frm.Owner = this;
            //frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!btnEdit.Enabled)
                return;
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["ShiftCode"].ToString();
                Class.DanhMuc_CaLamViec dm = new Class.DanhMuc_CaLamViec();
                dm.ShiftCode = _value;
                dm.ShiftName = txtName.Text;
                dm.Description = txtDescription.Text;
                dm.BeginTime = timeBeginTime.Time;
                dm.EndTime = timeEndTime.Time;

               
                    if (dm.Update())
                    { Class.App.SaveSuccessfully(); }
                    else
                    {
                        Class.App.SaveNotSuccessfully();

                    }

                CT_SHIFT_GetList();
                txtCode.Text = Get_Code_New();

             //   frmDanhMucCaLamViec_Update frm = new frmDanhMucCaLamViec_Update(false, "Cập nhật ca làm việc", "Ca", _value);
              //  frm.Owner = this;
             //   frm.ShowDialog();
            }
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["ShiftCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.DanhMuc_CaLamViec dm = new Class.DanhMuc_CaLamViec();
                dm.ShiftCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    CT_SHIFT_GetList();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }

        private void gridItemDetail_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_ItemClick(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void Loadthongtin()
        {


            Class.DanhMuc_CaLamViec dm = new Class.DanhMuc_CaLamViec();
            DataTable dt = dm.GetShiftByCode(txtCode.Text);
            txtCode.Text = dt.Rows[0]["ShiftCode"].ToString();
            txtName.Text = dt.Rows[0]["ShiftName"].ToString();
            timeBeginTime.Time = (DateTime)dt.Rows[0]["BeginTime"];
            timeEndTime.Time = (DateTime)dt.Rows[0]["EndTime"];
            txtDescription.Text = dt.Rows[0]["Description"].ToString();  
        }

        private void UpdateSift()
        {
            Class.DanhMuc_CaLamViec dm = new Class.DanhMuc_CaLamViec();
            dm.ShiftCode= txtCode.Text;
            dm.ShiftName= txtName.Text;
            dm.Description=txtDescription.Text;
            dm.BeginTime = timeBeginTime.Time;
            dm.EndTime = timeEndTime.Time;

            if (txtCode.Enabled==true)
            {
                if (dm.Insert())
                { Class.App.SaveSuccessfully();}
                else
                {
                    Class.App.SaveNotSuccessfully();

                }
            }
            else
                if (dm.Update())
                { Class.App.SaveSuccessfully(); }
                else
                {
                    Class.App.SaveNotSuccessfully();

                }

            CT_SHIFT_GetList();
            txtCode.Text = Get_Code_New();

        }

        private void groupItem_DoubleClick(object sender, EventArgs e)
        {
            
            
        }
    }
}
