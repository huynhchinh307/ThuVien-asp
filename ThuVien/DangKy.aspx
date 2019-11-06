<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="ThuVien.DangKy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Đăng Ký -Thư viện</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Đăng ký"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Đăng ký vào thư viện" CssClass="title"></asp:Label>
    </div>
    <hr />
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
        <div class="form-group">
            <label>Nhập laị mật khẩu:</label>
            <asp:TextBox ID="txtNhapLaiMK" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Mật khẩu chưa được nhập lại" ForeColor="Red" ControlToValidate="txtNhapLaiMK"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mật khẩu không giống nhau" ControlToCompare="txtMatKhau" ControlToValidate="txtNhapLaiMK" ForeColor="Red"></asp:CompareValidator>
        </div>
        <asp:ImageButton ID="btnDangKy" runat="server" ImageUrl="~/libs/images/DangKy.png" OnClick="btnDangKy_Click" /><br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Dang-Nhap">Đã có tài khoản?    </asp:HyperLink>
        |
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Quen-Mat-Khau">  Quên mật khẩu?</asp:HyperLink>
    </div>
    <hr />
</asp:Content>

