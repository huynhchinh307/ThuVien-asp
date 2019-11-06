<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ThuVien.Admin.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thư viện - Quản lý thư viên
    </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shell">
        <!-- Small Nav -->
        <div class="small-nav"><a href="#">Bảng điều khiển</a> <span>&gt;</span> Tổng Quan </div>
        <!-- End Small Nav -->
        <br />
        <!-- Main -->
        <div id="main">
            <div class="cl">&nbsp;</div>
            <div id="content">
                <!-- Box -->
                <div class="box">
                    <div class="box-head">
                        <h2 class="left">Danh sách sách chưa duyệt</h2>
                    </div>
                    <asp:GridView ID="dataSach" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="table" AllowPaging="True" OnPageIndexChanging="dataSach_PageIndexChanging" OnRowCommand="dataSach_RowCommand">
                        <Columns>
                            <asp:TemplateField>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="ID" DataField="IdSach" />
                            <asp:HyperLinkField DataNavigateUrlFields="TenChuanHoa,IdSach" DataNavigateUrlFormatString="~/Sach/{0}-{1}" DataTextField="TenSach" HeaderText="Tên sách">
                                <HeaderStyle Width="372px" />
                            </asp:HyperLinkField>
                            <asp:BoundField HeaderText="Người đăng" DataField="UserName">
                                <HeaderStyle Width="109px"  />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Control" HeaderStyle-Width="110px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="btnDuyet" runat="server" ImageUrl="~/libs/images/duyet.png" CommandName="Duyet" CommandArgument='<%# Eval("IDSach") %>' CausesValidation="false" OnClientClick='return confirm("Bạn muốn duyệt sách này chứ?");'/> 
                                    <asp:ImageButton ID="btnTuChoi" runat="server" ImageUrl="~/libs/images/tuchoi.png" CommandName="Xoa" CommandArgument='<%# Eval("IDSach") %>' CausesValidation="false" OnClientClick='return confirm("Bạn muốn từ chối sách này chứ?");' />
                                </ItemTemplate>
                                <HeaderStyle Width="150px"></HeaderStyle>
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle HorizontalAlign = "Right" CssClass ="pagging" />
                    </asp:GridView>
                </div>
                <div class="box">
                    <div class="box-head">
                        <h2 class="left">Danh sách tài liệu chưa duyệt</h2>
                    </div>
                    <asp:GridView ID="dataTaiLieu" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="table" AllowPaging="True" OnPageIndexChanging="dataTaiLieu_PageIndexChanging" OnRowCommand="dataTaiLieu_RowCommand">
                        <Columns>
                            <asp:TemplateField>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="ID" DataField="IdTaiLieu" />
                            <asp:HyperLinkField DataNavigateUrlFields="TenChuanHoa,IdTaiLieu" DataNavigateUrlFormatString="~/Tai-Lieu/{0}-{1}" DataTextField="TenTaiLieu" HeaderText="Tên tài liệu">
                                <HeaderStyle Width="372px" />
                            </asp:HyperLinkField>
                            <asp:BoundField HeaderText="Người đăng" DataField="UserName">
                                <HeaderStyle Width="109px"  />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Control" HeaderStyle-Width="110px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="btnDuyet" runat="server" ImageUrl="~/libs/images/duyet.png" CommandName="Duyet" CommandArgument='<%# Eval("IDTaiLieu") %>' CausesValidation="false" OnClientClick='return confirm("Bạn muốn duyệt tài liệu này chứ?");'/> 
                                    <asp:ImageButton ID="btnTuChoi" runat="server" ImageUrl="~/libs/images/tuchoi.png" CommandName="Xoa" CommandArgument='<%# Eval("IDTaiLieu") %>' CausesValidation="false" OnClientClick='return confirm("Bạn muốn từ chối duyệt tài liệu này chứ?");' />
                                </ItemTemplate>
                                <HeaderStyle Width="150px"></HeaderStyle>
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle HorizontalAlign = "Right" CssClass ="pagging" />
                    </asp:GridView>
                </div>
            </div>
            <!-- Sidebar -->
            <div id="sidebar">
                <!-- Box -->
                <div class="box">
                    <!-- Box Head -->
                    <div class="box-head">
                        <h2>Công Cụ</h2>
                    </div>
                    <!-- End Box Head-->
                    <div class="box-content">
                        <p><a href="#">Khôi phục dữ liệu</a></p>
                        <p><a href="#">Sao lưu dữ liệu</a></p>
                    </div>
                </div>
                <!-- End Box -->
            </div>
            <!-- End Sidebar -->
        </div>
    </div>
</asp:Content>
