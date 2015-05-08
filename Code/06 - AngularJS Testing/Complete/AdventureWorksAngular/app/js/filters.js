angular.module('F1FeederApp.filters', []).
    filter('searchFilter', function () {
        return function (drivers, nameFilter) {
            if (nameFilter === null) return drivers;

            var filtered = [];
            var match = new RegExp(nameFilter, 'i');
            for (var i = 0; i < drivers.length; i++) {
                var driver = drivers[i];
                if (match.test(driver.Driver.givenName) || match.test(driver.Driver.familyName)) {
                    filtered.push(driver);
                }
            }
            return filtered;
        };
    });
