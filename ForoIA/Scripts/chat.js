﻿(function () {

    var chatHub = $.connection.chatHub;
    $.connection.hub.logging = true;
    $.connection.hub.start();

    chatHub.client.newMessage = function (message) {

        model.addMessage(message);

    };

    var Model = function () {
        var self = this;
        self.message = ko.observable("");
        self.messages = ko.observableArray();
    };

    Model.prototype = {

        sendMessage: function () {
            var self = this;
            chatHub.server.send(self.message());
            self.message("");
        },

        addMessage: function (message) {
            var self = this;
            self.messages.push(message);
        }

    };

    var model = new Model();

    $(function () {
        ko.applyBindings(model);
    });

}());