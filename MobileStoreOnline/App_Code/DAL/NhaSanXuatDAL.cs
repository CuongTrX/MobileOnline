using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MobileStoreOnline.App_Code.DAL
{
    public class NhaSanXuatDAL
    {
        DBLib db;
        public NhaSanXuatDAL()
        {

        }
        public bool insertNSX(string TenSX)
        {
            db = new DBLib();
            try
            {
                db.AddParameter("@TenSX", TenSX);
                return db.ExecuteNonQuery("sp_InsertNSX", CommandType.StoredProcedure) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable getNhaSanXuat()
        {
            db = new DBLib();
            try
            {
                return db.FillDataTable("sp_SelectNhaSanXuat", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool updateNSX(DTO.NhaSanXuat dto)
        {
            db = new DBLib();
            try
            {
                db.AddParameter("@MaSX", dto.MaSX);
                db.AddParameter("@TenSX", dto.TenSX);
                return db.ExecuteNonQuery("sp_UpdateNSX", CommandType.StoredProcedure) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool deleteNSX(int MaSX)
        {
            db = new DBLib();
            try
            {
                db.AddParameter("@MaSX", MaSX);
                return db.ExecuteNonQuery("sp_DeleteNSX", CommandType.StoredProcedure) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}