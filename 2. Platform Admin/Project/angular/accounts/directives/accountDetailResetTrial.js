﻿(function() {
    'use strict';

    // TODO: replace app with your module name
    angular.module('app').directive('accountDetailResetTrial', ['$window', accountDetailResetTrial]);
    
    function accountDetailResetTrial($window) {
        // Usage:
        // 
        // Creates:
        // 
        var directive = {
            link: link,
            replace: true,     //<-- Replace the directive element with the template completly
            restrict: 'AEC',    //<-- Allows use as: Attribute, Element and Class
            templateUrl: '/angular/accounts/templates/accountDetailResetTrial.html'      //<-- replaces inline version of ---->   template: '<p>Test Directive</p>'
        };
        return directive;

        function link(scope, element, attrs) {
        }
    }

})();