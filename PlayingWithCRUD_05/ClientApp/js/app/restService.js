angular.module('restDemo').service('restService', ['$resource', '$q', function ($resource, $q) {
    var fGetArray = function (url) {
        var deferred = $q.defer();
        var serverRestapi = $resource(url, {}, { get: { method: 'Get', isArray: true } });
        serverRestapi.get(
            function (response) {
                console.log(response);
                return deferred.resolve(response);
            },
            function (error) {
                console.log(error);
                return deferred.reject(error);
            }
        );

        return deferred.promise;
    };

    return {
        Get_Array: fGetArray
    };

}]);