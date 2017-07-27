var myApp = angular.module('myApp', []);

//$scope is like a viewbag in code behind
myApp.controller('myAppCtrl', function ($scope) {
    $scope.somestring = 'test string';

    // make angular employee model
    $scope.angEmp = Model;
});