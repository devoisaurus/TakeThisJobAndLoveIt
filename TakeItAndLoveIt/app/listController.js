app.controller("listController",
    function listController($scope, $http, $location) {

        $scope.list = [];

        $http.get("/api/companies")
            .then(function (res) {
                $scope.list = res.data;
            });

        $scope.detailView = function(company) {
            $http.get("/api/companies/" + company.companyId)
            .then(function(success) {
                    $location.path("/detail");

                })
        }

        $scope.deleteMe = function (company) {
            $http.delete("/api/companies/" + company.companyId)
                .then(function (success) {
                        $location.path("/list");
                    },
                    function (error) { });
        }

    });