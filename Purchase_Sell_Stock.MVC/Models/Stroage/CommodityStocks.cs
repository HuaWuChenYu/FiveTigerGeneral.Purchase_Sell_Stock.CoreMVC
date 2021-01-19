using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.Stroage
{
    /// <summary>
    /// 商品库存表
    /// </summary>
    public class CommodityStocks
    {
        /// <summary>
        /// 库存主键id
        /// </summary>
        
        public int CommodityStocksId { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        
        public int GoodsId { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
       
        public int Inventory { get; set; }
        /// <summary>
        /// 可售库存
        /// </summary>
     
        public int vendibilityInventory { get; set; }
        /// <summary>
        /// 仓库外键
        /// </summary>
        public int WarehouseId { get; set; }
    }
}
