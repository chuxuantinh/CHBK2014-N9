using System;


namespace CHBK2014_N9.Common.Class
{
   
        public class RowClickEventArgs
        {
            private int _mRowIndex;

            private int _mColumnIndex;

            private string _mFieldName;

            public int ColumnIndex
            {
                get
                {
                    return this._mColumnIndex;
                }
                set
                {
                    this._mColumnIndex = value;
                }
            }

            public string FieldName
            {
                get
                {
                    return this._mFieldName;
                }
                set
                {
                    this._mFieldName = value;
                }
            }

            public int RowIndex
            {
                get
                {
                    return this._mRowIndex;
                }
                set
                {
                    this._mRowIndex = value;
                }
            }

            public RowClickEventArgs(int rowIndex, int columnIndex, string fieldName)
            {
                this._mRowIndex = rowIndex;
                this._mColumnIndex = columnIndex;
                this._mFieldName = fieldName;
            }

            public RowClickEventArgs(int rowIndex, int columnIndex)
            {
                this._mRowIndex = rowIndex;
                this._mColumnIndex = columnIndex;
                this._mFieldName = "";
            }

            public RowClickEventArgs(int rowIndex, string fieldName)
            {
                this._mRowIndex = rowIndex;
                this._mColumnIndex = -1;
                this._mFieldName = fieldName;
            }

            public RowClickEventArgs()
            {
                this._mRowIndex = -1;
                this._mColumnIndex = -1;
                this._mFieldName = "";
            }

            public void Reset()
            {
                this._mRowIndex = -1;
                this._mColumnIndex = -1;
                this._mFieldName = "";
            }

            public void Set(int RowIndex, int ColumnIndex, string FieldName)
            {
                this._mRowIndex = RowIndex;
                this._mColumnIndex = ColumnIndex;
                this._mFieldName = FieldName;
            }
        }
    
    
}
