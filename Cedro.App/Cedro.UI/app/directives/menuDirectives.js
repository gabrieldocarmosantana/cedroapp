angular.module('menuDirectives', [])
    .directive('menuHeader',
        function ($rootScope) {
            var ddo = {};
            ddo.restrict = "AE";
            ddo.scope = {
                itens: '='
            }
            ddo.templateUrl = 'app/views/components/menuHeader.html';
            ddo.transclude = true;
            ddo.link = function (scope, element, attrs) {
                scope.GetClient = function () {
                    $rootScope.$broadcast('GetClient');
                }
            }
            return ddo;
        })