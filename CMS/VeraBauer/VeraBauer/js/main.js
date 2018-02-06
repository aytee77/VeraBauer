$(function () {
    PageInit();

    $(window).resize(PageResize);
    $(window).scroll(PageScroll);
});

function PageInit() {
    squareCalc();
    InitMobilenav();
    handlHeaderSpace();
    initGallerie();
    InitSpielplan();
    initHomeSlider();
    setTimeout(handleScrollHeader, 20);
}

function PageResize() {
    squareCalc();
    handlHeaderSpace();
}

function PageScroll() {
    handleScrollHeader();
}

function initHomeSlider() {
    var swiper = new Swiper('.swiper-container', {
        autoplay: {
            delay: 2000,
        },
        effect: "fade",
        autoHeight: true,
    });
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
    $("body > .container").css("padding-top", $("header").height() ); 
}

function handleScrollHeader() {
    if (!window.isSpielPlan) {
        if ($(window).scrollTop() > 0) {
            $("html").addClass("scrolled");
        } else {
            $("html").removeClass("scrolled");
        }
    }
}

function initGallerie() {
    $('#GallerieButton').magnificPopup({
        items: window.galerie,
        gallery: {
            enabled: true
        },
        type: 'image'
    });
}

function scrollToElem(selector, time)
{
    time == undefined && (time = 700);
    var elem = $(selector)[0];
    var offset = 0;
    if (window.isSpielPlan) {
        offset = $("header").height() + $(".fixed").height();
    } else {
        offset = $("header").height()
    }

    $("html").animate({
        scrollTop: $(elem).offset().top - offset
    }, time)
}