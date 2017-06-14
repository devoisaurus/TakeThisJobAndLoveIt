app.controller("listController",
    function listController($scope, $http) {
        console.log("i'm list");
        $scope.welcome = "List Controller detected, proceed";

        $scope.list = [];

        $http.get("/api/JobLoveApp")
            .then(function (res) {
                $scope.list = res.data;
            });

    });