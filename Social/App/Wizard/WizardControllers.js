

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

    $scope.Title = 'Pedantic';

});

app.controller('Page2Controller', function ($scope) {
    $scope.Title = "Ostentatious";

});

app.controller('Page3Controller', function ($scope) {
    $scope.Title = "Page3";

});





app.controller('DictionaryController', function ($scope, GetDefinition) {

    $scope.word;

    $scope.definitions = null;


    $scope.txtChanged = function () {

        GetDefinition.postData($scope.word).then(function (result) {
            //alert("Sucusssfully Update + " + result.data.UserName);
            $scope.definitions = result.data;
            console.log($scope.definitions);
        });
    }

});





/*
wizardController.config(function ($routeProvider, $locationProvider) {

    $routeProvider.when('Page1', {
        templateUrl: '/Template/Page1.html',
        controller: 'Page1Controller'
    });

});

*/
