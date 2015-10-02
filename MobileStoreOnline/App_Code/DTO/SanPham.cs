using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStoreOnline.App_Code.DTO
{
    public class SanPham
    {
        public SanPham() { }
        public int MaSP { get; set; }
        public int MaSX { get; set; }
        public string TenSP { get; set; }
        public string GiaBan{ get; set; }
        public string NgayNhap { get; set; }
        public string PhanLoai { get; set; }
        public string HinhAnh { get; set; }
        public string ChiTiet { get; set; }
    }
}