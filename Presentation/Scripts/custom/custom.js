$(document).ready(function(){

    $("#get").click(function (e) {
        debugger;
        urlpath = 'http://localhost:51616/api/Index/';
        $.ajax({
            url: urlpath,
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                WriteResponse(data);
            },
            error: function (res) {
                alert(res);
            },
        });
    });
});