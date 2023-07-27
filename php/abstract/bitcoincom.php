<?php

namespace ccxt\abstract;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


abstract class bitcoincom extends \ccxt\fmfwio {
    public function public_get_public_currency($params = array()) {
        return $this->request('public/currency', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_symbol($params = array()) {
        return $this->request('public/symbol', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_ticker($params = array()) {
        return $this->request('public/ticker', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_price_rate($params = array()) {
        return $this->request('public/price/rate', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_trades($params = array()) {
        return $this->request('public/trades', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_orderbook($params = array()) {
        return $this->request('public/orderbook', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_candles($params = array()) {
        return $this->request('public/candles', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_futures_info($params = array()) {
        return $this->request('public/futures/info', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_futures_history_funding($params = array()) {
        return $this->request('public/futures/history/funding', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_futures_candles_index_price($params = array()) {
        return $this->request('public/futures/candles/index_price', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_futures_candles_mark_price($params = array()) {
        return $this->request('public/futures/candles/mark_price', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_futures_candles_premium_index($params = array()) {
        return $this->request('public/futures/candles/premium_index', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function public_get_public_futures_candles_open_interest($params = array()) {
        return $this->request('public/futures/candles/open_interest', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function private_get_spot_balance($params = array()) {
        return $this->request('spot/balance', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_spot_order($params = array()) {
        return $this->request('spot/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_spot_order_client_order_id($params = array()) {
        return $this->request('spot/order/{client_order_id}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_spot_fee($params = array()) {
        return $this->request('spot/fee', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_spot_fee_symbol($params = array()) {
        return $this->request('spot/fee/{symbol}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_spot_history_order($params = array()) {
        return $this->request('spot/history/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_spot_history_trade($params = array()) {
        return $this->request('spot/history/trade', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_margin_account($params = array()) {
        return $this->request('margin/account', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_margin_account_isolated_symbol($params = array()) {
        return $this->request('margin/account/isolated/{symbol}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_margin_order($params = array()) {
        return $this->request('margin/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_margin_order_client_order_id($params = array()) {
        return $this->request('margin/order/{client_order_id}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_margin_history_clearing($params = array()) {
        return $this->request('margin/history/clearing', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_margin_history_order($params = array()) {
        return $this->request('margin/history/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_margin_history_positions($params = array()) {
        return $this->request('margin/history/positions', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_margin_history_trade($params = array()) {
        return $this->request('margin/history/trade', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_balance($params = array()) {
        return $this->request('futures/balance', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_account($params = array()) {
        return $this->request('futures/account', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_account_isolated_symbol($params = array()) {
        return $this->request('futures/account/isolated/{symbol}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_order($params = array()) {
        return $this->request('futures/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_order_client_order_id($params = array()) {
        return $this->request('futures/order/{client_order_id}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_fee($params = array()) {
        return $this->request('futures/fee', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_fee_symbol($params = array()) {
        return $this->request('futures/fee/{symbol}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_history_clearing($params = array()) {
        return $this->request('futures/history/clearing', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_history_order($params = array()) {
        return $this->request('futures/history/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_history_positions($params = array()) {
        return $this->request('futures/history/positions', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_futures_history_trade($params = array()) {
        return $this->request('futures/history/trade', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_wallet_balance($params = array()) {
        return $this->request('wallet/balance', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_wallet_crypto_address($params = array()) {
        return $this->request('wallet/crypto/address', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_wallet_crypto_address_recent_deposit($params = array()) {
        return $this->request('wallet/crypto/address/recent-deposit', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_wallet_crypto_address_recent_withdraw($params = array()) {
        return $this->request('wallet/crypto/address/recent-withdraw', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_wallet_crypto_address_check_mine($params = array()) {
        return $this->request('wallet/crypto/address/check-mine', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_wallet_transactions($params = array()) {
        return $this->request('wallet/transactions', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_wallet_crypto_check_offchain_available($params = array()) {
        return $this->request('wallet/crypto/check-offchain-available', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_wallet_crypto_fee_estimate($params = array()) {
        return $this->request('wallet/crypto/fee/estimate', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_sub_account($params = array()) {
        return $this->request('sub-account', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_sub_account_acl($params = array()) {
        return $this->request('sub-account/acl', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_sub_account_balance_subaccid($params = array()) {
        return $this->request('sub-account/balance/{subAccID}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_get_sub_account_crypto_address_subaccid_currency($params = array()) {
        return $this->request('sub-account/crypto/address/{subAccID}/{currency}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function private_post_spot_order($params = array()) {
        return $this->request('spot/order', 'private', 'POST', $params, null, null, array("cost" => 1));
    }
    public function private_post_margin_order($params = array()) {
        return $this->request('margin/order', 'private', 'POST', $params, null, null, array("cost" => 1));
    }
    public function private_post_futures_order($params = array()) {
        return $this->request('futures/order', 'private', 'POST', $params, null, null, array("cost" => 1));
    }
    public function private_post_wallet_convert($params = array()) {
        return $this->request('wallet/convert', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function private_post_wallet_crypto_address($params = array()) {
        return $this->request('wallet/crypto/address', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function private_post_wallet_crypto_withdraw($params = array()) {
        return $this->request('wallet/crypto/withdraw', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function private_post_wallet_transfer($params = array()) {
        return $this->request('wallet/transfer', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function private_post_sub_account_freeze($params = array()) {
        return $this->request('sub-account/freeze', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function private_post_sub_account_activate($params = array()) {
        return $this->request('sub-account/activate', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function private_post_sub_account_transfer($params = array()) {
        return $this->request('sub-account/transfer', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function private_post_sub_account_acl($params = array()) {
        return $this->request('sub-account/acl', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function private_patch_spot_order_client_order_id($params = array()) {
        return $this->request('spot/order/{client_order_id}', 'private', 'PATCH', $params, null, null, array("cost" => 1));
    }
    public function private_patch_margin_order_client_order_id($params = array()) {
        return $this->request('margin/order/{client_order_id}', 'private', 'PATCH', $params, null, null, array("cost" => 1));
    }
    public function private_patch_futures_order_client_order_id($params = array()) {
        return $this->request('futures/order/{client_order_id}', 'private', 'PATCH', $params, null, null, array("cost" => 1));
    }
    public function private_delete_spot_order($params = array()) {
        return $this->request('spot/order', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_spot_order_client_order_id($params = array()) {
        return $this->request('spot/order/{client_order_id}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_margin_position($params = array()) {
        return $this->request('margin/position', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_margin_position_isolated_symbol($params = array()) {
        return $this->request('margin/position/isolated/{symbol}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_margin_order($params = array()) {
        return $this->request('margin/order', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_margin_order_client_order_id($params = array()) {
        return $this->request('margin/order/{client_order_id}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_futures_position($params = array()) {
        return $this->request('futures/position', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_futures_position_isolated_symbol($params = array()) {
        return $this->request('futures/position/isolated/{symbol}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_futures_order($params = array()) {
        return $this->request('futures/order', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_futures_order_client_order_id($params = array()) {
        return $this->request('futures/order/{client_order_id}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_delete_wallet_crypto_withdraw_id($params = array()) {
        return $this->request('wallet/crypto/withdraw/{id}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function private_put_margin_account_isolated_symbol($params = array()) {
        return $this->request('margin/account/isolated/{symbol}', 'private', 'PUT', $params, null, null, array("cost" => 1));
    }
    public function private_put_futures_account_isolated_symbol($params = array()) {
        return $this->request('futures/account/isolated/{symbol}', 'private', 'PUT', $params, null, null, array("cost" => 1));
    }
    public function private_put_wallet_crypto_withdraw_id($params = array()) {
        return $this->request('wallet/crypto/withdraw/{id}', 'private', 'PUT', $params, null, null, array("cost" => 1));
    }
    public function publicGetPublicCurrency($params = array()) {
        return $this->request('public/currency', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicSymbol($params = array()) {
        return $this->request('public/symbol', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicTicker($params = array()) {
        return $this->request('public/ticker', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicPriceRate($params = array()) {
        return $this->request('public/price/rate', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicTrades($params = array()) {
        return $this->request('public/trades', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicOrderbook($params = array()) {
        return $this->request('public/orderbook', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicCandles($params = array()) {
        return $this->request('public/candles', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicFuturesInfo($params = array()) {
        return $this->request('public/futures/info', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicFuturesHistoryFunding($params = array()) {
        return $this->request('public/futures/history/funding', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicFuturesCandlesIndexPrice($params = array()) {
        return $this->request('public/futures/candles/index_price', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicFuturesCandlesMarkPrice($params = array()) {
        return $this->request('public/futures/candles/mark_price', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicFuturesCandlesPremiumIndex($params = array()) {
        return $this->request('public/futures/candles/premium_index', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function publicGetPublicFuturesCandlesOpenInterest($params = array()) {
        return $this->request('public/futures/candles/open_interest', 'public', 'GET', $params, null, null, array("cost" => 10));
    }
    public function privateGetSpotBalance($params = array()) {
        return $this->request('spot/balance', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSpotOrder($params = array()) {
        return $this->request('spot/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSpotOrderClientOrderId($params = array()) {
        return $this->request('spot/order/{client_order_id}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSpotFee($params = array()) {
        return $this->request('spot/fee', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSpotFeeSymbol($params = array()) {
        return $this->request('spot/fee/{symbol}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSpotHistoryOrder($params = array()) {
        return $this->request('spot/history/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSpotHistoryTrade($params = array()) {
        return $this->request('spot/history/trade', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetMarginAccount($params = array()) {
        return $this->request('margin/account', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetMarginAccountIsolatedSymbol($params = array()) {
        return $this->request('margin/account/isolated/{symbol}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetMarginOrder($params = array()) {
        return $this->request('margin/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetMarginOrderClientOrderId($params = array()) {
        return $this->request('margin/order/{client_order_id}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetMarginHistoryClearing($params = array()) {
        return $this->request('margin/history/clearing', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetMarginHistoryOrder($params = array()) {
        return $this->request('margin/history/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetMarginHistoryPositions($params = array()) {
        return $this->request('margin/history/positions', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetMarginHistoryTrade($params = array()) {
        return $this->request('margin/history/trade', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesBalance($params = array()) {
        return $this->request('futures/balance', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesAccount($params = array()) {
        return $this->request('futures/account', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesAccountIsolatedSymbol($params = array()) {
        return $this->request('futures/account/isolated/{symbol}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesOrder($params = array()) {
        return $this->request('futures/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesOrderClientOrderId($params = array()) {
        return $this->request('futures/order/{client_order_id}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesFee($params = array()) {
        return $this->request('futures/fee', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesFeeSymbol($params = array()) {
        return $this->request('futures/fee/{symbol}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesHistoryClearing($params = array()) {
        return $this->request('futures/history/clearing', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesHistoryOrder($params = array()) {
        return $this->request('futures/history/order', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesHistoryPositions($params = array()) {
        return $this->request('futures/history/positions', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetFuturesHistoryTrade($params = array()) {
        return $this->request('futures/history/trade', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetWalletBalance($params = array()) {
        return $this->request('wallet/balance', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetWalletCryptoAddress($params = array()) {
        return $this->request('wallet/crypto/address', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetWalletCryptoAddressRecentDeposit($params = array()) {
        return $this->request('wallet/crypto/address/recent-deposit', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetWalletCryptoAddressRecentWithdraw($params = array()) {
        return $this->request('wallet/crypto/address/recent-withdraw', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetWalletCryptoAddressCheckMine($params = array()) {
        return $this->request('wallet/crypto/address/check-mine', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetWalletTransactions($params = array()) {
        return $this->request('wallet/transactions', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetWalletCryptoCheckOffchainAvailable($params = array()) {
        return $this->request('wallet/crypto/check-offchain-available', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetWalletCryptoFeeEstimate($params = array()) {
        return $this->request('wallet/crypto/fee/estimate', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSubAccount($params = array()) {
        return $this->request('sub-account', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSubAccountAcl($params = array()) {
        return $this->request('sub-account/acl', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSubAccountBalanceSubAccID($params = array()) {
        return $this->request('sub-account/balance/{subAccID}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privateGetSubAccountCryptoAddressSubAccIDCurrency($params = array()) {
        return $this->request('sub-account/crypto/address/{subAccID}/{currency}', 'private', 'GET', $params, null, null, array("cost" => 15));
    }
    public function privatePostSpotOrder($params = array()) {
        return $this->request('spot/order', 'private', 'POST', $params, null, null, array("cost" => 1));
    }
    public function privatePostMarginOrder($params = array()) {
        return $this->request('margin/order', 'private', 'POST', $params, null, null, array("cost" => 1));
    }
    public function privatePostFuturesOrder($params = array()) {
        return $this->request('futures/order', 'private', 'POST', $params, null, null, array("cost" => 1));
    }
    public function privatePostWalletConvert($params = array()) {
        return $this->request('wallet/convert', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function privatePostWalletCryptoAddress($params = array()) {
        return $this->request('wallet/crypto/address', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function privatePostWalletCryptoWithdraw($params = array()) {
        return $this->request('wallet/crypto/withdraw', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function privatePostWalletTransfer($params = array()) {
        return $this->request('wallet/transfer', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function privatePostSubAccountFreeze($params = array()) {
        return $this->request('sub-account/freeze', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function privatePostSubAccountActivate($params = array()) {
        return $this->request('sub-account/activate', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function privatePostSubAccountTransfer($params = array()) {
        return $this->request('sub-account/transfer', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function privatePostSubAccountAcl($params = array()) {
        return $this->request('sub-account/acl', 'private', 'POST', $params, null, null, array("cost" => 15));
    }
    public function privatePatchSpotOrderClientOrderId($params = array()) {
        return $this->request('spot/order/{client_order_id}', 'private', 'PATCH', $params, null, null, array("cost" => 1));
    }
    public function privatePatchMarginOrderClientOrderId($params = array()) {
        return $this->request('margin/order/{client_order_id}', 'private', 'PATCH', $params, null, null, array("cost" => 1));
    }
    public function privatePatchFuturesOrderClientOrderId($params = array()) {
        return $this->request('futures/order/{client_order_id}', 'private', 'PATCH', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteSpotOrder($params = array()) {
        return $this->request('spot/order', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteSpotOrderClientOrderId($params = array()) {
        return $this->request('spot/order/{client_order_id}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteMarginPosition($params = array()) {
        return $this->request('margin/position', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteMarginPositionIsolatedSymbol($params = array()) {
        return $this->request('margin/position/isolated/{symbol}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteMarginOrder($params = array()) {
        return $this->request('margin/order', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteMarginOrderClientOrderId($params = array()) {
        return $this->request('margin/order/{client_order_id}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteFuturesPosition($params = array()) {
        return $this->request('futures/position', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteFuturesPositionIsolatedSymbol($params = array()) {
        return $this->request('futures/position/isolated/{symbol}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteFuturesOrder($params = array()) {
        return $this->request('futures/order', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteFuturesOrderClientOrderId($params = array()) {
        return $this->request('futures/order/{client_order_id}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privateDeleteWalletCryptoWithdrawId($params = array()) {
        return $this->request('wallet/crypto/withdraw/{id}', 'private', 'DELETE', $params, null, null, array("cost" => 1));
    }
    public function privatePutMarginAccountIsolatedSymbol($params = array()) {
        return $this->request('margin/account/isolated/{symbol}', 'private', 'PUT', $params, null, null, array("cost" => 1));
    }
    public function privatePutFuturesAccountIsolatedSymbol($params = array()) {
        return $this->request('futures/account/isolated/{symbol}', 'private', 'PUT', $params, null, null, array("cost" => 1));
    }
    public function privatePutWalletCryptoWithdrawId($params = array()) {
        return $this->request('wallet/crypto/withdraw/{id}', 'private', 'PUT', $params, null, null, array("cost" => 1));
    }
}
