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
    public partial class frmDanhmuc_Form :  DevExpress.XtraEditors.XtraForm
    {
        public frmDanhmuc_Form()
        {
            InitializeComponent();
        }

        private void pControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDanhmuc_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnCallDanhMucChucVu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhMuc_ChucVu"))
            {
                frmDanhMuc_ChucVu frm = new frmDanhMuc_ChucVu();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private bool _checkControl(string frmForm)
        {
            for (int i = 0; i < pControls.Controls.Count; i++)
            {
                if (pControls.Controls[i].Text == frmForm)
                {
                    pControls.Controls[i].Show();
                    // pControls.Controls[i].Size = new System.Drawing.Size(pControls.Width, pControls.Height);
                    return true;
                }
                else
                {
                    pControls.Controls[i].Hide();
                }
            }
            return false;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnCallDanhMucChucVu_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhMuc_ChucVu"))
            {
                frmDanhMuc_ChucVu frm = new frmDanhMuc_ChucVu();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void navBarMenu_Click_1(object sender, EventArgs e)
        {

        }

        private void pControls_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCallDanhMucChuyenMon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhMuc_ChuyenMon"))
            {
                frmDanhMuc_ChuyenMon frm = new frmDanhMuc_ChuyenMon();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhMucBangCap_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhmuc_Bangcap"))
            {
                frmDanhmuc_Bangcap frm = new frmDanhmuc_Bangcap();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhMucQuocTich_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhmuc_QuocGia"))
            {
                frmDanhmuc_QuocGia frm = new frmDanhmuc_QuocGia();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhMucKyNang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhMuc_KyNang"))
            {
                frmDanhMuc_KyNang frm = new frmDanhMuc_KyNang();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhMucDanToc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhMuc_DantToc"))
            {
                frmDanhMuc_DantToc frm = new frmDanhMuc_DantToc();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhMucTonGiao_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhmuc_Tongiao"))
            {
                frmDanhmuc_Tongiao frm = new frmDanhmuc_Tongiao();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhMucQuanHeGiaDinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhMuc_GiaDinh"))
            {
                frmDanhMuc_GiaDinh frm = new frmDanhMuc_GiaDinh();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhMucHocVan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhmuc_Hocvan"))
            {
                frmDanhmuc_Hocvan frm = new frmDanhmuc_Hocvan();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhMucTinHoc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhmuc_Hocvan"))
            {
                frmDanhMuc_TinHoc frm = new frmDanhMuc_TinHoc();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhMucNgoaiNgu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhmuc_Hocvan"))
            {
                frmDanhmuc_Ngoaingu frm = new frmDanhmuc_Ngoaingu();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhSachChiNhanh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
          //  Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhMuc_ChiNhanh"))
            {
                frmDanhMuc_ChiNhanh frm = new frmDanhMuc_ChiNhanh();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
           
     
   
        }

        private void btnCallDanhSachPhongBan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
         //   Waiting.ShowWaitForm();
            if (!_checkControl("frmDanhMuc_PhongBan"))
            {
                frmDanhMuc_PhongBan frm = new frmDanhMuc_PhongBan();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
           
        }

        private void btnCallCaLamViec_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDanhMuc_CaLamViec frm = new frmDanhMuc_CaLamViec();
            frm.ShowDialog();
        }

        private void btnCallKyHieuChamCong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            Waiting.SetWaitFormDescription("Đang khởi tạo danh mục..");
            if (!Class.App.IsFocusForm(typeof(frmChamCong_KyHieuChamCong), this))
            {
                Class.S_Log.Insert("Danh mục", "Xem Danh mục chương trình");
                frmChamCong_KyHieuChamCong frm = new frmChamCong_KyHieuChamCong();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnCallDanhSachNhom_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            Waiting.SetWaitFormDescription("Đang khởi tạo danh sách nhóm");
            if (!Class.App.IsFocusForm(typeof(frmDanhSachNhom),this))
            {
                Class.S_Log.Insert("Danh mục", "Xem Danh mục chương trình");
                frmDanhSachNhom frm= new frmDanhSachNhom();
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();

            }
            Waiting.CloseWaitForm();
        }
    }
}
