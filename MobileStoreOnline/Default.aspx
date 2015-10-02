<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MobileStoreOnline.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="panel-heading">
        <h4 class="panel-title text-center">Mobile Shop Online</h4>
    </div>
    <div class="panel-body">
        <div class="col-xs-12">
            <p class="text-center label-danger">HÀNG MỚI VỀ</p>
            <div class="row">
                <asp:Repeater ID="NewPhone" runat="server">
                    <ItemTemplate>
                        <div class="col-sm-3">
                            <a href="ProductInfo.aspx?MaSP=<%#Eval("MaSP") %>">
                                <div class="panel panel-info">
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
                <ul class="pager pull-right">
                    <li><a href="Product.aspx?page=1&id=new" class="btn btn-info">Xem tiếp...</a></li>
                </ul>
            </div>
            <br />
            <p class="text-center label-warning">SMART PHONE</p>
            <div class="row">
                <asp:Repeater ID="SmartPhone" runat="server">
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
                <ul class="pager pull-right">
                    <li><a href="Product.aspx?page=1&Id=1" class="btn btn-info">Xem tiếp...</a></li>
                </ul>
            </div>
            <br />
            <p class="text-center label-success">HÀNG PHỔ THÔNG</p>
            <div class="row">
                <asp:Repeater ID="PhoThong" runat="server">
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
                <ul class="pager pull-right">
                    <li><a href="Product.aspx?page=1&Id=0" class="btn btn-info">Xem tiếp...</a></li>
                </ul>
            </div>
            <br />
        </div>
    </div>
</asp:Content>
