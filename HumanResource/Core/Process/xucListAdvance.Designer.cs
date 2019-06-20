namespace CHBK2014_N9.HumanResource.Core.Process
{
    partial class xucListAdvance
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
            this.colAdvanceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubsidiaryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCalculator = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptPhoto = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTableListSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCalculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptPhoto)).BeginInit();
            this.SuspendLayout();
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
            this.gcList.Location = new System.Drawing.Point(0, 31);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCalculator,
            this.rptPhoto});
            this.gcList.Size = new System.Drawing.Size(1276, 491);
            this.gcList.TabIndex = 4;
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
            this.gbList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gbList.ColumnPanelRowHeight = 32;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdvanceID,
            this.colSubsidiaryName,
            this.colDepartmentName,
            this.colGroupName,
            this.colEmployeeCode,
            this.colFirstName,
            this.colLastName,
            this.colReason,
            this.colMoney,
            this.colDate,
            this.colPerson});
            this.gbList.GridControl = this.gcList;
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
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.EnableAppearanceEvenRow = true;
            this.gbList.OptionsView.RowAutoHeight = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            // 
            // colAdvanceID
            // 
            this.colAdvanceID.Caption = "AdvanceID";
            this.colAdvanceID.FieldName = "AdvanceID";
            this.colAdvanceID.Name = "colAdvanceID";
            // 
            // colSubsidiaryName
            // 
            this.colSubsidiaryName.Caption = "Công ty con";
            this.colSubsidiaryName.FieldName = "SubsidiaryName";
            this.colSubsidiaryName.Name = "colSubsidiaryName";
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.Caption = "Phòng ban";
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.Width = 132;
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "Tổ nhóm";
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.Caption = "Mã NV";
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.OptionsColumn.AllowEdit = false;
            this.colEmployeeCode.OptionsColumn.ReadOnly = true;
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 0;
            this.colEmployeeCode.Width = 70;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Họ lót";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.OptionsColumn.ReadOnly = true;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 103;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Tên";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.AllowEdit = false;
            this.colLastName.OptionsColumn.ReadOnly = true;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 66;
            // 
            // colReason
            // 
            this.colReason.Caption = "Lý do tạm ứng";
            this.colReason.FieldName = "Reason";
            this.colReason.Name = "colReason";
            this.colReason.OptionsColumn.AllowEdit = false;
            this.colReason.OptionsColumn.ReadOnly = true;
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 3;
            this.colReason.Width = 209;
            // 
            // colMoney
            // 
            this.colMoney.Caption = "Số tiền";
            this.colMoney.ColumnEdit = this.repCalculator;
            this.colMoney.FieldName = "Money";
            this.colMoney.Name = "colMoney";
            this.colMoney.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Money", "{0:##,##0}")});
            this.colMoney.Visible = true;
            this.colMoney.VisibleIndex = 6;
            this.colMoney.Width = 85;
            // 
            // repCalculator
            // 
            this.repCalculator.AutoHeight = false;
            this.repCalculator.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCalculator.Name = "repCalculator";
            // 
            // colDate
            // 
            this.colDate.Caption = "Ngày tạm ứng";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.OptionsColumn.ReadOnly = true;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 4;
            this.colDate.Width = 102;
            // 
            // colPerson
            // 
            this.colPerson.AppearanceCell.Options.UseTextOptions = true;
            this.colPerson.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPerson.Caption = "Người cho ứng";
            this.colPerson.FieldName = "Person";
            this.colPerson.Name = "colPerson";
            this.colPerson.OptionsColumn.AllowEdit = false;
            this.colPerson.OptionsColumn.ReadOnly = true;
            this.colPerson.Visible = true;
            this.colPerson.VisibleIndex = 5;
            this.colPerson.Width = 147;
            // 
            // rptPhoto
            // 
            this.rptPhoto.CustomHeight = 48;
            this.rptPhoto.Name = "rptPhoto";
            this.rptPhoto.NullText = "[Chưa chọn hình]";
            this.rptPhoto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // xucListAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcList);
            this.Name = "xucListAdvance";
            this.Size = new System.Drawing.Size(1276, 547);
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
            ((System.ComponentModel.ISupportInitialize)(this.rptPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraGrid.Columns.GridColumn colAdvanceID;
        private DevExpress.XtraGrid.Columns.GridColumn colSubsidiaryName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colReason;
        private DevExpress.XtraGrid.Columns.GridColumn colMoney;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repCalculator;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPerson;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit rptPhoto;
    }
}
