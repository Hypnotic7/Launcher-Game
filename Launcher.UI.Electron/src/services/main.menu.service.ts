import { injectable, inject } from 'inversify';
import "reflect-metadata";

export interface IMainMenuService {
}


@injectable()
export class MainMenuService implements IMainMenuService{

    readonly url: string = "http://localhost:49456/api/Login";



}