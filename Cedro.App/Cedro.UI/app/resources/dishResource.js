
angular.module('dishResources', ['ngResource'])
    .factory('dishResource',
        function ($resource, $window) {

           var restaurantService = $resource;
           restaurantService = $resource(null,
                {
                    dishid:'@id'
                },
                {
                    'get': {
                        method: 'GET',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Dishes/'
                    },
                    'getbyid': {
                        method: 'GET',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Dishes/GetById/:dishid'
                    },
                    'save': {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Dishes/Add'
                    },
                    'update': {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Dishes/Update'
                    },
                    'delete': {
                        method: 'GET',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        url: 'http://localhost:53879/Dishes/remove/:dishid'
                    }
                });

           return restaurantService;
        })
     .factory('dishService',
       function ($window, $q, dishResource) {
           var service = {}
           service.get = function () {
               return $q(function (resolve, reject) {
                   dishResource.get("", function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }

           service.save = function (model) {
               return $q(function (resolve, reject) {
                   dishResource.save(model, function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }

           service.getbyid = function (model) {
               return $q(function (resolve, reject) {
                   dishResource.getbyid(model, function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }

           service.update = function (model) {
               return $q(function (resolve, reject) {
                   dishResource.update(model, function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }
           service.delete = function (model) {
               return $q(function (resolve, reject) {
                   dishResource.delete(model, function (response) {
                       resolve(response);
                   },
                  function (erro) {
                      reject(erro);
                  });
               });
           }
           return service;
       });
