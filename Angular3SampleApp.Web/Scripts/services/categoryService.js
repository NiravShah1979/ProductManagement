var app = angular.module('myApp');
app.service('categoryService', function ($http) {
    return function getCategories() {
        $http({
            method: "GET",
            url: "http://localhost:25828/api/categories"
        }).then(function mySucces(response) {
            return response.data;
        }, function myError(response) {
            return response.statusText;
        });
    }
});