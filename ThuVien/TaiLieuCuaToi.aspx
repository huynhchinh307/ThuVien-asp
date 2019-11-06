<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="TaiLieuCuaToi.aspx.cs" Inherits="ThuVien.TaiLieuCuaToi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Tài liệu của tôi -Thư viện</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Tài liệu của tôi"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Tài liệu của tôi" CssClass="title"></asp:Label>
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
    <asp:GridView ID="dataTaiLieuCuaToi" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="100%" AllowPaging="True" OnRowDataBound="dataTaiLieuCuaToi_RowDataBound" OnPageIndexChanging="dataTaiLieuCuaToi_PageIndexChanging">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="IDTaiLieu" />
            <asp:BoundField HeaderText="Tên tài liệu" DataField="TenTaiLieu"/>
            <asp:BoundField HeaderText="Tên chuyên ngành" DataField="TenChuyenNganh" />
            <asp:BoundField HeaderText="Trạng thái" DataField="TrangThai" />
            <asp:TemplateField HeaderText="Tùy chỉnh">
                <ItemTemplate>
                    <asp:ImageButton ID="btnDel" runat="server" ImageUrl="~/Admin/css/images/del.png" CommandName="Xoa" CommandArgument='<%# Eval("IDTaiLieu") %>' CausesValidation="false" OnClientClick='return confirm("Bạn chắc chắn muốn xóa chứ?");' />
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
