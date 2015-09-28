// Write your Javascript code.



var ProjectConroller = function ($scope, $resource) {
    var vm = this;

    var project = $resource("/api/project", {}, {
        query: { method: 'GET', isArray: true }
    })

    $scope.all = project.query();

    vm.title = '';

    activate();

    function activate() { }
}

Portfolio = angular.module('Portfolio', ['ngResource'])
Portfolio.controller('ProjectController', ['$scope', '$resource', ProjectConroller]);
