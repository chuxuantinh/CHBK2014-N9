namespace CHBK2014_N9.ATT.UI.MayChamCong.DuLieuMayChamCong
{
    partial class frmTaiDuLieuChamCong
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.tbxMachineNumber = new System.Windows.Forms.TextBox();
            this.tbxDeviceIP = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSoRecord = new System.Windows.Forms.Label();
            this.labelItem3 = new System.Windows.Forms.Label();
            this.labelItem2 = new System.Windows.Forms.Label();
            this.labelItem1 = new System.Windows.Forms.Label();
            this.listViewMayChamCong = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTaiVeMayTinh = new System.Windows.Forms.Button();
            this.dateTimeDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLuaChonTai = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuBoChonTatCa = new System.Windows.Forms.ToolStrip();
            this.DGVDuLieuVaoRa = new System.Windows.Forms.DataGridView();
            this.ColMaChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBarChay = new System.Windows.Forms.ProgressBar();
            this.MenuChonTatCa = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox_MCCVL = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDuLieuVaoRa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_MCCVL);
            this.panel1.Controls.Add(this.txtSerial);
            this.panel1.Controls.Add(this.tbxMachineNumber);
            this.panel1.Controls.Add(this.tbxDeviceIP);
            this.panel1.Controls.Add(this.tbxPort);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbSoRecord);
            this.panel1.Controls.Add(this.labelItem3);
            this.panel1.Controls.Add(this.labelItem2);
            this.panel1.Controls.Add(this.labelItem1);
            this.panel1.Controls.Add(this.listViewMayChamCong);
            this.panel1.Controls.Add(this.btnTaiVeMayTinh);
            this.panel1.Controls.Add(this.dateTimeDenNgay);
            this.panel1.Controls.Add(this.dateTimeTuNgay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxLuaChonTai);
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 502);
            this.panel1.TabIndex = 0;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(103, 259);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(122, 20);
            this.txtSerial.TabIndex = 901;
            // 
            // tbxMachineNumber
            // 
            this.tbxMachineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMachineNumber.Location = new System.Drawing.Point(188, 402);
            this.tbxMachineNumber.MaxLength = 3;
            this.tbxMachineNumber.Name = "tbxMachineNumber";
            this.tbxMachineNumber.Size = new System.Drawing.Size(37, 20);
            this.tbxMachineNumber.TabIndex = 900;
            this.tbxMachineNumber.Text = "1";
            // 
            // tbxDeviceIP
            // 
            this.tbxDeviceIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDeviceIP.Location = new System.Drawing.Point(21, 402);
            this.tbxDeviceIP.Name = "tbxDeviceIP";
            this.tbxDeviceIP.Size = new System.Drawing.Size(99, 20);
            this.tbxDeviceIP.TabIndex = 898;
            this.tbxDeviceIP.Text = "192.168.8.19";
            // 
            // tbxPort
            // 
            this.tbxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPort.Location = new System.Drawing.Point(126, 402);
            this.tbxPort.MaxLength = 6;
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(56, 20);
            this.tbxPort.TabIndex = 899;
            this.tbxPort.Text = "4370";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(58, 367);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "label2";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSoRecord
            // 
            this.lbSoRecord.AutoSize = true;
            this.lbSoRecord.Location = new System.Drawing.Point(41, 266);
            this.lbSoRecord.Name = "lbSoRecord";
            this.lbSoRecord.Size = new System.Drawing.Size(35, 13);
            this.lbSoRecord.TabIndex = 9;
            this.lbSoRecord.Text = "label2";
            // 
            // labelItem3
            // 
            this.labelItem3.AutoSize = true;
            this.labelItem3.Location = new System.Drawing.Point(42, 222);
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Size = new System.Drawing.Size(35, 13);
            this.labelItem3.TabIndex = 8;
            this.labelItem3.Text = "label3";
            // 
            // labelItem2
            // 
            this.labelItem2.AutoSize = true;
            this.labelItem2.Location = new System.Drawing.Point(41, 197);
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Size = new System.Drawing.Size(35, 13);
            this.labelItem2.TabIndex = 7;
            this.labelItem2.Text = "label3";
            // 
            // labelItem1
            // 
            this.labelItem1.AutoSize = true;
            this.labelItem1.Location = new System.Drawing.Point(41, 175);
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Size = new System.Drawing.Size(35, 13);
            this.labelItem1.TabIndex = 6;
            this.labelItem1.Text = "label2";
            // 
            // listViewMayChamCong
            // 
            this.listViewMayChamCong.CheckBoxes = true;
            this.listViewMayChamCong.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewMayChamCong.LargeImageList = this.imageList1;
            this.listViewMayChamCong.Location = new System.Drawing.Point(14, 162);
            this.listViewMayChamCong.Name = "listViewMayChamCong";
            this.listViewMayChamCong.Size = new System.Drawing.Size(221, 97);
            this.listViewMayChamCong.TabIndex = 11;
            this.listViewMayChamCong.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTaiVeMayTinh
            // 
            this.btnTaiVeMayTinh.Location = new System.Drawing.Point(88, 119);
            this.btnTaiVeMayTinh.Name = "btnTaiVeMayTinh";
            this.btnTaiVeMayTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTaiVeMayTinh.TabIndex = 4;
            this.btnTaiVeMayTinh.Text = "&Tải về";
            this.btnTaiVeMayTinh.UseVisualStyleBackColor = true;
            this.btnTaiVeMayTinh.Click += new System.EventHandler(this.btnTaiVeMayTinh_Click);
            // 
            // dateTimeDenNgay
            // 
            this.dateTimeDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimeDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDenNgay.Location = new System.Drawing.Point(97, 91);
            this.dateTimeDenNgay.Name = "dateTimeDenNgay";
            this.dateTimeDenNgay.Size = new System.Drawing.Size(121, 20);
            this.dateTimeDenNgay.TabIndex = 3;
            // 
            // dateTimeTuNgay
            // 
            this.dateTimeTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimeTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTuNgay.Location = new System.Drawing.Point(97, 65);
            this.dateTimeTuNgay.Name = "dateTimeTuNgay";
            this.dateTimeTuNgay.Size = new System.Drawing.Size(121, 20);
            this.dateTimeTuNgay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lựa chọn tải";
            // 
            // comboBoxLuaChonTai
            // 
            this.comboBoxLuaChonTai.FormattingEnabled = true;
            this.comboBoxLuaChonTai.Items.AddRange(new object[] {
            "Tất cả",
            "Theo thời gian"});
            this.comboBoxLuaChonTai.Location = new System.Drawing.Point(97, 27);
            this.comboBoxLuaChonTai.Name = "comboBoxLuaChonTai";
            this.comboBoxLuaChonTai.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLuaChonTai.TabIndex = 0;
            this.comboBoxLuaChonTai.SelectedIndexChanged += new System.EventHandler(this.comboBoxLuaChonTai_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MenuBoChonTatCa);
            this.panel2.Controls.Add(this.DGVDuLieuVaoRa);
            this.panel2.Location = new System.Drawing.Point(246, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 455);
            this.panel2.TabIndex = 1;
            // 
            // MenuBoChonTatCa
            // 
            this.MenuBoChonTatCa.Location = new System.Drawing.Point(0, 0);
            this.MenuBoChonTatCa.Name = "MenuBoChonTatCa";
            this.MenuBoChonTatCa.Size = new System.Drawing.Size(1012, 25);
            this.MenuBoChonTatCa.TabIndex = 1;
            this.MenuBoChonTatCa.Text = "toolStrip1";
            // 
            // DGVDuLieuVaoRa
            // 
            this.DGVDuLieuVaoRa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDuLieuVaoRa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaChamCong,
            this.ColNgay,
            this.ColGio,
            this.Column4,
            this.Column5,
            this.Column6,
            this.ColTenMay});
            this.DGVDuLieuVaoRa.Location = new System.Drawing.Point(0, 18);
            this.DGVDuLieuVaoRa.Name = "DGVDuLieuVaoRa";
            this.DGVDuLieuVaoRa.Size = new System.Drawing.Size(1012, 437);
            this.DGVDuLieuVaoRa.TabIndex = 0;
            // 
            // ColMaChamCong
            // 
            this.ColMaChamCong.HeaderText = "Mã máy";
            this.ColMaChamCong.Name = "ColMaChamCong";
            // 
            // ColNgay
            // 
            this.ColNgay.HeaderText = "Column2";
            this.ColNgay.Name = "ColNgay";
            // 
            // ColGio
            // 
            this.ColGio.HeaderText = "Gio Cham";
            this.ColGio.Name = "ColGio";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kieu Cham";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nguon cham";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ma so may";
            this.Column6.Name = "Column6";
            // 
            // ColTenMay
            // 
            this.ColTenMay.HeaderText = "Tên máy";
            this.ColTenMay.Name = "ColTenMay";
            // 
            // progressBarChay
            // 
            this.progressBarChay.Location = new System.Drawing.Point(246, 30);
            this.progressBarChay.Name = "progressBarChay";
            this.progressBarChay.Size = new System.Drawing.Size(1005, 23);
            this.progressBarChay.TabIndex = 2;
            // 
            // MenuChonTatCa
            // 
            this.MenuChonTatCa.Location = new System.Drawing.Point(0, 0);
            this.MenuChonTatCa.Name = "MenuChonTatCa";
            this.MenuChonTatCa.Size = new System.Drawing.Size(1263, 25);
            this.MenuChonTatCa.TabIndex = 3;
            this.MenuChonTatCa.Text = "toolStrip1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // comboBox_MCCVL
            // 
            this.comboBox_MCCVL.FormattingEnabled = true;
            this.comboBox_MCCVL.Location = new System.Drawing.Point(79, 334);
            this.comboBox_MCCVL.Name = "comboBox_MCCVL";
            this.comboBox_MCCVL.Size = new System.Drawing.Size(121, 21);
            this.comboBox_MCCVL.TabIndex = 902;
            this.comboBox_MCCVL.SelectedIndexChanged += new System.EventHandler(this.comboBox_MCCVL_SelectedIndexChanged);
            // 
            // frmTaiDuLieuChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 483);
            this.Controls.Add(this.MenuChonTatCa);
            this.Controls.Add(this.progressBarChay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaiDuLieuChamCong";
            this.Text = "frmTaiDuLieuChamCong";
            this.Load += new System.EventHandler(this.frmTaiDuLieuChamCong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDuLieuVaoRa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBarChay;
        private System.Windows.Forms.ComboBox comboBoxLuaChonTai;
        private System.Windows.Forms.DateTimePicker dateTimeDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimeTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaiVeMayTinh;
        private System.Windows.Forms.DataGridView DGVDuLieuVaoRa;
        private System.Windows.Forms.ListView listViewMayChamCong;
        private System.Windows.Forms.ToolStrip MenuBoChonTatCa;
        private System.Windows.Forms.ToolStrip MenuChonTatCa;
        private System.Windows.Forms.Label labelItem2;
        private System.Windows.Forms.Label labelItem1;
        private System.Windows.Forms.Label labelItem3;
        private System.Windows.Forms.Label lbSoRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbxMachineNumber;
        private System.Windows.Forms.TextBox tbxDeviceIP;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenMay;
        private System.Windows.Forms.ComboBox comboBox_MCCVL;
    }
}