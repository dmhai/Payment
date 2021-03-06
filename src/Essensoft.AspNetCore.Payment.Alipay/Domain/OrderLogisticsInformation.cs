﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderLogisticsInformation Data Structure.
    /// </summary>
    [Serializable]
    public class OrderLogisticsInformation : AlipayObject
    {
        /// <summary>
        /// 物流信息
        /// </summary>
        [JsonProperty("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("express_company")]
        public string ExpressCompany { get; set; }

        /// <summary>
        /// 是否匹配到物流单号
        /// </summary>
        [JsonProperty("has_matched")]
        public bool HasMatched { get; set; }

        /// <summary>
        /// 物流状态 RECEIVE_SUCCESS-揽件成功 DELIVER_SUCCESS-快件发出 TRANSIT-中转 DELIVERY_REMIND-派件提醒 TO_PICK_UP-待提货 RECEIVE_SIGN-已签收 SIGN_FAILED-签收失败
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
