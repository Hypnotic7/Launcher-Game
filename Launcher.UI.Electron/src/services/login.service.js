var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { injectable } from 'inversify';
import "reflect-metadata";
let LoginService = class LoginService {
    constructor() {
        this.url = "http://localhost:8080/api/Login";
    }
    validateLogin(accountName, accountPassword) {
        alert("start validating login");
        var xHttpRequest = new XMLHttpRequest();
        xHttpRequest.open("POST", this.url, false);
        xHttpRequest.setRequestHeader("Content-type", "application/json");
        xHttpRequest.send(JSON.stringify({ accountName: accountName, accountPassword: accountPassword }));
        var response = xHttpRequest.responseText;
        console.log(response);
        return true;
    }
};
LoginService = __decorate([
    injectable()
], LoginService);
export { LoginService };
//# sourceMappingURL=login.service.js.map