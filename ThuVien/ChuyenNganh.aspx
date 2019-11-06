<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="ChuyenNganh.aspx.cs" Inherits="ThuVien.ChuyenNganh1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Tài liệu theo chuyên ngành -Thư viện</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Tài liệu theo chuyên ngành"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Tài liệu theo chuyên ngành" CssClass="title"></asp:Label>
    </div>
    <asp:DataList ID="dataTaiLieu" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
        <ItemTemplate>
            <div class="item_box">
                <div class="center_item_box">
                    <div class="item_img">
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "~/Tai-Lieu/"+Eval("TenChuanHoa")+"-"+Eval("IdTaiLieu") %>'>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Hinh") %>' ToolTip='<%# Eval("TenChuyenNganh") %>' />
                            </asp:HyperLink>
                    </div>
                    <p>Người đăng: <asp:Label ID="Label3" runat="server" Text='<%# Eval("UserName") %>' ForeColor="Red"></asp:Label></p>
                </div>
                <h5 class="content-tieude">
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("TenChuyenNganh") %>'></asp:Label>
                </h5>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

