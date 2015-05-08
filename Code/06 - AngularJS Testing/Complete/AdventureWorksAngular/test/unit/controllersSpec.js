describe('Controller: driversController', function () {

    // ** Arrange **
    beforeEach(module('F1FeederApp'));

    var driversController, scope;
    beforeEach(inject(function ($controller, $rootScope, $httpBackend) {

        // Create a Mock Scope
        scope = $rootScope.$new();

        // $httpBackend is a fake for $http service
        httpBackend = $httpBackend;

        // Fake Driver Data
        httpBackend.expectJSONP(
          "http://ergast.com/api/f1/2013/driverStandings.json?callback=JSON_CALLBACK").respond(
          {
              "MRData": {
                  "StandingsTable": {
                      "StandingsLists": [{
                          "DriverStandings": [
                            {
                                "Driver": {
                                    "givenName": 'Sebastian',
                                    "familyName": 'Vettel'
                                },
                                "points": "397",
                                "nationality": "German",
                                "Constructors": [
                                    { "name": "Red Bull" }
                                ]
                            },
                            {
                                "Driver": {
                                    "givenName": 'Fernando',
                                    "familyName": 'Alonso'
                                },
                                "points": "242",
                                "nationality": "Spanish",
                                "Constructors": [
                                    { "name": "Ferrari" }
                                ]
                            },
                            {
                                "Driver": {
                                    "givenName": 'Mark',
                                    "familyName": 'Webber'
                                },
                                "points": "199",
                                "nationality": "Australian",
                                "Constructors": [
                                    { "name": "Red Bull" }
                                ]
                            }
                          ]
                      }]
                  }
              }
          }
        );

        // ** Act **
        // Create controller and pass fake scope
        driversController = $controller('driversController', { $scope: scope });

        // Then we flush the httpBackend to resolve the fake http call
        httpBackend.flush();
    }));

    // ** Assert **
    // Test that controller returns 3 drivers
    it('should return a list with three drivers', function () {
        expect(scope.driversList.length).toBe(3);
    });

    // Check drivers familyName matches fake data
    it('should retrieve the family names of the drivers', function () {
        expect(scope.driversList[0].Driver.familyName).toBe("Vettel");
        expect(scope.driversList[1].Driver.familyName).toBe("Alonso");
        expect(scope.driversList[2].Driver.familyName).toBe("Webber");
    });

});