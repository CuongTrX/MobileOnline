using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileStoreOnline.App_Code.DTO;
using MobileStoreOnline.App_Code.BLL;
using System.Data.SqlClient;

namespace MobileStoreOnline
{
    public partial class Login : System.Web.UI.Page
    {
        string act = "";
        KhachHang dtoKhachHang;
        KhachHangBLL bllKhachHang;
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            dtoKhachHang = new KhachHang();
            bllKhachHang = new KhachHangBLL();
            SqlDataReader reader;
            dtoKhachHang.Email = Email.Text;
            dtoKhachHang.PassWord = PassWord.Text;

            try
            {
                reader = bllKhachHang.checkKhachHang(Email.Text);
                if (reader.Read())
                {
                    if ((string)reader["PassWord"] == PassWord.Text)
                    {
                        if ((int)reader["IsAdmin"] == 1)
                        {
                            Response.Redirect("Admin/Default.aspx");
                        }
                        else
                        {
                            Response.Redirect("Default.aspx");
                        }
                    }
                    else
                    {
                        error.Text = "Mật khẩu không đúng!";
                    }

                }
                else
                {
                    error.Text = "Email không tồn tại!";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}