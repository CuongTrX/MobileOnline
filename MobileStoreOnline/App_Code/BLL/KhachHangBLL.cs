using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MobileStoreOnline.App_Code.BLL
{
    public class KhachHangBLL
    {
        public KhachHangBLL()
        {

        }

        DAL.KhachHangDAL dal = new DAL.KhachHangDAL();
        public SqlDataReader checkKhachHang(string Email)
        {
            try
            {
                return dal.checkKhachHang(Email);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object insertKhachHang(DTO.KhachHang dto)
        {
            try
            {
                return dal.insertKhachHang(dto);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}