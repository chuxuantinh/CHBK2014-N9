using DevExpress.XtraEditors;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace CHBK2014_N9.Dictionnary
{
    public partial class xfmStep : XtraForm
    {

        private bool _search = false;
      


        public bool IsSearch
        {
            set
            {
                this.xucstep.IsSearch = value;
            }
        }

        public xfmStep()
        {
            this.InitializeComponent();
            this.Init();
        }

        public xfmStep(bool search)
        {
            this._search = search;
            this.InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            SYS_LOG.Insert("Danh Mục Bậc Lương", "Xem");
            this.xucstep = new xucStep();
            base.Controls.Add(this.xucstep);
            this.xucstep.Dock = DockStyle.Fill;
            this.xucstep.CloseClick += new ButtonClickEventHander(this.xucstep_CloseClick);
            this.Text =  this.Text;
        }
        private void RaiseItemSelectedEventHander(HRM_DEPARTMENT item)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(this, item);
            }
        }

        private void xucstep_CloseClick(object sender)
        {
            base.Close();
        }

        public event xfmStep.ItemSelectedEventHander ItemSelected;

        public delegate void ItemSelectedEventHander(object sender, HRM_DEPARTMENT item);
    }
}
