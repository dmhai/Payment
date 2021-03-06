﻿using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelUserQueryResponse.
    /// </summary>
    public class AlipayMobilePublicLabelUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 标签编号，英文逗号分隔。
        /// </summary>
        [JsonProperty("label_ids")]
        public string LabelIds { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }
    }
}
