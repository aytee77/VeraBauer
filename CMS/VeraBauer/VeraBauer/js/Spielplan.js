function InitSpielplan() {
    $("#yearSelect").change(function () {
        scrollToElem("#" + $("#yearSelect").val());
    });
    $(".yearAnchor").each(function () {
        $("#yearSelect").append($('<option>', {
            value: $(this).attr("name"),
            text: $(this).attr("name")
        }));
        $("#yearSelect").val((new Date()).getFullYear());
    });

    if ($("#yearSelect").length) {
        window.isSpielPlan = true;
        scrollToElem("#" + $("#yearSelect").val(), 0);
    }
}