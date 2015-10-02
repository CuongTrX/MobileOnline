<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MobileStoreOnline.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="panel-heading">
        <h4 class="panel-title text-center">Đăng Ký</h4>
    </div>
    <div class="panel-body">
        <div class="row">
            <label class="col-xs-3 text-right control-label">Họ và tên:</label>
            <div class="col-xs-6" runat="server">
                <asp:TextBox runat="server" ID="HoTen" CssClass="form-control" />
            </div>
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">Ngày sinh:</label>
            <div class="col-xs-6">
                <asp:TextBox runat="server" ID="NgaySinh" CssClass="form-control" />
            </div>
            <script type="text/javascript">
                $(function () {
                    $('#<%=NgaySinh.ClientID%>').datetimepicker({
                            format: "DD/MM/YYYY"
                        });
                    });
            </script>
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">Giới Tính:</label>
            <div class="col-xs-6">
                <asp:RadioButtonList ID="GioiTinh" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="Nam " Value="1" />
                    <asp:ListItem Text="Nữ " Value="0" />
                </asp:RadioButtonList>
            </div>
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">CMND:</label>
            <div class="col-xs-6">
                <asp:TextBox runat="server" ID="CMND" CssClass="form-control" />
            </div>
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">Địa Chỉ:</label><div class="col-xs-6">
                <asp:TextBox runat="server" ID="DiaChi" CssClass="form-control" />
            </div>
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">Số Điện Thoại:</label><div class="col-xs-6">
                <asp:TextBox runat="server" ID="DT" CssClass="form-control" />
            </div>
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">Email:</label><div class="col-xs-6">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" />
            </div>
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">Password</label>
            <div class="col-xs-6">
                <asp:TextBox runat="server" TextMode="Password" ID="PassWord" CssClass="form-control" />
            </div>
        </div>
        <br />
        <div class="row">
            <label class="col-xs-3 text-right control-label">Confirm Password</label>
            <div class="col-xs-6">
                <asp:TextBox runat="server" TextMode="Password" ID="confirmPassword" CssClass="form-control" />
            </div>
        </div>
        <br />

        <div class="row">
            <label class="col-xs-3  text-right control-label">Điều khoản:</label>
            <div class="col-xs-6">
                <textarea class="form-control" rows="5" disabled="disabled">
      1.1. Điều khoản thanh toán kiểm soát chủ yếu các rủi ro trong thanh toán
                            
Các rủi ro tài chính (trong xuất khẩu) có thể được kiểm soát bằng cách:

Bảo đảm qua một nhà môi giới bảo hiểm

Chia các rủi ro về giao hàng giữa người mua và người bán bằng cách phân định rõ trách nhiệm (Phụ lục 4).

Chia các rủi ro thanh toán hoặc không thanh toán cũng theo cách trên.

Ba yếu tố kiểm soát rủi ro trên thường được kết hợp sử dụng trong giao dịch kinh doanh.

1.2. Tín dụng ngắn hạn và dài hạn

Yếu tố đầu tiên của kiểm soát rủi ro là xác định thời hạn của tín dụng được nhà cung cấp chấp nhận. Thanh toán tín dụng ở đây được kết hợp với rất nhiều hình thức thanh toán. Ví dụ: "L/C 60 ngày". Việc thanh toán sẽ được ngân hàng thực hiện và sau 60 ngày kể từ khi L/C được xuất trình. Có 2 loại tín dụng:

Tín dụng ngắn hạn: Thời hạn thanh toán nằm trong khoảng thời gian không quá 12 tháng, nghĩa là thời gian từ lúc giao hàng tới khi thanh toán được thực hiện không quá 12 tháng. Tín dụng ngắn hạn thường dùng cho việc thanh toán hàng tiêu dùng, nguyên liệu thô, hàng hoá bán thành phẩm.

Tín dụng dài hạn: việc thanh toán được thực hiện dài hơn 12 tháng sau khi giao nhận hàng hoá hay sau khi hết hạn hợp đồng.
  </textarea>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-xs-6 col-xs-offset-3">
                <asp:CheckBox ID="CheckBox" runat="server" />Tôi đồng ý với điều khoản
            </div>
        </div>
        <br />
        <div class="text-center" runat="server">
            <asp:Button ID="btnSubmit" runat="server" Text="Đồng ý" OnClick="Submit_Click" CssClass="btn btn-default" />
        </div>
    </div>
</asp:Content>
