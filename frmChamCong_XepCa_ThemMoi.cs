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
    public partial class frmChamCong_XepCa_ThemMoi :DevExpress.XtraEditors.XtraForm
    {
        string _TimeKeeperTableListIDTo;
        public frmChamCong_XepCa_ThemMoi()
        {
            InitializeComponent();
            _TimeKeeperTableListIDTo = "43ee0df4-5fba-42da-9da7-33b5437d7a97";
            CT_TIMEKEEPER_TABLELIST_GetList(_TimeKeeperTableListIDTo);

            gridItem.Enabled = false;



        }

        public frmChamCong_XepCa_ThemMoi(string TimeKeeperTableListIDTo)
        {

            InitializeComponent();
            _TimeKeeperTableListIDTo = TimeKeeperTableListIDTo;
            CT_TIMEKEEPER_TABLELIST_GetList(TimeKeeperTableListIDTo);
            gridItem.Enabled = false;

        }

        string TimeKeeperTableListName;
        string TimeKeeperTableListNameFrom;
        int _Month;
        int _Year;
        void CT_TIMEKEEPER_TABLELIST_GetList(string TimeKeeperTableListIDFrom)
        {
            Class.BangXepCa xc = new Class.BangXepCa();
            DataTable dt = xc.CT_TIMEKEEPER_TABLELIST_GetList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (TimeKeeperTableListIDFrom.ToUpper() == dt.Rows[i]["TimeKeeperTableListID"].ToString().ToUpper())
                {
                    TimeKeeperTableListName = dt.Rows[i]["TimeKeeperTableListName"].ToString();
                    _Month = int.Parse(dt.Rows[i]["Month"].ToString());
                    _Year = int.Parse(dt.Rows[i]["Year"].ToString());
                    dt.Rows.RemoveAt(i);
                    break;
                }
            }
            gridItem.DataSource = dt;
        }
        private void radioBXC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioBXC.SelectedIndex == 0)
            {
                gridItem.Enabled = false;
            }
            else
            {
                gridItem.Enabled = true;
            }
        }


        private void frmChamCong_XepCa_ThemMoi_Load(object sender, EventArgs e)
        {
           
        }
        bool indicatorIcon = true;
        private void gridItemDetail_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                if (!indicatorIcon)
                {
                    e.Info.ImageIndex = -1;
                }
            }     
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            Class.BangXepCa xc = new Class.BangXepCa();
            xc.TimeKeeperTableListID = _TimeKeeperTableListIDTo;
            xc.TimeKeeperTableListIDTo = _TimeKeeperTableListIDTo;
            xc.Month = _Month;
            xc.Year = _Year;
            xc.TimeKeeperTableListName = TimeKeeperTableListName;
            if (radioBXC.SelectedIndex == 0)
            {
                if (xc.CT_TIMEKEEPER_TABLELIST_Reset())
                {
                    MessageBox.Show("Khởi tạo lại Dữ liệu thành công !");
                    Class.S_Log.Insert("Chấm công", "Khởi tạo lại dữ liệu xếp ca " + TimeKeeperTableListName);
                }
                else
                {
                    MessageBox.Show("Lổi. không thể tạo lại Dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string _TimeKeeperTableListIDFrom = gridItemDetail.GetRowCellValue(gridItemDetail.FocusedRowHandle, colTimeKeeperTableListID).ToString();
                TimeKeeperTableListNameFrom = gridItemDetail.GetRowCellValue(gridItemDetail.FocusedRowHandle, colTimeKeeperTableListName).ToString();

                if (_TimeKeeperTableListIDFrom.Length > 0)
                {
                    xc.TimeKeeperTableListIDFrom = _TimeKeeperTableListIDFrom;

                    if (xc.CT_TIMEKEEPER_SHIFT_UpdateFromOld())
                    {
                        MessageBox.Show("Khởi tạo lại Dữ liệu thành công !");
                        Class.S_Log.Insert("Chấm công", "Khởi tạo lại dữ liệu xếp ca " + TimeKeeperTableListName + " Từ tháng có sẵn " + TimeKeeperTableListNameFrom);
                    }
                    else
                    {
                        MessageBox.Show("Lổi. không thể tạo lại Dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            this.Close();
        }
    }
}
