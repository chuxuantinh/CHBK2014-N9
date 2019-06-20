namespace CHBK2014_N9.Data
{
    partial class xfmLogin
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
            this.lblServer = new DevExpress.XtraEditors.LabelControl();
            this.rdgAuthentication = new DevExpress.XtraEditors.RadioGroup();
            this.tePassword = new System.Windows.Forms.TextBox();
            this.teLogin = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cbxServer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.trlServer = new DevExpress.XtraTreeList.TreeList();
            this.tlcServer = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lblSelectdatabase = new DevExpress.XtraEditors.LabelControl();
            this.picRefreshserver = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAuthentication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trlServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreshserver.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(227, 32);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(35, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server ";
            // 
            // rdgAuthentication
            // 
            this.rdgAuthentication.EditValue = 0;
            this.rdgAuthentication.Location = new System.Drawing.Point(289, 75);
            this.rdgAuthentication.Name = "rdgAuthentication";
            this.rdgAuthentication.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tài khoản Windows"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tài khoản SQL")});
            this.rdgAuthentication.Size = new System.Drawing.Size(190, 57);
            this.rdgAuthentication.TabIndex = 1;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(686, 82);
            this.tePassword.Name = "tePassword";
            this.tePassword.Size = new System.Drawing.Size(100, 21);
            this.tePassword.TabIndex = 2;
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(686, 45);
            this.teLogin.Name = "teLogin";
            this.teLogin.Size = new System.Drawing.Size(100, 21);
            this.teLogin.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(609, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "User Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(609, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(609, 131);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng nhập ";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(711, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxServer
            // 
            this.cbxServer.Location = new System.Drawing.Point(289, 25);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxServer.Size = new System.Drawing.Size(100, 20);
            this.cbxServer.TabIndex = 8;
            this.cbxServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxServer_KeyDown);
            // 
            // trlServer
            // 
            this.trlServer.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcServer});
            this.trlServer.Location = new System.Drawing.Point(12, 28);
            this.trlServer.Name = "trlServer";
            this.trlServer.BeginUnboundLoad();
            this.trlServer.AppendNode(new object[] {
            "Máy đơn"}, -1);
            this.trlServer.AppendNode(new object[] {
            "Mạng nội bộ"}, -1);
            this.trlServer.AppendNode(new object[] {
            "Mạng Internet"}, -1);
            this.trlServer.EndUnboundLoad();
            this.trlServer.Size = new System.Drawing.Size(186, 177);
            this.trlServer.TabIndex = 9;
            this.trlServer.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.trlServer_FocusedNodeChanged_1);
            // 
            // tlcServer
            // 
            this.tlcServer.Caption = "Chọn máy chủ";
            this.tlcServer.FieldName = "Chọn máy chủ";
            this.tlcServer.MinWidth = 34;
            this.tlcServer.Name = "tlcServer";
            this.tlcServer.Visible = true;
            this.tlcServer.VisibleIndex = 0;
            // 
            // lblSelectdatabase
            // 
            this.lblSelectdatabase.Location = new System.Drawing.Point(227, 160);
            this.lblSelectdatabase.Name = "lblSelectdatabase";
            this.lblSelectdatabase.Size = new System.Drawing.Size(74, 13);
            this.lblSelectdatabase.TabIndex = 10;
            this.lblSelectdatabase.Text = "Chọn Database";
            // 
            // picRefreshserver
            // 
            this.picRefreshserver.Location = new System.Drawing.Point(366, 160);
            this.picRefreshserver.Name = "picRefreshserver";
            this.picRefreshserver.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picRefreshserver.Size = new System.Drawing.Size(100, 31);
            this.picRefreshserver.TabIndex = 11;
            this.picRefreshserver.EditValueChanged += new System.EventHandler(this.picRefreshserver_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(641, 202);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Test ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xfmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 261);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.picRefreshserver);
            this.Controls.Add(this.lblSelectdatabase);
            this.Controls.Add(this.trlServer);
            this.Controls.Add(this.cbxServer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teLogin);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.rdgAuthentication);
            this.Controls.Add(this.lblServer);
            this.Name = "xfmLogin";
            this.Text = "xfnLogin";
            ((System.ComponentModel.ISupportInitialize)(this.rdgAuthentication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trlServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreshserver.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblServer;
        private DevExpress.XtraEditors.RadioGroup rdgAuthentication;
        private System.Windows.Forms.TextBox tePassword;
        private System.Windows.Forms.TextBox teLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.ComboBoxEdit cbxServer;
        private DevExpress.XtraTreeList.TreeList trlServer;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcServer;
        private DevExpress.XtraEditors.LabelControl lblSelectdatabase;
        private DevExpress.XtraEditors.PictureEdit picRefreshserver;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}