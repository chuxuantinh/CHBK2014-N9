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
    public partial class xfmShift : Form
    {

        private bool _search = false;
        public xfmShift()
        {
            InitializeComponent();
            Init();
        }

        public bool IsSearch
        {
            set
            {
                this.ucList.IsSearch = value;
            }
        }

        public xfmShift(bool search)
        {
            this._search = search;
            this.InitializeComponent();
            this.Init();
        }

      
        private void Init()
        {
            SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Xem");
            this.ucList.CloseClick += new ButtonClickEventHander(this.ucList_CloseClick);
            this.ucList.Added += new xucShift.AddedEventHander(this.ucList_Added);
            this.ucList.Updated += new xucShift.UpdatedEventHander(this.ucList_Updated);
            this.ucList.Deleted += new DeletedEventHander(this.ucList_Deleted);
            this.Text = "Ca làm việc";
        }


        public void RaiseAddedEventHander(DIC_SHIFT Item)
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

        private void RaiseItemSelectedEventHander(DIC_SHIFT item)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(this, item);
            }
        }

        public void RaiseUpdatedEventHander(DIC_SHIFT Item)
        {
            if (this.Updated != null)
            {
                this.Updated(this, Item);
            }
        }

        private void ucList_Added(object sender, DIC_SHIFT Item)
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

        private void ucList_Updated(object sender, DIC_SHIFT Item)
        {
            this.RaiseUpdatedEventHander(Item);
        }

        public event xfmShift.AddedEventHander Added;

        public event DeletedEventHander Deleted;

        public event xfmShift.ItemSelectedEventHander ItemSelected;

        public event xfmShift.UpdatedEventHander Updated;

        public delegate void AddedEventHander(object sender, DIC_SHIFT Item);

        public delegate void DeletedEventHandler(object sender, RowClickEventArgs e);

        public delegate void ItemSelectedEventHander(object sender, DIC_SHIFT item);

        public delegate void UpdatedEventHander(object sender, DIC_SHIFT Item);
    }
}
