import Exchange from './abstract/bitfinex2.js';
import type { TransferEntry, Int, OrderSide, OrderType, Trade, OHLCV, Order, FundingRateHistory, OrderBook, Str, Transaction, Ticker, Balances, Tickers, Strings, Currency, Market, OpenInterest, Liquidation, OrderRequest } from './base/types.js';
/**
 * @class bitfinex2
 * @augments Exchange
 */
export default class bitfinex2 extends Exchange {
    describe(): any;
    isFiat(code: any): boolean;
    getCurrencyId(code: any): string;
    getCurrencyName(code: any): any;
    amountToPrecision(symbol: any, amount: any): any;
    priceToPrecision(symbol: any, price: any): any;
    fetchStatus(params?: {}): Promise<{
        status: string;
        updated: any;
        eta: any;
        url: any;
        info: any;
    }>;
    fetchMarkets(params?: {}): Promise<any[]>;
    fetchCurrencies(params?: {}): Promise<{}>;
    safeNetwork(networkId: any): string;
    fetchBalance(params?: {}): Promise<Balances>;
    transfer(code: string, amount: number, fromAccount: any, toAccount: any, params?: {}): Promise<TransferEntry>;
    parseTransfer(transfer: any, currency?: Currency): {
        id: any;
        timestamp: number;
        datetime: string;
        status: string;
        amount: number;
        currency: string;
        fromAccount: string;
        toAccount: string;
        info: any;
    };
    parseTransferStatus(status: any): string;
    convertDerivativesId(currency: any, type: any): any;
    fetchOrderBook(symbol: string, limit?: Int, params?: {}): Promise<OrderBook>;
    parseTicker(ticker: any, market?: Market): Ticker;
    fetchTickers(symbols?: Strings, params?: {}): Promise<Tickers>;
    fetchTicker(symbol: string, params?: {}): Promise<Ticker>;
    parseTrade(trade: any, market?: Market): Trade;
    fetchTrades(symbol: string, since?: Int, limit?: Int, params?: {}): Promise<Trade[]>;
    fetchOHLCV(symbol: string, timeframe?: string, since?: Int, limit?: Int, params?: {}): Promise<OHLCV[]>;
    parseOHLCV(ohlcv: any, market?: Market): OHLCV;
    parseOrderStatus(status: any): any;
    parseOrderFlags(flags: any): any;
    parseTimeInForce(orderType: any): string;
    parseOrder(order: any, market?: Market): Order;
    createOrderRequest(symbol: string, type: OrderType, side: OrderSide, amount: number, price?: number, params?: {}): any;
    createOrder(symbol: string, type: OrderType, side: OrderSide, amount: number, price?: number, params?: {}): Promise<Order>;
    createOrders(orders: OrderRequest[], params?: {}): Promise<Order[]>;
    cancelAllOrders(symbol?: Str, params?: {}): Promise<Order[]>;
    cancelOrder(id: string, symbol?: Str, params?: {}): Promise<Order>;
    cancelOrders(ids: any, symbol?: Str, params?: {}): Promise<Order[]>;
    fetchOpenOrder(id: string, symbol?: Str, params?: {}): Promise<any>;
    fetchClosedOrder(id: string, symbol?: Str, params?: {}): Promise<any>;
    fetchOpenOrders(symbol?: Str, since?: Int, limit?: Int, params?: {}): Promise<Order[]>;
    fetchClosedOrders(symbol?: Str, since?: Int, limit?: Int, params?: {}): Promise<Order[]>;
    fetchOrderTrades(id: string, symbol?: Str, since?: Int, limit?: Int, params?: {}): Promise<Trade[]>;
    fetchMyTrades(symbol?: Str, since?: Int, limit?: Int, params?: {}): Promise<Trade[]>;
    createDepositAddress(code: string, params?: {}): Promise<{
        currency: string;
        address: string;
        tag: string;
        network: any;
        info: any;
    }>;
    fetchDepositAddress(code: string, params?: {}): Promise<{
        currency: string;
        address: string;
        tag: string;
        network: any;
        info: any;
    }>;
    parseTransactionStatus(status: any): string;
    parseTransaction(transaction: any, currency?: Currency): Transaction;
    fetchTradingFees(params?: {}): Promise<{}>;
    fetchDepositsWithdrawals(code?: Str, since?: Int, limit?: Int, params?: {}): Promise<Transaction[]>;
    withdraw(code: string, amount: number, address: any, tag?: any, params?: {}): Promise<any>;
    fetchPositions(symbols?: Strings, params?: {}): Promise<import("./base/types.js").Position[]>;
    parsePosition(position: any, market?: Market): import("./base/types.js").Position;
    nonce(): number;
    sign(path: any, api?: string, method?: string, params?: {}, headers?: any, body?: any): {
        url: string;
        method: string;
        body: any;
        headers: any;
    };
    handleErrors(statusCode: any, statusText: any, url: any, method: any, headers: any, body: any, response: any, requestHeaders: any, requestBody: any): any;
    parseLedgerEntryType(type: any): any;
    parseLedgerEntry(item: any, currency?: Currency): {
        id: string;
        direction: any;
        account: any;
        referenceId: string;
        referenceAccount: any;
        type: any;
        currency: string;
        amount: number;
        timestamp: number;
        datetime: string;
        before: any;
        after: number;
        status: any;
        fee: any;
        info: any;
    };
    fetchLedger(code?: Str, since?: Int, limit?: Int, params?: {}): Promise<any>;
    fetchFundingRate(symbol: string, params?: {}): Promise<any>;
    fetchFundingRates(symbols?: Strings, params?: {}): Promise<{}>;
    fetchFundingRateHistory(symbol?: Str, since?: Int, limit?: Int, params?: {}): Promise<FundingRateHistory[]>;
    parseFundingRate(contract: any, market?: Market): {
        info: any;
        symbol: string;
        markPrice: number;
        indexPrice: number;
        interestRate: any;
        estimatedSettlePrice: any;
        timestamp: number;
        datetime: string;
        fundingRate: number;
        fundingTimestamp: any;
        fundingDatetime: any;
        nextFundingRate: number;
        nextFundingTimestamp: number;
        nextFundingDatetime: string;
        previousFundingRate: any;
        previousFundingTimestamp: any;
        previousFundingDatetime: any;
    };
    parseFundingRateHistory(contract: any, market?: Market): {
        info: any;
        symbol: string;
        markPrice: number;
        indexPrice: number;
        interestRate: any;
        estimatedSettlePrice: any;
        timestamp: number;
        datetime: string;
        fundingRate: number;
        fundingTimestamp: any;
        fundingDatetime: any;
        nextFundingRate: number;
        nextFundingTimestamp: number;
        nextFundingDatetime: string;
        previousFundingRate: any;
        previousFundingTimestamp: any;
        previousFundingDatetime: any;
    };
    fetchOpenInterest(symbol: string, params?: {}): Promise<OpenInterest>;
    fetchOpenInterestHistory(symbol: string, timeframe?: string, since?: Int, limit?: Int, params?: {}): Promise<OpenInterest[]>;
    parseOpenInterest(interest: any, market?: Market): OpenInterest;
    fetchLiquidations(symbol: string, since?: Int, limit?: Int, params?: {}): Promise<Liquidation[]>;
    parseLiquidation(liquidation: any, market?: Market): Liquidation;
    setMargin(symbol: string, amount: any, params?: {}): Promise<{
        info: any;
        type: any;
        amount: any;
        code: any;
        symbol: any;
        status: string;
    }>;
    parseMarginModification(data: any, market?: any): {
        info: any;
        type: any;
        amount: any;
        code: any;
        symbol: any;
        status: string;
    };
    fetchOrder(id: string, symbol?: string, params?: {}): Promise<Order>;
    editOrder(id: string, symbol: any, type: any, side: any, amount?: any, price?: any, params?: {}): Promise<Order>;
}
