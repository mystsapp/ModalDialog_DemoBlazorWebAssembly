var bweInterop = {};

bweInterop.getPosition = async function () {
    function getPositionAsync() {
        return new Promise((success, error) => {
            navigator.geolocation.getCurrentPosition(success, error); // (success, error) : true, false
        });
    }

    if (navigator.geolocation) {
        var position = await getPositionAsync();
        var coords = {
            latitude: position.coords.latitude,
            longitude: position.coords.longitude
        };

        return coords;
    } else {
        throw Error("Geolaction is not supported by this browser.");
    }
}