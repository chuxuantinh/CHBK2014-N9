using System;


namespace CHBK2014_N9.Common
{
   public class SaveChangedEventArgs: EventArgs
    {

        private bool m_notsave;

        public bool NotSave
        {
            get
            {
                return this.m_notsave;
            }
        }

        public SaveChangedEventArgs()
        {
        }
    }

   
}
