using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class  xfmDictionnary :Form
    {

        private xucLanguage xucLanguage;
        private xucBranch xucBranch;
        private xucPosition xucPosition;
        private xucProfessional xucProfessional;
        private xucReligion xucReligion;
        private xucJob xucJob;
        private xucAllowance xucAllowance;
        private xucDegree xucDegree;
        private xucDepartment xucDepartment;
        private xucSubsidiary xucSubsidiary;
        private xucEducation xucEducation;
        private xucEthnic xucEthnic;
        private xucGroup xucGroup;
        private xucGroupRate xucGroupRate;
        private xucHoliday xucHoliday;
        private xucInformatic xucInformatic;
        private xucMachine xucMachine;
        private xucNationality xucNationality;
        private xucProvince xucProvince;
        private xucRank xucRank;
        private xucRate xucRate;
        private xucRelative xucRelative;
        private xucShift xucShift;
        private xucSkill xucSkill;
        private xucStep xucStep;
        private xucState xucState;
        private xucUnit xucUnit;
        private xucSymbol xucSymbol;
        public xfmDictionnary()
        {
            InitializeComponent();
         base.Load += new EventHandler(xfmDictionnary_Load);
        }

    


        private static string LoadStyle()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\Theme.xml"));
            string str = dataSet.Tables[0].Rows[0][1].ToString();
            return str;
        }

        public void SetStyle(string Style)
        {
            if (!(Style == "Classic"))
            {
                this.navBarControl1.SmallImages = this.imgMetro;
            }
            else
            {
                this.navBarControl1.SmallImages = this.imgClassic;
            }
        }

        private void Execute(string id, string @ref)
        {
            string str = id;
            if (str != null)
            {
                switch (str)
                {
                    case "xucLanguage":
                        {
                            //  xucLanguage xuclang = new xucLanguage();
                            // SYS_LOG.Insert("Danh Mục Ngoại Ngữ", "Xem");
                            this.gcControl.Text = this.bbiLanguage.Caption;
                            if (xucLanguage != null)
                            {
                                xucLanguage.BringToFront();
                            }
                            else
                            {
                                xucLanguage xuclang = new xucLanguage();
                                {
                                    Dock = DockStyle.Fill;
                                }
                                this.gcControl.Controls.Add(xuclang);
                                xuclang.BringToFront();
                            }
                            break;
                        }
                    case "xucProfessional":
                        {
                           // SYS_LOG.Insert("Danh Mục Chuyên Môn", "Xem");
                            this.gcControl.Text = this.bbiProfessional.Caption;
                            if (this.xucProfessional != null)
                            {
                                this.xucProfessional.BringToFront();
                            }
                            else
                            {
                                this.xucProfessional = new xucProfessional()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucProfessional);
                                this.xucProfessional.BringToFront();
                            }
                            break;
                        }
                    case "xucDegree":
                        {
                            // SYS_LOG.Insert("Danh Mục Bằng Cấp", "Xem");
                           
                            this.gcControl.Text = this.bbiDegree.Caption;
                            if (this.xucDegree != null)
                            {
                                this.xucDegree.BringToFront();
                            }
                            else
                            {
                                this.xucDegree = new xucDegree()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucDegree);
                                this.xucDegree.BringToFront();
                            }
                            break;
                        }
                    case "xucJob":
                        {
                            //  SYS_LOG.Insert("Danh Mục Công Việc", "Xem");
                         //   this.xucJob = new xucJob();
                            this.gcControl.Text = this.bbiJob.Caption;
                            if (this.xucJob != null)
                            {
                                this.xucJob.BringToFront();
                            }
                            else
                            {
                                this.xucJob = new xucJob();
                                {
                                    Dock = DockStyle.Fill;
                                }
                                this.gcControl.Controls.Add(this.xucJob);
                                this.xucJob.BringToFront();
                            }
                            break;
                        }
                    case "xucNationality":
                        {
                          //  SYS_LOG.Insert("Danh Mục Quốc Tịch", "Xem");
                            this.gcControl.Text = this.bbiNationality.Caption;
                            if (this.xucNationality != null)
                            {
                                this.xucNationality.BringToFront();
                            }
                            else
                            {
                                this.xucNationality = new xucNationality()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucNationality);
                                this.xucNationality.BringToFront();
                            }
                            break;
                        }
                    case "xucEthnic":
                        {
                          //  SYS_LOG.Insert("Danh Mục Dân Tộc", "Xem");
                            this.gcControl.Text = this.bbiEthnic.Caption;
                            if (this.xucEthnic != null)
                            {
                                this.xucEthnic.BringToFront();
                            }
                            else
                            {
                                this.xucEthnic = new xucEthnic()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucEthnic);
                                this.xucEthnic.BringToFront();
                            }
                            break;
                        }
                    case "xucReligion":
                        {
                          //  SYS_LOG.Insert("Danh Mục Tôn Giáo", "Xem");
                            this.gcControl.Text = this.bbiReligion.Caption;
                            if (this.xucReligion != null)
                            {
                                this.xucReligion.BringToFront();
                            }
                            else
                            {
                                this.xucReligion = new xucReligion()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucReligion);
                                this.xucReligion.BringToFront();
                            }
                            break;
                        }
                    case "xucRelative":
                        {
                         //   SYS_LOG.Insert("Danh Mục Quan Hệ Gia Đình", "Xem");
                            this.gcControl.Text = this.bbiRelative.Caption;
                            if (this.xucRelative != null)
                            {
                                this.xucRelative.BringToFront();
                            }
                            else
                            {
                                this.xucRelative = new xucRelative()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucRelative);
                                this.xucRelative.BringToFront();
                            }
                            break;
                        }
                    case "xucEducation":
                        {
                           // SYS_LOG.Insert("Danh Mục Học Vấn", "Xem");
                            this.gcControl.Text = this.bbiEducation.Caption;
                            if (this.xucEducation != null)
                            {
                                this.xucEducation.BringToFront();
                            }
                            else
                            {
                                this.xucEducation = new xucEducation()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucEducation);
                                this.xucEducation.BringToFront();
                            }
                            break;
                        }
                    case "xucInformatic":
                        {
                          //  SYS_LOG.Insert("Danh Mục Tin Học", "Xem");
                            this.gcControl.Text = this.bbiInformatic.Caption;
                            if (this.xucInformatic != null)
                            {
                                this.xucInformatic.BringToFront();
                            }
                            else
                            {
                                this.xucInformatic = new xucInformatic()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucInformatic);
                                this.xucInformatic.BringToFront();
                            }
                            break;
                        }
                    case "xucPosition":
                        {

                            xucPosition xucPosition = new xucPosition();
                        //    SYS_LOG.Insert("Danh Mục Chức Vụ", "Xem");
                            this.gcControl.Text = this.bbiPosition.Caption;
                            if (this.xucPosition != null)
                            {
                                this.xucPosition.BringToFront();
                            }
                            else
                            {
                                this.xucPosition = new xucPosition()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucPosition);
                                this.xucPosition.BringToFront();
                            }
                            break;
                        }
                    case "xucSkill":
                        {
                         //   SYS_LOG.Insert("Danh Mục Kỹ Năng", "Xem");
                            this.gcControl.Text = this.bbiSkill.Caption;
                            if (this.xucSkill != null)
                            {
                                this.xucSkill.BringToFront();
                            }
                            else
                            {
                                this.xucSkill = new xucSkill()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucSkill);
                                this.xucSkill.BringToFront();
                            }
                            break;
                        }
                    case "xucRate":
                        {
                          //  SYS_LOG.Insert("Danh Mục Tiêu Chí Đánh Giá", "Xem");
                            this.gcControl.Text = this.bbiRate.Caption;
                            if (this.xucRate != null)
                            {
                                this.xucRate.BringToFront();
                            }
                            else
                            {
                                this.xucRate = new xucRate()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucRate);
                                this.xucRate.BringToFront();
                            }
                            break;
                        }
                    case "xucGroupRate":
                        {
                           // SYS_LOG.Insert("Danh Mục Tiêu Chí Đánh Giá", "Xem");
                            this.gcControl.Text = this.bbiGroupRate.Caption;
                            if (this.xucGroupRate != null)
                            {
                                this.xucGroupRate.BringToFront();
                            }
                            else
                            {
                                this.xucGroupRate = new xucGroupRate()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucGroupRate);
                                this.xucGroupRate.BringToFront();
                            }
                            break;
                        }
                    case "xucSubsidiary":
                        {
                           // SYS_LOG.Insert("Công Ty Con", "Xem");
                            this.gcControl.Text = this.bbiSubsidiary.Caption;
                            if (this.xucSubsidiary != null)
                            {
                                this.xucSubsidiary.BringToFront();
                            }
                            else
                            {
                                this.xucSubsidiary = new xucSubsidiary()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucSubsidiary);
                                this.xucSubsidiary.BringToFront();
                            }
                            break;
                        }
                    case "xucBranch":
                        {
                          //  SYS_LOG.Insert("Chi Nhánh Công Ty", "Xem");
                            this.gcControl.Text = this.bbiBranch.Caption;
                            if (this.xucBranch != null)
                            {
                                this.xucBranch.BringToFront();
                            }
                            else
                            {
                                this.xucBranch = new xucBranch()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucBranch);
                                this.xucBranch.BringToFront();
                            }
                            break;
                        }
                    case "xucDepartment":
                        {
                         //   SYS_LOG.Insert("Danh Sách Phòng Ban", "Xem");
                            this.gcControl.Text = this.bbiDepartment.Caption;
                            if (this.xucDepartment != null)
                            {
                                this.xucDepartment.BringToFront();
                            }
                            else
                            {
                                this.xucDepartment = new xucDepartment()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucDepartment);
                                this.xucDepartment.BringToFront();
                            }
                            break;
                        }
                    case "xucGroup":
                        {
                          //  SYS_LOG.Insert("Các Tổ, Nhóm", "Xem");
                            this.gcControl.Text = this.bbiGroup.Caption;
                            if (this.xucGroup != null)
                            {
                                this.xucGroup.BringToFront();
                            }
                            else
                            {
                                this.xucGroup = new xucGroup()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucGroup);
                                this.xucGroup.BringToFront();
                            }
                            break;
                        }
                    case "xucShift":
                        {
                         //   SYS_LOG.Insert("Ca Làm Việc", "Xem");
                            this.gcControl.Text = this.bbiShift.Caption;
                            if (this.xucShift != null)
                            {
                                this.xucShift.BringToFront();
                            }
                            else
                            {
                                this.xucShift = new xucShift()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucShift);
                                this.xucShift.BringToFront();
                            }
                            break;
                        }
                    case "xucSymbol":
                        {
                          //  SYS_LOG.Insert("Ký Hiệu Chấm Công", "Xem");
                            this.gcControl.Text = this.bbiSymbol.Caption;
                            if (this.xucSymbol != null)
                            {
                                this.xucSymbol.BringToFront();
                            }
                            else
                            {
                                this.xucSymbol = new xucSymbol()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucSymbol);
                                this.xucSymbol.BringToFront();
                            }
                            break;
                        }
                    case "xucMachine":
                        {
                         //   SYS_LOG.Insert("Danh Sách Thiết Bị", "Xem");
                            this.gcControl.Text = this.bbiMachine.Caption;
                            if (this.xucMachine != null)
                            {
                                this.xucMachine.BringToFront();
                            }
                            else
                            {
                                this.xucMachine = new xucMachine()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucMachine);
                                this.xucMachine.BringToFront();
                            }
                            break;
                        }
                    case "xucHoliday":
                        {
                            //SYS_LOG.Insert("Ngày Nghỉ, Ngày Lễ", "Xem");
                            this.gcControl.Text = this.bbiHoliday.Caption;
                            if (this.xucHoliday != null)
                            {
                                this.xucHoliday.BringToFront();
                            }
                            else
                            {
                                this.xucHoliday = new xucHoliday()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucHoliday);
                                this.xucHoliday.BringToFront();
                            }
                            break;
                        }
                    case "xucUnit":
                        {
                      //      SYS_LOG.Insert("Đơn Vị Tính", "Xem");
                            this.gcControl.Text = this.bbiUnit.Caption;
                            if (this.xucUnit != null)
                            {
                                this.xucUnit.BringToFront();
                            }
                            else
                            {
                                this.xucUnit = new xucUnit()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucUnit);
                                this.xucUnit.BringToFront();
                            }
                            break;
                        }
                    //case "xucProductGroup":
                    //    {
                    //        SYS_LOG.Insert("Nhóm Sản Phẩm", "Xem");
                    //        this.gcControl.Text = this.bbiProductGroup.Caption;
                    //        if (this.xucProductGroup != null)
                    //        {
                    //            this.xucProductGroup.BringToFront();
                    //        }
                    //        else
                    //        {
                    //            this.xucProductGroup = new xucProductGroup()
                    //            {
                    //                Dock = DockStyle.Fill
                    //            };
                    //            this.gcControl.Controls.Add(this.xucProductGroup);
                    //            this.xucProductGroup.BringToFront();
                    //        }
                    //        break;
                    //    }
                    //case "xucProduct":
                    //    {
                    //        SYS_LOG.Insert("Sản Phẩm", "Xem");
                    //        this.gcControl.Text = this.bbiProduct.Caption;
                    //        if (this.xucProduct != null)
                    //        {
                    //            this.xucProduct.BringToFront();
                    //        }
                    //        else
                    //        {
                    //            this.xucProduct = new xucProduct()
                    //            {
                    //                Dock = DockStyle.Fill
                    //            };
                    //            this.gcControl.Controls.Add(this.xucProduct);
                    //            this.xucProduct.BringToFront();
                    //        }
                    //        break;
                    //    }
                    case "xucState":
                        {
                           // SYS_LOG.Insert("Công Đoạn", "Xem");
                            this.gcControl.Text = this.bbiState.Caption;
                            if (this.xucState != null)
                            {
                                this.xucState.BringToFront();
                            }
                            else
                            {
                                this.xucState = new xucState()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucState);
                                this.xucState.BringToFront();
                            }
                            break;
                        }
                    case "xucRank":
                        {
                           // SYS_LOG.Insert("Ngạch Lương", "Xem");
                            this.gcControl.Text = this.bbiRank.Caption;
                            if (this.xucRank != null)
                            {
                                this.xucRank.BringToFront();
                            }
                            else
                            {
                                this.xucRank = new xucRank()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucRank);
                                this.xucRank.BringToFront();
                            }
                            break;
                        }
                    case "xucStep":
                        {
                          //  SYS_LOG.Insert("Bậc Lương", "Xem");
                            this.gcControl.Text = this.bbiStep.Caption;
                            if (this.xucStep != null)
                            {
                                this.xucStep.BringToFront();
                            }
                            else
                            {
                                this.xucStep = new xucStep()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucStep);
                                this.xucStep.BringToFront();
                            }
                            break;
                        }
                    case "xucAllowance":
                        {
                          //  SYS_LOG.Insert("Phụ Cấp", "Xem");
                           this.gcControl.Text = this.bbiAllowance.Caption;
                            if (xucAllowance != null)
                            {
                                this.xucAllowance.BringToFront();
                            }
                            else
                            {
                                this.xucAllowance = new xucAllowance()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucAllowance);
                                this.xucAllowance.BringToFront();
                            }
                            break;
                        }



                    case "xucProvince":
                        {
                            //  SYS_LOG.Insert("Phụ Cấp", "Xem");
                            this.gcControl.Text = this.bbiProvince.Caption;
                            if (xucProvince != null)
                            {
                                this.xucProvince.BringToFront();
                            }
                            else
                            {
                                this.xucProvince = new xucProvince()
                                {
                                    Dock = DockStyle.Fill
                                };
                                this.gcControl.Controls.Add(this.xucProvince);
                                this.xucProvince.BringToFront();
                            }
                            break;
                        }
                }
            }
        }

        private void xfmDictionnary_Load(object sender, EventArgs e)
        {
          this.SetStyle(xfmDictionnary.LoadStyle());
            this.Execute("xucLanguage", "");
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void bbiLangguage_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Execute("xucLanguage", "");
        }

        private void bbiLangguage_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            Execute("xucLanguage", "");
        }

        private void bbiBranch_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Execute("xucBranch", "");
        }

        private void navBarItem3_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Execute("xucPosition", "");
        }

        private void bbiProfessional_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Execute("xucProfessional", "");
        }

        private void bbiReligion_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Execute("xucReligion", "");
        }

        private void bbiPosition_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Execute("xucPosition", "");
        }

        private void bbiJob_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucJob", "");
        }

        private void navBarItem1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucAllowance", "");
        }

        private void bbiEducation_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucDegree", "");
        }

        private void bbiDepartment_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucDepartment", "");
        }

        private void bbiSubsidiary_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucSubsidiary", "");
        }

        private void bbiEducation_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucEducation", "");
        }

        private void bbiEthnic_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucEthnic", "");
        }

        private void bbiGroup_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucGroup","");
        }

        private void bbiGroupRate_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucGroupRate", "");
        }

        private void bbiHoliday_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucHoliday", "");
        }

        private void bbiInformatic_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucInformatic", "");
        }

        private void bbiMachine_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucMachine", "");
        }

        private void bbiNationlity_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucNationality", "");
        }

        private void bbiProvince_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucProvince","");
        }

        private void bbiRank_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucRank", "");
        }

        private void bbiRate_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucRate", "");
        }

        private void bbiRelative_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucRelative", "");
        }

        private void bbiShift_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucShift", "");
        }

        private void bbiSkill_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucSkill", "");
        }

        private void bbiStep_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucStep", "");
        }

        private void bbiState_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucState", "");
        }

        private void bbiSymbol_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucSymbol", "");
        }

        private void bbiUnit_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Execute("xucUnit","");
        }
    }
}
