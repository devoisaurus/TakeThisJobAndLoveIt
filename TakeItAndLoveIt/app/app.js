var app = angular.module("JobLoveApp", ["ngRoute"]);

angular.module("JobLoveApp")
    .config([
        "$routeProvider", "$locationProvider", function($routeProvider, $locationProvider) {
                $routeProvider
                    .when("/add",
                        {
                            templateUrl: "app/partials/add.html",
                            controller: "addController"
                        })
                    .when("/list",
                        {
                            templateUrl: "app/partials/list.html",
                            controller: "listController"
                        })
                    .when("/detail",
                        {
                            templateUrl: "app/partials/details.html",
                            controller: "addController"
                        })
                    .when("/detail/:id",
                        {
                            templateUrl: "app/partials/details.html",
                            controller: "detailController"
                        })
                    .when("/main",
                        {
                            templateUrl: "app/partials/landing.html",
                            controller: "homeController"
                        })
                    .when("Home/Index",
                        {
                            templateUrl: "app/partials/landing.html",
                            controller: "homeController"
                        });
        }
    ]);
