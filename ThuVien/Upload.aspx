<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="ThuVien.Upload" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Tải lên -Thư viện</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Tải lên"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="center_title_bar">
        <asp:Label ID="Label2" runat="server" Text="Tải tệp tin lên" CssClass="title"></asp:Label>
    </div>

    <hr />
    <h2>
        <asp:Label ID="lblThongBao" runat="server" Text="" style="text-align: center; color: red;"></asp:Label>
    </h2>
    <div class="form-upload">
        <asp:MultiView ID="upload" runat="server">
            <asp:View ID="View1" runat="server">
                <div>
                    <h4>Chọn loại upload</h4>
                    <div>
                        <asp:ImageButton ID="btnViewSach" runat="server" ImageUrl="~/libs/images/btnDangSach.png" CausesValidation="False" OnClick="btnViewSach_Click" ValidateRequestMode="Disabled" />
                        <asp:ImageButton ID="btnViewTaiLieu" runat="server" ImageUrl="~/libs/images/btnDangTaiLieu.png" CausesValidation="False" OnClick="btnViewTaiLieu_Click" ValidateRequestMode="Disabled" />
                    </div>
                    <div class="form-group">
                        <asp:Image ID="imgHinh" runat="server" ImageUrl="~/Uploads/document.png" Width="150px" />
                        <asp:FileUpload ID="fHinh" runat="server"/>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fHinh" ForeColor="Red" ErrorMessage="Bạn chưa chọn hình!"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Tên sách:</label>
                        <asp:TextBox ID="txtTenSach" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Tên sách không được để trống!" ControlToValidate="txtTenSach" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Tác giả: </label>
                        <asp:TextBox ID="txtTacGia" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Tác giả không được để trống!" ControlToValidate="txtTacGia" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Thể loại sách: </label>
                        <asp:DropDownList ID="drpTheLoaiSach" runat="server" CssClass="form-drp"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Nhà xuất bản: </label>
                        <asp:DropDownList ID="drpNhaXuatBan" runat="server" CssClass="form-drp"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Mô tả: </label>
                        <CKEditor:CKEditorControl ID="txtMoTaSach" runat="server"></CKEditor:CKEditorControl>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Mô tả sách không được để trống" ControlToValidate="txtMoTaSach" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Chọn file: </label>
                        <asp:FileUpload ID="fSach" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Bạn chưa chọn file!" ControlToValidate="fSach" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:ImageButton ID="btnUploadSach" runat="server" ImageUrl="~/libs/images/Upload.png" OnClick="btnUploadSach_Click" />
                    </div>
                </div>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <div>
                    <h4>Chọn loại upload</h4>
                    <div class="form-group">
                        <asp:ImageButton ID="btnViewSach2" runat="server" ImageUrl="~/libs/images/btnDangSach.png" CausesValidation="False" OnClick="btnViewSach_Click" ValidateRequestMode="Disabled" />
                        <asp:ImageButton ID="btnViewTaiLieu2" runat="server" ImageUrl="~/libs/images/btnDangTaiLieu.png" CausesValidation="False" OnClick="btnViewTaiLieu_Click" ValidateRequestMode="Disabled" />
                    </div>
                    <div class="form-group">
                        <asp:Image ID="imgHinh2" runat="server" ImageUrl="~/Uploads/document.png" Width="150px" />
                        <asp:FileUpload ID="fHinh2" runat="server"/>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Hình không được bỏ trống!" ControlToValidate="fHinh2" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Tên tài liệu: </label>
                        <asp:TextBox ID="txtTenTaiLieu" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Tên tài liệu không được bỏ trống!" ControlToValidate="txtTenTaiLieu" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Chuyên ngành: </label>
                        <asp:DropDownList ID="drpChuyenNganh" runat="server" CssClass="form-drp"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Mô tả: </label>
                        <CKEditor:CKEditorControl ID="txtMoTaTaiLieu" runat="server"></CKEditor:CKEditorControl>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Mô tả không được bỏ trống!" ControlToValidate="txtMoTaTaiLieu" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Chọn file: </label>
                        <asp:FileUpload ID="fTaiLieu" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Bạn chưa chọn file, hoặc file không hợp lệ" ControlToValidate="fTaiLieu" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:ImageButton ID="btnTaiLieu" runat="server" ImageUrl="~/libs/images/Upload.png" OnClick="btnTaiLieu_Click" />
                    </div>
                </div>
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>
