using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xfmGroup : Form
    {

        private bool _search = false;
       

        public bool IsSearch
        {
            set
            {
                this.xucgroup.IsSearch = value;
            }
        }

        public xfmGroup()
        {
            this.InitializeComponent();
            this.Init();
        }

        public xfmGroup(bool search)
        {
            this._search = search;
            this.InitializeComponent();
            this.Init();
        }

        private void Init()
        {
          //  SYS_LOG.Insert("Danh Sách Tổ Nhóm", "Xem");
            this.xucgroup = new xucGroup();
            base.Controls.Add(this.xucgroup);
            this.xucgroup.Dock = DockStyle.Fill;
            this.xucgroup.CloseClick += new ButtonClickEventHander(this.xucgroup_CloseClick);
            this.Text = "Phòng ban";
        }


        private void RaiseItemSelectedEventHander(HRM_GROUP item)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(this, item);
            }
        }

        private void xucgroup_CloseClick(object sender)
        {
            base.Close();
        }

        public event xfmGroup.ItemSelectedEventHander ItemSelected;

        public delegate void ItemSelectedEventHander(object sender, HRM_GROUP item);
    }
}
