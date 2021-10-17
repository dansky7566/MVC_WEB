
(function ($) {
    var $filesTemp = [];
    var tmpFileIndex = 0;

    $(document).ready(function () {

        //檔案上傳
        $('#FileUpload').on("change", function () {
            UploadButton('#FileUpload', $filesTemp, tmpFileIndex);
        });

        //刪除按鈕
        $("#Files").on("click", '.btnTmpFileDel', function () {
            var DelTmpIndex = $(this).siblings('.hdTmpFileId').val();
            RemoveItem(this, '.tmpFileList', $filesTemp, DelTmpIndex)
        });

    });
})(jQuery);