using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTreeList;
using CHBK2014_N9.Common;
//using CHBK2014_N9.Common.Properties;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
namespace CHBK2014_N9.Common.Report
{
    public partial class xfmReport : RibbonForm
    {
        public xfmReport()
        {
            InitializeComponent();
        }

        public xfmReport(string Title)
        {
            this.InitializeComponent();
            this.Text = string.Concat(Title, " (Báo Cáo - QLNS)");
        }


        public void SetTitle(string Title)
        {
            this.Text = string.Concat(Title, " (Báo Cáo - QLNS)");
        }

        public void ShowPrintPreview(XtraReport xtraReport)
        {
            this.m_xtraReport = xtraReport;
            this.printControl1.PrintingSystem = xtraReport.PrintingSystem;
            xtraReport.CreateDocument();
            base.Show();
        }

        public void ShowPrintPreview(GridControl gridControl)
        {
            PrintingSystem printingSystem = new PrintingSystem();
            PrintableComponentLink printableComponentLink = new PrintableComponentLink()
            {
                Component = gridControl
            };
            printingSystem.Links.AddRange(new object[] { printableComponentLink });
            this.printControl1.PrintingSystem = printableComponentLink.PrintingSystem;
            printableComponentLink.CreateDocument();
            base.Show();
        }

        public void ShowPrintPreview(TreeList treeList)
        {
            PrintingSystem printingSystem = new PrintingSystem();
            PrintableComponentLink printableComponentLink = new PrintableComponentLink()
            {
                Component = treeList
            };
            printingSystem.Links.AddRange(new object[] { printableComponentLink });
            this.printControl1.PrintingSystem = printableComponentLink.PrintingSystem;
            printableComponentLink.CreateDocument();
            base.Show();
        }

        public void ShowPrintPreview(ChartControl chartControl)
        {
            PrintingSystem printingSystem = new PrintingSystem();
            PrintableComponentLink printableComponentLink = new PrintableComponentLink()
            {
                Component = chartControl
            };
            printingSystem.Links.AddRange(new object[] { printableComponentLink });
            this.printControl1.PrintingSystem = printableComponentLink.PrintingSystem;
            printableComponentLink.CreateDocument();
            base.Show();
        }

        private void bbiDesignView_ItemClick(object sender, ItemClickEventArgs e)
        {
          // (new xfmReportDesigner(this.m_xtraReport)).Show();
        }
    }
}
