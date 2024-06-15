<?php

namespace ccxt\pro;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

use Exception; // a common import

class binanceus extends \ccxt\pro\binance {

    public function describe() {
        // eslint-disable-next-line new-cap
        $restInstance = new \ccxt\async\binanceus ();
        $restDescribe = $restInstance->describe ();
        $extended = $this->deep_extend($restDescribe, parent::describe());
        return $this->deep_extend($extended, array(
            'id' => 'binanceus',
            'name' => 'Binance US',
            'countries' => array( 'US' ), // US
            'certified' => false,
            'urls' => array(
                'logo' => 'https://user-images.githubusercontent.com/1294454/65177307-217b7c80-da5f-11e9-876e-0b748ba0a358.jpg',
                'api' => array(
                    'ws' => array(
                        'spot' => 'wss://stream.binance.us:9443/ws',
                    ),
                    'web' => 'https://www.binance.us',
                    'sapi' => 'https://api.binance.us/sapi/v1',
                    'wapi' => 'https://api.binance.us/wapi/v3',
                    'public' => 'https://api.binance.us/api/v1',
                    'private' => 'https://api.binance.us/api/v3',
                    'v3' => 'https://api.binance.us/api/v3',
                    'v1' => 'https://api.binance.us/api/v1',
                ),
                'www' => 'https://www.binance.us',
                'referral' => 'https://www.binance.us/?ref=35005074',
                'doc' => 'https://github.com/binance-us/binance-official-api-docs',
                'fees' => 'https://www.binance.us/en/fee/schedule',
            ),
            'options' => array(
                'fetchCurrencies' => false,
                'quoteOrderQty' => false,
                'defaultType' => 'spot',
                'fetchMarkets' => array( 'spot' ),
            ),
        ));
    }
}
