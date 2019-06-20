using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHBK2014_N9.Common
{
    public class RibbonChangedEventArgs : EventArgs
    {
        private MenuButton m_ribbon;

        public MenuButton Ribbon
        {
            get
            {
                return this.m_ribbon;
            }
        }

        public RibbonChangedEventArgs(MenuButton mRibbon)
        {
            this.m_ribbon = mRibbon;
        }
    }
}
