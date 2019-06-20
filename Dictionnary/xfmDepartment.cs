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
    public partial class xfmDepartment :Form
    {
        private bool _search = false;
        public xfmDepartment()
        {
            InitializeComponent();
            Init();
        }

        public bool IsSearch
        {
            set
            {
                this.xucdepartment.IsSearch = value;
            }
        }

       

        public xfmDepartment(bool search)
        {
            this._search = search;
            this.InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            SYS_LOG.Insert("Danh Sách Phòng Ban", "Xem");
            this.xucdepartment = new xucDepartment();
            base.Controls.Add(this.xucdepartment);
            this.xucdepartment.Dock = DockStyle.Fill;
            this.xucdepartment.CloseClick += new ButtonClickEventHander(this.xucdepartment_CloseClick);
            this.Text = "Phòng ban";
        }

        private void RaiseItemSelectedEventHander(HRM_DEPARTMENT item)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(this, item);
            }
        }

        private void xucdepartment_CloseClick(object sender)
        {
            base.Close();
        }

        public event xfmDepartment.ItemSelectedEventHander ItemSelected;

        public delegate void ItemSelectedEventHander(object sender, HRM_DEPARTMENT item);

    }
}
