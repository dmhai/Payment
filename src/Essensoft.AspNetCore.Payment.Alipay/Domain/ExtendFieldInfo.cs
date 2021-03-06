﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtendFieldInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtendFieldInfo : AlipayObject
    {
        /// <summary>
        /// 字段名
        /// </summary>
        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        [JsonProperty("field_value")]
        public string FieldValue { get; set; }
    }
}
