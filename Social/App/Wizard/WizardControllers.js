

app.config(function ($routeProvider, $locationProvider) {

    $routeProvider
        .when('/Page1', {
            templateUrl: '/Template/Page1.html',
            controller: 'Page1Controller'
        })
        .when('/Page2', {
            templateUrl: '/Template/Page2.html',
            controller: 'Page2Controller'
        })
        .when('/Page3', {
            templateUrl: '/Template/Page3.html',
            controller: 'Page3Controller'
        })
        .otherwise({
            templateUrl: '/Template/Page1.html',
            controller: 'Page1Controller'
        });

    $locationProvider.html5Mode(false).hashPrefix('!');

});


app.controller('Page1Controller', function ($scope) {

    $scope.Title = 'Page1';

});

app.controller('Page2Controller', function ($scope) {
    $scope.Title = "Page2";

});

app.controller('Page3Controller', function ($scope) {
    $scope.Title = "Page3";

});




/*
wizardController.config(function ($routeProvider, $locationProvider) {

    $routeProvider.when('Page1', {
        templateUrl: '/Template/Page1.html',
        controller: 'Page1Controller'
    });

});

*/
