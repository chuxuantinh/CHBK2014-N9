using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab;
using DevExpress.XtraTabbedMdi;
using Microsoft.VisualBasic.CompilerServices;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
//using CHBK2014_N9.Data.Core;
//using CHBK2014_N9.Data.Extra.Class;
//using CHBK2014_N9.Data.Extra.Forms;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.Dictionnary;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core;
using CHBK2014_N9.HumanResource.Core.Class;
using CHBK2014_N9.HumanResource.Core.Machine;
using CHBK2014_N9.HumanResource.Core.Process;
//using CHBK2014_N9.HumanResource.My;
//using CHBK2014_N9.HumanResource.Properties;
//using CHBK2014_N9.HumanResource.Report;
using CHBK2014_N9.Logonui;
//using CHBK2014_N9.Net.Info;
//using CHBK2014_N9.Net.Info.Forms;
using CHBK2014_N9.Security;
//using CHBK2014_N9.Security.Security.Login;
//using CHBK2014_N9.Service.Class;
//using CHBK2014_N9.Service.Forms;
using CHBK2014_N9.Utils;
//using CHBK2014_N9.Utils.App;
//using CHBK2014_N9.Utils.Security2;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CHBK2014_N9
{
    public partial class frmMainHr : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private bool _ready;

        private SqlHelper sql;

        private string _themePath = string.Concat(Application.StartupPath, "\\Layout\\theme.xml");

     private string _startupPath = string.Concat(Application.StartupPath, "\\Layout\\startup.xml");
     //   private BarEditItem bbiStyle;
        public object Waiting { get; private set; }

        private xfmAtt xfmAtt;

        private xfmReg xfmReg;
        private xfmContract xfmContract;
        private xfmShiftOrder xfmShiftOrder;
        private xfmTimekeeperTable xfmTimekeeperTable;
        private xfmSalaryAllowance xfmSalaryAllowance;
        private xfmListAdvance xfmListAdvance;
        private xfmListAssignment xfmListAssignment;
        private xfmUsers xfmUsers;
        public frmMainHr()
        {
           InitializeComponent();

           // MyApplication.SotfType = EnumSotfType.Trial;
            this._ready = true;
           // DbInfo.CheckVersion();
            xfmLoginClassic _xfmLoginClassic = new xfmLoginClassic();
            _xfmLoginClassic.LoginSuccess += new xfmLoginClassic.LoginSuccessEventHander(this.FrmLoginSuccess);
            _xfmLoginClassic.ShowDialog(this);
        }


        private void FrmLoginSuccess(object sender)
        {
           // DbInfo.CheckVersion();
            Options.FormLoading.SetProgressValue(32,"Đang khởi tạo hệ thống...");
         //   SYS_LOG.Insert("Hệ Thống", "Đăng Nhập");
            Options.FormLoading.SetProgressValue(35, ( "Đang lấy thông tin hệ thống..."));
            //MyInfo.GetInfo();
            //CODE.CompanyName = MyInfo.Company;
            //CODE.Address = MyInfo.Address;
         //   CODE cODE = new CODE();
            //Options.FormLoading.SetProgressValue(40, ("Đang nạp thông tin hệ thống..."));
            //cODE.CheckLicense();
            //Options.FormLoading.SetProgressValue(45,("Đang kiểm tra sự hợp lệ.."));
         
            this.sql = new SqlHelper(SqlHelper.ConnectString);
            this.sql.Extract();
            Options.FormLoading.SetProgressValue(50, ("Đang khởi tạo hệ thống..."));
            clsAllOption _clsAllOption = new clsAllOption();
            if (this._ready)
            {
               // this.InitializeComponent(); // load lan 2
                //this.InitMultiLanguages();
               // this.LoadToggle();
              this.rbcMain.SelectedPage = this.rbpFunction;
             this.rbcMain.Minimized = _clsAllOption.Minimized;
               // this.bbeMonthDefault.EditValue = _clsAllOption.MonthDefault;
                //if (!_clsAllOption.ShowTimekeeper)
                //{
                //    this.rbpgTimekeeper.Visible = false;
                //}
                //if (!_clsAllOption.ShowSalary)
                //{
                //    this.rbpgSalary.Visible = false;
                //}
            }
            Options.FormLoading.SetProgressValue(65, ("Đang thiết lập hệ thống..."));
            this.lblAccount.Caption = string.Concat(MyLogin.AccountName, "/", HRM_ORGANIZATION.GetOrganizationByMyLogin());
            this.lblServer.Caption = string.Concat(this.sql.Server, "  ");
            BarStaticItem barStaticItem = this.lblDatabase;
       //    string[] database = new string[] { this.sql.Database, " (", DbInfo.CurrentVersion, ") ", DbInfo.Description };
         //   barStaticItem.Caption = string.Concat(database);
          //  BarStaticItem barStaticItem1 = this.lblToday;
            DateTime loginDate = MyLogin.LoginDate;
            lblServer.Caption = string.Concat("Thời gian: ", loginDate.ToString("dd/MM/yyyy hh:mm:ss"));
         //   this.lblVersion.Caption = string.Concat("Phiên bản:", MyAssembly.AssemblyVersion);
            Options.FormLoading.SetProgressValue(70,("Đang kiểm tra dữ liệu..."));
            int num = this.sql.Server.IndexOf("\\");
            string lower = (num != -1 ? this.sql.Server.Substring(0, num) : this.sql.Server);
            lower = lower.ToLower();
          
            this.Items();
            //if (_clsAllOption.ShowHelp)
            //{
            //    this.BbiHelpItemClick(this, null);
            //}




            //Options.FormLoading.SetProgressValue(80, "Đang kiểm tra mã đăng ký...");
            //if (CODE.TypeSoft == 0)
            //{
            //    MyApplication.SotfType = EnumSotfType.Trial;
            //}
            //else if (CODE.TypeSoft == 1)
            //{
            //    if ((lower != ".") & (lower != "(local)") & (lower != "(localhost)") & (lower != Environment.MachineName.ToLower()))
            //    {
            //        Options.FormLoading.Visible = false;
            //        XtraMessageBox.Show("Phần mềm đang truy cập cở sở dữ liệu trên máy chủ khác.\nTính năng không được hỗ trợ cho phiên bản này (Hoặc vui lòng mua phiên bản thu phí để được hỗ trợ).", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        xfmDatabaseConfig _xfmDatabaseConfig = new xfmDatabaseConfig();
            //        _xfmDatabaseConfig.Logined += new xfmDatabaseConfig.LoginedEventHander(frmMain.XfmDatabaseConfigLogined);
            //        _xfmDatabaseConfig.ShowDialog(this);
            //        XtraMessageBox.Show("Cấu hình mới chưa được thiết lập, Phần mềm sẽ kết thúc tại đây.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        Application.Exit();
            //    }
            //    if ((lower != ".") & (lower != "(local)") & (lower != "(localhost)") & (lower != Environment.MachineName.ToLower()))
            //    {
            //        this.bbiBackup.Visibility = BarItemVisibility.Never;
            //        this.bbiRestore.Visibility = BarItemVisibility.Never;
            //    }
            //    MyApplication.SotfType = EnumSotfType.Free;
            //    this.lblInfo.Caption = "BKHITECH!";
            //    this.bbiDiagram.Enabled = false;
            //    this.bbiTimekeeperTable.Enabled = false;
            //    this.bbiTimekeeperTable1.Enabled = false;
            //    this.bbiTimekeeping.Enabled = false;
            //    this.bbiTimekeeperOverTime.Enabled = false;
            //    this.bbiTimekeeperTotal.Enabled = false;
            //    this.bbiSalary.Enabled = false;
            //    this.bbiSalary1.Enabled = false;
            //    this.bbiSalaryOverTime.Enabled = false;
            //    this.bbiSalaryPay.Enabled = false;
            //    this.bbiShiftOrder.Enabled = false;
            //}
            //this.rbcMain.ApplicationCaption = (MultiLanguages.Language() == "vi-VN" ? "Phần Mềm Quản Lý Nhân Sự" : "Chutinh");
            //if (CODE.TypeSoft >= 200 & CODE.TypeSoft <= 299)
            //{
            //    MyApplication.SotfType = EnumSotfType.Standard;
            //}
            //if (CODE.TypeSoft >= 300 & CODE.TypeSoft <= 399)
            //{
            //    MyApplication.SotfType = EnumSotfType.Professional;
            //}
            //if (CODE.TypeSoft >= 400 & CODE.TypeSoft <= 499)
            //{
            //    MyApplication.SotfType = EnumSotfType.Enterprise;
            //}
            //BarStaticItem barStaticItem2 = this.lblVersion;
            //object[] assemblyVersion = new object[] { "Phiên bản:", MyAssembly.AssemblyVersion, " ", MyApplication.SotfType };
            //barStaticItem2.Caption = string.Concat(assemblyVersion);
            //if (!MyRule.IsAccess("rbpgClose"))
            //{
            //    this.rbpgClose.Visible = false;
            //}
            //if (!MyRule.IsAccess("rbpgDatabase"))
            //{
            //    this.rbpgDatabase.Visible = false;
            //}
            //if (!MyRule.IsAccess("rbpgSecurity"))
            //{
            //    this.rbpgSecurity.Visible = false;
            //}
            //Options.FormLoading.SetProgressValue(90, "Đang khởi tạo mặc định...");
            //if (CODE.TypeSoft != 1)
            //{
            //    if (!(clsAllOption.CheckOption("ShowDiagram") != ""))
            //    {
            //        this.Execute("xfmDiagram", "");
            //    }
            //    else if (clsAllOption.CheckOption("ShowDiagram") == "True")
            //    {
            //        this.Execute("xfmDiagram", "");
            //    }
            //}
            //if (!(clsAllOption.CheckOption("ShowWorkdesk") != ""))
            //{
            //    this.Execute("xfmWorkdesk", "");
            //}
            //else if (clsAllOption.CheckOption("ShowWorkdesk") == "True")
            //{
            //    this.Execute("xfmWorkdesk", "");
            //}
            Options.FormLoading.SetProgressValue(100, "Hoàn tất");
            Options.FormLoading.Visible = false;
            //if (CODE.TypeSoft == 1)
            //{
            //    xfmLicense _xfmLicense = new xfmLicense();
            //    _xfmLicense.Success += new xfmLicense.SuccessEventHander((object s) => base.Close());
            //    _xfmLicense.ShowDialog();
            //}
            //else 
            //if (this.sql.Database == "HRMExample")
            //{
            //    (new xfmDatabaseExample()).ShowDialog();
            //}

            ///****
            if (_clsAllOption.WindowState == "Maximized")
            {
                base.Top = 0;
                base.Left = 0;
                base.Bounds = Screen.PrimaryScreen.Bounds;
                base.WindowState = FormWindowState.Maximized;
                base.Width = 1024;
                base.Height = 768;
            }
            else if ((_clsAllOption.LocationX < 0 ? false : _clsAllOption.LocationY >= 0))
            {
                base.WindowState = FormWindowState.Normal;
                base.Bounds = Screen.PrimaryScreen.Bounds;
                base.Left = _clsAllOption.LocationX;
                base.Top = _clsAllOption.LocationY;
                if ((_clsAllOption.SizeWidth < 800 ? false : _clsAllOption.SizeHeight >= 600))
                {
                    base.Width = _clsAllOption.SizeWidth;
                    base.Height = _clsAllOption.SizeHeight;
                }
                else
                {
                    base.Width = 800;
                    base.Height = 600;
                }
            }
            else
            {
                base.Top = 0;
                base.Left = 0;
                base.Bounds = Screen.PrimaryScreen.Bounds;
                base.WindowState = FormWindowState.Maximized;
                base.Width = 1024;
                base.Height = 768;
            }

           
           base.SizeChanged += new EventHandler(this.frmMainHr_SizeChanged);
            base.LocationChanged += new EventHandler(this.frmMainHr_LocationChanged);
            timer.Enabled = true;
        }

        private void frmMainHr_LoaSetSkin(object sender, EventArgs e)
        {
            this.SetSkin();
            foreach (SkinContainer skin in SkinManager.Default.Skins)
            {
                BarCheckItem skinName = this.rbcMain.Items.CreateCheckItem(skin.SkinName, false);
                skinName.Tag = skin.SkinName;
                skinName.ItemClick += new ItemClickEventHandler(this.OnPaintStyleClick);
                this.bbSkin.ItemLinks.Add(skinName);
            }
            //  Welcome.LoadWelcome();
            rbcMain.Hide();
        }

        private void rbcMain_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            
                HumanResource.Core.xfmEmployee frm = new HumanResource.Core.xfmEmployee();
                frm.MdiParent = this;
                frm.Show();
          
          
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
         //   Cursor.Current = Cursors.WaitCursor;
           //this.Execute("xfmDictionary", "");
            //  Cursor.Current = Cursors.Default;
            Dictionnary.xfmDictionnary frm = new Dictionnary.xfmDictionnary();
            frm.MdiParent = this;
            frm.Show();


        }


        //private void LoadToggle()
        //{
        //    bool keyState = frmMain.GetKeyState(144) != 0;
        //    bool flag = frmMain.GetKeyState(20) != 0;
        //    bool keyState1 = frmMain.GetKeyState(45) != 0;
        //    if (!keyState)
        //    {
        //        this.bbiNumlock.Caption = string.Empty;
        //    }
        //    else
        //    {
        //        this.bbiNumlock.Caption = "NUM";
        //    }
        //    if (!flag)
        //    {
        //        this.bbiCapslock.Caption = string.Empty;
        //    }
        //    else
        //    {
        //        this.bbiCapslock.Caption = "CAPS";
        //    }
        //    if (!keyState1)
        //    {
        //        this.bbiOverwrite.Caption = "INS";
        //    }
        //    else
        //    {
        //        this.bbiOverwrite.Caption = "OVR";
        //    }
        //    this.Refresh();
        //}

        private void xfmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            xfmEmployee xfmE = new xfmEmployee();
            xfmE = null;
        }

        private void Execute(string id, string @ref)
        {
            string[] str;
            string str1 = id;
            if (str1 != null)
            {
                switch (str1)
                {
                    case "xfmUsers":
                        {
                          //  SYS_LOG.Insert("Quản Lý Người Dùng", "Xem");
                            if (this.xfmUsers != null)
                            {
                                this.tabMdi.Pages[this.xfmUsers].MdiChild.Activate();
                            }
                            else
                            {
                                this.xfmUsers = new xfmUsers()
                                {
                                    MdiParent = this
                                };
                                this.xfmUsers.FormClosing += new FormClosingEventHandler(this.XfmUsersFormClosing);
                                this.xfmUsers.Show();
                            }
                            this.xfmUsers.IsSearch = false;
                            break;
                        }

                    case "xfmDictionary":
                        {

                            //Dictionnary.xfmDictionnary frm = new Dictionnary.xfmDictionnary();
                            //frm.MdiParent = this;
                            //frm.Show();
                            //break;

                            ////   SYS_LOG.Insert("Danh Sách Nhân Viên", "Xem");
                            Dictionnary.xfmDictionnary xfmE = new Dictionnary.xfmDictionnary();
                            if (xfmE != null)
                            {
                              tabMdi.Pages[xfmE].MdiChild.Activate();
                            }
                            else
                            {
                                //  xfmE = new xfmEmployee()
                                {
                                    MdiParent = this;
                                }
                             //   xfmE.FormClosing += new FormClosingEventHandler(this.xfmEmployee_FormClosing);
                                xfmE.Show();
                            }
                            break;
                        }


                    case "xfmEmployee":
                        {
                            //   SYS_LOG.Insert("Danh Sách Nhân Viên", "Xem");
                            xfmEmployee xfmE = new xfmEmployee();
                            if (xfmE != null)
                            {
                                 this.tabMdi.Pages[xfmE].MdiChild.Activate();
                            }
                            else
                            {
                                xfmE = new xfmEmployee()
                                {
                                    MdiParent = this
                                };
                                xfmE.FormClosing += new FormClosingEventHandler(this.xfmEmployee_FormClosing);
                                xfmE.Show();
                            }
                            break;
                        }

                    //case "xfmPermision":
                    //    {
                    //        SYS_LOG.Insert("Phân Quyền Người Dùng", "Xem");
                    //        if (this.xfmPermision != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmPermision].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmPermision = new xfmPermision()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmPermision.FormClosing += new FormClosingEventHandler(this.xfmPermision_FormClosing);
                    //            this.xfmPermision.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmGroups":
                    //    {
                    //        SYS_LOG.Insert("Quản Lý Vai Trò", "Xem");
                    //        if (this.xfmGroups != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmGroups].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmGroups = new xfmGroups()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmGroups.FormClosing += new FormClosingEventHandler(this.XfmGroupsFormClosing);
                    //            this.xfmGroups.Show();
                    //        }
                    //        this.xfmGroups.IsSearch = false;
                    //        break;
                    //    }
                    //case "xfmSysLog":
                    //    {
                    //        SYS_LOG.Insert("Nhật Ký Hệ Thống", "Xem");
                    //        if (this.xfmSysLog != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmSysLog].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmSysLog = new XfmSysLog()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmSysLog.FormClosing += new FormClosingEventHandler(this.XfmSysLogFormClosing);
                    //            this.xfmSysLog.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmWorkdesk":
                    //    {
                    //        SYS_LOG.Insert("Bàn Làm Việc", "Xem");
                    //        if (this.xfmWorkdesk != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmWorkdesk].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmWorkdesk = new xfmWorkdesk()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmWorkdesk.FormClosing += new FormClosingEventHandler(this.xfmWorkdesk_FormClosing);
                    //            this.xfmWorkdesk.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmReportUI":
                    //    {
                    //        SYS_LOG.Insert("Báo Cáo", "Xem");
                    //        if (this.xfmReportUI != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmReportUI].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmReportUI = new xfmReportUI()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmReportUI.FormClosing += new FormClosingEventHandler(this.xfmReportUI_FormClosing);
                    //            this.xfmReportUI.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmDiagram":
                    //    {
                    //        SYS_LOG.Insert("Bàn Làm Việc", "Xem");
                    //        if (this.xfmDiagram != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmDiagram].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmDiagram = new xfmDiagram()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmDiagram.ItemClicked += new xfmDiagram.ItemClickedEventHander((object s, string i) => {
                    //                Cursor.Current = Cursors.WaitCursor;
                    //                this.Execute(i, "");
                    //                Cursor.Current = Cursors.Default;
                    //            });
                    //            this.xfmDiagram.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmDiagram = null);
                    //            this.xfmDiagram.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmDictionary":
                    //    {
                    //        SYS_LOG.Insert("Danh Mục Chương Trình", "Xem");
                    //        if (this.xfmDictionary != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmDictionary].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmDictionary = new xfmDictionary()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmDictionary.FormClosing += new FormClosingEventHandler(this.xfmDictionary_FormClosing);
                    //            this.xfmDictionary.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmCandidate":
                    //    {
                    //        SYS_LOG.Insert("Danh Sách Ứng Viên", "Xem");
                    //        if (this.xfmCandidate != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmCandidate].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmCandidate = new xfmCandidate()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmCandidate.FormClosing += new FormClosingEventHandler(this.xfmCandidate_FormClosing);
                    //            this.xfmCandidate.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmEmployee":
                    //    {
                    //        SYS_LOG.Insert("Danh Sách Nhân Viên", "Xem");
                    //        if (this.xfmEmployee != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmEmployee].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmEmployee = new xfmEmployee()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmEmployee.FormClosing += new FormClosingEventHandler(this.xfmEmployee_FormClosing);
                    //            this.xfmEmployee.Show();
                    //        }
                    //        break;
                    //    }
                    case "xfmContract":
                        {
                            //SYS_LOG.Insert("Hợp Đồng Nhân Viên", "Xem");
                            if (this.xfmContract != null)
                            {
                                this.tabMdi.Pages[this.xfmContract].MdiChild.Activate();
                            }
                            else
                            {
                                this.xfmContract = new xfmContract()
                                {
                                    MdiParent = this
                                };
                               // this.xfmContract.FormClosing += new FormClosingEventHandler(this.xfmContract_FormClosing);
                                this.xfmContract.Show();
                            }
                            break;
                        }
                    //case "xfmProcess":
                    //    {
                    //        SYS_LOG.Insert("Quá Trình Làm Việc", "Xem");
                    //        if (this.xfmProcess != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmProcess].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmProcess = new xfmProcess()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmProcess.FormClosing += new FormClosingEventHandler(this.xfmProcess_FormClosing);
                    //            this.xfmProcess.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmProcessList":
                    //    {
                    //        SYS_LOG.Insert("Quá Trình Làm Việc", "Xem");
                    //        if (this.xfmProcessList != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmProcessList].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmProcessList = new xfmProcessList()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmProcessList.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmProcessList = null);
                    //            this.xfmProcessList.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmWork":
                    //    {
                    //        SYS_LOG.Insert("Quản Lý Công Việc", "Xem");
                    //        if (this.xfmWork != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmWork].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmWork = new xfmWork()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmWork.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmWork = null);
                    //            this.xfmWork.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmInsurance":
                    //    {
                    //        SYS_LOG.Insert("Bảo Hiểm Xã Hội", "Xem");
                    //        if (this.xfmInsurance != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmInsurance].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmInsurance = new xfmInsurance()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmInsurance.FormClosing += new FormClosingEventHandler(this.xfmInsurance_FormClosing);
                    //            this.xfmInsurance.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmDeclaration":
                    //    {
                    //        SYS_LOG.Insert("Các Chế Độ Và Chính Sách", "Xem");
                    //        if (this.xfmDeclaration != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmDeclaration].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmDeclaration = new xfmDeclaration()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmDeclaration.FormClosing += new FormClosingEventHandler(this.xfmDeclaration_FormClosing);
                    //            this.xfmDeclaration.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmPayInsurance":
                    //    {
                    //        SYS_LOG.Insert("Các Chế Độ Và Chính Sách", "Xem");
                    //        if (this.xfmPayInsurance != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmPayInsurance].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmPayInsurance = new xfmPayInsurance()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmPayInsurance.FormClosing += new FormClosingEventHandler(this.xfmPayInsurance_FormClosing);
                    //            this.xfmPayInsurance.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmWelfare":
                    //    {
                    //        SYS_LOG.Insert("Chương Trình Phúc Lợi", "Xem");
                    //        if (this.xfmWelfare != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmWelfare].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmWelfare = new xfmWelfare()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmWelfare.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmWelfare = null);
                    //            this.xfmWelfare.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmReward":
                    //    {
                    //        SYS_LOG.Insert("Khen Thưởng", "Xem");
                    //        if (this.xfmReward != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmReward].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmReward = new xfmReward()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmReward.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmReward = null);
                    //            this.xfmReward.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmDiscipline":
                    //    {
                    //        SYS_LOG.Insert("Kỷ Luật", "Xem");
                    //        if (this.xfmDiscipline != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmDiscipline].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmDiscipline = new xfmDiscipline()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmDiscipline.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmDiscipline = null);
                    //            this.xfmDiscipline.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmTraining":
                    //    {
                    //        SYS_LOG.Insert("Kỷ Luật", "Xem");
                    //        if (this.xfmTraining != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmTraining].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmTraining = new xfmTraining()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmTraining.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmTraining = null);
                    //            this.xfmTraining.Show();
                    //        }
                    //        break;
                    //    }
                    case "xfmShiftOrder":
                        {
                           // SYS_LOG.Insert("Bảng Xếp Ca", "Xem");
                            if (this.xfmShiftOrder != null)
                            {
                                this.tabMdi.Pages[this.xfmShiftOrder].MdiChild.Activate();
                            }
                            else
                            {
                                this.xfmShiftOrder = new xfmShiftOrder()
                                {
                                    MdiParent = this
                                };
                                this.xfmShiftOrder.FormClosing += new FormClosingEventHandler(this.xfmShiftOrder_FormClosing);
                                this.xfmShiftOrder.SaveDataChanged += new xfmShiftOrder.SaveDataChangedHander(this.xfmShiftOrder_SaveDataChanged);
                                this.xfmShiftOrder.Show();
                            }
                            break;
                        }
                    //case "xfmTimekeeping":
                    //    {
                    //        SYS_LOG.Insert("Chấm Công", "Xem");
                    //        if (this.xfmTimekeeping != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmTimekeeping].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmTimekeeping = new xfmTimekeeping()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmTimekeeping.FormClosing += new FormClosingEventHandler(this.xfmTimekeeping_FormClosing);
                    //            this.xfmTimekeeping.UnShiftData += new xfmTimekeeping.UnShiftDataHandler(this.xfmTimekeeping_UnShiftData);
                    //            this.xfmTimekeeping.TimekeeperTableInserted += new xfmTimekeeping.TimekeeperTableInsertedHandler(this.xfmTimekeeping_TimekeeperTableInserted);
                    //            this.xfmTimekeeping.Show();
                    //        }
                    //        break;
                    //    }
                    case "xfmAtt":
                        {
                            // SYS_LOG.Insert("Kết Nối Máy Chấm Công", "Xem");
                            if (this.xfmAtt != null)
                            {
                                this.tabMdi.Pages[this.xfmAtt].MdiChild.Activate();
                            }
                            else
                            {
                                this.xfmAtt = new xfmAtt()
                                {
                                    MdiParent = this
                                };
                             //   this.xfmAtt.FormClosing += new FormClosingEventHandler(this.xfmAtt_FormClosing);
                                this.xfmAtt.Show();
                            }
                            break;
                        }
                    case "xfmTimekeeperTable":
                        {
                          //  SYS_LOG.Insert("Chấm Công Tổng Hợp", "Xem");
                            if (this.xfmTimekeeperTable != null)
                            {
                                this.tabMdi.Pages[this.xfmTimekeeperTable].MdiChild.Activate();
                            }
                            else
                            {
                                this.xfmTimekeeperTable = new xfmTimekeeperTable()
                                {
                                    MdiParent = this
                                };
                              //  this.xfmTimekeeperTable.FormClosing += new FormClosingEventHandler(this.xfmTimekeeperTable_FormClosing);
                                this.xfmTimekeeperTable.UnShiftData += new xfmTimekeeperTable.UnShiftDataHandler(this.xfmTimekeeping_UnShiftData);
                               // this.xfmTimekeeperTable.TimekeeperTableInserted += new xfmTimekeeperTable.TimekeeperTableInsertedHandler(this.xfmTimekeeping_TimekeeperTableInserted);
                               // this.xfmTimekeeperTable.TimekeeperTableDeleted += new xfmTimekeeperTable.TimekeeperTableDeletedHandler(this.xfmTimekeeperTable_TimekeeperTableDeleted);
                                this.xfmTimekeeperTable.Show();
                            }
                            break;
                        }
                    //case "xfmTimekeeperOverTime":
                    //    {
                    //        SYS_LOG.Insert("Chấm Công Tăng Ca", "Xem");
                    //        if (this.xfmTimekeeperOverTime != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmTimekeeperOverTime].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmTimekeeperOverTime = new xfmTimekeeperOverTime()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmTimekeeperOverTime.FormClosing += new FormClosingEventHandler(this.xfmTimekeeperOverTime_FormClosing);
                    //            this.xfmTimekeeperOverTime.UnShiftData += new xfmTimekeeperOverTime.UnShiftDataHandler(this.xfmTimekeeping_UnShiftData);
                    //            this.xfmTimekeeperOverTime.TimekeeperTableInserted += new xfmTimekeeperOverTime.TimekeeperTableInsertedHandler(this.xfmTimekeeping_TimekeeperTableInserted);
                    //            this.xfmTimekeeperOverTime.TimekeeperTableDeleted += new xfmTimekeeperOverTime.TimekeeperTableDeletedHandler(this.xfmTimekeeperTable_TimekeeperTableDeleted);
                    //            this.xfmTimekeeperOverTime.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmTimekeeperTotal":
                    //    {
                    //        SYS_LOG.Insert("Chấm Công Tăng Ca", "Xem");
                    //        if (this.xfmTimekeeperTotal != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmTimekeeperTotal].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmTimekeeperTotal = new xfmTimekeeperTotal()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmTimekeeperTotal.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmTimekeeperTotal = null);
                    //            this.xfmTimekeeperTotal.UnShiftData += new xfmTimekeeperTotal.UnShiftDataHandler(this.xfmTimekeeping_UnShiftData);
                    //            this.xfmTimekeeperTotal.TimekeeperTableInserted += new xfmTimekeeperTotal.TimekeeperTableInsertedHandler(this.xfmTimekeeping_TimekeeperTableInserted);
                    //            this.xfmTimekeeperTotal.TimekeeperTableDeleted += new xfmTimekeeperTotal.TimekeeperTableDeletedHandler(this.xfmTimekeeperTable_TimekeeperTableDeleted);
                    //            this.xfmTimekeeperTotal.Show();
                    //        }
                    //        break;
                    //    }
                    case "xfmSalary":
                        {
                            //     SYS_LOG.Insert("Bảng Tính Lương", "Xem");



                            xfmSalary xfmSalary = new xfmSalary();

                            if (xfmSalary != null)
                            {
                                xfmSalary.Show();
                            }
                            break;
                          
                        }
                    //case "xfmSalaryOverTime":
                    //    {
                    //        SYS_LOG.Insert("Tính Lương Tăng Ca", "Xem");
                    //        if (this.xfmSalaryOverTime != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmSalaryOverTime].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmSalaryOverTime = new xfmSalaryOverTime()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmSalaryOverTime.FormClosing += new FormClosingEventHandler(this.xfmSalaryOverTime_FormClosing);
                    //            this.xfmSalaryOverTime.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmSalaryPay":
                    //    {
                    //        SYS_LOG.Insert("Bảng Thanh Toán Lương", "Xem");
                    //        if (this.xfmSalaryPay != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmSalaryPay].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmSalaryPay = new xfmSalaryPay()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmSalaryPay.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmSalaryPay = null);
                    //            this.xfmSalaryPay.SalaryPayChanged += new xfmSalaryPay.SalaryPayChangedHander((object s) => {
                    //            });
                    //            this.xfmSalaryPay.Show();
                    //        }
                    //        break;
                    //    }
                    case "xfmSalaryAllowance":
                        {
                         //   SYS_LOG.Insert("Bảng Phụ Cấp Lương", "Xem");
                            if (this.xfmSalaryAllowance != null)
                            {
                                this.tabMdi.Pages[this.xfmSalaryAllowance].MdiChild.Activate();
                            }
                            else
                            {
                                this.xfmSalaryAllowance = new xfmSalaryAllowance()
                                {
                                    MdiParent = this
                                };
                                this.xfmSalaryAllowance.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmSalaryAllowance = null);
                                this.xfmSalaryAllowance.SalaryPayChanged += new xfmSalaryAllowance.SalaryPayChangedHander((object s) =>
                                {
                                });
                                this.xfmSalaryAllowance.Show();
                            }
                            break;
                        }
                    //case "xfmSalaryPlus":
                    //    {
                    //        SYS_LOG.Insert("Các Khoản Thu Nhập Khác", "Xem");
                    //        if (this.xfmSalaryPlus != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmSalaryPlus].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmSalaryPlus = new xfmSalaryPlus()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmSalaryPlus.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmSalaryPlus = null);
                    //            this.xfmSalaryPlus.SalaryPayChanged += new xfmSalaryPlus.SalaryPayChangedHander((object s) => {
                    //            });
                    //            this.xfmSalaryPlus.Show();
                    //        }
                    //        break;
                    //    }
                    //case "xfmSalaryMinus":
                    //    {
                    //        SYS_LOG.Insert("Các Khoản Khấu Trừ Khác", "Xem");
                    //        if (this.xfmSalaryMinus != null)
                    //        {
                    //            this.tabMdi.Pages[this.xfmSalaryMinus].MdiChild.Activate();
                    //        }
                    //        else
                    //        {
                    //            this.xfmSalaryMinus = new xfmSalaryMinus()
                    //            {
                    //                MdiParent = this
                    //            };
                    //            this.xfmSalaryMinus.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmSalaryMinus = null);
                    //            this.xfmSalaryMinus.SalaryPayChanged += new xfmSalaryMinus.SalaryPayChangedHander((object s) => {
                    //            });
                    //            this.xfmSalaryMinus.Show();
                    //        }
                    //        break;
                    //    }
                    case "xfmListAdvance":
                        {
                           // SYS_LOG.Insert("Tạm ứng lương", "Xem");
                            if (this.xfmListAdvance != null)
                            {
                                this.tabMdi.Pages[this.xfmListAdvance].MdiChild.Activate();
                            }
                            else
                            {
                                this.xfmListAdvance = new xfmListAdvance()
                                {
                                    MdiParent = this
                                };
                                this.xfmListAdvance.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmListAdvance = null);
                                this.xfmListAdvance.Show();
                            }
                            break;
                        }
                    case "xfmListAssignment":
                        {
                           // SYS_LOG.Insert("Công tác phí", "Xem");
                            if (this.xfmListAssignment != null)
                            {
                                this.tabMdi.Pages[this.xfmListAssignment].MdiChild.Activate();
                            }
                            else
                            {
                                this.xfmListAssignment = new xfmListAssignment()
                                {
                                    MdiParent = this
                                };
                                this.xfmListAssignment.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmListAssignment = null);
                                this.xfmListAssignment.Show();
                            }
                            break;
                        }
                        //case "xfmBalanceSheet":
                        //    {
                        //        SYS_LOG.Insert("Quyết Toán Thuế TNCN", "Xem");
                        //        if (this.xfmBalanceSheet != null)
                        //        {
                        //            this.tabMdi.Pages[this.xfmBalanceSheet].MdiChild.Activate();
                        //        }
                        //        else
                        //        {
                        //            this.xfmBalanceSheet = new xfmBalanceSheet()
                        //            {
                        //                MdiParent = this
                        //            };
                        //            this.xfmBalanceSheet.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => this.xfmBalanceSheet = null);
                        //            this.xfmBalanceSheet.Show();
                        //        }
                        //        break;
                        //    }
                        //case "xfmTotalUp":
                        //    {
                        //        SYS_LOG.Insert("Thống Kê", "Xem");
                        //        if (this.xfmTotalUp != null)
                        //        {
                        //            this.tabMdi.Pages[this.xfmTotalUp].MdiChild.Activate();
                        //        }
                        //        else
                        //        {
                        //            this.xfmTotalUp = new xfmTotalUp()
                        //            {
                        //                MdiParent = this
                        //            };
                        //            this.xfmTotalUp.FormClosing += new FormClosingEventHandler(this.xfmTotalUp_FormClosing);
                        //            this.xfmTotalUp.Show();
                        //        }
                        //        break;
                        //    }
                        //case "xfmSearch":
                        //    {
                        //        SYS_LOG.Insert("Tìm Kiếm", "Xem");
                        //        if (this.xfmSearch != null)
                        //        {
                        //            this.tabMdi.Pages[this.xfmSearch].MdiChild.Activate();
                        //        }
                        //        else
                        //        {
                        //            this.xfmSearch = new xfmSearch("")
                        //            {
                        //                MdiParent = this
                        //            };
                        //            this.xfmSearch.FormClosing += new FormClosingEventHandler(this.xfmSearch_FormClosing);
                        //            this.xfmSearch.Show();
                        //        }
                        //        break;
                        //    }

                }
            }
        }

        //private void LoadStartup()
        //{
        //    try
        //    {
        //        DataSet dataSet = new DataSet();
        //        dataSet.ReadXml(this._startupPath);
        //        foreach (DataRow row in dataSet.Tables[0].Rows)
        //        {
        //            this.Execute(row[1].ToString(), "");
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        private void frmMainHr_LocationChanged(object sender, EventArgs e)
        {
            clsAllOption _clsAllOption = new clsAllOption()
            {
                WindowState = base.WindowState.ToString(),
                LocationX = base.Location.X,
                LocationY = base.Location.Y
            };
            _clsAllOption.SaveOption();
        }



        private void frmMainHr_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Unload();
        }


        private void FrmOutwardListExpand(object sender)
        {
            this.Execute("xfmOutwardList", "");
        }



        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        internal static extern short GetKeyState(int keyCode);



        private void Items()
        {
            //    if (MyRule.IsAccess("bbiOption"))
            //    {
            //        this.bbiOption.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiOption.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiUsers"))
            //    {
            //        this.bbiUsers.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiUsers.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiPermission"))
            //    {
            //        this.bbiPermission.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiPermission.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiSysLog"))
            //    {
            //        this.bbiSysLog.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiSysLog.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiBackup"))
            //    {
            //        this.bbiBackup.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiBackup.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiRestore"))
            //    {
            //        this.bbiRestore.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiRestore.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiWorkdesk"))
            //    {
            //        this.bbiWorkdesk.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiWorkdesk.Enabled = false;
            //    }
            if (MyRule.IsAccess("bbiDictionary"))
            {
                this.bbiDictionary.Enabled = true;
            }
            else
            {
                this.bbiDictionary.Enabled = false;
            }

            //if (MyRule.IsAccess("bbiCandidate"))
            //{
            //    this.bbiCandidate.Enabled = true;
            //}
            //else
            //{
            //    this.bbiCandidate.Enabled = false;
            //}
            if (MyRule.IsAccess("bbiEmployee"))
            {
                this.bbiEmployee.Enabled = true;
            }
            else
            {
                this.bbiEmployee.Enabled = false;
            }
            if (MyRule.IsAccess("bbiContract"))
            {
                this.bbiContract.Enabled = true;
            }
            else
            {
                this.bbiContract.Enabled = false;
            }
            //    if (MyRule.IsAccess("bbiProcess"))
            //    {
            //        this.bbiProcess.Enabled = true;
            //        this.bbiProcessList.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiProcess.Enabled = false;
            //        this.bbiProcessList.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiInsurance"))
            //    {
            //        this.bbiDeclaration.Enabled = true;
            //        this.bbiInsurance.Enabled = true;
            //        this.bbiPayInsurance.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiDeclaration.Enabled = false;
            //        this.bbiInsurance.Enabled = false;
            //        this.bbiPayInsurance.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiWork"))
            //    {
            //        this.bbiWork.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiWork.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiReward"))
            //    {
            //        this.bbiReward.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiReward.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiDiscipline"))
            //    {
            //        this.bbiDiscipline.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiDiscipline.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiTraining"))
            //    {
            //        this.bbiTraining.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiTraining.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiWelfare"))
            //    {
            //        this.bbiWelfare.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiWelfare.Enabled = false;
            //    }
            if (MyRule.IsAccess("bbiShiftOrder"))
            {
                this.bbiShiftOrder.Enabled = true;
            }
            else
            {
                this.bbiShiftOrder.Enabled = false;
            }
            //    if (MyRule.IsAccess("bbiTimekeeping"))
            //    {
            //        this.bbiTimekeeping.Enabled = true;
            //        this.bbiConnectDevice.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiTimekeeping.Enabled = false;
            //        this.bbiConnectDevice.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiTimekeeperTable"))
            //    {
            //        this.bbiTimekeeperTable.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiTimekeeperTable.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiTimekeeperTableOverTime"))
            //    {
            //        this.bbiTimekeeperOverTime.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiTimekeeperOverTime.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiTimekeeperTotal"))
            //    {
            //        this.bbiTimekeeperTotal.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiTimekeeperTotal.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiMinSalary"))
            //    {
            //        this.bbiMinSalary.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiMinSalary.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiFormula"))
            //    {
            //        this.bbiFormula.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiFormula.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiSalary"))
            //    {
            //        this.bbiSalary.Enabled = true;
            //        this.bbiSalaryOverTime.Enabled = true;
            //        this.bbiSalaryPay.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiSalary.Enabled = false;
            //        this.bbiSalaryOverTime.Enabled = false;
            //        this.bbiSalaryPay.Enabled = false;
            //    }
            //    if (MyRule.IsAccess("bbiTotalUp"))
            //    {
            //        this.bbiTotalUp.Enabled = true;
            //    }
            //    else
            //    {
            //        this.bbiTotalUp.Enabled = false;
        }

    [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private string LoadStyle()
        {
            string str;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(this._themePath);
                str = dataSet.Tables[0].Rows[0][1].ToString();
            }
            catch
            {
                str = "Classic";
            }
            return str;
        }

        //private void LoadToggle()
        //{
        //    bool keyState = frmMainHr.GetKeyState(144) != 0;
        //    bool flag = frmMainHr.GetKeyState(20) != 0;
        //    bool keyState1 = frmMainHr.GetKeyState(45) != 0;
        //    if (!keyState)
        //    {
        //        this.bbiNumlock.Caption = string.Empty;
        //    }
        //    else
        //    {
        //        this.bbiNumlock.Caption = "NUM";
        //    }
        //    if (!flag)
        //    {
        //        this.bbiCapslock.Caption = string.Empty;
        //    }
        //    else
        //    {
        //        this.bbiCapslock.Caption = "CAPS";
        //    }
        //    if (!keyState1)
        //    {
        //        this.bbiOverwrite.Caption = "INS";
        //    }
        //    else
        //    {
        //        this.bbiOverwrite.Caption = "OVR";
        //    }
        //    this.Refresh();
        //}

        private void OnPaintStyleClick(object sender, ItemClickEventArgs e)
        {
            BarEditItem bbiStyle = new BarEditItem();
            UserLookAndFeel.Default.SkinName =  e.Item.Tag.ToString();
        
            SaveTheme(e.Item.Tag.ToString(), bbiStyle.EditValue.ToString());
        }

        private void PressKeyboardButton(Keys keyCode)
        {
            frmMainHr.keybd_event((byte)keyCode, 69, 1, 0);
            frmMainHr.keybd_event((byte)keyCode, 69, 3, 0);
            //this.LoadToggle();
        }

        private void rbcMain_ApplicationButtonClick(object sender, EventArgs e)
        {
            //  this.pcRecentList.Controls.Clear();
            Form[] mdiChildren = base.MdiChildren;
            for (int num = 0; num < (int)mdiChildren.Length; num++)
            {
                Form form = mdiChildren[num];
                HyperLinkEdit hyperLinkEdit = new HyperLinkEdit()
                {
                    Text = form.Text,
                    Name = form.Name,
                 //   Width = this.pcRecentList.Width - 10,
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyles.NoBorder
                };
                hyperLinkEdit.Click += new EventHandler((object s, EventArgs i) =>
                {
                    this.Execute((s as HyperLinkEdit).Name, "");
                    this.pmAppMain.HidePopup();
                });
             //   this.pcRecentList.Controls.Add(hyperLinkEdit);
            }
        }

        private void rbcMain_MinimizedChanged(object sender, EventArgs e)
        {
            (new clsAllOption()
            {
                Minimized = this.rbcMain.Minimized
            }).SaveOption();
        }


        private void SaveTheme(string themeName, string styleName)
        {
            try
            {
                DataSet dataSet = new DataSet();
                DataTable dataTable = new DataTable();
                try
                {
                    dataTable.Columns.Add("Theme", typeof(string));
                    dataTable.Columns.Add("Style", typeof(string));
                    object[] objArray = new object[] { themeName, styleName };
                    dataTable.Rows.Add(new object[0]);
                    dataTable.Rows[0][0] = objArray[0];
                    dataTable.Rows[0][1] = objArray[1];
                    dataSet.Tables.Add(dataTable);
                }
                finally
                {
                    if (dataTable != null)
                    {
                        ((IDisposable)dataTable).Dispose();
                    }
                }
                dataSet.WriteXml(this._themePath);
            }
            catch
            {
            }
        }

        private void SetSkin()
        {
            if (File.Exists(this._themePath))
            {

                    BarEditItem bbiStyle = new BarEditItem();
                if (!(this.LoadStyle() == "Classic"))
                {
                       this.bbiStyle.EditValue = "Metro";
                }
                else
                {

                //    BarEditItem bbiStyle = new BarEditItem();
                    bbiStyle.EditValue = "Classic";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarStaticItem barStaticItem = this.lblToday;
            DateTime now = DateTime.Now;
            barStaticItem.Caption = string.Concat("Thời gian: ", now.ToString("dd-MM-yyyy hh:mm:ss"));
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            HumanResource.Core.xucOrganizationEdit frm = new HumanResource.Core.xucOrganizationEdit();
           
            frm.Show();
        }

        private void frmMainHr_Load(object sender, EventArgs e)
        {
            this.LookAndFeel.SetSkinStyle("Office 2007 Blue");
          this.SetSkin();
            foreach (SkinContainer skin in SkinManager.Default.Skins)
            {
                BarCheckItem skinName = this.rbcMain.Items.CreateCheckItem(skin.SkinName, false);
                skinName.Tag = skin.SkinName;
                  skinName.ItemClick += new ItemClickEventHandler(this.OnPaintStyleClick);
                this.bbSkin.ItemLinks.Add(skinName);
            }
           //  Welcome.LoadWelcome();
        //   rbcMain.Hide();
        }

        private void rbcMain_SizeChanged(object sender, EventArgs e)
        {

        }

        private void frmMainHr_SizeChanged(object sender, EventArgs e)
        {
            clsAllOption _clsAllOption = new clsAllOption()
            {
                WindowState = base.WindowState.ToString(),
                SizeWidth = base.Width,
                SizeHeight = base.Height
            };
            _clsAllOption.SaveOption();
        }

      



        //private void TurnOnCapsLock()
        //{
        //    if (frmMain.GetKeyState(20) == 0)
        //    {
        //        this.PressKeyboardButton(Keys.Capital);
        //    }
        //}

        private void Unload()
        {
            if (this.tabMdi.Pages.Count > 0)
            {
                this.tabMdi.Pages.Clear();
            }
            //(new SendReportMail()).DeleteEmail();
            //SYS_LOG.Insert("Hệ Thống", "Kết Thúc");
        }






        private void bbiSalary1_ItemClick(object sender, ItemClickEventArgs e)
        {
            HumanResource.Core.xfmSalary frm = new HumanResource.Core.xfmSalary();
            frm.MdiParent = this;
            frm.Show();

        }

        private void bbiEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            HumanResource.Core.xfmEmployee frm = new HumanResource.Core.xfmEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbiAtt_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Execute("xfmAtt", "");
            Cursor.Current = Cursors.Default;
        }

        private void bbiContract_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Execute("xfmContract", "");
            Cursor.Current = Cursors.Default;
        }

        private void bbiShiftOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Execute("xfmShiftOrder", "");
            Cursor.Current = Cursors.Default;
        }

        private void xfmShiftOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.xfmShiftOrder = null;
        }

        private void xfmShiftOrder_SaveDataChanged(object sender)
        {
            //if (this.xfmTimekeeping != null)
            //{
            //    this.xfmTimekeeping.LoadTimeKeeperTable();
            //}
            //if (this.xfmTimekeeperTable != null)
            //{
            //    this.xfmTimekeeperTable.LoadTimekeeperTableList();
            //}
            //if (this.xfmTimekeeperOverTime != null)
            //{
            //    this.xfmTimekeeperOverTime.LoadTimekeeperTableList();
            //}
            this.tabMdi.Pages[this.xfmShiftOrder].MdiChild.Activate();
        }

        private void xfmTimekeeping_UnShiftData(object sender, int Month, int Year)
        {
          //  SYS_LOG.Insert("Bảng Xếp Ca", "Xem");
            if (this.xfmShiftOrder != null)
            {
                this.xfmShiftOrder.SetData(Month, Year);
                this.tabMdi.Pages[this.xfmShiftOrder].MdiChild.Activate();
            }
            else
            {
                xfmShiftOrder _xfmShiftOrder = new xfmShiftOrder(Month, Year)
                {
                    MdiParent = this
                };
                this.xfmShiftOrder = _xfmShiftOrder;
                this.xfmShiftOrder.FormClosing += new FormClosingEventHandler(this.xfmShiftOrder_FormClosing);
                this.xfmShiftOrder.SaveDataChanged += new xfmShiftOrder.SaveDataChangedHander(this.xfmShiftOrder_SaveDataChanged);
                this.xfmShiftOrder.Show();
            }
        }

        private void bbiTimekeeperTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Execute("xfmTimekeeperTable", "");
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Execute("xfmSalaryAllowance", "");
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Execute("xfmSalaryAllowance", "");
            Cursor.Current = Cursors.Default;
        }

        private void bbiListAdvance_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Execute("xfmListAdvance", "");
            Cursor.Current = Cursors.Default;
        }

        private void bbiListAssignment_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Execute("xfmListAssignment", "");
            Cursor.Current = Cursors.Default;
        }

        private void bbiUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Execute("xfmUsers", "");
            Cursor.Current = Cursors.Default;
        }


        private void XfmUsersFormClosing(object sender, FormClosingEventArgs e)
        {
            this.xfmUsers = null;
        }
    }
}
