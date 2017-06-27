var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { injectable } from 'inversify';
import "reflect-metadata";
let CreateAccountService = class CreateAccountService {
    constructor() {
        this.url = "http://localhost:8080/api/CreateAccount";
    }
    createAccount(accountName, accountPassword, email) {
        alert("Creating account");
        return true;
    }
};
CreateAccountService = __decorate([
    injectable()
], CreateAccountService);
export { CreateAccountService };
//# sourceMappingURL=create.account.service.js.map