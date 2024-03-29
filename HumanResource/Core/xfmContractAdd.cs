﻿using DevExpress.XtraEditors;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmContractAdd : XtraForm
    {

        public RowClickEventArgs m_RowClickEventArgs;
        public xfmContractAdd()
        {
            this.InitializeComponent();
        }

        public xfmContractAdd(Actions Action)
        {
            this.InitializeComponent();
            this.Init();
            this.ucAdd.Status = Action;
            HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
            this.ucAdd.SetData(hRMCONTRACT.NewID());
            this.Text = "Thêm";
        }

        public xfmContractAdd(Actions Action, HRM_CONTRACT Item)
        {
            this.InitializeComponent();
            this.Init();
            this.ucAdd.Status = Action;
            if (Action == Actions.Update)
            {
                this.ucAdd.SetData(Item);
                this.Text = "Cập nhật";
            }
            else if (Action == Actions.Delete)
            {
                this.ucAdd.SetData(Item.ContractCode);
            }
        }

        public xfmContractAdd(Actions Action, string EmployeeCode)
        {
            this.InitializeComponent();
            this.Init();
            this.ucAdd.Status = Action;
            if (Action == Actions.Add)
            {
                HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
                this.ucAdd.SetDefaultAdd(EmployeeCode);
                this.ucAdd.SetData(hRMCONTRACT.NewID());
                this.Text = "Thêm";
            }
            else if (Action == Actions.Delete)
            {
            }
        }

        public void Delete()
        {
            this.ucAdd.Delete();
        }


        private void Init()
        {
          //  this.ucAdd = new xucContractAdd();
            base.Controls.Add(this.ucAdd);
            this.ucAdd.CancelClick += new ButtonClickEventHander(this.ucAdd_CancelClick);
            this.ucAdd.Success += new xucContractAdd.SuccessEventHander(this.ucAdd_Success);
            this.Text = "Hợp đồng";
        }

       

        protected override bool ProcessDialogKey(Keys keyData)
        {
            bool flag;
            Keys key = keyData;
            if (key <= (Keys.LButton | Keys.RButton | Keys.Cancel | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.A | Keys.B | Keys.C | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.Control))
            {
                if (key == Keys.Escape)
                {
                    base.Close();
                    flag = true;
                }
                else if (key == Keys.F2)
                {
                    this.ucAdd.IsClose = CloseOrNew.Close;
                    this.ucAdd.Save();
                    flag = true;
                }
                else
                {
                    if (key != (Keys.LButton | Keys.RButton | Keys.Cancel | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.A | Keys.B | Keys.C | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.Control))
                    {
                        flag = false;
                        return flag;
                    }
                    this.ucAdd.IsClose = CloseOrNew.Close;
                    this.ucAdd.Save();
                    flag = true;
                }
            }
            else if (key <= (Keys.LButton | Keys.RButton | Keys.Cancel | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.A | Keys.B | Keys.C | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.Shift | Keys.Control))
            {
                if (key == (Keys.LButton | Keys.RButton | Keys.Cancel | Keys.MButton | Keys.XButton1 | Keys.XButton2 | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.Capital | Keys.CapsLock | Keys.KanaMode | Keys.HanguelMode | Keys.HangulMode | Keys.JunjaMode | Keys.A | Keys.B | Keys.C | Keys.D | Keys.E | Keys.F | Keys.G | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.T | Keys.U | Keys.V | Keys.W | Keys.Control))
                {
                    this.ucAdd.IsClose = CloseOrNew.Close;
                    this.ucAdd.Save();
                    flag = true;
                }
                else
                {
                    if (key != (Keys.LButton | Keys.RButton | Keys.Cancel | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.A | Keys.B | Keys.C | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.Shift | Keys.Control))
                    {
                        flag = false;
                        return flag;
                    }
                    this.ucAdd.IsClose = CloseOrNew.New;
                    this.ucAdd.Save();
                    flag = true;
                }
            }
            else if (key == (Keys.MButton | Keys.D | Keys.Alt))
            {
                flag = true;
            }
            else
            {
                if (key != (Keys.Back | Keys.ShiftKey | Keys.FinalMode | Keys.H | Keys.P | Keys.X | Keys.Alt))
                {
                    flag = false;
                    return flag;
                }
                base.Close();
                flag = true;
            }
            return flag;
        }

        public void RaiseAddedEventHander(HRM_CONTRACT Item)
        {
            if (this.Added != null)
            {
                this.Added(this, Item);
            }
        }

        public void RaiseUpdatedEventHander(HRM_CONTRACT Item)
        {
            if (this.Updated != null)
            {
                this.Updated(this, Item);
            }
        }

        private void ucAdd_CancelClick(object sender)
        {
            base.Close();
        }

        private void ucAdd_Success(object sender, HRM_CONTRACT Item)
        {
            if (this.ucAdd.Status == Actions.Add)
            {
                this.RaiseAddedEventHander(Item);
            }
            else if (this.ucAdd.Status == Actions.Update)
            {
                this.RaiseUpdatedEventHander(Item);
            }
            if (this.ucAdd.IsClose == CloseOrNew.Close)
            {
                base.Close();
            }
            this.ucAdd.Clear();
        }

        public event xfmContractAdd.AddedEventHander Added;

        public event xfmContractAdd.UpdatedEventHander Updated;

        public delegate void AddedEventHander(object sender, HRM_CONTRACT Item);

        public delegate void UpdatedEventHander(object sender, HRM_CONTRACT Item);
    }
}
