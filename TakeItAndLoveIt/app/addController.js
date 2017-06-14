app.controller("addController",
    function addController($scope) {
        console.log("i'm add");
        $scope.welcome = "Add Controller detected, proceed";


        $scope.company = {
            name: "",
            contact: "",
            email: "",
            phone: ""
        };

        $scope.submit = function(company) {
            console.log(company);
        }

    });