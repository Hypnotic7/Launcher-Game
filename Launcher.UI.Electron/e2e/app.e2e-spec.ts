import { GamePage } from './app.po';

describe('laucher.game App', () => {
  let page: GamePage;

  beforeEach(() => {
    page = new GamePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
