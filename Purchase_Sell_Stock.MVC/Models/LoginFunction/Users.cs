using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Models.LoginFunction
{
    public class Users
    {
        public int UserId { get; set; }//用户主键
        public string UserAccount { get; set; }//用户账号
        public string UserPhone { get; set; }//用户手机号
        public string UserPassword { get; set; }//用户密码
    }
}
