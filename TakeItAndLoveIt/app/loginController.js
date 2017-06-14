app.controller("loginController", 
    function loginController($scope, $http) {
        $scope.welcome = "login controller here";

        $scope.user = {
            username: "",
            password: ""
        };

        $scope.newuser = {
            
        }

        $scope.register = function() {
            $http.post("/api/users", $scope.newuser).then(function(success) {
                    console.log("yay");
                },
                function(error) {
                    console.log("boo");
                });
        }

        $scope.submit= function (user)
        {
            console.log(user);
        }
    })