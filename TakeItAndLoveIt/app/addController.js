app.controller("addController",
    function addController($scope, $http, $location) {
        console.log("i'm add");
        $scope.welcome = "Add Controller detected, proceed";


        $scope.company = {
            CompanyName: "",
            PrimaryContact: "",
            PrimaryContactEmail: "",
            PrimaryContactPhone: ""
        };


        $scope.addCompany = function(company) {
            $http.post("/api/companies", $scope.company)
                .then(function(success) {
                        $location.path("app/partials/list");
                    },
                function (error) { });
        }

    });