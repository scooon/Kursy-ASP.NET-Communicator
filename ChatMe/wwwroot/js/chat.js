"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;


connection.on("newMessage", function (message) {
    let newMessage = JSON.parse(message);
    console.log(newMessage);
    var dt = new Date(newMessage.createdTime);
    console.log(dt.getFullYear());
    // Temp visualisation
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    //li.textContent = `${newMessage.displayName}: ${newMessage.messageContent} | ${dt.getHours()}:${dt.getMinutes()}`

    if (newMessage.creatorID == myID) {
        console.log("moja");
        li.innerHTML = `<li><div class="message-bubble my-message"><div class="message-bubble-author">${newMessage.displayName} (${newMessage.username})</div>
              <div class="message-bubble-content">
                                ${newMessage.messageContent}
              </div>
              <div class="message-bubble-createdTime">
                                ${dt.getHours()}:${dt.getMinutes()}
              </div>
            </div></li>`;
    }
    else {
        li.innerHTML = `<li><div class="message-bubble"><div class="message-bubble-author">${newMessage.displayName} (${newMessage.username})</div>
              <div class="message-bubble-content">
                                ${newMessage.messageContent}
              </div>
              <div class="message-bubble-createdTime">
                                ${dt.getHours()}:${dt.getMinutes()}
              </div>
            </div></li>`;
    }

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
            let div = document.createElement("div");
            let label = document.createTextNode(user.displayName + " (" + user.username + ") <" + user.email + ">");
            div.onclick = "createConversation(" + user.id + ")";
            div.setAttribute('onclick', "createConversation(" + user.id + ")");
            div.appendChild(label);
            li.appendChild(div);
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
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {

    var message = document.getElementById("messageInput").value;
    const urlParams = new URLSearchParams(window.location.search);
    var conversationID = parseInt(urlParams.get('conversation'));
    console.log(conversationID);
    if (Number.isInteger(conversationID)) {
        console.log(conversationID);
        connection.invoke("SendMessage", conversationID, message).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    }
});

function searchUser() {
    var keyword = document.getElementById("userSearchInput").value;
    connection.invoke("SearchUser", keyword).catch(function (err) {
        return console.error(err.toString());
    });
    console.log($.connection.hub.id);
}


document.getElementById("userSearchInput").addEventListener("input", function (event) {
    searchUser();
    event.preventDefault();
});

// Create conversation

function createConversation(userID) {
    let members = new Array();
    members.push(userID);
    console.log(JSON.stringify(members));
    connection.invoke("CreateConversation", JSON.stringify(members)).catch(function (err) {
        return console.error(err.toString());
    });
}

connection.on("SwitchToConversation", function (conversationID) {
    let searchParams;
    if ('URLSearchParams' in window) {
        searchParams = new URLSearchParams(window.location.search);
    } else {
        searchParams = new URLSearchParams();
    }
    searchParams.set("conversation", conversationID);
    window.location.search = searchParams.toString();
});


fitWindow();

function fitWindow() {

    document.getElementById('appWindow').style.height = (document.body.clientHeight - document.getElementsByTagName('header')[0].clientHeight) + "px";

    document.getElementById('rightPane').style.height = (document.body.clientHeight - document.getElementsByTagName('header')[0].clientHeight) + "px";

    document.getElementById('chatWindow').style.height = (document.body.clientHeight - document.getElementsByTagName('header')[0].clientHeight - document.getElementById('messageInputBar').clientHeight) + "px";

    document.getElementById('conversationWindow').style.height = (document.body.clientHeight - document.getElementsByTagName('header')[0].clientHeight) + "px";
}

window.addEventListener('resize', function (event) {
    fitWindow();
}, true);