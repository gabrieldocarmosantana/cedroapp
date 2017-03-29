angular.module('app').controller('HomeController', function ($scope, modelService) {
    $scope.itensMenu = modelService.getMenuItens();

    console.log();

 
});