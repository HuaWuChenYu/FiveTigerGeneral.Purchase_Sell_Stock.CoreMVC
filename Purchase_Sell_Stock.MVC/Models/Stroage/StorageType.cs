using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.Stroage
{
    /// <summary>
    /// 出入库类型表
    /// </summary>
    public class StorageType
    {
        /// <summary>
        /// 出入库类型id
        /// </summary>
        
        public int StorageTypeId { get; set; }
        /// <summary>
        /// 出入库类型名称
        /// </summary>
        
        public string StorageTypeName { get; set; }
    }
}
