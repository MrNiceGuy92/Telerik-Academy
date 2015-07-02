function ClickOnTheButton(event, args) {
    var browserWindow = window,
        browser = browserWindow.navigator.appCodeName,
        isMozzila = browser == "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}