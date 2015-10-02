using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MobileStoreOnline.App_Code.DTO;
using System.Data.SqlClient;

namespace MobileStoreOnline.App_Code.DAL
{
    public class KhachHangDAL
    {
        public KhachHangDAL()
        {

        }
        DBLib db = new DBLib();

        public SqlDataReader checkKhachHang(string Email)
        {
            try
            {
                db.AddParameter("@Email", Email);
                return db.ExecuteReader("sp_CheckKhachHang", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object insertKhachHang(KhachHang dto)
        {
            try
            {
                db.AddParameter("@HoTen", dto.HoTen);
                db.AddParameter("@NgaySinh", dto.NgaySinh);
                db.AddParameter("@GioiTinh", dto.GioiTinh);
                db.AddParameter("@CMND", dto.CMND);
                db.AddParameter("@DiaChi", dto.DiaChi);
                db.AddParameter("@DT", dto.DT);
                db.AddParameter("@Email", dto.Email);
                db.AddParameter("@PassWord", dto.PassWord);
                return db.ExecuteScalar("sp_InsertKhachHang", CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}