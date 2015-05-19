
app.controller('DashboardController', function ($scope, theFactory) {

    $scope.User = null;
    $scope.mySelections = [];

    $scope.myData = [];



    theFactory.getData().then(function (result) {

        $scope.myData = result.data;
        console.log(result);

    });


    $scope.gridOptions = {
        data: 'myData',
        multiSelect: false,
        selectedItems: $scope.mySelections,
        enableCellEdit: true,
        enableColumnResize: true,
        columnDefs:
            [
                /*{field: 'Id', displayName: 'UserId',width:90},*/
                { field: 'FirstName', displayName: 'FirstName'},
                { field: 'LastName', displayName: 'LastName'},
                {field: 'Email', displayName: 'EMail'},
                
            ]

    };


});



app.controller('Grid2Controller', function ($scope, theFactory) {

    $scope.gridOptions = {

        enableSelectAll: true,
        enableSorting: true,
        selectionRowHeaderWidth: 35,
        rowHeight: 35,
        showGridFooter: true
    };



    theFactory.getData().then(function (result) {

        $scope.gridOptions.data = result.data;
    });

});
