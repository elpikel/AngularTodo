angular.module('todoTemplates', []).directive('todoItem', function() {
    return {
        restrict: 'E',
        scope: {
            isDone: '@',
            name: '@'
        },
        transclude: true,
        template:
            '<div>' +
                '<input type="checkbox" ng-model="isDone">' +
                '<span style="padding-left:5px;" class="done-{{isDone}}">{{name}}</span>' +
                '</div>',
        replace: true
    };
});