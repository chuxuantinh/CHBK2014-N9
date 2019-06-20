using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Common
{
    public partial class xucBaseAddH : xucBase
    {
        public xucBaseAddH()
        {
            InitializeComponent();
            this.Init();
        }

        protected virtual void Add()
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.RaiseCancelClickEventHander();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.m_CloseOrNew = CloseOrNew.Close;
            this.Save();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            this.m_CloseOrNew = CloseOrNew.New;
            this.Save();
            this.m_Status = Actions.Add;
            this.Add();
        }

        public virtual void Change()
        {
        }

        protected virtual bool Check()
        {
            return true;
        }

        public virtual new void Delete()
        {
            this.uc_Delete();
        }
        protected virtual void Init()
        {
            this.ReLoad();
        }

        protected virtual void MakerInterface()
        {
        }

        public bool Number(KeyPressEventArgs e)
        {
            bool flag;
            if (!(e.KeyChar == '\b' | e.KeyChar == '.' | e.KeyChar == '-'))
            {
                flag = (char.IsNumber(e.KeyChar) ? false : true);
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        public void RaiseCancelClickEventHander()
        {
            if (this.CancelClick != null)
            {
                this.CancelClick(this);
            }
        }

        public void RaiseSaveClickEventHander()
        {
            if (this.SaveClick != null)
            {
                this.SaveClick(this);
            }
        }

        public virtual void ReLoad()
        {
        }

        public virtual void Save()
        {
            if (this.Check())
            {
                if (this.m_Status == Actions.Add)
                {
                    this.uc_Save();
                }
                else if (this.m_Status == Actions.Update)
                {
                    this.uc_Update();
                }
                else if (this.m_Status == Actions.Change)
                {
                    this.uc_Change();
                }
            }
        }

        public void SetData(string id)
        {
            this.Add();
        }

        public void SetDataByGuid(Guid id)
        {
            this.Add();
        }

        protected virtual void SetInterface()
        {
        }

        protected virtual string uc_Change()
        {
            return string.Empty;
        }

        protected virtual string uc_Delete()
        {
            return string.Empty;
        }

        protected virtual string uc_Save()
        {
            return string.Empty;
        }

        protected virtual string uc_Update()
        {
            return string.Empty;
        }

        public event ButtonClickEventHander CancelClick;

        public event ButtonClickEventHander SaveClick;
    }

}