using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CHBK2014_N9.HumanResource.Core
{
   internal class MsgResc
    {


        private static ResourceManager resourceMan;

        private static CultureInfo resourceCulture;

        internal static Bitmap _001_38
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("001_38", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap billing__2_
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("billing (2)", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap check
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("check", MsgResc.resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return MsgResc.resourceCulture;
            }
            set
            {
                MsgResc.resourceCulture = value;
            }
        }

        internal static string Delete
        {
            get
            {
                return MsgResc.ResourceManager.GetString("Delete", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap edit
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("edit", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap facebook
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("facebook", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap fail
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("fail", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap filter
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("filter", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap hinh9
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("hinh9", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap loading_s
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("loading_s", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap lock_open__1_
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("lock_open (1)", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap orca
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("orca", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap page_white_g
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("page_white_g", MsgResc.resourceCulture);
            }
        }

        internal static string Permision
        {
            get
            {
                return MsgResc.ResourceManager.GetString("Permision", MsgResc.resourceCulture);
            }
        }

        internal static string Print
        {
            get
            {
                return MsgResc.ResourceManager.GetString("Print", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap print16x16
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("print16x16", MsgResc.resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(MsgResc.resourceMan, null))
                {
                    MsgResc.resourceMan = new ResourceManager("Perfect.HumanResource.Core.MsgResc", typeof(MsgResc).Assembly);
                }
                return MsgResc.resourceMan;
            }
        }

        internal static string Save
        {
            get
            {
                return MsgResc.ResourceManager.GetString("Save", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap sign_plus
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("sign_plus", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap sign_plus1
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("sign_plus1", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap skype
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("skype", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap sucess
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("sucess", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap U160
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("U160", MsgResc.resourceCulture);
            }
        }

        internal static Bitmap yahoo_protocol
        {
            get
            {
                return (Bitmap)MsgResc.ResourceManager.GetObject("yahoo_protocol", MsgResc.resourceCulture);
            }
        }

        internal MsgResc()
        {
        }
    }
}
