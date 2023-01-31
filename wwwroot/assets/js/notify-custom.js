function notifySuccess(text="Success") {
     $.growl.notice1({
         message: text
    });
}
function notifyWarning(text = "Warning") {
    $.growl.warning1({
        message: text
    });
}

function notifyError(text = "Error") {
    $.growl.error1({
        message: text
    });
}