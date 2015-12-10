﻿var app = angular.module('Brello', []);

app.controller("BoardController", ["$scope", "$http", function ($scope, $http) {
    $scope.test = "Hello World!";

    $scope.hello = function () {
        //$scope.test = "Hello, is it me you're looking for?";
        // GET: api/BoardApi
        $http.get("api/BoardApi")
            .success(function (response) {
                console.log(response);
                $scope.test = response.Data[1];
            })
        .error(function (error) { alert(error.message);});

    }
}]);