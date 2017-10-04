$(function () {
    PageInit();

    $(window).resize(PageResize);
    $(window).scroll(PageScroll);
});

function PageInit() {
    squareCalc();
    InitMobilenav();
    handlHeaderSpace();
    handleScrollHeader();
}

function PageResize() {
    squareCalc();
    handlHeaderSpace();
}

function PageScroll() {
    handleScrollHeader();
}

function InitMobilenav() {
    window.mobileNavOpen = false;
    $(".MobileToggle").click(function() {
        if (window.mobileNavOpen) {
            CloseMobileNav();
        } else {
            OpenMobileNav();
        }
    });
}

function CloseMobileNav() {
    $(".MobileToggle").removeClass("open");
    $(".MobileHidden").stop().slideUp(400);
    window.mobileNavOpen = false;
}

function OpenMobileNav() {
    $(".MobileToggle").addClass("open");
    $(".MobileHidden").stop().slideDown(400);
    window.mobileNavOpen = true;
}

function squareCalc() {
    $(".square").each(function() {
        $(this).height($(".square").width());
    });
}

function handlHeaderSpace() {
    $("body").css("padding-top", $("header").height() + 30); 
}

function handleScrollHeader() {
    if ($(window).scrollTop() > 0) {
        $("html").addClass("scrolled");
    } else {
        $("html").removeClass("scrolled");
    }
}