app.controller('MenuController', function ($scope) {

    //--------Menu------------------------------------------------
    $scope.items = [
        'The first choice!',
        'And another choice for you.',
        'but wait! A third!'
    ];

    $scope.status = {
        isopen: false
    };


    /*
        $scope.toggled = function (open) {
            $log.log('Dropdown is now: ', open);
        };

        $scope.toggleDropdown = function ($event) {
            $event.preventDefault();
            $event.stopPropagation();
            $scope.status.isopen = !$scope.status.isopen;
        };
        */
    $scope.menuClicked = function ($event) {
        alert("asdfasdf");
        $event.preventDefault();
        $event.stopPropagation();

    };
    //--------end Menu-----------------------------------------------

});