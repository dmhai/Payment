﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CraftsmanAssessment Data Structure.
    /// </summary>
    [Serializable]
    public class CraftsmanAssessment : AlipayObject
    {
        /// <summary>
        /// 子评分项
        /// </summary>
        [JsonProperty("sub_assessments")]
        public List<CraftsmanSubAssessment> SubAssessments { get; set; }

        /// <summary>
        /// 单个手艺人的评价总条数。
        /// </summary>
        [JsonProperty("total_no")]
        public long TotalNo { get; set; }

        /// <summary>
        /// 单个手艺人的总评分的均分
        /// </summary>
        [JsonProperty("total_score")]
        public long TotalScore { get; set; }
    }
}
