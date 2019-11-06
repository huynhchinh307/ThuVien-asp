<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ThemNguoiDung.aspx.cs" Inherits="ThuVien.Admin.ThemNguoiDung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thư viện - Sửa người dùng</title>
    <style type="text/css">
        .auto-style3 {
            color: #7f7f7f;
            font-size: 11px;
            cursor: pointer;
            line-height: 14px;
            -moz-border-radius: 3px;
            -webkit-border-radius: 3px;
            -moz-box-shadow: 0 0 2px #978f6c;
            -webkit-box-shadow: 0 0 2px #978f6c;
            border: 1px solid #b1a874;
            padding: 2px 6px;
            background: #eee url('css/images/button.gif') repeat-x 0 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shell">
        `<!-- Small Nav --><div class="small-nav"><a href="index.aspx">Bảng điều khiển</a> <span>&gt;</span> Quản lý người dùng </div>
        <!-- End Small Nav -->
        <br />
        <!-- Main -->
        <div id="main">
            <div class="cl">&nbsp;</div>
            <div id="content2">
                <!-- Box -->
                <div class="box">
          <!-- Box Head -->
          <div class="box-head">
            <h2>Sửa người dùng</h2>
          </div>
          <!-- End Box Head -->
            <!-- Form -->
                    <div class="form">
                        <div id="thongbao" runat="server">
                            <p>
                                <asp:Label ID="lblThongBao" runat="server"></asp:Label>
                            </p>
                        </div>
                        <p>
                            <span class="req">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="UserName không được bỏ trống!" ForeColor="Red" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                            </span>
                            <label>UserName</label>
                            <asp:TextBox ID="txtUserName" runat="server" CssClass="field size1"></asp:TextBox>
                        </p>
                        <p>
                            <span class="req">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Tên người dùng không được bỏ trống!" ForeColor="Red" ControlToValidate="txtTenNguoiDung"></asp:RequiredFieldValidator>
                            </span>
                            <label>Tên người dùng</label>
                            <asp:TextBox ID="txtTenNguoiDung" runat="server" CssClass="field size1"></asp:TextBox>
                        </p>
                        <p>
                            <span class="req">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Địa chỉ email không hợp lệ." ForeColor="Red" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Địa chỉ Email không được bỏ trống!" ForeColor="Red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                            </span>
                            <label>Email</label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="field size1"></asp:TextBox>
                        </p>
                        <p>
                            <span class="req">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Mật khẩu không được bỏ trống!" ForeColor="Red" ControlToValidate="txtMatKhau"></asp:RequiredFieldValidator>
                            </span>
                            <label>Mật khẩu</label>
                            <asp:TextBox ID="txtMatKhau" runat="server" CssClass="field size1"></asp:TextBox>
                        </p>
                        <p>
                            <label>Quyền hạn</label>
                            <asp:DropDownList ID="drlLevel" runat="server">
                                <asp:ListItem Value="0">Thành viên</asp:ListItem>
                                <asp:ListItem Value="1">Quản trị viên</asp:ListItem>
                            </asp:DropDownList>
                        </p>
                    </div>
            <!-- End Form -->
            <!-- Form Buttons -->
            <div class="buttons">
                <asp:Button ID="btnXoa" runat="server" Text="Hủy thay đổi" CssClass="button" OnClick="btnXoa_Click" />
                <asp:Button ID="btnThem" runat="server" Text="Thêm người dùng" CssClass="auto-style3" OnClick="btnSua_Click" ForeColor="#00CC00" />
            </div>
            <!-- End Form Buttons -->
        </div>
            </div>
        </div>
    </div>
</asp:Content>
