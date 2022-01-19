"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

document.getElementById("userSearchButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user} says ${message}`;
});

connection.on("UserSearchResponse", function (listOfUsers) {
    console.log(listOfUsers);
    let searchList = document.getElementById("searchList");
    searchList.innerHTML = "";
    console.log(listOfUsers.length);
    if (listOfUsers.length > 0) {
        listOfUsers.forEach(function (user) {
            console.log(user)
            let li = document.createElement("li");
            li.appendChild(document.createTextNode(user.displayName + " (" + user.username + ") <" + user.email + ">"));
            searchList.appendChild(li);
        });
    } else {
        let li = document.createElement("li");
        li.appendChild(document.createTextNode("No users found :("));
        searchList.appendChild(li);
    }
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    document.getElementById("userSearchButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

function searchUser() {
    var keyword = document.getElementById("userSearchInput").value;
    connection.invoke("SearchUser", keyword).catch(function (err) {
        return console.error(err.toString());
    });
}

document.getElementById("userSearchButton").addEventListener("click", function (event) {
    searchUser();
    event.preventDefault();
});

document.getElementById("userSearchInput").addEventListener("input", function (event) {
    searchUser();
    event.preventDefault();
});