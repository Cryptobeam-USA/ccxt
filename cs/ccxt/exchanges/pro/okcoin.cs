namespace ccxt.pro;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class okcoin { public okcoin(object args = null) : base(args) { } }
public partial class okcoin : ccxt.okcoin
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "has", new Dictionary<string, object>() {
                { "ws", true },
                { "watchTicker", true },
                { "watchTickers", false },
                { "watchOrderBook", true },
                { "watchOrders", true },
                { "watchTrades", true },
                { "watchBalance", true },
                { "watchOHLCV", true },
            } },
            { "urls", new Dictionary<string, object>() {
                { "api", new Dictionary<string, object>() {
                    { "ws", "wss://real.okcoin.com:8443/ws/v3" },
                } },
                { "logo", "https://user-images.githubusercontent.com/1294454/27766791-89ffb502-5ee5-11e7-8a5b-c5950b68ac65.jpg" },
                { "www", "https://www.okcoin.com" },
                { "doc", "https://www.okcoin.com/docs/en/" },
                { "fees", "https://www.okcoin.com/coin-fees" },
                { "referral", "https://www.okcoin.com/account/register?flag=activity&channelId=600001513" },
            } },
            { "options", new Dictionary<string, object>() {
                { "fetchMarkets", new List<object>() {"spot"} },
                { "watchOrders", "order" },
                { "watchOrderBook", new Dictionary<string, object>() {
                    { "limit", 400 },
                    { "type", "spot" },
                    { "depth", "depth_l2_tbt" },
                } },
                { "watchBalance", "spot" },
                { "ws", new Dictionary<string, object>() {
                    { "inflate", true },
                } },
            } },
            { "streaming", new Dictionary<string, object>() {
                { "ping", this.ping },
                { "keepAlive", 20000 },
            } },
        });
    }

    public async virtual Task<object> subscribe(object channel, object symbol, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object url = getValue(getValue(this.urls, "api"), "ws");
        object messageHash = add(add(add(add(getValue(market, "type"), "/"), channel), ":"), getValue(market, "id"));
        object request = new Dictionary<string, object>() {
            { "op", "subscribe" },
            { "args", new List<object>() {messageHash} },
        };
        return await this.watch(url, messageHash, this.deepExtend(request, parameters), messageHash);
    }

    public async override Task<object> watchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#watchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int} [since] timestamp in ms of the earliest trade to fetch
        * @param {int} [limit] the maximum amount of trades to fetch
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object[]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        symbol = this.symbol(symbol);
        object trades = await this.subscribe("trade", symbol, parameters);
        if (isTrue(this.newUpdates))
        {
            limit = callDynamically(trades, "getLimit", new object[] {symbol, limit});
        }
        return this.filterBySinceLimit(trades, since, limit, "timestamp", true);
    }

    public async override Task<object> watchOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#watchOrders
        * @description watches information on multiple orders made by the user
        * @param {string} symbol unified market symbol of the market orders were made in
        * @param {int} [since] the earliest time in ms to fetch orders for
        * @param {int} [limit] the maximum number of order structures to retrieve
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object[]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        await this.authenticate();
        if (isTrue(!isEqual(symbol, null)))
        {
            symbol = this.symbol(symbol);
        }
        object orderType = this.safeString(this.options, "watchOrders", "order");
        object trades = await this.subscribe(orderType, symbol, parameters);
        if (isTrue(this.newUpdates))
        {
            limit = callDynamically(trades, "getLimit", new object[] {symbol, limit});
        }
        return this.filterBySinceLimit(trades, since, limit, "timestamp", true);
    }

    public virtual void handleOrders(WebSocketClient client, object message, object subscription = null)
    {
        //
        // {
        //     "table": "spot/order",
        //     "data": [
        //       {
        //         "client_oid": '',
        //         "created_at": "2022-03-04T16:44:58.530Z",
        //         "event_code": "0",
        //         "event_message": '',
        //         "fee": '',
        //         "fee_currency": '',
        //         "filled_notional": "0",
        //         "filled_size": "0",
        //         "instrument_id": "LTC-USD",
        //         "last_amend_result": '',
        //         "last_fill_id": "0",
        //         "last_fill_px": "0",
        //         "last_fill_qty": "0",
        //         "last_fill_time": "1970-01-01T00:00:00.000Z",
        //         "last_request_id": '',
        //         "margin_trading": "1",
        //         "notional": '',
        //         "order_id": "8629537900471296",
        //         "order_type": "0",
        //         "price": "1500",
        //         "rebate": '',
        //         "rebate_currency": '',
        //         "side": "sell",
        //         "size": "0.0133",
        //         "state": "0",
        //         "status": "open",
        //         "timestamp": "2022-03-04T16:44:58.530Z",
        //         "type": "limit"
        //       }
        //     ]
        //   }
        //
        object table = this.safeString(message, "table");
        object orders = this.safeValue(message, "data", new List<object>() {});
        object ordersLength = getArrayLength(orders);
        if (isTrue(isGreaterThan(ordersLength, 0)))
        {
            object limit = this.safeInteger(this.options, "ordersLimit", 1000);
            if (isTrue(isEqual(this.orders, null)))
            {
                this.orders = new ArrayCacheBySymbolById(limit);
            }
            object stored = this.orders;
            object marketIds = new Dictionary<string, object>() {};
            object parsed = this.parseOrders(orders);
            for (object i = 0; isLessThan(i, getArrayLength(parsed)); postFixIncrement(ref i))
            {
                object order = getValue(parsed, i);
                callDynamically(stored, "append", new object[] {order});
                object symbol = getValue(order, "symbol");
                object market = this.market(symbol);
                ((IDictionary<string,object>)marketIds)[(string)getValue(market, "id")] = true;
            }
            object keys = new List<object>(((IDictionary<string,object>)marketIds).Keys);
            for (object i = 0; isLessThan(i, getArrayLength(keys)); postFixIncrement(ref i))
            {
                object messageHash = add(add(table, ":"), getValue(keys, i));
                callDynamically(client as WebSocketClient, "resolve", new object[] {this.orders, messageHash});
            }
        }
    }

    public async override Task<object> watchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#watchTicker
        * @description watches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        return await this.subscribe("ticker", symbol, parameters);
    }

    public virtual object handleTrade(WebSocketClient client, object message)
    {
        //
        //     {
        //         "table": "spot/trade",
        //         "data": [
        //             {
        //                 "side": "buy",
        //                 "trade_id": "30770973",
        //                 "price": "4665.4",
        //                 "size": "0.019",
        //                 "instrument_id": "BTC-USDT",
        //                 "timestamp": "2020-03-16T13:41:46.526Z"
        //             }
        //         ]
        //     }
        //
        object table = this.safeString(message, "table");
        object data = this.safeValue(message, "data", new List<object>() {});
        object tradesLimit = this.safeInteger(this.options, "tradesLimit", 1000);
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object trade = this.parseTrade(getValue(data, i));
            object symbol = getValue(trade, "symbol");
            object marketId = this.safeString(getValue(trade, "info"), "instrument_id");
            object messageHash = add(add(table, ":"), marketId);
            object stored = this.safeValue(this.trades, symbol);
            if (isTrue(isEqual(stored, null)))
            {
                stored = new ArrayCache(tradesLimit);
                ((IDictionary<string,object>)this.trades)[(string)symbol] = stored;
            }
            callDynamically(stored, "append", new object[] {trade});
            callDynamically(client as WebSocketClient, "resolve", new object[] {stored, messageHash});
        }
        return message;
    }

    public virtual object handleTicker(WebSocketClient client, object message)
    {
        //
        //     {
        //         "table": "spot/ticker",
        //         "data": [
        //             {
        //                 "last": "4634.1",
        //                 "open_24h": "5305.6",
        //                 "best_bid": "4631.6",
        //                 "high_24h": "5950",
        //                 "low_24h": "4448.8",
        //                 "base_volume_24h": "147913.11435388",
        //                 "quote_volume_24h": "756850119.99108082",
        //                 "best_ask": "4631.7",
        //                 "instrument_id": "BTC-USDT",
        //                 "timestamp": "2020-03-16T13:16:25.677Z",
        //                 "best_bid_size": "0.12348942",
        //                 "best_ask_size": "0.00100014",
        //                 "last_qty": "0.00331822"
        //             }
        //         ]
        //     }
        //
        object table = this.safeString(message, "table");
        object data = this.safeValue(message, "data", new List<object>() {});
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object ticker = this.parseTicker(getValue(data, i));
            object symbol = getValue(ticker, "symbol");
            object marketId = this.safeString(getValue(ticker, "info"), "instrument_id");
            object messageHash = add(add(table, ":"), marketId);
            ((IDictionary<string,object>)this.tickers)[(string)symbol] = ticker;
            callDynamically(client as WebSocketClient, "resolve", new object[] {ticker, messageHash});
        }
        return message;
    }

    public async override Task<object> watchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#watchOHLCV
        * @description watches historical candlestick data containing the open, high, low, and close price, and the volume of a market
        * @param {string} symbol unified symbol of the market to fetch OHLCV data for
        * @param {string} timeframe the length of time each candle represents
        * @param {int} [since] timestamp in ms of the earliest candle to fetch
        * @param {int} [limit] the maximum amount of candles to fetch
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {int[][]} A list of candles ordered as timestamp, open, high, low, close, volume
        */
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        symbol = this.symbol(symbol);
        object interval = this.safeString(this.timeframes, timeframe, timeframe);
        object name = add(add("candle", interval), "s");
        object ohlcv = await this.subscribe(name, symbol, parameters);
        if (isTrue(this.newUpdates))
        {
            limit = callDynamically(ohlcv, "getLimit", new object[] {symbol, limit});
        }
        return this.filterBySinceLimit(ohlcv, since, limit, 0, true);
    }

    public virtual void handleOHLCV(WebSocketClient client, object message)
    {
        //
        //     {
        //         "table": "spot/candle60s",
        //         "data": [
        //             {
        //                 "candle": [
        //                     "2020-03-16T14:29:00.000Z",
        //                     "4948.3",
        //                     "4966.7",
        //                     "4939.1",
        //                     "4945.3",
        //                     "238.36021657"
        //                 ],
        //                 "instrument_id": "BTC-USDT"
        //             }
        //         ]
        //     }
        //
        object table = this.safeString(message, "table");
        object data = this.safeValue(message, "data", new List<object>() {});
        object parts = ((string)table).Split(new [] {((string)"/")}, StringSplitOptions.None).ToList<object>();
        object part1 = this.safeString(parts, 1);
        object interval = ((string)part1).Replace((string)"candle", (string)"");
        interval = ((string)interval).Replace((string)"s", (string)"");
        // use a reverse lookup in a static map instead
        object timeframe = this.findTimeframe(interval);
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object marketId = this.safeString(getValue(data, i), "instrument_id");
            object candle = this.safeValue(getValue(data, i), "candle");
            object market = this.safeMarket(marketId);
            object symbol = getValue(market, "symbol");
            object parsed = this.parseOHLCV(candle, market);
            ((IDictionary<string,object>)this.ohlcvs)[(string)symbol] = this.safeValue(this.ohlcvs, symbol, new Dictionary<string, object>() {});
            object stored = this.safeValue(getValue(this.ohlcvs, symbol), timeframe);
            if (isTrue(isEqual(stored, null)))
            {
                object limit = this.safeInteger(this.options, "OHLCVLimit", 1000);
                stored = new ArrayCacheByTimestamp(limit);
                ((IDictionary<string,object>)getValue(this.ohlcvs, symbol))[(string)timeframe] = stored;
            }
            callDynamically(stored, "append", new object[] {parsed});
            object messageHash = add(add(table, ":"), marketId);
            callDynamically(client as WebSocketClient, "resolve", new object[] {stored, messageHash});
        }
    }

    public async override Task<object> watchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#watchOrderBook
        * @description watches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int} [limit] the maximum amount of order book entries to return
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        object options = this.safeValue(this.options, "watchOrderBook", new Dictionary<string, object>() {});
        object depth = this.safeString(options, "depth", "depth_l2_tbt");
        object orderbook = await this.subscribe(depth, symbol, parameters);
        return (orderbook as IOrderBook).limit();
    }

    public override void handleDelta(object bookside, object delta)
    {
        object price = this.safeFloat(delta, 0);
        object amount = this.safeFloat(delta, 1);
        (bookside as IOrderBookSide).store(price, amount);
    }

    public override void handleDeltas(object bookside, object deltas)
    {
        for (object i = 0; isLessThan(i, getArrayLength(deltas)); postFixIncrement(ref i))
        {
            this.handleDelta(bookside, getValue(deltas, i));
        }
    }

    public virtual object handleOrderBookMessage(WebSocketClient client, object message, object orderbook)
    {
        //
        //     {
        //         "instrument_id": "BTC-USDT",
        //         "asks": [
        //             ["4568.5", "0.49723138", "2"],
        //             ["4568.7", "0.5013", "1"],
        //             ["4569.1", "0.4398", "1"],
        //         ],
        //         "bids": [
        //             ["4568.4", "0.84187666", "5"],
        //             ["4568.3", "0.75661506", "6"],
        //             ["4567.8", "2.01", "2"],
        //         ],
        //         "timestamp": "2020-03-16T11:11:43.388Z",
        //         "checksum": 473370408
        //     }
        //
        object asks = this.safeValue(message, "asks", new List<object>() {});
        object bids = this.safeValue(message, "bids", new List<object>() {});
        this.handleDeltas(getValue(orderbook, "asks"), asks);
        this.handleDeltas(getValue(orderbook, "bids"), bids);
        object timestamp = this.parse8601(this.safeString(message, "timestamp"));
        ((IDictionary<string,object>)orderbook)["timestamp"] = timestamp;
        ((IDictionary<string,object>)orderbook)["datetime"] = this.iso8601(timestamp);
        return orderbook;
    }

    public virtual object handleOrderBook(WebSocketClient client, object message)
    {
        //
        // first message (snapshot)
        //
        //     {
        //         "table": "spot/depth",
        //         "action": "partial",
        //         "data": [
        //             {
        //                 "instrument_id": "BTC-USDT",
        //                 "asks": [
        //                     ["4568.5", "0.49723138", "2"],
        //                     ["4568.7", "0.5013", "1"],
        //                     ["4569.1", "0.4398", "1"],
        //                 ],
        //                 "bids": [
        //                     ["4568.4", "0.84187666", "5"],
        //                     ["4568.3", "0.75661506", "6"],
        //                     ["4567.8", "2.01", "2"],
        //                 ],
        //                 "timestamp": "2020-03-16T11:11:43.388Z",
        //                 "checksum": 473370408
        //             }
        //         ]
        //     }
        //
        // subsequent updates
        //
        //     {
        //         "table": "spot/depth",
        //         "action": "update",
        //         "data": [
        //             {
        //                 "instrument_id":   "BTC-USDT",
        //                 "asks": [
        //                     ["4598.8", "0", "0"],
        //                     ["4599.1", "0", "0"],
        //                     ["4600.3", "0", "0"],
        //                 ],
        //                 "bids": [
        //                     ["4598.5", "0.08", "1"],
        //                     ["4598.2", "0.0337323", "1"],
        //                     ["4598.1", "0.12681801", "3"],
        //                 ],
        //                 "timestamp": "2020-03-16T11:20:35.139Z",
        //                 "checksum": 740786981
        //             }
        //         ]
        //     }
        //
        object action = this.safeString(message, "action");
        object data = this.safeValue(message, "data", new List<object>() {});
        object table = this.safeString(message, "table");
        if (isTrue(isEqual(action, "partial")))
        {
            for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
            {
                object update = getValue(data, i);
                object marketId = this.safeString(update, "instrument_id");
                object market = this.safeMarket(marketId);
                object symbol = getValue(market, "symbol");
                object options = this.safeValue(this.options, "watchOrderBook", new Dictionary<string, object>() {});
                // default limit is 400 bidasks
                object limit = this.safeInteger(options, "limit", 400);
                object orderbook = this.orderBook(new Dictionary<string, object>() {}, limit);
                ((IDictionary<string,object>)this.orderbooks)[(string)symbol] = orderbook;
                this.handleOrderBookMessage(client as WebSocketClient, update, orderbook);
                object messageHash = add(add(table, ":"), marketId);
                callDynamically(client as WebSocketClient, "resolve", new object[] {orderbook, messageHash});
            }
        } else
        {
            for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
            {
                object update = getValue(data, i);
                object marketId = this.safeString(update, "instrument_id");
                object market = this.safeMarket(marketId);
                object symbol = getValue(market, "symbol");
                if (isTrue(inOp(this.orderbooks, symbol)))
                {
                    object orderbook = getValue(this.orderbooks, symbol);
                    this.handleOrderBookMessage(client as WebSocketClient, update, orderbook);
                    object messageHash = add(add(table, ":"), marketId);
                    callDynamically(client as WebSocketClient, "resolve", new object[] {orderbook, messageHash});
                }
            }
        }
        return message;
    }

    public async virtual Task<object> authenticate(object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        this.checkRequiredCredentials();
        object url = getValue(getValue(this.urls, "api"), "ws");
        object messageHash = "login";
        var client = this.client(url);
        var future = this.safeValue(((WebSocketClient)client).subscriptions, messageHash);
        if (isTrue(isEqual(future, null)))
        {
            future = client.future("authenticated");
            object timestamp = ((object)this.seconds()).ToString();
            object method = "GET";
            object path = "/users/self/verify";
            object auth = add(add(timestamp, method), path);
            object signature = this.hmac(this.encode(auth), this.encode(this.secret), sha256, "base64");
            object request = new Dictionary<string, object>() {
                { "op", messageHash },
                { "args", new List<object>() {this.apiKey, this.password, timestamp, signature} },
            };
            this.spawn(this.watch, new object[] { url, messageHash, request, messageHash, future});
        }
        return future;
    }

    public async override Task<object> watchBalance(object parameters = null)
    {
        /**
        * @method
        * @name okcoin#watchBalance
        * @description watch balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/#/?id=balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object defaultType = this.safeString2(this.options, "watchBalance", "defaultType");
        object type = this.safeString(parameters, "type", defaultType);
        if (isTrue(isEqual(type, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " watchBalance requires a type parameter (one of \'spot\', \'margin\', \'futures\', \'swap\')")) ;
        }
        // const query = this.omit (params, 'type');
        object negotiation = await this.authenticate();
        return await this.subscribeToUserAccount(negotiation, parameters);
    }

    public async virtual Task<object> subscribeToUserAccount(object negotiation, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        object defaultType = this.safeString2(this.options, "watchBalance", "defaultType");
        object type = this.safeString(parameters, "type", defaultType);
        if (isTrue(isEqual(type, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " watchBalance requires a type parameter (one of \'spot\', \'margin\', \'futures\', \'swap\')")) ;
        }
        await this.loadMarkets();
        object currencyId = this.safeString(parameters, "currency");
        object code = this.safeString(parameters, "code", this.safeCurrencyCode(currencyId));
        object currency = null;
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
        }
        object symbol = this.safeString(parameters, "symbol");
        object market = this.market(symbol);
        object marketUndefined = (isEqual(market, null));
        object currencyUndefined = (isEqual(currency, null));
        if (isTrue(isEqual(type, "spot")))
        {
            if (isTrue(currencyUndefined))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " watchBalance requires a \'currency\' (id) or a unified \'code\' parameter for "), type), " accounts")) ;
            }
        } else if (isTrue(isTrue(isTrue((isEqual(type, "margin"))) || isTrue((isEqual(type, "swap")))) || isTrue((isEqual(type, "option")))))
        {
            if (isTrue(marketUndefined))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " watchBalance requires a \'instrument_id\' (id) or a unified \'symbol\' parameter for "), type), " accounts")) ;
            }
        } else if (isTrue(isEqual(type, "futures")))
        {
            if (isTrue(isTrue(currencyUndefined) && isTrue(marketUndefined)))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " watchBalance requires a \'currency\' (id), or unified \'code\', or \'instrument_id\' (id), or unified \'symbol\' parameter for "), type), " accounts")) ;
            }
        }
        object suffix = null;
        if (!isTrue(currencyUndefined))
        {
            suffix = getValue(currency, "id");
        } else if (!isTrue(marketUndefined))
        {
            suffix = getValue(market, "id");
        }
        object accountType = ((bool) isTrue((isEqual(type, "margin")))) ? "spot" : type;
        object account = ((bool) isTrue((isEqual(type, "margin")))) ? "margin_account" : "account";
        object messageHash = add(add(accountType, "/"), account);
        object subscriptionHash = add(add(messageHash, ":"), suffix);
        object url = getValue(getValue(this.urls, "api"), "ws");
        object request = new Dictionary<string, object>() {
            { "op", "subscribe" },
            { "args", new List<object>() {subscriptionHash} },
        };
        object query = this.omit(parameters, new List<object>() {"currency", "code", "instrument_id", "symbol", "type"});
        return await this.watch(url, messageHash, this.deepExtend(request, query), subscriptionHash);
    }

    public virtual void handleBalance(WebSocketClient client, object message)
    {
        //
        // spot
        //
        //     {
        //         "table": "spot/account",
        //         "data": [
        //             {
        //                 "available": "11.044827320825",
        //                 "currency": "USDT",
        //                 "id": '',
        //                 "balance": "11.044827320825",
        //                 "hold": "0"
        //             }
        //         ]
        //     }
        //
        // margin
        //
        //     {
        //         "table": "spot/margin_account",
        //         "data": [
        //             {
        //                 "maint_margin_ratio": "0.08",
        //                 "liquidation_price": "0",
        //                 "currency:USDT": { available: "0", balance: "0", borrowed: "0", hold: "0", lending_fee: "0" },
        //                 "tiers": "1",
        //                 "instrument_id":   "ETH-USDT",
        //                 "currency:ETH": { available: "0", balance: "0", borrowed: "0", hold: "0", lending_fee: "0" }
        //             }
        //         ]
        //     }
        //
        object table = this.safeString(message, "table");
        object parts = ((string)table).Split(new [] {((string)"/")}, StringSplitOptions.None).ToList<object>();
        object data = this.safeValue(message, "data", new List<object>() {});
        ((IDictionary<string,object>)this.balance)["info"] = data;
        object type = this.safeString(parts, 0);
        if (isTrue(isEqual(type, "spot")))
        {
            object part1 = this.safeString(parts, 1);
            if (isTrue(isEqual(part1, "margin_account")))
            {
                type = "margin";
            }
        }
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object balance = this.parseBalanceByType(type, data);
            object oldBalance = this.safeValue(this.balance, type, new Dictionary<string, object>() {});
            object newBalance = this.deepExtend(oldBalance, balance);
            ((IDictionary<string,object>)this.balance)[(string)type] = this.safeBalance(newBalance);
            callDynamically(client as WebSocketClient, "resolve", new object[] {getValue(this.balance, type), table});
        }
    }

    public virtual object handleSubscriptionStatus(WebSocketClient client, object message)
    {
        //
        //     {"event":"subscribe","channel":"spot/depth:BTC-USDT"}
        //
        // const channel = this.safeString (message, 'channel');
        // ((WebSocketClient)client).subscriptions[channel] = message;
        return message;
    }

    public virtual object handleAuthenticate(WebSocketClient client, object message)
    {
        //
        //     { event: "login", success: true }
        //
        callDynamically(client as WebSocketClient, "resolve", new object[] {message, "authenticated"});
        return message;
    }

    public override object ping(WebSocketClient client)
    {
        // okex does not support built-in ws protocol-level ping-pong
        // instead it requires custom text-based ping-pong
        return "ping";
    }

    public virtual object handlePong(WebSocketClient client, object message)
    {
        client.lastPong = this.milliseconds();
        return message;
    }

    public virtual object handleErrorMessage(WebSocketClient client, object message)
    {
        //
        //     { event: "error", message: "Invalid sign", errorCode: 30013 }
        //     {"event":"error","message":"Unrecognized request: {\"event\":\"subscribe\",\"channel\":\"spot/depth:BTC-USDT\"}","errorCode":30039}
        //     { event: "error", message: "Channel spot/order doesn't exist", errorCode: 30040 }
        //
        object errorCode = this.safeString(message, "errorCode");
        try
        {
            if (isTrue(!isEqual(errorCode, null)))
            {
                object feedback = add(add(this.id, " "), this.json(message));
                this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), errorCode, feedback);
                object messageString = this.safeValue(message, "message");
                if (isTrue(!isEqual(messageString, null)))
                {
                    this.throwBroadlyMatchedException(getValue(this.exceptions, "broad"), messageString, feedback);
                }
            }
        } catch(Exception e)
        {
            if (isTrue(e is AuthenticationError))
            {
                ((WebSocketClient)client).reject(e, "authenticated");
                object method = "login";
                if (isTrue(inOp(((WebSocketClient)client).subscriptions, method)))
                {

                }
                return false;
            }
        }
        return message;
    }

    public override void handleMessage(WebSocketClient client, object message)
    {
        if (!isTrue(this.handleErrorMessage(client as WebSocketClient, message)))
        {
            return;
        }
        //
        //     {"event":"error","message":"Unrecognized request: {\"event\":\"subscribe\",\"channel\":\"spot/depth:BTC-USDT\"}","errorCode":30039}
        //     {"event":"subscribe","channel":"spot/depth:BTC-USDT"}
        //     {
        //         "table": "spot/depth",
        //         "action": "partial",
        //         "data": [
        //             {
        //                 "instrument_id":   "BTC-USDT",
        //                 "asks": [
        //                     ["5301.8", "0.03763319", "1"],
        //                     ["5302.4", "0.00305", "2"],
        //                 ],
        //                 "bids": [
        //                     ["5301.7", "0.58911427", "6"],
        //                     ["5301.6", "0.01222922", "4"],
        //                 ],
        //                 "timestamp": "2020-03-16T03:25:00.440Z",
        //                 "checksum": -2088736623
        //             }
        //         ]
        //     }
        // {
        //     "table":"spot/order",
        //     "data":[
        //         {
        //             "client_oid":"",
        //             "filled_notional":"0",
        //             "filled_size":"0",
        //             "instrument_id":"ETC-USDT",
        //             "last_fill_px":"0",
        //             "last_fill_qty":"0",
        //             "last_fill_time":"1970-01-01T00:00:00.000Z",
        //             "margin_trading":"1",
        //             "notional":"",
        //             "order_id":"3576398568830976",
        //             "order_type":"0",
        //             "price":"5.826",
        //             "side":"buy",
        //             "size":"0.1",
        //             "state":"0",
        //             "status":"open",
        //             "fee_currency":"ETC",
        //             "fee":"-0.01",
        //             "rebate_currency":"open",
        //             "rebate":"0.05",
        //             "timestamp":"2019-09-24T06:45:11.394Z",
        //             "type":"limit",
        //             "created_at":"2019-09-24T06:45:11.394Z"
        //         }
        //     ]
        // }
        //
        if (isTrue(isEqual(message, "pong")))
        {
            this.handlePong(client as WebSocketClient, message);
            return;
        }
        object table = this.safeString(message, "table");
        if (isTrue(isEqual(table, null)))
        {
            object eventVar = this.safeString(message, "event");
            if (isTrue(!isEqual(eventVar, null)))
            {
                object methods = new Dictionary<string, object>() {
                    { "login", this.handleAuthenticate },
                    { "subscribe", this.handleSubscriptionStatus },
                };
                object method = this.safeValue(methods, eventVar);
                if (isTrue(!isEqual(method, null)))
                {
                    DynamicInvoker.InvokeMethod(method, new object[] { client, message});
                }
            }
        } else
        {
            object parts = ((string)table).Split(new [] {((string)"/")}, StringSplitOptions.None).ToList<object>();
            object name = this.safeString(parts, 1);
            object methods = new Dictionary<string, object>() {
                { "depth", this.handleOrderBook },
                { "depth5", this.handleOrderBook },
                { "depth_l2_tbt", this.handleOrderBook },
                { "ticker", this.handleTicker },
                { "trade", this.handleTrade },
                { "account", this.handleBalance },
                { "margin_account", this.handleBalance },
                { "order", this.handleOrders },
            };
            object method = this.safeValue(methods, name);
            if (isTrue(isGreaterThanOrEqual(getIndexOf(name, "candle"), 0)))
            {
                method = this.handleOHLCV;
            }
            if (isTrue(!isEqual(method, null)))
            {
                DynamicInvoker.InvokeMethod(method, new object[] { client, message});
            }
        }
    }
}
