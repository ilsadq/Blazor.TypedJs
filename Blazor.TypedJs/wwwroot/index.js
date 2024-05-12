let _typed;

export function init(elementId, strings, typeSpeed) {
    _typed = new Typed("#" + elementId, {
        strings,
        typeSpeed,
    });
}

export function dispose() {
    if (_typed) _typed.destroy();
}
