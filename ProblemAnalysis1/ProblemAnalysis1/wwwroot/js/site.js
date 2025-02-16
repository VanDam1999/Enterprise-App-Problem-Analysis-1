$(function () {

    $(".date-picker")
        .datepicker({
            dateFormat: "yy-mm-dd",
            changeYear: true,
            yearRange: "-100:+0"
        });

});
