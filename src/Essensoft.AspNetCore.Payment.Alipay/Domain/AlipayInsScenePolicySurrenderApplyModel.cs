﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsScenePolicySurrenderApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePolicySurrenderApplyModel : AlipayObject
    {
        /// <summary>
        /// 退保扩展参数 ;标准json格式
        /// </summary>
        [JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 蚂蚁保险平台生成的保单号
        /// </summary>
        [JsonProperty("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 退保时标识的退保计价方式:  01:退保不退款 02:指定金额退款 03:全额退 04:区间退保 05:全额比例退
        /// </summary>
        [JsonProperty("surrender_price_type")]
        public string SurrenderPriceType { get; set; }

        /// <summary>
        /// 退保原因说明
        /// </summary>
        [JsonProperty("surrender_reason")]
        public string SurrenderReason { get; set; }

        /// <summary>
        /// 标识保单的退保时间(如不输入，默认当前时间)
        /// </summary>
        [JsonProperty("surrender_time")]
        public string SurrenderTime { get; set; }
    }
}
