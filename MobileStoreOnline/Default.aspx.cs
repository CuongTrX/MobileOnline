using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileStoreOnline.App_Code.DTO;
using MobileStoreOnline.App_Code.BLL;
using System.Data;

namespace MobileStoreOnline
{
    public partial class Default : System.Web.UI.Page
    {
        SanPhamBLL bllSanPham;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            bllSanPham = new SanPhamBLL();
            DataTable dtNewPhone = bllSanPham.selectSPByNew();
            PagedDataSource pdsNewPhone = new PagedDataSource();
            DataView dvNewPhone = new DataView(dtNewPhone);
            pdsNewPhone.DataSource = dvNewPhone;
            pdsNewPhone.AllowPaging = true;
            pdsNewPhone.PageSize = 4;
            NewPhone.DataSource = pdsNewPhone;
            NewPhone.DataBind();
            //
            bllSanPham = new SanPhamBLL();
            DataTable dtSmartPhone = bllSanPham.selectSPByIDPhanLoai(1);
            PagedDataSource pdsSmartPhone = new PagedDataSource();
            DataView dvSmartPhone = new DataView(dtSmartPhone);
            pdsSmartPhone.DataSource = dvSmartPhone;
            pdsSmartPhone.AllowPaging = true;
            pdsSmartPhone.PageSize = 4;
            SmartPhone.DataSource = pdsSmartPhone;
            SmartPhone.DataBind();
            //
            bllSanPham = new SanPhamBLL();
            DataTable dtPhoThong = bllSanPham.selectSPByIDPhanLoai(0);
            PagedDataSource pdsPhoThong = new PagedDataSource();
            DataView dvPhoThong = new DataView(dtPhoThong);
            pdsPhoThong.DataSource = dvPhoThong;
            pdsPhoThong.AllowPaging = true;
            pdsPhoThong.PageSize = 4;
            PhoThong.DataSource = pdsPhoThong;
            PhoThong.DataBind();
        }
    }
}