//angular.module('restaurantServices')
//    .factory('restaurantService',
//       function ( $window, $q, restaurantResource) {
//           var service = {}
//           service.get = function () {
//               return $q(function (resolve, reject) {
//                   restaurantResource.get("",function (response) {
//                       resolve(response);
//                   },
//                  function (erro) {
//                      reject(erro);
//                  });
//               });
//           }
       
//           return service;
//       });