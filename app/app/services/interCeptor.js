app.factory("interCeptor", function($location){
    return{
        'request': function(config){
            console.log("Intercepted");
            config.headers.Authorization=localStorage.getItem("token");
            // config.headers.UserAgent=localStorage.getItem("user");
            return config;
        },
        'responseError': function(rejection){
            $location.path("Ketabkhana/Login")

        }
    }
})