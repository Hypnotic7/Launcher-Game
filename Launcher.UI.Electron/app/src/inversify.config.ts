import { Container } from "inversify";
import { TYPES, ILoginService , LoginService } from "./Services/login.service";

var iocContainer = new Container();
iocContainer.bind<ILoginService>(TYPES.ILoginService).to(LoginService);

export { iocContainer };