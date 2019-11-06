<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Upload.ascx.cs" Inherits="ThuVien.libs.WebUserControl1" %>
<table class="upload-result" id="uploadResult">
    <tbody id="p1ctrbllcn41s1v808p3pht1i064" data-data="0 0" class="odd" data-id="5178649">
        <tr class="tr_processBar" id="abId0.5049964884207911">
            <td colspan="2" id="abId0.8703771891828636">
                <div class="upload-process-text">100% tải lên &nbsp;•&nbsp; Data.docx</div>
                <div class="upload-process">
                    <div class="upload-process-bar"></div>
                </div>
                <input class="cb_saveAll" checked="" type="checkbox" value="5178649" name="docName_saveAll[]" onclick="checkSaveAll(this)">
                <input type="hidden" class="user_id" name="user_id" value="4244073">
                <input type="hidden" class="code" name="code" value="53c885dfde83a699eea9a3a30d503339">
                <div class="tr_docName_saveAll" id="abId0.054494467727928875" abineguid="ADB3AAE057B545C7940D4F866DF5C6B7">
                    <label for="txtName-5178649">Tên tài liệu: </label>
                    <input type="text" placeholder="Tiêu đề phải dài hơn 20 kí tự." class="txt-name" id="txtName-5178649" value="Data " onblur="suggestWords(this)">
                </div>
            </td>
        </tr>
        <tr class="tr_info">
            <td class="colum_left">
                <div class="change_avarta_doc"><a href="javascript:;" class="change_avatar">
                    <img id="docImg_5178649" alt="Data " src="https://media.store123doc.com/images/web_2/bg_changeImg.jpg"></a>
                    <form class="form" name="step_2" id="step_5178649" action="/documents/ajax/aja_avatar_document.php" method="POST" enctype="multipart/form-data">
                        <input type="hidden" name="doc_path" value="">
                        <input type="hidden" name="doc_id" value="5178649">
                        <input type="hidden" id="x" name="x">
                        <input type="hidden" id="y" name="y">
                        <input type="hidden" id="w" name="w">
                        <input type="hidden" id="h" name="h">
                        <input type="file" class="input_avatar" name="image" id="image" accept="image/*" onchange="previewAvatarDocumentUpload(5178649, this, 2000000)">
                        <a href="javascript://" class="edit_avatar"></a></form>
                    <input type="hidden" id="txtImage-5178649" value="">
                </div>
            </td>
            <td class="colum_right">
                <table class="tbl_info_document" data-id="5178649">
                    <tbody id="abId0.11723444948400696">
                        <tr id="abId0.2103965631546343">
                            <td class="info-th">
                                <label for="txtName-5178649">Tên tài liệu<i class="i_req">(*)</i></label></td>
                            <td id="abId0.9308951831445611" abineguid="7B198C28D9F744698A1697E5CE78D8F7">
                                <input type="text" placeholder="Tiêu đề phải dài hơn 20 kí tự." class="txt-name" id="txtName-5178649" value="Data " onblur="suggestWords(this)">
                            </td>
                        </tr>
                        <tr>
                            <td class="info-th">
                                <label for="selFirstCat-5178649"></label>
                            </td>
                            <td>
                                <select class="opts-cat selCat1" data-next=".selCat2" id="selFirstCat-5178649">
                                    <option value="-1">- Danh mục - </option>
                                    <option value="169">Luận Văn - Báo Cáo</option>
                                    <option value="154">Kỹ Năng Mềm</option>
                                    <option value="672">Mẫu Slide</option>
                                    <option value="35">Kinh Doanh - Tiếp Thị</option>
                                    <option value="44">Kinh Tế - Quản Lý</option>
                                    <option value="54">Tài Chính - Ngân Hàng</option>
                                    <option value="49">Biểu Mẫu - Văn Bản</option>
                                    <option value="99">Giáo Dục - Đào Tạo</option>
                                    <option value="284">Giáo án - Bài giảng</option>
                                    <option value="62">Công Nghệ Thông Tin</option>
                                    <option value="85">Kỹ Thuật - Công Nghệ</option>
                                    <option value="73">Ngoại Ngữ</option>
                                    <option value="93">Khoa Học Tự Nhiên</option>
                                    <option value="121">Y Tế - Sức Khỏe</option>
                                    <option value="104">Văn Hóa - Nghệ Thuật</option>
                                    <option value="165">Nông - Lâm - Ngư</option>
                                    <option value="186">Thể loại khác</option>
                                </select>
                                <select class="opts-cat selCat2" data-next=".selCat3" disabled="disabled"></select>
                                <select class="opts-cat selCat3 hidden" data-next=".selCat4"></select>
                                <select class="opts-cat selCat4 hidden" data-next="end"></select>
                            </td>
                        </tr>
                        <tr id="abId0.7061757908971733">
                            <td class="info-th">
                                <label for="txtKeyword-5178649">Từ khóa <i class="i_req">(*)</i></label></td>
                            <td id="abId0.0889124927111209">
                                <div class="tags" data-wmin="100" data-wmax="538" id="abId0.16504493426246292" abineguid="C4DFFC7B4C95430C8C67EDE771E4CCF5">
                                    <ul class="list-tag"></ul>
                                    <input class="text-input-tag" id="txtKeyword-5178649" data-tag="true" type="text" name="" placeholder="Từ khóa">
                                    <ul class="list-result" style="display: none;"></ul>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <div class="suggest_words">
                                    <ul>
                                        <li onclick="addWord(this)" data-id="87712"><a>database</a></li>
                                        <li onclick="addWord(this)" data-id="110078"><a>control data</a></li>
                                        <li onclick="addWord(this)" data-id="110170"><a>data analysis</a></li>
                                        <li onclick="addWord(this)" data-id="110770"><a>database</a></li>
                                        <li onclick="addWord(this)" data-id="111551"><a>data</a></li>
                                        <li onclick="addWord(this)" data-id="111818"><a>data widgets</a></li>
                                        <li onclick="addWord(this)" data-id="111931"><a>dataming</a></li>
                                        <li onclick="addWord(this)" data-id="111962"><a>oracle database</a></li>
                                        <li onclick="addWord(this)" data-id="111971"><a>data intergrity</a></li>
                                        <li onclick="addWord(this)" data-id="112777"><a>data</a></li>
                                    </ul>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td class="info-th default-head">
                                <label for="txtDes-5178649">Mô tả</label></td>
                            <td>
                                <textarea class="txt-des" id="txtDes-5178649" placeholder="Để có thứ hạng cao tại kết quả tìm kiếm"></textarea>
                            </td>
                        </tr>
                        <tr id="abId0.06276922035335075">
                            <td class="info-th default-head"></td>
                            <td id="abId0.16960960941804948" >
                                <div class="price_div" id="abId0.47425896941022705">
                                    <select class="opts-set-price" id="sel-set-price-5178649">
                                        <option>Chọn giá bán </option>
                                        <option value="0">Miễn phí</option>
                                        <option value="2000">2.000đ</option>
                                        <option value="3000">3.000đ</option>
                                        <option value="4000">4.000đ</option>
                                        <option value="5000">5.000đ</option>
                                        <option value="7000">7.000đ</option>
                                        <option value="10000">10.000đ</option>
                                        <option value="14000">14.000đ</option>
                                        <option value="15000">15.000đ</option>
                                        <option value="20000">20.000đ</option>
                                        <option value="37000">37.000đ</option>
                                        <option value="38000">38.000đ</option>
                                        <option value="50000">50.000đ</option>
                                        <option value="77000">77.000đ</option>
                                        <option value="100000">100000đ</option>
                                        <option value="-1">Tự đặt giá</option>
                                    </select>
                                    <input type="text" class="txt-set-price">
                                    <div class="txt-show-price highlight"></div>
                                </div>
                                <div class="price_div selectView hidden" id="abId0.1984667619110334">
                                    <select class="opts-set-percent">
                                        <option>Số trang xem trước </option>
                                        <option value="0">tự chọn </option>
                                        <option value="20">20%</option>
                                        <option value="50">50%</option>
                                    </select>
                                    <span class="pd9">trang</span>
                                    <input type="text" class="txt-page-show" id="txtPageShow-5178649">
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td class="info-th default-head">
                                <label>File đính kèm</label></td>
                            <td>
                                <form id="frmFileMore" method="post" action="/documents/ajax_upload/aja_file_more.php" enctype="multipart/form-data" abineguid="0CD768CB5422417A8E48DACD72313736">
                                    <div class="fileDoc">
                                        <label>File đính kèm</label>
                                        <input type="file" name="fileInput" id="fileInput" onchange="changeFileInput(this)">
                                    </div>
                                    <input type="hidden" name="fileDocId" value="5178649">
                                    <span>Chỉ chấp nhận định dạng file ZIP/RAR (tối đa 32MB)</span>
                                    <p>
                                        <input type="text" name="fileDocName" class="fileDoc_name" placeholder="Tên file đính kèm (VD: quản lý lớp học viết bằng C#)"></p>
                                </form>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td><a href="javascript:;" class="addColDoc_btn" uid="4244073" docid="5178649" onclick="showAddCollection(this)"><i></i>Thêm vào bộ sưu tập</a>     </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <p class="line_space"></p>
                                <div class="btn-save">Lưu</div>
                                <i class="note_save">Hệ thống đang xử lý, vui lòng đợi trong giây lát ...</i>      </td>
                        </tr>
                    </tbody>
                </table>
            </td>
        </tr>
        <tr></tr>
    </tbody>
</table>