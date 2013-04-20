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
        // todo
        $(".menu-mobile-dropdown").toggle();
    });
    
    $(window).resize(function () {
        if (window.innerWidth > 640) {
            site.mobileDropdown.removeAttr("style");
        }
    });
});