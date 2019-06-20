using DevExpress.XtraBars;
using System;

namespace CHBK2014_N9.Common
{
 public   class ItemCommand
    {

        private string m_caption = "";

        private bool m_enable = false;

        private BarItemVisibility m_visibility = BarItemVisibility.Never;

        public string Caption
        {
            get
            {
                return this.m_caption;
            }
            set
            {
                this.m_caption = value;
            }
        }

        public bool Enable
        {
            get
            {
                return this.m_enable;
            }
            set
            {
                this.m_enable = value;
            }
        }

        public BarItemVisibility Visibility
        {
            get
            {
                return this.m_visibility;
            }
            set
            {
                this.m_visibility = value;
            }
        }

        public ItemCommand()
        {
        }
    }
}
