using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.XtraReports.UI;

namespace CHBK2014_N9
{
    public partial class FrmDanhSach_HopDong : DevExpress.XtraEditors.XtraForm
    {
        public FrmDanhSach_HopDong()
        {
            InitializeComponent();
        }

        private void FrmDanhSach_HopDong_Load(object sender, EventArgs e)
        {
            Get_Contract();
        }

        private void Get_Contract()
        {
            Class.DanhMuc_HopDong dmhd = new Class.DanhMuc_HopDong();
            DataTable dthd = dmhd.CT_CONTRACT_GetList();
                gridItem.DataSource=dthd;
           

        }

        private void cboTrangThai_EditValueChanged(object sender, EventArgs e)
        {
            if (cboTrangThai.EditValue == null)
            {
                cboTrangThai.EditValue = "[Tất cả]";
            }
            switch (cboTrangThai.EditValue.ToString())
            {
                case "[Tất cả]":
                    //xulyloaddsHopDong(treeListCoCauToChuc.FocusedNode.GetDisplayText(1), -1);
                    break;
                case "[Danh sách hợp đồng hiện tại]":
                   // xulyloaddsHopDong("HDHT", -1);
                    break;
                case "[Danh sách hợp đồng sắp hết hạn (30 Ngày)]":
                   // xulyloaddsHopDong("30Ngay", -1);
                    break;
                case "[Danh sách hợp đồng đã hết hạn]":
                   // xulyloaddsHopDong("HetHan", -1);
                    break;
            }
        }

        private void btnAddHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhSach_HopDong_ThemMoi frm = new frmDanhSach_HopDong_ThemMoi();
            frm.ShowDialog();
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                int waitIndex = 0;
                Waiting.ShowWaitForm();
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["ContractCode"].ToString();
                Class.DanhMuc_HopDong hd = new Class.DanhMuc_HopDong();
                hd.ContractCode = _value;
                DataTable dt = hd.CT_CONTRACT_GetPrintByCode();
                if (_value.IndexOf("HDTV") > 0)
                {
                    // Reports.reportHoDongThuViec rp = new Reports.reportHoDongThuViec();
                    // rp.DataSource = dt;
                    // rp.ShowDesigner();
                    // rp.ShowPreviewDialog();
                }
                else
                {

                    Reports.reportHopDongLaoDong report = new Reports.reportHopDongLaoDong(dt);
                    report.DataSource = dt;
                    Waiting.CloseWaitForm();
                    waitIndex = 1;
                   report.ShowPreviewDialog();


                     report.ShowDesigner();
                    Class.S_Log.Insert("Hợp đồng", "Xem trang In Hợp đồng lao động: " + _value);
                }
                if (waitIndex != 1)
                    Waiting.CloseWaitForm();
            }



        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //  chinh sua thong tin hop dong o day
        }
    }
}
