var myApp = angular.module('myApp', []);
myApp.controller("appController",function($scope,$http){
	
	$scope.createRecipe = function(){
		$http({
			method: 'POST',
			url: '',
			data: $scope.recipeCreate
		}).then(function successCallback(response){
			$scope.recipeCreates.push(response.data);
			alert("Recipe has created Successfully")
		}, function errorCallback(response){
			alert("Error while created Recipe");
			alert($scope.recipeCreate.url);

		});
	};

	$scope.updateRecipe = function(){
		$http({
			method: 'PUT',
			url: '' + $scope.recipeUpdate.number,
			data: $scope.recipeUpdate
		}).then(function successCallback(response){
			alert("Recipe has updated Successfully")
		}, function errorCallback(response){
			alert("Error while updating recipe");
		});
	};

	$scope.deleteRecipe = function(recipe){
		$http({
			method: 'DELETE',
			url:'' + recipeDelete.number
		}).then(function successCallback(response){
			alert("Recipe has deleted Successfully");
			var index = $scope.recipeDeletes.indexof(recipe);
			$scope.recipeDeletes.splice(index, 1);
		}, function errorCallback(response){
			alert("Error while deleting recipe");
		});
	};

	$scope.createUser = function(){
		$http({
			method: 'POST',
			url:'http://192.168.100.18:54014/api/Clients/Phischel/NewClient',
			data: $scope.user
		}).then(function successCallback(response){
			$scope.users.push(response.data);
			alert("User has created Successfully")
		}, function errorCallback(response){
			alert("Error while created User");
		});
		// $http.post('',$scope.user,{headers:{'Content-Type':'application/x-www-form-urlencoded'}}).then(function(response){});
	};

	$scope.createOrder = function(){
		$http({
			method: 'POST',
			url: '',
			data: $scope.orderCreate
		}).then(function successCallback(response){
			$scope.orders.push(response.data);
			alert("Order has created Successfully")
		}, function errorCallback(response){
			alert("Error while created Order");
			alert($scope.orderCreate.pickupTime);
			alert($scope.orderCreate.id);
			alert($scope.orderCreate.acetaminofen);
			alert($scope.orderCreate.acetaminofenCount);
			alert($scope.orderCreate.url);
		});
	};

});