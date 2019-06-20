using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Common.Base
{
    public partial class XucToolBar : xucBase
    {
        // private DevExpress.XtraBars.Bar barAccount;

       // SuperToolTip superToolTip = new SuperToolTip();
        [Category("Design")]
        [DefaultValue(false)]
        [Description("Button Add")]
        public BarItemVisibility ButtonAdd
        {
            get
            {
                return this.bbiAdd.Visibility;
            }
            set
            {
                this.bbiAdd.Visibility = value;
                base.Update();
            }
        }

        [Category("Design")]
        [DefaultValue(false)]
        [Description("Button Cancel")]
        public BarItemVisibility ButtonCancel
        {
            get
            {
                return this.bbiCancel.Visibility;
            }
            set
            {
                this.bbiCancel.Visibility = value;
                base.Show();
                this.barAccount.Reset();
            }
        }

        //[Category("Design")]
        //[DefaultValue(false)]
        //[Description("Button Change")]
        //public BarItemVisibility ButtonChange
        //{
        //    get
        //    {
        //        return this.bbiChange.Visibility;
        //    }
        //    set
        //    {
        //        this.bbiChange.Visibility = value;
        //        base.Update();
        //    }
        //}

        [Category("Design")]
        [DefaultValue(false)]
        [Description("Button Delete")]
        public BarItemVisibility ButtonDelete
        {
            get
            {
                return this.bbiDelete.Visibility;
            }
            set
            {
                this.bbiDelete.Visibility = value;
                base.Update();
            }
        }

        [Category("Design")]
        [DefaultValue(false)]
        [Description("Button Edit")]
        public BarItemVisibility ButtonEdit
        {
            get
            {
                return this.bbiEdit.Visibility;
            }
            set
            {
                this.bbiEdit.Visibility = value;
                base.Update();
            }
        }

        [Category("Design")]
        [DefaultValue(false)]
        [Description("Button Delete")]
        public BarItemVisibility ButtonExport
        {
            get
            {
                return this.bbiExport.Visibility;
            }
            set
            {
                this.bbiExport.Visibility = value;
                base.Update();
            }
        }

        [Category("Design")]
        [DefaultValue(false)]
        [Description("Button Delete")]
        public BarItemVisibility ButtonOption
        {
            get
            {
                return this.bbiOption.Visibility;
            }
            set
            {
                this.bbiOption.Visibility = value;
                base.Update();
            }
        }

        [Category("Design")]
        [DefaultValue(false)]
        [Description("Button Print")]
        public BarItemVisibility ButtonPrint
        {
            get
            {
                return this.bbiPrint.Visibility;
            }
            set
            {
                this.bbiPrint.Visibility = value;
                base.Update();
            }
        }

        [Category("Design")]
        [DefaultValue(false)]
        [Description("Button Save")]
        public BarItemVisibility ButtonSave
        {
            get
            {
                return this.bbiSave.Visibility;
            }
            set
            {
                this.bbiSave.Visibility = value;
                base.Show();
                this.barAccount.Reset();
            }
        }

        [Category("Design")]
        [DefaultValue(false)]
        [Description("Button SaveNew")]
        public BarItemVisibility ButtonSaveNew
        {
            get
            {
                return this.bbiSaveNew.Visibility;
            }
            set
            {
                this.bbiSaveNew.Visibility = value;
                base.Show();
                this.barAccount.Reset();
            }
        }
        public XucToolBar()
        {
            InitializeComponent();
        }
          public virtual void MakerInterface()
        {
        }

        private void RaiseAddClickEventHander()
        {
            if (this.AddClick != null)
            {
                this.AddClick(this);
            }
        }

        private void RaiseCancleClickEventHander()
        {
            if (this.CancleClick != null)
            {
                this.CancleClick(this);
            }
        }

        private void RaiseChangeClickEventHander()
        {
            if (this.ChangeClick != null)
            {
                this.ChangeClick(this);
            }
        }

        private void RaiseClearClickEventHander()
        {
            if (this.ClearClick != null)
            {
                this.ClearClick(this);
            }
        }

        private void RaiseCloseClickEventHander()
        {
            if (this.CloseClick != null)
            {
                this.CloseClick(this);
            }
        }

        private void RaiseConstructClickEventHander()
        {
            if (this.ConstructClick != null)
            {
                this.ConstructClick(this);
            }
        }

        private void RaiseCopyClickEventHander()
        {
            if (this.CopyClick != null)
            {
                this.CopyClick(this);
            }
        }

        private void RaiseDeleteClickEventHander()
        {
            if (this.DeleteClick != null)
            {
                this.DeleteClick(this);
            }
        }

        private void RaiseEditClickEventHander()
        {
            if (this.EditClick != null)
            {
                this.EditClick(this);
            }
        }

        private void RaiseEditUnitConvert()
        {
            ButtonClickEventHander buttonClickEventHander = this.EditUnitConvert;
            if (buttonClickEventHander != null)
            {
                buttonClickEventHander(this);
            }
        }

        private void RaiseExportEventHander()
        {
            if (this.ExportClick != null)
            {
                this.ExportClick(this);
            }
        }

        private void RaiseGroupChanged()
        {
            ButtonClickEventHander buttonClickEventHander = this.GroupChanged;
            if (buttonClickEventHander != null)
            {
                buttonClickEventHander(this);
            }
        }

        private void RaiseHelpClickEventHander()
        {
            if (this.HelpClick != null)
            {
                this.HelpClick(this);
            }
        }

        private void RaiseHistoryClick()
        {
            ButtonClickEventHander buttonClickEventHander = this.HistoryClick;
            if (buttonClickEventHander != null)
            {
                buttonClickEventHander(this);
            }
        }

        private void RaiseIdChanged()
        {
            ButtonClickEventHander buttonClickEventHander = this.IdChanged;
            if (buttonClickEventHander != null)
            {
                buttonClickEventHander(this);
            }
        }

        private void RaiseImportClickEventHander()
        {
            if (this.ImportClick != null)
            {
                this.ImportClick(this);
            }
        }

        private void RaiseMergeChanged()
        {
            ButtonClickEventHander buttonClickEventHander = this.MergeChanged;
            if (buttonClickEventHander != null)
            {
                buttonClickEventHander(this);
            }
        }

        private void RaiseMirrorClickEventHander()
        {
            if (this.MirrorClick != null)
            {
                this.MirrorClick(this);
            }
        }

        private void RaiseOptionClickEventHander()
        {
            if (this.OptionClick != null)
            {
                this.OptionClick(this);
            }
        }

        private void RaisePermisionClickEventHander()
        {
            if (this.PermisionClick != null)
            {
                this.PermisionClick(this);
            }
        }

        private void RaisePrintClickEventHander()
        {
            if (this.PrintClick != null)
            {
                this.PrintClick(this);
            }
        }

        private void RaiseRefreshClickEventHander()
        {
            if (this.RefreshClick != null)
            {
                this.RefreshClick(this);
            }
        }

        private void RaiseSaveClickEventHander()
        {
            if (this.SaveClick != null)
            {
                this.SaveClick(this);
            }
        }

        private void RaiseSaveNewClickEventHander()
        {
            if (this.SaveNewClick != null)
            {
                this.SaveNewClick(this);
            }
        }

        private void RaiseSearchClickEventHander()
        {
            if (this.SearchClick != null)
            {
                this.SearchClick(this);
            }
        }

        private void RaiseStockChanged()
        {
            ButtonClickEventHander buttonClickEventHander = this.StockChanged;
            if (buttonClickEventHander != null)
            {
                buttonClickEventHander(this);
            }
        }

        public virtual void SetInterface()
        {
        }

        public event ButtonClickEventHander AddClick;

        public event ButtonClickEventHander CancleClick;

        public event ButtonClickEventHander ChangeClick;

        public event ButtonClickEventHander ClearClick;

        public event ButtonClickEventHander CloseClick;

        public event ButtonClickEventHander ConstructClick;

        public event ButtonClickEventHander CopyClick;

        public event ButtonClickEventHander DeleteClick;

        public event ButtonClickEventHander EditClick;

        public event ButtonClickEventHander EditUnitConvert;

        public event ButtonClickEventHander ExportClick;

        public event ButtonClickEventHander GroupChanged;

        public event ButtonClickEventHander HelpClick;

        public event ButtonClickEventHander HistoryClick;

        public event ButtonClickEventHander IdChanged;

        public event ButtonClickEventHander ImportClick;

        public event ButtonClickEventHander MergeChanged;

        public event ButtonClickEventHander MirrorClick;

        public event ButtonClickEventHander OptionClick;

        public event ButtonClickEventHander PermisionClick;

        public event ButtonClickEventHander PrintClick;

        public event ButtonClickEventHander RefreshClick;

        public event ButtonClickEventHander SaveClick;

        public event ButtonClickEventHander SaveNewClick;

        public event ButtonClickEventHander SearchClick;

        public event ButtonClickEventHander StockChanged;

        private void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseAddClickEventHander();
        }

        private void bbiCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseCancleClickEventHander();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseDeleteClickEventHander();
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseCloseClickEventHander();
        }

        private void bbiOption_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseOptionClickEventHander();
        }

        private void bbiSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseSearchClickEventHander();
        }

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseExportEventHander();
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseSaveClickEventHander();
        }

        private void bbiSaveNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseSaveNewClickEventHander();
        }

        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaisePrintClickEventHander();
        }

        private void bbiCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseCopyClickEventHander();
        }

        private void bbiDeleteAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseEditClickEventHander();
        }
    }


}

