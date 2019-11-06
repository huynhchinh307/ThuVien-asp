<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ThuVien.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập quản trị trang web</title>
    <style>
        .stylebtn {
            background: #288ad6;
            position: relative;
            line-height: 28px;
            font-size: 14px;
            color: #fff;
            border: 1px solid #288ad6;
            border-radius: 4px;
            margin-right: 5px;
            padding: 0 3.3%;
            text-align: center;
            cursor: pointer;
            top: 0px;
            left: 0px;
        }

        .left_box {
            background: url(../libs/images/left_box.png) no-repeat;
            width: 10px;
            height: 33px;
            float: left;
        }

        .right_box {
            background: url(../libs/images/right_box.png) no-repeat;
            width: 10px;
            height: 33px;
            float: left;
        }

        .bottombox_left {
            background: url(../libs/images/bottombox_left.png) no-repeat;
            width: 10px;
            height: 6px;
            float: left;
        }

        .bottombox_center {
            background: url(../libs/images/bottombox_center.gif) repeat-x;
            height: 6px;
            float: left;
        }

        .bottombox_right {
            background: url(../libs/images/bottombox_right.gif) no-repeat;
            width: 10px;
            height: 6px;
            float: left;
        }

        .box {
            background: url(../libs/images/box.jpg) repeat-x;
            width: 288px;
            float: left;
            height: 33px;
        }

        .title_box {
            font-family: Tahoma, Geneva, sans-serif;
            color: #ffffff;
            font-weight: bold;
            font-size: 15px !important;
            padding-top: 7px !important;
        }

        .auto-style1 {
            width: 40%;
            height: 30px;
        }

        .auto-style2 {
            width: 60%;
            height: 30px;
        }

        .auto-style3 {
            height: 25px;
        }

        .form-content {
            position: relative;
            margin: 13% auto;
            max-width: 408px;
        }
    </style>
</head>
<body>
    <div class="form-content">
        <div style="width: 408px; margin-right: 12px;">
            <div class="left_box">
            </div>
            <div style="width: 388px;" class="box">
                <div class="title_box" align="center">
                    Đăng nhập Quản Trị
                </div>
            </div>
            <div class="right_box">
            </div>
            <div style="background-color: #edeeef; float: left; width: 408px; padding-top: 19px; padding-bottom: 19px;">
                <form id="form1" runat ="server">
                    <asp:Label ID="lblthongbao" runat="server" Text=""></asp:Label>
                    <table id="Login1" cellspacing="0" cellpadding="0" border="0" style="width: 408px; border-collapse: collapse;">
                        <tr>
                            <td>
                                <table style="width: 100%;" align="center" cellpadding="4px;">
                                    <tr>
                                        <td class="auto-style1" align="right">Tên đăng nhập:
                                        </td>
                                        <td align="left" class="auto-style2">
                                            <asp:TextBox ID="txtUserName" runat="server" Style="width: 170px;"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Tên đăng nhập không được trống" Text="*" ControlToValidate="txtUserName" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 40%;" class="textinput" align="right">Mật khẩu:
                                        </td>
                                        <td style="width: 60%" align="left">
                                            <asp:TextBox ID="txtMatKhau" runat="server" class="login-pw" Style="width: 170px;" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Mật khẩu không đc trống" Text="*" ForeColor="Red" ControlToValidate="txtMatKhau"></asp:RequiredFieldValidator>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" align="center" class="auto-style3">
                                            <asp:CheckBox ID="ckbhien" runat="server" AutoPostBack="True" OnCheckedChanged="ckbhien_CheckedChanged" /><a class="textlink">Hiện mật khẩu</a> |
                                        <asp:HyperLink ID="Forgotpassword" runat="server" class="textlink">Quên mật khẩu?</asp:HyperLink>
                                        </td>
                                    </tr>
                                    <tr align="center">
                                        <td colspan="2">
                                            <img src="images/line.jpg" width="300" height="1" alt="" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" align="center">
                                            <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" class="stylebtn" OnClick="btnDangNhap_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </form>
            </div>
            <div class="bottombox_left">
            </div>
            <div style="width: 388px;" class="bottombox_center">
            </div>
            <div class="bottombox_right">
            </div>
        </div>
    </div>
</body>
</html>
