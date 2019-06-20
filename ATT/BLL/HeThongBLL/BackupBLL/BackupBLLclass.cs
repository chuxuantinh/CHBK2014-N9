using CHBK2014_N9.ATT.DAL.HeThongDAL.BackupDAL;
using CHBK2014_N9.ATT.DTO.HethongDTO.BackupDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.HeThongBLL.BackupBLL
{
  internal  class BackupBLLclass
    {

        private BackupDALclass _backupDALclass = new BackupDALclass();

        public DataTable TuDongSaoLuuGet(BackupDTOclass _backupDTOclass)
        {
            return this._backupDALclass.TuDongSaoLuu_get(_backupDTOclass);
        }

        public DataTable TuDongSaoLuuGetAll(BackupDTOclass _backupDTOclass)
        {
            return this._backupDALclass.TuDongSaoLuu_getAll(_backupDTOclass);
        }

        public void TuDongSaoLuuInsert(BackupDTOclass _backupDTOclass)
        {
            this._backupDALclass.TuDongSaoLuu_Insert(_backupDTOclass);
        }

        public void TuDongSaoLuuUpdate(BackupDTOclass _backupDTOclass)
        {
            this._backupDALclass.TuDongSaoLuu_Update(_backupDTOclass);
        }
    }
}
