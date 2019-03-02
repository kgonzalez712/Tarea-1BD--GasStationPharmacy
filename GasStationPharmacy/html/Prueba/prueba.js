angular.module('demo', [])
.controller('Hello', function($scope, $http) {
    $http.get('').
        then(function(response) {
            $scope.greeting = response.data;
        });
});