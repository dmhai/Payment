﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintActionNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintActionNotifyModel : AlipayObject
    {
        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("eprint_sign")]
        public string EprintSign { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 授权类型：0=自有应用授权、1=开放应用授权
        /// </summary>
        [JsonProperty("oauth_type")]
        public long OauthType { get; set; }

        /// <summary>
        /// 云平台订单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 回调时间
        /// </summary>
        [JsonProperty("push_time")]
        public string PushTime { get; set; }

        /// <summary>
        /// 按键行为 0=拒单 1=接单
        /// </summary>
        [JsonProperty("state")]
        public long State { get; set; }
    }
}
