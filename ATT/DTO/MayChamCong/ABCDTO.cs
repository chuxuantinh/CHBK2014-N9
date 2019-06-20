using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.MayChamCong
{
  internal  class ABCDTO
    {
        
            // Fields
            private int _DeviceID;
            private string _MaNV;
            private int _Status;
            private DateTime _ThoiGian;
            private int _Verified;
            private int _Workcode;

            // Properties
            public int DeviceID
            {
                get
                {
                    return this._DeviceID;
                }
                set
                {
                    this._DeviceID = value;
                }
            }

            public string MaNV
            {
                get
                {
                    return this._MaNV;
                }
                set
                {
                    this._MaNV = value;
                }
            }

            public int Status
            {
                get
                {
                    return this._Status;
                }
                set
                {
                    this._Status = value;
                }
            }

            public DateTime ThoiGian
            {
                get
                {
                    return this._ThoiGian;
                }
                set
                {
                    this._ThoiGian = value;
                }
            }

            public int Verified
            {
                get
                {
                    return this._Verified;
                }
                set
                {
                    this._Verified = value;
                }
            }

            public int Workcode
            {
                get
                {
                    return this._Workcode;
                }
                set
                {
                    this._Workcode = value;
                }
            }
        }


    
}
