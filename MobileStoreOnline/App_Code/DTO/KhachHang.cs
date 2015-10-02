using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStoreOnline.App_Code.DTO
{
    public class KhachHang
    {
        public KhachHang()
        {

        }
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string DT { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public int IsAdmin { get; set; }
    }
}