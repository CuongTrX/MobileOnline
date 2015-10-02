using MobileStoreOnline.App_Code.BLL;
using MobileStoreOnline.App_Code.DTO;
using System;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;

namespace MobileStoreOnline.Admin
{
    public partial class AddProduct : System.Web.UI.Page
    {
        NhaSanXuatBLL bllNhaSanXuat;
        SanPhamBLL bllSanPham;
        SanPham dtoSanPham;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtNhaSanXuat;
            
            bllNhaSanXuat = new NhaSanXuatBLL();
            dtNhaSanXuat = bllNhaSanXuat.getNhaSanXuat();
            TenSX.DataTextField = "TenSX";
            TenSX.DataValueField = "MaSX";
            TenSX.DataSource = dtNhaSanXuat;
            TenSX.DataBind();

            gvSanPhamBindData();
            
        }
        protected void Page_Clear()
        {
            TenSP.Text = null;
            GiaBan.Text = null;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            dtoSanPham = new SanPham();
            bllSanPham = new SanPhamBLL();
            string fname = null;
            dtoSanPham.MaSX = Convert.ToInt32(TenSX.SelectedValue);
            dtoSanPham.TenSP = TenSP.Text;
            dtoSanPham.GiaBan = GiaBan.Text;
            dtoSanPham.PhanLoai = PhanLoai.SelectedValue;
            //Upload image
            HttpPostedFile file = Request.Files["FileUpload"];
            //check file was submitted
            if (file != null && file.ContentLength > 0)
            {
                fname = Path.GetFileName(file.FileName);
            }
            dtoSanPham.HinhAnh = fname;
            dtoSanPham.ChiTiet = Request.Form["ChiTiet"];
            if (bllSanPham.insertSanPham(dtoSanPham))
            {
                if (fname != null)
                {
                    file.SaveAs(Server.MapPath(Path.Combine("../Images/", fname)));
                }
                Page_Clear();
                gvSanPhamBindData();
                lblMessage.Text = null;
                error.Text = "Thêm thành công!";
            }
            else
            {
                lblMessage.Text = null;
                error.Text = "Lỗi! Vui lòng thử lại.";
            }
        }
        //gvSanPham
        private void gvSanPhamBindData()
        {
            DataTable dtSanPham;
            bllSanPham = new SanPhamBLL();
            dtSanPham = bllSanPham.getSanPham();
            gvSanPham.DataSource = dtSanPham;
            gvSanPham.DataBind();
        }
        protected void EditRecord(object sender, GridViewEditEventArgs e)
        {
            gvSanPham.EditIndex = e.NewEditIndex;
            lblMessage.Text = null;
            gvSanPhamBindData();
        }
        protected void CancelRecord(object sender, GridViewCancelEditEventArgs e)
        {
            gvSanPham.EditIndex = -1;
            gvSanPhamBindData();
        }
        protected void UpdateRecord(object sender, GridViewUpdateEventArgs e)
        {
            dtoSanPham = new SanPham();

            GridViewRow row = (GridViewRow)gvSanPham.Rows[e.RowIndex];
            dtoSanPham.MaSP = Int32.Parse(gvSanPham.DataKeys[e.RowIndex].Value.ToString());
            dtoSanPham.GiaBan = ((TextBox)row.Cells[4].Controls[0]).Text;
            dtoSanPham.HinhAnh = ((TextBox)row.Cells[6].Controls[0]).Text;
            dtoSanPham.ChiTiet = ((TextBox)row.Cells[7].Controls[0]).Text;

            try
            {
                bllSanPham.updateSanPham(dtoSanPham);
                error.Text = null;
                lblMessage.Text = "Cập nhật thành công!";
                // Refresh the data
                gvSanPham.EditIndex = -1;
                gvSanPhamBindData();
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void DeleteRecord(object sender, GridViewDeleteEventArgs e)
        {
            bllSanPham = new SanPhamBLL();
            int MaSP = Int32.Parse(gvSanPham.DataKeys[e.RowIndex].Value.ToString());
            
            try
            {
                bllSanPham.deleteSanPham(MaSP);
                error.Text = null;
                lblMessage.Text = "Xóa thành công!";
                gvSanPhamBindData();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}