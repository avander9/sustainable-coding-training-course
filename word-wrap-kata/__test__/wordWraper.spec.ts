/**
 * @jest-environment jsdom
 */

import { Controller } from '../src/controller';

describe('the word wrap editor', () => {
    it('should Work', () => {

        const controller = new Controller();
        var spectedValue = controller.bestWraperEver("", 0)
        expect(spectedValue).toBe("");
    });
    it('When the word is empty should do nothing', () => {
        const word = '';
        const width = 2;
        const expectedWrapedWord = word;
        const returnedValue = new Controller().bestWraperEver(word, width);

        expect(returnedValue).toEqual(expectedWrapedWord);

    })
    it('When the colunmwidth is empty should do nothing', () => {
        const word = 'patata';
        const width = 0;
        const expectedWrapedWord = word;
        const returnedValue = new Controller().bestWraperEver(word, width);

        expect(returnedValue).toEqual(expectedWrapedWord);

    })
});