function TodoController($scope, $http) {
    $http.get("/api/todolist").success(function(data, status, headers, config) {
        $scope.todos = data;
    })
    .error(function(data, status, headers, config) {
        $scope.errorMessage = data.Message;
    });

    $scope.addTodo = function() {
        var todoItem = { Name: $scope.todoText, IsDone: false };

        $http.put("/api/todo", todoItem).success(function(data, status, headers, config) {
            $scope.todos.push(todoItem);
            $scope.todoText = '';
            $scope.errorMessage = '';
        })
        .error(function(data, status, headers, config) {
            $scope.errorMessage = data.Message;
        });
    };

    $scope.remaining = function() {
        var count = 0;

        angular.forEach($scope.todos, function(todo) {
            count += todo.IsDone ? 0 : 1;
        });

        return count;
    };
}