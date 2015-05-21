var app = angular.module('MyApp', ['ngRoute', 'ngGrid', 'ui.bootstrap', 'ui.grid']);



app.factory('theFactory', function ($http) {
       
        var fact = {};
        fact.getData = function () {
            return $http(
                {
                    method: "GET",
                    url: "/Dashboard/GetLastUser",
                    cache: false
                });
        }

        return fact;

});

app.factory('UserProfile', function ($http) {

    var fact = {};
    fact.getData = function () {
        return $http(
            {
                method: "GET",
                url: "/Profile/GetProfile",
                cache: false
            });
    }

    return fact;

});



app.factory('UpdateUserProfile', function ($http) {

    var fact = {};
    fact.postData = function (user) {
        return $http(
            {
                method: "POST",
                url: "/Profile/Update",
                data:
                    {
                        UserId: user.Id,
                        Username: user.UserName,
                        FirstName: user.FirstName,
                        LastName: user.LastName,
                        Email: user.Email,
                        Address: user.Address,
                        ProfilePicture: user.ProfilePicture
                    }
            });
    }

    return fact;

});


app.factory('GetDefinition', function ($http) {

    var fact = {};
    fact.postData = function (word) {
        return $http(
            {
                method: "POST",
                url: "/WebApi/GetDefinition",
                data:
                    {
                        word: word
                    }
            });
    }

    return fact;

});



//app.factory('DictionaryFactory', function ($http) {
//    return {
//        getDefinition: function (callback) {
//            $http.get('/api/define').success(callback);
//        }
//    }
//})



