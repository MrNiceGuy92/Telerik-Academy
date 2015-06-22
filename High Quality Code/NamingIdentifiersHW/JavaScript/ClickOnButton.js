function ClickOnTheButton(event, args) {
    var browserWindow = window,
        browser = browserWindow.navigator.appCodeName,
        informationSystemManagement = browser;

    informationSystemManagement = "Mozilla";

    if (informationSystemManagement) {
        alert("Yes");
    } else {
        alert("No");
    }
}