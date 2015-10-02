using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MobileStoreOnline.App_Code.DAL
{
    public class SanPhamDAL
    {
        public SanPhamDAL() { }
        DBLib db = new DBLib();
        
        public bool insertSanPham(DTO.SanPham dto)
        {
            try
            {
                db.AddParameter("@MaSX", dto.MaSX);
                db.AddParameter("@TenSP", dto.TenSP);
                db.AddParameter("@GiaBan", dto.GiaBan);
                db.AddParameter("@PhanLoai", dto.PhanLoai);
                db.AddParameter("@HinhAnh", dto.HinhAnh);
                db.AddParameter("@ChiTiet", dto.ChiTiet);
                return db.ExecuteNonQuery("sp_InsertSanPham", CommandType.StoredProcedure) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable getSanPham()
        {
            try
            {
                return db.FillDataTable("sp_SelectSanPham", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable searchSanPham(string SQL)
        {
            try
            {
                return db.FillDataTable(SQL, CommandType.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public SqlDataReader selectSanPhamByMaSP(int MaSP)
        {
            try
            {
                db.AddParameter("@MaSP", MaSP);
                return db.ExecuteReader("sp_SelectSanPhamByMaSP", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable selectSPByIDPhanLoai(int PhanLoai)
        {
            try
            {
                db.AddParameter("@Id", PhanLoai);
                return db.FillDataTable("sp_SelectSPByIdPhanLoai", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable selectSPByNew()
        {
            try
            {
                return db.FillDataTable("sp_SelectSPNew", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool updateSanPham(DTO.SanPham dto)
        {
            try
            {
                db.AddParameter("@MaSP", dto.MaSP);
                db.AddParameter("@GiaBan", dto.GiaBan);
                db.AddParameter("@HinhAnh", dto.HinhAnh);
                db.AddParameter("@ChiTiet", dto.ChiTiet);
                return db.ExecuteNonQuery("sp_UpdateSanPham", CommandType.StoredProcedure) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool deleteSanPham(int MaSP)
        {
            try
            {
                db.AddParameter("@MaSP", MaSP);
                return db.ExecuteNonQuery("sp_DeleteSanPham", CommandType.StoredProcedure) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}