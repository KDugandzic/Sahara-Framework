﻿(function () {
    'use strict';

    // TODO: replace app with your module name
    angular.module('app').directive('editLeadButtonCopyModal', ['$window', editLeadButtonCopyModal]);

    function editLeadButtonCopyModal($window) {
        // Usage:
        // 
        // Creates:
        // 
        var directive = {
            link: link,
            replace: true,     //<-- Replace the directive element with the template completly
            restrict: 'AEC',    //<-- Allows use as: Attribute, Element and Class
            templateUrl: '/angular/settings/templates/modals/editLeadButtonCopyModal.html'   //<-- replaces inline version of ---->   template: '<p>Test Directive</p>'
            //controller: controller
        }
        return directive;

        function link(scope, element, attrs) {

            
        }

        

    }

})();