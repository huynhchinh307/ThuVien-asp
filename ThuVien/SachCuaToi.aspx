<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="SachCuaToi.aspx.cs" Inherits="ThuVien.SachCuaToi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sách của tôi -Thư viện</title>
    <style type="text/css">
        .auto-style1 {
            height: 41px;
            border-bottom: 1px solid #e2d8c7;
            line-height: 40px;
            position: relative;
            font-size: 20px;
            left: -10px;
            top: -245px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Sách của tôi"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Sách của tôi" CssClass="title"></asp:Label>
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
    <asp:GridView ID="dataSachCuaToi" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="100%" AllowPaging="True" OnRowDataBound="dataSachCuaToi_RowDataBound" OnRowCommand="dataSachCuaToi_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="IDSach" />
            <asp:BoundField HeaderText="Tên sách" DataField="TenSach"/>
            <asp:BoundField HeaderText="Tác giả" DataField="TacGia" />
            <asp:BoundField HeaderText="Thể loại" DataField="TenTheLoai" />
            <asp:BoundField HeaderText="Nhà xuất bản" DataField="TenNhaXuatBan" />
            <asp:BoundField HeaderText="Trạng thái" DataField="TrangThai" />
            <asp:TemplateField HeaderText="Tùy chỉnh">
                <ItemTemplate>
                    <asp:ImageButton ID="btnDel" runat="server" ImageUrl="~/Admin/css/images/del.png" CommandName="Xoa" CommandArgument='<%# Eval("IdSach") %>' CausesValidation="false" OnClientClick='return confirm("Bạn chắc chắn muốn xóa chứ?");' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#f0ecdd" Font-Bold="True" ForeColor="#7E592A" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
        <PagerStyle HorizontalAlign = "Right" CssClass ="pagging" />
    </asp:GridView>
</asp:Content>