﻿(function () {
    'use strict';

    // TODO: replace app with your module name
    angular.module('app').directive('invoiceHistoryPanel', ['$window', invoiceHistoryPanel]);

    function invoiceHistoryPanel($window) {
        // Usage:
        // 
        // Creates:
        // 
        var directive = {
            link: link,
            replace: true,     //<-- Replace the directive element with the template completly
            restrict: 'AEC',    //<-- Allows use as: Attribute, Element and Class
            templateUrl: '/angular/billing/templates/invoiceHistoryPanel.html'   //<-- replaces inline version of ---->   template: '<p>Test Directive</p>'
            //controller: controller
        }
        return directive;

        function link(scope, element, attrs) {

            
        }

        

    }

})();