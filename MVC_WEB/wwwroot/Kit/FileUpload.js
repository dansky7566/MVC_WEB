//上傳功能

function UploadButton(UploadFileName, filesTmpArray, tmpFileIndex) {

    var files = $(UploadFileName)[0].files;
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
            filesTmpArray.push(obj);
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
    }
}

//附檔下載_TMP刪除按鈕
function RemoveItem(object, closeColumn, $filesTemp, DelTmpIndex) {
    for (var i = 0; i < $filesTemp.length; i++) {
        if ($filesTemp[i].tmpFileIndex == DelTmpIndex) {
            $filesTemp.splice(i, 1);
        }
    }
    $(object).closest(closeColumn).remove();
}








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
