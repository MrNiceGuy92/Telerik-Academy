/*I have used JS.HInt.*/

(function () {
    'use strict';
    var addScroll = false,
        pageX = 0,
        pageY = 0,
        theLayer,
        args,
        navigatorAppName = navigator.appName;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    document.onmousemove = mouseMove;

    if (navigatorAppName === "Netscape") {
        document.captureEvents(Event.MOUSEMOVE);
    }

    function mouseMove(input) {
        if (navigatorAppName === "Netscape") {
            pageX = input.pageX - 5;
            pageY = input.pageY;
        } else {
            pageX = event.x - 5;
            pageY = event.y;
        }
        if (navigatorAppName === "Netscape") {
            if (document.layers.ToolTip.visibility === 'show') {
                new PopTip();
            }
        } else {
            if (document.all.ToolTip.style.visibility === 'visible') {
                new PopTip();
            }
        }
    }

    function PopTip() {
        if (navigatorAppName === "Netscape") {
            theLayer = eval('document.layers[\'ToolTip\']');
            if ((pageX + 120) > window.innerWidth) {
                pageX = window.innerWidth - 150;
            }
            theLayer.left = pageX + 10;
            theLayer.top = pageY + 15;
            theLayer.visibility = 'show';
        } else {
            theLayer = eval('document.all[\'ToolTip\']');
            if (theLayer) {
                pageX = event.x - 5;
                pageY = event.y;
                if (addScroll) {
                    pageX = pageX + document.body.scrollLeft;
                    pageY = pageY + document.body.scrollTop;
                }
                if ((pageX + 120) > document.body.clientWidth) {
                    pageX = pageX - 150;
                }
                theLayer.style.pixelLeft = pageX + 10;
                theLayer.style.pixelTop = pageY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function HideTip() {
        args = HideTip.arguments;
        if (navigatorAppName === "Netscape") {
            document.layers.ToolTip.visibility = 'hide';
        } else {
            document.all.ToolTip.style.visibility = 'hidden';
        }
    }

    function HideMenu1() {
        if (navigatorAppName === "Netscape") {
            document.layers.menu1.visibility = 'hide';
        } else {
            document.all.menu1.style.visibility = 'hidden';
        }
    }

    function ShowMenu1() {
        if (navigatorAppName === "Netscape") {
            theLayer = eval('document.layers[\'menu1\']');
            theLayer.visibility = 'show';
        } else {
            theLayer = eval('document.all[\'menu1\']');
            theLayer.style.visibility = 'visible';
        }
    }

    function HideMenu2() {
        if (navigatorAppName === "Netscape") {
            document.layers.menu2.visibility = 'hide';
        } else {
            document.all.menu2.style.visibility = 'hidden';
        }
    }

    function ShowMenu2() {
        if (navigatorAppName === "Netscape") {
            theLayer = eval('document.layers[\'menu2\']');
            theLayer.visibility = 'show';
        } else {
            theLayer = eval('document.all[\'menu2\']');
            theLayer.style.visibility = 'visible';
        }
    }
})();