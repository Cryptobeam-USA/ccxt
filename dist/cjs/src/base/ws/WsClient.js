'use strict';

var Client = require('./Client.js');
var platform = require('../functions/platform.js');
require('../../static_dependencies/crypto-js/crypto-js.cjs.js');
require('../../static_dependencies/qs/index.cjs.js');
require('../../static_dependencies/BN/bn.cjs.js');
require('../functions/crypto.js');
var time = require('../functions/time.js');
var WebSocket = require('ws');

function _interopDefaultLegacy (e) { return e && typeof e === 'object' && 'default' in e ? e : { 'default': e }; }

var WebSocket__default = /*#__PURE__*/_interopDefaultLegacy(WebSocket);

const WebSocketPlatform = platform.isNode ? WebSocket__default["default"] : self.WebSocket;
class WsClient extends Client {
    createConnection() {
        if (this.verbose) {
            this.log(new Date(), 'connecting to', this.url);
        }
        this.connectionStarted = time.milliseconds();
        this.setConnectionTimeout();
        if (platform.isNode) {
            this.connection = new WebSocketPlatform(this.url, this.protocols, this.options);
        }
        else {
            this.connection = new WebSocketPlatform(this.url, this.protocols);
        }
        this.connection.onopen = this.onOpen.bind(this);
        this.connection.onmessage = this.onMessage.bind(this);
        this.connection.onerror = this.onError.bind(this);
        this.connection.onclose = this.onClose.bind(this);
        if (platform.isNode) {
            this.connection
                .on('ping', this.onPing.bind(this))
                .on('pong', this.onPong.bind(this))
                .on('upgrade', this.onUpgrade.bind(this));
        }
        // this.connection.terminate () // debugging
        // this.connection.close () // debugging
    }
    connect(backoffDelay = 0) {
        if (!this.startedConnecting) {
            this.startedConnecting = true;
            // exponential backoff for consequent ws connections if necessary
            if (backoffDelay) {
                time.sleep(backoffDelay).then(this.createConnection.bind(this));
            }
            else {
                this.createConnection();
            }
        }
        return this.connected;
    }
    isOpen() {
        return (this.connection.readyState === WebSocketPlatform.OPEN);
    }
    close() {
        if (this.connection instanceof WebSocketPlatform) {
            return this.connection.close();
        }
    }
}

module.exports = WsClient;
