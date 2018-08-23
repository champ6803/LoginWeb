app.controller("LoginController", function ($scope, $http, AuthenticationService) {
    $scope.loginForm = typeof loginForm !== "undefined" ? loginForm ? loginForm : null : null;

    $scope.account = {
        email: "jidapa@gmail.com",
        password: "jida123"
    }

    $scope.checkEmail = function (o) { 
        if (o) {
            if (o === $scope.account.email) {
                window.location.href = "https://localhost:44396/Home/Login?logintest=" + o;
            }
            else {
                alert("Try again or create a new account.");
            }
        }
        else {
            alert("Please input your email.")
        }
    }

    $scope.loginEmail = (window.location.search).substring(11);

    $scope.loginfunc = function (email,pass){
        if (email && pass) {
            if (pass == $scope.account.password) {
                alert("login success");
            }
            else {
                alert("password incorrect");
            }
        }
    }

    $scope.creareNewAccount = function () {
        window.location.href = "https://localhost:44396/Home/NewAccount";
    }

    $scope.ForgetPassword = function () {
        window.location.href = "https://localhost:44396/Home/ForgetPassword"
    }

    $scope.login = function (o) {
        if (o) {
            AuthenticationService.Login(o.username, o.password, function (result) {
                if (result === true) {
                    alert('ยินดีต้อนรับเข้าสู่ระบบ');
                    var m = JSON.parse(localStorage.currentUser);
                    if (m.role == "Recruitment") {
                        window.location.href = "http://localhost:8002?access_token=" + m.token;
                    } else if (m.role == "Community") {
                        window.location.href = "http://localhost:8001?access_token=" + m.token;
                    } else {
                        window.location.href = "/";
                    }
                    
                } else {
                    alert('ไม่สามารถเข้าสู่ระบบได้');
                }
            });
        }
        else {
            alert("ไม่สามารถเข้าสู่ระบบได้");
        }
    };
});