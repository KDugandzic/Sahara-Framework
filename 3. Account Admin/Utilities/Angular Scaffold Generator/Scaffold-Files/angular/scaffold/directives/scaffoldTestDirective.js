﻿(function() {
    'use strict';

    // TODO: replace app with your module name
    angular.module('app').directive('scaffoldTestDirective', ['$window', scaffoldTestDirective]);
    
    function scaffoldTestDirective($window) {
        // Usage:
        // 
        // Creates:
        // 
        var directive = {
            link: link,
            replace: true,     //<-- Replace the directive element with the template completly
            restrict: 'AEC',    //<-- Allows use as: Attribute, Element and Class
            templateUrl: '/angular/scaffold/templates/scaffoldTestDirective.html',      //<-- replaces inline version of ---->   template: '<p>Test Directive</p>'
            scope: {
                // variables
                message: "=",
                loaderType: "="
            }
        };
        return directive;

        function link(scope, element, attrs) {
        }
    }

})();