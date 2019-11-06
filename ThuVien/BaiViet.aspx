<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="BaiViet.aspx.cs" Inherits="ThuVien.BaiViet1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Bài viết -Thư viện</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Trang chủ"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Tất cả bài viết" CssClass="title"></asp:Label>
    </div>
    <div>
        <asp:DataList ID="dataBaiViet" runat="server" Width="100%">
            <ItemTemplate>
                <div class="title-list-baiviet">
                    <asp:Label ID="lblTenBaiViet" runat="server" Text='<%# Eval("TenBaiViet") %>'></asp:Label> 
                </div>
                <div class="menu-list-baiviet">
                    <asp:Label ID="lblNguoiViet" runat="server" Text='<%# "Viết bởi: "+Eval("TenNguoiDung") %>' style="padding-left: 10px;"></asp:Label>
                    <asp:Label ID="lblThoiGian" runat="server" Text='<%# DateTime.Parse(Eval("ThoiGian").ToString()).ToString("dd-MM-yyyy") %>' style="padding-right: 10px; float: right"></asp:Label>
                </div>
                <div class="noidung-list-baiviet">
                    <asp:Label ID="lblNoiDung" runat="server" Text='<%# Eval("NoiDung") %>'></asp:Label>
                </div>
                <div class="btn-list-baiviet">
                    <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/libs/images/View.png" NavigateUrl='<%# "~/Tin-Tuc/"+Eval("TenChuanHoa")+"-"+Eval("IdBaiViet") %>'>HyperLink</asp:HyperLink>
                </div>
                <hr />
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div>

    </div>
</asp:Content>
