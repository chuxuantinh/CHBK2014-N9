using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace CHBK2014_N9.Common.Base
{
    public partial class XucBaseBasicB : xucBase
    {

        protected bool _search;

        private string _Title = "";

        protected RowClickEventArgs MRowClickEventArgs = new RowClickEventArgs();

        protected Actions MStatus;
        public XucBaseBasicB()
        {
            InitializeComponent();

            this.InitializeComponent();
            this._search = false;
            this.DisableMenu(true);
        }


        public bool IsSearch
        {
            get
            {
                return this._search;
            }
            set
            {
                this._search = value;
            }
        }

        public new string Title
        {
            set
            {
                this._Title = value;
            }
        }

      
        protected virtual void Add()
        {
        }

        protected virtual void AddRow(object Item)
        {
        }

        protected virtual void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Add();
        }

        protected virtual void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseCloseClickEventHander();
        }

        protected virtual void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Delete();
        }

        protected virtual void bbiDeleteAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Clear();
        }

        protected virtual void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Change();
        }

        protected virtual void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Export();
        }

        protected virtual void bbiPermision_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        protected virtual void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Print();
        }

        protected virtual void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ReLoad();
        }

        public virtual void Change()
        {
        }

        protected virtual new void Clear()
        {
        }

        public virtual void Construct()
        {
        }

        protected virtual void Copy()
        {
        }

        public virtual new void Delete()
        {
        }

        public void DisableMenu(bool disable)
        {
            this.ucToolBar.bbiEdit.Enabled = !disable;
            this.ucToolBar.bbiDelete.Enabled = !disable;
            this.ucToolBar.bbiDeleteAll.Enabled = !disable;
            this.ucToolBar.bbiPermision.Enabled = !disable;
            this.ucToolBar.bbiCopy.Enabled = !disable;
            this.ucToolBar.bbiPrint.Enabled = !disable;
            this.ucToolBar.bbiExport.Enabled = !disable;
        }

        public void DisableMenuNoData(bool disable)
        {
            this.DisableMenu(disable);
            this.ucToolBar.bbiPrint.Enabled = !disable;
            this.ucToolBar.bbiExport.Enabled = !disable;
            this.ucToolBar.bbiCopy.Enabled = !disable;
            this.ucToolBar.bbiEdit.Enabled = !disable;
            this.ucToolBar.bbiDelete.Enabled = !disable;
            this.ucToolBar.bbiDeleteAll.Enabled = !disable;
        }

       

        protected virtual void EditUnitConvert()
        {
        }

        protected virtual void GroupChange()
        {
        }

        protected virtual void History()
        {
        }

        protected virtual void IdChanged()
        {
        }

        public virtual void Import()
        {
        }

        private void Init()
        {
            this.ucToolBar.AddClick += new ButtonClickEventHander(this.ucToolBar_AddClick);
            this.ucToolBar.EditClick += new ButtonClickEventHander(this.ucToolBar_EditClick);
            this.ucToolBar.DeleteClick += new ButtonClickEventHander(this.ucToolBar_DeleteClick);
            this.ucToolBar.SearchClick += new ButtonClickEventHander(this.ucToolBar_SearchClick);
            this.ucToolBar.PrintClick += new ButtonClickEventHander(this.ucToolBar_PrintClick);
            this.ucToolBar.RefreshClick += new ButtonClickEventHander(this.ucToolBar_RefreshClick);
            this.ucToolBar.OptionClick += new ButtonClickEventHander(this.ucToolBar_OptionClick);
            this.ucToolBar.ExportClick += new ButtonClickEventHander(this.ucToolBar_Export);
            this.ucToolBar.HelpClick += new ButtonClickEventHander(this.ucToolBar_HelpClick);
            this.ucToolBar.CloseClick += new ButtonClickEventHander(this.ucToolBar_CloseClick);
            this.ucToolBar.ImportClick += new ButtonClickEventHander(this.ucToolBar_ImportClick);
            this.ucToolBar.PermisionClick += new ButtonClickEventHander(this.ucToolBar_PermisionClick);
            this.ucToolBar.ConstructClick += new ButtonClickEventHander(this.ucToolBar_ConstructClick);
            this.ucToolBar.CopyClick += new ButtonClickEventHander(this.ucToolBar_CopyClick);
            this.ucToolBar.MirrorClick += new ButtonClickEventHander(this.ucToolBar_MirrorClick);
            this.ucToolBar.ClearClick += new ButtonClickEventHander(this.ucToolBar_ClearClick);
            this.ucToolBar.HistoryClick += new ButtonClickEventHander(this.ucToolBar_HistoryClick);
            this.ucToolBar.GroupChanged += new ButtonClickEventHander(this.ucToolBar_GroupChanged);
            this.ucToolBar.StockChanged += new ButtonClickEventHander(this.ucToolBar_StockChanged);
            this.ucToolBar.MergeChanged += new ButtonClickEventHander(this.ucToolBar_MergeChanged);
            this.ucToolBar.IdChanged += new ButtonClickEventHander(this.ucToolBar_IdChanged);
            this.ucToolBar.EditUnitConvert += new ButtonClickEventHander(this.ucToolBar_EditUnitConvert);
            this.ReLoad();
            this.MStatus = Actions.None;
        }

       

        protected virtual void ItemSelectd(RowClickEventArgs ex)
        {
        }

        protected virtual void List_Init(AdvBandedGridView dt)
        {
        }

        protected virtual void MergeChanged()
        {
        }

        public virtual void Mirror()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Init();
            base.OnLoad(e);
        }

        public virtual void Permision()
        {
        }

        protected virtual void Print()
        {
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            bool flag;
            Keys key = keyData;
            if (key <= Keys.F5)
            {
                if (key == Keys.Escape)
                {
                    this.RaiseCloseClickEventHander();
                    flag = true;
                }
                else if (key == Keys.F1)
                {
                    this.ucToolBar_HelpClick(this.ucToolBar);
                    flag = true;
                }
                else
                {
                    if (key != Keys.F5)
                    {
                        flag = false;
                        return flag;
                    }
                    this.ReLoad();
                    flag = true;
                }
            }
            else if (key <= (Keys.MButton | Keys.ShiftKey | Keys.Capital | Keys.CapsLock | Keys.D | Keys.P | Keys.T | Keys.Control))
            {
                switch (key)
                {
                    case Keys.LButton | Keys.MButton | Keys.XButton1 | Keys.A | Keys.D | Keys.E | Keys.Control:
                        {
                            this.ucToolBar_Export(this.ucToolBar);
                            flag = true;
                            break;
                        }
                    case Keys.RButton | Keys.MButton | Keys.XButton2 | Keys.B | Keys.D | Keys.F | Keys.Control:
                        {
                            this.ucToolBar_SearchClick(this.ucToolBar);
                            flag = true;
                            break;
                        }
                    default:
                        {
                            switch (key)
                            {
                                case Keys.RButton | Keys.MButton | Keys.XButton2 | Keys.Back | Keys.LineFeed | Keys.Clear | Keys.B | Keys.D | Keys.F | Keys.H | Keys.J | Keys.L | Keys.N | Keys.Control:
                                    {
                                        this.ucToolBar_AddClick(this.ucToolBar);
                                        flag = true;
                                        break;
                                    }
                                case Keys.LButton | Keys.RButton | Keys.Cancel | Keys.MButton | Keys.XButton1 | Keys.XButton2 | Keys.Back | Keys.Tab | Keys.LineFeed | Keys.Clear | Keys.Return | Keys.Enter | Keys.A | Keys.B | Keys.C | Keys.D | Keys.E | Keys.F | Keys.G | Keys.H | Keys.I | Keys.J | Keys.K | Keys.L | Keys.M | Keys.N | Keys.O | Keys.Control:
                                    {
                                        this.ucToolBar_OptionClick(this.ucToolBar);
                                        flag = true;
                                        break;
                                    }
                                case Keys.ShiftKey | Keys.P | Keys.Control:
                                    {
                                        this.ucToolBar_PrintClick(this.ucToolBar);
                                        flag = true;
                                        break;
                                    }
                                case Keys.LButton | Keys.ShiftKey | Keys.ControlKey | Keys.A | Keys.P | Keys.Q | Keys.Control:
                                case Keys.RButton | Keys.ShiftKey | Keys.Menu | Keys.B | Keys.P | Keys.R | Keys.Control:
                                case Keys.LButton | Keys.RButton | Keys.Cancel | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.A | Keys.B | Keys.C | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.Control:
                                    {
                                        flag = false;
                                        return flag;
                                    }
                                case Keys.MButton | Keys.ShiftKey | Keys.Capital | Keys.CapsLock | Keys.D | Keys.P | Keys.T | Keys.Control:
                                    {
                                        this.ucToolBar_AddClick(this.ucToolBar);
                                        flag = true;
                                        break;
                                    }
                                default:
                                    {
                                        flag = false;
                                        return flag;
                                    }
                            }
                            break;
                        }
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
                this.RaiseCloseClickEventHander();
                flag = true;
            }
            return flag;
        }

        private void RaiseCloseClickEventHander()
        {
            if (this.CloseClick != null)
            {
                this.CloseClick(this);
            }
        }

        private void RaiseListKeyDownEventHander(KeyEventArgs key, RowClickEventArgs e)
        {
            if (this.ListKeyDown != null)
            {
                this.ListKeyDown(this, key, e);
            }
        }

        private void RaiseRowClickEventHander(RowClickEventArgs e)
        {
            if (this.RowClick != null)
            {
                this.RowClick(this, e);
            }
        }

        private void RaiseRowDoubleClickEventHander(RowClickEventArgs e)
        {
            if (this.RowDoubleClick != null)
            {
                this.RowDoubleClick(this, e);
            }
        }

        public virtual void ReLoad()
        {
        }

        protected virtual void Search()
        {
            XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
        }

        protected virtual new void Select()
        {
        }

        protected virtual void SetMenu(RowClickEventArgs e)
        {
        }

        public virtual void SetSearch(RowClickEventArgs e)
        {
        }

        protected virtual void StockChange()
        {
        }

        private void ucToolBar_AddClick(object sender)
        {
            this.Add();
        }

        private void ucToolBar_ClearClick(object sender)
        {
            this.Clear();
        }

        private void ucToolBar_CloseClick(object sender)
        {
            this.RaiseCloseClickEventHander();
        }

        private void ucToolBar_ConstructClick(object sender)
        {
            this.Construct();
        }

        private void ucToolBar_CopyClick(object sender)
        {
            this.Copy();
        }

        private void ucToolBar_DeleteClick(object sender)
        {
            this.Delete();
        }

        private void ucToolBar_EditClick(object sender)
        {
            this.Change();
        }

        private void ucToolBar_EditUnitConvert(object sender)
        {
            this.EditUnitConvert();
        }

        private void ucToolBar_Export(object sender)
        {
            base.Export();
        }

        private void ucToolBar_GroupChanged(object sender)
        {
            this.GroupChange();
        }

        private void ucToolBar_HelpClick(object sender)
        {
            Process.Start("http://phanmembachkhoa.com");
        }

        private void ucToolBar_HistoryClick(object sender)
        {
            this.History();
        }

        private void ucToolBar_IdChanged(object sender)
        {
            this.IdChanged();
        }

        private void ucToolBar_ImportClick(object sender)
        {
            this.Import();
        }

        private void ucToolBar_MergeChanged(object sender)
        {
            this.MergeChanged();
        }

        private void ucToolBar_MirrorClick(object sender)
        {
            this.Mirror();
        }

        private void ucToolBar_OptionClick(object sender)
        {
            XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
        }

        private void ucToolBar_PermisionClick(object sender)
        {
            this.Permision();
        }

        private void ucToolBar_PrintClick(object sender)
        {
            this.Print();
        }

        private void ucToolBar_RefreshClick(object sender)
        {
            this.ReLoad();
        }

        private void ucToolBar_SearchClick(object sender)
        {
            this.Search();
        }

        private void ucToolBar_SelectClick(object sender)
        {
            this.Select();
        }

        private void ucToolBar_StockChanged(object sender)
        {
            this.StockChange();
        }

        protected virtual void UpdateRow(object Item, RowClickEventArgs e)
        {
        }

        public event ButtonClickEventHander CloseClick;

        public event ListKeyDownEventHander ListKeyDown;

        public event RowClickEventHander RowClick;

        public event RowClickEventHander RowDoubleClick;
    }
}
