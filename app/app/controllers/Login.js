// app.controller("Login",function($scope, $http, $location){
//     $scope.login = function(){

//         $http.post("https://localhost:44348/api/Login", $scope.data)
//         .then(function success(resp){

            
//             console.log("success from login");
//             if(resp == null)
//             {
//                 console.log("Null type");
//                 alert("Invalid Username or Password");
//                 $scope.invalid = "Invalid Username or Password"
//             }
            
//             // console.log(resp.data);
//             // console.log(resp.data.UserName);
//             // console.log(resp.data.Type);
//             localStorage.setItem("token", resp.data.AccessToken);
//             localStorage.setItem("user", resp.data.UserName);

//             var type = resp.data.Type;


//             if(type == "Admin")
//             {
//                 $location.path("Admin/Home")
//                 console.log(type);
//             }
//             else if(type == "Customer")
//             {
//                 $location.path("Customer/Home")
//                 console.log(type);
//             }
//             else if(type == "Shop")
//             {
//                 $location.path("Shop/Home")
//                 console.log(type);
//             }
//             else if(type == "Employee")
//             {
//                 $location.path("Employee/AllOrders")
//                 console.log(type);
//             }


            

            
//         },
//         function error(err){
            
//             console.log(err);
//             console.log("Error from login");
//         });
//     }
    
// });




app.controller("Login",function($scope, ajax, $location){

    $scope.login = function(){

        ajax.post("api/Login",$scope.data, success, error)
        function success(resp){
            console.log("success from login");
            if(resp == null)
            {
                console.log("Null type");
                alert("Invalid Username or Password");
                $scope.invalid = "Invalid Username or Password"
            }
            
            // console.log(resp.data);
            // console.log(resp.data.UserName);
            // console.log(resp.data.Type);
            localStorage.setItem("token", resp.data.AccessToken);
            localStorage.setItem("user", resp.data.UserName);

            var type = resp.data.Type;


            if(type == "Admin")
            {
                $location.path("Admin/Home")
                console.log(type);
            }
            else if(type == "Customer")
            {
                $location.path("Customer/Home")
                console.log(type);
            }
            else if(type == "Shop")
            {
                $location.path("Shop/Home")
                console.log(type);
            }
            else if(type == "Employee")
            {
                $location.path("Employee/AllOrders")
                console.log(type);
            }

        }
        
        function error(err){
            
            console.log(err);
            console.log("Error from login");
            
        }
    }
});

