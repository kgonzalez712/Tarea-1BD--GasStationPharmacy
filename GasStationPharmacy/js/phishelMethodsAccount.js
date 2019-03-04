var myApp = angular.module('myApp', []);
myApp.controller("appController",function($scope,$http){
	$http.get("https://gasstationpharmacyrestserver20190302021942.azurewebsites.net/api/Clients/PH/345").then(function(response){
		$scope.user = response.data;
	});
});