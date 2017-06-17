app.controller("addController",
    function addController($scope, $http) {
        console.log("i'm add");
        $scope.welcome = "Add Controller detected, proceed";


        $scope.company = {
            CompanyName: "",
            PrimaryContact: "",
            PrimaryContactEmail: "",
            PrimaryContactPhone: ""
        };


        $scope.addCompany = function(company) {
            $http.post("/api/companies", $scope.company).then(function (success) { },
                function (error) { });
        }

    });