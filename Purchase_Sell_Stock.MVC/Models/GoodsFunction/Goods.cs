﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Purchase_Sell_Stock.MVC.Models.GoodsFunction
{
    /// <summary>
    /// 商品模型
    /// </summary>
    public class Goods
    {
        /// <summary>
        /// 商品主键
        /// </summary>
        public int GoodsId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string GoodsPhoto { get; set; }
        /// <summary>
        /// 商品规格
        /// </summary>
        public string GoodsSize { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 进货价格
        /// </summary>
        public int ProcurementPrice { get; set; }
        /// <summary>
        /// 商品上下架状态
        /// </summary>
        public bool GoodsState { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public string Goodsclassify { get; set; }
        /// <summary>
        /// 商品分类名称
        /// </summary>
        public string GoodsTypeName { get; set; }
        /// <summary>
        /// 商品单位名称
        /// </summary>
        public string GoodsUnitName { get; set; }
        /// <summary>
        /// 商品品牌外键
        /// </summary>
        public string GoodsBrandName { get; set; }
        /// <summary>
        /// 店铺外键
        /// </summary>
        public int StoreId { get; set; }
    }
}
