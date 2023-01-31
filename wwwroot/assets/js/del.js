function del(id, title,url) {
    let text = "bạn có chắc chắn muốn xóa: " + title;
    if (confirm(text) == true) {
        delWithId(id,url);
    }

}
function delWithId(id,url) {

    var param = {
        'id': id
    }
    $.ajax({
        type: 'POST',
        url: url,
        data: param,
        async: true,
        success: function (data) {
            console.log("data", data)
            // Utils.UnLoading();
            if (data.isSuccess) {
                location.href = location.href;
            }
            else {
            }
        }

    });
}