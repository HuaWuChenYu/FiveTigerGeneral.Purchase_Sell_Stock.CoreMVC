using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Purchase_Sell_Stock.MVC.Models.LoginFunction;
using System.Text;
using System.Net;
using System.IO;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class Login : Controller
    {
        RegisterHelper rh = new RegisterHelper();
        [Route("/Login/index")]
        public IActionResult Index()
        {
            
            return View();
        }
        public static string PostUrl = "https://106.ihuyi.com/webservice/sms.php?method=Submit";
        public int Page_Load(string mobile/*,object sender, EventArgs e*/)
        {
            //必须修改成自己的
            string account = "C66281108";//查看用户名 登录用户中心->验证码通知短信>产品总览->API接口信息->APIID
            //必须修改成自己的
            string password = "ee07813f1a433b55b4e5c3eea78c2c08"; //查看密码 登录用户中心->验证码通知短信>产品总览->API接口信息->APIKEY
                                                                  // string mobile = HttpContext.Request.Query["mobile"];
            Random rad = new Random();
            int mobile_code = rad.Next(1000, 10000);
            string content = "您的验证码是：" + mobile_code + " 。请不要把验证码泄露给其他人。";

            //Session["mobile"] = mobile;
            //Session["mobile_code"] = mobile_code;

            string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

            UTF8Encoding encoding = new UTF8Encoding();
            byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(PostUrl);
            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = postData.Length;

            Stream newStream = myRequest.GetRequestStream();
            // Send the data.
            newStream.Write(postData, 0, postData.Length);
            newStream.Flush();
            newStream.Close();

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            if (myResponse.StatusCode == HttpStatusCode.OK)
            {
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

                //Response.Write(reader.ReadToEnd());

                string res = reader.ReadToEnd();
                int len1 = res.IndexOf("</code>");
                int len2 = res.IndexOf("<code>");
                string code = res.Substring((len2 + 6), (len1 - len2 - 6));
                //Response.Write(code);
                int len3 = res.IndexOf("</msg>");
                int len4 = res.IndexOf("<msg>");
                string msg = res.Substring((len4 + 5), (len3 - len4 - 5));
                return mobile_code;

            }
            else
            {
                //访问失败
                return 0;
            }
        }
        [Route("/Login/Show")]
        public ActionResult Show()
        {
            return View();
        }
        [Route("/Login/ForgetPwd")]
        public ActionResult ForgetPwd()
        {
            return View();
        }
        public ActionResult XS()
        {
            return View();
        }

    }
}
