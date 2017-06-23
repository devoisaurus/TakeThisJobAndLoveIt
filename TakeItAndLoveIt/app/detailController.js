app.controller("detailController",
    function detailController($scope, $http, $routeParams) {

        $http.get("/api/companies/" + $routeParams.id)
            .then(function (res) {
                $scope.companies = res.data;
            });


        $scope.interactionList = [];

        $http.get("/api/companies/" + $routeParams.id + "/interactions")
            .then(function (res) {
                $scope.interactionList = res.data;
            });


        $scope.addInteraction = function (interaction) {
            $http.post("/api/companies/" + $routeParams.id + "/interactions/", $scope.interaction)
                .then(function (success) {
                        console.log("i did the thing");
                    },
                    function (error) {
                        console.log("I did not do the thing");
                    });

        }
    });