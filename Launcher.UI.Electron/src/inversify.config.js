import { Container } from 'inversify';
import { LoginService } from "./services/login.service";
import { CreateAccountService } from './services/create.account.service';
import { TYPES } from "./RegitredTypes";
var iocContainer = new Container();
iocContainer.bind(TYPES.ILoginService).to(LoginService);
iocContainer.bind(TYPES.ICreateAccount).to(CreateAccountService);
export { iocContainer };
//# sourceMappingURL=inversify.config.js.map