using System;
using System.Collections.Generic;
using System.Text;

namespace Purchase_Sell_Stock.MVC.Models.GoodsFunction
{
    public class GoodsPaging<T>
    {
        public List<T> list { get; set; }
        public int Count { get; set; }
    }
}
