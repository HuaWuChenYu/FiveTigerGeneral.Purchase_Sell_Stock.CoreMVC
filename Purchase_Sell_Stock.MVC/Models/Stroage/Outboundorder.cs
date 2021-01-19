using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.Stroage
{
    /// <summary>
    /// 出库订单表
    /// </summary>
    public class Outboundorder
    {
        /// <summary>
        /// 出库订单Id
        /// </summary>
       
        public int OutboundorderId { get; set; }
        /// <summary>
        /// 出库订单编号
        /// </summary>
        
        public string OutboundorderOrderNumber { get; set; }
        /// <summary>
        /// 订单外键
        /// </summary>
         
        public int OrdersId { get; set; }
        /// <summary>
        /// 出库类型外键
        /// </summary>
         
        public int StorageTypeId { get; set; }
        /// <summary>
        /// 状态（待出库 部分出库 已出库）
        /// </summary>
        
        public int OutboundorderState { get; set; }
        /// <summary>
        /// 出库数量（默认值0）
        /// </summary>
        
        public int OutboundorderNumber { get; set; }
        /// <summary>
        /// 发货方（仓库）（仓库外键）
        /// </summary>
         
        public int WarehouseId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
         
        public DateTime OutboundordercreationTime { get; set; }
        /// <summary>
        /// 出库时间	
        /// </summary>
        
        public DateTime OutboundorderTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
         
        public string OutboundorderRemark { get; set; }
    }
}
