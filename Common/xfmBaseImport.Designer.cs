namespace CHBK2014_N9.Common
{
    partial class xfmBaseImport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmBaseImport));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lbMessage = new DevExpress.XtraEditors.LabelControl();
            this.lbFix = new System.Windows.Forms.LinkLabel();
            this.wcImport = new DevExpress.XtraWizard.WizardControl();
            this.wpSelectFile = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.lbLinkFileDecription = new DevExpress.XtraEditors.LabelControl();
            this.lbLinkFile = new DevExpress.XtraEditors.LabelControl();
            this.lbFilePathDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtFilePath = new DevExpress.XtraEditors.ButtonEdit();
            this.cheIsUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.wpProcessPage = new DevExpress.XtraWizard.WizardPage();
            this.lbProgressDescription = new DevExpress.XtraEditors.LabelControl();
            this.mqProgress = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.lbDataRow = new DevExpress.XtraEditors.LabelControl();
            this.wpFinish = new DevExpress.XtraWizard.CompletionWizardPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbFinishDescription = new DevExpress.XtraEditors.LabelControl();
            this.gcMessage = new DevExpress.XtraGrid.GridControl();
            this.gbMessage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wpSelectField = new DevExpress.XtraWizard.WizardPage();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectField = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSelectField = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lcSheet = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboSheet = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.wcImport)).BeginInit();
            this.wcImport.SuspendLayout();
            this.wpSelectFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsUpdate.Properties)).BeginInit();
            this.wpProcessPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mqProgress.Properties)).BeginInit();
            this.wpFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMessage)).BeginInit();
            this.wpSelectField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelectField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSheet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.AllowHtmlString = true;
            this.lbMessage.Location = new System.Drawing.Point(3, 5);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(182, 13);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Thành công: <color=red>0</color> mẫu tin. Lỗi: <color=red>0</color> mẫu tin.";
            // 
            // lbFix
            // 
            this.lbFix.AutoSize = true;
            this.lbFix.BackColor = System.Drawing.Color.Transparent;
            this.lbFix.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbFix.Location = new System.Drawing.Point(363, 4);
            this.lbFix.Name = "lbFix";
            this.lbFix.Size = new System.Drawing.Size(51, 16);
            this.lbFix.TabIndex = 3;
            this.lbFix.TabStop = true;
            this.lbFix.Text = "Sửa Lỗi";
            this.lbFix.Visible = false;
            this.lbFix.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbFix_LinkClicked);
            // 
            // wcImport
            // 
            this.wcImport.CancelText = "Thoát";
            this.wcImport.Controls.Add(this.wpSelectFile);
            this.wcImport.Controls.Add(this.wpProcessPage);
            this.wcImport.Controls.Add(this.wpFinish);
            this.wcImport.Controls.Add(this.wpSelectField);
            this.wcImport.Controls.Add(this.lcSheet);
            this.wcImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wcImport.FinishText = "&Hoàn Thành";
            this.wcImport.HelpText = "&Trợ Giúp";
            this.wcImport.Location = new System.Drawing.Point(0, 0);
            this.wcImport.Name = "wcImport";
            this.wcImport.NextText = "&Tiếp Tục >";
            this.wcImport.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wpSelectFile,
            this.wpSelectField,
            this.wpProcessPage,
            this.wpFinish});
            this.wcImport.PreviousText = "< &Trở Lại";
            this.wcImport.Size = new System.Drawing.Size(494, 467);
            this.wcImport.Text = "Các bước nhập danh sách * từ tập tin excel";
            this.wcImport.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wcImport.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wcImport_SelectedPageChanged);
            this.wcImport.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wcImport_NextClick);
            // 
            // wpSelectFile
            // 
            this.wpSelectFile.Controls.Add(this.lbLinkFileDecription);
            this.wpSelectFile.Controls.Add(this.lbLinkFile);
            this.wpSelectFile.Controls.Add(this.lbFilePathDescription);
            this.wpSelectFile.Controls.Add(this.txtFilePath);
            this.wpSelectFile.Controls.Add(this.cheIsUpdate);
            this.wpSelectFile.Name = "wpSelectFile";
            this.wpSelectFile.Size = new System.Drawing.Size(434, 299);
            this.wpSelectFile.Text = "Lựa chọn tập tin excel";
            // 
            // lbLinkFileDecription
            // 
            this.lbLinkFileDecription.AllowHtmlString = true;
            this.lbLinkFileDecription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbLinkFileDecription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbLinkFileDecription.Location = new System.Drawing.Point(4, 154);
            this.lbLinkFileDecription.Name = "lbLinkFileDecription";
            this.lbLinkFileDecription.Size = new System.Drawing.Size(410, 25);
            this.lbLinkFileDecription.TabIndex = 15;
            this.lbLinkFileDecription.Text = "Mở tập tin <b><i>*.xls</i></b> trong thư mục <b>ImportFile</b> tại ổ đĩa cài đặt " +
    "hoặc nhấp vào liên kết sau để xem tập tin mẫu:";
            // 
            // lbLinkFile
            // 
            this.lbLinkFile.AllowHtmlString = true;
            this.lbLinkFile.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbLinkFile.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbLinkFile.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisPath;
            this.lbLinkFile.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lbLinkFile.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.lbLinkFile.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbLinkFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLinkFile.Location = new System.Drawing.Point(31, 129);
            this.lbLinkFile.Name = "lbLinkFile";
            this.lbLinkFile.Size = new System.Drawing.Size(333, 31);
            this.lbLinkFile.TabIndex = 15;
            this.lbLinkFile.Text = "\\Bin\\Import\\*.xls";
            this.lbLinkFile.Click += new System.EventHandler(this.lbLinkFile_Click);
            // 
            // lbFilePathDescription
            // 
            this.lbFilePathDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbFilePathDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbFilePathDescription.Location = new System.Drawing.Point(3, 3);
            this.lbFilePathDescription.Name = "lbFilePathDescription";
            this.lbFilePathDescription.Size = new System.Drawing.Size(411, 47);
            this.lbFilePathDescription.TabIndex = 0;
            this.lbFilePathDescription.Text = "Điều chỉnh tập tin cần import có cấu trúc các trường dữ liệu giống như tập tin ex" +
    "cel mẫu (xem tập tin mẫu theo đường dẫn bên dưới). Đảm bảo dữ liệu cột mã * khôn" +
    "g trùng lấp nhau.";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(30, 66);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("txtFilePath.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Chọn tập tin để nạp dữ liệu", "Browse", null, true)});
            this.txtFilePath.Size = new System.Drawing.Size(334, 38);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.TabStop = false;
            this.txtFilePath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtFilePath_ButtonClick);
            // 
            // cheIsUpdate
            // 
            this.cheIsUpdate.Location = new System.Drawing.Point(4, 206);
            this.cheIsUpdate.Name = "cheIsUpdate";
            this.cheIsUpdate.Properties.Caption = "Cập nhật nếu tồn tại";
            this.cheIsUpdate.Size = new System.Drawing.Size(261, 19);
            this.cheIsUpdate.TabIndex = 15;
            this.cheIsUpdate.Visible = false;
            // 
            // wpProcessPage
            // 
            this.wpProcessPage.Controls.Add(this.lbProgressDescription);
            this.wpProcessPage.Controls.Add(this.mqProgress);
            this.wpProcessPage.Controls.Add(this.lbDataRow);
            this.wpProcessPage.Name = "wpProcessPage";
            this.wpProcessPage.Size = new System.Drawing.Size(434, 299);
            this.wpProcessPage.Text = "Tiến trình thực hiện việc nạp dữ liệu";
            // 
            // lbProgressDescription
            // 
            this.lbProgressDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbProgressDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbProgressDescription.Location = new System.Drawing.Point(3, 4);
            this.lbProgressDescription.Name = "lbProgressDescription";
            this.lbProgressDescription.Size = new System.Drawing.Size(411, 46);
            this.lbProgressDescription.TabIndex = 1;
            // 
            // mqProgress
            // 
            this.mqProgress.EditValue = 0;
            this.mqProgress.Location = new System.Drawing.Point(3, 79);
            this.mqProgress.Name = "mqProgress";
            this.mqProgress.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.mqProgress.Size = new System.Drawing.Size(410, 18);
            this.mqProgress.TabIndex = 0;
            // 
            // lbDataRow
            // 
            this.lbDataRow.Location = new System.Drawing.Point(160, 192);
            this.lbDataRow.Name = "lbDataRow";
            this.lbDataRow.Size = new System.Drawing.Size(63, 13);
            this.lbDataRow.TabIndex = 1;
            this.lbDataRow.Text = "labelControl2";
            // 
            // wpFinish
            // 
            this.wpFinish.AllowBack = false;
            this.wpFinish.Controls.Add(this.labelControl2);
            this.wpFinish.Controls.Add(this.lbFinishDescription);
            this.wpFinish.Controls.Add(this.gcMessage);
            this.wpFinish.Controls.Add(this.lbMessage);
            this.wpFinish.Name = "wpFinish";
            this.wpFinish.Size = new System.Drawing.Size(434, 299);
            this.wpFinish.Text = "Hoàn thành";
            this.wpFinish.Click += new System.EventHandler(this.wpFinish_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "labelControl2";
            // 
            // lbFinishDescription
            // 
            this.lbFinishDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbFinishDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbFinishDescription.Location = new System.Drawing.Point(7, 7);
            this.lbFinishDescription.Name = "lbFinishDescription";
            this.lbFinishDescription.Size = new System.Drawing.Size(411, 32);
            this.lbFinishDescription.TabIndex = 2;
            this.lbFinishDescription.Text = "Quá trình import dữ liệu * đã hoàn tất. Nhấn nút hoàn thành phía bên dưới để xác " +
    "nhận lại.";
            // 
            // gcMessage
            // 
            this.gcMessage.Location = new System.Drawing.Point(3, 71);
            this.gcMessage.MainView = this.gbMessage;
            this.gcMessage.Name = "gcMessage";
            this.gcMessage.Size = new System.Drawing.Size(428, 228);
            this.gcMessage.TabIndex = 0;
            this.gcMessage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbMessage});
            // 
            // gbMessage
            // 
            this.gbMessage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMessage,
            this.colStatus});
            this.gbMessage.GridControl = this.gcMessage;
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.OptionsView.EnableAppearanceEvenRow = true;
            this.gbMessage.OptionsView.RowAutoHeight = true;
            this.gbMessage.OptionsView.ShowColumnHeaders = false;
            this.gbMessage.OptionsView.ShowGroupPanel = false;
            this.gbMessage.OptionsView.ShowIndicator = false;
            // 
            // colMessage
            // 
            this.colMessage.Caption = "Thông tin";
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.OptionsColumn.AllowEdit = false;
            this.colMessage.OptionsColumn.ReadOnly = true;
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 0;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.ReadOnly = true;
            // 
            // wpSelectField
            // 
            this.wpSelectField.Controls.Add(this.gcList);
            this.wpSelectField.Name = "wpSelectField";
            this.wpSelectField.Size = new System.Drawing.Size(434, 299);
            this.wpSelectField.Text = "Ghép trường dữ liệu";
            // 
            // gcList
            // 
            this.gcList.Location = new System.Drawing.Point(0, 109);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSelectField});
            this.gcList.Size = new System.Drawing.Size(434, 184);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // gbList
            // 
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFieldName,
            this.colSelectField});
            this.gbList.GridControl = this.gcList;
            this.gbList.Name = "gbList";
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.OptionsView.ShowIndicator = false;
            // 
            // colFieldName
            // 
            this.colFieldName.Caption = "Mặc định";
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.OptionsColumn.AllowEdit = false;
            this.colFieldName.OptionsColumn.ReadOnly = true;
            this.colFieldName.Width = 159;
            // 
            // colSelectField
            // 
            this.colSelectField.Caption = "Tùy chọn";
            this.colSelectField.ColumnEdit = this.repSelectField;
            this.colSelectField.FieldName = "SelectField";
            this.colSelectField.Name = "colSelectField";
            this.colSelectField.Visible = true;
            this.colSelectField.VisibleIndex = 0;
            this.colSelectField.Width = 192;
            // 
            // repSelectField
            // 
            this.repSelectField.AutoHeight = false;
            this.repSelectField.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSelectField.Name = "repSelectField";
            this.repSelectField.NullText = "<Vui lòng chọn>";
            // 
            // lcSheet
            // 
            this.lcSheet.Location = new System.Drawing.Point(160, 65);
            this.lcSheet.Name = "lcSheet";
            this.lcSheet.Root = this.layoutControlGroup2;
            this.lcSheet.Size = new System.Drawing.Size(180, 120);
            this.lcSheet.TabIndex = 0;
            this.lcSheet.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(180, 120);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(243, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Chọn Sheet";
            // 
            // cboSheet
            // 
            this.cboSheet.Location = new System.Drawing.Point(61, 2);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSheet.Size = new System.Drawing.Size(79, 20);
            this.cboSheet.StyleController = this.lcSheet;
            this.cboSheet.TabIndex = 4;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // xfmBaseImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 467);
            this.Controls.Add(this.wcImport);
            this.Controls.Add(this.lbFix);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfmBaseImport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập từ Excel";
            ((System.ComponentModel.ISupportInitialize)(this.wcImport)).EndInit();
            this.wcImport.ResumeLayout(false);
            this.wpSelectFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsUpdate.Properties)).EndInit();
            this.wpProcessPage.ResumeLayout(false);
            this.wpProcessPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mqProgress.Properties)).EndInit();
            this.wpFinish.ResumeLayout(false);
            this.wpFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMessage)).EndInit();
            this.wpSelectField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelectField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSheet.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lbMessage;
        public System.Windows.Forms.LinkLabel lbFix;
        public DevExpress.XtraWizard.WizardControl wcImport;
        public DevExpress.XtraWizard.WelcomeWizardPage wpSelectFile;
        public DevExpress.XtraWizard.WizardPage wpSelectField;
        public DevExpress.XtraWizard.CompletionWizardPage wpFinish;
        public DevExpress.XtraWizard.WizardPage wpProcessPage;
        public DevExpress.XtraEditors.ButtonEdit txtFilePath;
        public DevExpress.XtraEditors.LabelControl lbFilePathDescription;
        public DevExpress.XtraEditors.LabelControl lbLinkFile;
        public DevExpress.XtraGrid.GridControl gcMessage;
        public DevExpress.XtraGrid.Views.Grid.GridView gbMessage;
        public DevExpress.XtraGrid.Columns.GridColumn colMessage;
        public DevExpress.XtraGrid.Columns.GridColumn colStatus;
        public DevExpress.XtraGrid.GridControl gcList;
        public DevExpress.XtraGrid.Views.Grid.GridView gbList;
        public DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        public DevExpress.XtraGrid.Columns.GridColumn colSelectField;
        public DevExpress.XtraEditors.Repository.RepositoryItemComboBox repSelectField;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.ComboBoxEdit cboSheet;
        public DevExpress.XtraLayout.LayoutControl lcSheet;
        public   DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        public DevExpress.XtraEditors.LabelControl lbDataRow;
            public DevExpress.XtraEditors.MarqueeProgressBarControl mqProgress;
        public DevExpress.XtraEditors.LabelControl lbLinkFileDecription;
        public DevExpress.XtraEditors.LabelControl lbProgressDescription;
        public DevExpress.XtraEditors.LabelControl lbFinishDescription;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.CheckEdit cheIsUpdate;
    }
}