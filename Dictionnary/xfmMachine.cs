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
    public partial class xfmMachine : XtraForm
    {
        public xfmMachine()
        {
            InitializeComponent();
        }

        private bool _search = false;

        public bool IsSearch
        {
            set
            {
                this.ucList.IsSearch = value;
            }
        }

        public xfmMachine(bool search)
        {
            this._search = search;
            this.InitializeComponent();
            this.Init();
        }
        


        private void Init()
        {
            SYS_LOG.Insert("Danh Sách Thiết Bị", "Xem");
            this.ucList.CloseClick += new ButtonClickEventHander(this.ucList_CloseClick);
            this.ucList.Added += new xucMachine.AddedEventHander(this.ucList_Added);
            this.ucList.Updated += new xucMachine.UpdatedEventHander(this.ucList_Updated);
            this.ucList.Deleted += new xucMachine.DeletedEventHandler(this.ucList_Deleted);
            this.Text = "Máy chấm công";
        }


        public void RaiseAddedEventHander(DIC_MACHINE Item)
        {
            if (this.Added != null)
            {
                this.Added(this, Item);
            }
        }

        public void RaiseDeletedEventHander(DIC_MACHINE Item, RowClickEventArgs e)
        {
            if (this.Deleted != null)
            {
                this.Deleted(this, Item, e);
            }
        }

        private void RaiseItemSelectedEventHander(DIC_MACHINE item)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(this, item);
            }
        }

        public void RaiseUpdatedEventHander(DIC_MACHINE Item)
        {
            if (this.Updated != null)
            {
                this.Updated(this, Item);
            }
        }

        private void ucList_Added(object sender, DIC_MACHINE Item)
        {
            this.RaiseAddedEventHander(Item);
        }

        private void ucList_CloseClick(object sender)
        {
            base.Close();
        }

        private void ucList_Deleted(object sender, DIC_MACHINE Item, RowClickEventArgs e)
        {
            this.RaiseDeletedEventHander(Item, e);
        }

        private void ucList_Updated(object sender, DIC_MACHINE Item)
        {
            this.RaiseUpdatedEventHander(Item);
        }

        public event xfmMachine.AddedEventHander Added;

        public event xfmMachine.DeletedEventHandler Deleted;

        public event xfmMachine.ItemSelectedEventHander ItemSelected;

        public event xfmMachine.UpdatedEventHander Updated;

        public delegate void AddedEventHander(object sender, DIC_MACHINE Item);

        public delegate void DeletedEventHandler(object sender, DIC_MACHINE Item, RowClickEventArgs e);

        public delegate void ItemSelectedEventHander(object sender, DIC_MACHINE item);

        public delegate void UpdatedEventHander(object sender, DIC_MACHINE Item);
    }
}
