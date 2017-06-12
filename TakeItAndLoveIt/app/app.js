var app = angular.module("JobLoveApp", ["ngRoute"]);

          app.controller("homeController", ["$scope", function($scope) {
                         $scope.welcome = "*waves* ";
                     }]);
