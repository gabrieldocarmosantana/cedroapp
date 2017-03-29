angular.module('restaurantsDirectives', ['ui.grid', 'ui.grid.edit', 'ui.bootstrap'])
   .directive('restaurantGrid',
        function () {
            var ddo = {};
            ddo.restrict = "AE";
            ddo.scope = {
                titulo: '@',
                datagrid: '='
            }
            ddo.templateUrl = 'app/views/components/restaurantGrid.html';
            ddo.link = function (scope, element, attrs) {

            }
            return ddo;
    });