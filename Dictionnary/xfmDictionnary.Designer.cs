namespace CHBK2014_N9.Dictionnary
{
    partial class xfmDictionnary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmDictionnary));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navEmployee = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbiPosition = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiProfessional = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiDegree = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiLanguage = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiReligion = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiJob = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiNationality = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiEthnic = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiRelative = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiEducation = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiInformatic = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiSkill = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiProvince = new DevExpress.XtraNavBar.NavBarItem();
            this.navSalary = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbiAllowance = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiRank = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiStep = new DevExpress.XtraNavBar.NavBarItem();
            this.navTimekeeping = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbiHoliday = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiMachine = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiShift = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiSymbol = new DevExpress.XtraNavBar.NavBarItem();
            this.navOrganization = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbiBranch = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiDepartment = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiSubsidiary = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.navGroupRate = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbiGroupRate = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiRate = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.imgMetro = new DevExpress.Utils.ImageCollection(this.components);
            this.imgClassic = new DevExpress.Utils.ImageCollection(this.components);
            this.gcControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcControl = new DevExpress.XtraEditors.GroupControl();
            this.bbiState = new DevExpress.XtraNavBar.NavBarItem();
            this.bbiUnit = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMetro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClassic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcControl1)).BeginInit();
            this.gcControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcControl)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navEmployee;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navEmployee,
            this.navSalary,
            this.navTimekeeping,
            this.navOrganization,
            this.navGroupRate,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.bbiPosition,
            this.bbiProfessional,
            this.bbiDegree,
            this.bbiLanguage,
            this.navBarItem3,
            this.bbiReligion,
            this.bbiJob,
            this.bbiNationality,
            this.bbiBranch,
            this.bbiEthnic,
            this.navBarItem5,
            this.bbiRelative,
            this.bbiEducation,
            this.bbiInformatic,
            this.bbiSkill,
            this.bbiAllowance,
            this.bbiDepartment,
            this.bbiSubsidiary,
            this.bbiGroup,
            this.bbiGroupRate,
            this.bbiRate,
            this.bbiHoliday,
            this.bbiMachine,
            this.bbiShift,
            this.bbiSymbol,
            this.bbiProvince,
            this.bbiRank,
            this.bbiStep,
            this.bbiState,
            this.bbiUnit});
            this.navBarControl1.Location = new System.Drawing.Point(5, 23);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 212;
            this.navBarControl1.Size = new System.Drawing.Size(212, 555);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // navEmployee
            // 
            this.navEmployee.Caption = "Danh mục nhân sự";
            this.navEmployee.Expanded = true;
            this.navEmployee.ImageUri.Uri = "Pie";
            this.navEmployee.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiPosition),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiProfessional),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiDegree),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiLanguage),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiReligion),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiJob),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiNationality),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiEthnic),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiRelative),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiEducation),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiInformatic),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiSkill),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiProvince)});
            this.navEmployee.Name = "navEmployee";
            // 
            // bbiPosition
            // 
            this.bbiPosition.Caption = "Chức vụ";
            this.bbiPosition.ImageUri.Uri = "Forward";
            this.bbiPosition.Name = "bbiPosition";
            this.bbiPosition.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiPosition_LinkClicked);
            // 
            // bbiProfessional
            // 
            this.bbiProfessional.Caption = "Chuyên môn";
            this.bbiProfessional.ImageUri.Uri = "Apply";
            this.bbiProfessional.Name = "bbiProfessional";
            this.bbiProfessional.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiProfessional_LinkClicked);
            // 
            // bbiDegree
            // 
            this.bbiDegree.Caption = "Bằng cấp";
            this.bbiDegree.ImageUri.Uri = "Forward";
            this.bbiDegree.Name = "bbiDegree";
            this.bbiDegree.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiEducation_LinkClicked);
            // 
            // bbiLanguage
            // 
            this.bbiLanguage.Caption = "Ngoại ngữ";
            this.bbiLanguage.ImageUri.Uri = "Apply";
            this.bbiLanguage.Name = "bbiLanguage";
            this.bbiLanguage.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiLangguage_LinkPressed);
            this.bbiLanguage.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiLangguage_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Chức vụ";
            this.navBarItem3.ImageUri.Uri = "Apply";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // bbiReligion
            // 
            this.bbiReligion.Caption = "Tôn giáo";
            this.bbiReligion.ImageUri.Uri = "Apply";
            this.bbiReligion.Name = "bbiReligion";
            this.bbiReligion.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiReligion_LinkClicked);
            // 
            // bbiJob
            // 
            this.bbiJob.Caption = "Công việc";
            this.bbiJob.ImageUri.Uri = "Forward";
            this.bbiJob.Name = "bbiJob";
            this.bbiJob.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiJob_LinkClicked);
            // 
            // bbiNationality
            // 
            this.bbiNationality.Caption = "Quốc tịch";
            this.bbiNationality.ImageUri.Uri = "Forward";
            this.bbiNationality.Name = "bbiNationality";
            this.bbiNationality.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiNationlity_LinkClicked);
            // 
            // bbiEthnic
            // 
            this.bbiEthnic.Caption = "Dân tộc";
            this.bbiEthnic.ImageUri.Uri = "Forward";
            this.bbiEthnic.Name = "bbiEthnic";
            this.bbiEthnic.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiEthnic_LinkClicked);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Tôn giáo";
            this.navBarItem5.ImageUri.Uri = "Forward";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // bbiRelative
            // 
            this.bbiRelative.Caption = "Quan hệ gia đình";
            this.bbiRelative.ImageUri.Uri = "Forward";
            this.bbiRelative.Name = "bbiRelative";
            this.bbiRelative.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiRelative_LinkClicked);
            // 
            // bbiEducation
            // 
            this.bbiEducation.Caption = "Học vấn";
            this.bbiEducation.ImageUri.Uri = "Forward";
            this.bbiEducation.Name = "bbiEducation";
            this.bbiEducation.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiEducation_LinkClicked_1);
            // 
            // bbiInformatic
            // 
            this.bbiInformatic.Caption = "Tin học";
            this.bbiInformatic.ImageUri.Uri = "Forward";
            this.bbiInformatic.Name = "bbiInformatic";
            this.bbiInformatic.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiInformatic_LinkClicked);
            // 
            // bbiSkill
            // 
            this.bbiSkill.Caption = "Kỹ năng mềm";
            this.bbiSkill.ImageUri.Uri = "Forward";
            this.bbiSkill.Name = "bbiSkill";
            this.bbiSkill.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiSkill_LinkClicked);
            // 
            // bbiProvince
            // 
            this.bbiProvince.Caption = "Tỉnh thành";
            this.bbiProvince.ImageUri.Uri = "Forward";
            this.bbiProvince.Name = "bbiProvince";
            this.bbiProvince.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiProvince_LinkClicked);
            // 
            // navSalary
            // 
            this.navSalary.Caption = "Danh mục tính lương";
            this.navSalary.ImageUri.Uri = "Chart";
            this.navSalary.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiAllowance),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiRank),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiStep)});
            this.navSalary.Name = "navSalary";
            // 
            // bbiAllowance
            // 
            this.bbiAllowance.Caption = "Phụ cấp";
            this.bbiAllowance.ImageUri.Uri = "Currency";
            this.bbiAllowance.Name = "bbiAllowance";
            this.bbiAllowance.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // bbiRank
            // 
            this.bbiRank.Caption = "Ngạch lương";
            this.bbiRank.ImageUri.Uri = "Currency";
            this.bbiRank.Name = "bbiRank";
            this.bbiRank.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiRank_LinkClicked);
            // 
            // bbiStep
            // 
            this.bbiStep.Caption = "Bậc lương";
            this.bbiStep.ImageUri.Uri = "Currency";
            this.bbiStep.Name = "bbiStep";
            this.bbiStep.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiStep_LinkClicked);
            // 
            // navTimekeeping
            // 
            this.navTimekeeping.Caption = "Danh mục chấm công";
            this.navTimekeeping.Expanded = true;
            this.navTimekeeping.ImageUri.Uri = "ShowWorkTimeOnly";
            this.navTimekeeping.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiHoliday),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiMachine),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiShift),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiSymbol)});
            this.navTimekeeping.Name = "navTimekeeping";
            // 
            // bbiHoliday
            // 
            this.bbiHoliday.Caption = "Ngày nghỉ, kỳ ngỉ";
            this.bbiHoliday.ImageUri.Uri = "Forward";
            this.bbiHoliday.Name = "bbiHoliday";
            this.bbiHoliday.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiHoliday_LinkClicked);
            // 
            // bbiMachine
            // 
            this.bbiMachine.Caption = "Khai báo máy chấm công";
            this.bbiMachine.ImageUri.Uri = "Forward";
            this.bbiMachine.Name = "bbiMachine";
            this.bbiMachine.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiMachine_LinkClicked);
            // 
            // bbiShift
            // 
            this.bbiShift.Caption = "Ca làm việc";
            this.bbiShift.ImageUri.Uri = "SwitchTimeScalesTo";
            this.bbiShift.Name = "bbiShift";
            this.bbiShift.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiShift_LinkClicked);
            // 
            // bbiSymbol
            // 
            this.bbiSymbol.Caption = "Ký hiệu chấm công";
            this.bbiSymbol.ImageUri.Uri = "SwitchTimeScalesTo";
            this.bbiSymbol.Name = "bbiSymbol";
            this.bbiSymbol.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiSymbol_LinkClicked);
            // 
            // navOrganization
            // 
            this.navOrganization.Caption = "Danh mục cơ cấu tổ chức";
            this.navOrganization.Expanded = true;
            this.navOrganization.ImageUri.Uri = "SendBehindText";
            this.navOrganization.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiBranch),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiDepartment),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiSubsidiary),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiGroup)});
            this.navOrganization.Name = "navOrganization";
            // 
            // bbiBranch
            // 
            this.bbiBranch.Caption = "Chi nhánh";
            this.bbiBranch.ImageUri.Uri = "Forward";
            this.bbiBranch.Name = "bbiBranch";
            this.bbiBranch.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiBranch_LinkClicked);
            // 
            // bbiDepartment
            // 
            this.bbiDepartment.Caption = "Phòng ban";
            this.bbiDepartment.ImageUri.Uri = "Forward";
            this.bbiDepartment.Name = "bbiDepartment";
            this.bbiDepartment.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiDepartment_LinkClicked);
            // 
            // bbiSubsidiary
            // 
            this.bbiSubsidiary.Caption = "Công ty con";
            this.bbiSubsidiary.ImageUri.Uri = "Forward";
            this.bbiSubsidiary.Name = "bbiSubsidiary";
            this.bbiSubsidiary.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiSubsidiary_LinkClicked);
            // 
            // bbiGroup
            // 
            this.bbiGroup.Caption = "Tổ /nhóm";
            this.bbiGroup.ImageUri.Uri = "Forward";
            this.bbiGroup.Name = "bbiGroup";
            this.bbiGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiGroup_LinkClicked);
            // 
            // navGroupRate
            // 
            this.navGroupRate.Caption = "Danh mục tiêu chí đánh giá";
            this.navGroupRate.Expanded = true;
            this.navGroupRate.ImageUri.Uri = "Edit";
            this.navGroupRate.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiGroupRate),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiRate),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiState)});
            this.navGroupRate.Name = "navGroupRate";
            // 
            // bbiGroupRate
            // 
            this.bbiGroupRate.Caption = "Nhóm tiêu chí";
            this.bbiGroupRate.ImageUri.Uri = "Forward";
            this.bbiGroupRate.Name = "bbiGroupRate";
            this.bbiGroupRate.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiGroupRate_LinkClicked);
            // 
            // bbiRate
            // 
            this.bbiRate.Caption = "Tiêu chí đánh giá";
            this.bbiRate.ImageUri.Uri = "Forward";
            this.bbiRate.Name = "bbiRate";
            this.bbiRate.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiRate_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Danh mục khác";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbiUnit)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // imgMetro
            // 
            this.imgMetro.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgMetro.ImageStream")));
            // 
            // imgClassic
            // 
            this.imgClassic.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgClassic.ImageStream")));
            // 
            // gcControl1
            // 
            this.gcControl1.Controls.Add(this.navBarControl1);
            this.gcControl1.Location = new System.Drawing.Point(0, 0);
            this.gcControl1.Name = "gcControl1";
            this.gcControl1.Size = new System.Drawing.Size(222, 628);
            this.gcControl1.TabIndex = 1;
            this.gcControl1.Text = "Danh mục thông tin nhân sự";
            // 
            // gcControl
            // 
            this.gcControl.Location = new System.Drawing.Point(228, 0);
            this.gcControl.Name = "gcControl";
            this.gcControl.Size = new System.Drawing.Size(714, 628);
            this.gcControl.TabIndex = 2;
            this.gcControl.Text = "groupControl1";
            // 
            // bbiState
            // 
            this.bbiState.Caption = "Công đoạn";
            this.bbiState.ImageUri.Uri = "Forward";
            this.bbiState.Name = "bbiState";
            this.bbiState.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiState_LinkClicked);
            // 
            // bbiUnit
            // 
            this.bbiUnit.Caption = "Đơn vị tính";
            this.bbiUnit.ImageUri.Uri = "Forward";
            this.bbiUnit.Name = "bbiUnit";
            this.bbiUnit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbiUnit_LinkClicked);
            // 
            // xfmDictionnary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 628);
            this.Controls.Add(this.gcControl1);
            this.Controls.Add(this.gcControl);
            this.Name = "xfmDictionnary";
            this.Text = "Danh mục các thông tin liên quan";
            this.Load += new System.EventHandler(this.xfmDictionnary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMetro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClassic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcControl1)).EndInit();
            this.gcControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navEmployee;
        private DevExpress.XtraNavBar.NavBarItem bbiPosition;
        private DevExpress.XtraNavBar.NavBarGroup navSalary;
        private DevExpress.XtraNavBar.NavBarGroup navTimekeeping;
        private DevExpress.XtraNavBar.NavBarGroup navOrganization;
        private DevExpress.XtraNavBar.NavBarGroup navGroupRate;
        private DevExpress.XtraNavBar.NavBarItem bbiProfessional;
        private DevExpress.XtraNavBar.NavBarItem bbiDegree;
        private DevExpress.XtraNavBar.NavBarItem bbiLanguage;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem bbiReligion;
        private DevExpress.Utils.ImageCollection imgMetro;
        private DevExpress.Utils.ImageCollection imgClassic;
        private DevExpress.XtraEditors.GroupControl gcControl1;
        private DevExpress.XtraNavBar.NavBarItem bbiJob;
        private DevExpress.XtraNavBar.NavBarItem bbiNationality;
        private DevExpress.XtraEditors.GroupControl gcControl;
        private DevExpress.XtraNavBar.NavBarItem bbiBranch;
        private DevExpress.XtraNavBar.NavBarItem bbiEthnic;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem bbiRelative;
        private DevExpress.XtraNavBar.NavBarItem bbiEducation;
        private DevExpress.XtraNavBar.NavBarItem bbiInformatic;
        private DevExpress.XtraNavBar.NavBarItem bbiSkill;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem bbiAllowance;
        private DevExpress.XtraNavBar.NavBarItem bbiDepartment;
        private DevExpress.XtraNavBar.NavBarItem bbiSubsidiary;
        private DevExpress.XtraNavBar.NavBarItem bbiGroup;
        private DevExpress.XtraNavBar.NavBarItem bbiGroupRate;
        private DevExpress.XtraNavBar.NavBarItem bbiRate;
        private DevExpress.XtraNavBar.NavBarItem bbiHoliday;
        private DevExpress.XtraNavBar.NavBarItem bbiMachine;
        private DevExpress.XtraNavBar.NavBarItem bbiShift;
        private DevExpress.XtraNavBar.NavBarItem bbiSymbol;
        private DevExpress.XtraNavBar.NavBarItem bbiProvince;
        private DevExpress.XtraNavBar.NavBarItem bbiRank;
        private DevExpress.XtraNavBar.NavBarItem bbiStep;
        private DevExpress.XtraNavBar.NavBarItem bbiState;
        private DevExpress.XtraNavBar.NavBarItem bbiUnit;
    }
}