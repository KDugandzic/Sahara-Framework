﻿(function () {
    'use strict';

    var id = 'app';

    // TODO: Inject modules as needed.
    var app = angular.module('app', [
        // Angular modules 
        //'ngAnimate',        // animations
        'ngRoute',           // routing

        // Custom modules 

        // 3rd Party Modules
        'ui.bootstrap',
        'angularMoment'
    ])
        .config(function ($routeProvider, $locationProvider) {

            $routeProvider.
                when("/platform", { templateUrl: "/angular/platform/partials/platformIndex.html", caseInsensitiveMatch: true })//.
                //when("/platform/:id", { templateUrl: "/angular/platform/partials/platformDetail.html", caseInsensitiveMatch: true })   //<-- :id is route parameter


            // Hide #Hashtag from route URLs on browsers that allow it
            if (window.history && window.history.pushState) {
                $locationProvider.html5Mode(true);
            }
        });

    // Execute bootstrapping code and any dependencies.

    // inject services as needed:

    app.run(['$q', '$rootScope',
        function ($q, $rootScope) {



        }]);

})();