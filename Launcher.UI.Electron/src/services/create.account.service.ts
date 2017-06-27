import { injectable, inject } from 'inversify';
import "reflect-metadata";

export interface ICreateAccount {
  createAccount(accountName: string, accountPassword: string, email: string): boolean;
}

@injectable()
export class CreateAccountService implements ICreateAccount {

    readonly url: string = "http://localhost:8080/api/CreateAccount"; 


    createAccount(accountName: string, accountPassword: string, email: string): boolean {
        alert("Creating account");

        return true;
    }
}

