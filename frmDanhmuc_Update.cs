using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHBK2014_N9
{
    public partial class frmDanhmuc_Update : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhmuc_Update()
        {


            InitializeComponent();
        }

        string _FormName = "";
        public string _reCallFunction;

        public frmDanhmuc_Update(bool Add_New, string Caption_Name, string Form_Name, string Code, string recallFunction)
        {

            InitializeComponent();
            this.Text = Caption_Name;
            if (Add_New)
            {
                txtCode.Text = Call_Code_New(Form_Name);
                
            }
            else
            {
                call_info(Form_Name, Code);
                txtCode.Enabled = false;
            }
            _FormName = Form_Name;
            _reCallFunction = recallFunction;

        }

        private string Call_Code_New(string Form_Name)
        {

            string code = "";
            switch (Form_Name)
            {

                case "TT":
                    Class.CT_Provice dmtt = new Class.CT_Provice();
                    code = dmtt.GetNewCode();
                    break;

                case "HV":
                    Class.Danhmuc_Hocvan dmhv = new Class.Danhmuc_Hocvan();
                    code = dmhv.GetNewCode();
                    break;
                case "BC":
                    Class.Danhmuc_Hocvan dmbc = new Class.Danhmuc_Hocvan();
                    code = dmbc.GetNewCode();
                    break;
                case "CV":
                    Class.Danhmuc_Chucvu dmcv = new Class.Danhmuc_Chucvu();
                    code = dmcv.GetNewCode();
                    break;
                case "CM":
                    Class.DanhMuc_ChuyenMon dmcm = new Class.DanhMuc_ChuyenMon();
                    code = dmcm.GetNewCode();
                    break;

                case "QG":
                    Class.DanhMuc_QuocGia dmqg = new Class.DanhMuc_QuocGia();
                    code = dmqg.GetNewCode();
                    break;
                case "DT":
                    Class.DanhMuc_DanToc dmdt = new Class.DanhMuc_DanToc();
                    code = dmdt.GetNewCode();
                    break;

                case "TG":
                    Class.DanhMuc_TonGiao dmtg = new Class.DanhMuc_TonGiao();
                    code = dmtg.GetNewCode();
                    break;
                case "QHGD":
                    Class.DanhMuc_GiaDinh dmgd = new Class.DanhMuc_GiaDinh();
                    code = dmgd.GetNewCode();
                    break;

                case "TH":
                    Class.DanhMuc_TinHoc dmth = new Class.DanhMuc_TinHoc();
                    code = dmth.GetNewCode();
                    break;
                case "NN":
                    Class.DanhMuc_NgoaiNgu dmnn = new Class.DanhMuc_NgoaiNgu();
                    code = dmnn.GetNewCode();
                    break;
                case "KN":
                    Class.DanhMuc_KyNang dmkn = new Class.DanhMuc_KyNang();
                    code = dmkn.GetNewCode();
                    break;
            
            }
            return code;

        }

        private void call_info(string Form_Name, string code)

        {
            switch (Form_Name)
            {

                case "TH":
                    Class.DanhMuc_TinHoc dmth = new Class.DanhMuc_TinHoc();
                    DataTable dtth = dmth.GetInformaticByCode(code);
                    txtCode.Text = dtth.Rows[0]["InformaticCode"].ToString();
                    txtName.Text = dtth.Rows[0]["InformaticName"].ToString();
                    txtDescription.Text = dtth.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dtth.Rows[0]["Active"];
                    break;
                case "NN":
                    Class.DanhMuc_NgoaiNgu dmnn = new Class.DanhMuc_NgoaiNgu();
                    DataTable dtnn = dmnn.GetLanguageByCode(code);
                    txtCode.Text = dtnn.Rows[0]["LanguageCode"].ToString();
                    txtName.Text = dtnn.Rows[0]["LanguageName"].ToString();
                    txtDescription.Text = dtnn.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dtnn.Rows[0]["Active"];
                    break;
                case "KN":
                    Class.DanhMuc_KyNang dmkn = new Class.DanhMuc_KyNang();
                    DataTable dtkn = dmkn.GetSkillByCode(code);
                    txtCode.Text = dtkn.Rows[0]["SkillCode"].ToString();
                    txtName.Text = dtkn.Rows[0]["SkillName"].ToString();
                    txtDescription.Text = dtkn.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dtkn.Rows[0]["Active"];
                    break;
                case "TT":
                    Class.CT_Provice dmtt = new Class.CT_Provice();
                    DataTable dttt = dmtt.GetProvinceByCode(code);
                    txtCode.Text = dttt.Rows[0]["ProvinceCode"].ToString();
                    txtName.Text = dttt.Rows[0]["ProvinceName"].ToString();
                    txtDescription.Text = dttt.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dttt.Rows[0]["Active"];
                    break;

                case "HV":
                    Class.Danhmuc_Hocvan dmhv = new Class.Danhmuc_Hocvan();
                    DataTable dthv = dmhv.GetEducationByCode(code);
                    txtCode.Text = dthv.Rows[0]["EducationCode"].ToString();
                                           txtName.Text = dthv.Rows[0]["EducationName"].ToString();
                    txtDescription.Text = dthv.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dthv.Rows[0]["Active"];
                    break;
               
                case "BC":
                    Class.DanhMuc_BangCap dmbc = new Class.DanhMuc_BangCap();
                    DataTable dtbc = dmbc.GetDegreeByCode(code);
                    txtCode.Text = dtbc.Rows[0]["DegreeCode"].ToString();
                    txtName.Text = dtbc.Rows[0]["DegreeName"].ToString();
                    txtDescription.Text = dtbc.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dtbc.Rows[0]["Active"];
                    break;
                case "CV":
                    Class.Danhmuc_Chucvu dmcv = new Class.Danhmuc_Chucvu();
                    DataTable dtcv = dmcv.GetPositionByCode(code);
                    txtCode.Text = dtcv.Rows[0]["PositionCode"].ToString();
                    txtName.Text = dtcv.Rows[0]["PositionName"].ToString();
                    txtDescription.Text = dtcv.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dtcv.Rows[0]["Active"];
                    break;
                case "CM":
                    Class.DanhMuc_ChuyenMon dmcm = new Class.DanhMuc_ChuyenMon();
                    DataTable dtcm = dmcm.GetProfessionalByCode(code);
                    txtCode.Text = dtcm.Rows[0]["ProfessionalCode"].ToString();
                    txtName.Text = dtcm.Rows[0]["ProfessionalName"].ToString();
                    txtDescription.Text = dtcm.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dtcm.Rows[0]["Active"];
                    break;

                case "QG":
                    Class.DanhMuc_QuocGia dmqg = new Class.DanhMuc_QuocGia();
                    DataTable dtqg = dmqg.GetNationalityByCode(code);
                    txtCode.Text = dtqg.Rows[0]["NationalityCode"].ToString();
                    txtName.Text = dtqg.Rows[0]["NationalityName"].ToString();
                    txtDescription.Text = dtqg.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dtqg.Rows[0]["Active"];
                    break;

                case "DT":
                    Class.DanhMuc_DanToc dmdt = new Class.DanhMuc_DanToc();
                    DataTable dtdt = dmdt.GetEthnicByCode(code);
                    txtCode.Text = dtdt.Rows[0]["EthnicCode"].ToString();
                    txtName.Text = dtdt.Rows[0]["EthnicName"].ToString();
                    txtDescription.Text = dtdt.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dtdt.Rows[0]["Active"];
                    break;
                case "TG":
                    Class.DanhMuc_TonGiao dmtg = new Class.DanhMuc_TonGiao();
                    DataTable dttg = dmtg.GetReligionByCode(code);
                    txtCode.Text = dttg.Rows[0]["ReligionCode"].ToString();
                    txtDescription.Text = dttg.Rows[0]["ReligionName"].ToString();
                    txtName.Text = dttg.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dttg.Rows[0]["Active"];
                    break;
                case "QHGD":
                    Class.DanhMuc_GiaDinh dmgd = new Class.DanhMuc_GiaDinh();
                    DataTable dtgd = dmgd.GetRelativeByCode(code);
                    txtCode.Text = dtgd.Rows[0]["RelativeCode"].ToString();
                    txtDescription.Text = dtgd.Rows[0]["RelativeName"].ToString();
                    txtName.Text = dtgd.Rows[0]["Description"].ToString();
                    checkActive.Checked = (bool)dtgd.Rows[0]["Active"];
                    break;
    

            }
    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 1 || txtCode.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            switch (_FormName)
            {

                case "TT":
                    Update_Tinh();
                    break;
                case "HV":
                    Update_HocVan();
                    this.Text = "Thêm Học vấn";
                    break;

                
                case "BC":
                    Update_BangCap();
                    this.Text = "Thêm Bằng cấp";
                    break;

                case "CV":
                    Update_ChucVu();
                    this.Text = "Thêm Chhức vụ";
                    break;
                case "CM":
                    Update_ChuyenMon();
                    this.Text = "Thêm Chuyên Môn";
                    break;

                case "QG":
                    Update_QuocGia();
                    this.Text = "Thêm Quốc gia";
                    break;
                case "DT":
                    Update_DanToc();
                    this.Text = "Thêm Dân Tộc";
                    break;

                case "TG":
                    Update_TonGiao();
                    this.Text = "Thêm Tôn giáo";
                    break;

                case "QHGD":
                    Update_GiaDinh();
                    this.Text = "Thêm Quan hệ gia đình";
                    break;
                case "TH":
                    Update_TinHoc();
                    break;
                case "NN":
                   Update_NgoaiNgu();
                    break;
                case "KN":
// Update_KyNang();
                    break;
            }
            this.Close();
        }

         private void Update_GiaDinh()
        {
            Class.DanhMuc_GiaDinh dm = new Class.DanhMuc_GiaDinh();
            dm.RelativeCode = txtCode.Text;
            dm.RelativeName = txtName.Text;
            dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            else
            {
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_reCallFunction == "frmDanhMuc_GiaDinh")
                (this.Owner as frmDanhMuc_GiaDinh).GetAllList_RELATIVE();
        }

         private void Update_TinHoc()
         {
             Class.DanhMuc_TinHoc dm = new Class.DanhMuc_TinHoc();
             dm.InformaticCode = txtCode.Text;
             dm.InformaticName = txtName.Text;
             dm.Description = txtDescription.Text;
             dm.Active = checkActive.Checked;
             if (txtCode.Enabled == true)
             {
                 if (dm.Insert())
                 {
                     Class.App.SaveSuccessfully();
                 }
                 else
                 {
                     Class.App.SaveNotSuccessfully();
                 }
             }
             else
             {
                 if (dm.Update())
                 {
                     Class.App.SaveSuccessfully();
                 }
                 else
                 {
                     Class.App.SaveNotSuccessfully();
                 }
             }
             if (_reCallFunction == "frmDanhMuc_TinHoc")
                 (this.Owner as frmDanhMuc_TinHoc).GetAllList_INFORMATIC();
         }

         private void Update_NgoaiNgu()
         {
             Class.DanhMuc_NgoaiNgu dm = new Class.DanhMuc_NgoaiNgu();
             dm.LanguageCode = txtCode.Text;
             dm.LanguageName = txtName.Text;
             dm.Description = txtDescription.Text;
             dm.Active = checkActive.Checked;
             if (txtCode.Enabled == true)
             {
                 if (dm.Insert())
                 {
                     Class.App.SaveSuccessfully();
                 }
                 else
                 {
                     Class.App.SaveNotSuccessfully();
                 }
             }
             else
             {
                 if (dm.Update())
                 {
                     Class.App.SaveSuccessfully();
                 }
                 else
                 {
                     Class.App.SaveNotSuccessfully();
                 }
             }
             if (_reCallFunction == "frmDanhMuc_NgoaiNgu")
                 (this.Owner as frmDanhmuc_Ngoaingu).Laydanhsachngoaingu();
         }

         //private void Update_KyNang()
         //{
         //    Class.DanhMuc_KyNang dm = new Class.DanhMuc_KyNang();
         //    dm.SkillCode = txtCode.Text;
         //    dm.SkillName = txtName.Text;
         //    dm.Description = txtDescription.Text;
         //    dm.Active = checkActive.Checked;
         //    if (txtCode.Enabled == true)
         //    {
         //        if (dm.Insert())
         //        {
         //            Class.App.SaveSuccessfully();
         //        }
         //        else
         //        {
         //            Class.App.SaveNotSuccessfully();
         //        }
         //    }
         //    else
         //    {
         //        if (dm.Update())
         //        {
         //            Class.App.SaveSuccessfully();
         //        }
         //        else
         //        {
         //            Class.App.SaveNotSuccessfully();
         //        }
         //    }
         //    if (_reCallFunction == "frmDanhMuc_KyNang")
         //        (this.Owner as frmDanhMuc_KyNang).GetAllList_SKILL();
         //}

        private void Update_TonGiao()
        {
            Class.DanhMuc_TonGiao dm = new Class.DanhMuc_TonGiao();
            dm.ReligionCode = txtCode.Text;
            dm.ReligionName = txtName.Text;
            dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            else
            {
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_reCallFunction == "frmDanhMuc_DantToc")
                (this.Owner as frmDanhMuc_DantToc).GetAllList_ETHNIC();


        }

        private void  Update_DanToc()
        {
            Class.DanhMuc_DanToc dm = new Class.DanhMuc_DanToc();
            dm.EthnicCode = txtCode.Text;
            dm.EthnicName = txtName.Text;
            dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            else
            {
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_reCallFunction == "frmDanhMuc_DantToc")
                (this.Owner as frmDanhMuc_DantToc).GetAllList_ETHNIC();


        }

        private void Update_QuocGia()
        {
            Class.DanhMuc_QuocGia dm = new Class.DanhMuc_QuocGia();
            dm.NationalityCode = txtCode.Text;
            dm.NationalityName = txtName.Text;
            dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            else
            {
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_reCallFunction == "frmDanhmuc_QuocGia")
                (this.Owner as frmDanhmuc_QuocGia).Loadanhsachquocgia();


        }


        private void Update_ChuyenMon()
        {
            Class.DanhMuc_ChuyenMon dm = new Class.DanhMuc_ChuyenMon();
            dm.ProfessionalCode = txtCode.Text;
            dm.ProfessionalName = txtName.Text;
            dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            else
            {
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_reCallFunction == "frmDanhMuc_ChuyenMon")
                (this.Owner as frmDanhMuc_ChuyenMon).GetAllList_PROFESSIONAL();


        }


        private void Update_BangCap()
        {
            Class.DanhMuc_BangCap dm = new Class.DanhMuc_BangCap();
            dm.DegreeCode = txtCode.Text;
            dm.DegreeName = txtName.Text;
            dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            else
            {
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_reCallFunction == "frmDanhmuc_Bangcap")
                (this.Owner as frmDanhmuc_Bangcap).Loadbangcap();


        }

        private void Update_HocVan()
        {
           Class.Danhmuc_Hocvan dm = new Class.Danhmuc_Hocvan();
            dm.EducationCode = txtCode.Text;
            dm.EducationName = txtName.Text;
            dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            else
            {
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_reCallFunction == "frmDanhmuc_Hocvan")
                (this.Owner as frmDanhmuc_Hocvan).Laydanhsachhocvan();
        }

       

        private void Update_Tinh()
        {
            Class.CT_Provice dm = new Class.CT_Provice();
            dm.ProvinceCode = txtCode.Text;
            dm.ProvinceName = txtName.Text;
            dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            else
            {
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_reCallFunction == "frmProvince")
                (this.Owner as frmProvince).GetAllList_Province();
        }


        private void Update_ChucVu()
        {
            Class.Danhmuc_Chucvu dm = new Class.Danhmuc_Chucvu();
            dm.PositionCode = txtCode.Text;
            dm.PositionName = txtName.Text;
            dm.IsManager = checkActive.Checked;
                dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            else
            {
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_reCallFunction == "frmDanhMuc_ChucVu")
                (this.Owner as frmDanhMuc_ChucVu).GetAllList_Position();


        }

        private void btnUpdateNew_Click(object sender, EventArgs e)
        {
              if (txtName.Text.Length < 1 || txtCode.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            switch (_FormName)
            {
                case "CM":
                    Update_ChuyenMon();
                    this.Text = "Thêm chuyên môn";
                    break;
                case "BC":
                    Update_BangCap();
                    this.Text = "Thêm Bằng cấp";
                    break;
                case "QT":
                    Update_QuocGia();
                    this.Text = "Thêm Quốc tịch";
                    break;
                case "DT":
                    Update_DanToc();
                    this.Text = "Thêm Dân tộc";
                    break;
                case "TG":
                    Update_TonGiao();
                    this.Text = "Thêm Tôn Giáo";
                    break;
                case "QHGD":
                    Update_GiaDinh();
                    this.Text = "Thêm Quan hệ gia đình";
                    break;
                //case "HV":
                //    Update_HocVan();
                //    this.Text = "Thêm Học vấn";
                ////    break;
                //case "TH":
                //    Update_TinHoc();
                //    this.Text = "Thêm Bằng tin học";
                //    break;
                //case "NN":
                //    Update_NgoaiNgu();
                //    this.Text = "Thêm Bằng ngoại ngữ";
                //    break;
                //case "KN":
                //    Update_KyNang();
                //    this.Text = "Thêm Kỹ năng";
                //    break;
                //case "TT":
                //    Update_Tinh();
                //    this.Text = "Thêm Tỉnh";
                //    break;
                //case "TrH":
                //    Update_TruongHoc();
                //    this.Text = "Thêm Trường học";
                //    break;
            }
            txtCode.Enabled = true;
            txtCode.Text = Call_Code_New(_FormName);
            txtName.Text = "";
            txtDescription.Text = "";
        
        }

    }
}
