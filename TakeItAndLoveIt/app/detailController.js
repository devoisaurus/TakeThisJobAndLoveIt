app.controller("detailController",
    function detailController($scope, $http) {
        console.log("I'm details");
        $scope.welcome = "Details Controller detected, proceed";

        $scope.list = [];

        $http.get("/api/JobLoveApp")
            .then(function(res) {
                $scope.list = res.data;
            });
    });