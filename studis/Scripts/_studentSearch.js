﻿$(document).ready(function () {
    $('#SearchString').keyup(function (e) {
        //var url = "@(Url.Action('StudentSearchPartial', 'Student'))";
        var url = "/Student/StudentSearchPartial";
        var data = $('#SearchString').val();

        $.ajax({
            url: url,
            type: "POST",
            data: { 'searchString': data },
            success: function (resp) {
                //alert(resp);
                $('#searchDiv').empty();
                $('#searchDiv').append(resp);
                //('#searchDiv').html(resp);
            },
            error: function (resp) {
                alert("err with ajax post");
            }
        });
    });
});