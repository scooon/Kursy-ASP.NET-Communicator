﻿"use strict";


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
        //TODO: Dorobić obsługę readed z awatarkami.
    }
    groupMessages();
    scrollConvToEnd();
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
            div.classList.add("searchItemData");
            let displayName = document.createElement("div");
            displayName.classList.add("searchListItemDisplayName");
            displayName.appendChild(document.createTextNode(user.displayName));
            let userName = document.createElement("div");
            userName.classList.add("searchListItemUserName");
            userName.appendChild(document.createTextNode(user.username));
            let email = document.createElement("div");
            email.classList.add("searchListItemEmail");
            email.appendChild(document.createTextNode(user.email));

            let avatar = document.createElement("div");
            avatar.classList.add("avatar");
            let avatarSpan = document.createElement("span");
            avatarSpan.appendChild(document.createTextNode(getShortcut(user.username, user.displayName).toUpperCase()));
            avatar.appendChild(avatarSpan);

            li.onclick = "createConversation(" + user.id + ")";
            li.setAttribute('onclick', "createConversation(" + user.id + ")");
            div.appendChild(displayName);
            div.appendChild(userName);
            div.appendChild(email);
            li.appendChild(avatar);
            li.appendChild(div);
            searchList.appendChild(li); 

          
        });
    } else {
        let li = document.createElement("li");
        li.appendChild(document.createTextNode("No users found :("));
        searchList.appendChild(li);
    }
});

function getShortcut(username, displayName) {
    let chatName;
    if (displayName.length < 3) {
        chatName = username;
    } else {
        chatName = displayName;
    }
    let shortcut = "";
    if (chatName.includes(' ')) {
        let words = chatName.split(" ");
        for (let i = 0; i < words.length; i++) {
            if ((i == 1) || (i == words.length)) {
                shortcut += words[i].substring(0, 1);
            }
        }
        return shortcut;
    } else {
        if (chatName.length > 2) {
            shortcut = chatName.substring(0, 1);
            shortcut += chatName.substring(chatName.length - 1);
        } else {
            shortcut = chatName;
        }
        return shortcut;
    }
}

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    if (document.getElementById("messageInput").value != "") {
        sendMessage();
    }

});

function sendMessage() {
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
    document.getElementById("messageInput").value = "";
    groupMessages();
}

function showSearch() {
    document.getElementById("searchView").style.display = "block";
}

function closeSearch() {
    document.getElementById("searchView").style.display = "none";
}

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

    document.getElementById('chatWindow').style.height = (document.body.clientHeight - document.getElementsByTagName('header')[0].clientHeight - document.getElementById('messageInputBar').clientHeight * 1.5) + "px";

    document.getElementById('messageInputBar').style.height = (document.body.clientHeight - document.getElementsByTagName('header')[0].clientHeight - document.getElementById('chatWindow').clientHeight) + "px";

    document.getElementById('conversationWindow').style.height = (document.body.clientHeight - document.getElementsByTagName('header')[0].clientHeight) + "px";
}

/*function groupMessages() {
    let messages = document.getElementsByClassName("message-bubble");
    let author = "null";
    let id = 0;
    Array.from(messages).forEach((bubble) => {
        console.log(id);
        let compare = messages.length - 1;
        let last = false;
        if (!bubble.getElementsByClassName("message-bubble-author")[0].innerText.includes(author)) {
            
            //TODO: Ostatni bubble nie robi się okrągły
            if (id == 1) {
                if (!messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                    messages[id - 1].style.borderRadius = "3.1rem";
                } else {
                    if (messages[id - 1].classList.contains("my-message")) {
                        messages[id - 1].style.borderRadius = "2.1rem 0.25rem 2.1rem 2.1rem";
                    } else {
                        messages[id - 1].style.borderRadius = "0.25rem 2.1rem 2.1rem 2.1rem";
                    }
                }
            } else if (id > 1) {
                if (!messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText) && !messages[id - 2].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText)) {
                    messages[id - 1].style.borderRadius = "2.1rem";
                } else if (!messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                    messages[id].style.borderRadius = "2.1rem";
                } else {
                    if (messages[id-1].classList.contains("my-message")) {
                        messages[id-1].style.borderRadius = "2.1rem 0.25rem 2.1rem 2.1rem";
                    } else {
                        messages[id-1].style.borderRadius = "0.25rem 2.1rem 2.1rem 2.1rem";
                    }
                   
                }
            }



            bubble.getElementsByClassName("message-bubble-author")[0].style.display = 'block';


   
                if (bubble.classList.contains("my-message")) {
                    bubble.style.borderRadius = "2.1rem 2.1rem 0.25rem 2.1rem";
                } else {
                    bubble.style.borderRadius = "2.1rem 2.1rem 2.1rem 0.25rem";
                }
     
            
            
        } else {
            bubble.getElementsByClassName("message-bubble-author")[0].style.display = 'none';
            if (bubble.classList.contains("my-message")) {
                if (id == compare) {
                    console.log("działa2moja")
                    if (!messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {

                        messages[id].style.borderRadius = "2.1rem";
                    } else {
                        messages[id].style.borderRadius = "2.1rem 0.25rem 2.1rem 2.1rem";
                    }
                } else {
                    bubble.style.borderRadius = "2.1rem 0.25rem 0.25rem 2.1rem";
                }
            } else {
                if (id == compare) {
                    console.log("działa2kogos")
                    if (!messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                        messages[id].style.borderRadius = "2.1rem";
                    } else {
                        messages[id].style.borderRadius = "0.25rem 2.1rem 2.1rem 2.1rem";
                    }
                } else {
                    bubble.style.borderRadius = "0.25rem 2.1rem 2.1rem 0.25rem";
                }
            }

            
        }

        author = bubble.getElementsByClassName("message-bubble-author")[0].innerText;
        id++;
        //TODO: Zaokrąglenia przy grupowaniu z uwzględnieniem, że może być pojedyncza wiadomość oraz moja albo rozmówcy (inny róg zaokrąglony).
    });
}*/

function groupMessages() {
    let messages = document.getElementsByClassName("message-bubble");
    let author = "null";
    let id = 0;
    let compare = messages.length - 1;
    Array.from(messages).forEach((bubble) => {
        console.log(id);
        if (bubble.classList.contains("my-message")) {
            if (id == 0) {
                if (compare > id) {
                    // Jeżeli konwersacja zawiera więcej niż jedną wiadomość
                    if (messages[id + 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                        // Jeżeli kolejna wiadomość należy do tego samego autora
                        messages[id].style.borderRadius = "2.1rem 2.1rem 0.25rem 2.1rem";
                    } else {
                        // Jeżeli kolejna wiadomość należy do innego autora
                        messages[id].style.borderRadius = "2.1rem";
                    }
                } else {
                    // Jeżeli konwersacja zawiera tylko jedną wiadomość
                    messages[id].style.borderRadius = "2.1rem";
                }
            } else if (id > 0) {
                // Jeżeli to nie jest pierwsza wiadomość
                if (compare > id) {
                    // Jeżeli konwersacja zawiera więcej niż jedną wiadomość, ale to nie jest ostatnia wiadomość
                    if (messages[id + 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                        // Jeżeli kolejna wiadomość jest tego samego autora
                        if (messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                            // Jeżeli poprzednia wiadomość jest tego samego autora
                            messages[id].style.borderRadius = "2.1rem 0.25rem 0.25rem 2.1rem";
                        } else {
                            // Jeżeli poprzednia wiadomość jest innego autora
                            messages[id].style.borderRadius = "2.1rem 2.1rem 0.25rem 2.1rem";
                        }
                    } else {
                        // Jeżeli kolejna wiadomość jest innego autora
                        if (messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                            // Jeżeli poprzednia wiadomość jest tego samego autora
                            messages[id].style.borderRadius = "2.1rem 0.25rem 2.1rem 2.1rem";
                        } else {
                            // Jeżeli poprzednia wiadomość jest innego autora
                            messages[id].style.borderRadius = "2.1rem";
                        }
                    }
                } else {
                    // Jeżeli to jest ostatnia wiadomość
                    if (messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                        // Jeżeli poprzednia wiadomość jest tego samego autora
                        messages[id].style.borderRadius = "2.1rem 0.25rem 2.1rem 2.1rem";
                    } else {
                        // Jeżeli poprzednia wiadomość jest innego autora
                        messages[id].style.borderRadius = "2.1rem";
                    }
                }
            }
        } else {
            if (id == 0) {
                if (compare > id) {
                    // Jeżeli konwersacja zawiera więcej niż jedną wiadomość
                    if (messages[id + 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                        // Jeżeli kolejna wiadomość należy do tego samego autora
                        messages[id].style.borderRadius = "2.1rem 2.1rem 2.1rem 0.25rem";
                    } else {
                        // Jeżeli kolejna wiadomość należy do innego autora
                        messages[id].style.borderRadius = "2.1rem";
                    }
                } else {
                    // Jeżeli konwersacja zawiera tylko jedną wiadomość
                    messages[id].style.borderRadius = "2.1rem";
                }
            } else if (id > 0) {
                // Jeżeli to nie jest pierwsza wiadomość
                if (compare > id) {
                    // Jeżeli konwersacja zawiera więcej niż jedną wiadomość, ale to nie jest ostatnia wiadomość
                    if (messages[id + 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                        // Jeżeli kolejna wiadomość jest tego samego autora
                        if (messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                            // Jeżeli poprzednia wiadomość jest tego samego autora
                            messages[id].style.borderRadius = "0.25rem 2.1rem 2.1rem 0.25rem";
                        } else {
                            // Jeżeli poprzednia wiadomość jest innego autora
                            messages[id].style.borderRadius = "2.1rem 2.1rem 2.1rem 0.25rem";
                        }
                    } else {
                        // Jeżeli kolejna wiadomość jest innego autora
                        if (messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                            // Jeżeli poprzednia wiadomość jest tego samego autora
                            messages[id].style.borderRadius = "0.25rem 2.1rem 2.1rem 2.1rem";
                        } else {
                            // Jeżeli poprzednia wiadomość jest innego autora
                            messages[id].style.borderRadius = "2.1rem";
                        }
                    }
                } else {
                    // Jeżeli to jest ostatnia wiadomość
                    if (messages[id - 1].getElementsByClassName("message-bubble-author")[0].innerText.includes(messages[id].getElementsByClassName("message-bubble-author")[0].innerText)) {
                        // Jeżeli poprzednia wiadomość jest tego samego autora
                        messages[id].style.borderRadius = "0.25rem 2.1rem 2.1rem 2.1rem";
                    } else {
                        // Jeżeli poprzednia wiadomość jest innego autora
                        messages[id].style.borderRadius = "2.1rem";
                    }
                }
            }
        }
        id++;
    });

    let readed = [];
    for (let readedItem = messages.length - 1; readedItem >= 0; readedItem--) {
        // Nie będzie działać dla konwersacji wieloosobowych! Trzeba będzie zmodyfikować skrypt


        if (document.getElementById("messagesList").getElementsByTagName("li")[readedItem].getElementsByClassName("message-bubble-readed").length > 0) {
            if (readed.includes(document.getElementById("messagesList").getElementsByTagName("li")[readedItem].getElementsByClassName("message-bubble-readed")[0].innerText)) {
                document.getElementById("messagesList").getElementsByTagName("li")[readedItem].getElementsByClassName("message-bubble-readed")[0].style.display = "none";
            } else {
                readed.push(document.getElementById("messagesList").getElementsByTagName("li")[readedItem].getElementsByClassName("message-bubble-readed")[0].innerText);
            }
        }
    }
}

function scrollConvToEnd() {
    document.getElementById("chatWindow").scrollTo(0, parseInt(window.getComputedStyle(document.getElementById("chatWindow"), null).getPropertyValue("height")) + 200);
}

window.addEventListener('resize', function (event) {
    fitWindow();
}, true);

document.getElementById("messageInput").onkeypress = function (e) {
    //e = e || window.event;
    // use e.keyCode
    if (e.key === "Enter") {
        if (document.getElementById("messageInput").value != "") {
            sendMessage();
        }
    }
};

document.getElementById("messageInput").oninput = function (e) {
    if (document.getElementById("messageInput").value != "") {
        document.getElementById("sendButton").classList.add("messageNotEmpty");
    } else {
        document.getElementById("sendButton").classList.remove("messageNotEmpty");
    }
};

groupMessages();
scrollConvToEnd();