﻿//site.js

(function () {
    var el = $("#username");
    el.text = "Amouna";

    var main = document.getElementById("main");

    main.onmouseenter = function () {

        main.style.backgroundColor = "#888";
    };

    main.onmouseleave = function () {
        main.style.backgroundColor = "";
    };

})();

