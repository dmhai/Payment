﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanRepayDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanRepayDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 贷款申请受理单号，与外部业务单号二者不能同时为空
        /// </summary>
        [JsonProperty("apply_receipt_no")]
        public string ApplyReceiptNo { get; set; }

        /// <summary>
        /// 查询还款流水明细截止时间
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 外部业务单号，与贷款申请受理单号二者不能同时为空
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 查询还款流水明细起始时间
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }
}
