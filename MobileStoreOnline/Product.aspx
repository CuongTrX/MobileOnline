<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="MobileStoreOnline.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="panel-heading">
        <h4 class="panel-title text-center">Mobile Shop Online</h4>
    </div>
    <div class="panel-body">
        <div class="col-xs-12">
            <div class="row">
                <asp:Repeater ID="SanPham" runat="server">
                    <ItemTemplate>
                        <div class="col-sm-3">
                            <a href="ProductInfo.aspx?MaSP=<%#Eval("MaSP") %>">
                                <div class="panel panel-primary">
                                    <div class="panel-heading text-center"><%# Eval("TenSP") %></div>
                                    <div class="panel-body text-center">
                                        <img src="Images/<%# Eval("HinhAnh") %>" class="img-responsive container" />
                                    </div>
                                    <div class="panel-footer text-center">Giá: <%# Eval("GiaBan") %></div>
                                </div>
                            </a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="row">
                <ul class="pager">
                    <li><a id="pSanPham" runat="server">Previous</a></li>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <li><a id="nSanPham" runat="server">Next</a></li>
                </ul>
            </div>
            <br />
        </div>
    </div>
</asp:Content>
