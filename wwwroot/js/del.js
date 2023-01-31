function del(id, title) {
    let text = "bạn có chắc chắn muốn xóa: " + title;
    if (confirm(text) == true) {
        delWithId(id);
    }

}
function delWithId(id) {
    //let pass = document.querySelector("[name='pass']").value;

    //console.log("pass", pass)

    var param = {
        'id': id
    }
    //   Utils.Loading();
    $.ajax({
        type: 'POST',
        url: "@Url.Action("Del")",
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