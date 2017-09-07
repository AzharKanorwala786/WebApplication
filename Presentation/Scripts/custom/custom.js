var App = App || {};

App.Products = {

    GetUrl: function () {

        $.ajax({
            url: '/Home/GetAPICall',
            type: 'GET',
            dataType: 'json',
            success: function (url) {
                App.Products.GetData(url + 'GetProducts');
            }
        })
    },

    GetData: function (urlpath) {

        $.ajax({
            url: urlpath,
            type: 'GET',
            dataType:'json',
            success: function (data) {
                debugger;
                console.log(data);
                App.Products.PassData(data);
            },
            error: function (res) {
                debugger;
                console.log(res)
            },
        });
    },

    PassData : function(data)  {

        var product = data[0];
        $.ajax({
            url: '/Home/Products',
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            cache: false,
            data: product,
            success: function (data) {
                debugger;
                console.log(data);
            },
            error: function (res) {
                debugger;
                alert("error");
            },
        });
    },
}