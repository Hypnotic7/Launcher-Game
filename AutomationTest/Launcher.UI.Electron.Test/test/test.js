var Application = require('spectron').Application
var assert = require('assert')

describe('application launch', function () {

    beforeEach(function () {
        this.app = new Application({
            path: '../../Launcher.UI.Electron/node_modules/electron/dist/electron.exe'
        })
        return this.app.start()
    })

    afterEach(function () {
        if (this.app && this.app.isRunning()) {
            return this.app.stop()
        }
    })

    it('shows an initial window', function () {
        return this.app.client.getWindowCount().then(function (count) {
            assert.equal(count, 1)
        })
    })
})




