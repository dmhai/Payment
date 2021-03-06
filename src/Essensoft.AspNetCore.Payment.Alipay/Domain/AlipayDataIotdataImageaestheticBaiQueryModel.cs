﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataImageaestheticBaiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataImageaestheticBaiQueryModel : AlipayObject
    {
        /// <summary>
        /// 用于标识不同的业务方
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用于标识当次的图片base64数据
        /// </summary>
        [JsonProperty("image_base_64")]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// 图片的oss url地址
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 用于标识当次请求
        /// </summary>
        [JsonProperty("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// url 或 base64
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
