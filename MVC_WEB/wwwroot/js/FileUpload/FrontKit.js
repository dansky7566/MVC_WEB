
(function ($) {
    var $filesTemp = [];
    var tmpFileIndex = 0;

    $(document).ready(function () {

        //檔案上傳
        $('#FileUpload').on("change", function () {

            var html = "<div>檔案名稱：{0} 副檔名：{1} </div> <br/>";
            var data = UploadButton('#FileUpload', $filesTemp, tmpFileIndex, html);
            console.log(data);      
        });

        //刪除按鈕
        $("#Files").on("click", '.btnTmpFileDel', function () {
            var DelTmpIndex = $(this).siblings('.hdTmpFileId').val();
            RemoveItem(this, '.tmpFileList', $filesTemp, DelTmpIndex)
        });

    });
})(jQuery);