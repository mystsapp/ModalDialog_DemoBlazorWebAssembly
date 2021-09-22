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

bweInterop.registerResizeHangler = function (dotNetObjectRef) {
    function resizeHandler() {
        dotNetObjectRef.invokMethodAsynce('GetWindowSize', {
            width: window.innerWidth,
            height: window.innerHeight
        });
    }

    resizeHandler();
    window.addEventListener("resize", resizeHandler);
}