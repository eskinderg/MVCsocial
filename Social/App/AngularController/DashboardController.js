
app.controller('DashboardController', function ($scope, theFactory, UserDialog) {

    $scope.User = null;
    $scope.mySelections = [];

    $scope.myData = [];



    theFactory.getData().then(function (result) {

        $scope.myData = result.data;
        //console.log(result);

    });


    $scope.deleteThisRow = function (row) {
        //$scope.open(row);
        UserDialog.open(row);
    }

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
                { field: 'Email', displayName: 'EMail' },
                {
                    field: 'Action',
                    cellTemplate: '<div style="padding:5px;">' +
                                        '<a style="color:#FF00B4;" ng-click="$event.stopPropagation(); deleteThisRow(row.entity);">Delete</a>' +
                                   '</div>',
                    width: 100,
                    enableCellEdit: false,
                    enableColumnResize: false,
                    enableCellSelection: false,
                    enableRowSelection:false

                }
                
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
