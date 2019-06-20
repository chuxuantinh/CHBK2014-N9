using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Xml;
using System.Media;
using DevExpress.XtraBars.Helpers;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;


namespace CHBK2014_N9
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string sv_host = "";
        //string template_grid = Application.StartupPath + @"\Templates\Templates_Menu.xml";

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Owner = this;
            frm.ShowDialog();
            if (_taiKhoan != "")
            {
                Waiting.ShowWaitForm();
                Waiting.SetWaitFormDescription("Đang tải thông tin tài khoản..");
                Permission_Show_Menu(_taiKhoan);
                //hien thi btndoimatkhau
                btnDoiMatKhau.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                // goi chuc nang thong bao
                this.btnThongBao.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                Class.RegistryWriter rg = new Class.RegistryWriter();
                lblFullname.Caption = "Đang sử dụng: " + _taiKhoan + "  | Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy h:m tt") + "   |  Máy chủ: " + rg.valuekey("server");
                sv_host = rg.valuekey("server");

                // goi thong tin de luu Log phan mem
                Class.S_Log.Call_PcInfo();
                Class.S_Log.UserName = _taiKhoan.ToLower();
                ribbon.SelectedPage = Menu_Hrm;
                Class.S_Log.Insert("Hệ thống", "Đăng nhập");
                Class.App.client_User = _taiKhoan;
                if (rg.valuekey("alert") == "Blue")
                {
                    btnThongBao.Enabled = true;
                }
                else if (rg.valuekey("alert") == "1")
                {
                    btnThongBao.Enabled = true;
                    Class.ThongKe tk = new Class.ThongKe();
                    DataTable dt = tk.CT_EMPLOYEE_GetListBirthday();
                    if (dt.Rows.Count > 0)
                    {
                        dt.Columns.Add("Day", Type.GetType("System.String"));
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string txt = ((DateTime)dt.Rows[i]["BirthDay"]).Day.ToString();
                            if (txt.Length == 1)
                            {
                                txt = "0" + txt;
                            }
                            dt.Rows[i]["Day"] = txt;

                        }
                        DataView dv = dt.DefaultView;
                        dv.Sort = "Day ASC";
                        dt = dv.ToTable();

                        // xuat thong bao sinh nhat sap den
                        string tb = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tb += (i + 1).ToString() + ". " + dt.Rows[i]["FirstName"].ToString() + " " + dt.Rows[i]["LastName"].ToString() + ": <i>" + ((DateTime)dt.Rows[i]["Birthday"]).ToString("dd/MM/yyyy") + "</i>\n";
                        }
                        alertControl.Show(this, "Danh sách sắp đến ngày sinh nhật:", tb);
                        //-------------
                        // xuat danh sach sap phai ky lai hop dong
                        Class.DanhMuc_HopDong hd = new Class.DanhMuc_HopDong();
                        DataTable dthd = hd.CT_CONTRACT_GetListJustExpiration();
                        if (dthd.Rows.Count > 0)
                        {

                            DataView _dv = new DataView();
                            _dv = dthd.DefaultView;
                            _dv.Sort = "ToDate ASC";


                            string tb2 = "";
                            for (int i = 0; i < _dv.Count; i++)
                            {
                                tb2 += (i + 1).ToString() + ". " + _dv[i]["FirstName"].ToString() + " " + _dv[i]["LastName"].ToString() + " -<i> " + ((DateTime)_dv[i]["ToDate"]).ToString("dd/MM/yyyy") + "</i>\n"; ;
                            }
                            alertControl.Show(this, "Danh sách sắp ký lại hợp đồng :", tb2);
                        }
                        ////-----------------=================
                        if (File.Exists(@"media/" + Class.App.media))
                        {
                            SoundPlayer simpleSound = new SoundPlayer(@"media/" + Class.App.media);
                            simpleSound.Play();
                        }
                    }
                }
                else
                {
                     btnThongBao.Enabled = false;
                }

                Waiting.CloseWaitForm();
            }

        }
        public string _taiKhoan = "";

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_bFullScreenMode == true)
            {
                ShowTaskbar();
            }
            string skin = defaultGiaoDien.LookAndFeel.SkinName;
            Class.RegistryWriter rg = new Class.RegistryWriter();
            rg.WriteKey("style", skin);
            //try
            //{
            //    ribbon.SaveLayoutToXml(template_grid);
            //}
            //catch { }
            Application.Exit();

        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Class.App.IsFocusForm(typeof(frmPhanQuyen), this))
            {
                frmPhanQuyen frm = new frmPhanQuyen();
                frm.MdiParent = this;
                frm.Show();
            }
        }


        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau(this._taiKhoan);
            frm.ShowDialog();
        }

        private static string config(string url, string bien)
        {
            string _config = "";
            XmlTextReader xmlReader = new XmlTextReader(url);
            while (xmlReader.Read())
            {
                if (xmlReader.Name == bien)
                {
                    _config = xmlReader.ReadElementString();
                }
            }
            xmlReader.Close();
            return _config;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          //  Permission_Hide_Menu(); // call permission hide

            this.Text = this.Text + " " + config("Config.xml", "company") + " V" + config("Config.xml", "version");

            Class.RegistryWriter rg = new Class.RegistryWriter();
         //   this.defaultGiaoDien.LookAndFeel.SkinName = "Xmas 2008 Blue";
           this.defaultGiaoDien.LookAndFeel.SkinName = rg.valuekey("style");
            string sv = rg.valuekey("server");
            if (sv == "Blue")
                btnCauHinh_ItemClick(null, null);
            else
                btnDangNhap_ItemClick(null, null);

            //// timechechSv.Enabled = true;          
            SkinHelper.InitSkinPopupMenu(barSubItem2);
            SkinHelper.InitSkinPopupMenu(barSubItem4);
           

        }

        private void btnCauHinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmConfig frm = new frmConfig();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }


        private void timechechSv_Tick(object sender, EventArgs e)
        {
            /*
            TcpClient TcpScan = new TcpClient();
            try
            {
                TcpScan.Connect(sv_host, 1433);
              //  this.btnCheckSV.Glyph = global::HRM.Properties.Resources._15;
                btnCheckSV.Caption = "online";
                TcpScan.Close();
                Application.DoEvents();
               Class.App.checkSV = 1;
            }

            catch
            {
              //  this.btnCheckSV.Glyph = global::HRM.Properties.Resources._16;
                btnCheckSV.Caption = "offline";
                Class.App.checkSV =0;
            }
           */
        }




        private void timecheckThongBao_Tick(object sender, EventArgs e)
        {
            if (Class.App.checkSV == 1)
            {
                // kiemtradulieucanthongbao();
            }
        }


        private void MenuItemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemShow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.Show();
        }

        private void btnHideProgam_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            string[] thongbao = new string[] { "Phần mềm đang chạy ẩn trên khay hệ thống !" };

         //   frmPopupThongBaoMoi frm = new frmPopupThongBaoMoi(thongbao);
           // frm.Show();
        }

        private void MenuItemStop_Click(object sender, EventArgs e)
        {
            btnThongBao.Checked = false;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            MenuItemShow_Click(null, null);
        }

        private void mnuThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        #region media Alert

        private void btnmedia1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Class.RegistryWriter rg = new Class.RegistryWriter();
            rg.WriteKey("media", "default_ring.wav");
            Class.App.media = "default_ring.wav";
            if (File.Exists(@"media/" + Class.App.media))
            {
                SoundPlayer simpleSound = new SoundPlayer(@"media/" + Class.App.media);
                simpleSound.Play();
            }
        }

        private void btnmedia2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Class.RegistryWriter rg = new Class.RegistryWriter();
            rg.WriteKey("media", "buzz.wav");
            Class.App.media = "buzz.wav";
            if (File.Exists(@"media/" + Class.App.media))
            {
                SoundPlayer simpleSound = new SoundPlayer(@"media/" + Class.App.media);
                simpleSound.Play();
            }
        }

        private void btnmedia3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Class.RegistryWriter rg = new Class.RegistryWriter();
            rg.WriteKey("media", "Yahoo_ring_03.wav");
            Class.App.media = "Yahoo_ring_03.wav";
            if (File.Exists(@"media/" + Class.App.media))
            {
                SoundPlayer simpleSound = new SoundPlayer(@"media/" + Class.App.media);
                simpleSound.Play();
            }
        }

        private void btnmedia4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Class.RegistryWriter rg = new Class.RegistryWriter();
            rg.WriteKey("media", "yodel.wav");
            Class.App.media = "yodel.wav";
            if (File.Exists(@"media/" + Class.App.media))
            {
                SoundPlayer simpleSound = new SoundPlayer(@"media/" + Class.App.media);
                simpleSound.Play();
            }
        }

        #endregion

        private void btnDanhMucChuongTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            Waiting.SetWaitFormDescription("Đang khởi tạo danh mục..");
            if (!Class.App.IsFocusForm(typeof(frmDanhmuc_Form), this))
            {
                Class.S_Log.Insert("Danh mục", "Xem Danh mục chương trình");
                frmDanhmuc_Form frm = new frmDanhmuc_Form();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnDanhSachNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            Waiting.SetWaitFormDescription("Đang tải danh sách nhân viên..");
            if (!Class.App.IsFocusForm(typeof(frmDanhSachNhanVien), this))
            {
                Class.S_Log.Insert("Nhân viên", "Xem Danh sách nhân viên");
                frmDanhSachNhanVien frm = new frmDanhSachNhanVien();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnDanhMucQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhanQuyen_DanhMuc frm = new frmPhanQuyen_DanhMuc();
            frm.ShowDialog();
        }

        //private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frmNguoiDung frm = new frmNguoiDung();
        //    frm.ShowDialog();
        //}

    //    #region Xu_Ly_Phan_quyen
        public void Permission_Show_Menu(string strUser)
        {
            Class.S_TaiKhoan tk = new Class.S_TaiKhoan();
            tk.UserName = strUser;
            DataTable _dtPermission = tk.GetPermissionByUser();
            try
            {
             //   Permission_Hide_Menu();
                for (int k = 0; k < ribbon.Pages.Count; k++)
                {
                    if (ribbon.Pages[k].Tag != null)
                    {
                        string page_tag = ribbon.Pages[k].Tag.ToString();
                        for (int m = 0; m < ribbon.Pages[k].Groups.Count; m++)
                        {
                            if (ribbon.Pages[k].Groups[m].Tag != null)
                            {
                                string group_tag = ribbon.Pages[k].Groups[m].Tag.ToString();
                                for (int l = 0; l < ribbon.Pages[k].Groups[m].ItemLinks.Count; l++)
                                {
                                    if (ribbon.Pages[k].Groups[m].ItemLinks[l].Item.Tag != null)
                                    {
                                        string item_tag = ribbon.Pages[k].Groups[m].ItemLinks[l].Item.Tag.ToString();
                                        for (int i = 0; i < _dtPermission.Rows.Count; i++)
                                        {
                                            string item_code = _dtPermission.Rows[i]["Object_ID"].ToString();
                                            if (item_code.CompareTo(item_tag) == 0)
                                            {
                                                ribbon.Pages[k].Groups[m].ItemLinks[l].Visible = true;
                                                int index_group = item_code.LastIndexOf("_");
                                                if (index_group > -1)
                                                {
                                                    string group_code = item_code.Substring(0, index_group);
                                                    if (group_code.CompareTo(group_tag) == 0)
                                                    {
                                                        ribbon.Pages[k].Groups[m].Visible = true;
                                                        int index_page = group_code.LastIndexOf("_");
                                                        if (index_page > -1)
                                                        {
                                                            string page_code = group_code.Substring(0, index_page);
                                                            if (page_code.CompareTo(page_tag) == 0)
                                                            {
                                                                ribbon.Pages[k].Visible = true;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //
            }
            catch (Exception ex)
            {
                string err = ex.ToString();
                throw;
            }
            Class.App.dtPermision = _dtPermission;


            //if (File.Exists(template_grid))
            //{
            //    ribbon.RestoreLayoutFromXml(template_grid);
            //}

        }
        public void Permission_Hide_Menu()
        {
            for (int i = 0; i < ribbon.Pages.Count; i++)  // duyêt tất cả page trên menu
            {
                ribbon.Pages[i].Visible = false; // cho ẩn tất cả
                for (int j = 0; j < ribbon.Pages[i].Groups.Count; j++)  // duyet trong group
                {
                    ribbon.Pages[i].Groups[j].Visible = false; // cho tat cac cac group ẩn hết
                    for (int k = 0; k < ribbon.Pages[i].Groups[j].ItemLinks.Count; k++) // duyet tat ca cac Item trong group
                    {
                        ribbon.Pages[i].Groups[j].ItemLinks[k].Visible = false;  // cho ẩn tất cả item
                    }
                }

            }
            Menu_System.Visible = true;// cho hien thi menu dang nhap
            //MenuHTTop1.Visible = true;
            Menu_System.Groups["MenuHTTop1"].Visible = true;
            for (int i = 0; i < Menu_System.Groups["MenuHTTop1"].ItemLinks.Count; i++)
            {
                Menu_System.Groups["MenuHTTop1"].ItemLinks[i].Visible = true;
            }
        }
       

        private void btnCongTy_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCongTy frm = new frmCongTy();
            frm.ShowDialog();
        }

        //private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frmBackup frm = new frmBackup();
        //    frm.ShowDialog();
        //}

        //private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frmRestore frm = new frmRestore();
        //    frm.ShowDialog();
        //}

        //private void btnHistory_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    if (!Class.App.IsFocusForm(typeof(frmLog), this))
        //    {
        //        frmLog frm = new frmLog();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}

        //private void btnQuanLyHopDong_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    Waiting.SetWaitFormDescription("Đang tải danh sách hợp đồng..");
        //    if (!Class.App.IsFocusForm(typeof(frmDanhSachHopDong), this))
        //    {
        //        Class.S_Log.Insert("Hợp đồng", "Xem Danh sách hợp đồng");
        //        frmDanhSachHopDong frm = new frmDanhSachHopDong();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}

        //private void btnQuaTrinhLamViec_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    Waiting.SetWaitFormDescription("Đang tải quá trình làm việc..");
        //    if (!Class.App.IsFocusForm(typeof(frmQuaTrinhLamViec), this))
        //    {
        //        Class.S_Log.Insert("Quá trình làm việc", "Xem ");
        //        frmQuaTrinhLamViec frm = new frmQuaTrinhLamViec();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}

        //private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    if (!Class.App.IsFocusForm(typeof(frmThongKe), this))
        //    {
        //        Class.S_Log.Insert("Thống kê", "Xem báo cáo thống kê ");
        //        frmThongKe frm = new frmThongKe();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}

        //private void btnKetNoiMayChamCong_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    if (!Class.App.IsFocusForm(typeof(frmChamCong_KetNoi), this))
        //    {
        //        Class.S_Log.Insert("Chấm công", " Kết nối máy chấm công ");
        //        frmChamCong_KetNoi frm = new frmChamCong_KetNoi();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}

        private void btnBangXepCa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(frmChamCong_BangXepCa), this))
            {
                // kiem tra du lieu thang hien tai va tat waiting
                Class.BangXepCa bxc = new Class.BangXepCa();
                bxc.Month = DateTime.Now.Month;
                bxc.Year = DateTime.Now.Year;
                DataTable dt = bxc.CT_TIMEKEEPER_TABLELIST_Get();
                if (dt.Rows.Count < 1)
                {
                    if (Waiting.IsSplashFormVisible)
                        Waiting.CloseWaitForm();
                }

                Class.S_Log.Insert("Chấm công", "Xem danh sách bảng xếp ca");
                 frmChamCong_BangXepCa frm = new frmChamCong_BangXepCa();
                frm.MdiParent = this;
                frm.Show();
            }
            if (Waiting.IsSplashFormVisible)
                Waiting.CloseWaitForm();
        }

        private void btnThongBao_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Class.RegistryWriter rg = new Class.RegistryWriter();
            if (btnThongBao.Checked)
            {
                rg.WriteKey("alert", "1");
            }
            else
            {
                rg.WriteKey("alert", "0");
            }
        }

        //private void btnChamCongThang_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    if (!Class.App.IsFocusForm(typeof(frmChamCong_ChamCongThang), this))
        //    {
        //        Class.S_Log.Insert("Chấm công", "Xem danh sách Chấm công tháng");
        //        frmChamCong_ChamCongThang frm = new frmChamCong_ChamCongThang();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }

        //    Waiting.CloseWaitForm();
        //}

        //private void btnTongHopChamCong_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    if (!Class.App.IsFocusForm(typeof(frmChamCong_TongHop), this))
        //    {
        //        Class.S_Log.Insert("Chấm công", "Xem danh sách Tổng hợp Chấm công");
        //        frmChamCong_TongHop frm = new frmChamCong_TongHop();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }

        //    Waiting.CloseWaitForm();
        //}

        //private void btnDanhSachNhanVienThoiVu_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    Waiting.SetWaitFormDescription("Đang tải danh sách nhân viên..");
        //    if (!Class.App.IsFocusForm(typeof(frmDanhSachNhanVien_ThoiVu), this))
        //    {
        //        Class.S_Log.Insert("Nhân viên", "Xem Danh sách nhân viên thời vụ");
        //        frmDanhSachNhanVien_ThoiVu frm = new frmDanhSachNhanVien_ThoiVu();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}

        //private void btnBangChamCongThoiVu_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    Waiting.SetWaitFormDescription("Đang tải bảng chấm công nhân viên..");
        //    if (!Class.App.IsFocusForm(typeof(frmDanhSachNhanVien_ThoiVu_ChamCong), this))
        //    {
        //        Class.S_Log.Insert("Nhân viên", "Xem bảng chấm công nhân viên thời vụ");
        //        frmDanhSachNhanVien_ThoiVu_ChamCong frm = new frmDanhSachNhanVien_ThoiVu_ChamCong();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}

        //private void btnSystemHelp_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    if (!Class.App.IsFocusForm(typeof(frmSystemHelp), this))
        //    {
        //        frmSystemHelp frm = new frmSystemHelp();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}

        //private void btnHopDongThoiVu_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    Waiting.SetWaitFormDescription("Đang tải danh sách hợp đồng  thời vụ..");
        //    if (!Class.App.IsFocusForm(typeof(frmDanhSachHopDong_Season), this))
        //    {
        //        frmDanhSachHopDong_Season frm = new frmDanhSachHopDong_Season();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}

        //private void btnDesignReport_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Waiting.ShowWaitForm();
        //    if (!Class.App.IsFocusForm(typeof(frmReportDesign), this))
        //    {
        //        frmReportDesign frm = new frmReportDesign();
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    Waiting.CloseWaitForm();
        //}
        private bool _bFullScreenMode = false;
        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F11)
            {
                if (_bFullScreenMode == false)
                {
                    HideTaskBar();
                    //this.WindowState = System.Windows.FormWindowState.Normal;
                    // this.WindowState = System.Windows.FormWindowState.Maximized;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.ShowIcon = false;
                    this.Left = 0;
                    this.Top = 0;
                    this.Bounds = Screen.PrimaryScreen.Bounds;

                    _bFullScreenMode = true;

                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    this.ShowIcon = true;
                    // Resize lại như cũ
                    _bFullScreenMode = false;
                    ShowTaskbar();
                }
            }
        }
        [DllImport("User32", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        const int SWP_HIDEWINDOW = 0x80;
        const int SWP_SHOWWINDOW = 0x40;

        private IntPtr taskbar = FindWindow("Shell_traywnd", "");

        public void HideTaskBar()
        {
            SetWindowPos(taskbar, 0, 0, 0, 0, 0, SWP_HIDEWINDOW);
        }

        public void ShowTaskbar()
        {
            SetWindowPos(taskbar, 0, 0, 0, 0, 0, SWP_SHOWWINDOW);
        }

        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNguoiDung frm = new frmNguoiDung();
            frm.ShowDialog();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            Waiting.SetWaitFormDescription("Đang tải danh sách hợp đồng..");
            if (!Class.App.IsFocusForm(typeof(FrmDanhSach_HopDong), this))
            {
                Class.S_Log.Insert("Hợp đồng", "Xem Danh sách hợp đồng");
                FrmDanhSach_HopDong frm = new FrmDanhSach_HopDong();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnBangChamCongThoiVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(frmChamCong_BangXepCa), this))
            {
                // kiem tra du lieu thang hien tai va tat waiting
                Class.BangXepCa bxc = new Class.BangXepCa();
                bxc.Month = DateTime.Now.Month;
                bxc.Year = DateTime.Now.Year;
                DataTable dt = bxc.CT_TIMEKEEPER_TABLELIST_Get();
                if (dt.Rows.Count < 1)
                {
                    if (Waiting.IsSplashFormVisible)
                        Waiting.CloseWaitForm();
                }

                Class.S_Log.Insert("Chấm công", "Xem danh sách bảng xếp ca");
                frmChamCong_BangXepCa frm = new frmChamCong_BangXepCa();
                frm.MdiParent = this;
                frm.Show();
            }
            if (Waiting.IsSplashFormVisible)
                Waiting.CloseWaitForm();
        }

        private void btnQuaTrinhLamViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            Waiting.SetWaitFormDescription("Đang tải quá trình làm việc..");
            if (!Class.App.IsFocusForm(typeof(frmQuaTrinh_LamViec), this))
            {
                Class.S_Log.Insert("Quá trình làm việc", "Xem ");
                frmQuaTrinh_LamViec frm = new frmQuaTrinh_LamViec();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnSystemHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(frmTroGiup), this))
            {
                frmTroGiup frm = new frmTroGiup();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnDanhSachNhanVienThoiVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnChamCongThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(frmChamCong_ChamCongThang), this))
            {
                Class.S_Log.Insert("Chấm công", "Xem danh sách Chấm công tháng");
                frmChamCong_ChamCongThang frm = new frmChamCong_ChamCongThang();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(FrmLog), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                FrmLog frm = new FrmLog();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnKetNoiMayChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(frmChamCong_KetNoi), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                frmChamCong_KetNoi frm = new frmChamCong_KetNoi();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

      

        private void barButtonItem_QuanLyMCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(ATT.UI.frmQuanLyMayChamCong), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                ATT.UI.frmQuanLyMayChamCong frm = new ATT.UI.frmQuanLyMayChamCong();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void barButtonItem_TaiDuLieuCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(ATT.UI.MayChamCong.DuLieuMayChamCong.frmTaiDuLieuChamCong), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                ATT.UI.MayChamCong.DuLieuMayChamCong.frmTaiDuLieuChamCong frm = new ATT.UI.MayChamCong.DuLieuMayChamCong.frmTaiDuLieuChamCong();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void barButtonItem_TinhCongBaoBieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
          if (!Class.App.IsFocusForm(typeof(ATT.UI.BaoBieu.frmTinhCongVaInBaoBieu), this))
            {
               Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                ATT.UI.BaoBieu.frmTinhCongVaInBaoBieu frm = new ATT.UI.BaoBieu.frmTinhCongVaInBaoBieu();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void barButtonItem_TaiNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(ATT.UI.MayChamCong.DuLieuMayChamCong.frmTaiNhanVien), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                ATT.UI.MayChamCong.DuLieuMayChamCong.frmTaiNhanVien frm = new ATT.UI.MayChamCong.DuLieuMayChamCong.frmTaiNhanVien();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(ATT.UI.MayChamCong.frmDangKyMayChamCong), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                ATT.UI.MayChamCong.frmDangKyMayChamCong frm = new ATT.UI.MayChamCong.frmDangKyMayChamCong();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(ATT.Connect_MCC), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                ATT.Connect_MCC frm = new ATT.Connect_MCC();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(frmConfig), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
               frmConfig frm = new frmConfig();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(ATT.UI.BaoBieu.frmTinhCongVaInBaoBieu2), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                ATT.UI.BaoBieu.frmTinhCongVaInBaoBieu2 frm = new ATT.UI.BaoBieu.frmTinhCongVaInBaoBieu2();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!Class.App.IsFocusForm(typeof(CHBK2014_N9.HumanResource.Core.xfmEmployee), this))
            {
                Class.S_Log.Insert("Xem Log", "Kết nối chấm công");
                CHBK2014_N9.HumanResource.Core.xfmEmployee frm = new CHBK2014_N9.HumanResource.Core.xfmEmployee();
                frm.MdiParent = this;
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }
    }
}