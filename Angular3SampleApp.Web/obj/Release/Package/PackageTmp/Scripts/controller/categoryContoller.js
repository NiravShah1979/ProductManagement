/// <reference path="../services/categoryService.js" />
var app = angular.module('myApp', []);
app.constant("myConfig", {
    "url": "http://productmanagementservices.azurewebsites.net/api/categories"
}).service('categoryService', function ($http, myConfig) {
    return {
        getCategories: function () {
            return $http({
                method: "GET",
                url: myConfig.url
            }).then(function mySucces(response) {
                return response;
            }, function myError(response) {
                return response.statusText;
            });
        }
    }
})
.controller('categoryController', ['$scope', 'categoryService', function ($scope, categoryService) {
        categoryService.getCategories()
            .then(function mySucces(response) {
                $scope.categories = response.data;
            }, function myError(response) {
                console.log("Error" + response.statusText);
            });
}]);

