﻿app.controller('FriendsController', function ($scope, theFactory, $modal, $log) {

    theFactory.getData().then(function (result) {

        $scope.Users = result.data;
    });




    $scope.open = function (user) {

        var modalInstance = $modal.open({
            animation: true,
            templateUrl: 'myModalContent.html',
            controller: 'ModalInstanceCtrl',
            resolve: {
                items: function () {
                    return user;
                }
            }
        });


        modalInstance.result.then(function (selectedItem) {
            $scope.selected = selectedItem;
        }, function () {
            $log.info('Modal dismissed at: ' + new Date());
        });

    }



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