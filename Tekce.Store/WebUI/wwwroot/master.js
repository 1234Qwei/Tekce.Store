"use strict";

var menuHelper = function () {

    var currentMenuActivator = function () {
        var url = window.location;
        var element = $('.menu-link').filter(function () {
            return this.href == url;
        });
        element.addClass("active");
    }
    return {
        init: function () {
            currentMenuActivator();
        }

    }
}
function init(){
    menuHelper().init();  
}

init();