angular.module('app')
    .config(function ($routeProvider, $locationProvider) {
   
        $routeProvider
             .when("/home", {
                 templateUrl: "app/views/home.html",
                 controller: 'HomeController'
             })
             .when("/restaurants", {
                 templateUrl: "/app/views/restaurant/restaurant.html",
                 controller: 'RestaurantController'
             })
            .when("/addrestaurants", {
                templateUrl: "/app/views/restaurant/add-restaurant.html",
                controller: 'RestaurantController'
            })
            .when("/editRestaurant", {
                templateUrl: "/app/views/restaurant/edit-restaurant.html",
                controller: 'RestaurantController'
            }).when("/dishes", {
                templateUrl: "/app/views/dishes/dish.html",
                controller: 'DishController'
            })
            .when("/adddish", {
                templateUrl: "/app/views/dishes/add-dish.html",
                controller: 'DishController'
            })
            .when("/editdish", {
                templateUrl: "/app/views/dishes/edit-dish.html",
                controller: 'DishController'
            });

        $routeProvider.otherwise({ redirectTo: '/home' });
        $locationProvider.html5Mode(false);
        $locationProvider.hashPrefix('');
})