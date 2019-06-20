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
    public partial class frmDanhSach_HopDong_ThemMoi : Form
    {

        DateTime DateBegin = DateTime.Now;
        public frmDanhSach_HopDong_ThemMoi()
        {
            InitializeComponent();
        }

        private void frmDanhSach_HopDong_ThemMoi_Load(object sender, EventArgs e)
        {
            GetList_Position();
            Get_EmployeeCodeToCBO();
        //  Get_EmployeeCodeByCode(txtEmployeeCode.EditValue.ToString());
            Get_Info_Company();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_hopDong();
        }

        static string _textAll = "0";
        private string call_Code_New()
        {
            txtEmployeeCode.Enabled = true;
            txtContractCode.Enabled = true;
            txtContractYear.Enabled = true;
            txtContractType.Enabled = true;
            txtContractTime.Enabled = true;


            txtBasicSalary.Text = "";
            txtAllowance.Text = "";
            txtRate.Text = "80";
            txtSubject.Text = "";
            txtDescription.Text = "";
            Set_NgayThangMacDinh();
            xulyTaoCodeHopdong();
            // cboSinger.EditValue = "PTH0002"; // mac dinh cho Giam Doc Dieu Hanh 
            _textAll = "0";
            return "";
        }
        private void Update_hopDong()
        {
            Class.DanhMuc_HopDong dmhd = new Class.DanhMuc_HopDong();
            dmhd.ContractCode = txtContractCode.Text;
            dmhd.EmployeeCode = txtEmployeeCode.Text;
            dmhd.ContractType = txtContractType.Text;
            dmhd.ContractTime = txtContractTime.Text;
            dmhd.ContractYear = int.Parse(txtContractYear.Text);
            dmhd.SignDate = dateSignDate.DateTime;
            dmhd.FromDate = dateFromDate.DateTime;
            dmhd.ToDate = dateToDate.DateTime;
            dmhd.BasicSalary = txtBasicSalary.Value;
            dmhd.PayForm = txtPayForm.Text;
            dmhd.PayDate = int.Parse(txtPayDate.Text);
            dmhd.Allowance = txtAllowance.Text;
            dmhd.SecondAllowance = txtTestAllowance.Text;
            dmhd.Rate = int.Parse(txtRate.Text);
            dmhd.Insurance = txtInsurance.Text;
            dmhd.WorkTime = txtWorkTime.Text;
            dmhd.Signer = txtSigner.Text;
            dmhd.SignerPosition = txtSignerPosition.Text;
            dmhd.SignerNationality = txtSignerNationality.Text;
            dmhd.Company = txtCompany.Text;
            dmhd.Address = txtAddress.Text;
            dmhd.Tel = txtTel.Text;
            dmhd.Subject = txtSubject.Text;
            dmhd.Description = txtDescription.Text;
            dmhd.IsCurrent = checkIsCurrent.Checked;
            if (dmhd.Insert())
            {
                Class.App.SaveSuccessfully();



            }
            else
            {
                Class.App.SaveNotSuccessfully();

            }


        }

        private void call_info(string code)
        {
            Class.DanhMuc_HopDong hd = new Class.DanhMuc_HopDong();
            DataTable dt = hd.CT_CONTRACT_Get(code);
            txtSigner.Text = dt.Rows[0]["Signer"].ToString();
            txtSignerNationality.Text = dt.Rows[0]["SignerNationality"].ToString();
            txtSignerPosition.Text = dt.Rows[0]["SignerPosition"].ToString();
            txtCompany.Text = dt.Rows[0]["Company"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            txtTel.Text = dt.Rows[0]["Tel"].ToString();
            checkIsCurrent.Checked = (bool)dt.Rows[0]["IsCurrent"];
            txtEmployeeCode.EditValue = dt.Rows[0]["EmployeeCode"].ToString();

            //tab thong tin hop dong
            if (dt.Rows[0]["SecondAllowance"].ToString().Length > 0)
                _textAll = dt.Rows[0]["SecondAllowance"].ToString();
            else
                _textAll = "0";

            txtContractCode.Text = dt.Rows[0]["ContractCode"].ToString();
            txtContractTime.Text = dt.Rows[0]["ContractTime"].ToString();
            txtContractType.Text = dt.Rows[0]["ContractType"].ToString();
            txtContractYear.Text = dt.Rows[0]["ContractYear"].ToString();
            dateSignDate.DateTime = (DateTime)dt.Rows[0]["SignDate"];
            dateFromDate.DateTime = (DateTime)dt.Rows[0]["FromDate"];
            if (dt.Rows[0]["ToDate"] != DBNull.Value)
            {
                dateToDate.DateTime = (DateTime)dt.Rows[0]["ToDate"];
            }
            txtBasicSalary.Value = (decimal)dt.Rows[0]["BasicSalary"];
            txtPayForm.Text = dt.Rows[0]["PayForm"].ToString();
            txtPayDate.Value = (int)dt.Rows[0]["PayDate"];
            txtAllowance.Text = dt.Rows[0]["Allowance"].ToString();
            txtTestAllowance.Text = dt.Rows[0]["SecondAllowance"].ToString();
            txtRate.Text = dt.Rows[0]["Rate"].ToString();
            txtInsurance.Text = dt.Rows[0]["Insurance"].ToString();
            txtWorkTime.Text = dt.Rows[0]["WorkTime"].ToString();
            txtSubject.Text = dt.Rows[0]["Subject"].ToString();
            txtDescription.Text = dt.Rows[0]["Description"].ToString();
        }
        private void txtEmployeeCode_EditValueChanged(object sender, EventArgs e)
        {

          int SelectedRow = cboEmployeeCodeDetail.FocusedRowHandle;
          if (SelectedRow >= 0)
          {
              DataRow drow = cboEmployeeCodeDetail.GetDataRow(SelectedRow);
              string _FirstName = drow["FirstName"].ToString();
              string _LastName = drow["LastName"].ToString();
              DateTime _Birthday = (DateTime)drow["Birthday"];
              string _Position = drow["Position"].ToString();
              string _Nationality = drow["Nationality"].ToString();
              string _IDCard = drow["IDCard"].ToString();
              DateTime _IDCardDate = (DateTime)drow["IDCardDate"];
              string _IDCardPlace = drow["IDCardPlace"].ToString();
              string _BranchName = drow["BranchName"].ToString();

              if (drow["BeginDate"] != DBNull.Value)
              {
                  DateBegin = (DateTime)drow["BeginDate"];
              }

              txtFullName.Text = _FirstName + " " + _LastName;
              dateBirthday.DateTime = _Birthday;
              txtPosition.Text = _Position;
              txtNationality.Text = _Nationality;
              txtIDCard.Text = _IDCard;
              dateIDCardDate.DateTime = _IDCardDate;
              txtIDCardPlace.Text = _IDCardPlace;
              txtBranchName.Text = _BranchName;

              xulyTaoCodeHopdong(); // goi ham tinh tu dong code
          }
        }

        private void Get_EmployeeCodeToCBO()
        {
            Class.NhanVien nv = new Class.NhanVien();
            nv.Status = -1;
            DataTable dt = nv.LoadDanhSachNhanVien_Ex();
            cboSinger.Properties.DataSource = dt;
            cboSinger.Properties.DisplayMember = "EmployeeCode";
            cboSinger.Properties.ValueMember = "EmployeeCode";

            txtEmployeeCode.Properties.DataSource = dt;
            txtEmployeeCode.Properties.DisplayMember = "EmployeeCode";
            txtEmployeeCode.Properties.ValueMember = "EmployeeCode";
        }

        private void Get_Info_Company()
        {
            Class.DanhMuc_CongTy ct = new Class.DanhMuc_CongTy();

            DataTable dt = ct.LoadThongTinCty();
            txtAddress.Text = dt.Rows[0]["CompanyAddress"].ToString();
            txtTel.Text = dt.Rows[0]["Tel"].ToString(); ;





        }


        private void xulyTaoCodeHopdong()
        {
           if (btnUpdate.Enabled==true)
            {
                if (txtFullName.Text != "[Họ và tên nhân viên]")
                {
                    Class.DanhMuc_HopDong hd = new Class.DanhMuc_HopDong();
                  //  Class.NhanVien_HopDong hd = new Class.NhanVien_HopDong();
                    hd.ContractYear = int.Parse(txtContractYear.Text);
                    // hd.ContractType = txtContractType.Text;
                    DataTable dt = hd.CT_CONTRACT_GetByYear();
                    hd.EmployeeCode = txtEmployeeCode.EditValue.ToString();
                    DataTable dthdbynv = hd.CT_CONTRACT_GetByEmployee();

                    if (dt.Rows.Count > 0)
                    {
                        string _idCheck;
                        string[] cat;
                        int next_ID = 0;
                        int next_ID2 = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            _idCheck = dt.Rows[i]["ContractCode"].ToString();
                            cat = _idCheck.Split('-');
                            next_ID2 = int.Parse(cat.GetValue(0).ToString());
                            if ((next_ID2 - next_ID) > 1)
                            {
                                break;
                            }
                            next_ID = int.Parse(cat.GetValue(0).ToString());
                        }
                        //string _idContract = dt.Rows[dt.Rows.Count - 1]["ContractCode"].ToString();
                        //cat = _idContract.Split('-');
                        // next_ID = int.Parse(cat.GetValue(0).ToString()) + 1;
                        next_ID++;
                        if (next_ID.ToString().Length == 1)
                        {
                            txtContractCode.Text = "000" + next_ID.ToString() + "-" + txtContractYear.Text;
                        }
                        if (next_ID.ToString().Length == 2)
                        {
                            txtContractCode.Text = "00" + next_ID.ToString() + "-" + txtContractYear.Text;
                        }
                        if (next_ID.ToString().Length == 3)
                        {
                            txtContractCode.Text = "0" + next_ID.ToString() + "-" + txtContractYear.Text;
                        }
                        if (next_ID.ToString().Length == 4)
                        {
                            txtContractCode.Text = next_ID.ToString() + "-" + txtContractYear.Text;
                        }
                    }
                    else
                    {
                        txtContractCode.Text = "0001-" + txtContractYear.Text;
                    }
                    // kiem tra ky hop dong truc tiep ko co thu viec
                    int solanHD = 1;
                    for (int i = 0; i < dthdbynv.Rows.Count; i++)
                    {
                        string maHD = dthdbynv.Rows[i]["ContractCode"].ToString();
                        if (maHD.Contains("HDTV"))
                        {
                            solanHD = dthdbynv.Rows.Count;
                            break;
                        }
                        if (maHD.Contains("HDLD"))
                        {
                            solanHD++;
                        }
                    }
                    switch (txtContractType.Text)
                    {
                        case "Hợp đồng xác định thời hạn":
                            txtContractCode.Text = txtContractCode.Text + "/HDLD/Lan" + solanHD;
                            break;

                        case "Hợp đồng không xác định thời hạn":
                            txtContractCode.Text = txtContractCode.Text + "/HDLD/KXDTH-Lan" + solanHD;
                            break;
                        case "Hợp đồng thử việc":
                            txtContractCode.Text = txtContractCode.Text + "/HDTV";
                            break;
                        case "Hợp đồng học việc":
                            txtContractCode.Text = txtContractCode.Text + "/HDHV";
                            break;
                    }

                    if (dthdbynv.Rows.Count > 0)
                    {
                        if (dthdbynv.Rows[dthdbynv.Rows.Count - 1]["ToDate"] != DBNull.Value)
                        {
                            DateTime _dateNgaykt = (DateTime)dthdbynv.Rows[dthdbynv.Rows.Count - 1]["ToDate"];
                            DateTime _dateNgayKyTiep = _dateNgaykt.AddDays(1);
                            dateFromDate.DateTime = _dateNgayKyTiep;
                            dateSignDate.DateTime = _dateNgayKyTiep;
                          dateFromDate_Validated(null, null);
                        }
                    }
                    else
                    {
                        // la HDTV se lay ngay tu ngay bat dau lam viec
                        dateFromDate.DateTime = DateBegin;
                        dateSignDate.DateTime = DateBegin;
                      dateFromDate_Validated(null, null);
                    }


                }
                else
                {
                    MessageBox.Show("Vui Lòng chọn nhân viên ký hợp đồng trước");
                    TabControl.SelectedTabPage = TabPage1;
                }
            }

            // tam thoi han che khong cho lam lap 4 hop dong lao dong
            if (txtContractCode.Text.Contains("Lan4"))
            {
                MessageBox.Show("Hợp đồng Lao động chỉ chấp nhận nhỏ hơn 4 lần, Vui lòng kiểm tra lại hoặc liên hệ Người Quản Trị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void GetList_Position()
        {
            Class.Danhmuc_Chucvu dm = new Class.Danhmuc_Chucvu();
            DataTable dt = dm.GetAlllist_Position();
            // txtSubject.Properties.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtSubject.Properties.Items.Add(dt.Rows[i]["PositionName"].ToString());
            }
        }

        private void Get_EmployeeCodeByCode(string strcode)
        {
            Class.NhanVien nv = new Class.NhanVien();
            DataTable dt = nv.GetEmployeeByCode(strcode);
            txtFullName.Text = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString(); ;
            dateBirthday.DateTime = (DateTime)dt.Rows[0]["Birthday"];
            txtPosition.Text = dt.Rows[0]["Position"].ToString();
            txtNationality.Text = dt.Rows[0]["Nationality"].ToString();
            txtIDCard.Text = dt.Rows[0]["IDCard"].ToString();
            dateIDCardDate.DateTime = (DateTime)dt.Rows[0]["IDCardDate"];
            txtIDCardPlace.Text = dt.Rows[0]["IDCardPlace"].ToString();
            txtBranchName.Text = dt.Rows[0]["BranchName"].ToString();



        }

        private void Set_NgayThangMacDinh()
        {
            dateSignDate.DateTime = DateTime.Now;
            dateFromDate.DateTime = DateTime.Now;
            dateToDate.DateTime = DateTime.Now;
            txtContractYear.Text = DateTime.Now.Year.ToString();
        }

        private void txtAddress_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateFromDate_Validated(object sender, EventArgs e)
        {
            txtContractTime_SelectedIndexChanged(null, null);
        }

        // Load thoi gian ky hop dong
        private void txtContractTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (txtContractTime.Text)
            {
                case "0 Tháng":
                    dateToDate.DateTime = dateFromDate.DateTime;
                    break;
                case "1 Tháng":
                    dateToDate.DateTime = dateFromDate.DateTime.AddMonths(1).AddDays(-1);
                    break;
                case "2 Tháng":
                    dateToDate.DateTime = dateFromDate.DateTime.AddMonths(2).AddDays(-1);
                    break;
                case "6 Tháng":
                    dateToDate.DateTime = dateFromDate.DateTime.AddMonths(6).AddDays(-1);
                    break;
                case "1 Năm":
                    dateToDate.DateTime = dateFromDate.DateTime.AddYears(1).AddDays(-1);
                    break;
                case "2 Năm":
                    dateToDate.DateTime = dateFromDate.DateTime.AddYears(2).AddDays(-1);
                    break;
            }

        }

        private void cboSinger_EditValueChanged(object sender, EventArgs e)
        {
            int SelectedRow = cboSingerDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                //DataRow drow = cboSingerDetail.GetDataRow(SelectedRow);
                //string _FirstName = drow["FirstName"].ToString();
                //string _LastName = drow["LastName"].ToString();
                ////DateTime _Birthday = (DateTime)drow["Birthday"];
                //string _Position = drow["Position"].ToString();
                //string _Nationality = drow["Nationality"].ToString();

                //txtSigner.Text = _FirstName + " " + _LastName;             
                //txtSignerPosition.Text = _Position;
                //txtSignerNationality.Text = _Nationality;
            }
        }
    }
}
