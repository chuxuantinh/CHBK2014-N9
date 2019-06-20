using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace CHBK2014_N9.Dictionnary
{
    public partial class xfmSchool : XtraForm
    {
        private bool _search = false;


        public bool IsSearch
        {
            set
            {
                this.ucList.IsSearch = value;
            }
        }

        public xfmSchool(bool search)
        {
            this._search = search;
            this.InitializeComponent();
            this.Init();
        }

        public xfmSchool()
        {
            this.InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            SYS_LOG.Insert("Danh Mục Trường Học", "Xem");
            this.ucList.CloseClick += new ButtonClickEventHander(this.ucList_CloseClick);
            this.ucList.Added += new xucSchool.AddedEventHander(this.ucList_Added);
            this.ucList.Updated += new xucSchool.UpdatedEventHander(this.ucList_Updated);
            this.ucList.Deleted += new DeletedEventHander(this.ucList_Deleted);
            this.Text = "Trường đào tạo";
        }

        public void RaiseAddedEventHander(DIC_SCHOOL Item)
        {
            if (this.Added != null)
            {
                this.Added(this, Item);
            }
        }

        public void RaiseDeletedEventHander(RowClickEventArgs e)
        {
            if (this.Deleted != null)
            {
                this.Deleted(this, e);
            }
        }

        private void RaiseItemSelectedEventHander(DIC_SCHOOL item)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(this, item);
            }
        }

        public void RaiseUpdatedEventHander(DIC_SCHOOL Item)
        {
            if (this.Updated != null)
            {
                this.Updated(this, Item);
            }
        }

        private void ucList_Added(object sender, DIC_SCHOOL Item)
        {
            this.RaiseAddedEventHander(Item);
        }

        private void ucList_CloseClick(object sender)
        {
            base.Close();
        }

        private void ucList_Deleted(object sender, RowClickEventArgs e)
        {
            this.RaiseDeletedEventHander(e);
        }

        private void ucList_Updated(object sender, DIC_SCHOOL Item)
        {
            this.RaiseUpdatedEventHander(Item);
        }

        public event xfmSchool.AddedEventHander Added;

        public event DeletedEventHander Deleted;

        public event xfmSchool.ItemSelectedEventHander ItemSelected;

        public event xfmSchool.UpdatedEventHander Updated;

        public delegate void AddedEventHander(object sender, DIC_SCHOOL Item);

        public delegate void DeletedEventHandler(object sender, RowClickEventArgs e);

        public delegate void ItemSelectedEventHander(object sender, DIC_SCHOOL item);

        public delegate void UpdatedEventHander(object sender, DIC_SCHOOL Item);

        private void xfmSchool_Load(object sender, EventArgs e)
        {

        }
    }
}
