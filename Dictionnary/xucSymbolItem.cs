using DevExpress.Utils;
using DevExpress.XtraEditors;
using CHBK2014_N9.Common;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace CHBK2014_N9.Dictionnary
{
    public partial class xucSymbolItem : xucBase
    {

        private string m_SymbolCode;

        private string m_SymbolName;
        public string SymbolCode
        {
            get
            {
                return this.m_SymbolCode;
            }
            set
            {
                this.m_SymbolCode = value;
                this.Init();
            }
        }

        public string SymbolName
        {
            get
            {
                return this.m_SymbolName;
            }
            set
            {
                this.m_SymbolName = value;
                this.Init();
            }
        }

        public xucSymbolItem()
        {
            this.InitializeComponent();
            this.m_SymbolCode = "";
            this.m_SymbolName = "";
        }

       

        private void Init()
        {
            this.lbSymbolCode.Text = this.m_SymbolCode;
            this.lbSymbolName.Text = this.m_SymbolName;
        }
    }
}
