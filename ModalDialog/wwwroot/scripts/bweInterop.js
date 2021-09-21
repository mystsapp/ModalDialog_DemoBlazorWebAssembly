var bweInterop = {};
bweInterop.setDocumentTitle = function (title) {
    document.title = title;
}

bweInterop.getWindowSize = function () {
    var size = {
        width: window.innerWidth,
        height: window.innerHeight
    }
    return size;
}