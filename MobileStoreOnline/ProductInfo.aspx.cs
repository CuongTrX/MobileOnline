using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileStoreOnline.App_Code.DTO;
using MobileStoreOnline.App_Code.BLL;
using System.Data;
using System.Data.SqlClient;

namespace MobileStoreOnline
{
    public partial class ProductInfo : System.Web.UI.Page
    {
        SanPhamBLL bllSanPham;
        SqlDataReader sdrSanPham;
        protected void Page_Load(object sender, EventArgs e)
        {
            bllSanPham = new SanPhamBLL();
            if (Request.QueryString["MaSP"]!=null)
            {
                sdrSanPham = bllSanPham.selectSanPhamByMaSP(int.Parse(Request.QueryString["MaSP"]));
                if (sdrSanPham.Read())
                {
                    TenSP.Text = (string)sdrSanPham["TenSP"];
                    TenSX.Text = (string)sdrSanPham["TenSX"];
                    GiaBan.Text = sdrSanPham["GiaBan"].ToString();
                    NgayNhap.Text = ((DateTime)sdrSanPham["NgayNhap"]).ToString("dd/MM/yyyy");
                    HinhAnh.ImageUrl = "/Images/" + (string)sdrSanPham["HinhAnh"];
                    ChiTiet.Text = (string)sdrSanPham["ChiTiet"];
                }
                else
                {
                    Response.Redirect("/Default.aspx");
                }
            }
            else
            {
                Response.Redirect("/Default.aspx");
            }
        }
    }
}