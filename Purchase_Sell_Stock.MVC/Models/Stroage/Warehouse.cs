using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.Stroage
{
    /// <summary>
    /// 仓库表
    /// </summary>
    public class Warehouse
    {
        /// <summary>
        /// 仓库Id
        /// </summary>
         
        public int WarehouseId { get; set; }
        /// <summary>
        /// 仓库编号
        /// </summary>
       
        public string WarehouseOrderNumber { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        
        public string WarehouseName { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        
        public string WarehousePrincipal { get; set; }
        /// <summary>
        /// 负责人电话
        /// </summary>
        
        public string WarehousePrincipalPhone { get; set; }
        /// <summary>
        /// 仓库位置
        /// </summary>
       
        public string Warehouselocation { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        
        public string WarehouseRemark { get; set; }
        /// <summary>
        /// 仓库状态（开启关闭）	
        /// </summary>
         
        public int WarehouseState { get; set; }
        /// <summary>
        /// 仓库类型(仓库类型外键)	
        /// </summary>
       
        public int WarehouseTypeId { get; set; }
    }
}
