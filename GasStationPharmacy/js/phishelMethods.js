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

	$scope.userCreate = function(){
		$http({
			method: 'POST',
			url:'',
			data: $scope.user
		}).then(function successCallback(response){
			$scope.users.push(response.data);
			alert("User has created Successfully")
		}, function errorCallback(response){
			alert("Error while created User");
			alert($scope.user);
		});
	};
});