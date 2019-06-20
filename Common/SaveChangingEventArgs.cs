using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHBK2014_N9.Common
{
 public   class SaveChangingEventArgs: EventArgs
    {

        private string m_caption;

        private int m_percent;

        public int Percent
        {
            get
            {
                return this.m_percent;
            }
        }

        public string Status
        {
            get
            {
                return this.m_caption;
            }
        }

        public SaveChangingEventArgs()
        {
        }
    }
}
