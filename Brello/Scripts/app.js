var app = angular.module('brello', []);

app.controller("BoardController", ["$scope","$http", function ($scope) {
    $scope.test = "Hello World!";

    $scope.hello = function () {
        //$scope.test = "hello, is it me you're looking for?";
        //GET api/BoardApi
        $http.get("api/BoardApi")
            .success(function (response) {
                $scope.test = response.data[1];
            })
        .errror(function (error) { alert(error.message);});
    }
}]);