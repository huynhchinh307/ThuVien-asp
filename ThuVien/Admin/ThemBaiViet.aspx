<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ThemBaiViet.aspx.cs" Inherits="ThuVien.Admin.ThemBaiViet" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thư viện - Thêm Bài Viết</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shell">
        <!-- Small Nav -->
        <div class="small-nav"><a href="#">Bảng điều khiển</a> <span>&gt;</span> Quản lý bài viết </div>
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
            <h2>Thêm bài viết</h2>
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
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Nội dung không được bỏ trống!" ForeColor="Red" ControlToValidate="txtNoiDung"></asp:RequiredFieldValidator></span>
                            <label>Nội dung</label>
                            <CKEditor:CKEditorControl ID="txtNoiDung" runat="server"></CKEditor:CKEditorControl>
                        </p>
                    </div>
            <!-- End Form -->
            <!-- Form Buttons -->
            <div class="buttons">
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" CssClass="button" OnClick="btnXoa_Click" />
                <asp:Button ID="btnDangBai" runat="server" Text="Đăng bài viết" CssClass="button" OnClick="btnDangBai_Click" />
            </div>
            <!-- End Form Buttons -->
        </div>
            </div>
        </div>
    </div>
</asp:Content>
