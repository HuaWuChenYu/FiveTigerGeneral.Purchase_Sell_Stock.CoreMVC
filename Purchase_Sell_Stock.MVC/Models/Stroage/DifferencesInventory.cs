using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.Stroage
{
    /// <summary>
    ///  差异库存表
    /// </summary>
    public class DifferencesInventory
    {
        /// <summary>
        /// 差异库存主键Id
        /// </summary>
        
        public int DifferencesInventoryId { get; set; }
        /// <summary>
        /// 出库订单表外键
        /// </summary>
        
        public int OutboundorderId { get; set; }
        /// <summary>
        /// 差异类型外键
        /// </summary>
        
        public int DifferentTypesId { get; set; }
        /// <summary>
        /// 差异数量
        /// </summary>
       
        public int DifferencesInventoryNumber { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
   
        public DateTime DifferencesInventoryCreationTime { get; set; }
    }
}
