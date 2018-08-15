app.controller("LoginController", function ($scope, $http, AuthenticationService) {
    $scope.loginForm = typeof loginForm !== "undefined" ? loginForm ? loginForm : null : null;

    $scope.login = function (o) {
        if (o) {
            AuthenticationService.Login(o.username, o.password, function (result) {
                if (result === true) {
                    alert('ยินดีต้อนรับเข้าสู่ระบบ');
                    window.location.href = "/";
                } else {
                    alert('ไม่สามารถเข้าสู่ระบบได้');
                }
            });
        }
    };
});