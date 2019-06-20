using DevExpress.XtraEditors;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmShiftOrder : XtraForm
    {

      
        public xfmShiftOrder()
        {
            InitializeComponent();
           
         
            this.x_ShiftOrder = new xucShiftOrder()
            {
                Dock = DockStyle.Fill
            };
            this.x_ShiftOrder.SaveDataChanged += new xucShiftOrder.SaveDataChangedHander(this.x_ShiftOrder_SaveDataChanged);
            base.Controls.Add(this.x_ShiftOrder);
        }

        public xfmShiftOrder(int Month, int Year)
        {
            this.InitializeComponent();
            this.Text = "Ca làm việc";
            this.x_ShiftOrder = new xucShiftOrder(Month, Year)
            {
                Dock = DockStyle.Fill
            };
            this.x_ShiftOrder.SaveDataChanged += new xucShiftOrder.SaveDataChangedHander(this.x_ShiftOrder_SaveDataChanged);
            base.Controls.Add(this.x_ShiftOrder);
        }

        private void RaiseClosedHandler()
        {
            if (this.Closed != null)
            {
                this.Closed(this);
            }
        }

        private void RaiseSaveDataChangedHander()
        {
            if (this.SaveDataChanged != null)
            {
                this.SaveDataChanged(this);
            }
        }

        public void SetData(int Month, int Year)
        {
            if (this.x_ShiftOrder != null)
            {
                this.x_ShiftOrder.SetData(Month, Year);
            }
            else
            {
                base.Controls.Clear();
                this.x_ShiftOrder = new xucShiftOrder(Month, Year)
                {
                    Dock = DockStyle.Fill
                };
                this.x_ShiftOrder.SaveDataChanged += new xucShiftOrder.SaveDataChangedHander(this.x_ShiftOrder_SaveDataChanged);
                base.Controls.Add(this.x_ShiftOrder);
            }
        }

        private void x_ShiftOrder_SaveDataChanged(object sender)
        {
            this.RaiseSaveDataChangedHander();
        }

     

        public event xfmShiftOrder.ClosedHandler Closed;

        public event xfmShiftOrder.SaveDataChangedHander SaveDataChanged;

        public delegate void ClosedHandler(object sender);

        public delegate void SaveDataChangedHander(object sender);

        private void xfmShiftOrder_Load(object sender, EventArgs e)
        {

        }

        private void xfmShiftOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RaiseClosedHandler();
        }
    }
}
