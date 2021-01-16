using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.Stroage
{
    /// <summary>
    /// 库存流水记录表
    /// </summary>
    public class FlowRecord
    {
        /// <summary>
        /// 库存流水记录表主键id
        /// </summary>
        
        public int FlowRecordId { get; set; }
        /// <summary>
        /// 出库订单表外键
        /// </summary>
        
        public int OutboundorderId { get; set; }
        /// <summary>
        /// 入库订单表外键
        /// </summary>
        
        public int IncomingorderId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
      
        public DateTime FlowRecordCreationTime { get; set; }
        /// <summary>
        /// 剩余库存（商品库存表外键）
        /// </summary>
        
        public int CommodityStocksId { get; set; }
    }
}
