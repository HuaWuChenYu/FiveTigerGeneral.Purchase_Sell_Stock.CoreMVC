$.ajaxSetup({ //发送请求前触发
    beforeSend: function (xhr) { //可以设置自定义标头
        var token = getCookie("token");
        if (token == "" || token == null || token == undefined) {
            alert('请先登录');
            location.href = '/Login/Show';
            return;
        }
        xhr.setRequestHeader('Authorization', "Bearer " + token);
    }
});