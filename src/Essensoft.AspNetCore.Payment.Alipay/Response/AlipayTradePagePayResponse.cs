﻿using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradePagePayResponse.
    /// </summary>
    public class AlipayTradePagePayResponse : AlipayResponse
    {
        /// <summary>
        /// 商户原始订单号，最大长度限制32位
        /// </summary>
        [JsonProperty("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 收款支付宝账号对应的支付宝唯一用户号。  以2088开头的纯16位数字
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
