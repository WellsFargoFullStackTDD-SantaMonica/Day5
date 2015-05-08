// Examples from Jasmine Docs

// A Simple Suite / Spec
describe("A suite is just a function", function () {
    var a;

    it("and so is a spec", function () {
        a = true;

        expect(a).toBe(true);
    });
});

// Expections and Matchers
describe("The 'toBe' matcher compares with ===", function() {
    it("and has a positive case", function() {
        expect(true).toBe(true);
    });

    it("and can have a negative case", function () {
        expect(false).not.toBe(true);
    });
});

// Matchers
describe("Included matchers:", function () {

    it("The 'toBe' matcher compares with ===", function () {
        var a = 12;
        var b = a;

        expect(a).toBe(b);
        expect(a).not.toBe(null);
    });

    describe("The 'toEqual' matcher", function () {

        it("works for simple literals and variables", function () {
            var a = 12;
            expect(a).toEqual(12);
        });

        it("should work for objects", function () {
            var foo = {
                a: 12,
                b: 34
            };
            var bar = {
                a: 12,
                b: 34
            };
            expect(foo).toEqual(bar);
        });
    });

    it("The 'toMatch' matcher is for regular expressions", function () {
        var message = "foo bar baz";

        expect(message).toMatch(/bar/);
        expect(message).toMatch("bar");
        expect(message).not.toMatch(/quux/);
    });

    it("The 'toBeDefined' matcher compares against `undefined`", function () {
        var a = {
            foo: "foo"
        };

        expect(a.foo).toBeDefined();
        expect(a.bar).not.toBeDefined();
    });

    it("The `toBeUndefined` matcher compares against `undefined`", function () {
        var a = {
            foo: "foo"
        };

        expect(a.foo).not.toBeUndefined();
        expect(a.bar).toBeUndefined();
    });

    it("The 'toBeNull' matcher compares against null", function () {
        var a = null;
        var foo = "foo";

        expect(null).toBeNull();
        expect(a).toBeNull();
        expect(foo).not.toBeNull();
    });

    it("The 'toBeTruthy' matcher is for boolean casting testing", function () {
        var a, foo = "foo";

        expect(foo).toBeTruthy();
        expect(a).not.toBeTruthy();
    });

    it("The 'toBeFalsy' matcher is for boolean casting testing", function () {
        var a, foo = "foo";

        expect(a).toBeFalsy();
        expect(foo).not.toBeFalsy();
    });

    it("The 'toContain' matcher is for finding an item in an Array", function () {
        var a = ["foo", "bar", "baz"];

        expect(a).toContain("bar");
        expect(a).not.toContain("quux");
    });

    it("The 'toBeLessThan' matcher is for mathematical comparisons", function () {
        var pi = 3.1415926,
          e = 2.78;

        expect(e).toBeLessThan(pi);
        expect(pi).not.toBeLessThan(e);
    });

    it("The 'toBeGreaterThan' matcher is for mathematical comparisons", function () {
        var pi = 3.1415926,
          e = 2.78;

        expect(pi).toBeGreaterThan(e);
        expect(e).not.toBeGreaterThan(pi);
    });

    it("The 'toBeCloseTo' matcher is for precision math comparison", function () {
        var pi = 3.1415926,
          e = 2.78;

        expect(pi).not.toBeCloseTo(e, 2);
        expect(pi).toBeCloseTo(e, 0);
    });

    it("The 'toThrow' matcher is for testing if a function throws an exception", function () {
        var foo = function () {
            return 1 + 2;
        };
        var bar = function () {
            return a + 1;
        };

        expect(foo).not.toThrow();
        expect(bar).toThrow();
    });

    it("The 'toThrowError' matcher is for testing a specific thrown exception", function () {
        var foo = function () {
            throw new TypeError("foo bar baz");
        };

        expect(foo).toThrowError("foo bar baz");
        expect(foo).toThrowError(/bar/);
        expect(foo).toThrowError(TypeError);
        expect(foo).toThrowError(TypeError, "foo bar baz");
    });
});

// beforeEach and afterEach
describe("A spec using beforeEach and afterEach", function () {
    var foo = 0;

    beforeEach(function () {
        foo += 1;
    });

    afterEach(function () {
        foo = 0;
    });

    it("is just a function, so it can contain any code", function () {
        expect(foo).toEqual(1);
    });

    it("can have more than one expectation", function () {
        expect(foo).toEqual(1);
        expect(true).toEqual(true);
    });
});

// beforeAll and afterAll
describe("A spec using beforeAll and afterAll", function () {
    var foo;

    beforeAll(function () {
        foo = 1;
    });

    afterAll(function () {
        foo = 0;
    });

    it("sets the initial value of foo before specs run", function () {
        expect(foo).toEqual(1);
        foo += 1;
    });

    it("does not reset foo between specs", function () {
        expect(foo).toEqual(2);
    });
});

// Disabling Suites
xdescribe("A spec", function () {
    var foo;

    beforeEach(function () {
        foo = 0;
        foo += 1;
    });

    it("is just a function, so it can contain any code", function () {
        expect(foo).toEqual(1);
    });
});

// Pending Specs
describe("Pending specs", function() {
    xit("can be declared 'xit'", function() {
        expect(true).toBe(false);
    });

    it("can be declared with 'it' but without a function");

    it("can be declared by calling 'pending' in the spec body", function () {
        expect(true).toBe(false);
        pending('this is why it is pending');
    });
});

// Spies
describe("A spy", function () {
    var foo, bar = null;

    beforeEach(function () {
        foo = {
            setBar: function (value) {
                bar = value;
            }
        };

        spyOn(foo, 'setBar');

        foo.setBar(123);
        foo.setBar(456, 'another param');
    });

    it("tracks that the spy was called", function () {
        expect(foo.setBar).toHaveBeenCalled();
    });

    it("tracks all the arguments of its calls", function () {
        expect(foo.setBar).toHaveBeenCalledWith(123);
        expect(foo.setBar).toHaveBeenCalledWith(456, 'another param');
    });

    it("stops all execution on a function", function () {
        expect(bar).toBeNull();
    });
});

// Call Through
describe("A spy, when configured to call through", function () {
    var foo, bar, fetchedBar;

    beforeEach(function () {
        foo = {
            setBar: function (value) {
                bar = value;
            },
            getBar: function () {
                return bar;
            }
        };

        spyOn(foo, 'getBar').and.callThrough();

        foo.setBar(123);
        fetchedBar = foo.getBar();
    });

    it("tracks that the spy was called", function () {
        expect(foo.getBar).toHaveBeenCalled();
    });

    it("should not effect other functions", function () {
        expect(bar).toEqual(123);
    });

    it("when called returns the requested value", function () {
        expect(fetchedBar).toEqual(123);
    });
});

// returnValue
describe("A spy, when configured to fake a return value", function () {
    var foo, bar, fetchedBar;

    beforeEach(function () {
        foo = {
            setBar: function (value) {
                bar = value;
            },
            getBar: function () {
                return bar;
            }
        };

        spyOn(foo, "getBar").and.returnValue(745);

        foo.setBar(123);
        fetchedBar = foo.getBar();
    });

    it("tracks that the spy was called", function () {
        expect(foo.getBar).toHaveBeenCalled();
    });

    it("should not effect other functions", function () {
        expect(bar).toEqual(123);
    });

    it("when called returns the requested value", function () {
        expect(fetchedBar).toEqual(745);
    });
});

// and.callFake
describe("A spy, when configured with an alternate implementation", function () {
    var foo, bar, fetchedBar;

    beforeEach(function () {
        foo = {
            setBar: function (value) {
                bar = value;
            },
            getBar: function () {
                return bar;
            }
        };

        spyOn(foo, "getBar").and.callFake(function () {
            return 1001;
        });

        foo.setBar(123);
        fetchedBar = foo.getBar();
    });

    it("tracks that the spy was called", function () {
        expect(foo.getBar).toHaveBeenCalled();
    });

    it("should not effect other functions", function () {
        expect(bar).toEqual(123);
    });

    it("when called returns the requested value", function () {
        expect(fetchedBar).toEqual(1001);
    });
});

// and.throwError
describe("A spy, when configured to throw an error", function () {
    var foo, bar;

    beforeEach(function () {
        foo = {
            setBar: function (value) {
                bar = value;
            }
        };

        spyOn(foo, "setBar").and.throwError("quux");
    });

    it("throws the value", function () {
        expect(function () {
            foo.setBar(123)
        }).toThrowError("quux");
    });
});

// and.Stub
describe("A spy", function () {
    var foo, bar = null;

    beforeEach(function () {
        foo = {
            setBar: function (value) {
                bar = value;
            }
        };

        spyOn(foo, 'setBar').and.callThrough();
    });

    it("can call through and then stub in the same spec", function () {
        foo.setBar(123);
        expect(bar).toEqual(123);

        foo.setBar.and.stub();
        bar = null;

        foo.setBar(123);
        expect(bar).toBe(null);
    });
});

// Other Spy Tracking Properties
describe("A spy", function() {
    var foo, bar = null;

    beforeEach(function() {
        foo = {
            setBar: function(value) {
                bar = value;
            }
        };

        spyOn(foo, 'setBar');
    });

    it("tracks if it was called at all", function() {
        expect(foo.setBar.calls.any()).toEqual(false);

        foo.setBar();

        expect(foo.setBar.calls.any()).toEqual(true);
    });

    it("tracks the number of times it was called", function() {
        expect(foo.setBar.calls.count()).toEqual(0);

        foo.setBar();
        foo.setBar();

        expect(foo.setBar.calls.count()).toEqual(2);
    });

    it("tracks the arguments of each call", function() {
        foo.setBar(123);
        foo.setBar(456, "baz");

        expect(foo.setBar.calls.argsFor(0)).toEqual([123]);
        expect(foo.setBar.calls.argsFor(1)).toEqual([456, "baz"]);
    });

    it("tracks the arguments of all calls", function() {
        foo.setBar(123);
        foo.setBar(456, "baz");

        expect(foo.setBar.calls.allArgs()).toEqual([[123],[456, "baz"]]);
    });

    it("can provide the context and arguments to all calls", function() {
        foo.setBar(123);

        expect(foo.setBar.calls.all()).toEqual([{object: foo, args: [123], returnValue: undefined}]);
    });

    it("has a shortcut to the most recent call", function() {
        foo.setBar(123);
        foo.setBar(456, "baz");

        expect(foo.setBar.calls.mostRecent()).toEqual({object: foo, args: [456, "baz"], returnValue: undefined});
    });

    it("has a shortcut to the first call", function() {
        foo.setBar(123);
        foo.setBar(456, "baz");

        expect(foo.setBar.calls.first()).toEqual({object: foo, args: [123], returnValue: undefined});
    });

    it("tracks the context", function() {
        var spy = jasmine.createSpy('spy');
        var baz = {
            fn: spy
        };
        var quux = {
            fn: spy
        };
        baz.fn(123);
        quux.fn(456);

        expect(spy.calls.first().object).toBe(baz);
        expect(spy.calls.mostRecent().object).toBe(quux);
    });

    it("can be reset", function () {
        foo.setBar(123);
        foo.setBar(456, "baz");

        expect(foo.setBar.calls.any()).toBe(true);

        foo.setBar.calls.reset();

        expect(foo.setBar.calls.any()).toBe(false);
    });
});

