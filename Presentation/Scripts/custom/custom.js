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
                console.log(res);
            },
        });
    }

    function GetDatabyName(Name)
    {
        $.ajax({
            url: urlpath + Name,
            type: 'GET',
            datatype: 'json',
            success: function (data) {
                console.log(data)
            },
            error: function (res) {
                console.log(res);
            },
        });
    }

    function Create() {

    }
});