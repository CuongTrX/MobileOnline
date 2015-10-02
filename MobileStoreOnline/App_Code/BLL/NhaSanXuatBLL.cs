using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MobileStoreOnline.App_Code.BLL
{
    public class NhaSanXuatBLL
    {
        public NhaSanXuatBLL() { }

        DAL.NhaSanXuatDAL dal = new DAL.NhaSanXuatDAL();
        public bool insertNSX(string TenSX)
        {
            try
            {
                return dal.insertNSX(TenSX);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable getNhaSanXuat()
        {
            try
            {
                return dal.getNhaSanXuat();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool updateNSX(DTO.NhaSanXuat dto)
        {
            try
            {
                return dal.updateNSX(dto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool deleteNSX(int MaSX)
        {
            try
            {
                return dal.deleteNSX(MaSX);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}