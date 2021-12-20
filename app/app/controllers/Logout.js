// app.controller("Logout",function($http, $location){
//     $http.get("https://localhost:44348/api/Logout")
//     .then(function(rsp){
//         localStorage.removeItem("token");
//         localStorage.removeItem("user");
//     },
//     function(err){
//         console.log(err);
//     });
//     $location.path("Ketabkhana/Login")
// });


app.controller("Logout",function($scope,ajax, $location){
    ajax.get("api/Logout",success,error);
    function success(response){
        localStorage.removeItem("token");
        localStorage.removeItem("user");
    }
    function error(error){
        console.log(error);

    }
    $location.path("Ketabkhana/Login")

});
