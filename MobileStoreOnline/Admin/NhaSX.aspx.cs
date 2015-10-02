using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileStoreOnline.App_Code.BLL;
using MobileStoreOnline.App_Code.DTO;
using System.Data;

namespace MobileStoreOnline.Admin
{
    public partial class NhaSX : Page
    {
        NhaSanXuatBLL bllNSX;
        NhaSanXuat dtoNSX;
        DataTable dtNSX;

        protected void Page_Load(object sender, EventArgs e)
        {
            gvNSXBindData();
        }
        public void gvNSXBindData()
        {
            bllNSX = new NhaSanXuatBLL();
            dtNSX = new DataTable();
            dtNSX = bllNSX.getNhaSanXuat();
            gvNSX.DataSource = dtNSX;
            gvNSX.DataBind();
        }

        protected void gvNhaSanXuat_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvNSX.EditIndex = e.NewEditIndex;
            lblMessage.Text = null;
            gvNSXBindData();
        }

        protected void gvNhaSanXuat_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvNSX.EditIndex = -1;
            gvNSXBindData();
        }

        protected void gvNhaSanXuat_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            dtoNSX = new NhaSanXuat();

            GridViewRow row = (GridViewRow)gvNSX.Rows[e.RowIndex];
            dtoNSX.MaSX = Int32.Parse(gvNSX.DataKeys[e.RowIndex].Value.ToString());
            dtoNSX.TenSX = ((TextBox)row.Cells[2].Controls[0]).Text;

            try
            {
                bllNSX.updateNSX(dtoNSX);
                error.Text = null;
                lblMessage.Text = "Cập nhật thành công!";
                // Refresh the data
                gvNSX.EditIndex = -1;
                gvNSXBindData();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void gvNhaSanXuat_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            bllNSX = new NhaSanXuatBLL();
            int MaSX = Int32.Parse(gvNSX.DataKeys[e.RowIndex].Value.ToString());

            try
            {
                bllNSX.deleteNSX(MaSX);
                error.Text = null;
                lblMessage.Text = "Xóa thành công!";
                gvNSXBindData();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void addNSX_Click(object sender, EventArgs e)
        {
            bllNSX = new NhaSanXuatBLL();
            if (bllNSX.insertNSX(TenNSX.Text))
            {
                lblMessage.Text = null;
                error.Text = "Thêm thành công!";
                gvNSXBindData();
            }

        }
    }
}