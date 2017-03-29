angular.module('dishDirectives', ['ui.grid', 'ui.grid.edit', 'ui.bootstrap'])
   .directive('dishGrid',
        function () {
            var ddo = {};
            ddo.restrict = "AE";
            ddo.scope = {
                titulo: '@',
                datagrid: '='
            }
            ddo.templateUrl = 'app/views/components/dishGrid.html';
            ddo.link = function (scope, element, attrs) {

            }
            return ddo;
        });