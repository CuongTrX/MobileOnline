<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductInfo.aspx.cs" Inherits="MobileStoreOnline.ProductInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="panel-heading">
        <h4 class="panel-title text-center">Chi tiết sản phẩm</h4>
    </div>
    <div class="panel-body">
        <%--Thêm sản phẩm--%>
        <div class="row text-center">
            <asp:Label ID="error" runat="server" CssClass="small alert-danger" />
        </div>
        <div class="row">
            <div class="col-xs-8">
                <div class="form-group row">
                    <label class="col-xs-4 text-right control-label">Tên sản phẩm:</label>
                    <div class="col-xs-8">
                        <asp:Label ID="TenSP" runat="server" CssClass="text-left control-label" />
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-xs-4 text-right">Tên nhà sản xuất:</label>
                    <div class="col-xs-8">
                        <asp:Label ID="TenSX" runat="server" CssClass="text-left control-label" />
                    </div>
                </div>

                <div class="form-group row">
                    <label class="col-xs-4 text-right">Giá bán:</label>
                    <div class="col-xs-8">
                        <asp:Label ID="GiaBan" runat="server" CssClass="text-left control-label" />
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-xs-4 text-right">Ngày nhập</label>
                    <div class="col-xs-8">
                        <asp:Label ID="NgayNhap" runat="server" CssClass="text-left control-label" />
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-xs-4 text-right">Mô tả chi tiết:</label>
                    <div class="col-xs-8">
                        <asp:Label ID="ChiTiet" runat="server" CssClass="text-left control-label" />
                    </div>
                </div>
            </div>
            <div class="col-xs-4">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <h4 class="panel-title text-center">Hình minh họa</h4>
                    </div>
                    <div class="panel-body">
                        <asp:Image ID="HinhAnh" runat="server" />
                    </div>
                </div>

                <div class="text-center">
                    <asp:Button ID="Submit" runat="server" Text="Thêm vào giỏ hàng" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>
