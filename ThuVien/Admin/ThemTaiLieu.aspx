<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ThemTaiLieu.aspx.cs" Inherits="ThuVien.Admin.ThemTaiLieu" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thư viện - Thêm tài liệu</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shell">
        <!-- Small Nav -->
        <div class="small-nav"><a href="#">Bảng điều khiển</a> <span>&gt;</span> Quản lý tài liệu </div>
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
            <h2>Thêm tài liệu</h2>
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
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Bạn chưa chọn file!" ForeColor="Red" ControlToValidate="ffile"></asp:RequiredFieldValidator></span>
                            <label>Tên file</label>
                             <asp:FileUpload ID="ffile" runat="server" />
                        </p>
                        <p>
                             <label>Chuyên ngành</label>
                             <asp:DropDownList ID="drpChuyenNganh" runat="server">
                             </asp:DropDownList>
                        </p>
                        <p>
                            <span class="req">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Bạn chưa chọn hình!" ForeColor="Red" ControlToValidate="fhinh"></asp:RequiredFieldValidator></span>
                            <label>Hình</label>
                             <asp:FileUpload ID="fhinh" runat="server" />
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
                <asp:Button ID="btnDangBai" runat="server" Text="Đăng Tài Liệu" CssClass="button" OnClick="btnDangTaiLieu_Click" />
            </div>
            <!-- End Form Buttons -->
        </div>
            </div>
        </div>
    </div>
</asp:Content>
