<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="QLTheLoaiSach.aspx.cs" Inherits="ThuVien.Admin.QLTheLoaiSach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>ADMIN -Quản lý thể loại sách</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shell">
        <!-- Small Nav -->
        <div class="small-nav"><a href="#">Bảng điều kiển</a<span>&gt;</span> Quản lý thể loại sách</div>
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
                        <h2 class="left">Danh sách thể loại sách</h2>
                    </div>
                    <!-- End Box Head -->
                    <asp:GridView ID="data" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="table" AllowPaging="True" OnPageIndexChanging="data_PageIndexChanging" OnRowCommand="data_RowCommand">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="ckbChon" runat="server" Width="50" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="ID" DataField="IDTheLoaiSach" HeaderStyle-Width="200px" />
                            <asp:BoundField HeaderText="Tên Thể Loại Sách" DataField="TenTheLoai" HeaderStyle-Width="200px" />
                            <asp:TemplateField HeaderText="Control" HeaderStyle-Width="200px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="btnEdit" runat="server" ImageUrl="~/Admin/css/images/edit.png" CommandName="Sua" CommandArgument='<%# Eval("IDTheLoaiSach") %>'/> 
                                    <asp:ImageButton ID="btnDel" runat="server" ImageUrl="~/Admin/css/images/del.png" CommandName="Xoa" CommandArgument='<%# Eval("IDTheLoaiSach") %>' CausesValidation="false" OnClientClick='return confirm("Bạn chắc chắn muốn xóa chứ?");' />
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
                    <div id="thongbao" runat="server" class="box-content">
                        <asp:Label ID="lblThongBao" runat="server" CssClass=""></asp:Label><br />
                        <label>Tên thể loại sách</label>
                        <br />
                        <asp:TextBox ID="txtTheLoaiSach" runat="server" Width="100%" CssClass="field size1"></asp:TextBox>
                        <br />
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Admin/css/images/add.png" OnClick="btnThem_click" />
                        <div class="cl">&nbsp;</div>
                        <p class="select-all">
                            <asp:CheckBox ID="ckbChonAll" runat="server" CssClass="checkbox" Text="Chọn tất cả" AutoPostBack="True" OnCheckedChanged="ckbChonAll_CheckedChanged" />
                        </p>
                        <p>
                            <asp:Button ID="btnXoaAll" runat="server" Text="Xóa mục đang chọn" CssClass="button" ForeColor="Red" OnClick="btnXoaAll_Click" />
                        </p>
                    </div>
                        <!-- Sort -->
                        <div class="box-head">
                        <h2>Update </h2>
                    </div>
                    <div  class="box-content">
                        <asp:Label ID="lblThongBao2" runat="server" CssClass=""></asp:Label><br />
                         <label>Tên thể loại sách</label> 
                         <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                         <br />
                        <asp:TextBox ID="txttheloaisach1" runat="server" Width="100%" CssClass="field size1"></asp:TextBox> <br />
                        <asp:Button ID="btnXoa" runat="server" Text="Sửa" CssClass="button" OnClick="btnSua_Click" />
                    </div>
                        <!-- End Sort -->
                    </div>
                </div>
                <!-- End Box -->
            </div>
            <!-- End Sidebar -->
        </div>
   
</asp:Content>
