var thisApp = angular.module('restDemo', ['ngResource']);
thisApp.controller('restController', ['$scope', 'restService', function($scope, restService) {

    $scope.Get_Array = function () {

        restService.Get_Array('http://localhost:7588/api/Person').then(function (response) {
            //console.log(response);
            $scope.persons = response;
        });

        $scope.name = "Hello Me";
    };
}]);