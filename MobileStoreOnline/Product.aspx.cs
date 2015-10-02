using MobileStoreOnline.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileStoreOnline
{
    public partial class Product : System.Web.UI.Page
    {
        SanPhamBLL bllSanPham;
        DataTable dtSanPham;
        protected void Page_Load(object sender, EventArgs e)
        {
            bllSanPham = new SanPhamBLL();

            if (Request.QueryString.Count <= 1)
            {
                dtSanPham = bllSanPham.getSanPham();
            }
            else if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["Id"] == "new")
                {
                    dtSanPham = bllSanPham.selectSPByNew();
                }
                else
                {
                    dtSanPham = bllSanPham.selectSPByIDPhanLoai(int.Parse(Request.QueryString["Id"]));
                }
            }
            else
            {
                string sqlQuery = "select * from SanPham where MaSX = '" + int.Parse(Request.QueryString["MaSX"]) + "'";
                sqlQuery += " and GiaBan >= '" + int.Parse(Request.QueryString["PriceFrom"]) + "'";
                if (Request.QueryString["PriceTo"] != "0")
                {
                    sqlQuery += " and GiaBan <= '" + int.Parse(Request.QueryString["PriceTo"]) + "'";
                }

                if (Request.QueryString["TenSP"] != null)
                {
                    sqlQuery += " and TenSP like '%" + Request.QueryString["TenSP"].ToString() + "%'";
                }

                
                dtSanPham = bllSanPham.searchSanPham(sqlQuery);
            }

            PagedDataSource pdsSanPham = new PagedDataSource();
            DataView dvSanPham = new DataView(dtSanPham);

            pdsSanPham.DataSource = dvSanPham;
            pdsSanPham.AllowPaging = true;
            pdsSanPham.PageSize = 8;
            int pcSanPham = pdsSanPham.PageCount;
            int currentPage;
            if (Request.QueryString["page"] != null)
            {
                currentPage = Int32.Parse(Request.QueryString["page"]);
            }
            else
            {
                currentPage = 1;
            }
            pdsSanPham.CurrentPageIndex = currentPage - 1;

            if (!pdsSanPham.IsFirstPage)
            {
                if (Request.QueryString.Count<=1)
                {
                    pSanPham.HRef = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage - 1);
                }
                else if (Request.QueryString["id"] != null)
                {
                    pSanPham.HRef = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage - 1);
                    pSanPham.HRef += "&Id=" + Request.QueryString["Id"];
                }
                else
                {
                    pSanPham.HRef = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage - 1);
                    pSanPham.HRef += "&TenSP=" + Request.QueryString["TenSP"];
                    pSanPham.HRef += "&MaSX=" + Request.QueryString["MaSX"];
                    pSanPham.HRef += "&PriceFrom=" + Request.QueryString["PriceFrom"];
                    pSanPham.HRef += "&PriceTo=" + Request.QueryString["PriceTo"];
                }
            }
            else
            {
                pSanPham.Disabled = false;
            }
            if (!pdsSanPham.IsLastPage)
            {
                if (Request.QueryString.Count <= 1)
                {
                    nSanPham.HRef = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage + 1);
                }
                else if (Request.QueryString["id"] != null)
                {
                    nSanPham.HRef = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage + 1);
                    nSanPham.HRef += "&Id=" + Request.QueryString["Id"];
                }
                else
                {
                    nSanPham.HRef = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage + 1);
                    nSanPham.HRef += "&TenSP=" + Request.QueryString["TenSP"];
                    nSanPham.HRef += "&MaSX=" + Request.QueryString["MaSX"];
                    nSanPham.HRef += "&PriceFrom=" + Request.QueryString["PriceFrom"];
                    nSanPham.HRef += "&PriceTo=" + Request.QueryString["PriceTo"];
                }
            }
            else
            {
                nSanPham.Disabled = false;
            }


            SanPham.DataSource = pdsSanPham;
            SanPham.DataBind();
        }
    }
}