var app = angular.module("JobLoveApp", ["ngRoute"]);

angular.module("JobLoveApp")
    .config([
        "$routeProvider", "$locationProvider", function($routeProvider, $locationProvider) {
            $routeProvider
                .when("/detail",
                    {
                        templateUrl: "app/partials/details.html",
                        controller: "detailController"
                    })
                .when("/add",
                    {
                        templateUrl: "app/partials/add.html",
                        controller: "addController"
                    })
                .when("/list",
                    {
                        templateUrl: "app/partials/list.html",
                        controller: "listController"
                    });
        }
    ]);
