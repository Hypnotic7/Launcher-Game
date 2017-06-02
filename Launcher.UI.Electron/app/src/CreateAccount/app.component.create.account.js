"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require("@angular/core");
var create_account_service_1 = require("../Services/create.account.service");
var CreateAccountModel = (function () {
    function CreateAccountModel() {
    }
    return CreateAccountModel;
}());
exports.CreateAccountModel = CreateAccountModel;
var CreateAccountComponent = (function () {
    function CreateAccountComponent() {
        this.CreateAccountModel = new CreateAccountModel();
        this.CreateAccountService = new create_account_service_1.CreateAccountService();
    }
    return CreateAccountComponent;
}());
CreateAccountComponent = __decorate([
    core_1.Component({
        selector: 'app-create-account',
        templateUrl: './app/CreateAccount/app.component.create.account.html',
        styleUrls: ['./app/CreateAccount/app.component.create.account.css'],
        viewProviders: [create_account_service_1.CreateAccountService]
    }),
    __metadata("design:paramtypes", [])
], CreateAccountComponent);
exports.CreateAccountComponent = CreateAccountComponent;
//# sourceMappingURL=app.component.create.account.js.map