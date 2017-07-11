import { injectable, inject } from 'inversify';
import "reflect-metadata";

export interface IMainMenuService {
    logout(accountName: string);
}


@injectable()
export class MainMenuService implements IMainMenuService{

    readonly url: string = "http://localhost:49456/api/MainMenu";

    logout(accountName: string): boolean {
        alert("Logging Out");
        var xHttpRequest: XMLHttpRequest = new XMLHttpRequest();
        xHttpRequest.open("POST", this.url, false);
        xHttpRequest.setRequestHeader("Content-type", "application/json");
        xHttpRequest.send(JSON.stringify({ accountName: accountName}));

        var response = xHttpRequest.responseText;

        console.log(response);
        if (response.search("true") === -1) {
            return false;
        }
        return true;  
    }


}