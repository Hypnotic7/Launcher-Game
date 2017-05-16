var describe = require('mocha').describe;

var assert = require('assert');

var Application = require('spectron').Application;

describe('First Test',
    function() {
        this.timeout(10000);
        beforeEach(function() {
            this.app = new Application({ path: '../../Launcher.UI.Electron/app.js' });
            return this.app.start();
        });
        afterEach(function() {
            if (this.app && this.app.isRunning()) {
                return this.app.stop();
            }
        });
        it('showWindow',
            function() {
               assert.equal(1,1);
            });
    });




