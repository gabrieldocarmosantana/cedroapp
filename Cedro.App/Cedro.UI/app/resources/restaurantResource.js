
angular.module('restaurantResources', ['ngResource'])
    .factory('restaurantResource',
        function ($resource, $window) {

           var restaurantService = $resource;
           restaurantService = $resource(null,
                   {
                       restaurantid:'@id'
                   },
                {
                    'get': {
                        method: 'GET',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Restaurant/'
                    },
                    'getbyid': {
                        method: 'GET',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Restaurant/GetById/:restaurantid'
                    },
                    'save': {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Restaurant/Add'
                    },
                    'update': {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Restaurant/update'
                    },
                    'delete': {
                        method: 'GET',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Restaurant/Remove/:restaurantid'
                    }
                });

           return restaurantService;
        })
    .factory('restaurantService',
       function ($window, $q, restaurantResource) {
           var service = {}
           service.get = function () {
               return $q(function (resolve, reject) {
                   restaurantResource.get("", function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }

           service.getbyid  = function (model) {
               return $q(function (resolve, reject) {
                   restaurantResource.getbyid(model, function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }
           service.save = function (model) {
               return $q(function (resolve, reject) {
                   restaurantResource.save(model, function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }

           service.update = function (model) {
               return $q(function (resolve, reject) {
                   restaurantResource.save(model, function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }

           service.delete = function (model) {
               return $q(function (resolve, reject) {
                   restaurantResource.delete(model, function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }
           return service;
       });
   