<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="ChiTietSach.aspx.cs" Inherits="ThuVien.ChiTietSach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Chi tiết sách</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Chi tiết sách"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <asp:DataList ID="dataChiTiet" runat="server">
        <ItemTemplate>
            <div style="padding: 15px;">
                <div class="post_summary_wrapper">
                    <div class="post_summary-header"><b>Thông tin chung</b></div>
                    <div class="post_summary_left">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Hinh") %>' Width="280px" />
                    </div>
                    <div class="post_summary_right">
                        <div>
                            <h1 class="title-details">
                                <asp:Label ID="lblTenSach" runat="server" Text='<%# Eval("TenSach") %>'></asp:Label>
                            </h1>
                        </div>
                        <div style="padding-bottom: 20px;">
                            Người đăng:    
                            <asp:Label ID="lblNguoiDang" runat="server" Text='<%# Eval("UserName") %>'></asp:Label><br />
                            Tác giả:    
                            <asp:Label ID="lblTacGia" runat="server" Text='<%# Eval("TacGia") %>'></asp:Label><br />
                            Thể loại:  
                            <asp:Label ID="lblTheLoai" runat="server" Text='<%# Eval("TenTheLoai") %>'></asp:Label><br />
                            Nhà xuất bản:  
                            <asp:Label ID="lblNhaXuatBan" runat="server" Text='<%# Eval("TenNhaXuatBan") %>'></asp:Label>
                        </div>
                        <div style="padding-top: 40px; text-align: center;">
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("TenFile") %>' ImageUrl="~/libs/images/taive.png">Tải xuống</asp:HyperLink>
                        </div>
                    </div>
                </div>
                <div style="clear: both"></div>
                <div class="post_summary_wrapper">
                    <div class="post_summary-header">
                        <label><b>Mô tả</b></label>
                    </div>
                    <div class="post_summary-content">
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
                    </div>
                </div>
            </div>
        </ItemTemplate>

    </asp:DataList>
</asp:Content>
