<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="ChiTietBaiViet.aspx.cs" Inherits="ThuVien.ChiTietBaiViet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Chi tiết bài viết -Thư viện</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Chi tiết bài viết"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <asp:DataList ID="dataBaiViet" runat="server" Width="100%">
        <ItemTemplate>
            <h1 class="title-baiviet">
                <asp:Label ID="lblTenBaiViet" runat="server" Text='<%# Eval("TenBaiViet") %>'></asp:Label>
            </h1>
            <hr />
            <div class="menu-baiviet">
                <asp:Label ID="lblNguoiViet" runat="server" Text='<%# "Người viết: "+Eval("TenNguoiDung") %>' Style="float: left; margin-left: 10px;"></asp:Label>
                <asp:Label ID="lblDate" runat="server" Text='<%# DateTime.Parse(Eval("ThoiGian").ToString()).ToString("dd-MM-yyyy") %>' Style="float: right; margin-right: 10px;"></asp:Label>
            </div>
            <hr />
            <div class="noidung-baiviet">
                <asp:Label ID="lblNoiDung" runat="server" Text='<%# Eval("NoiDung") %>'></asp:Label>
            </div>
        </ItemTemplate>
    </asp:DataList>
    
    <hr />
    
</asp:Content>