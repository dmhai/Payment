﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktCouponBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCouponBaseDTO : AlipayObject
    {
        /// <summary>
        /// 权益Id
        /// </summary>
        [JsonProperty("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonProperty("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [JsonProperty("coupon_value")]
        public string CouponValue { get; set; }
    }
}
