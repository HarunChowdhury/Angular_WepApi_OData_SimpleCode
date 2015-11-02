var todoApp = angular.module("todoApp", []);





todoApp.filter("checkedItems", function () {
    return function(items, showComplete) {
        var resultArr = [];
        angular.forEach(items, function(item) {
            if (item.done == false || showComplete == true) {
                resultArr.push(item);
            }
        });
        return resultArr;
    };
});


var model = {
    user: "Adam",
    items: [{ action: "Buy Flowers", done: true },
        { action: "Get Shoes", done: false },
        { action: "Collect Tickets", done: true },
        { action: "Call Joe", done: false }]
};

todoApp.controller("ToDoCtrl",function($scope) {

    $scope.toDo = model;
    $scope.incompleteCount = function() {
        var count = 0;
        angular.forEach($scope.toDo.items, function(item) {
            if (!item.done) {
                count++;
            }
        });
        return count;
    };
    
    $scope.warningLevel = function() {
        return $scope.incompleteCount() < 2 ? "label-success" : "label-warning";
    };

    $scope.addNewItem = function(text) {

        $scope.toDo.items.push({
               action: text,
                 done:  false
        });

    };

});





