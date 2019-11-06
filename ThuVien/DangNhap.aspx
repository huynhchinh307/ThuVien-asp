<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="ThuVien.DangNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Đăng nhập -Thư viện</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Thư viện"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Đăng nhập vào thư viên" CssClass="title"></asp:Label>
    </div>
    <hr />
    <div class="form-login">
        <div class="thongbao">
            <asp:Label ID="lblThongBao" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <div class="form-group">
            <label>Tên đăng nhập:</label>
            <asp:TextBox ID="txtTenDangNhap" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Tên đăng nhập không được bỏ trống" ForeColor="Red" ControlToValidate="txtTenDangNhap"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Mật khẩu:</label>
            <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Mật khẩu không được bỏ trống" ForeColor="Red" ControlToValidate="txtMatKhau"></asp:RequiredFieldValidator>
        </div>
        <asp:ImageButton ID="btnLogin" runat="server" OnClick="btnLogin_Click" ImageUrl="~/libs/images/DangNhap.png" /><br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Dang-Ky">Chưa có tài khoản?    </asp:HyperLink>
        |
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Quen-Mat-Khau">  Quên mật khẩu?</asp:HyperLink>
    </div>
    <hr />
</asp:Content>
