import { Laucher.GamePage } from './app.po';

describe('laucher.game App', () => {
  let page: Laucher.GamePage;

  beforeEach(() => {
    page = new Laucher.GamePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
