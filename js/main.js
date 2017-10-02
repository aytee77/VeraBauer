$(function () {
    PageInit();

    $(window).resize(PageResize);
});

function PageInit() {
    squareCalc();
}

function PageResize() {
    squareCalc();
}

function squareCalc() {
    $(".square").each(function() {
        $(this).height($(this).width());
    });
}