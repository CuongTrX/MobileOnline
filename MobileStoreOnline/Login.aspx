<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MobileStoreOnline.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="panel-heading">
        <h4 class="panel-title text-center">Đăng Nhập</h4>
    </div>
    <div class="panel-body">
        <div class="row text-center">
            <asp:Label ID="error" runat="server" Text="" CssClass="small alert-danger" />
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">Email:</label>
            <div class="col-xs-6">
                <asp:TextBox ID="Email" CssClass="form-control" runat="server" />
            </div>
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">Password</label>
            <div class="col-xs-6">
                <asp:TextBox ID="PassWord" TextMode="Password" CssClass="form-control" runat="server" />
            </div>
        </div>
        <br />
        <div class="text-center">
            <asp:Button ID="btnSubmit" runat="server" Text="Đồng ý" OnClick="btnSubmit_Click" CssClass="btn btn-default" />
        </div>
    </div>
</asp:Content>
