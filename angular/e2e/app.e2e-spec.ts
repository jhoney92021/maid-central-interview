import { MaidCentralInterviewTemplatePage } from './app.po';

describe('MaidCentralInterview App', function() {
  let page: MaidCentralInterviewTemplatePage;

  beforeEach(() => {
    page = new MaidCentralInterviewTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
