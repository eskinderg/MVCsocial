app.controller('FriendsController', function ($scope, theFactory, $modal) {

    theFactory.getData().then(function (result) {

        $scope.Users = result.data;
    });


        $scope.clicked = function (usr) {

        //alert('You Clicked on ' + user.FirstName
        //console.log(user);
            //$scope.user = null;

            $scope.user = usr; //[user.FirstName, user.LastName, user.Username];

        $scope.animationsEnabled = true;

        $scope.open = function (size) {

            var modalInstance = $modal.open({
                animation: $scope.animationsEnabled,
                templateUrl: 'myModalContent.html',
                controller: 'ModalInstanceCtrl',
                size: size,
                resolve: {
                    items: function () {
                        return $scope.user;
                    }
                }
            });

            modalInstance.result.then(function (selectedItem) {
                $scope.selected = selectedItem;
            }, function () {
                console.log('Modal dismissed at: ' + new Date());
            });
        };

        $scope.open();

        $scope.toggleAnimation = function () {
            $scope.animationsEnabled = !$scope.animationsEnabled;
        };


    }
    
    //---------------------------------------------------------------------------

});

/*
app.controller('DialogController', function ($scope, $modal, $log) {

    

});
*/




app.factory('Dialog', function ($modal, $log) {

    
    return function (user) {
        //alert(usr.FirstName);

    };

    /*
    $scope.user = ['item1', 'item2', 'item3'];

    $scope.animationsEnabled = true;

    $scope.open = function (size) {

        var modalInstance = $modal.open({
            animation: $scope.animationsEnabled,
            templateUrl: 'myModalContent.html',
            controller: 'ModalInstanceCtrl',
            size: size,
            resolve: {
                user: function () {
                    return $scope.user;
                }
            }
        });

        modalInstance.result.then(function (selectedItem) {
            $scope.selected = selectedItem;
        }, function () {
            $log.info('Modal dismissed at: ' + new Date());
        });
    };

    $scope.toggleAnimation = function () {
        $scope.animationsEnabled = !$scope.animationsEnabled;
    };
    */
});







app.controller('ModalInstanceCtrl', function ($scope, $modalInstance, user) {

    $scope.user = user;
    $scope.selected = {
        item: $scope.user[0]
    };

    $scope.ok = function () {
        $modalInstance.close($scope.selected.item);
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
});