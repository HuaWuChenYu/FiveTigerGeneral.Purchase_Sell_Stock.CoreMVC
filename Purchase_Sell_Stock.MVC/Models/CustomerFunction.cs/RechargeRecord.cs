﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.CustomerFunction.cs
{
    /// <summary>
    /// 充值记录
    /// </summary>
    public class RechargeRecord
    {
        /// <summary>
        /// 充值ID
        /// </summary>
        public int RechargeId { get; set; }
        /// <summary>
        /// 充值时间
        /// </summary>
        public DateTime PrepaidTime { get; set; }
        /// <summary>
        /// 买家外键
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// 面额标题
        /// </summary>
        public string DenominationLable { get; set; }
        /// <summary>
        /// 店铺外键
        /// </summary>
        public int StoreId { get; set; }
    }
}
