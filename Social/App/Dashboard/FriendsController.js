app.controller('FriendsController', function ($scope, theFactory, UserDialog) {

    theFactory.getData().then(function (result) {

        $scope.Users = result.data;
    });

    $scope.open = function (user)
    {
        UserDialog.open(user);
    }

    $scope.cancel = function()
    {
        alert("cancelling");
    }

});

