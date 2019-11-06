<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="ThuVien.DoiMatKhau" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Đổi mật khẩu - Thư viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Đổi mật khẩu"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Đổi mật khẩu" CssClass="title"></asp:Label>
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
            <label>Nhập mật khẩu cũ:</label>
            <asp:TextBox ID="txtMatKhau" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mật khẩu cũ không được bỏ trống" ForeColor="Red" ControlToValidate="txtMatKhau"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Nhập mật khẩu mới:</label>
            <asp:TextBox ID="txtMatKhauMoi" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Mật khẩu mới không được bỏ trống" ForeColor="Red" ControlToValidate="txtMatKhauMoi"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Nhập lại mật khẩu mới:</label>
            <asp:TextBox ID="txtMatKhauMoi2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Mật khẩu nhập lại không được bỏ trống" ForeColor="Red" ControlToValidate="txtMatKhauMoi2"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mật khẩu nhập lại không đúng" ForeColor="Red" ControlToCompare="txtMatKhauMoi2" ControlToValidate="txtMatKhauMoi"></asp:CompareValidator>
        </div>
        <asp:ImageButton ID="btnCapNhat" runat="server" ImageUrl="~/libs/images/DoiMatKhau.png" OnClick="btnCapNhat_Click"  /><br />
    </div>
</asp:Content>
