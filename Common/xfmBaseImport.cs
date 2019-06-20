using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraWizard;
using CHBK2014_N9.Data.Helper;
//using CHBK2014_N9.Utils.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Common
{
    public partial class xfmBaseImport : XtraForm
    {

        public string[] ParamName;

        public List<int> ParamNameIndex;

        public List<string> FieldName;

        private int m_Success = 0;

        private int m_Error = 0;

        private bool m_IsFieldFull = false;

        public xfmBaseImport()
        {
            InitializeComponent();
            this.CreateNullMessage();
            this.lbLinkFile.Text = string.Concat(Application.StartupPath, "\\ImportFile\\*.xls");
            xfmBaseImport _xfmBaseImport = this;
            _xfmBaseImport.Success = (xfmBaseImport.SuccessEventHander)Delegate.Combine(_xfmBaseImport.Success, new xfmBaseImport.SuccessEventHander(this.xfmImport_Success));

        }


        public void CreateNullMessage()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Message"));
            dataTable.Columns.Add(new DataColumn("Status"));
            this.gcMessage.DataSource = dataTable;
        }


        public void ErrorRow(string Error)
        {
            this.m_Error++;
            this.gbMessage.AddNewRow();
            this.gbMessage.SetFocusedRowCellValue(this.colMessage, Error);
            this.gbMessage.SetFocusedRowCellValue(this.colStatus, "1");
        }

        protected virtual void FillField()
        {
        }


        private void lbFix_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(this.txtFilePath.Text);
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public void FillField(List<string> FieldName)
        {
            string text = this.cboSheet.Text;
            SqlHelper sqlHelper = new SqlHelper();
            DataTable dataTable = new DataTable();
            List<int> nums = new List<int>();
            DataTable dataTable1 =  Perfect.Utils.Excel.ExcelImport.ReadExcelContents(this.txtFilePath.Text, text);
            if (dataTable1 != null)
            {
                string[] str = new string[dataTable1.Columns.Count];
                this.repSelectField.Items.Clear();
                int num = 0;
                try
                {
                    foreach (DataColumn column in dataTable1.Columns)
                    {
                        if (!(dataTable1.Rows[0][column.Caption].ToString() != ""))
                        {
                            continue;
                        }
                        str[num] = dataTable1.Rows[0][column.Caption].ToString();
                        this.repSelectField.Items.Add(dataTable1.Rows[0][column.Caption].ToString());
                        num++;
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể đọc sheet này! Nó không giống cấu trúc mặc định của chương trình!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                foreach (string fieldName in FieldName)
                {
                    if (fieldName != "")
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Concat("select N'", fieldName, "' as [FieldName], '' as [SelectField]"), sqlHelper.ConnectionString);
                        sqlDataAdapter.Fill(dataTable);
                    }
                }
                this.gcList.DataSource = dataTable;
                for (int i = 0; i < dataTable1.Columns.Count; i++)
                {
                    this.gbList.SetRowCellValue(i, this.colSelectField, str[i]);
                    num = i;
                }
                if (FieldName.Count <= num + 1)
                {
                    this.m_IsFieldFull = true;
                }
            }
        }

        public void FillSheet()
        {
            DataTable dataTable =   Perfect.Utils.Excel. ExcelImport.ReadSheets(this.txtFilePath.Text);
            if (dataTable != null)
            {
                this.cboSheet.Properties.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    this.cboSheet.Properties.Items.Add(row["TABLE_NAME"].ToString());
                }
                if (dataTable.Rows.Count > 0)
                {
                    this.cboSheet.SelectedIndex = 0;
                }
            }
        }

        private void Import()
        {
            DataTable dataTable =   Perfect.Utils.Excel. ExcelImport.ReadExcelContents(this.txtFilePath.Text, this.cboSheet.Text);
            if (dataTable != null)
            {
                this.ParamNameIndex = new List<int>();
                int num = 0;
                while (num < this.gbList.RowCount)
                {
                    DataRow dataRow = this.gbList.GetDataRow(num);
                    if (!(dataRow[1].ToString() != ""))
                    {
                        this.ParamNameIndex.Clear();
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < this.repSelectField.Items.Count; i++)
                        {
                            if (dataRow[1].ToString() == this.repSelectField.Items[i].ToString())
                            {
                                this.ParamNameIndex.Add(i);
                            }
                        }
                        num++;
                    }
                }
                this.Import(dataTable);
            }
        }

        protected virtual void Import(DataTable ExcelContentTable)
        {
        }

        private void wcImport_SelectedPageChanged(object sender, WizardPageChangedEventArgs e)
        {
            this.lcSheet.Visible = false;
            if ((e.Page != this.wpSelectField ? false : e.Direction == Direction.Forward))
            {
                this.lcSheet.Visible = true;
                if (this.txtFilePath.Text == "")
                {
                    this.wcImport.SelectedPage = this.wpSelectFile;
                }
            }
            if ((e.Page != this.wpProcessPage ? false : e.Direction == Direction.Forward))
            {
                if (!this.m_IsFieldFull)
                {
                    this.wcImport.SelectedPage = this.wpSelectField;
                }
            }
            if ((e.Page != this.wpProcessPage ? false : e.Direction == Direction.Backward))
            {
                this.wcImport.SelectedPage = this.wpSelectField;
            }
        }

        private void xfmImport_Success(object sender)
        {
            this.wcImport.SelectedPage = this.wpFinish;
            LabelControl labelControl = this.lbMessage;
            object[] mSuccess = new object[] { "Thành công: <color=red>", this.m_Success, "</color> mẫu tin. Lỗi: <color=red>", this.m_Error, "</color> mẫu tin." };
            labelControl.Text = string.Concat(mSuccess);
            if (this.m_Error > 0)
            {
                this.lbFix.Visible = true;
            }
        }


        private void xfmImport_Load(object sender, EventArgs e)
        {
        }
        public event xfmBaseImport.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender);

        private void wcImport_NextClick(object sender, WizardCommandButtonClickEventArgs e)
        {
            this.m_Success = 0;
            this.m_Error = 0;
            if (e.Page == this.wpSelectFile)
            {
                if (!(this.txtFilePath.Text != ""))
                {
                    XtraMessageBox.Show("Vui lòng chọn đường dẫn đến tập tin dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    this.FillSheet();
                }
            }
            else if (e.Page == this.wpSelectField)
            {
                if (this.m_IsFieldFull)
                {
                    this.wcImport.SelectedPage = this.wpProcessPage;
                    this.Refresh();
                    this.CreateNullMessage();
                    this.Import();
                    this.RaiseSuccessEventHander();
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn đầy đủ thông tin cho các trường!", "Thông Báo");
                }
            }



        }


        public void ProgressRow(string Progress)
        {
            this.lbDataRow.Text = Progress;
            this.lbDataRow.Refresh();
            this.mqProgress.Refresh();
        }

        private void RaiseSuccessEventHander()
        {
            if (this.Success != null)
            {
                this.Success(this);
            }
        }

        public void SuccessRow()
        {
            this.m_Success++;
        }

        public void SuccessRow(string Information)
        {
            this.m_Success++;
            this.gbMessage.AddNewRow();
            this.gbMessage.SetFocusedRowCellValue(this.colMessage, Information);
            this.gbMessage.SetFocusedRowCellValue(this.colStatus, "0");
        }

        private void txtFilePath_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != ButtonPredefines.Glyph)
            {
                this.txtFilePath.Text = this.lbLinkFile.Text;
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "Excel File(*.xls,*.xlsx)|*.xls;*.xlsx",
                    FilterIndex = 0
                };
                OpenFileDialog openFileDialog1 = openFileDialog;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.txtFilePath.Text = openFileDialog1.FileName;
                }
            }
        }

        private void wpFinish_Click(object sender, EventArgs e)
        {

        }

        private void lbLinkFile_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(this.lbLinkFile.Text);
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillField();
        }
    }
}
