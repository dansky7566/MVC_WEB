
(function ($) {
    var $filesTemp = [];
    var tmpFileIndex = 0;

    $(document).ready(function () {

        //檔案上傳按鈕
        $('#FileUpload').on("change", function () {
            _uploadFile();
        });

        //附檔下載_TMP刪除按鈕
        $("#Files").on("click", '.btnTmpFileDel', function () {
            var DelTmpIndex = $(this).siblings('.hdTmpFileId').val();
            //取得要刪除的檔案
            for (var i = 0; i < $filesTemp.length; i++) {
                if ($filesTemp[i].tmpFileIndex == DelTmpIndex) {
                    $filesTemp.splice(i, 1);
                }
            }
            $(this).closest('.tmpFileList').remove();
        });

        //送出按鈕
        $('#btnSave').on("click", function () {

            var fromData = new FormData();
            GetUploadFile(fromData)
            //之後送ashx做處理
            $.ajax({
                url: "/FileUpload/FrontUpload",
                type: "POST",
                data: fromData,
                contentType: false,
                processData: false,
                async: false,
                success: function (data) {
                    window.location.reload();
                }
            });

        });

        //----Function-----

        //上傳檔案邏輯
        var _uploadFile = function () {
            var files = $('#FileUpload')[0].files;
            var isCheck = true;
            var ErrorMessage = "檔案格式錯誤";
            var validExts = new Array(".bmp", ".gif", ".jpg", ".png", ".tif", ".txt", ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".zip", ".rar", ".mp3", ".mp4", ".mpg", ".avi", ".odt", ".ods", ".odp", ".csv", ".txt");

            $.each(files, function (index, item) {

                var Extension = '.' + getFileExtension(item.name);
                if (validExts.indexOf(Extension.toLowerCase()) < 0) {

                    isCheck = false;
                }
                else {
                    var obj = { 'OriginalName': item.name, 'content': item, 'tmpFileIndex': tmpFileIndex };
                    $filesTemp.push(obj);
                    var htmlTag = "<tr class='tmpFileList'>" +
                        "<th scope='row'>" +
                        "<input class='form-control FileName' type='text' value='" + getFileName(item.name) + "' />" +
                        "</th>" +
                        "<td><a class='text-height'>" + item.name + "</a></td>" +
                        "<td>" +
                        "<input type='hidden' class='hdTmpFileId' value= " + tmpFileIndex + ">" +
                        "<input type='hidden' class='hdFileExtension' value=" + "." + getFileExtension(item.name) + "  >" +
                        "<input type='button' class='btn btn-outline-danger btnTmpFileDel' value = 'x' >" +
                        "<input type='hidden' class='hdTmpIsDel'></td>";
                    $("#Files").append(htmlTag);
                    tmpFileIndex++;
                }
            });
            if (isCheck == false) {
                swal(ErrorMessage);
            }
        };

        //取得副檔名
        function getFileExtension(fileName) {
            return (/[.]/.exec(fileName)) ? /[^.]+$/.exec(fileName)[0] : undefined;
        }

        //取得檔案名稱
        function getFileName(val) {
            filename = val.split('\\').pop().split('/').pop();
            filename = filename.substring(0, filename.lastIndexOf('.'));
            return filename;
        }

        //取得檔案
        function GetUploadFile(object) {
            var FileData = $filesTemp;
            for (var i = 0; i < FileData.length; i++) {
                object.append("FileUpload", FileData[i].content);
            }
        }

        //-----------------

    });
})(jQuery);