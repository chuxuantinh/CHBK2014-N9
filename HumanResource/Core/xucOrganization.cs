using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
//using CHBK2014_N9.Common.Report;
using CHBK2014_N9;
using CHBK2014_N9.ERP;
//using CHBK2014_N9.Net.Info;
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucOrganization : UserControl
    {

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        private PopupMenu ppDepartment;

        private Point m_Point;

        private string m_CompanyName = "";

        private DataTable dt;

        private int m_Status = 2;

        private bool m_IsAll = false;

        private Organization cls;

        

        private int m_CompanyFactQuantity = 0;

        private int m_CompanyQuantity = 0;
        public xucOrganization()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.xucOrganization_Load_1);
        }




        //

        private void AddBranchNullToDataTable(DataTable dt)
        {
            foreach (DataRow row in (new HRM_BRANCH()).GetListBySubsidiaryNull().Rows)
            {
                DataRowCollection rows = dt.Rows;
                object[] str = new object[] { row["BranchCode"].ToString(), string.Concat(row["BranchName"].ToString(), this.StringQuantity(row)), "All", "Branch", int.Parse(row["FactQuantity"].ToString()), int.Parse(row["Quantity"].ToString()), 2 };
                rows.Add(str);
                this.m_CompanyFactQuantity += int.Parse(row["FactQuantity"].ToString());
                this.m_CompanyQuantity += int.Parse(row["Quantity"].ToString());
                this.AddDepartmentByBranchNotNullToDataTable(row["BranchCode"].ToString(), dt);
            }
        }

        private void AddBranchToDataTable(string SubsidiaryCode, DataTable dt)
        {
            foreach (DataRow row in (new HRM_BRANCH()).GetListBySubsidiary(SubsidiaryCode).Rows)
            {
                DataRowCollection rows = dt.Rows;
                object[] str = new object[] { row["BranchCode"].ToString(), string.Concat(row["BranchName"].ToString(), this.StringQuantity(row)), row["SubsidiaryCode"].ToString(), "Branch", int.Parse(row["FactQuantity"].ToString()), int.Parse(row["Quantity"].ToString()), 2 };
                rows.Add(str);
                this.AddDepartmentByBranchToDataTable(row["BranchCode"].ToString(), dt);
            }
        }

        private void AddDepartmentByBranchNotNullToDataTable(string BranchCode, DataTable dt)
        {
            foreach (DataRow row in (new HRM_DEPARTMENT()).GetListByBranchNotNull(BranchCode).Rows)
            {
                DataRowCollection rows = dt.Rows;
                object[] str = new object[] { row["DepartmentCode"].ToString(), string.Concat(row["DepartmentName"].ToString(), this.StringQuantity(row)), BranchCode, "Department", int.Parse(row["FactQuantity"].ToString()), int.Parse(row["Quantity"].ToString()), 3 };
                rows.Add(str);
                this.AddGroupToDataTable(row["DepartmentCode"].ToString(), dt);
            }
        }

        private void AddDepartmentByBranchToDataTable(string BranchCode, DataTable dt)
        {
            foreach (DataRow row in (new HRM_DEPARTMENT()).GetListByBranch(BranchCode).Rows)
            {
                DataRowCollection rows = dt.Rows;
                object[] str = new object[] { row["DepartmentCode"].ToString(), string.Concat(row["DepartmentName"].ToString(), this.StringQuantity(row)), row["BranchCode"].ToString(), "Department", int.Parse(row["FactQuantity"].ToString()), int.Parse(row["Quantity"].ToString()), 3 };
                rows.Add(str);
                this.AddGroupToDataTable(row["DepartmentCode"].ToString(), dt);
            }
        }

        private void AddDepartmentBySubsidiaryNotNullToDataTable(string SubsidiaryCode, DataTable dt)
        {
            foreach (DataRow row in (new HRM_DEPARTMENT()).GetListBySubsidiaryNotNull(SubsidiaryCode).Rows)
            {
                DataRowCollection rows = dt.Rows;
                object[] str = new object[] { row["DepartmentCode"].ToString(), string.Concat(row["DepartmentName"].ToString(), this.StringQuantity(row)), SubsidiaryCode, "Department", int.Parse(row["FactQuantity"].ToString()), int.Parse(row["Quantity"].ToString()), 3 };
                rows.Add(str);
                this.AddGroupToDataTable(row["DepartmentCode"].ToString(), dt);
            }
        }

        private void AddDepartmentNullToDataTable(DataTable dt)
        {
            foreach (DataRow row in (new HRM_DEPARTMENT()).GetListBySubsidiaryBranchNull().Rows)
            {
                DataRowCollection rows = dt.Rows;
                object[] str = new object[] { row["DepartmentCode"].ToString(), string.Concat(row["DepartmentName"].ToString(), this.StringQuantity(row)), "All", "Department", int.Parse(row["FactQuantity"].ToString()), int.Parse(row["Quantity"].ToString()), 3 };
                rows.Add(str);
                this.m_CompanyFactQuantity += int.Parse(row["FactQuantity"].ToString());
                this.m_CompanyQuantity += int.Parse(row["Quantity"].ToString());
                this.AddGroupToDataTable(row["DepartmentCode"].ToString(), dt);
            }
        }

        private void AddEmployeeToDataTable(DataTable dt, string Place, string Code)
        {
            DataTable listCurrentNow;
            object[] str;
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            if (Place == "Subsidiary")
            {
                listCurrentNow = hRMEMPLOYEE.GetListCurrentNow(1, Code, -1);
            }
            else if (!(Place == "Branch"))
            {
                listCurrentNow = (!(Place == "Department") ? hRMEMPLOYEE.GetListCurrentNow(4, Code, -1) : hRMEMPLOYEE.GetListCurrentNow(3, Code, -1));
            }
            else
            {
                listCurrentNow = hRMEMPLOYEE.GetListCurrentNow(2, Code, -1);
            }
            foreach (DataRow row in listCurrentNow.Rows)
            {
                if ((bool)row["Sex"])
                {
                    if ((int)row["Status"] == 3)
                    {
                        DataRowCollection rows = dt.Rows;
                        str = new object[] { row["EmployeeCode"].ToString(), string.Concat(row["FirstName"].ToString(), " ", row["LastName"].ToString()), row["GroupCode"].ToString(), "Employee", 7 };
                        rows.Add(str);
                    }
                    else
                    {
                        DataRowCollection dataRowCollection = dt.Rows;
                        str = new object[] { row["EmployeeCode"].ToString(), string.Concat(row["FirstName"].ToString(), " ", row["LastName"].ToString()), row["GroupCode"].ToString(), "Employee", 5 };
                        dataRowCollection.Add(str);
                    }
                }
                else if ((int)row["Status"] == 3)
                {
                    DataRowCollection rows1 = dt.Rows;
                    str = new object[] { row["EmployeeCode"].ToString(), string.Concat(row["FirstName"].ToString(), " ", row["LastName"].ToString()), row["GroupCode"].ToString(), "Employee", 8 };
                    rows1.Add(str);
                }
                else
                {
                    DataRowCollection dataRowCollection1 = dt.Rows;
                    str = new object[] { row["EmployeeCode"].ToString(), string.Concat(row["FirstName"].ToString(), " ", row["LastName"].ToString()), row["GroupCode"].ToString(), "Employee", 6 };
                    dataRowCollection1.Add(str);
                }
            }
        }

        private void AddGroupToDataTable(string DepartmentCode, DataTable dt)
        {
            foreach (DataRow row in (new HRM_GROUP()).GetListByDepartment(DepartmentCode).Rows)
            {
                DataRowCollection rows = dt.Rows;
                object[] str = new object[] { row["GroupCode"].ToString(), string.Concat(row["GroupName"].ToString(), this.StringQuantity(row)), row["DepartmentCode"].ToString(), "Group", int.Parse(row["FactQuantity"].ToString()), int.Parse(row["Quantity"].ToString()), 4 };
                rows.Add(str);
            }
        }

        private void AddSubsidiaryToDataTable(DataTable dt)
        {
            foreach (DataRow row in (new HRM_SUBSIDIARY()).GetList().Rows)
            {
                DataRowCollection rows = dt.Rows;
                object[] str = new object[] { row["SubsidiaryCode"].ToString(), string.Concat(row["SubsidiaryName"].ToString(), this.StringQuantity(row)), "All", "Subsidiary", int.Parse(row["FactQuantity"].ToString()), int.Parse(row["Quantity"].ToString()), 1 };
                rows.Add(str);
                this.m_CompanyFactQuantity += int.Parse(row["FactQuantity"].ToString());
                this.m_CompanyQuantity += int.Parse(row["Quantity"].ToString());
                this.AddBranchToDataTable(row["SubsidiaryCode"].ToString(), dt);
                this.AddDepartmentBySubsidiaryNotNullToDataTable(row["SubsidiaryCode"].ToString(), dt);
            }
        }



        //
        public void DeleteNode(TreeListNode Node)
        {
        }

        private void DepartmentAdd(HRM_DEPARTMENT Item, DevExpress.XtraTreeList.Nodes.TreeListNode TreeListNode, string Code)
        {
            if (TreeListNode.HasChildren)
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode node in TreeListNode.Nodes)
                {
                    if (!(node.GetValue("ID").ToString() == Code))
                    {
                        this.DepartmentAdd(Item, node, Code);
                    }
                    else
                    {
                        TreeList treeList = this.treeList1;
                        object[] departmentCode = new object[] { Item.DepartmentCode, string.Concat(Item.DepartmentName, this.StringQuantity(0, 0)), Code, "Department", 0, 0, 3 };
                        DevExpress.XtraTreeList.Nodes.TreeListNode treeListNode = treeList.AppendNode(departmentCode, node);
                        this.treeList1.SetFocusedNode(treeListNode);
                        return;
                    }
                }
            }
        }
        //
        /// <summary>
        /// 
        /// </summary>


        private void frm_Added(object sender, HRM_SUBSIDIARY Item)
        {
            TreeList treeList = this.treeList1;
            object[] subsidiaryCode = new object[] { Item.SubsidiaryCode, string.Concat(Item.SubsidiaryName, this.StringQuantity(0, 0)), "All", "Subsidiary", 0, 0, 1 };
            treeList.AppendNode(subsidiaryCode, this.treeList1.Nodes.FirstNode);
        }

        private void frm_Added(object sender, HRM_BRANCH Item)
        {
            TreeListNode treeListNode;
            object[] branchCode;
            if (!(Item.SubsidiaryCode != ""))
            {
                TreeList treeList = this.treeList1;
                branchCode = new object[] { Item.BranchCode, string.Concat(Item.BranchName, this.StringQuantity(0, 0)), "All", "Branch", 0, 0, 2 };
                treeListNode = treeList.AppendNode(branchCode, this.treeList1.Nodes.FirstNode);
                this.treeList1.SetFocusedNode(treeListNode);
            }
            else
            {
                foreach (TreeListNode node in this.treeList1.Nodes.FirstNode.Nodes)
                {
                    if (node.GetValue("ID").ToString() == Item.SubsidiaryCode)
                    {
                        TreeList treeList1 = this.treeList1;
                        branchCode = new object[] { Item.BranchCode, string.Concat(Item.BranchName, this.StringQuantity(0, 0)), Item.SubsidiaryCode, "Branch", 0, 0, 2 };
                        treeListNode = treeList1.AppendNode(branchCode, node);
                        this.treeList1.SetFocusedNode(treeListNode);
                    }
                }
            }
        }

        private void frm_Added(object sender, HRM_DEPARTMENT Item)
        {
            if (Item.SubsidiaryCode != "")
            {
                if (!(Item.BranchCode != ""))
                {
                    this.DepartmentAdd(Item, this.treeList1.Nodes.FirstNode, Item.SubsidiaryCode);
                }
                else
                {
                    this.DepartmentAdd(Item, this.treeList1.Nodes.FirstNode, Item.BranchCode);
                }
            }
            else if (!(Item.BranchCode != ""))
            {
                TreeList treeList = this.treeList1;
                object[] departmentCode = new object[] { Item.DepartmentCode, string.Concat(Item.DepartmentName, this.StringQuantity(0, 0)), "All", "Department", 0, 0, 3 };
                TreeListNode treeListNode = treeList.AppendNode(departmentCode, this.treeList1.Nodes.FirstNode);
                this.treeList1.SetFocusedNode(treeListNode);
            }
            else
            {
                this.DepartmentAdd(Item, this.treeList1.Nodes.FirstNode, Item.BranchCode);
            }
        }

        private void frm_Added(object sender, HRM_GROUP Item)
        {
            if (!(Item.DepartmentCode != ""))
            {
                this.Reload();
            }
            else
            {
                this.GroupAdd(Item, this.treeList1.Nodes.FirstNode);
            }
        }

        private void frm_Updated(object sender, HRM_SUBSIDIARY Item)
        {
            TreeListNode focusedNode = this.treeList1.FocusedNode;
            focusedNode.SetValue("Name", string.Concat(Item.SubsidiaryName, this.StringQuantity(int.Parse(focusedNode.GetValue("FactQuantity").ToString()), int.Parse(focusedNode.GetValue("Quantity").ToString()))));
        }

        private void frm_Updated(object sender, HRM_BRANCH Item)
        {
            TreeListNode focusedNode = this.treeList1.FocusedNode;
            if (!(Item.SubsidiaryCode != focusedNode.GetValue("ParentID").ToString()))
            {
                focusedNode.SetValue("Name", string.Concat(Item.BranchName, this.StringQuantity(int.Parse(focusedNode.GetValue("FactQuantity").ToString()), int.Parse(focusedNode.GetValue("Quantity").ToString()))));
            }
            else
            {
                this.Reload();
            }
        }

        private void frm_Updated(object sender, HRM_DEPARTMENT Item)
        {
            bool flag;
            TreeListNode focusedNode = this.treeList1.FocusedNode;
            if ((!(Item.BranchCode == "") || !(Item.SubsidiaryCode == "") || !(focusedNode.GetValue("ParentID").ToString() == "All")) && (!(focusedNode.GetValue("ParentID").ToString() == Item.BranchCode) || !(Item.SubsidiaryCode == "") || !(focusedNode.ParentNode.GetValue("ParentID").ToString() == "All")) && (!(focusedNode.GetValue("ParentID").ToString() == Item.SubsidiaryCode) || !(Item.BranchCode == "") || !(focusedNode.ParentNode.GetValue("ParentID").ToString() == "All")))
            {
                flag = (!(Item.BranchCode != "") || !(Item.SubsidiaryCode != "") || !(focusedNode.GetValue("ParentID").ToString() == Item.BranchCode) ? true : !(focusedNode.ParentNode.GetValue("ParentID").ToString() == Item.SubsidiaryCode));
            }
            else
            {
                flag = false;
            }
            if (flag)
            {
                this.Reload();
            }
            else
            {
                focusedNode.SetValue("Name", string.Concat(Item.DepartmentName, this.StringQuantity(int.Parse(focusedNode.GetValue("FactQuantity").ToString()), int.Parse(focusedNode.GetValue("Quantity").ToString()))));
            }
        }

        private void frm_Updated(object sender, HRM_GROUP Item)
        {
            TreeListNode focusedNode = this.treeList1.FocusedNode;
            if (!(Item.DepartmentCode != focusedNode.GetValue("ParentID").ToString()))
            {
                focusedNode.SetValue("Name", string.Concat(Item.GroupName, this.StringQuantity(int.Parse(focusedNode.GetValue("FactQuantity").ToString()), int.Parse(focusedNode.GetValue("Quantity").ToString()))));
            }
            else
            {
                this.Reload();
            }
        }

        private void GroupAdd(HRM_GROUP Item, DevExpress.XtraTreeList.Nodes.TreeListNode TreeListNode)
        {
            if (TreeListNode.HasChildren)
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode node in TreeListNode.Nodes)
                {
                    if (!(node.GetValue("ID").ToString() == Item.DepartmentCode))
                    {
                        this.GroupAdd(Item, node);
                    }
                    else
                    {
                        TreeList treeList = this.treeList1;
                        object[] groupCode = new object[] { Item.GroupCode, string.Concat(Item.GroupName, this.StringQuantity(0, 0)), Item.DepartmentCode, "Group", 0, 0, 4 };
                        DevExpress.XtraTreeList.Nodes.TreeListNode treeListNode = treeList.AppendNode(groupCode, node);
                        this.treeList1.SetFocusedNode(treeListNode);
                        return;
                    }
                }
            }
        }

        public void LoadAllData()
        {
            this.m_IsAll = true;
            this.m_Status = 2;
            this.LoadTreeList(0, "");
        }

        public void LoadAllData(int Status)
        {
            this.m_IsAll = true;
            this.m_Status = Status;
            this.LoadTreeList(0, "");
        }

        public void LoadData()
        {
            this.m_IsAll = false;
            this.m_Status = 2;
            this.LoadTreeList(MyLogin.Level, MyLogin.Code);
        }

        public void LoadData(int Status)
        {
            this.m_IsAll = false;
            this.m_Status = Status;
            this.LoadTreeList(MyLogin.Level, MyLogin.Code);
        }

        private void LoadTreeList(int Level, string Code)
        {
            object[] mCompanyName;
            //if (MyInfo.GetInfo() == "OK")
            //{
            //    this.m_CompanyName = MyInfo.Company;
            //}

            this.m_CompanyName = "Công ty ABC";
            this.dt = new DataTable();
            this.dt.Columns.Add("ID");
            this.dt.Columns.Add("Name");
            this.dt.Columns.Add("ParentID");
            this.dt.Columns.Add("Type");
            this.dt.Columns.Add("FactQuantity");
            this.dt.Columns.Add("Quantity");
            this.dt.Columns.Add("ImageIndex");
            if (Level == 0)
            {
                DataRowCollection rows = this.dt.Rows;
                mCompanyName = new object[] { "All", this.m_CompanyName, "", "Company", 0, 0, 0 };
                rows.Add(mCompanyName);
                this.m_CompanyFactQuantity = 0;
                this.m_CompanyQuantity = 0;
                this.AddSubsidiaryToDataTable(this.dt);
                this.AddBranchNullToDataTable(this.dt);
                this.AddDepartmentNullToDataTable(this.dt);
                this.dt.Rows[0]["Name"] = string.Concat(this.dt.Rows[0]["Name"].ToString(), this.StringQuantity(this.m_CompanyFactQuantity, this.m_CompanyQuantity));
                this.dt.Rows[0]["FactQuantity"] = this.m_CompanyFactQuantity;
                this.dt.Rows[0]["Quantity"] = this.m_CompanyQuantity;
            }
            else if (Level == 1)
            {
                HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
                hRMSUBSIDIARY.Get(Code);
                DataRowCollection dataRowCollection = this.dt.Rows;
                mCompanyName = new object[] { hRMSUBSIDIARY.SubsidiaryCode, string.Concat(hRMSUBSIDIARY.SubsidiaryName, this.StringQuantity(hRMSUBSIDIARY.FactQuantity, hRMSUBSIDIARY.Quantity)), "", "Subsidiary", hRMSUBSIDIARY.FactQuantity, hRMSUBSIDIARY.Quantity, 1 };
                dataRowCollection.Add(mCompanyName);
                this.AddBranchToDataTable(hRMSUBSIDIARY.SubsidiaryCode, this.dt);
                this.AddDepartmentBySubsidiaryNotNullToDataTable(hRMSUBSIDIARY.SubsidiaryCode, this.dt);
            }
            else if (Level == 2)
            {
                HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                hRMBRANCH.Get(Code);
                DataRowCollection rows1 = this.dt.Rows;
                mCompanyName = new object[] { hRMBRANCH.BranchCode, string.Concat(hRMBRANCH.BranchName, this.StringQuantity(hRMBRANCH.FactQuantity, hRMBRANCH.Quantity)), "", "Branch", hRMBRANCH.FactQuantity, hRMBRANCH.Quantity, 2 };
                rows1.Add(mCompanyName);
                this.AddDepartmentByBranchToDataTable(hRMBRANCH.BranchCode, this.dt);
            }
            else if (Level == 3)
            {
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                hRMDEPARTMENT.Get(Code);
                DataRowCollection dataRowCollection1 = this.dt.Rows;
                mCompanyName = new object[] { hRMDEPARTMENT.DepartmentCode, string.Concat(hRMDEPARTMENT.DepartmentName, this.StringQuantity(hRMDEPARTMENT.FactQuantity, hRMDEPARTMENT.Quantity)), "", "Department", hRMDEPARTMENT.FactQuantity, hRMDEPARTMENT.Quantity, 3 };
                dataRowCollection1.Add(mCompanyName);
                this.AddGroupToDataTable(hRMDEPARTMENT.DepartmentCode, this.dt);
            }
            else if (Level == 4)
            {
                HRM_GROUP hRMGROUP = new HRM_GROUP();
                hRMGROUP.Get(Code);
                DataRowCollection rows2 = this.dt.Rows;
                mCompanyName = new object[] { hRMGROUP.GroupCode, string.Concat(hRMGROUP.GroupName, this.StringQuantity(hRMGROUP.FactQuantity, hRMGROUP.Quantity)), "", "Group", hRMGROUP.FactQuantity, hRMGROUP.Quantity, 4 };
                rows2.Add(mCompanyName);
            }
            this.treeList1.DataSource = this.dt;
            this.treeList1.ExpandAll();
        }

        public void RaiseSelectedEventHander(Organization Item)
        {
            if (this.Selected != null)
            {
                this.Selected(this, Item);
            }
        }

        public void RaiseUpdatedEventHander()
        {
            if (this.Updated != null)
            {
                this.Updated(this);
            }
        }

        private void Reload()
        {
            if (!this.m_IsAll)
            {
                this.LoadData(this.m_Status);
            }
            else
            {
                this.LoadAllData();
            }
        }

        public void SelectNodeByLevelCode(int Level, string Code)
        {
          //  IDisposable disposable;
          //  IEnumerator enumerator = this.treeList1.Nodes.GetEnumerator();
          ////  TreeListNode current = new TreeListNode();

          //  try
          //  {
          //      while (enumerator.MoveNext())
          //      {
          //          TreeListNode current =   (TreeListNode)enumerator.Current;
          //        if ((int.Parse(current.GetValue("ImageIndex").ToString()) != Level ? true : !(current.GetValue("ID").ToString() == Code)))
          //          {
          //              IEnumerator enumerator1 = current.Nodes.GetEnumerator();
          //              try
          //              {
          //                  while (enumerator1.MoveNext())
          //                  {
          //                      TreeListNode treeListNode = (TreeListNode)enumerator1.Current;
          //                      if ((int.Parse(treeListNode.GetValue("ImageIndex").ToString()) != Level ? true : !(treeListNode.GetValue("ID").ToString() == Code)))
          //                      {
          //                          IEnumerator enumerator2 = treeListNode.Nodes.GetEnumerator();
          //                          try
          //                          {
          //                              while (enumerator2.MoveNext())
          //                              {
          //                                  TreeListNode current1 = (TreeListNode)enumerator2.Current;
          //                                  if ((int.Parse(current1.GetValue("ImageIndex").ToString()) != Level ? true : !(current1.GetValue("ID").ToString() == Code)))
          //                                  {
          //                                      IEnumerator enumerator3 = current1.Nodes.GetEnumerator();
          //                                      try
          //                                      {
          //                                          while (enumerator3.MoveNext())
          //                                          {
          //                                              TreeListNode treeListNode1 = (TreeListNode)enumerator3.Current;
          //                                              if ((int.Parse(treeListNode1.GetValue("ImageIndex").ToString()) != Level ? true : !(treeListNode1.GetValue("ID").ToString() == Code)))
          //                                              {
          //                                                  IEnumerator enumerator4 = treeListNode1.Nodes.GetEnumerator();
          //                                                  try
          //                                                  {
          //                                                      while (enumerator4.MoveNext())
          //                                                      {
          //                                                          TreeListNode current2 = (TreeListNode)enumerator4.Current;
          //                                                          if ((int.Parse(current2.GetValue("ImageIndex").ToString()) != Level ? false : current2.GetValue("ID").ToString() == Code))
          //                                                          {
          //                                                              this.treeList1.SetFocusedNode(current2);
          //                                                              return;
          //                                                          }
          //                                                      }
          //                                                  }
          //                                                  finally
          //                                                  {
          //                                                      disposable = enumerator4 as IDisposable;
          //                                                      if (disposable != null)
          //                                                      {
          //                                                          disposable.Dispose();
          //                                                      }
          //                                                  }
          //                                              }
          //                                              else
          //                                              {
          //                                                  this.treeList1.SetFocusedNode(treeListNode1);
          //                                                  return;
          //                                              }
          //                                          }
          //                                      }
          //                                      finally
          //                                      {
          //                                          disposable = enumerator3 as IDisposable;
          //                                          if (disposable != null)
          //                                          {
          //                                              disposable.Dispose();
          //                                          }
          //                                      }
          //                                  }
          //                                  else
          //                                  {
          //                                      this.treeList1.SetFocusedNode(current1);
          //                                      return;
          //                                  }
          //                              }
          //                          }
          //                          finally
          //                          {
          //                              disposable = enumerator2 as IDisposable;
          //                              if (disposable != null)
          //                              {
          //                                  disposable.Dispose();
          //                              }
          //                          }
          //                      }
          //                      else
          //                      {
          //                          this.treeList1.SetFocusedNode(treeListNode);
          //                          return;
          //                      }
          //                  }
          //              }
          //              finally
          //              {
          //                  disposable = enumerator1 as IDisposable;
          //                  if (disposable != null)
          //                  {
          //                      disposable.Dispose();
          //                  }
          //              }
          //          }
          //          else
          //          {
          //              this.treeList1.SetFocusedNode(current);
          //              return;
          //          }
          //      }
          //      return;
          //  }
          //  finally
          //  {
          //      disposable = enumerator as IDisposable;
          //      if (disposable != null)
          //      {
          //          disposable.Dispose();
          //      }
          //  }
        }

        public void SetFocusedNode(string code)
        {
            this.treeList1.SetFocusedNode(this.treeList1.FindNodeByFieldValue("ID", code));
        }

        private void ShowMenu(TreeListHitInfo hi, Point point)
        {
            DataRowView dataRecordByNode = (DataRowView)this.treeList1.GetDataRecordByNode(hi.Node);
            this.treeList1.SetFocusedNode(hi.Node);
            if (hi.Node != null)
            {
                if (dataRecordByNode["Type"].ToString() == "Company")
                {
                    this.ppCompany.ShowPopup(point);
                }
                else if (dataRecordByNode["Type"].ToString() == "Subsidiary")
                {
                    this.ppSubsidiary.ShowPopup(point);
                }
                else if (dataRecordByNode["Type"].ToString() == "Branch")
                {
                    this.ppBranch.ShowPopup(point);
                }
                else if (dataRecordByNode["Type"].ToString() == "Department")
                {
                    this.ppDepartment.ShowPopup(point);
                }
                else if (dataRecordByNode["Type"].ToString() == "Group")
                {
                    this.ppGroup.ShowPopup(point);
                }
                else if (dataRecordByNode["Type"].ToString() == "Employee")
                {
                    this.ppEmployee.ShowPopup(point);
                }
            }
        }

        private string StringQuantity(System.Data.DataRow DataRow)
        {
            string str = "";
            if (!(this.m_Status == 0 || this.m_Status == 1 ? false : this.m_Status != 3))
            {
                string[] strArrays = new string[] { " (", DataRow["FactQuantity"].ToString(), "/", DataRow["Quantity"].ToString(), ")" };
                str = string.Concat(strArrays);
            }
            else if (this.m_Status != 2)
            {
                int num = int.Parse(DataRow["Quantity"].ToString()) - int.Parse(DataRow["FactQuantity"].ToString());
                str = string.Concat(" (", num.ToString(), ")");
            }
            else
            {
                str = string.Concat(" (", DataRow["FactQuantity"].ToString(), ")");
            }
            return str;
        }

        private string StringQuantity(int FactQuantity, int Quantity)
        {
            string str = "";
            if (!(this.m_Status == 0 || this.m_Status == 1 ? false : this.m_Status != 3))
            {
                string[] strArrays = new string[] { " (", FactQuantity.ToString(), "/", Quantity.ToString(), ")" };
                str = string.Concat(strArrays);
            }
            else if (this.m_Status != 2)
            {
                int quantity = Quantity - FactQuantity;
                str = string.Concat(" (", quantity.ToString(), ")");
            }
            else
            {
                str = string.Concat(" (", FactQuantity.ToString(), ")");
            }
            return str;
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            DataRowView dataRecordByNode = (DataRowView)this.treeList1.GetDataRecordByNode(e.Node);
            this.cls = new Organization();
            if (e.Node != null)
            {
                if (dataRecordByNode["Type"].ToString() == "Company")
                {
                    this.cls.Level = 0;
                    this.cls.Code = "";
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Subsidiary")
                {
                    this.cls.SubsidiaryCode = dataRecordByNode["ID"].ToString();
                    this.cls.Code = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 1;
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Branch")
                {
                    this.cls.BranchCode = dataRecordByNode["ID"].ToString();
                    this.cls.Code = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 2;
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Department")
                {
                    this.cls.DepartmentCode = dataRecordByNode["ID"].ToString();
                    this.cls.Code = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 3;
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Group")
                {
                    this.cls.GroupCode = dataRecordByNode["ID"].ToString();
                    this.cls.Code = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 4;
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Employee")
                {
                    this.cls.EmployeeCode = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 5;
                    this.RaiseSelectedEventHander(this.cls);
                }
            }
            this.treeList1.SetFocusedNode(e.Node);
        }

        private void treeList1_GetSelectImage(object sender, GetSelectImageEventArgs e)
        {
            DataRowView dataRecordByNode = (DataRowView)this.treeList1.GetDataRecordByNode(e.Node);
            e.NodeImageIndex = int.Parse(dataRecordByNode["ImageIndex"].ToString());
        }

        public void UpdateNodeByLevelCode(int Level, string Code)
        {
        }

     
      

        public event xucOrganization.SelectedEventHander Selected;

        public event xucOrganization.UpdatedEventHander Updated;

        public delegate void SelectedEventHander(object sender, Organization Item);

        public delegate void UpdatedEventHander(object sender);

        private void xucOrganization_Load_1(object sender, EventArgs e)
        {
          Reload();
        }

        private void treeList1_FocusedNodeChanged_1(object sender, FocusedNodeChangedEventArgs e)
        {
            DataRowView dataRecordByNode = (DataRowView)this.treeList1.GetDataRecordByNode(e.Node);
            this.cls = new Organization();
            if (e.Node != null)
            {
                if (dataRecordByNode["Type"].ToString() == "Company")
                {
                    this.cls.Level = 0;
                    this.cls.Code = "";
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Subsidiary")
                {
                    this.cls.SubsidiaryCode = dataRecordByNode["ID"].ToString();
                    this.cls.Code = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 1;
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Branch")
                {
                    this.cls.BranchCode = dataRecordByNode["ID"].ToString();
                    this.cls.Code = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 2;
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Department")
                {
                    this.cls.DepartmentCode = dataRecordByNode["ID"].ToString();
                    this.cls.Code = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 3;
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Group")
                {
                    this.cls.GroupCode = dataRecordByNode["ID"].ToString();
                    this.cls.Code = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 4;
                    this.RaiseSelectedEventHander(this.cls);
                }
                else if (dataRecordByNode["Type"].ToString() == "Employee")
                {
                    this.cls.EmployeeCode = dataRecordByNode["ID"].ToString();
                    this.cls.Level = 5;
                    this.RaiseSelectedEventHander(this.cls);
                }
            }
            this.treeList1.SetFocusedNode(e.Node);
        }

        private void treeList1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void treeList1_GetSelectImage_1(object sender, GetSelectImageEventArgs e)
        {
            DataRowView dataRecordByNode = (DataRowView)this.treeList1.GetDataRecordByNode(e.Node);
            e.NodeImageIndex = int.Parse(dataRecordByNode["ImageIndex"].ToString());
        }

        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            this.m_Point = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                this.ShowMenu(this.treeList1.CalcHitInfo(this.m_Point), this.treeList1.PointToScreen(this.m_Point));
            }
        }
    }
}
