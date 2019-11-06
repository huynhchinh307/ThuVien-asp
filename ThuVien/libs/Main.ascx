<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Main.ascx.cs" Inherits="ThuVien.libs.Main" %>
<%@ Register Src="~/libs/MenuChuyenMuc.ascx" TagPrefix="Main" TagName="MenuChuyenMuc" %>
<%@ Register Src="~/libs/TaiLieuMoi.ascx" TagPrefix="Main" TagName="TaiLieuMoi" %>


<div class="main-tailieu" style="padding-top: 20px;">
    <div class="row">
        <div class="col-md-8 block-left">
            <ul class="nav nav-tabs local-tab">
                <li class="active">
                    <a data-toggle="tab" href="#" aria-expanded="true">Tài liệu mới nhất
                    </a>
                </li>
            </ul>
            <div class="tab-content">
                <div id="tphcm" class="tab-pane fade active in">
                    <div class="list-all-new">
                        <div class="news-item item-vip1">
                            <div class="news-thumb">
                                <a href="/phong-tro/151527/phong-cao-cap-moi-xay-thang-may-ham-xe-24-24-q-tan-binh-cua-so-gac-toilet-phoi-do-rieng.html">
                                    <img src="https://static.thuephongtro.com/Uploads/Images/Thumb/20181128010524-View-1.jpg" alt="">
                                </a>
                                <div class="icons">VIP</div>

                            </div>
                            <div class="news-info">
                                <h3 class="news-title">
                                    <a href="/phong-tro/151527/phong-cao-cap-moi-xay-thang-may-ham-xe-24-24-q-tan-binh-cua-so-gac-toilet-phoi-do-rieng.html" title="Phòng Cao Cấp. Mới xây. Thang máy. Hầm xe 24/24. Q. Tân Bình. Cửa sổ  gác  toilet  phơi đồ riêng">Phòng Cao Cấp. Mới xây. Thang máy. Hầm xe 24/24. Q. Tân Bình. Cửa sổ  gác  toilet  phơi đồ riêng</a>
                                </h3>
                                <div class="room-detail">
                                    <div class="localtion">
                                        Khu vực: <b>Tân Bình</b> <span class="mgl-10">Diện tích: <b>20m<sup>2</sup></b></span>
                                        <div class="room-detail-item">
                                            <span class="time">28/11/2018</span>
                                        </div>
                                    </div>
                                </div>
                                <div class="price"><span>CÔNG NGHỆ THÔNG TIN</span></div>
                                <div class="news-desc">Nội thất cao cấp có gác bếp riêng cửa sổ thông thoáng. Chỗ phơi đồ chung &amp; riêng trong phòng. Tùy chọn nước thủy cục/nước máy. Wifi mạnh thang máy hiện đại hầm xe rộng. Mở cửa 24/24. Vừa xây xong còn mới 100%. Vị trí ngay trung tâm đi</div>
                            </div>
                        </div>
                    </div>
                </div>
                <%--<div class="paging-container">
                <ul class="pagination">
                    <li class="active"><a href="javascript:void(0)">1</a></li><li><a href="?p=2">2</a></li><li><a href="?p=3">3</a></li><li><a href="?p=4">4</a></li><li><a href="?p=5">5</a></li><li><a href="?p=2">»</a></li>
                </ul>
            </div>--%>
            </div>
        </div>
        <div class="col-md-4 sidebar-right">
            <!-- Tài liệu mới -->
            <Main:TaiLieuMoi runat="server" id="TaiLieuMoi" />
            <!-- Chuyên mục -->
            <Main:MenuChuyenMuc runat="server" ID="MenuChuyenMuc" />
            <!-- Thống Kê -->
            <%--<div class="sidebar-box">
                    <h3 class="sidebarbox-title">
                        <span><i class="fa fa-bars"></i>Cộng đồng</span>
                    </h3>
                    <div class="sidebarbox-body">
                        <div class="fanpage-box">
                            <iframe src="https://www.facebook.com/plugins/page.php?href=https%3A%2F%2Fwww.facebook.com%2Ftimnhatro%2F&amp;tabs=timeline&amp;width=360&amp;height=210&amp;small_header=false&amp;adapt_container_width=true&amp;hide_cover=false&amp;show_facepile=true&amp;appId=131375914163212" width="100%" height="200" style="border:none;overflow:hidden" scrolling="no" frameborder="0" allowtransparency="true" allow="encrypted-media"></iframe>
                        </div>
                    </div>
                </div>--%>
        </div>
    </div>
</div>