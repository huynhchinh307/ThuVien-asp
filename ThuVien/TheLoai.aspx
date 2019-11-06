<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="TheLoai.aspx.cs" Inherits="ThuVien.TheLoai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thể Loại Sách -Thư viện</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Thể Loại Sách"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Sách Theo Thể Loại" CssClass="title"></asp:Label>
    </div>
    <asp:DataList ID="dataSach" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
        <ItemTemplate>
            <div class="item_box">
                <div class="center_item_box">
                    <div class="item_img">
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "~/Sach/"+Eval("TenChuanHoa")+"-"+Eval("IdSach") %>'>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Hinh") %>' ToolTip='<%# Eval("TenSach") %>' />
                            </asp:HyperLink>
                    </div>
                    <p>Người đăng: <asp:Label ID="Label3" runat="server" Text='<%# Eval("UserName") %>' ForeColor="Red"></asp:Label></p>
                </div>
                <h5 class="content-tieude">
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("TenSach") %>'></asp:Label>
                </h5>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
