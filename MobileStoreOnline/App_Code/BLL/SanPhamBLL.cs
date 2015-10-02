using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MobileStoreOnline.App_Code.BLL
{
    public class SanPhamBLL
    {
        public SanPhamBLL() { }

        public bool insertSanPham(DTO.SanPham dto)
        {
            try
            {
                return dal.insertSanPham(dto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        DAL.SanPhamDAL dal = new DAL.SanPhamDAL();
        public DataTable getSanPham()
        {
            try
            {
                return dal.getSanPham();
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
                return dal.searchSanPham(SQL);
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
                return dal.selectSanPhamByMaSP(MaSP);
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
                return dal.selectSPByIDPhanLoai(PhanLoai);
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
                return dal.selectSPByNew();
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
                return dal.updateSanPham(dto);
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
                return dal.deleteSanPham(MaSP);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}