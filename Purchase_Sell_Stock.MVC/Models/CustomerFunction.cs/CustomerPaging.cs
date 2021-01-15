using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.CustomerFunction.cs
{
    /// <summary>
    /// 买家表分页
    /// </summary>
    public class CustomerPaging
    {
        public List<Customer> list { get; set; }
        public int Count { get; set; }
    }
}
