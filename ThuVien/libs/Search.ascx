<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search.ascx.cs" Inherits="ThuVien.libs.Search" %>
<div class="searchbar_top hidden-xs">
    <div class="searchbar_top_body">
        <form action="/tim-kiem.html" method="GET" name="frmSearch" id="frmSearch" abineguid="B96DB2A2E05449B490EF92D3643D6442">
            <div class="box-search">
                <h3 class="title">Tìm kiếm nhanh</h3>
                <div class="bs-content">
                    <div class="row">
                        <div class="col-md-2">
                            <asp:DropDownList ID="DropDownList1" runat="server" tabindex="-1" aria-hidden="true" CssClass="form-control select2-hidden-accessible"></asp:DropDownList>
                            <span class="select2 select2-container select2-container--default select2-container--below" dir="ltr" style="width: 151.656px;"><span class="selection"><span class="select2-selection select2-selection--single" role="combobox" aria-autocomplete="list" aria-haspopup="true" aria-expanded="false" tabindex="0" aria-labelledby="select2-ddlCategory-container"><span class="select2-selection__rendered" id="select2-ddlCategory-container" title="Cho thuê phòng trọ">Cho thuê phòng trọ</span><span class="select2-selection__arrow" role="presentation"><b role="presentation"></b></span></span></span><span class="dropdown-wrapper" aria-hidden="true"></span></span>
                        </div>
                        <div class="col-md-2">
                            <select id="ddlProvince" name="province" class="form-control select2-hidden-accessible" tabindex="-1" aria-hidden="true">
                                <option value="">Tỉnh/Thành phố</option>
                                &gt;
                            </select><span class="select2 select2-container select2-container--default select2-container--below" dir="ltr" style="width: 151.094px;"><span class="selection"><span class="select2-selection select2-selection--single" role="combobox" aria-autocomplete="list" aria-haspopup="true" aria-expanded="false" tabindex="0" aria-labelledby="select2-ddlProvince-container"><span class="select2-selection__rendered" id="select2-ddlProvince-container" title="TP Hồ Chí Minh">TP Hồ Chí Minh</span><span class="select2-selection__arrow" role="presentation"><b role="presentation"></b></span></span></span><span class="dropdown-wrapper" aria-hidden="true"></span></span>
                        </div>
                        <div class="col-md-2">
                            <select id="ddlDistrict" name="district" class="form-control select2-hidden-accessible" tabindex="-1" aria-hidden="true">
                                <option value="">Quận/Huyện</option>
                            </select><span class="select2 select2-container select2-container--default" dir="ltr" style="width: 150.281px;"><span class="selection"><span class="select2-selection select2-selection--single" role="combobox" aria-autocomplete="list" aria-haspopup="true" aria-expanded="false" tabindex="0" aria-labelledby="select2-ddlDistrict-container"><span class="select2-selection__rendered" id="select2-ddlDistrict-container" title="Quận/Huyện">Quận/Huyện</span><span class="select2-selection__arrow" role="presentation"><b role="presentation"></b></span></span></span><span class="dropdown-wrapper" aria-hidden="true"></span></span>
                        </div>
                        <div class="col-md-2">
                            <select id="ddlArea" name="area" class="form-control select2-hidden-accessible" tabindex="-1" aria-hidden="true">
                                <option value="">Diện tích</option>

                                <option value="0-20">&lt;20 m2</option>
                                <option value="20-40">20 - 40 m2</option>
                                <option value="40-80">40 - 80 m2</option>
                                <option value="80-100">80 - 100 m2</option>
                                <option value="100">&gt;100 m2</option>

                            </select><span class="select2 select2-container select2-container--default" dir="ltr" style="width: 151.656px;"><span class="selection"><span class="select2-selection select2-selection--single" role="combobox" aria-autocomplete="list" aria-haspopup="true" aria-expanded="false" tabindex="0" aria-labelledby="select2-ddlArea-container"><span class="select2-selection__rendered" id="select2-ddlArea-container" title="Diện tích">Diện tích</span><span class="select2-selection__arrow" role="presentation"><b role="presentation"></b></span></span></span><span class="dropdown-wrapper" aria-hidden="true"></span></span>
                        </div>
                        <div class="col-md-2">
                            <select id="ddlPrice" name="price" class="form-control select2-hidden-accessible" tabindex="-1" aria-hidden="true">

                            </select><span class="select2 select2-container select2-container--default" dir="ltr" style="width: 151.656px;"><span class="selection"><span class="select2-selection select2-selection--single" role="combobox" aria-autocomplete="list" aria-haspopup="true" aria-expanded="false" tabindex="0" aria-labelledby="select2-ddlPrice-container"><span class="select2-selection__rendered" id="select2-ddlPrice-container" title="Mức giá">Mức giá</span><span class="select2-selection__arrow" role="presentation"><b role="presentation"></b></span></span></span><span class="dropdown-wrapper" aria-hidden="true"></span></span>
                        </div>
                        <div class="col-md-2">
                            <div class="bs-item" id="KeyDownEnterHome" style="background: none;">
                                <input class="form-control" name="id" type="text" placeholder="Tìm theo mã số tin">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="bs-search">
                    <asp:Button ID="btnTim" runat="server" Text="Tìm ngay" CssClass="btn btn-warning btn-block" />
                </div>
            </div>
        </form>
    </div>
</div>
 <div class="clearfix"></div>









