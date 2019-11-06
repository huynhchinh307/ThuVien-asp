<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="QLTaiLieu.aspx.cs" Inherits="ThuVien.Admin.QLTaiLieu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>ADMIN -Quản lý tài liệu</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shell">
        <!-- Small Nav -->
        <div class="small-nav"><a href="#">B</a>ảng điều kiển <span>&gt;</span> Quản lý tài liệu</div>
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
                        <h2 class="left">Danh sách Tài Liệu</h2>
                    </div>
                    <!-- End Box Head -->
                    <asp:GridView ID="data" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="table" AllowPaging="True" OnPageIndexChanging="data_PageIndexChanging" OnRowCommand="data_RowCommand">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="ckbChon" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="ID" DataField="IDTaiLieu" />
                            <asp:BoundField HeaderText="Tên Tài Liệu" DataField="TenTaiLieu" HeaderStyle-Width="100px" >
<HeaderStyle Width="350px"></HeaderStyle>
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Người viết" DataField="UserName" />
                            <asp:BoundField HeaderText="Chuyên Ngành" DataField="TenChuyenNganh" />
                            <asp:BoundField HeaderText="Trạng Thái" DataField="TrangThai" />
                            <asp:TemplateField HeaderText="Control">
                                <ItemTemplate>
                                    <asp:ImageButton ID="btnEdit" runat="server" ImageUrl="~/Admin/css/images/edit.png" CommandName="Sua" CommandArgument='<%# Eval("IDTaiLieu") %>'/> 
                                    <asp:ImageButton ID="btnDel" runat="server" ImageUrl="~/Admin/css/images/del.png" CommandName="Xoa" CommandArgument='<%# Eval("IDTaiLieu") %>' CausesValidation="false" OnClientClick='return confirm("Bạn chắc chắn muốn xóa chứ?");' />
                                </ItemTemplate>
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
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Admin/ThemTaiLieu.aspx"><img src="css/images/add.png" /></asp:HyperLink>
                        <div class="cl">&nbsp;</div>
                        <p class="select-all">
                            <asp:CheckBox ID="ckbChonAll" runat="server" CssClass="checkbox" Text="Chọn tất cả" AutoPostBack="True" OnCheckedChanged="ckbChonAll_CheckedChanged" />
                        </p>
                        <p>
                            <asp:Button ID="btnXoaAll" runat="server" Text="Xóa mục đang chọn" CssClass="button" ForeColor="Red" OnClick="btnXoaAll_Click" />
                        </p>
                    </div>
                    </div>
                        <!-- Sort -->
                    <div class="box">
                        <div class="box-head">
                            <h2 class="left">Mở rộng</h2>
                        </div>
                        <div class="box-content">
                            <p>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/QLChuyenNganh.aspx">Quản lý Chuyên Ngành</asp:HyperLink></p>
                        </div>
                        <!-- End Sort -->
                    </div>
                </div>
                <!-- End Box -->
            </div>
            <!-- End Sidebar -->
        </div>
   
</asp:Content>
