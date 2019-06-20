using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucListContractEmployee : UserControl
    {

        private int m_Status = -1;

        private int m_Level = MyLogin.Level;

        private string m_Code = MyLogin.Code;

        private string m_EmployeeCode = "";

        private Organization l_Organization;

        private DataTable dt_Employee;

        private SelectionMode m_ListSelectionMode = SelectionMode.One;
        public xucListContractEmployee()
        {
            InitializeComponent();
        }

        private void bbiViewByDepartment_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.xucOrganizationEdit1.BringToFront();
            this.imgListEmployee.Enabled = false;
            this.imgListEmployee.BackColor = Color.WhiteSmoke;
            this.imgListEmployee.ForeColor = Color.DimGray;
            if (this.l_Organization == null)
            {
                this.l_Organization = this.xucOrganizationEdit1.Organization;
            }
            this.RaiseDepartmentSelectedHandler(this.l_Organization);
        }

        private void bbiViewByEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.btSearch.BringToFront();
            this.imgListEmployee.Enabled = true;
            this.imgListEmployee.BackColor = Color.White;
            this.imgListEmployee.ForeColor = Color.Black;
            if (this.m_EmployeeCode != "")
            {
                this.RaiseEmployeeSelectedHandler(this.m_EmployeeCode);
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            this.Search(this.dt_Employee, this.btSearch.Text);
        }

        private void btSearch_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.Search(this.dt_Employee, this.btSearch.Text);
        }

        private void btSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.Search(this.dt_Employee, this.btSearch.Text);
            if (this.btSearch.Text == "")
            {
                this.btSearch.EditValue = null;
            }
        }

        private string GetCode(ImageListBoxItem item)
        {
            string str;
            try
            {
                string str1 = item.Value.ToString();
                char[] chrArray = new char[] { '(', ')' };
                str = str1.Split(chrArray)[1];
            }
            catch
            {
                str = "";
            }
            return str;
        }

        private void imgListEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            this.imgListEmployee.SelectionMode = SelectionMode.MultiSimple;
            if ((e.Modifiers != Keys.Control ? false : e.KeyCode == Keys.A))
            {
                this.imgListEmployee.SelectAll();
            }
        }

        private void imgListEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string code = this.GetCode(this.imgListEmployee.SelectedItem as ImageListBoxItem);
                string str = code;
                this.m_EmployeeCode = code;
                this.RaiseEmployeeSelectedHandler(str);
            }
            catch
            {
            }
            if (this.m_ListSelectionMode == SelectionMode.One)
            {
                if (Control.ModifierKeys == Keys.None)
                {
                    this.imgListEmployee.SelectionMode = SelectionMode.One;
                }
                else
                {
                    this.imgListEmployee.SelectionMode = SelectionMode.MultiSimple;
                }
            }
        }


        public void ListSelectionMode(SelectionMode mode)
        {
            SelectionMode selectionMode = mode;
            SelectionMode selectionMode1 = selectionMode;
            this.m_ListSelectionMode = selectionMode;
            this.imgListEmployee.SelectionMode = selectionMode1;
        }

        public void LoadData(int Type)
        {
            this.xucOrganizationEdit1.LoadData();
            if (Type != 0)
            {
                this.bbiViewByDepartment_ItemClick(this, null);
            }
            else
            {
                this.bbiViewByEmployee_ItemClick(this, null);
            }
            this.LoadData(-1, MyLogin.Level, MyLogin.Code);
        }

        public void LoadData(int Status, int Level, string Code)
        {
            this.m_Status = Status;
            this.m_Level = Level;
            this.m_Code = Code;
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            this.dt_Employee = hRMEMPLOYEE.GetListCurrentNow(this.m_Level, this.m_Code, this.m_Status);
            this.imgListEmployee.Items.Clear();
            if (this.dt_Employee.Rows.Count > 0)
            {
                foreach (DataRow row in this.dt_Employee.Rows)
                {
                    ImageListBoxItem imageListBoxItem = new ImageListBoxItem();
                    if (!bool.Parse(row["Sex"].ToString()))
                    {
                        imageListBoxItem.ImageIndex = 1;
                    }
                    else
                    {
                        imageListBoxItem.ImageIndex = 0;
                    }
                    string[] str = new string[] { "(", row["EmployeeCode"].ToString(), ") - ", row["FirstName"].ToString(), " ", row["LastName"].ToString() };
                    imageListBoxItem.Value = string.Concat(str);
                    this.imgListEmployee.Items.Add(imageListBoxItem);
                }
            }
        }

        private void RaiseDepartmentSelectedHandler(Organization Item)
        {
            if (this.DepartmentSelected != null)
            {
                this.DepartmentSelected(this, Item);
            }
        }

        private void RaiseEmployeeSelectedHandler(string EmployeeCode)
        {
            if (this.EmployeeSelected != null)
            {
                this.EmployeeSelected(this, EmployeeCode);
            }
        }

        public void Search(DataTable Employees, string Value)
        {
            this.imgListEmployee.Items.Clear();
            if (Employees.Rows.Count > 0)
            {
                foreach (DataRow row in Employees.Rows)
                {
                    if ((row["EmployeeCode"].ToString().ToLower().Contains(Value.ToLower()) || row["FirstName"].ToString().ToLower().Contains(Value.ToLower()) ? true : row["LastName"].ToString().ToLower().Contains(Value.ToLower())))
                    {
                        ImageListBoxItem imageListBoxItem = new ImageListBoxItem();
                        if (!(bool)row["Sex"])
                        {
                            imageListBoxItem.ImageIndex = 1;
                        }
                        else
                        {
                            imageListBoxItem.ImageIndex = 0;
                        }
                        string[] str = new string[] { "(", row["EmployeeCode"].ToString(), ") - ", row["FirstName"].ToString(), " ", row["LastName"].ToString() };
                        imageListBoxItem.Value = string.Concat(str);
                        this.imgListEmployee.Items.Add(imageListBoxItem);
                    }
                }
            }
        }


        private void xucOrganizationEdit1_DepartmentSelected(object sender, Organization Item)
        {
            this.LoadData(-1, Item.Level, Item.Code);
            Organization item = Item;
            Organization organization = item;
            this.l_Organization = item;
            this.RaiseDepartmentSelectedHandler(organization);
        }

        public event xucListContractEmployee.DepartmentSelectedHandler DepartmentSelected;

        public event xucListContractEmployee.EmployeeSelectedHandler EmployeeSelected;

        public delegate void DepartmentSelectedHandler(object sender, Organization Item);

        public delegate void EmployeeSelectedHandler(object sender, string EmployeeCode);
    }
}
