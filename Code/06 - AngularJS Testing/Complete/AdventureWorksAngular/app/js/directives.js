angular.module('F1FeederApp.directives', []).
    directive('driverlink', function () {
        var directive = {};
        directive.restrict = 'E'; 
        directive.template = '<a href="#/drivers/{{driver.Driver.driverId}}">{{driver.Driver.givenName}}&nbsp;{{driver.Driver.familyName}}</a>';
        return directive;
    });
