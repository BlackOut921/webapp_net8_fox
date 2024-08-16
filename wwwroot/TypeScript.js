window.onload = function () {
    var _observer = new IntersectionObserver(function (items) {
        return items.forEach(function (i) { return i.isIntersecting && i.target.classList.add("show"); });
    });
    var _observerTargets = document.querySelectorAll(".observer-target");
    _observerTargets.length > 0 && _observerTargets.forEach(function (i) { return _observer.observe(i); });
    var _testString = "Test string";
    var _testNumber = 0;
    var _testBool = false;
    var _testArray = []; //For readonly: const vName: readonly string[] = [];
};
//# sourceMappingURL=TypeScript.js.map