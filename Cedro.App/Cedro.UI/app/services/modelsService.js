
angular.module('modelServices', ['ngResource'])
    .factory('modelService',
        function () {
            var service = {}
            service.getMenuItens = function () {
                var obj =
                     [
                        {
                            name: "Restaurantes",
                            link: "/#/restaurants"
                        },
                        {
                            name: "Pratos",
                            link: "/#/dishes"
                        }
                     ];

                return obj;
            }


            service.getRestaurantGridConfig = function() {
                var obj = [
                    {
                       
                        name: "Excluir",
                        width: "10%",
                        cellTemplate: '<div class="ui-grid-vcenter"><a class="btn primary btn-sm"" ng-click="grid.appScope.remove(row.entity.Id)">Excluir</a></div>'
                    },
                    {
                        //field: "",
                        name: "Editar",
                        width: "15%",
                        cellTemplate: '<div class="ui-grid-vcenter"><a class="btn primary btn-sm"" href="/#/editRestaurant/?id={{row.entity.Id}}">Editar</a></div>'
                    },
                    {
                        field: "Name",
                        name: "Restaurante",
                        width: "75%"
                     }
                ];



                return obj;
            }
            service.getRestaurantModel = function () {
                var obj = {
                    name: "",
                    id: ""
                }


                return obj;
            }



            service.getDishGridConfig = function () {
                var obj = [
                    {

                        name: "Excluir",
                        width: "10%",
                        cellTemplate: '<div class="ui-grid-vcenter"><a class="btn primary btn-sm"" ng-click="grid.appScope.remove(row.entity.DishId)" >Excluir</a></div>'
                    },
                    {
                        //field: "",
                        name: "Editar",
                        width: "15%",
                        cellTemplate: '<div class="ui-grid-vcenter"><a class="btn primary btn-sm"" href="/#/editdish/?id={{row.entity.DishId}}">Editar</a></div>'
                    },
                    {
                        field: "RestaurantName",
                        name: "Restaurante",
                        width: "15%"
                    },
                    {
                        field: "Name",
                        name: "Prato",
                        width: "50%"
                    },
                    {
                        field: "Price",
                        name: "Preço",
                        width: "50%"
                    }

                ];


                return obj;
            }

            service.getDishModel = function () {

                var obj = {
                    restaurantId: "",
                    dishId: "",
                    name: "",
                    price:""
                }


                return obj;
            }

            

            return service;
        });