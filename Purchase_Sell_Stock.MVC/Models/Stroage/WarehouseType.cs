using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.Stroage
{
    /// <summary>
    /// 仓库类型表
    /// </summary>
    public class WarehouseType
    {

        /// <summary>
        /// 仓库类型id	
        /// </summary>
         
        public int WarehouseTypeId { get; set; }
        /// <summary>
        /// 仓库类型	
        /// </summary>
         
        public string WarehouseTypeName { get; set; }
    }
}
