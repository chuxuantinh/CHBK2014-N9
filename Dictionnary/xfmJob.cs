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
    public partial class xfmJob : XtraForm
    {

        private bool _search = false;
        public xfmJob()
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

        public xfmJob(bool search)
        {
            this._search = search;
            this.InitializeComponent();
            this.Init();
        }

        

        private void Init()
        {
            SYS_LOG.Insert("Danh Mục Công Việc", "Xem");
            this.ucList.CloseClick += new ButtonClickEventHander(this.ucList_CloseClick);
            this.Text = "Job";
        }


        private void RaiseItemSelectedEventHander(DIC_JOB item)
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

        public event xfmJob.ItemSelectedEventHander ItemSelected;

        public delegate void ItemSelectedEventHander(object sender, DIC_JOB item);

        private void xfmJob_Load(object sender, EventArgs e)
        {

        }
    }
}
