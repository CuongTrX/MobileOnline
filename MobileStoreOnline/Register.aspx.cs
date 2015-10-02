using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileStoreOnline.App_Code.DTO;
using MobileStoreOnline.App_Code.BLL;

namespace MobileStoreOnline
{
    public partial class Register : System.Web.UI.Page
    {
        KhachHang dtoKhachHang;
        KhachHangBLL bllKhachHang;

        string act = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["Email"] != null)
                {
                    HttpCookie cookie = Request.Cookies["Email"];
                    Email.Text = cookie.Value;
                }
            }
            if (Session["action"] != null)
                act = Session["action"].ToString();
        }
        
        protected void Submit_Click(object sender, EventArgs e)
        {
            dtoKhachHang = new KhachHang();
            bllKhachHang = new KhachHangBLL();
            dtoKhachHang.HoTen = HoTen.Text;
            dtoKhachHang.NgaySinh = NgaySinh.Text;
            dtoKhachHang.GioiTinh = GioiTinh.Text;
            dtoKhachHang.CMND = CMND.Text;
            dtoKhachHang.DiaChi = DiaChi.Text;
            dtoKhachHang.DT = DT.Text;
            dtoKhachHang.Email = Email.Text;
            dtoKhachHang.PassWord = PassWord.Text;
            try
            {
                object oKH = bllKhachHang.insertKhachHang(dtoKhachHang);
                if (oKH != null)
                {
                    HoTen.Text = oKH.ToString();
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            //try
            //{
            //    object oKH;
            //    oKH = bllKhachHang.selectKhachHang("hhhhhh");
            //    HoTen.Text = oKH.ToString();
                //Session["HoTen"] = dtoKhachHang.HoTen;
                //Session["MaKH"] = oKH.ToString();
                //HttpCookie cookie = new HttpCookie("Email", dtoKhachHang.Email);
                //cookie.Expires = DateTime.Now.AddDays(1D);
                //Response.Cookies.Add(cookie);
                //Response.Write(act);
                //if (act == "loginshop")
                //{
                //    Response.Redirect("Cart.aspx");
                //}
                //else
                //{
                //    Response.Redirect("Default.aspx");
                //}
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}