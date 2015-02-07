var myApp = angular.module('myApp', ['ngHandsontable']);
myApp.controller('GridController', ['$scope', function ($scope) {
    $scope.gridModel = grid;
}]);