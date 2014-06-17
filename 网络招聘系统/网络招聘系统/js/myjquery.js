$(document).ready(function(argument) {
    // body...

    $("#bt_sign").css("background-color", "#90799e");
    $("#bt_login").css("background-color", "#e6deea");
    $("#bt_sign").click(function(argument) {
        // body...
        $("#login").css({
            "display": "none",
        });

        $("#sign").css("display", "block");
        $("#bt_sign").css("background-color", "#e6deea");
        $("#bt_login").css("background-color", "#90799e");
        return false;
    });
    $("#bt_login").click(function(argument) {
        // body...
        $("#sign").css("display", "none");
        $("#login").css({
            "display": "block",
        });
        $("#bt_login").css("background-color", "#e6deea");
        $("#bt_sign").css("background-color", "#90799e");
        return false;
    });
});
