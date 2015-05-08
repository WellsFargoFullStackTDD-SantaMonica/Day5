describe('Filter: searchFilter', function () {
    beforeEach(module('F1FeederApp'));

    var data = [
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
        }];

    beforeEach(inject(function (_$filter_) {
        $filter = _$filter_;
    }));

    it('returns correct count when given null', function () {
        var searchFilter = $filter('searchFilter');
        expect(searchFilter(data, null).length).toEqual(1);
    });

    it('returns the correct value when given a string of chars', function () {
        var searchFilter = $filter('searchFilter');
        expect(searchFilter(data, 'Q').length).toEqual(0);
    });
}); 