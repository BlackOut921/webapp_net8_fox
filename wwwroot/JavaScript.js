﻿"use strict";

window.onload = () => {
    try {
        const _observer = new IntersectionObserver(e => {
            e.forEach(i => i.isIntersecting && i.target.classList.add("show"));
        });

        const _observerTargets = document.querySelectorAll(".observer-target");
        _observerTargets.length > 0 && _observerTargets.forEach(i => _observer.observe(i));
    }
    catch (e) {
        console.log(e);
    }
};