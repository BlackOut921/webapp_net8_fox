window.onload = function () {
    var _observer = new IntersectionObserver(function (items) {
        return items.forEach(function (i) { return i.isIntersecting && i.target.classList.add("show"); });
    });
    var _observerTargets = document.querySelectorAll(".observer-target");
    _observerTargets.length > 0 && _observerTargets.forEach(function (i) { return _observer.observe(i); });
};
//# sourceMappingURL=TypeScript.js.map