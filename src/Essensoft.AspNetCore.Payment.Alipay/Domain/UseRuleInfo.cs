﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UseRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UseRuleInfo : AlipayObject
    {
        /// <summary>
        /// 适用门店列表
        /// </summary>
        [JsonProperty("suitable_shops")]
        public List<string> SuitableShops { get; set; }

        /// <summary>
        /// 核销方式
        /// </summary>
        [JsonProperty("use_mode")]
        public List<string> UseMode { get; set; }
    }
}
