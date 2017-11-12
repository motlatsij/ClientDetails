var app = angular.module('myApp', []);
//var baseURL = "http://localhost:64542";
app.controller('clientCtrl', function ($scope, $http) {
    $scope.getClient = function (id) {

        return $http.get("/home/GetIdentityTypes/" + id)
            .then(function (response) {
                $scope.IdentityTypes = response.data;

                $http.get("/home/edit/" + id)
                    .then(function (response) {
                        $scope.client = response.data;
                        $scope.client.DateofBirth = parseJsonDate($scope.client.DateofBirth);
                    });

            });
    };

    $scope.updateClient = function () {
        return $http.post("/home/edit", JSON.stringify($scope.client))
            .then(function (response) {
                alert("Record updated");
            }), function errorCallback(response) {
                alert("Unsuccessful");
            };
    };

    $scope.getClient(1); // Hardcode since I will be dealing with only 1 record, otherwise i could have returned a list and pass the Id as parameter on the edit screen
});

function parseJsonDate(jsonDateString) {
    return new Date(parseInt(jsonDateString.replace('/Date(', '')));
}