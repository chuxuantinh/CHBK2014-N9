using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CHBK2014_N9
{
    public partial class FrmLog : DevExpress.XtraEditors.XtraForm
    {
        public FrmLog()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        string Grid_tem =Application.StartupPath + @"\Templates\Templates_Log.xml";

        private void FrmLog_Load(object sender, EventArgs e)
        {
            if (File.Exists(Grid_tem))
            {

                gridView1.RestoreLayoutFromXml(Grid_tem);

                Get_LogSystem();
            }
        }

        private void Get_LogSystem()
        {


            gridControl1.DataSource = Class.S_Log.Log_HeThong();
            gridView1.ExpandAllGroups();
        }

    }
}
