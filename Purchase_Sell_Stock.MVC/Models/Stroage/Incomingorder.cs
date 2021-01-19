using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.Stroage
{
    /// <summary>
    /// 入库订单表
    /// </summary>
    public class Incomingorder
    {
        /// <summary>
        /// 入库订单Id
        /// </summary>
        
        public int IncomingorderId { get; set; }
        /// <summary>
        /// 入库订单单号
        /// </summary>
       
        public string IncomingorderOrderNumber { get; set; }
        /// <summary>
        /// 采购表外键	
        /// </summary>
         
        public int ProcurementId { get; set; }
        /// <summary>
        /// 出入库类型名称
        /// </summary>
        
        public string StorageTypeName { get; set; }
        /// <summary>
        /// 状态（待入库 部分入库 已入库）
        /// </summary>
         
        public int IncomingorderState { get; set; }
        /// <summary>
        /// 收货方（仓库外键）
        /// </summary>
      
        public string WarehouseName { get; set; }
        /// <summary>
        /// 收货数量（默认值0）
        /// </summary>
      
        public int IncomingorderNumber { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
         
        public DateTime IncomingordercreationTime { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        
        public DateTime IncomingorderTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        
        public string IncomingorderRemark { get; set; }
        /// <summary>
        /// 退单表外键
        /// </summary>
         
        public int CancelOrder { get; set; }
    }
}
