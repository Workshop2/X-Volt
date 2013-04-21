var site = {};

// site load
$(document).ready(function () {
    $(".live-tile, .flip-list").not(".exclude").liveTile();
    
    // hides the navigation stuff if js is enabled
    $(".menu-wrapper .menu-links-outer .menu-links-inner").addClass("js");

    site.mobileDropdown = $(".menu-mobile-dropdown");
    var cloned = $(".menu-wrapper .menu-links-outer .menu-links-inner").clone();
    site.mobileDropdown.append(cloned);

    site.menuWrapper = $(".menu-wrapper .menu-icon");
    site.menuWrapper.wrap("<div class='js' />");
    site.menuWrapper.click(function () {
        $(".menu-mobile-dropdown").toggle();
        site.mobileToggle = true;
    });
    
    $(window).resize(function () {
        // remove open menu when browser is sized above the visible boundary
        if (window.innerWidth > 640 && site.mobileToggle) {
            site.mobileDropdown.removeAttr("style");
            site.mobileToggle = false;
        }
    });
});