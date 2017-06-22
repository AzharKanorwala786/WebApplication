$(document).ready(function(){

    var urlpath = 'http://localhost:51616/api/Index/';

    $("#get").click(function () {
        debugger;
        GetAll();
    });


    function GetAll()
    {
        debugger;
        $.ajax({
            url: urlpath,
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                console.log(data)
            },
            error: function (res) {
                alert(res);
            },
        });
    }

    //$("#get").click(function (e) {
    //    debugger;
    //    urlpath = 'http://localhost:51616/api/Index/';
    //    $.ajax({
    //        url: urlpath,
    //        type: 'GET',
    //        dataType: 'json',
    //        success: function (data) {
    //            console.log(data)
    //        },
    //        error: function (res) {
    //            alert(res);
    //        },
    //    });
    //});
});