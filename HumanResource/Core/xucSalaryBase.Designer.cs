namespace CHBK2014_N9.HumanResource.Core
{
    partial class xucSalaryBase
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ptLock = new System.Windows.Forms.PictureBox();
            this.ptFinish = new System.Windows.Forms.PictureBox();
            this.lbSalaryName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbSubName = new DevExpress.XtraEditors.LabelControl();
            this.xucExpandCollapseButton1 = new CHBK2014_N9.Common.Base.xucExpandCollapseButton();
            this.lbMessage = new DevExpress.XtraEditors.LabelControl();
            this.lbMainName = new DevExpress.XtraEditors.LabelControl();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dManager)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ptLock);
            this.flowLayoutPanel1.Controls.Add(this.ptFinish);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(296, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(487, 20);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // ptLock
            // 
            this.ptLock.Location = new System.Drawing.Point(4, 0);
            this.ptLock.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ptLock.Name = "ptLock";
            this.ptLock.Size = new System.Drawing.Size(16, 16);
            this.ptLock.TabIndex = 0;
            this.ptLock.TabStop = false;
            this.ptLock.Visible = false;
            // 
            // ptFinish
            // 
            this.ptFinish.Location = new System.Drawing.Point(24, 0);
            this.ptFinish.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ptFinish.Name = "ptFinish";
            this.ptFinish.Size = new System.Drawing.Size(16, 16);
            this.ptFinish.TabIndex = 16;
            this.ptFinish.TabStop = false;
            this.ptFinish.Visible = false;
            // 
            // lbSalaryName
            // 
            this.lbSalaryName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbSalaryName.Location = new System.Drawing.Point(6, 3);
            this.lbSalaryName.Name = "lbSalaryName";
            this.lbSalaryName.Size = new System.Drawing.Size(147, 14);
            this.lbSalaryName.TabIndex = 0;
            this.lbSalaryName.Text = "Bảng Lương Tháng [00]";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lbSubName);
            this.panelControl1.Controls.Add(this.xucExpandCollapseButton1);
            this.panelControl1.Controls.Add(this.lbMessage);
            this.panelControl1.Controls.Add(this.lbSalaryName);
            this.panelControl1.Controls.Add(this.lbMainName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(270, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1006, 36);
            this.panelControl1.TabIndex = 17;
            // 
            // lbSubName
            // 
            this.lbSubName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubName.Location = new System.Drawing.Point(846, 4);
            this.lbSubName.Name = "lbSubName";
            this.lbSubName.Size = new System.Drawing.Size(45, 13);
            this.lbSubName.TabIndex = 3;
            this.lbSubName.Text = "SubName";
            // 
            // xucExpandCollapseButton1
            // 
            this.xucExpandCollapseButton1.Location = new System.Drawing.Point(611, 4);
            this.xucExpandCollapseButton1.Name = "xucExpandCollapseButton1";
            this.xucExpandCollapseButton1.Size = new System.Drawing.Size(17, 15);
            this.xucExpandCollapseButton1.TabIndex = 5;
            this.xucExpandCollapseButton1.ExpandCollapsed += new CHBK2014_N9.Common.Base.xucExpandCollapseButton.ExpandCollapsedHander(this.xucExpandCollapseButton1_ExpandCollapsed);
            // 
            // lbMessage
            // 
            this.lbMessage.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbMessage.Location = new System.Drawing.Point(170, 4);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(415, 13);
            this.lbMessage.TabIndex = 18;
            this.lbMessage.Text = "[Nếu bạn chưa phát sinh dữ liệu chấm công của tháng này thì vui lòng thực hiện tr" +
    "ước]";
            // 
            // lbMainName
            // 
            this.lbMainName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMainName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbMainName.Location = new System.Drawing.Point(673, 3);
            this.lbMainName.Name = "lbMainName";
            this.lbMainName.Size = new System.Drawing.Size(62, 14);
            this.lbMainName.TabIndex = 20;
            this.lbMainName.Text = "MainName";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4796, 22);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(439, 21);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4796, 1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(439, 18);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // dManager
            // 
            this.dManager.Form = this;
            this.dManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // xucSalaryBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "xucSalaryBase";
            this.Size = new System.Drawing.Size(1276, 521);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel3, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox ptLock;
        private System.Windows.Forms.PictureBox ptFinish;
        private DevExpress.XtraBars.Docking.DockManager dManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl lbSubName;
        private DevExpress.XtraEditors.LabelControl lbMainName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl lbMessage;
        public DevExpress.XtraEditors.LabelControl lbSalaryName;
        private Common.Base.xucExpandCollapseButton xucExpandCollapseButton1;
    }
}
