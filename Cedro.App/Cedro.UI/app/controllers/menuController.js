angular.module('app').controller('MenuController', function ($scope, modelService) {
    $scope.itensMenu = modelService.getMenuItens();
});