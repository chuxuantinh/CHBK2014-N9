using DevExpress.XtraEditors;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Security
{
    public partial class xfmUsers : Form
    {

     //   private xucUser ucList;

        private bool _search = false;

        public bool IsSearch
        {
            set
            {
                this.ucList.IsSearch = value;
            }
        }

        public xfmUsers(bool search)
        {
            this._search = search;
            this.InitializeComponent();
            this.Init();
        }
        private void Init()
        {
           // SYS_LOG.Insert("Quản Lý Người Dùng", "Xem");
            this.ucList.ReLoad();
            this.ucList.CloseClick += new ButtonClickEventHander(this.ucList_CloseClick);
            this.Text = "Quản lý User";

        }
        public xfmUsers()
        {
            InitializeComponent();
            Init();
        }

        private void RaiseItemSelectedEventHander(SYS_USER item)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(this, item);
            }
        }

        private void ucList_CloseClick(object sender)
        {
            base.Close();
        }

        public event xfmUsers.ItemSelectedEventHander ItemSelected;

        public delegate void ItemSelectedEventHander(object sender, SYS_USER item);
    }
}
