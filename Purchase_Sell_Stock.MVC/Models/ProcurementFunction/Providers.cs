﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Purchase_Sell_Stock.MVC.Models.ProcurementFunction
{
    /// <summary>
    /// 供应商表
    /// </summary>
    public class Providers
    {
        /// <summary>
        /// 供应商主键
        /// </summary>
        public int ProviderId { get; set; }
        /// <summary>
        /// 供应商编码
        /// </summary>
        public string ProvidersNum { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string ProvidersName { get; set; }
        /// <summary>
        /// 供应商类别
        /// </summary>
        public string ProvidersType { get; set; }
        /// <summary>
        /// 供应商负责人
        /// </summary>
        public string ProvidersPerson { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime ProvidersTime { get; set; }
        /// <summary>
        /// 供应商创建人
        /// </summary>
        public string ProvidersCreator { get; set; }
        /// <summary>
        /// 店铺外键
        /// </summary>
        public int StoreId { get; set; }
    }
}
