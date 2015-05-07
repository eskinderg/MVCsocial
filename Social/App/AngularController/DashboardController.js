app.controller('DashboardController', function ($scope, theFactory) {

        $scope.User = null;
        $scope.mySelections = [];

        $scope.myData = [];


        
        theFactory.getData().then(function (result)
        {

            $scope.Users = result.data;
            $scope.myData = result.data;



            $scope.clicked = function (user) {
                alert('You Clicked on ' + user.FirstName);
                console.log(user);
            }

        });


        $scope.gridOptions = {
            data: 'myData',
            multiSelect: false,
            selectedItems: $scope.mySelections,
            enableCellEdit: true,
            enableColumnResize: true
        };


});
