$(function () {
    $("#ItemNav li").each(function (_index, _element) {
        var nameview = $(this).attr("nameview");
        if (typeof nameview !== typeof undefined && nameview !== false) {
            $(this).click(function () {
                $("#PanelR").load("Home/GetPartialView", { view: nameview});
            });            
        }
    });

    $("#LinkToGitHub").click(function () {
        window.open("https://github.com/M3mbrillo?tab=repositories", "_blank");
    });

    $("#DownloadPDF").click(function () {
        window.location = "Home/DownloadPDF";
    });

    $("#PrintPDF").click(function () {        
        document.getElementById("PrintPDF_frame").contentWindow.print();
    });
});