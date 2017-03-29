angular.module('app').controller('RestaurantController', function ($scope, modelService, restaurantService, $filter, $routeParams, cfpLoadingBar) {
    cfpLoadingBar.start();
    $scope.itensMenu = modelService.getMenuItens();
    $scope.roptionsGrid = modelService.getRestaurantGridConfig();
    console.log($scope.roptionsGrid);

    if ($routeParams.id) {
        var id = $routeParams.id;
        restaurantService.getbyid({ id: $routeParams.id })
            .then(function(result) {
                $scope.editRestaurant = result.Data[0];
            });
    }

    $scope.rgrid = {
        data: [],
        columnDefs: $scope.roptionsGrid,
        onRegisterApi: function (gridApi) {
            $scope.grid1Api = gridApi;
        },
        appScopeProvider: $scope,
        enableRowSelection: true
    };
   


    $scope.searchRestaurant = function () {
        $scope.rName = "";
    }


    $scope.registerRestaurant = function () {
        console.log("Registrado");
    }
    $scope.update = function() {

        restaurantService.update($scope.editRestaurant)
            .then(function(obj) {
                location.href = '/#/restaurants';
            });
    }

    restaurantService.get()
     .then(function (resp) {

         $scope.rgrid.data = resp.Data;
         $scope.data = resp.Data;

        });

    $scope.refreshData = function () {
        $scope.rgrid.data = $filter('filter')($scope.data, $scope.searchText);
    };


    $scope.rModel = modelService.getRestaurantModel();

    $scope.save = function () {
        cfpLoadingBar.start();
        restaurantService.save($scope.rModel).then(function(obj) {
            location.href = '/#/restaurants';
        });
    }

    $scope.remove = function (idn) {
        cfpLoadingBar.start();
        restaurantService.delete({ id: idn })
            .then(function() {
                restaurantService.get()
                 .then(function (resp) {
                     $scope.rgrid.data = resp.Data;
                     $scope.data = resp.Data;
                 });
            });
    }
});