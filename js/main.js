$(function () {
    PageInit();

    $(window).resize(PageResize);
});

function PageInit() {
    squareCalc();
    InitMobilenav();
}

function PageResize() {
    squareCalc();
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
    $(".MobileHidden").slideUp(400);
    window.mobileNavOpen = false;
}

function OpenMobileNav() {
    $(".MobileHidden").slideDown(400);
    window.mobileNavOpen = true;
}

function squareCalc() {
    $(".square").each(function() {
        $(this).height($(".square").width());
    });
}