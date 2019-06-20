using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace CHBK2014_N9.ATT.DAL.Common
{
  internal  class Excel
    {
        private OleDbCommand _cmd;
        private string _cn;
        private static OleDbConnection _con;
        private OleDbDataAdapter _da;
        private string _sql;
        private DataTable _table;
        private string pathFile;

        public Excel(string pathFile)
        {
            this.pathFile = pathFile;
        }

        public OleDbConnection Connect()
        {
            if (this.pathFile.Contains("xlsx"))
            {
                this._cn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.pathFile + ";Extended Properties=Excel 12.0;";
            }
            else
            {
                this._cn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + this.pathFile + ";Extended Properties=Excel 8.0;";
            }
            _con = new OleDbConnection(this._cn);
            _con.Open();
            return _con;
        }

        public DataTable GetDataTable(string sql)
        {
            this._table = new DataTable();
            try
            {
                _con = this.Connect();
                this._da = new OleDbDataAdapter(sql, _con);
                this._da.Fill(this._table);
                _con.Close();
                return this._table;
            }
            catch (OleDbException)
            {
                _con.Close();
                return this._table;
            }
        }
    }
}
