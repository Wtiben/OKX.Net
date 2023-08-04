﻿using OKX.Net.Enums;
using OKX.Net.Objects.Trade;

namespace OKX.Net.Interfaces.Clients.UnifiedApi;

/// <summary>
/// Unified API trading endpoints
/// </summary>
public interface IOKXRestClientUnifiedApiTrading
{
    /// <summary>
    /// Amend incomplete orders in batches. Maximum 20 orders can be amended at a time. Request parameters should be passed in the form of an array.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-post-amend-multiple-orders" /></para>
    /// </summary>
    /// <param name="orders">Orders</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXOrderAmendResponse>>> AmendMultipleOrdersAsync(IEnumerable<OKXOrderAmendRequest> orders, CancellationToken ct = default);

    /// <summary>
    /// Amend an incomplete order.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-post-amend-order" /></para>
    /// </summary>
    /// <param name="symbol">Instrument ID</param>
    /// <param name="orderId">Order ID</param>
    /// <param name="clientOrderId">Client Order ID</param>
    /// <param name="requestId">Request ID</param>
    /// <param name="cancelOnFail">Cancel On Fail</param>
    /// <param name="newQuantity">New Quantity</param>
    /// <param name="newPrice">New Price</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<OKXOrderAmendResponse>> AmendOrderAsync(string symbol, long? orderId = null, string? clientOrderId = null, string? requestId = null, bool? cancelOnFail = null, decimal? newQuantity = null, decimal? newPrice = null, CancellationToken ct = default);

    /// <summary>
    /// Cancel unfilled algo orders(iceberg order and twap order). A maximum of 10 orders can be canceled at a time. Request parameters should be passed in the form of an array.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-algo-trading-post-cancel-algo-order" /></para>
    /// </summary>
    /// <param name="orders">Orders</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<OKXAlgoOrderResponse>> CancelAdvanceAlgoOrderAsync(IEnumerable<OKXAlgoOrderRequest> orders, CancellationToken ct = default);

    /// <summary>
    /// Cancel unfilled algo orders(trigger order, oco order, conditional order). A maximum of 10 orders can be canceled at a time. Request parameters should be passed in the form of an array.
    /// <para><a href="" /></para>
    /// </summary>
    /// <param name="orders">Orders</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<OKXAlgoOrderResponse>> CancelAlgoOrderAsync(IEnumerable<OKXAlgoOrderRequest> orders, CancellationToken ct = default);

    /// <summary>
    /// Cancel incomplete orders in batches. Maximum 20 orders can be canceled at a time. Request parameters should be passed in the form of an array.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-post-cancel-multiple-orders" /></para>
    /// </summary>
    /// <param name="orders">Orders</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXOrderCancelResponse>>> CancelMultipleOrdersAsync(IEnumerable<OKXOrderCancelRequest> orders, CancellationToken ct = default);

    /// <summary>
    /// Cancel an incomplete order.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-post-cancel-order" /></para>
    /// </summary>
    /// <param name="symbol">Symbol</param>
    /// <param name="orderId">Order ID</param>
    /// <param name="clientOrderId">Client Order ID</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<OKXOrderCancelResponse>> CancelOrderAsync(string symbol, long? orderId = null, string? clientOrderId = null, CancellationToken ct = default);

    /// <summary>
    /// Close all positions of an instrument via a market order.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-post-close-positions" /></para>
    /// </summary>
    /// <param name="symbol">Symbol</param>
    /// <param name="marginMode">Margin Mode</param>
    /// <param name="positionSide">Position Side</param>
    /// <param name="asset">Asset</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<OKXClosePositionResponse>> ClosePositionAsync(string symbol, OKXMarginMode marginMode, OKXPositionSide? positionSide = null, string? asset = null, CancellationToken ct = default);

    /// <summary>
    /// Retrieve a list of untriggered Algo orders under the current account.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-algo-trading-get-algo-order-history" /></para>
    /// </summary>
    /// <param name="algoOrderType">Algo Order Type</param>
    /// <param name="algoOrderState">Algo Order State</param>
    /// <param name="algoId">Algo ID</param>
    /// <param name="instrumentType">Instrument Type</param>
    /// <param name="symbol">Symbol</param>
    /// <param name="startTime">Pagination of data to return records earlier than the requested ts</param>
    /// <param name="endTime">Pagination of data to return records newer than the requested ts</param>
    /// <param name="limit">Number of results per request. The maximum is 100; the default is 100.</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXAlgoOrder>>> GetAlgoOrderHistoryAsync(OKXAlgoOrderType algoOrderType, OKXAlgoOrderState? algoOrderState = null, long? algoId = null, OKXInstrumentType? instrumentType = null, string? symbol = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Cancel unfilled algo orders(iceberg order and twap order). A maximum of 10 orders can be canceled at a time. Request parameters should be passed in the form of an array.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-algo-trading-get-algo-order-list" /></para>
    /// </summary>
    /// <param name="algoOrderType">Algo Order Type</param>
    /// <param name="algoId">Algo ID</param>
    /// <param name="instrumentType">Instrument Type</param>
    /// <param name="symbol">Symbol</param>
    /// <param name="startTime">Pagination of data to return records earlier than the requested ts</param>
    /// <param name="endTime">Pagination of data to return records newer than the requested ts</param>
    /// <param name="limit">Number of results per request. The maximum is 100; the default is 100.</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXAlgoOrder>>> GetAlgoOrderListAsync(OKXAlgoOrderType algoOrderType, long? algoId = null, OKXInstrumentType? instrumentType = null, string? symbol = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Retrieve the completed order data of the last 3 months, and the incomplete orders that have been canceled are only reserved for 2 hours.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-get-order-history-last-3-months" /></para>
    /// </summary>
    /// <param name="instrumentType">Instrument Type</param>
    /// <param name="symbol">Symbol</param>
    /// <param name="underlying">Underlying</param>
    /// <param name="orderType">Order Type</param>
    /// <param name="state">State</param>
    /// <param name="category">Category</param>
    /// <param name="startTime">Pagination of data to return records earlier than the requested ts</param>
    /// <param name="endTime">Pagination of data to return records newer than the requested ts</param>
    /// <param name="limit">Number of results per request. The maximum is 100; the default is 100.</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXOrder>>> GetOrderArchiveAsync(OKXInstrumentType instrumentType, string? symbol = null, string? underlying = null, OKXOrderType? orderType = null, OKXOrderState? state = null, OKXOrderCategory? category = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Retrieve order details.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-get-order-details" /></para>
    /// </summary>
    /// <param name="symbol">Instrument ID</param>
    /// <param name="orderId">Order ID</param>
    /// <param name="clientOrderId">Client Order ID</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<OKXOrder>> GetOrderDetailsAsync(string symbol, long? orderId = null, string? clientOrderId = null, CancellationToken ct = default);

    /// <summary>
    /// Retrieve the completed order data for the last 7 days, and the incomplete orders that have been cancelled are only reserved for 2 hours.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-get-order-history-last-7-days" /></para>
    /// </summary>
    /// <param name="instrumentType">Instrument Type</param>
    /// <param name="symbol">Instrument ID</param>
    /// <param name="underlying">Underlying</param>
    /// <param name="orderType">Order Type</param>
    /// <param name="state">State</param>
    /// <param name="category">Category</param>
    /// <param name="startTime">Pagination of data to return records earlier than the requested ts</param>
    /// <param name="endTime">Pagination of data to return records newer than the requested ts</param>
    /// <param name="limit">Number of results per request. The maximum is 100; the default is 100.</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXOrder>>> GetOrderHistoryAsync(OKXInstrumentType instrumentType, string? symbol = null, string? underlying = null, OKXOrderType? orderType = null, OKXOrderState? state = null, OKXOrderCategory? category = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Retrieve all incomplete orders under the current account.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-get-order-list" /></para>
    /// </summary>
    /// <param name="instrumentType">Instrument Type</param>
    /// <param name="symbol">Instrument ID</param>
    /// <param name="underlying">Underlying</param>
    /// <param name="orderType">Order Type</param>
    /// <param name="state">State</param>
    /// <param name="startTime">Pagination of data to return records earlier than the requested ts</param>
    /// <param name="endTime">Pagination of data to return records newer than the requested ts</param>
    /// <param name="limit">Number of results per request. The maximum is 100; the default is 100.</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXOrder>>> GetOrdersAsync(OKXInstrumentType? instrumentType = null, string? symbol = null, string? underlying = null, OKXOrderType? orderType = null, OKXOrderState? state = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Retrieve recently-filled transaction details in the last 3 months.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-get-transaction-details-last-3-months" /></para>
    /// </summary>
    /// <param name="instrumentType">Instrument Type</param>
    /// <param name="symbol">Symbol</param>
    /// <param name="underlying">Underlying</param>
    /// <param name="orderId">Order ID</param>
    /// <param name="startTime">Pagination of data to return records earlier than the requested ts</param>
    /// <param name="endTime">Pagination of data to return records newer than the requested ts</param>
    /// <param name="limit">Number of results per request. The maximum is 100; the default is 100.</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXTransaction>>> GetUserTradesArchiveAsync(OKXInstrumentType instrumentType, string? symbol = null, string? underlying = null, long? orderId = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Retrieve recently-filled transaction details in the last 3 day.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-get-transaction-details-last-3-days" /></para>
    /// </summary>
    /// <param name="instrumentType">Instrument Type</param>
    /// <param name="symbol">Symbol</param>
    /// <param name="underlying">Underlying</param>
    /// <param name="orderId">Order ID</param>
    /// <param name="startTime">Pagination of data to return records earlier than the requested ts</param>
    /// <param name="endTime">Pagination of data to return records newer than the requested ts</param>
    /// <param name="limit">Number of results per request. The maximum is 100; the default is 100.</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXTransaction>>> GetUserTradesAsync(OKXInstrumentType? instrumentType = null, string? symbol = null, string? underlying = null, long? orderId = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// The algo order includes trigger order, oco order, conditional order,iceberg order and twap order.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-algo-trading-post-place-algo-order" /></para>
    /// </summary>
    /// <param name="symbol">Symbol</param>
    /// <param name="tradeMode">Trade Mode</param>
    /// <param name="orderSide">Order Side</param>
    /// <param name="algoOrderType">Algo Order Type</param>
    /// <param name="quantity">Quantity</param>
    /// <param name="asset">Asset</param>
    /// <param name="reduceOnly">Reduce Only</param>
    /// <param name="positionSide">Position Side</param>
    /// <param name="quantityType">Quantity Type</param>
    /// <param name="tpTriggerPxType">Take-profit trigger price type</param>
    /// <param name="tpTriggerPrice">Take Profit Trigger Price</param>
    /// <param name="tpOrderPrice">Take Profit Order Price</param>
    /// <param name="slTriggerPxType">Stop-loss trigger price. If you fill in this parameter, you should fill in the stop-loss order price.</param>
    /// <param name="slTriggerPrice">Stop Loss Trigger Price</param>
    /// <param name="slOrderPrice">Stop Loss Order Price</param>
    /// <param name="triggerPrice">Trigger Price</param>
    /// <param name="orderPrice">Order Price</param>
    /// <param name="pxVar">Price Variance</param>
    /// <param name="priceRatio">Price Ratio</param>
    /// <param name="sizeLimit">Size Limit</param>
    /// <param name="priceLimit">Price Limit</param>
    /// <param name="callbackRatio">Callback ratio</param>
    /// <param name="callbackSpread">Callback spread</param>
    /// <param name="activePx">Active price</param>
    /// <param name="timeInterval">Time Interval</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<OKXAlgoOrderResponse>> PlaceAlgoOrderAsync(
        string symbol, 
        OKXTradeMode tradeMode, 
        OKXOrderSide orderSide, 
        OKXAlgoOrderType algoOrderType, 
        decimal quantity, 
        string? asset = null,
        bool? reduceOnly = null, 
        OKXPositionSide? positionSide = null,
        OKXQuantityType? quantityType = null,
        OKXAlgoPriceType? tpTriggerPxType = null, 
        decimal? tpTriggerPrice = null, 
        decimal? tpOrderPrice = null, 
        OKXAlgoPriceType? slTriggerPxType = null, 
        decimal? slTriggerPrice = null,
        decimal? slOrderPrice = null, 
        decimal? triggerPrice = null,
        decimal? orderPrice = null, 
        OKXPriceVariance? pxVar = null,
        decimal? priceRatio = null,
        decimal? sizeLimit = null, 
        decimal? priceLimit = null, 
        long? timeInterval = null,
        decimal? callbackRatio = null,
        decimal? activePx = null, decimal? 
        callbackSpread = null, 
        CancellationToken ct = default);

    /// <summary>
    /// Place orders in batches. Maximum 20 orders can be placed at a time. Request parameters should be passed in the form of an array.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-post-place-multiple-orders" /></para>
    /// </summary>
    /// <param name="orders">Orders</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<IEnumerable<OKXOrderPlaceResponse>>> PlaceMultipleOrdersAsync(IEnumerable<OKXOrderPlaceRequest> orders, CancellationToken ct = default);

    /// <summary>
    /// You can place an order only if you have sufficient funds.
    /// <para><a href="https://www.okx.com/docs-v5/en/#order-book-trading-trade-post-place-order" /></para>
    /// </summary>
    /// <param name="symbol">Symbol</param>
    /// <param name="tradeMode">Trade Mode</param>
    /// <param name="orderSide">Order Side</param>
    /// <param name="positionSide">Position Side</param>
    /// <param name="orderType">Order Type</param>
    /// <param name="quantity">Quantity</param>
    /// <param name="price">Price</param>
    /// <param name="asset">Asset</param>
    /// <param name="clientOrderId">Client Order ID</param>
    /// <param name="reduceOnly">Whether to reduce position only or not, true false, the default is false.</param>
    /// <param name="quantityType">Quantity Type</param>
    /// <param name="ct">Cancellation Token</param>
    /// <returns></returns>
    Task<WebCallResult<OKXOrderPlaceResponse>> PlaceOrderAsync(string symbol, OKXTradeMode tradeMode, OKXOrderSide orderSide, OKXPositionSide positionSide, OKXOrderType orderType, decimal quantity, decimal? price = null, string? asset = null, string? clientOrderId = null, bool? reduceOnly = null, OKXQuantityType? quantityType = null, CancellationToken ct = default);
}