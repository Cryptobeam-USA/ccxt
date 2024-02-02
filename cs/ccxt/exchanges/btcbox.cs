namespace ccxt;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

public partial class btcbox : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "btcbox" },
            { "name", "BtcBox" },
            { "countries", new List<object>() {"JP"} },
            { "rateLimit", 1000 },
            { "version", "v1" },
            { "pro", false },
            { "has", new Dictionary<string, object>() {
                { "CORS", null },
                { "spot", true },
                { "margin", false },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "addMargin", false },
                { "cancelOrder", true },
                { "closeAllPositions", false },
                { "closePosition", false },
                { "createOrder", true },
                { "createReduceOnlyOrder", false },
                { "fetchBalance", true },
                { "fetchBorrowRateHistories", false },
                { "fetchBorrowRateHistory", false },
                { "fetchCrossBorrowRate", false },
                { "fetchCrossBorrowRates", false },
                { "fetchFundingHistory", false },
                { "fetchFundingRate", false },
                { "fetchFundingRateHistory", false },
                { "fetchFundingRates", false },
                { "fetchIndexOHLCV", false },
                { "fetchIsolatedBorrowRate", false },
                { "fetchIsolatedBorrowRates", false },
                { "fetchLeverage", false },
                { "fetchMarginMode", false },
                { "fetchMarkOHLCV", false },
                { "fetchOpenInterestHistory", false },
                { "fetchOpenOrders", true },
                { "fetchOrder", true },
                { "fetchOrderBook", true },
                { "fetchOrders", true },
                { "fetchPosition", false },
                { "fetchPositionMode", false },
                { "fetchPositions", false },
                { "fetchPositionsRisk", false },
                { "fetchPremiumIndexOHLCV", false },
                { "fetchTicker", true },
                { "fetchTickers", false },
                { "fetchTrades", true },
                { "fetchTransfer", false },
                { "fetchTransfers", false },
                { "fetchWithdrawal", false },
                { "fetchWithdrawals", false },
                { "reduceMargin", false },
                { "setLeverage", false },
                { "setMarginMode", false },
                { "setPositionMode", false },
                { "transfer", false },
                { "withdraw", false },
                { "ws", false },
            } },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/51840849/87327317-98c55400-c53c-11ea-9a11-81f7d951cc74.jpg" },
                { "api", new Dictionary<string, object>() {
                    { "rest", "https://www.btcbox.co.jp/api" },
                } },
                { "www", "https://www.btcbox.co.jp/" },
                { "doc", "https://blog.btcbox.jp/en/archives/8762" },
                { "fees", "https://support.btcbox.co.jp/hc/en-us/articles/360001235694-Fees-introduction" },
            } },
            { "api", new Dictionary<string, object>() {
                { "public", new Dictionary<string, object>() {
                    { "get", new List<object>() {"depth", "orders", "ticker"} },
                } },
                { "private", new Dictionary<string, object>() {
                    { "post", new List<object>() {"balance", "trade_add", "trade_cancel", "trade_list", "trade_view", "wallet"} },
                } },
            } },
            { "markets", new Dictionary<string, object>() {
                { "BTC/JPY", this.safeMarketStructure(new Dictionary<string, object>() {
                    { "id", "btc" },
                    { "symbol", "BTC/JPY" },
                    { "base", "BTC" },
                    { "quote", "JPY" },
                    { "baseId", "btc" },
                    { "quoteId", "jpy" },
                    { "taker", this.parseNumber("0.0005") },
                    { "maker", this.parseNumber("0.0005") },
                    { "type", "spot" },
                    { "spot", true },
                }) },
                { "ETH/JPY", this.safeMarketStructure(new Dictionary<string, object>() {
                    { "id", "eth" },
                    { "symbol", "ETH/JPY" },
                    { "base", "ETH" },
                    { "quote", "JPY" },
                    { "baseId", "eth" },
                    { "quoteId", "jpy" },
                    { "taker", this.parseNumber("0.0010") },
                    { "maker", this.parseNumber("0.0010") },
                    { "type", "spot" },
                    { "spot", true },
                }) },
                { "LTC/JPY", this.safeMarketStructure(new Dictionary<string, object>() {
                    { "id", "ltc" },
                    { "symbol", "LTC/JPY" },
                    { "base", "LTC" },
                    { "quote", "JPY" },
                    { "baseId", "ltc" },
                    { "quoteId", "jpy" },
                    { "taker", this.parseNumber("0.0010") },
                    { "maker", this.parseNumber("0.0010") },
                    { "type", "spot" },
                    { "spot", true },
                }) },
                { "BCH/JPY", this.safeMarketStructure(new Dictionary<string, object>() {
                    { "id", "bch" },
                    { "symbol", "BCH/JPY" },
                    { "base", "BCH" },
                    { "quote", "JPY" },
                    { "baseId", "bch" },
                    { "quoteId", "jpy" },
                    { "taker", this.parseNumber("0.0010") },
                    { "maker", this.parseNumber("0.0010") },
                    { "type", "spot" },
                    { "spot", true },
                }) },
            } },
            { "precisionMode", TICK_SIZE },
            { "exceptions", new Dictionary<string, object>() {
                { "104", typeof(AuthenticationError) },
                { "105", typeof(PermissionDenied) },
                { "106", typeof(InvalidNonce) },
                { "107", typeof(InvalidOrder) },
                { "200", typeof(InsufficientFunds) },
                { "201", typeof(InvalidOrder) },
                { "202", typeof(InvalidOrder) },
                { "203", typeof(OrderNotFound) },
                { "401", typeof(OrderNotFound) },
                { "402", typeof(DDoSProtection) },
            } },
        });
    }

    public override object parseBalance(object response)
    {
        object result = new Dictionary<string, object>() {
            { "info", response },
        };
        object codes = new List<object>(((IDictionary<string,object>)this.currencies).Keys);
        for (object i = 0; isLessThan(i, getArrayLength(codes)); postFixIncrement(ref i))
        {
            object code = getValue(codes, i);
            object currency = this.currency(code);
            object currencyId = getValue(currency, "id");
            object free = add(currencyId, "_balance");
            if (isTrue(inOp(response, free)))
            {
                object account = this.account();
                object used = add(currencyId, "_lock");
                ((IDictionary<string,object>)account)["free"] = this.safeString(response, free);
                ((IDictionary<string,object>)account)["used"] = this.safeString(response, used);
                ((IDictionary<string,object>)result)[(string)code] = account;
            }
        }
        return this.safeBalance(result);
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        /**
        * @method
        * @name btcbox#fetchBalance
        * @description query for balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/#/?id=balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.privatePostBalance(parameters);
        return this.parseBalance(response);
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name btcbox#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int} [limit] the maximum amount of order book entries to return
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {};
        object numSymbols = getArrayLength(this.symbols);
        if (isTrue(isGreaterThan(numSymbols, 1)))
        {
            ((IDictionary<string,object>)request)["coin"] = getValue(market, "baseId");
        }
        object response = await this.publicGetDepth(this.extend(request, parameters));
        return this.parseOrderBook(response, getValue(market, "symbol"));
    }

    public override object parseTicker(object ticker, object market = null)
    {
        object symbol = this.safeSymbol(null, market);
        object last = this.safeString(ticker, "last");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", null },
            { "datetime", null },
            { "high", this.safeString(ticker, "high") },
            { "low", this.safeString(ticker, "low") },
            { "bid", this.safeString(ticker, "buy") },
            { "bidVolume", null },
            { "ask", this.safeString(ticker, "sell") },
            { "askVolume", null },
            { "vwap", null },
            { "open", null },
            { "close", last },
            { "last", last },
            { "previousClose", null },
            { "change", null },
            { "percentage", null },
            { "average", null },
            { "baseVolume", this.safeString(ticker, "vol") },
            { "quoteVolume", this.safeString(ticker, "volume") },
            { "info", ticker },
        }, market);
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name btcbox#fetchTicker
        * @description fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {};
        object numSymbols = getArrayLength(this.symbols);
        if (isTrue(isGreaterThan(numSymbols, 1)))
        {
            ((IDictionary<string,object>)request)["coin"] = getValue(market, "baseId");
        }
        object response = await this.publicGetTicker(this.extend(request, parameters));
        return this.parseTicker(response, market);
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        // fetchTrades (public)
        //
        //      {
        //          "date":"0",
        //          "price":3,
        //          "amount":0.1,
        //          "tid":"1",
        //          "type":"buy"
        //      }
        //
        object timestamp = this.safeTimestamp(trade, "date");
        market = this.safeMarket(null, market);
        object id = this.safeString(trade, "tid");
        object priceString = this.safeString(trade, "price");
        object amountString = this.safeString(trade, "amount");
        object type = null;
        object side = this.safeString(trade, "type");
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", trade },
            { "id", id },
            { "order", null },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", getValue(market, "symbol") },
            { "type", type },
            { "side", side },
            { "takerOrMaker", null },
            { "price", priceString },
            { "amount", amountString },
            { "cost", null },
            { "fee", null },
        }, market);
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name btcbox#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int} [since] timestamp in ms of the earliest trade to fetch
        * @param {int} [limit] the maximum amount of trades to fetch
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {Trade[]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {};
        object numSymbols = getArrayLength(this.symbols);
        if (isTrue(isGreaterThan(numSymbols, 1)))
        {
            ((IDictionary<string,object>)request)["coin"] = getValue(market, "baseId");
        }
        object response = await this.publicGetOrders(this.extend(request, parameters));
        //
        //     [
        //          {
        //              "date":"0",
        //              "price":3,
        //              "amount":0.1,
        //              "tid":"1",
        //              "type":"buy"
        //          },
        //     ]
        //
        return this.parseTrades(response, market, since, limit);
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name btcbox#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float} [price] the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "amount", amount },
            { "price", price },
            { "type", side },
            { "coin", getValue(market, "baseId") },
        };
        object response = await this.privatePostTradeAdd(this.extend(request, parameters));
        //
        //     {
        //         "result":true,
        //         "id":"11"
        //     }
        //
        return this.parseOrder(response, market);
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name btcbox#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        // a special case for btcbox – default symbol is BTC/JPY
        if (isTrue(isEqual(symbol, null)))
        {
            symbol = "BTC/JPY";
        }
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "id", id },
            { "coin", getValue(market, "baseId") },
        };
        object response = await this.privatePostTradeCancel(this.extend(request, parameters));
        //
        //     {"result":true, "id":"11"}
        //
        return this.parseOrder(response, market);
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "part", "open" },
            { "all", "closed" },
            { "cancelled", "canceled" },
            { "closed", "closed" },
            { "no", "closed" },
        };
        return this.safeString(statuses, status, status);
    }

    public override object parseOrder(object order, object market = null)
    {
        //
        //     {
        //         "id":11,
        //         "datetime":"2014-10-21 10:47:20",
        //         "type":"sell",
        //         "price":42000,
        //         "amount_original":1.2,
        //         "amount_outstanding":1.2,
        //         "status":"closed",
        //         "trades":[] // no clarification of trade value structure of order endpoint
        //     }
        //
        object id = this.safeString(order, "id");
        object datetimeString = this.safeString(order, "datetime");
        object timestamp = null;
        if (isTrue(!isEqual(datetimeString, null)))
        {
            timestamp = this.parse8601(add(getValue(order, "datetime"), "+09:00")); // Tokyo time
        }
        object amount = this.safeString(order, "amount_original");
        object remaining = this.safeString(order, "amount_outstanding");
        object price = this.safeString(order, "price");
        // status is set by fetchOrder method only
        object status = this.parseOrderStatus(this.safeString(order, "status"));
        // fetchOrders do not return status, use heuristic
        if (isTrue(isEqual(status, null)))
        {
            if (isTrue(Precise.stringEquals(remaining, "0")))
            {
                status = "closed";
            }
        }
        object trades = null; // todo: this.parseTrades (order['trades']);
        market = this.safeMarket(null, market);
        object side = this.safeString(order, "type");
        return this.safeOrder(new Dictionary<string, object>() {
            { "id", id },
            { "clientOrderId", null },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "lastTradeTimestamp", null },
            { "amount", amount },
            { "remaining", remaining },
            { "filled", null },
            { "side", side },
            { "type", null },
            { "timeInForce", null },
            { "postOnly", null },
            { "status", status },
            { "symbol", getValue(market, "symbol") },
            { "price", price },
            { "stopPrice", null },
            { "triggerPrice", null },
            { "cost", null },
            { "trades", trades },
            { "fee", null },
            { "info", order },
            { "average", null },
        }, market);
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name btcbox#fetchOrder
        * @description fetches information on an order made by the user
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        // a special case for btcbox – default symbol is BTC/JPY
        if (isTrue(isEqual(symbol, null)))
        {
            symbol = "BTC/JPY";
        }
        object market = this.market(symbol);
        object request = this.extend(new Dictionary<string, object>() {
            { "id", id },
            { "coin", getValue(market, "baseId") },
        }, parameters);
        object response = await this.privatePostTradeView(this.extend(request, parameters));
        //
        //      {
        //          "id":11,
        //          "datetime":"2014-10-21 10:47:20",
        //          "type":"sell",
        //          "price":42000,
        //          "amount_original":1.2,
        //          "amount_outstanding":1.2,
        //          "status":"closed",
        //          "trades":[]
        //      }
        //
        return this.parseOrder(response, market);
    }

    public async virtual Task<object> fetchOrdersByType(object type, object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        // a special case for btcbox – default symbol is BTC/JPY
        if (isTrue(isEqual(symbol, null)))
        {
            symbol = "BTC/JPY";
        }
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "type", type },
            { "coin", getValue(market, "baseId") },
        };
        object response = await this.privatePostTradeList(this.extend(request, parameters));
        //
        // [
        //      {
        //          "id":"7",
        //          "datetime":"2014-10-20 13:27:38",
        //          "type":"buy",
        //          "price":42750,
        //          "amount_original":0.235,
        //          "amount_outstanding":0.235
        //      },
        // ]
        //
        object orders = this.parseOrders(response, market, since, limit);
        // status (open/closed/canceled) is undefined
        // btcbox does not return status, but we know it's 'open' as we queried for open orders
        if (isTrue(isEqual(type, "open")))
        {
            for (object i = 0; isLessThan(i, getArrayLength(orders)); postFixIncrement(ref i))
            {
                ((IDictionary<string,object>)getValue(orders, i))["status"] = "open";
            }
        }
        return orders;
    }

    public async override Task<object> fetchOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name btcbox#fetchOrders
        * @description fetches information on multiple orders made by the user
        * @param {string} symbol unified market symbol of the market orders were made in
        * @param {int} [since] the earliest time in ms to fetch orders for
        * @param {int} [limit] the maximum number of order structures to retrieve
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {Order[]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        return await this.fetchOrdersByType("all", symbol, since, limit, parameters);
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name btcbox#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string} symbol unified market symbol
        * @param {int} [since] the earliest time in ms to fetch open orders for
        * @param {int} [limit] the maximum number of  open orders structures to retrieve
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {Order[]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        return await this.fetchOrdersByType("open", symbol, since, limit, parameters);
    }

    public override object nonce()
    {
        return this.milliseconds();
    }

    public override object sign(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        object url = add(add(add(add(getValue(getValue(this.urls, "api"), "rest"), "/"), this.version), "/"), path);
        if (isTrue(isEqual(api, "public")))
        {
            if (isTrue(getArrayLength(new List<object>(((IDictionary<string,object>)parameters).Keys))))
            {
                url = add(url, add("?", this.urlencode(parameters)));
            }
        } else
        {
            this.checkRequiredCredentials();
            object nonce = ((object)this.nonce()).ToString();
            object query = this.extend(new Dictionary<string, object>() {
                { "key", this.apiKey },
                { "nonce", nonce },
            }, parameters);
            object request = this.urlencode(query);
            object secret = this.hash(this.encode(this.secret), sha256);
            ((IDictionary<string,object>)query)["signature"] = this.hmac(this.encode(request), this.encode(secret), sha256);
            body = this.urlencode(query);
            headers = new Dictionary<string, object>() {
                { "Content-Type", "application/x-www-form-urlencoded" },
            };
        }
        return new Dictionary<string, object>() {
            { "url", url },
            { "method", method },
            { "body", body },
            { "headers", headers },
        };
    }

    public override object handleErrors(object httpCode, object reason, object url, object method, object headers, object body, object response, object requestHeaders, object requestBody)
    {
        if (isTrue(isEqual(response, null)))
        {
            return null;  // resort to defaultErrorHandler
        }
        // typical error response: {"result":false,"code":"401"}
        if (isTrue(isGreaterThanOrEqual(httpCode, 400)))
        {
            return null;  // resort to defaultErrorHandler
        }
        object result = this.safeValue(response, "result");
        if (isTrue(isTrue(isEqual(result, null)) || isTrue(isEqual(result, true))))
        {
            return null;  // either public API (no error codes expected) or success
        }
        object code = this.safeValue(response, "code");
        object feedback = add(add(this.id, " "), body);
        this.throwExactlyMatchedException(this.exceptions, code, feedback);
        throw new ExchangeError ((string)feedback) ;
    }

    public async override Task<object> request(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null, object config = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        config ??= new Dictionary<string, object>();
        object response = await this.fetch2(path, api, method, parameters, headers, body, config);
        if (isTrue((response is string)))
        {
            // sometimes the exchange returns whitespace prepended to json
            response = this.strip(response);
            if (!isTrue(this.isJsonEncodedObject(response)))
            {
                throw new ExchangeError ((string)add(add(this.id, " "), response)) ;
            }
            response = parseJson(response);
        }
        return response;
    }
}
