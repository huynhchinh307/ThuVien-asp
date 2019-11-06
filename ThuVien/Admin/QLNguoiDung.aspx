<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="QLNguoiDung.aspx.cs" Inherits="ThuVien.Admin.QLNguoiDung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thư viện - Quản lý người dùng</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shell">
        <!-- Small Nav -->
        <div class="small-nav"><a href="#">Bảng điều khiển</a> <span>&gt;</span> Quản lý người dùng </div>
        <!-- End Small Nav -->
        <br />
        <!-- Main -->
        <div id="main">
            <div class="cl">&nbsp;</div>
            <div id="content">
                <!-- Box -->
                <div class="box">
                    <!-- Box Head -->
                    <div class="box-head">
                        <h2 class="left">Danh sách người dùng</h2>
                    </div>
                    <!-- End Box Head -->
                    <asp:GridView ID="data" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="table" AllowPaging="True" OnPageIndexChanging="data_PageIndexChanging" OnRowCommand="data_RowCommand">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="ckbChon" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="ID" DataField="IdNguoiDung" />
                            <asp:BoundField HeaderText="UserName" DataField="UserName">
                                <HeaderStyle Width="80px" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Họ Tên" DataField="TenNguoiDung">
                                <HeaderStyle Width="180px" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Email" DataField="Email">
                                <HeaderStyle Width="139px" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Quyền" DataField="Level" />
                            <asp:TemplateField HeaderText="Control" HeaderStyle-Width="110px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="btnEdit" runat="server" ImageUrl="~/Admin/css/images/edit.png" CommandName="Sua" CommandArgument='<%# Eval("UserName") %>'/> 
                                    <asp:ImageButton ID="btnDel" runat="server" ImageUrl="~/Admin/css/images/del.png" CommandName="Xoa" CommandArgument='<%# Eval("UserName") %>' CausesValidation="false" OnClientClick='return confirm("Bạn chắc chắn muốn xóa chứ?");' />
                                </ItemTemplate>

                                <HeaderStyle Width="110px"></HeaderStyle>
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
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/ThemNguoiDung.aspx"><img src="css/images/add.png" /></asp:HyperLink>
                        <div class="cl">&nbsp;</div>
                        <p class="select-all">
                            <asp:CheckBox ID="ckbChonAll" runat="server" CssClass="checkbox" Text="Chọn tất cả" AutoPostBack="True" OnCheckedChanged="ckbChonAll_CheckedChanged" />
                        </p>
                        <p>
                            <asp:Button ID="btnXoaAll" runat="server" Text="Xóa mục đang chọn" CssClass="button" ForeColor="Red" OnClick="btnXoaAll_Click" />
                            </p>
                    </div>
                </div>
                <!-- End Box -->
            </div>
            <!-- End Sidebar -->
        </div>
    </div>
</asp:Content>
