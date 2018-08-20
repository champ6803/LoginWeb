var app = angular.module("myapp", []).run(run).factory('AuthenticationService', AuthenticationService);

function AuthenticationService($http) {
    var service = {};

    service.Login = Login;
    service.Logout = Logout;

    return service;

    function Login(username, password, callback) {
        //debugger;
        if (username && password) {
            $http.post('http://localhost:3004/api/Login', { username: username, password: password })
                .then(function (response) {
                    //debugger;
                    if (response.data) {
                        localStorage.currentUser = JSON.stringify({ username: username, role: response.data.userAuth.role, app: response.data.userAuth.app, token: response.data.token });
                        $http.defaults.headers.common.Authorization = 'Bearer ' + response.data.token;
                        callback(true);
                    } else {
                        callback(false);
                    }
                }, function (response) {
                    callback(false);
                });
        }
        else {
            callback(false);
        }
    }

    function Logout() {
        delete window.localStorage.currentUser;
        $http.defaults.headers.common.Authorization = '';
    }
}

function run($rootScope, $http) {
    var url_string = document.URL;
    var url = new URL(url_string);
    var access_token = url.searchParams.get("access_token");
    
    if (localStorage.currentUser) {
        var o = JSON.parse(localStorage.currentUser);
        $http.defaults.headers.common.Authorization = 'Bearer ' + o.token;
    } else if (access_token != null) {
        $http.defaults.headers.common.Authorization = 'Bearer ' + access_token;
    }

    //$rootScope.$on('$locationChangeStart', function (event, next, current) {
    //    var publicPages = ['/login'];
    //    var restrictedPage = publicPages.indexOf($location.path()) === -1;
    //    if (restrictedPage && !$localStorage.currentUser) {
    //        $location.path('/login');
    //    }
    //});
}

