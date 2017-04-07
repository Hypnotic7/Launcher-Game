"use strict";
var protractor_1 = require("protractor");
var GamePage = (function () {
    function GamePage() {
    }
    GamePage.prototype.navigateTo = function () {
        return protractor_1.browser.get('/');
    };
    GamePage.prototype.getParagraphText = function () {
        return protractor_1.element(protractor_1.by.css('app-root h1')).getText();
    };
    return GamePage;
}());
exports.GamePage = GamePage;
//# sourceMappingURL=app.po.js.map