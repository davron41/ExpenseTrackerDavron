"use strict";

let isConnected = false;
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/notification-hub")
    .build();

connection.on("IncrementNotificationsCount", function (message) {
    console.log(message);
    const notificationsElement = document.getElementById('notifications-count');
    const notificationsCount = Number(notificationsElement.innerHTML);

    console.log(notificationsCount);

    if (notificationsCount) {
        const total = notificationsCount + 1;
        notificationsElement.innerHTML = total.toString();
    }
});

var isConnec = false;

if (!isConnected) {
    connection.start().then(function () {
        isConnected = true;
        console.log("connection started...");
    }).catch(function (err) {
        return console.error(err.toString());
    });
}
