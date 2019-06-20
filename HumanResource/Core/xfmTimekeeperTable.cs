using DevExpress.XtraEditors;
using CHBK2014_N9.HumanResource.Core.Class;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmTimekeeperTable : XtraForm
    {

        public xucTimekeeperTable1 xucTimekeeperTable1;
      //  public xucTimekeeperTable xucTimekeeperTable = new Core.xucTimekeeperTable;
        //   public xucTimekeeperTable 
        public xucTimekeeperTableHour xucTimekeeperTableHour;
        public xfmTimekeeperTable()
        {
            InitializeComponent();
            base.Load += new EventHandler(this.xfmTimekeeperTable_Load);
        }

        private void LoadTimekeeperExtraPrivate()
        {
            //this.xucTimekeeperExtraPrivate = new xucTimekeeperExtraPrivate();
            //this.xucTimekeeperExtraPrivate.Closed += new xucTimekeeperExtraPrivate.ClosedHandler(this.xucTimekeeperTable_Closed);
            //this.xucTimekeeperExtraPrivate.UnShiftData += new xucTimekeeperExtraPrivate.UnShiftDataHandler((object s, int m, int y) => this.RaiseUnShiftDataHandler(m, y));
            //this.xucTimekeeperExtraPrivate.TimekeeperTableDeleted += new xucTimekeeperExtraPrivate.TimekeeperTableDeletedHandler((object s) => this.RaiseTimekeeperTableDeletedHander());
            //this.xucTimekeeperExtraPrivate.TimekeeperTableSelected += new xucTimekeeperExtraPrivate.TimekeeperTableSelectedHandler((object s, string code, Guid tID, int year, int mSelected) => {
            //    if (mSelected == 0)
            //    {
            //        if (this.xucTimekeeperTable == null)
            //        {
            //            this.LoadTimekeeperTable();
            //            this.xucTimekeeperTable.SetTimeKeeperTableList(tID, year);
            //            this.xucTimekeeperTable.xucOrganization1.SetFocusedNode(code);
            //        }
            //        else
            //        {
            //            this.xucTimekeeperTable.BringToFront();
            //            this.xucTimekeeperTable.SetTimeKeeperTableList(tID, year);
            //            this.xucTimekeeperTable.xucOrganization1.SetFocusedNode(code);
            //        }
            //    }
            //    else if (mSelected == 1)
            //    {
            //        if (this.xucTimekeeperTable1 == null)
            //        {
            //            this.LoadTimekeeperTable1();
            //            this.xucTimekeeperTable1.SetTimeKeeperTableList(tID, year);
            //            this.xucTimekeeperTable1.xucOrganization1.SetFocusedNode(code);
            //        }
            //        else
            //        {
            //            this.xucTimekeeperTable1.BringToFront();
            //            this.xucTimekeeperTable1.SetTimeKeeperTableList(tID, year);
            //            this.xucTimekeeperTable1.xucOrganization1.SetFocusedNode(code);
            //        }
            //    }
            //    else if (mSelected == 2)
            //    {
            //        if (this.xucTimekeeperTableHour == null)
            //        {
            //            this.LoadTimekeeperTableHour();
            //            this.xucTimekeeperTableHour.SetTimeKeeperTableList(tID, year);
            //            this.xucTimekeeperTableHour.xucOrganization1.SetFocusedNode(code);
            //        }
            //        else
            //        {
            //            this.xucTimekeeperTableHour.BringToFront();
            //            this.xucTimekeeperTableHour.SetTimeKeeperTableList(tID, year);
            //            this.xucTimekeeperTableHour.xucOrganization1.SetFocusedNode(code);
            //        }
            //    }
            //});
            //this.xucTimekeeperExtraPrivate.Dock = DockStyle.Fill;
            //base.Controls.Add(this.xucTimekeeperExtraPrivate);
            //this.xucTimekeeperExtraPrivate.BringToFront();
        }

        private void LoadTimekeeperTable()
        {
            this.xucTimekeeperTable = new xucTimekeeperTable();
            this.xucTimekeeperTable.Closed += new xucTimekeeperTable.ClosedHandler(this.xucTimekeeperTable_Closed);
            this.xucTimekeeperTable.UnShiftData += new xucTimekeeperTable.UnShiftDataHandler((object s, int m, int y) => this.RaiseUnShiftDataHandler(m, y));
            this.xucTimekeeperTable.TimekeeperTableDeleted += new xucTimekeeperTable.TimekeeperTableDeletedHandler((object s) => this.RaiseTimekeeperTableDeletedHander());
            this.xucTimekeeperTable.TimekeeperTableHourSelected += new xucTimekeeperTable.TimekeeperTableHourSelectedHandler((object s, string code, Guid tID, int year, int mSelected) => {
                if (mSelected == 0)
                {
                    if (this.xucTimekeeperTable1 == null)
                    {
                        this.LoadTimekeeperTable1();
                        this.xucTimekeeperTable1.SetTimeKeeperTableList(tID, year);
                        this.xucTimekeeperTable1.xucOrganization1.SetFocusedNode(code);
                    }
                    else
                    {
                        this.xucTimekeeperTable1.BringToFront();
                        this.xucTimekeeperTable1.SetTimeKeeperTableList(tID, year);
                        this.xucTimekeeperTable1.xucOrganization1.SetFocusedNode(code);
                    }
                }
                else if (mSelected == 1)
                {
                    if (this.xucTimekeeperTableHour == null)
                    {
                        this.LoadTimekeeperTableHour();
                        this.xucTimekeeperTableHour.SetTimeKeeperTableList(tID, year);
                        this.xucTimekeeperTableHour.xucOrganization1.SetFocusedNode(code);
                    }
                    else
                    {
                        this.xucTimekeeperTableHour.BringToFront();
                        this.xucTimekeeperTableHour.SetTimeKeeperTableList(tID, year);
                        this.xucTimekeeperTableHour.xucOrganization1.SetFocusedNode(code);
                    }
                }
                //else if (mSelected == 2)
                //{
                //    if (this.xucTimekeeperExtraPrivate == null)
                //    {
                //        this.LoadTimekeeperExtraPrivate();
                //        this.xucTimekeeperExtraPrivate.SetTimeKeeperTableList(tID, year);
                //        this.xucTimekeeperExtraPrivate.xucOrganization1.SetFocusedNode(code);
                //    }
                //    else
                //    {
                //        this.xucTimekeeperExtraPrivate.BringToFront();
                //        this.xucTimekeeperExtraPrivate.SetTimeKeeperTableList(tID, year);
                //        this.xucTimekeeperExtraPrivate.xucOrganization1.SetFocusedNode(code);
                //    }
                //}
            });
            this.xucTimekeeperTable.Dock = DockStyle.Fill;
            base.Controls.Add(this.xucTimekeeperTable);
            this.xucTimekeeperTable.BringToFront();
        }

        private void LoadTimekeeperTable1()
        {
            this.xucTimekeeperTable1 = new xucTimekeeperTable1();
            this.xucTimekeeperTable1.Closed += new xucTimekeeperTable1.ClosedHandler(this.xucTimekeeperTable_Closed);
            this.xucTimekeeperTable1.UnShiftData += new xucTimekeeperTable1.UnShiftDataHandler((object s, int m, int y) => this.RaiseUnShiftDataHandler(m, y));
            this.xucTimekeeperTable1.TimekeeperTableDeleted += new xucTimekeeperTable1.TimekeeperTableDeletedHandler((object s) => this.RaiseTimekeeperTableDeletedHander());
            this.xucTimekeeperTable1.TimekeeperTableHourSelected += new xucTimekeeperTable1.TimekeeperTableHourSelectedHandler((object s, string code, Guid tID, int year, int mSelected) =>
            {
                if (mSelected == 0)
                {
                    if (this.xucTimekeeperTable == null)
                    {
                        this.LoadTimekeeperTable();
                        this.xucTimekeeperTable.SetTimeKeeperTableList(tID, year);
                        this.xucTimekeeperTable.xucOrganization1.SetFocusedNode(code);
                    }
                    else
                    {
                        this.xucTimekeeperTable.BringToFront();
                        this.xucTimekeeperTable.SetTimeKeeperTableList(tID, year);
                        this.xucTimekeeperTable.xucOrganization1.SetFocusedNode(code);
                    }
                }
                else if (mSelected == 1)
                {
                    if (this.xucTimekeeperTableHour == null)
                    {
                        this.LoadTimekeeperTableHour();
                        this.xucTimekeeperTableHour.SetTimeKeeperTableList(tID, year);
                        this.xucTimekeeperTableHour.xucOrganization1.SetFocusedNode(code);
                    }
                    else
                    {
                        this.xucTimekeeperTableHour.BringToFront();
                        this.xucTimekeeperTableHour.SetTimeKeeperTableList(tID, year);
                        this.xucTimekeeperTableHour.xucOrganization1.SetFocusedNode(code);
                    }
                }
                //else if (mSelected == 2)
                //{
                //    if (this.xucTimekeeperExtraPrivate == null)
                //    {
                //        this.LoadTimekeeperExtraPrivate();
                //        this.xucTimekeeperExtraPrivate.SetTimeKeeperTableList(tID, year);
                //        this.xucTimekeeperExtraPrivate.xucOrganization1.SetFocusedNode(code);
                //    }
                //    else
                //    {
                //        this.xucTimekeeperExtraPrivate.BringToFront();
                //        this.xucTimekeeperExtraPrivate.SetTimeKeeperTableList(tID, year);
                //        this.xucTimekeeperExtraPrivate.xucOrganization1.SetFocusedNode(code);
                //    }
                //}
            });
            this.xucTimekeeperTable1.Dock = DockStyle.Fill;
            base.Controls.Add(this.xucTimekeeperTable1);
            this.xucTimekeeperTable1.BringToFront();
        }

        private void LoadTimekeeperTableHour()
        {
            this.xucTimekeeperTableHour = new xucTimekeeperTableHour();
            this.xucTimekeeperTableHour.Closed += new xucTimekeeperTableHour.ClosedHandler(this.xucTimekeeperTable_Closed);
            this.xucTimekeeperTableHour.UnShiftData += new xucTimekeeperTableHour.UnShiftDataHandler((object s, int m, int y) => this.RaiseUnShiftDataHandler(m, y));
            this.xucTimekeeperTableHour.TimekeeperTableDeleted += new xucTimekeeperTableHour.TimekeeperTableDeletedHandler((object s) => this.RaiseTimekeeperTableDeletedHander());
            this.xucTimekeeperTableHour.TimekeeperTableSelected += new xucTimekeeperTableHour.TimekeeperTableSelectedHandler((object s, string code, Guid tID, int year, int mSelected) =>
            {
                if (mSelected == 0)
                {
                if (this.xucTimekeeperTable == null)
                {
                    this.LoadTimekeeperTable();
                    this.xucTimekeeperTable.SetTimeKeeperTableList(tID, year);
                    this.xucTimekeeperTable.xucOrganization1.SetFocusedNode(code);
                }
                else
                {
                    this.xucTimekeeperTable.BringToFront();
                    this.xucTimekeeperTable.SetTimeKeeperTableList(tID, year);
                    this.xucTimekeeperTable.xucOrganization1.SetFocusedNode(code);
                }
            }
                else if (mSelected == 1)
            {
                if (this.xucTimekeeperTable1 == null)
                {
                    this.LoadTimekeeperTable1();
                    this.xucTimekeeperTable1.SetTimeKeeperTableList(tID, year);
                    this.xucTimekeeperTable1.xucOrganization1.SetFocusedNode(code);
                }
                else
                {
                    this.xucTimekeeperTable1.BringToFront();
                    this.xucTimekeeperTable1.SetTimeKeeperTableList(tID, year);
                    this.xucTimekeeperTable1.xucOrganization1.SetFocusedNode(code);
                }
            }
            //else if (mSelected == 2)
            //{
            //    if (this.xucTimekeeperExtraPrivate == null)
            //    {
            //        this.LoadTimekeeperExtraPrivate();
            //        this.xucTimekeeperExtraPrivate.SetTimeKeeperTableList(tID, year);
            //        this.xucTimekeeperExtraPrivate.xucOrganization1.SetFocusedNode(code);
            //    }
            //    else
            //    {
            //        this.xucTimekeeperExtraPrivate.BringToFront();
            //        this.xucTimekeeperExtraPrivate.SetTimeKeeperTableList(tID, year);
            //        this.xucTimekeeperExtraPrivate.xucOrganization1.SetFocusedNode(code);
            //    }
            //}
        });
            this.xucTimekeeperTableHour.Dock = DockStyle.Fill;
            base.Controls.Add(this.xucTimekeeperTableHour);
            this.xucTimekeeperTableHour.BringToFront();
        }

    public void LoadTimekeeperTableList()
        {
            if (this.xucTimekeeperTable != null)
            {
                this.xucTimekeeperTable.LoadTimeKeeperTableList();
            }


            {
                this.xucTimekeeperTableHour.LoadTimeKeeperTableList();
            }
            //if (this.xucTimekeeperExtraPrivate != null)
            //{
            //    this.xucTimekeeperExtraPrivate.LoadTimeKeeperTableList();
            //}
        }

        private void RaiseClosedHandler()
        {
            if (this.Closed != null)
            {
                this.Closed(this);
            }
        }

        private void RaiseTimekeeperTableDeletedHander()
        {
            if (this.TimekeeperTableDeleted != null)
            {
                this.TimekeeperTableDeleted(this);
            }
        }

        private void RaiseTimekeeperTableInsertedHander()
        {
            if (this.TimekeeperTableInserted != null)
            {
                this.TimekeeperTableInserted(this);
            }
        }

        private void RaiseUnShiftDataHandler(int Month, int Year)
        {
            if (this.UnShiftData != null)
            {
                this.UnShiftData(this, Month, Year);
            }
        }

        public void SaveBeforeClose()
        {
            if (this.xucTimekeeperTable.dt_Timekeeper.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu lại dữ liệu đã thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    if (!this.xucTimekeeperTable.SaveData())
                    {
                        XtraMessageBox.Show("Lưu thất bại!");
                    }
                }
            }
        }

        private void xfmTimekeeperTable_Load(object sender, EventArgs e)
        {
            clsTimeKeeperOption _clsTimeKeeperOption = new clsTimeKeeperOption();
            if (_clsTimeKeeperOption.TimeKeeperTableDefault == 0)
            {
                this.LoadTimekeeperTable();
            }
            else if (_clsTimeKeeperOption.TimeKeeperTableDefault == 1)
            {
                this.LoadTimekeeperTable1();
            }
            else if (_clsTimeKeeperOption.TimeKeeperTableDefault == 2)
            {
               this.LoadTimekeeperTableHour();
            }
            else if (_clsTimeKeeperOption.TimeKeeperTableDefault == 3)
            {
                this.LoadTimekeeperExtraPrivate();
            }
        }

        private void xfmTimekeeperTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.Close();
        }


        private void xucTimekeeperTable_Closed(object sender)
        {
           base.Close();
        }

        public event xfmTimekeeperTable.ClosedHandler Closed;

        public event xfmTimekeeperTable.TimekeeperTableDeletedHandler TimekeeperTableDeleted;

        public event xfmTimekeeperTable.TimekeeperTableInsertedHandler TimekeeperTableInserted;

        public event xfmTimekeeperTable.UnShiftDataHandler UnShiftData;

        public delegate void ClosedHandler(object sender);

        public delegate void TimekeeperTableDeletedHandler(object sender);

        public delegate void TimekeeperTableInsertedHandler(object sender);

        public delegate void UnShiftDataHandler(object sender, int Month, int Year);

        private void xfmTimekeeperTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            RaiseClosedHandler();
        }
    }
}
