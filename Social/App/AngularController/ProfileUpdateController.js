app.controller('ProfileUpdateController',function($scope,UserProfile,UpdateUserProfile,$http) {
    $scope.master = {};
    $scope.update = function (user) {
        //alert(user.FirstName + ' ' + user.LastName);
        //$scope.master = angular.copy(user);

        UpdateUserProfile.postData(user).then(function (result) {
            alert("Sucusssfully Update + " + result.data.Username);
        });
    };


    $scope.reset = function() {
        $scope.user = angular.copy($scope.master);
    };
    //$scope.reset();
    UserProfile.getData().then(function (result) {
        $scope.user = result.data[0];

        $scope.clicked = function (user) {

            alert('You Clicked on ' + user.FirstName);
            console.log(user);

        }
    });

});



//--------------------------------------------------------------------
//--------------------------------------------------------------------
app.directive('fileModel', ['$parse', function ($parse) {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            var model = $parse(attrs.fileModel);
            var modelSetter = model.assign;

            element.bind('change', function () {
                scope.$apply(function () {
                    modelSetter(scope, element[0].files[0]);
                });
            });
        }
    };
}]);



app.service('fileUpload', ['$http', function ($http) {
    this.uploadFileToUrl = function(file, uploadUrl){
        var fd = new FormData();
        fd.append('file', file);
        $http.post(uploadUrl, fd, {
            transformRequest: angular.identity,
            headers: {'Content-Type': undefined}
        })
        .success(function(){
        })
        .error(function(){
        });
    }
}]);

//--------------------------------------------------------------------------
//--------------------------------------------------------------------------