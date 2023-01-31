window.addEventListener('resize', function () { loadLayout(); })
loadLayout();
function loadLayout() {
    let w = $("#contain").width();
    let h = $("#contain").height();
    let wcanvas = 1280;
    let hcanvas = 720;
    let wr = wcanvas;
    let hr = hcanvas;

    if (w < wr) {
        wr = w;
        hr = wr * (hcanvas / wcanvas);
    }


    $("#cocos").css("width", wr + "px");
    $("#cocos").css("height", hr + "px");

    console.log("wr", wr)
    console.log("hr", hr)
}