namespace CHBK2014_N9.ATT.UI.MayChamCong
{
    partial class frmDangKyMayChamCong
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
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMayChamcong = new System.Windows.Forms.ComboBox();
            this.Button_KetNoi = new System.Windows.Forms.Button();
            this.button_DangKy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIDMayThongTin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKieuKetNoiThongTin = new System.Windows.Forms.Label();
            this.lbDiaChiIPThongTin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPortThongTin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCongCOMThongTin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTocDoTruyenThongTin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDiaChiWebThongTin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbKetNoiTuXaThongTin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDangKy = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbxDeviceIP = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.tbxMachineNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(136, 408);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(207, 20);
            this.txtSerial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial";
            // 
            // comboBoxMayChamcong
            // 
            this.comboBoxMayChamcong.FormattingEnabled = true;
            this.comboBoxMayChamcong.Location = new System.Drawing.Point(197, 48);
            this.comboBoxMayChamcong.Name = "comboBoxMayChamcong";
            this.comboBoxMayChamcong.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMayChamcong.TabIndex = 2;
            this.comboBoxMayChamcong.SelectedIndexChanged += new System.EventHandler(this.comboBoxMayChamcong_SelectedIndexChanged);
            // 
            // Button_KetNoi
            // 
            this.Button_KetNoi.Location = new System.Drawing.Point(85, 12);
            this.Button_KetNoi.Name = "Button_KetNoi";
            this.Button_KetNoi.Size = new System.Drawing.Size(75, 23);
            this.Button_KetNoi.TabIndex = 3;
            this.Button_KetNoi.Text = "Kết nối";
            this.Button_KetNoi.UseVisualStyleBackColor = true;
            this.Button_KetNoi.Click += new System.EventHandler(this.Button_KetNoi_Click);
            // 
            // button_DangKy
            // 
            this.button_DangKy.Location = new System.Drawing.Point(197, 12);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(75, 23);
            this.button_DangKy.TabIndex = 4;
            this.button_DangKy.Text = "Đăng ký";
            this.button_DangKy.UseVisualStyleBackColor = true;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Máy chấm công";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Máy";
            // 
            // lbIDMayThongTin
            // 
            this.lbIDMayThongTin.AutoSize = true;
            this.lbIDMayThongTin.Location = new System.Drawing.Point(194, 80);
            this.lbIDMayThongTin.Name = "lbIDMayThongTin";
            this.lbIDMayThongTin.Size = new System.Drawing.Size(83, 13);
            this.lbIDMayThongTin.TabIndex = 7;
            this.lbIDMayThongTin.Text = "Máy chấm công";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kiểu kết nối";
            // 
            // lbKieuKetNoiThongTin
            // 
            this.lbKieuKetNoiThongTin.AutoSize = true;
            this.lbKieuKetNoiThongTin.Location = new System.Drawing.Point(194, 107);
            this.lbKieuKetNoiThongTin.Name = "lbKieuKetNoiThongTin";
            this.lbKieuKetNoiThongTin.Size = new System.Drawing.Size(83, 13);
            this.lbKieuKetNoiThongTin.TabIndex = 9;
            this.lbKieuKetNoiThongTin.Text = "Máy chấm công";
            // 
            // lbDiaChiIPThongTin
            // 
            this.lbDiaChiIPThongTin.AutoSize = true;
            this.lbDiaChiIPThongTin.Location = new System.Drawing.Point(194, 142);
            this.lbDiaChiIPThongTin.Name = "lbDiaChiIPThongTin";
            this.lbDiaChiIPThongTin.Size = new System.Drawing.Size(83, 13);
            this.lbDiaChiIPThongTin.TabIndex = 11;
            this.lbDiaChiIPThongTin.Text = "Máy chấm công";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "IP";
            // 
            // lbPortThongTin
            // 
            this.lbPortThongTin.AutoSize = true;
            this.lbPortThongTin.Location = new System.Drawing.Point(194, 170);
            this.lbPortThongTin.Name = "lbPortThongTin";
            this.lbPortThongTin.Size = new System.Drawing.Size(83, 13);
            this.lbPortThongTin.TabIndex = 13;
            this.lbPortThongTin.Text = "Máy chấm công";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Port";
            // 
            // lbCongCOMThongTin
            // 
            this.lbCongCOMThongTin.AutoSize = true;
            this.lbCongCOMThongTin.Location = new System.Drawing.Point(194, 198);
            this.lbCongCOMThongTin.Name = "lbCongCOMThongTin";
            this.lbCongCOMThongTin.Size = new System.Drawing.Size(83, 13);
            this.lbCongCOMThongTin.TabIndex = 15;
            this.lbCongCOMThongTin.Text = "Máy chấm công";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "COM";
            // 
            // lbTocDoTruyenThongTin
            // 
            this.lbTocDoTruyenThongTin.AutoSize = true;
            this.lbTocDoTruyenThongTin.Location = new System.Drawing.Point(194, 226);
            this.lbTocDoTruyenThongTin.Name = "lbTocDoTruyenThongTin";
            this.lbTocDoTruyenThongTin.Size = new System.Drawing.Size(83, 13);
            this.lbTocDoTruyenThongTin.TabIndex = 17;
            this.lbTocDoTruyenThongTin.Text = "Máy chấm công";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tốc độ truyền";
            // 
            // lbDiaChiWebThongTin
            // 
            this.lbDiaChiWebThongTin.AutoSize = true;
            this.lbDiaChiWebThongTin.Location = new System.Drawing.Point(194, 253);
            this.lbDiaChiWebThongTin.Name = "lbDiaChiWebThongTin";
            this.lbDiaChiWebThongTin.Size = new System.Drawing.Size(83, 13);
            this.lbDiaChiWebThongTin.TabIndex = 19;
            this.lbDiaChiWebThongTin.Text = "Máy chấm công";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Địa chỉ web";
            // 
            // lbKetNoiTuXaThongTin
            // 
            this.lbKetNoiTuXaThongTin.AutoSize = true;
            this.lbKetNoiTuXaThongTin.Location = new System.Drawing.Point(194, 287);
            this.lbKetNoiTuXaThongTin.Name = "lbKetNoiTuXaThongTin";
            this.lbKetNoiTuXaThongTin.Size = new System.Drawing.Size(83, 13);
            this.lbKetNoiTuXaThongTin.TabIndex = 21;
            this.lbKetNoiTuXaThongTin.Text = "Máy chấm công";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kết nối từ xa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số đăng ký";
            // 
            // txtDangKy
            // 
            this.txtDangKy.Location = new System.Drawing.Point(136, 434);
            this.txtDangKy.Name = "txtDangKy";
            this.txtDangKy.Size = new System.Drawing.Size(207, 20);
            this.txtDangKy.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(0, 435);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblStatus.Size = new System.Drawing.Size(416, 25);
            this.lblStatus.TabIndex = 894;
            this.lblStatus.Text = "label3";
            // 
            // tbxDeviceIP
            // 
            this.tbxDeviceIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDeviceIP.Location = new System.Drawing.Point(60, 371);
            this.tbxDeviceIP.Name = "tbxDeviceIP";
            this.tbxDeviceIP.Size = new System.Drawing.Size(99, 20);
            this.tbxDeviceIP.TabIndex = 895;
            this.tbxDeviceIP.Text = "192.168.8.19";
            // 
            // tbxPort
            // 
            this.tbxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPort.Location = new System.Drawing.Point(165, 371);
            this.tbxPort.MaxLength = 6;
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(56, 20);
            this.tbxPort.TabIndex = 896;
            this.tbxPort.Text = "4370";
            // 
            // tbxMachineNumber
            // 
            this.tbxMachineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMachineNumber.Location = new System.Drawing.Point(240, 371);
            this.tbxMachineNumber.MaxLength = 3;
            this.tbxMachineNumber.Name = "tbxMachineNumber";
            this.tbxMachineNumber.Size = new System.Drawing.Size(37, 20);
            this.tbxMachineNumber.TabIndex = 897;
            this.tbxMachineNumber.Text = "1";
            // 
            // frmDangKyMayChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 460);
            this.Controls.Add(this.tbxMachineNumber);
            this.Controls.Add(this.tbxDeviceIP);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDangKy);
            this.Controls.Add(this.lbKetNoiTuXaThongTin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbDiaChiWebThongTin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTocDoTruyenThongTin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbCongCOMThongTin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbPortThongTin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDiaChiIPThongTin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbKieuKetNoiThongTin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbIDMayThongTin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_DangKy);
            this.Controls.Add(this.Button_KetNoi);
            this.Controls.Add(this.comboBoxMayChamcong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerial);
            this.Name = "frmDangKyMayChamCong";
            this.Text = "frmDangKyMayChamCong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangKyMayChamCong_FormClosing);
            this.Load += new System.EventHandler(this.frmDangKyMayChamCong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMayChamcong;
        private System.Windows.Forms.Button Button_KetNoi;
        private System.Windows.Forms.Button button_DangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIDMayThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKieuKetNoiThongTin;
        private System.Windows.Forms.Label lbDiaChiIPThongTin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPortThongTin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCongCOMThongTin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTocDoTruyenThongTin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDiaChiWebThongTin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbKetNoiTuXaThongTin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDangKy;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbxDeviceIP;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.TextBox tbxMachineNumber;
    }
}