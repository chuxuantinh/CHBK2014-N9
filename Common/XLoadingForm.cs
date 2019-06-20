using DevExpress.Utils;
using DevExpress.XtraEditors;
//using CHBK2014_N9.Common.Properties;
using CHBK2014_N9.Utils;
//using CHBK2014_N9.Utils.App;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CHBK2014_N9.Common
{
    public partial class XLoadingForm : XtraForm
    {

        private const int CS_DROPSHADOW = 131072;
        //public XLoadingForm()
        //{
        //    InitializeComponent();



        //}


        private bool _die = false;

        private bool _autoClose = false;

        private Form _form;

        public bool AutoClose
        {
            get
            {
                return this._autoClose;
            }
            set
            {
                this._autoClose = value;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                CreateParams classStyle = createParams;
                classStyle.ClassStyle = classStyle.ClassStyle | 131072;
                return createParams;
            }
        }

        public XLoadingForm(UserControl parent)
        {
            this.InitializeComponent();
        }

        public XLoadingForm()
        {
            this.InitializeComponent();
            FileInfo fileInfo = new FileInfo(string.Concat(Application.StartupPath, "\\CHBK2014-N9.HumanResource.exe"));
           // LabelControl labelControl = this.lblVersion;
          //  string[] str = new string[] { MultiLanguages.GetString("tbl_Loading", "Version", "Phiên bản"), ": ", MyAssembly.AssemblyVersion, " (Dùng chung) -  Biên dịch ngày ", null };
         //   str[4] = fileInfo.LastWriteTime.ToShortDateString();
          //  labelControl.Text = string.Concat(str);
        }

        public XLoadingForm(Form parent)
        {
            this.InitializeComponent();
            this._form = parent;
        }



        public void SetProgressValue(int position)
        {
            if (!this._die)
            {
                if (!base.Visible)
                {
                    if (this._form == null)
                    {
                        base.Show();
                    }
                    else
                    {
                        base.Show(this._form);
                    }
                }
                this.lblTitle.Text = string.Concat(( "Đang tải..."), position.ToString(), "%");
                base.Update();
            }
        }

        public void SetProgressValue(int position, string message)
        {
            if (!this._die)
            {
                if (!base.Visible)
                {
                    if (this._form == null)
                    {
                        base.Show();
                    }
                    else
                    {
                        base.Show(this._form);
                    }
                }
                this.lblTitle.Text = string.Concat(("Đang tải..."), position.ToString(), "%");
                base.Update();
            }
        }
    }
}
