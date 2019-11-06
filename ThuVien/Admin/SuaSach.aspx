<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SuaSach.aspx.cs" Inherits="ThuVien.Admin.SuaSach" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thư viện - Thêm Sách</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shell">
        <!-- Small Nav -->
        <div class="small-nav"><a href="#">Bảng điều khiển</a> <span>&gt;</span> Quản lý sách </div>
        <!-- End Small Nav -->
        <br />
        <!-- Main -->
        <div id="main">
            <div class="cl">&nbsp;</div>
            <div id="content2">
                <!-- Box -->
                <div class="box">
          <!-- Box Head -->
          <div class="box-head">
            <h2>Thêm sách</h2>
          </div>
          <!-- End Box Head -->
            <!-- Form -->
                    <div class="form">
                        <div id="thongbao" runat="server">
                            <p>
                                <asp:Label ID="lblThongBao" runat="server" CssClass=""></asp:Label>
                            </p>
                        </div>
                        <p>
                            <span class="req">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Tiêu đề không được bỏ trống!" ForeColor="Red" ControlToValidate="txtTieuDe"></asp:RequiredFieldValidator></span>
                            <label>Tiêu đề</label>
                            <asp:TextBox ID="txtTieuDe" runat="server" CssClass="field size1"></asp:TextBox>
                        </p>
                        <p>
                            <span class="req">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Tác giả không được bỏ trống!" ForeColor="Red" ControlToValidate="txtTacGia"></asp:RequiredFieldValidator></span>
                            <label>Tác giả</label>
                            <asp:TextBox ID="txtTacGia" runat="server" CssClass="field size1"></asp:TextBox>
                        </p>
                        <p>
                            <span class="req">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Tên file không được bỏ trống!" ForeColor="Red" ControlToValidate="txtTenFile"></asp:RequiredFieldValidator></span>
                            <label>Tên file</label>
                            <asp:TextBox ID="txtTenFile" runat="server" CssClass="field size1"></asp:TextBox>
                        </p>
                        <p>
                             <label>Thể loại sách</label>
                             <asp:DropDownList ID="drpTheLoaiSach" runat="server">
                             </asp:DropDownList>
                            <label>Hinh</label>
                            <asp:Image ID="Image1" runat="server" Width="180px" />
                             <asp:FileUpload ID="FileUpload1" runat="server" />
                             <label>Nhà xuất bản</label>
                             <asp:DropDownList ID="drpNhaXuatBan" runat="server">
                             </asp:DropDownList>
                        </p>
                        <p>
                            <span class="req">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Mô tả không được bỏ trống!" ForeColor="Red" ControlToValidate="txtMoTa"></asp:RequiredFieldValidator></span>
                            <label>Mô tả</label>
                            <CKEditor:CKEditorControl ID="txtMoTa" runat="server"></CKEditor:CKEditorControl>
                        </p>
                    </div>
            <!-- End Form -->
            <!-- Form Buttons -->
            <div class="buttons">
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" CssClass="button" OnClick="btnXoa_Click" />
                <asp:Button ID="btnSuaBai" runat="server" Text="Sửa Sách" CssClass="button" OnClick="btnSuaSach_Click" />
            </div>
            <!-- End Form Buttons -->
        </div>
            </div>
        </div>
    </div>
</asp:Content>
