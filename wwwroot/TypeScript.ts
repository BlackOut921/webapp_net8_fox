window.onload = () => {
    const _observer = new IntersectionObserver(items =>
        items.forEach(i => i.isIntersecting && i.target.classList.add("show")));
    const _observerTargets = document.querySelectorAll(".observer-target");
    _observerTargets.length > 0 && _observerTargets.forEach(i => _observer.observe(i));

    let _testString: string = "Test string";
    let _testNumber: number = 0;
    let _testBool: boolean = false;
    const _testArray: string[] = []; //For readonly: const vName: readonly string[] = [];
};