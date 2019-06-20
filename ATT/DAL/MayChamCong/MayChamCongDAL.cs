using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.MayChamCong;

namespace CHBK2014_N9.ATT.DAL.MayChamCong
{
  internal  class MayChamCongDAL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void CapNhatActiveKey(MayChamCongDTO _mayChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC),
                new SqlParameter("@Serial", _mayChamCongDTO.Serial),
                new SqlParameter("@SoDangKy", _mayChamCongDTO.SoDangKy)
            };
            base.Procedure("MAYCHAMCONG_activeKey", sqlParams);
        }

        public void DELELEMAYCHAMCONG(MayChamCongDTO _mayChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC)
            };
            base.Procedure("MAYCHAMCONG_delete", sqlParams);
        }

        public DataTable LOADMAYCHAMCONG()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("MAYCHAMCONG_getall", sqlParams);
        }

        public DataTable MayChamCong_getAllByTenMCC(MayChamCongDTO _mayChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@TenMCC", _mayChamCongDTO.TenMCC)
            };
            return base.executeNonQuerya("MayChamCong_getAllByTenMCC", sqlParams);
        }

        public DataTable MayChamCong_getLoad(MayChamCongDTO _mayChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC)
            };
            return base.executeNonQuerya("MayChamCong_get", sqlParams);
        }

        public ArrayList SelectAllMCC()

        {

            SqlDataReader reader = dbHelper.ExecuteQuery("MAYCHAMCONG_getall");
            ArrayList list = new ArrayList();

            try
            {


            
                    while (reader.Read())
                    {
                    string a0;
                    string a1;
                    int a2;
                    string a3;
                    if (reader[0]!= DBNull.Value && string.IsNullOrEmpty(reader[0].ToString().Trim()))
                        {
                         a0 = reader.GetString(0);
                        }
                    else
                    {
                        a0 = "";
                            
                     }

                    if (reader[1] != DBNull.Value && string.IsNullOrEmpty(reader[1].ToString().Trim()))
                    {
                        a1 = reader.GetString(1);
                    }
                    else
                    {
                        a1= "";

                    }

                    if (reader[2] != DBNull.Value )
                    {
                        a2 = reader.GetInt32(2);
                    }
                    else
                    {
                      //

                    }

                    if (reader[3] != DBNull.Value && string.IsNullOrEmpty(reader[3].ToString().Trim()))
                    {
                        a3 = reader.GetString(3);
                    }
                    else
                    {
                        a3 = "";

                    }

                    string a4;
                    if (reader[4] != DBNull.Value && string.IsNullOrEmpty(reader[4].ToString().Trim()))
                    {
                        a4 = reader.GetString(4);
                    }
                    else
                    {
                        a4 = "";

                    }

                    int a5;
                    if (reader[5] != DBNull.Value)
                    {
                        a5 = reader.GetInt32(5);
                    }
                    else
                    {
                        //

                    }
                    int a6;
                    if (reader[6] != DBNull.Value)
                    {
                        a6 = reader.GetInt32(6);
                    }
                    else
                    {
                        //

                    }

                    string a7;
                    if (reader[7] != DBNull.Value && string.IsNullOrEmpty(reader[7].ToString().Trim()))
                    {
                        a7 = reader.GetString(7);
                    }
                    else
                    {
                        a7 = "";

                    }

                    string a8;
                    if (reader[8] != DBNull.Value && string.IsNullOrEmpty(reader[8].ToString().Trim()))
                    {
                        a8 = reader.GetString(8);
                    }
                    else
                    {
                        a8 = "";

                    }

                    DateTime a9;
                    if (reader[9] != DBNull.Value && string.IsNullOrEmpty(reader[9].ToString().Trim()))
                    {
                        a9 = reader.GetDateTime(9);
                    }
                    else
                    {
                       //
                    }

                    string a11;
                    if (reader[11] != DBNull.Value && string.IsNullOrEmpty(reader[11].ToString().Trim()))
                    {
                        a11 = reader.GetString(11);
                    }
                    else
                    {
                        a11 = "";

                    }

                    string a12;
                    if (reader[12] != DBNull.Value && string.IsNullOrEmpty(reader[12].ToString().Trim()))
                    {
                        a12 = reader.GetString(12);
                    }
                    else
                    {
                        a12 = "";

                    }




                    MayChamCongDTO gdto = new MayChamCongDTO(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetString(7), reader.GetString(8), reader.GetDateTime(9), reader.GetBoolean(10), reader.GetString(11), reader.GetString(12), reader.GetBoolean(13), reader.GetInt32(14));
                        list.Add(gdto);
                    }

               
            }
           finally
            {

                if (reader != null)
               

                reader.Close();
               
            }
                       
                                         

               
                return list;

          
         

           

        }

        public void SuaMayChamCong(MayChamCongDTO _mayChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC),
                new SqlParameter("@TenMCC", _mayChamCongDTO.TenMCC),
                new SqlParameter("@IDMCC", _mayChamCongDTO.IDMCC),
                new SqlParameter("@KieuKetNoi", _mayChamCongDTO.KieuKetNoi),
                new SqlParameter("@DiaChiIP", _mayChamCongDTO.DiaChiIP),
                new SqlParameter("@Port", _mayChamCongDTO.Port),
                new SqlParameter("@CongCOM", _mayChamCongDTO.CongCOM),
                new SqlParameter("@TocDoTruyen", _mayChamCongDTO.TocDoTruyen),
                new SqlParameter("@DiaChiWeb", _mayChamCongDTO.DiaChiWeb),
                new SqlParameter("@SuDungWeb", _mayChamCongDTO.SuDungWeb),
                new SqlParameter("@TrangThai", _mayChamCongDTO.TrangThai),
                new SqlParameter("@TrangThaiMay", _mayChamCongDTO.TrangThaiMay)
            };
            base.Procedure("MAYCHAMCONG_update", sqlParams);
        }

        public void ThemMayChamCong(MayChamCongDTO _mayChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC),
                new SqlParameter("@TenMCC", _mayChamCongDTO.TenMCC),
                new SqlParameter("@IDMCC", _mayChamCongDTO.IDMCC),
                new SqlParameter("@KieuKetNoi", _mayChamCongDTO.KieuKetNoi),
                new SqlParameter("@DiaChiIP", _mayChamCongDTO.DiaChiIP),
                new SqlParameter("@Port", _mayChamCongDTO.Port),
                new SqlParameter("@CongCOM", _mayChamCongDTO.CongCOM),
                new SqlParameter("@TocDoTruyen", _mayChamCongDTO.TocDoTruyen),
                new SqlParameter("@DiaChiWeb", _mayChamCongDTO.DiaChiWeb),
                new SqlParameter("@NgayDangKyTenMien", _mayChamCongDTO.NgayDangKyTenMien),
                new SqlParameter("@SuDungWeb", _mayChamCongDTO.SuDungWeb),
                new SqlParameter("@Serial", _mayChamCongDTO.Serial),
                new SqlParameter("@SoDangKy", _mayChamCongDTO.SoDangKy),
                new SqlParameter("@TrangThai", _mayChamCongDTO.TrangThai),
                new SqlParameter("@TrangThaiMay", _mayChamCongDTO.TrangThaiMay)
            };
            base.Procedure("MAYCHAMCONG_add", sqlParams);
        }
    }
}
