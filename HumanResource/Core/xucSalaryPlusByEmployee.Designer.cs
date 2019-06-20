namespace CHBK2014_N9.HumanResource.Core
{
    partial class xucSalaryPlusByEmployee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalaryTableListID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalaryPlusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalaryPlusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMoney = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colIncomeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSalaryIncome = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPayMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebtMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSalaryDeduction = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1s = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ppMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.colIsIncomeTax = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSalaryIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSalaryDeduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcList.EmbeddedNavigator.TextStringFormat = "{0}/{1}";
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repMoney,
                     this.repDate,
            this.repSalaryIncome});
            this.gcList.Size = new System.Drawing.Size(1297, 127);
            this.gcList.TabIndex = 5;
            this.gcList.UseEmbeddedNavigator = true;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            this.gcList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcList_KeyDown);
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gbList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gbList.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gbList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalaryTableListID,
            this.colEmployeeCode,
            this.colSalaryPlusID,
            this.colSalaryPlusName,
            this.colMoney,
            this.colIncomeCode,
            this.colDescription,
            this.colDate,
            this.colPayMoney,
            this.colDebtMoney,
            this.colIsIncomeTax});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupPanelText = "Kéo và Thả cột vào đây để nhóm dữ liệu";
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AllowIncrementalSearch = true;
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gbList.OptionsBehavior.FocusLeaveOnTab = true;
            this.gbList.OptionsLayout.StoreAllOptions = true;
            this.gbList.OptionsLayout.StoreAppearance = true;
            this.gbList.OptionsMenu.EnableColumnMenu = false;
            this.gbList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gbList.OptionsView.RowAutoHeight = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gbList_InitNewRow);
            this.gbList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gbList_CellValueChanged);
            this.gbList.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gbList_CellValueChanging);
            // 
            // colSalaryTableListID
            // 
            this.colSalaryTableListID.Caption = "Mã bảng lương";
            this.colSalaryTableListID.FieldName = "SalaryTableListID";
            this.colSalaryTableListID.Name = "colSalaryTableListID";
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.Caption = "Mã nhân viên";
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.OptionsColumn.AllowEdit = false;
            this.colEmployeeCode.OptionsColumn.ReadOnly = true;
            this.colEmployeeCode.Width = 77;
            // 
            // colSalaryPlusID
            // 
            this.colSalaryPlusID.Caption = "Mã thu nhập";
            this.colSalaryPlusID.FieldName = "SalaryPlusID";
            this.colSalaryPlusID.Name = "colSalaryPlusID";
            this.colSalaryPlusID.Width = 117;
            // 
            // colSalaryPlusName
            // 
            this.colSalaryPlusName.Caption = "Mô tả chi tiết";
            this.colSalaryPlusName.FieldName = "SalaryPlusName";
            this.colSalaryPlusName.Name = "colSalaryPlusName";
            this.colSalaryPlusName.Visible = true;
            this.colSalaryPlusName.VisibleIndex = 1;
            this.colSalaryPlusName.Width = 288;
            // 
            // colMoney
            // 
            this.colMoney.Caption = "Số tiền (VND)";
            this.colMoney.ColumnEdit = this.repMoney;
            this.colMoney.FieldName = "Money";
            this.colMoney.Name = "colMoney";
            this.colMoney.Visible = true;
            this.colMoney.VisibleIndex = 2;
            this.colMoney.Width = 104;
            // 
            // repMoney
            // 
            this.repMoney.AutoHeight = false;
            this.repMoney.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repMoney.Mask.UseMaskAsDisplayFormat = true;
            this.repMoney.Name = "repMoney";
            this.repMoney.EditValueChanged += new System.EventHandler(this.repMoney_EditValueChanged);
            this.repMoney.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repMoney_EditValueChanging);
            // 
            // colIncomeCode
            // 
            this.colIncomeCode.Caption = "Loại thu nhập cộng vào lương";
            this.colIncomeCode.ColumnEdit = this.repSalaryIncome;
            this.colIncomeCode.FieldName = "IncomeCode";
            this.colIncomeCode.Name = "colIncomeCode";
            this.colIncomeCode.Visible = true;
            this.colIncomeCode.VisibleIndex = 0;
            this.colIncomeCode.Width = 165;
            // 
            // repSalaryIncome
            // 
            this.repSalaryIncome.AutoHeight = false;
            this.repSalaryIncome.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repSalaryIncome.Name = "repSalaryIncome";
            this.repSalaryIncome.View = this.repositoryItemGridLookUpEdit1View;
            this.repSalaryIncome.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repSalaryIncome_ButtonClick);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Loại thu nhập";
            this.gridColumn1.FieldName = "IncomeName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tính thuế";
            this.gridColumn2.FieldName = "IsIncomeTax";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Ghi chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 274;
            // 
            // colDate
            // 
            this.colDate.Caption = "Ngày";
            this.colDate.ColumnEdit = this.repDate;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 6;
            this.colDate.Width = 87;
            // 
            // repDate
            // 
            this.repDate.AutoHeight = false;
            this.repDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDate.Name = "repDate";
            // 
            // colPayMoney
            // 
            this.colPayMoney.Caption = "Thanh toán ngay";
            this.colPayMoney.ColumnEdit = this.repMoney;
            this.colPayMoney.FieldName = "PayMoney";
            this.colPayMoney.Name = "colPayMoney";
            this.colPayMoney.Visible = true;
            this.colPayMoney.VisibleIndex = 4;
            this.colPayMoney.Width = 96;
            // 
            // colDebtMoney
            // 
            this.colDebtMoney.Caption = "Ghi vào lương";
            this.colDebtMoney.ColumnEdit = this.repMoney;
            this.colDebtMoney.FieldName = "DebtMoney";
            this.colDebtMoney.Name = "colDebtMoney";
            this.colDebtMoney.OptionsColumn.AllowEdit = false;
            this.colDebtMoney.OptionsColumn.ReadOnly = true;
            this.colDebtMoney.Visible = true;
            this.colDebtMoney.VisibleIndex = 5;
            this.colDebtMoney.Width = 99;
            // 
            // repSalaryDeduction
            // 
            this.repSalaryDeduction.AutoHeight = false;
            this.repSalaryDeduction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repSalaryDeduction.Name = "repSalaryDeduction";
            this.repSalaryDeduction.NullText = "[Chọn loại khấu trừ]";
            this.repSalaryDeduction.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // gridView1s
            // 
            this.gridView1s.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1s.Name = "gridView1s";
            this.gridView1s.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1s.OptionsView.ShowGroupPanel = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1297, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 127);
            this.barDockControlBottom.Size = new System.Drawing.Size(1297, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 127);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1297, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 127);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "&Xóa";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ppMenu
            // 
            this.ppMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.ppMenu.Manager = this.barManager1;
            this.ppMenu.Name = "ppMenu";
            // 
            // colIsIncomeTax
            this.colIsIncomeTax.Caption = "Tính thuế";
            this.colIsIncomeTax.FieldName = "IsIncomeTax";
            this.colIsIncomeTax.Name = "colIsIncomeTax";
            this.colIsIncomeTax.OptionsColumn.AllowEdit = false;
            this.colIsIncomeTax.OptionsColumn.ReadOnly = true;
            // 
            // xucSalaryPlusByEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "xucSalaryPlusByEmployee";
            this.Size = new System.Drawing.Size(1297, 150);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSalaryIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSalaryDeduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaryTableListID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaryPlusID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repSalaryDeduction;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaryPlusName;
        private DevExpress.XtraGrid.Columns.GridColumn colMoney;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repMoney;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPayMoney;
        private DevExpress.XtraGrid.Columns.GridColumn colDebtMoney;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repSalaryIncome;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1s;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.PopupMenu ppMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colIsIncomeTax;
    }
}
