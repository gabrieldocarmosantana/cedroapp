angular.module('app').controller('DishController', function ($scope, modelService, dishService, restaurantService, $routeParams,cfpLoadingBar) {
    //$scope.itensMenu = modelService.getMenuItens();
    cfpLoadingBar.start();
    $scope.dGridOptions= modelService.getDishGridConfig();
    console.log($scope.dGridOptions);


    if ($routeParams.id) {
        var id = $routeParams.id;
        cfpLoadingBar.start();
        dishService.getbyid({ id: $routeParams.id })
            .then(function (result) {
                $scope.editDish = result.Data[0];
            });
    }

    $scope.dgrid = {
        data: [],
        columnDefs: $scope.dGridOptions,
        onRegisterApi: function (gridApi) {
            $scope.grid1Api = gridApi;
        },
        appScopeProvider: $scope,
        enableRowSelection: true
    };

    dishService.get()
        .then(function (resp) {
            $scope.dgrid.data = resp.Data;
            $scope.data = resp.Data;

        });

    $scope.dModel = modelService.getDishModel();

    $scope.save = function () {
        cfpLoadingBar.start();
        console.log($scope.dModel);
        dishService.save($scope.dModel).then(function (obj) {
            location.href = '/#/dishes';
        });
    }

    $scope.update = function () {
        cfpLoadingBar.start();
        dishService.update($scope.editDish)
            .then(function() {
                location.href = '/#/dishes';
            });

    }

    restaurantService.get()
     .then(function (resp) {

         $scope.restaurants = resp.Data;
       

     });
  
    $scope.remove = function (idn) {
        cfpLoadingBar.start();
        dishService.delete({ id: idn })
            .then(function () {
                dishService.get()
                       .then(function (resp) {
                           $scope.dgrid.data = resp.Data;
                           $scope.data = resp.Data;

                       });
            });
    }

});