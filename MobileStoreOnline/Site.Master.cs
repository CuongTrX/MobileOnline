using System;
using System.Web.UI;
using MobileStoreOnline.App_Code.BLL;
using MobileStoreOnline.App_Code.DTO;
using System.Data;

namespace MobileStoreOnline
{
    public partial class Site : MasterPage
    {
        NhaSanXuatBLL bllNhaSanXuat;
        DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bllNhaSanXuat = new NhaSanXuatBLL();
                dataTable = bllNhaSanXuat.getNhaSanXuat();
                TenSX.DataTextField = "TenSX";
                TenSX.DataValueField = "MaSX";
                TenSX.DataSource = dataTable;
                TenSX.DataBind();
            }
            
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("Default.aspx");
        }

        protected void search_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx?page=1&TenSP=" + TenSP.Text + "&MaSX=" + TenSX.SelectedValue + "&PriceFrom=" + PriceFrom.SelectedValue + "&PriceTo=" + PriceTo.SelectedValue);
        }
    }
}