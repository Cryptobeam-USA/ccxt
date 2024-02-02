// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class bitstamp : Exchange
{
    public bitstamp (object args = null): base(args) {}

    public async Task<object> publicGetOhlcPair (object parameters = null)
    {
        return await this.callAsync ("publicGetOhlcPair",parameters);
    }

    public async Task<object> publicGetOrderBookPair (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderBookPair",parameters);
    }

    public async Task<object> publicGetTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetTicker",parameters);
    }

    public async Task<object> publicGetTickerHourPair (object parameters = null)
    {
        return await this.callAsync ("publicGetTickerHourPair",parameters);
    }

    public async Task<object> publicGetTickerPair (object parameters = null)
    {
        return await this.callAsync ("publicGetTickerPair",parameters);
    }

    public async Task<object> publicGetTransactionsPair (object parameters = null)
    {
        return await this.callAsync ("publicGetTransactionsPair",parameters);
    }

    public async Task<object> publicGetTradingPairsInfo (object parameters = null)
    {
        return await this.callAsync ("publicGetTradingPairsInfo",parameters);
    }

    public async Task<object> publicGetCurrencies (object parameters = null)
    {
        return await this.callAsync ("publicGetCurrencies",parameters);
    }

    public async Task<object> publicGetEurUsd (object parameters = null)
    {
        return await this.callAsync ("publicGetEurUsd",parameters);
    }

    public async Task<object> publicGetTravelRuleVasps (object parameters = null)
    {
        return await this.callAsync ("publicGetTravelRuleVasps",parameters);
    }

    public async Task<object> privateGetTravelRuleContacts (object parameters = null)
    {
        return await this.callAsync ("privateGetTravelRuleContacts",parameters);
    }

    public async Task<object> privateGetContactsContactUuid (object parameters = null)
    {
        return await this.callAsync ("privateGetContactsContactUuid",parameters);
    }

    public async Task<object> privateGetEarnSubscriptions (object parameters = null)
    {
        return await this.callAsync ("privateGetEarnSubscriptions",parameters);
    }

    public async Task<object> privateGetEarnTransactions (object parameters = null)
    {
        return await this.callAsync ("privateGetEarnTransactions",parameters);
    }

    public async Task<object> privatePostAccountBalances (object parameters = null)
    {
        return await this.callAsync ("privatePostAccountBalances",parameters);
    }

    public async Task<object> privatePostAccountBalancesCurrency (object parameters = null)
    {
        return await this.callAsync ("privatePostAccountBalancesCurrency",parameters);
    }

    public async Task<object> privatePostBalance (object parameters = null)
    {
        return await this.callAsync ("privatePostBalance",parameters);
    }

    public async Task<object> privatePostBalancePair (object parameters = null)
    {
        return await this.callAsync ("privatePostBalancePair",parameters);
    }

    public async Task<object> privatePostBchWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostBchWithdrawal",parameters);
    }

    public async Task<object> privatePostBchAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostBchAddress",parameters);
    }

    public async Task<object> privatePostUserTransactions (object parameters = null)
    {
        return await this.callAsync ("privatePostUserTransactions",parameters);
    }

    public async Task<object> privatePostUserTransactionsPair (object parameters = null)
    {
        return await this.callAsync ("privatePostUserTransactionsPair",parameters);
    }

    public async Task<object> privatePostCryptoTransactions (object parameters = null)
    {
        return await this.callAsync ("privatePostCryptoTransactions",parameters);
    }

    public async Task<object> privatePostOpenOrdersAll (object parameters = null)
    {
        return await this.callAsync ("privatePostOpenOrdersAll",parameters);
    }

    public async Task<object> privatePostOpenOrdersPair (object parameters = null)
    {
        return await this.callAsync ("privatePostOpenOrdersPair",parameters);
    }

    public async Task<object> privatePostOrderStatus (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderStatus",parameters);
    }

    public async Task<object> privatePostCancelOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelOrder",parameters);
    }

    public async Task<object> privatePostCancelAllOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelAllOrders",parameters);
    }

    public async Task<object> privatePostCancelAllOrdersPair (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelAllOrdersPair",parameters);
    }

    public async Task<object> privatePostBuyPair (object parameters = null)
    {
        return await this.callAsync ("privatePostBuyPair",parameters);
    }

    public async Task<object> privatePostBuyMarketPair (object parameters = null)
    {
        return await this.callAsync ("privatePostBuyMarketPair",parameters);
    }

    public async Task<object> privatePostBuyInstantPair (object parameters = null)
    {
        return await this.callAsync ("privatePostBuyInstantPair",parameters);
    }

    public async Task<object> privatePostSellPair (object parameters = null)
    {
        return await this.callAsync ("privatePostSellPair",parameters);
    }

    public async Task<object> privatePostSellMarketPair (object parameters = null)
    {
        return await this.callAsync ("privatePostSellMarketPair",parameters);
    }

    public async Task<object> privatePostSellInstantPair (object parameters = null)
    {
        return await this.callAsync ("privatePostSellInstantPair",parameters);
    }

    public async Task<object> privatePostTransferToMain (object parameters = null)
    {
        return await this.callAsync ("privatePostTransferToMain",parameters);
    }

    public async Task<object> privatePostTransferFromMain (object parameters = null)
    {
        return await this.callAsync ("privatePostTransferFromMain",parameters);
    }

    public async Task<object> privatePostMyTradingPairs (object parameters = null)
    {
        return await this.callAsync ("privatePostMyTradingPairs",parameters);
    }

    public async Task<object> privatePostFeesTrading (object parameters = null)
    {
        return await this.callAsync ("privatePostFeesTrading",parameters);
    }

    public async Task<object> privatePostFeesTradingPair (object parameters = null)
    {
        return await this.callAsync ("privatePostFeesTradingPair",parameters);
    }

    public async Task<object> privatePostFeesWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostFeesWithdrawal",parameters);
    }

    public async Task<object> privatePostFeesWithdrawalCurrency (object parameters = null)
    {
        return await this.callAsync ("privatePostFeesWithdrawalCurrency",parameters);
    }

    public async Task<object> privatePostWithdrawalRequests (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdrawalRequests",parameters);
    }

    public async Task<object> privatePostWithdrawalOpen (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdrawalOpen",parameters);
    }

    public async Task<object> privatePostWithdrawalStatus (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdrawalStatus",parameters);
    }

    public async Task<object> privatePostWithdrawalCancel (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdrawalCancel",parameters);
    }

    public async Task<object> privatePostLiquidationAddressNew (object parameters = null)
    {
        return await this.callAsync ("privatePostLiquidationAddressNew",parameters);
    }

    public async Task<object> privatePostLiquidationAddressInfo (object parameters = null)
    {
        return await this.callAsync ("privatePostLiquidationAddressInfo",parameters);
    }

    public async Task<object> privatePostBtcUnconfirmed (object parameters = null)
    {
        return await this.callAsync ("privatePostBtcUnconfirmed",parameters);
    }

    public async Task<object> privatePostWebsocketsToken (object parameters = null)
    {
        return await this.callAsync ("privatePostWebsocketsToken",parameters);
    }

    public async Task<object> privatePostBtcWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostBtcWithdrawal",parameters);
    }

    public async Task<object> privatePostBtcAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostBtcAddress",parameters);
    }

    public async Task<object> privatePostRippleWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostRippleWithdrawal",parameters);
    }

    public async Task<object> privatePostRippleAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostRippleAddress",parameters);
    }

    public async Task<object> privatePostLtcWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostLtcWithdrawal",parameters);
    }

    public async Task<object> privatePostLtcAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostLtcAddress",parameters);
    }

    public async Task<object> privatePostEthWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostEthWithdrawal",parameters);
    }

    public async Task<object> privatePostEthAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostEthAddress",parameters);
    }

    public async Task<object> privatePostXrpWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostXrpWithdrawal",parameters);
    }

    public async Task<object> privatePostXrpAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostXrpAddress",parameters);
    }

    public async Task<object> privatePostXlmWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostXlmWithdrawal",parameters);
    }

    public async Task<object> privatePostXlmAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostXlmAddress",parameters);
    }

    public async Task<object> privatePostPaxWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostPaxWithdrawal",parameters);
    }

    public async Task<object> privatePostPaxAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostPaxAddress",parameters);
    }

    public async Task<object> privatePostLinkWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostLinkWithdrawal",parameters);
    }

    public async Task<object> privatePostLinkAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostLinkAddress",parameters);
    }

    public async Task<object> privatePostUsdcWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostUsdcWithdrawal",parameters);
    }

    public async Task<object> privatePostUsdcAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostUsdcAddress",parameters);
    }

    public async Task<object> privatePostOmgWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostOmgWithdrawal",parameters);
    }

    public async Task<object> privatePostOmgAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostOmgAddress",parameters);
    }

    public async Task<object> privatePostDaiWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostDaiWithdrawal",parameters);
    }

    public async Task<object> privatePostDaiAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostDaiAddress",parameters);
    }

    public async Task<object> privatePostKncWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostKncWithdrawal",parameters);
    }

    public async Task<object> privatePostKncAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostKncAddress",parameters);
    }

    public async Task<object> privatePostMkrWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostMkrWithdrawal",parameters);
    }

    public async Task<object> privatePostMkrAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostMkrAddress",parameters);
    }

    public async Task<object> privatePostZrxWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostZrxWithdrawal",parameters);
    }

    public async Task<object> privatePostZrxAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostZrxAddress",parameters);
    }

    public async Task<object> privatePostGusdWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostGusdWithdrawal",parameters);
    }

    public async Task<object> privatePostGusdAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostGusdAddress",parameters);
    }

    public async Task<object> privatePostAaveWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostAaveWithdrawal",parameters);
    }

    public async Task<object> privatePostAaveAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAaveAddress",parameters);
    }

    public async Task<object> privatePostBatWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostBatWithdrawal",parameters);
    }

    public async Task<object> privatePostBatAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostBatAddress",parameters);
    }

    public async Task<object> privatePostUmaWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostUmaWithdrawal",parameters);
    }

    public async Task<object> privatePostUmaAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostUmaAddress",parameters);
    }

    public async Task<object> privatePostSnxWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostSnxWithdrawal",parameters);
    }

    public async Task<object> privatePostSnxAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostSnxAddress",parameters);
    }

    public async Task<object> privatePostUniWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostUniWithdrawal",parameters);
    }

    public async Task<object> privatePostUniAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostUniAddress",parameters);
    }

    public async Task<object> privatePostYfiWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostYfiWithdrawal",parameters);
    }

    public async Task<object> privatePostYfiAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostYfiAddress",parameters);
    }

    public async Task<object> privatePostAudioWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostAudioWithdrawal",parameters);
    }

    public async Task<object> privatePostAudioAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAudioAddress",parameters);
    }

    public async Task<object> privatePostCrvWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostCrvWithdrawal",parameters);
    }

    public async Task<object> privatePostCrvAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostCrvAddress",parameters);
    }

    public async Task<object> privatePostAlgoWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostAlgoWithdrawal",parameters);
    }

    public async Task<object> privatePostAlgoAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAlgoAddress",parameters);
    }

    public async Task<object> privatePostCompWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostCompWithdrawal",parameters);
    }

    public async Task<object> privatePostCompAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostCompAddress",parameters);
    }

    public async Task<object> privatePostGrtWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostGrtWithdrawal",parameters);
    }

    public async Task<object> privatePostGrtAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostGrtAddress",parameters);
    }

    public async Task<object> privatePostUsdtWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostUsdtWithdrawal",parameters);
    }

    public async Task<object> privatePostUsdtAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostUsdtAddress",parameters);
    }

    public async Task<object> privatePostEurtWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostEurtWithdrawal",parameters);
    }

    public async Task<object> privatePostEurtAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostEurtAddress",parameters);
    }

    public async Task<object> privatePostMaticWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostMaticWithdrawal",parameters);
    }

    public async Task<object> privatePostMaticAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostMaticAddress",parameters);
    }

    public async Task<object> privatePostSushiWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostSushiWithdrawal",parameters);
    }

    public async Task<object> privatePostSushiAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostSushiAddress",parameters);
    }

    public async Task<object> privatePostChzWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostChzWithdrawal",parameters);
    }

    public async Task<object> privatePostChzAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostChzAddress",parameters);
    }

    public async Task<object> privatePostEnjWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostEnjWithdrawal",parameters);
    }

    public async Task<object> privatePostEnjAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostEnjAddress",parameters);
    }

    public async Task<object> privatePostAlphaWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostAlphaWithdrawal",parameters);
    }

    public async Task<object> privatePostAlphaAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAlphaAddress",parameters);
    }

    public async Task<object> privatePostFttWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostFttWithdrawal",parameters);
    }

    public async Task<object> privatePostFttAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostFttAddress",parameters);
    }

    public async Task<object> privatePostStorjWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostStorjWithdrawal",parameters);
    }

    public async Task<object> privatePostStorjAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostStorjAddress",parameters);
    }

    public async Task<object> privatePostAxsWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostAxsWithdrawal",parameters);
    }

    public async Task<object> privatePostAxsAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAxsAddress",parameters);
    }

    public async Task<object> privatePostSandWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostSandWithdrawal",parameters);
    }

    public async Task<object> privatePostSandAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostSandAddress",parameters);
    }

    public async Task<object> privatePostHbarWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostHbarWithdrawal",parameters);
    }

    public async Task<object> privatePostHbarAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostHbarAddress",parameters);
    }

    public async Task<object> privatePostRgtWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostRgtWithdrawal",parameters);
    }

    public async Task<object> privatePostRgtAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostRgtAddress",parameters);
    }

    public async Task<object> privatePostFetWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostFetWithdrawal",parameters);
    }

    public async Task<object> privatePostFetAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostFetAddress",parameters);
    }

    public async Task<object> privatePostSklWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostSklWithdrawal",parameters);
    }

    public async Task<object> privatePostSklAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostSklAddress",parameters);
    }

    public async Task<object> privatePostCelWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostCelWithdrawal",parameters);
    }

    public async Task<object> privatePostCelAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostCelAddress",parameters);
    }

    public async Task<object> privatePostSxpWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostSxpWithdrawal",parameters);
    }

    public async Task<object> privatePostSxpAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostSxpAddress",parameters);
    }

    public async Task<object> privatePostAdaWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostAdaWithdrawal",parameters);
    }

    public async Task<object> privatePostAdaAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAdaAddress",parameters);
    }

    public async Task<object> privatePostSlpWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostSlpWithdrawal",parameters);
    }

    public async Task<object> privatePostSlpAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostSlpAddress",parameters);
    }

    public async Task<object> privatePostFtmWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostFtmWithdrawal",parameters);
    }

    public async Task<object> privatePostFtmAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostFtmAddress",parameters);
    }

    public async Task<object> privatePostPerpWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostPerpWithdrawal",parameters);
    }

    public async Task<object> privatePostPerpAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostPerpAddress",parameters);
    }

    public async Task<object> privatePostDydxWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostDydxWithdrawal",parameters);
    }

    public async Task<object> privatePostDydxAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostDydxAddress",parameters);
    }

    public async Task<object> privatePostGalaWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostGalaWithdrawal",parameters);
    }

    public async Task<object> privatePostGalaAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostGalaAddress",parameters);
    }

    public async Task<object> privatePostShibWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostShibWithdrawal",parameters);
    }

    public async Task<object> privatePostShibAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostShibAddress",parameters);
    }

    public async Task<object> privatePostAmpWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostAmpWithdrawal",parameters);
    }

    public async Task<object> privatePostAmpAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAmpAddress",parameters);
    }

    public async Task<object> privatePostSgbWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostSgbWithdrawal",parameters);
    }

    public async Task<object> privatePostSgbAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostSgbAddress",parameters);
    }

    public async Task<object> privatePostAvaxWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostAvaxWithdrawal",parameters);
    }

    public async Task<object> privatePostAvaxAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAvaxAddress",parameters);
    }

    public async Task<object> privatePostWbtcWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostWbtcWithdrawal",parameters);
    }

    public async Task<object> privatePostWbtcAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostWbtcAddress",parameters);
    }

    public async Task<object> privatePostCtsiWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostCtsiWithdrawal",parameters);
    }

    public async Task<object> privatePostCtsiAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostCtsiAddress",parameters);
    }

    public async Task<object> privatePostCvxWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostCvxWithdrawal",parameters);
    }

    public async Task<object> privatePostCvxAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostCvxAddress",parameters);
    }

    public async Task<object> privatePostImxWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostImxWithdrawal",parameters);
    }

    public async Task<object> privatePostImxAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostImxAddress",parameters);
    }

    public async Task<object> privatePostNexoWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostNexoWithdrawal",parameters);
    }

    public async Task<object> privatePostNexoAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostNexoAddress",parameters);
    }

    public async Task<object> privatePostUstWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostUstWithdrawal",parameters);
    }

    public async Task<object> privatePostUstAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostUstAddress",parameters);
    }

    public async Task<object> privatePostAntWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostAntWithdrawal",parameters);
    }

    public async Task<object> privatePostAntAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAntAddress",parameters);
    }

    public async Task<object> privatePostGodsWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostGodsWithdrawal",parameters);
    }

    public async Task<object> privatePostGodsAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostGodsAddress",parameters);
    }

    public async Task<object> privatePostRadWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostRadWithdrawal",parameters);
    }

    public async Task<object> privatePostRadAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostRadAddress",parameters);
    }

    public async Task<object> privatePostBandWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostBandWithdrawal",parameters);
    }

    public async Task<object> privatePostBandAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostBandAddress",parameters);
    }

    public async Task<object> privatePostInjWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostInjWithdrawal",parameters);
    }

    public async Task<object> privatePostInjAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostInjAddress",parameters);
    }

    public async Task<object> privatePostRlyWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostRlyWithdrawal",parameters);
    }

    public async Task<object> privatePostRlyAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostRlyAddress",parameters);
    }

    public async Task<object> privatePostRndrWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostRndrWithdrawal",parameters);
    }

    public async Task<object> privatePostRndrAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostRndrAddress",parameters);
    }

    public async Task<object> privatePostVegaWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostVegaWithdrawal",parameters);
    }

    public async Task<object> privatePostVegaAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostVegaAddress",parameters);
    }

    public async Task<object> privatePost1inchWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePost1inchWithdrawal",parameters);
    }

    public async Task<object> privatePost1inchAddress (object parameters = null)
    {
        return await this.callAsync ("privatePost1inchAddress",parameters);
    }

    public async Task<object> privatePostEnsWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostEnsWithdrawal",parameters);
    }

    public async Task<object> privatePostEnsAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostEnsAddress",parameters);
    }

    public async Task<object> privatePostManaWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostManaWithdrawal",parameters);
    }

    public async Task<object> privatePostManaAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostManaAddress",parameters);
    }

    public async Task<object> privatePostLrcWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostLrcWithdrawal",parameters);
    }

    public async Task<object> privatePostLrcAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostLrcAddress",parameters);
    }

    public async Task<object> privatePostApeWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostApeWithdrawal",parameters);
    }

    public async Task<object> privatePostApeAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostApeAddress",parameters);
    }

    public async Task<object> privatePostMplWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostMplWithdrawal",parameters);
    }

    public async Task<object> privatePostMplAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostMplAddress",parameters);
    }

    public async Task<object> privatePostEurocWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostEurocWithdrawal",parameters);
    }

    public async Task<object> privatePostEurocAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostEurocAddress",parameters);
    }

    public async Task<object> privatePostSolWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostSolWithdrawal",parameters);
    }

    public async Task<object> privatePostSolAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostSolAddress",parameters);
    }

    public async Task<object> privatePostDotWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostDotWithdrawal",parameters);
    }

    public async Task<object> privatePostDotAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostDotAddress",parameters);
    }

    public async Task<object> privatePostNearWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostNearWithdrawal",parameters);
    }

    public async Task<object> privatePostNearAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostNearAddress",parameters);
    }

    public async Task<object> privatePostDogeWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostDogeWithdrawal",parameters);
    }

    public async Task<object> privatePostDogeAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostDogeAddress",parameters);
    }

    public async Task<object> privatePostFlrWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostFlrWithdrawal",parameters);
    }

    public async Task<object> privatePostFlrAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostFlrAddress",parameters);
    }

    public async Task<object> privatePostDgldWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostDgldWithdrawal",parameters);
    }

    public async Task<object> privatePostDgldAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostDgldAddress",parameters);
    }

    public async Task<object> privatePostLdoWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostLdoWithdrawal",parameters);
    }

    public async Task<object> privatePostLdoAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostLdoAddress",parameters);
    }

    public async Task<object> privatePostTravelRuleContacts (object parameters = null)
    {
        return await this.callAsync ("privatePostTravelRuleContacts",parameters);
    }

    public async Task<object> privatePostEarnSubscribe (object parameters = null)
    {
        return await this.callAsync ("privatePostEarnSubscribe",parameters);
    }

    public async Task<object> privatePostEarnSubscriptionsSetting (object parameters = null)
    {
        return await this.callAsync ("privatePostEarnSubscriptionsSetting",parameters);
    }

    public async Task<object> privatePostEarnUnsubscribe (object parameters = null)
    {
        return await this.callAsync ("privatePostEarnUnsubscribe",parameters);
    }

    public async Task<object> privatePostWecanWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostWecanWithdrawal",parameters);
    }

    public async Task<object> privatePostWecanAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostWecanAddress",parameters);
    }

    public async Task<object> privatePostTracWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostTracWithdrawal",parameters);
    }

    public async Task<object> privatePostTracAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostTracAddress",parameters);
    }

    public async Task<object> privatePostEurcvWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostEurcvWithdrawal",parameters);
    }

    public async Task<object> privatePostEurcvAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostEurcvAddress",parameters);
    }

    public async Task<object> privatePostPyusdWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostPyusdWithdrawal",parameters);
    }

    public async Task<object> privatePostPyusdAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostPyusdAddress",parameters);
    }

}