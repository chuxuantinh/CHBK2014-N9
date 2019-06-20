using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Common
{
   public class GridViewColumnButtonMenu: GridViewMenu
    {

        private string PathXml = string.Concat(Application.StartupPath, "\\LayoutGrid");

        public Control ParentControl
        {
            get;
            set;
        }

        public string ParentControlName
        {
            get;
            set;
        }

        public GridViewColumnButtonMenu(GridView view) : base(view)
        {
        }

        protected override void CreateItems()
        {
            base.Items.Clear();
            DXSubMenuItem dXSubMenuItem = new DXSubMenuItem("Danh Sách Các Cột")
            {
                Image = GridMenuImages.Column.Images[5]
            };
            base.Items.Add(dXSubMenuItem);
            base.Items.Add(base.CreateMenuItem("Tuỳ Chọn Cột", GridMenuImages.Column.Images[4], "Customization", true));
            base.Items.Add(base.CreateMenuItem("Co Giãn Cột", GridMenuImages.Column.Images[6], "BestFit", true));
            if (!base.View.OptionsView.ShowGroupPanel)
            {
                base.Items.Add(this.CreateMenuItem("Hiện Khung Nhóm Dữ Liệu", null, "ShowGroupPanel", true, true));
            }
            else
            {
                base.Items.Add(this.CreateMenuItem("Ẩn Khung Nhóm Dữ Liệu", null, "HideGroupPanel", true, true));
            }
            base.Items.Add(this.CreateMenuCheckItem("Chọn Hết", false, null, "SelectAll", true, true));
            base.Items.Add(this.CreateMenuItem("Bỏ Chọn", null, "UnSelectAll", true, false));
            base.Items.Add(this.CreateMenuItem("Lưu Lại Vị Trí Và Sắp Xếp Các Cột", null, "SaveLayout", true, true));
            base.Items.Add(base.CreateMenuItem("Lấy Lại Vị Trí Và Sắp Xếp Mặc Định", null, "DefaultLayout", true));
            foreach (GridColumn column in base.View.Columns)
            {
                if (column.OptionsColumn.ShowInCustomizationForm)
                {
                    dXSubMenuItem.Items.Add(base.CreateMenuCheckItem(column.GetTextCaption(), column.VisibleIndex >= 0, null, column, true));
                }
            }
        }

        protected override void OnMenuItemClick(object sender, EventArgs e)
        {
            FileInfo fileInfo;
            if (!this.RaiseClickEvent(sender, null))
            {
                DXMenuItem dXMenuItem = sender as DXMenuItem;
                if (dXMenuItem.Tag != null)
                {
                    if (dXMenuItem.Tag is GridColumn)
                    {
                        GridColumn tag = dXMenuItem.Tag as GridColumn;
                        tag.VisibleIndex = (tag.VisibleIndex >= 0 ? -1 : base.View.VisibleColumns.Count);
                    }
                    else if (dXMenuItem.Tag.ToString() == "Customization")
                    {
                        base.View.ColumnsCustomization();
                    }
                    else if (dXMenuItem.Tag.ToString() == "BestFit")
                    {
                        base.View.BestFitColumns();
                    }
                    else if (!(dXMenuItem.Tag.ToString() == "Filter"))
                    {
                        if (dXMenuItem.Tag.ToString() == "HideGroupPanel")
                        {
                            base.View.OptionsView.ShowGroupPanel = false;
                        }
                        else if (dXMenuItem.Tag.ToString() == "ShowGroupPanel")
                        {
                            base.View.OptionsView.ShowGroupPanel = true;
                        }
                        else if (dXMenuItem.Tag.ToString() == "SelectAll")
                        {
                            base.View.SelectAll();
                        }
                        else if (dXMenuItem.Tag.ToString() == "UnSelectAll")
                        {
                            base.View.ClearSelection();
                        }
                        else if (dXMenuItem.Tag.ToString() == "SaveLayout")
                        {
                            try
                            {
                                string pathXml = this.PathXml;
                                if (!Directory.Exists(pathXml))
                                {
                                    Directory.CreateDirectory(pathXml);
                                    if (!Directory.Exists(pathXml))
                                    {
                                        return;
                                    }
                                }
                                if ((this.ParentControlName == "" ? false : this.ParentControlName != null))
                                {
                                    base.View.SaveLayoutToXml(string.Concat(this.PathXml, "\\", this.ParentControlName, ".xml"), OptionsLayoutBase.FullLayout);
                                }
                                else
                                {
                                    base.View.SaveLayoutToXml(string.Concat(this.PathXml, "\\", this.ParentControl.Name, ".xml"), OptionsLayoutBase.FullLayout);
                                }
                            }
                            catch
                            {
                            }
                        }
                        else if (dXMenuItem.Tag.ToString() == "DefaultLayout")
                        {
                            try
                            {
                                fileInfo = ((this.ParentControlName == "" ? false : this.ParentControlName != null) ? new FileInfo(string.Concat(this.PathXml, "\\", this.ParentControlName, ".xml")) : new FileInfo(string.Concat(this.PathXml, "\\", this.ParentControl.Name, ".xml")));
                                fileInfo.Delete();
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
        }

        public void RestoreLayout()
        {
            try
            {
                if ((this.ParentControlName == "" ? false : this.ParentControlName != null))
                {
                    base.View.RestoreLayoutFromXml(string.Concat(this.PathXml, "\\", this.ParentControlName, ".xml"), OptionsLayoutBase.FullLayout);
                }
                else
                {
                    base.View.RestoreLayoutFromXml(string.Concat(this.PathXml, "\\", this.ParentControl.Name, ".xml"), OptionsLayoutBase.FullLayout);
                }
            }
            catch
            {
            }
        }
    }
}
