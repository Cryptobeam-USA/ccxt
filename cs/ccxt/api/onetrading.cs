// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class onetrading : Exchange
{
    public onetrading (object args = null): base(args) {}

    public async Task<object> publicGetCurrencies (object parameters = null)
    {
        return await this.callAsync ("publicGetCurrencies",parameters);
    }

    public async Task<object> publicGetCandlesticksInstrumentCode (object parameters = null)
    {
        return await this.callAsync ("publicGetCandlesticksInstrumentCode",parameters);
    }

    public async Task<object> publicGetFees (object parameters = null)
    {
        return await this.callAsync ("publicGetFees",parameters);
    }

    public async Task<object> publicGetInstruments (object parameters = null)
    {
        return await this.callAsync ("publicGetInstruments",parameters);
    }

    public async Task<object> publicGetOrderBookInstrumentCode (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderBookInstrumentCode",parameters);
    }

    public async Task<object> publicGetMarketTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketTicker",parameters);
    }

    public async Task<object> publicGetMarketTickerInstrumentCode (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketTickerInstrumentCode",parameters);
    }

    public async Task<object> publicGetPriceTicksInstrumentCode (object parameters = null)
    {
        return await this.callAsync ("publicGetPriceTicksInstrumentCode",parameters);
    }

    public async Task<object> publicGetTime (object parameters = null)
    {
        return await this.callAsync ("publicGetTime",parameters);
    }

    public async Task<object> privateGetAccountBalances (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountBalances",parameters);
    }

    public async Task<object> privateGetAccountDepositCryptoCurrencyCode (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountDepositCryptoCurrencyCode",parameters);
    }

    public async Task<object> privateGetAccountDepositFiatEUR (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountDepositFiatEUR",parameters);
    }

    public async Task<object> privateGetAccountDeposits (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountDeposits",parameters);
    }

    public async Task<object> privateGetAccountDepositsBitpanda (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountDepositsBitpanda",parameters);
    }

    public async Task<object> privateGetAccountWithdrawals (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountWithdrawals",parameters);
    }

    public async Task<object> privateGetAccountWithdrawalsBitpanda (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountWithdrawalsBitpanda",parameters);
    }

    public async Task<object> privateGetAccountFees (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountFees",parameters);
    }

    public async Task<object> privateGetAccountOrders (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountOrders",parameters);
    }

    public async Task<object> privateGetAccountOrdersOrderId (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountOrdersOrderId",parameters);
    }

    public async Task<object> privateGetAccountOrdersOrderIdTrades (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountOrdersOrderIdTrades",parameters);
    }

    public async Task<object> privateGetAccountTrades (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountTrades",parameters);
    }

    public async Task<object> privateGetAccountTradesTradeId (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountTradesTradeId",parameters);
    }

    public async Task<object> privateGetAccountTradingVolume (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountTradingVolume",parameters);
    }

    public async Task<object> privatePostAccountDepositCrypto (object parameters = null)
    {
        return await this.callAsync ("privatePostAccountDepositCrypto",parameters);
    }

    public async Task<object> privatePostAccountWithdrawCrypto (object parameters = null)
    {
        return await this.callAsync ("privatePostAccountWithdrawCrypto",parameters);
    }

    public async Task<object> privatePostAccountWithdrawFiat (object parameters = null)
    {
        return await this.callAsync ("privatePostAccountWithdrawFiat",parameters);
    }

    public async Task<object> privatePostAccountFees (object parameters = null)
    {
        return await this.callAsync ("privatePostAccountFees",parameters);
    }

    public async Task<object> privatePostAccountOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostAccountOrders",parameters);
    }

    public async Task<object> privateDeleteAccountOrders (object parameters = null)
    {
        return await this.callAsync ("privateDeleteAccountOrders",parameters);
    }

    public async Task<object> privateDeleteAccountOrdersOrderId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteAccountOrdersOrderId",parameters);
    }

    public async Task<object> privateDeleteAccountOrdersClientClientId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteAccountOrdersClientClientId",parameters);
    }

}