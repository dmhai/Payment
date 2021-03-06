﻿using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradePageRefundResponse.
    /// </summary>
    public class AlipayTradePageRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 退款请求号
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次退款请求金额
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
