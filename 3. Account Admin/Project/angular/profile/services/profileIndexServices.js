﻿(function () {
    'use strict';

    var serviceId = 'profileIndexServices';
    var urlBase = '/Profile/Json';

    // Inject into main app module:
    angular.module('app')
        .factory(serviceId, ['$http', profileIndexServices]);

    function profileIndexServices($http) {
        // Define the functions and properties to reveal.
        var service = {

            updateProfileName: updateProfileName,
            updateProfileEmail: updateProfileEmail,
            updateProfilePassword: updateProfilePassword,

            updateProfilePhoto: updateProfilePhoto,

            getOtherAccounts: getOtherAccounts,

        };

        return service;

        
        function getOtherAccounts() {
            var date = new Date();
            var cacheBuster = "?cb=" + date.getTime();

            return $http({
                method: 'GET',
                url: urlBase + '/GetOtherAccounts' + cacheBuster,
            });
        }


        function updateProfileName(firstName, lastName) {
            var date = new Date();
            var cacheBuster = "?cb=" + date.getTime();

            return $http({
                method: 'POST',
                url: urlBase + '/UpdateName' + cacheBuster,
                transformRequest: transformRequest,
                params: {
                    firstName: firstName,
                    lastName: lastName
                }
            });
        }

        function updateProfileEmail(email) {
            var date = new Date();
            var cacheBuster = "?cb=" + date.getTime();

            return $http({
                method: 'POST',
                url: urlBase + '/UpdateEmail' + cacheBuster,
                transformRequest: transformRequest,
                params: {
                    email: email
                }
            });
        }

        function updateProfilePassword(currentPassword, newPassword) {
            var date = new Date();
            var cacheBuster = "?cb=" + date.getTime();

            return $http({
                method: 'POST',
                url: urlBase + '/UpdatePassword' + cacheBuster,
                transformRequest: transformRequest,
                params: {
                    currentPassword: currentPassword,
                    newPassword: newPassword,
                }
            });
        }

        /* ==========================================
            IMAGING
        ==========================================*/


        function updateProfilePhoto(file) {

            var xhr = new XMLHttpRequest();

            xhr.open('post', urlBase + '/UploadPhoto', true)

            xhr.setRequestHeader("Content-Type", "multipart/form-data");
            xhr.setRequestHeader("X-File-Name", file.fileName);
            xhr.setRequestHeader("X-File-Size", file.fileSize);
            xhr.setRequestHeader("X-File-Type", file.fileType);

            xhr.send(file);

            return xhr;
        }


        /* ==========================================
                HELPERS
        ==========================================*/

        var transformRequest = function (data, headersGetter) {
            var headers = headersGetter();
            headers['Authorization'] = 'WSSE profile="UsernameToken"';
            headers['X-WSSE'] = 'UsernameToken ' + nonce
            headers['Content-Type'] = 'application/json';
        };

    }
})();