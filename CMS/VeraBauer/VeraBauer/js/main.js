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
    initGallerie();
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
    $("nav .square").each(function() {
        $(this).height($("nav .square").width());
    });
    $(".button .square").each(function() {
        $(this).height($(this).width());
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

function initGallerie() {
    $('#GallerieButton').magnificPopup({
        items: [
            {
                src: 'https://via.placeholder.com/800x900/ffffff'
            },
            {
                src: 'https://via.placeholder.com/850x960/ffffff'
            },
            {
                src: 'https://via.placeholder.com/400x500/ffffff'
            },
        ],
        gallery: {
            enabled: true
        },
        type: 'image'
    });
}