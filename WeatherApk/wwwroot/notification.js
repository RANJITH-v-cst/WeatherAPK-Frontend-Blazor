
window.requestNotificationPermission = async () => {
    if (!("Notification" in window)) {
        console.log("This browser does not support desktop notification");
        return;
    }

    if (Notification.permission !== "granted" && Notification.permission !== "denied") {
        await Notification.requestPermission();
    }
};


window.showWeatherNotification = (title, message) => {
    if ("Notification" in window) {
        if (Notification.permission === "granted") {
            new Notification(title, {
                body: message,
                icon: '/favicon.ico' // Optional: add your own icon
            });
        }
    }
};