<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="TaiKhoan.aspx.cs" Inherits="ThuVien.TaiKhoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Tài khoản -Thư viện</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Thông tin tài khoản"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Thông tin tài khoản" CssClass="title"></asp:Label>
    </div>
    <hr />
    <ul class="menuTaiKhoan">
        <li class="active">
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="taikhoan" NavigateUrl="~/Tai-Khoan" ForeColor="#7E592A">Cập nhật thông tin</asp:HyperLink></li>
        <li class="divider"></li>
        <li>
            <asp:HyperLink ID="HyperLink10" runat="server" CssClass="taikhoan" NavigateUrl="~/Doi-Mat-Khau" ForeColor="#7E592A">Đổi mật khẩu</asp:HyperLink></li>
        <li class="divider"></li>
        <li>
            <asp:HyperLink ID="HyperLink2" runat="server" CssClass="taikhoan" NavigateUrl="~/Tai-Khoan/tai-lieu-cua-toi" ForeColor="#7E592A">Quản lý tài liệu</asp:HyperLink></li>
        <li class="divider"></li>
        <li>
            <asp:HyperLink ID="HyperLink3" runat="server" CssClass="taikhoan" NavigateUrl="~/Tai-Khoan/sach-cua-toi" ForeColor="#7E592A">Quản lý sách</asp:HyperLink></li>
    </ul>
    <hr />
    <div style="padding-bottom: 20px;"></div>
    <div class="form-login">
        <div class="thongbao">
            <asp:Label ID="lblThongBao" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <div class="form-group">
            <label>Họ và tên:</label>
            <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Họ tên không được bỏ trống" ForeColor="Red" ControlToValidate="txtHoTen"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email không được bỏ trống" ForeColor="Red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email không đúng định dạng" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
        </div>
        <asp:ImageButton ID="btnCapNhat" runat="server" ImageUrl="~/libs/images/CapNhat.png" OnClick="btnCapNhat_Click"  /><br />
    </div>
</asp:Content>
