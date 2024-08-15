"use strict";

window.onload = () => {
    const _observer = new IntersectionObserver(items =>
        items.forEach(i => i.isIntersecting && i.target.classList.add("show")));
    const _observerTargets = document.querySelectorAll(".observer-target");
    _observerTargets.length > 0 && _observerTargets.forEach(i => _observer.observe(i));
    console.log(_observerTargets.length);
};