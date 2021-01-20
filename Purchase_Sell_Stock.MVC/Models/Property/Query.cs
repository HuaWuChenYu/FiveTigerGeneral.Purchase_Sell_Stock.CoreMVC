using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.Property
{
    public class Query
    {
        public string buyer_logon_id { get; set; }
        public string buyer_user_id { get; set; }
        public string out_trade_no { get; set; }
        public string send_pay_date { get; set; }
        public string total_amount { get; set; }
        public string trade_status { get; set; }
    }
}
