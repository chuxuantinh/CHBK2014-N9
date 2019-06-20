namespace CHBK2014_N9.HumanResource.Core
{
    partial class xucSalaryAllowance
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
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalaryTableListID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubsidiaryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowanceCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowanceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCalculator = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colIncomeTaxValue = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTableListSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSalaryName
            // 
            this.lbSalaryName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            // 
            // repName
            // 
            this.repName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repName.Appearance.Options.UseFont = true;
            // 
            // repDateTimeSelect
            // 
            this.repDateTimeSelect.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repDateTimeSelect.Appearance.Options.UseFont = true;
            this.repDateTimeSelect.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.repDateTimeSelect.AppearanceDropDown.Options.UseFont = true;
            // 
            // repMonth
            // 
            this.repMonth.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repMonth.Appearance.Options.UseFont = true;
            this.repMonth.Mask.EditMask = "MM";
            this.repMonth.Mask.UseMaskAsDisplayFormat = true;
            // 
            // repYear
            // 
            this.repYear.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repYear.Appearance.Options.UseFont = true;
            this.repYear.Mask.EditMask = "yyyy";
            this.repYear.Mask.UseMaskAsDisplayFormat = true;
            // 
            // repTableListSelect
            // 
            this.repTableListSelect.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repTableListSelect.Appearance.Options.UseFont = true;
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
            this.gcList.Location = new System.Drawing.Point(270, 67);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCalculator});
            this.gcList.Size = new System.Drawing.Size(1165, 451);
            this.gcList.TabIndex = 23;
            this.gcList.UseEmbeddedNavigator = true;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gbList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gbList.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gbList.ColumnPanelRowHeight = 3;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalaryTableListID,
            this.colEmployeeCode,
            this.colFirstName,
            this.colLastName,
            this.colBranchName,
            this.colDepartmentName,
            this.colGroupName,
            this.colSubsidiaryName,
            this.colAllowanceCode,
            this.colAllowanceName,
            this.colMoney,
            this.colIncomeTaxValue});
            this.gbList.FixedLineWidth = 1;
            this.gbList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupPanelText = "Kéo và Thả cột vào đây để nhóm dữ liệu";
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AllowIncrementalSearch = true;
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gbList.OptionsBehavior.FocusLeaveOnTab = true;
            this.gbList.OptionsCustomization.AllowFilter = false;
            this.gbList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gbList.OptionsFilter.AllowFilterEditor = false;
            this.gbList.OptionsFilter.AllowMRUFilterList = false;
            this.gbList.OptionsLayout.StoreAllOptions = true;
            this.gbList.OptionsLayout.StoreAppearance = true;
            this.gbList.OptionsMenu.EnableColumnMenu = false;
            this.gbList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsPrint.AutoWidth = false;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintPreview = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.EnableAppearanceEvenRow = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            // 
            // colSalaryTableListID
            // 
            this.colSalaryTableListID.Caption = "Mã bảng lương";
            this.colSalaryTableListID.FieldName = "SalaryTableListID";
            this.colSalaryTableListID.Name = "colSalaryTableListID";
            this.colSalaryTableListID.OptionsColumn.ReadOnly = true;
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colEmployeeCode.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeCode.Caption = "Mã NV";
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.OptionsColumn.AllowEdit = false;
            this.colEmployeeCode.OptionsColumn.ReadOnly = true;
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 0;
            this.colEmployeeCode.Width = 67;
            // 
            // colFirstName
            // 
            this.colFirstName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFirstName.AppearanceHeader.Options.UseFont = true;
            this.colFirstName.Caption = "Họ lót";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.OptionsColumn.ReadOnly = true;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 96;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLastName.AppearanceHeader.Options.UseFont = true;
            this.colLastName.Caption = "Tên";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.AllowEdit = false;
            this.colLastName.OptionsColumn.ReadOnly = true;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 58;
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "Chi nhánh";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.OptionsColumn.AllowEdit = false;
            this.colBranchName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colBranchName.OptionsColumn.ReadOnly = true;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.Caption = "Phòng ban";
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.OptionsColumn.AllowEdit = false;
            this.colDepartmentName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDepartmentName.OptionsColumn.ReadOnly = true;
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "Tổ nhóm";
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.OptionsColumn.AllowEdit = false;
            this.colGroupName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colGroupName.OptionsColumn.ReadOnly = true;
            // 
            // colSubsidiaryName
            // 
            this.colSubsidiaryName.Caption = "Công ty con";
            this.colSubsidiaryName.FieldName = "SubsidiaryName";
            this.colSubsidiaryName.Name = "colSubsidiaryName";
            // 
            // colAllowanceCode
            // 
            this.colAllowanceCode.Caption = "Mã phụ cấp";
            this.colAllowanceCode.FieldName = "AllowanceCode";
            this.colAllowanceCode.Name = "colAllowanceCode";
            this.colAllowanceCode.Visible = true;
            this.colAllowanceCode.VisibleIndex = 3;
            this.colAllowanceCode.Width = 97;
            // 
            // colAllowanceName
            // 
            this.colAllowanceName.Caption = "Tên phụ cấp";
            this.colAllowanceName.FieldName = "AllowanceName";
            this.colAllowanceName.Name = "colAllowanceName";
            this.colAllowanceName.Visible = true;
            this.colAllowanceName.VisibleIndex = 4;
            this.colAllowanceName.Width = 177;
            // 
            // colMoney
            // 
            this.colMoney.Caption = "Số tiền hưởng (VND)";
            this.colMoney.ColumnEdit = this.repCalculator;
            this.colMoney.FieldName = "Money";
            this.colMoney.Name = "colMoney";
            this.colMoney.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Money", "{0:##,##0}")});
            this.colMoney.Visible = true;
            this.colMoney.VisibleIndex = 5;
            this.colMoney.Width = 132;
            // 
            // repCalculator
            // 
            this.repCalculator.AutoHeight = false;
            this.repCalculator.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCalculator.DisplayFormat.FormatString = "\"{0:##,##0}\"";
            this.repCalculator.EditFormat.FormatString = "\"{0:##,##0}\"";
            this.repCalculator.Mask.UseMaskAsDisplayFormat = true;
            this.repCalculator.Name = "repCalculator";
            // 
            // colIncomeTaxValue
            // 
            this.colIncomeTaxValue.Caption = "Giảm trừ thuế (%)";
            this.colIncomeTaxValue.ColumnEdit = this.repCalculator;
            this.colIncomeTaxValue.FieldName = "IncomeTaxValue";
            this.colIncomeTaxValue.Name = "colIncomeTaxValue";
            this.colIncomeTaxValue.Visible = true;
            this.colIncomeTaxValue.VisibleIndex = 6;
            this.colIncomeTaxValue.Width = 115;
            // 
            // xucSalaryAllowance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcList);
            this.Name = "xucSalaryAllowance";
            this.Size = new System.Drawing.Size(1435, 543);
            this.Controls.SetChildIndex(this.gcList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTableListSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCalculator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaryTableListID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubsidiaryName;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowanceCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowanceName;
        private DevExpress.XtraGrid.Columns.GridColumn colMoney;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomeTaxValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repCalculator;
    }
}
