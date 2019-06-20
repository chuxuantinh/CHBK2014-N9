using System;
using System.Data.Common;

namespace CHBK2014_N9.Data.Helper
{
   public class SqlHelperException: DbException
    {

        private readonly string _message = "";

        private readonly int _numberError = -1;

        private int _lineError = -1;

        public int LineError
        {
            get
            {
                return this._lineError;
            }
        }

        public override string Message
        {
            get
            {
                return this._message;
            }
        }

        public int Number
        {
            get
            {
                return this._numberError;
            }
        }

        public SqlHelperException(string message)
        {
            this._message = message;
            this._numberError = -1;
        }

        public SqlHelperException(string message, int number)
        {
            this._message = message;
            this._numberError = number;
        }

        public SqlHelperException(string message, int number, int lineError)
        {
            this._message = message;
            this._numberError = number;
            this._lineError = lineError;
        }
    }
}
