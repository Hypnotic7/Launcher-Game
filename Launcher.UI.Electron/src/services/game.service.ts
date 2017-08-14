import { injectable, inject } from 'inversify';
import "reflect-metadata";
const config = require('../../endpointconfig.json');

export interface IGameService {
  something():void
}

@injectable()
export class GameService implements IGameService {
  private url: string = config.ApiEndpoints.GameEndpoint;
    
  something(): void {
    
  }
}
