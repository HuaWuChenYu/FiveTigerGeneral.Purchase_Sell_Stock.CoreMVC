using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Purchase_Sell_Stock.MVC.Models.LoginFunction;
using System.Text;
using System.Net;
using System.IO;
using System.Configuration;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class LoginController : Controller
    {
        RegisterHelper rh = new RegisterHelper();
        [Route("/Login/index")]
        public IActionResult Index()
        {
            
            return View();
        }
        public static string PostUrl = ConfigurationManager.AppSettings["WebReference.Service.PostUrl"];
        public IActionResult LoginIndex()
        {
            return View();
        }
        //public IActionResult GetMessage()
        //{
        //    //定义你的账号密码（你在互亿无线注册的账号密码）
        //    string account = "互亿无线注册的账号";
        //    string password = "互亿无线注册的密码";//密码可以使用明文密码或使用32位MD5加密

        //    //获取Ajax传输过来的手机号码
        //    string mobile = Request.QueryString["mobile"];

        //    //在1000-10000之间随机获取一个数值 作为你的 手机验证码
        //    Random rad = new Random();
        //    int mobile_code = rad.Next(1000, 10000);

        //    //定义发送至手机中显示的信息
        //    string content = "您的验证码是：" + mobile_code + " 。请不要把验证码泄露给其他人。";

        //    //将你的手机号码存入Session中
        //    Session["mobile"] = mobile;

        //    //将你的手机验证码存入Session中
        //    Session["mobile_code"] = mobile_code;

        //    string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

        //    //将账号，密码，手机号码，手机验证码等字符串进行编码，并将它们存储在字节数组postData中
        //    UTF8Encoding encoding = new UTF8Encoding();
        //    byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

        //    //设置发送请求报文
        //    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(PostUrl);//PostUrl在Web.config中定义
        //    myRequest.Method = "POST";
        //    myRequest.ContentType = "application/x-www-form-urlencoded";
        //    myRequest.ContentLength = postData.Length;

        //    //创建流
        //    Stream newStream = myRequest.GetRequestStream();

        //    //发送数据
        //    newStream.Write(postData, 0, postData.Length);
        //    newStream.Flush();
        //    newStream.Close();

        //    //获取返回信息（xml）
        //    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
        //    if (myResponse.StatusCode == HttpStatusCode.OK)
        //    {
        //        StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);


        //        string res = reader.ReadToEnd();

        //        //获取返回枚举值
        //        int len1 = res.IndexOf("</code>");
        //        int len2 = res.IndexOf("<code>");
        //        string code = res.Substring((len2 + 6), (len1 - len2 - 6));

        //        //获取返回信息
        //        int len3 = res.IndexOf("</msg>");
        //        int len4 = res.IndexOf("<msg>");
        //        string msg = res.Substring((len4 + 5), (len3 - len4 - 5));
        //        Response.Write(msg);

        //        Response.End();

        //    }
        //    else
        //    {
        //        //访问失败
        //        Response.Write("err");
        //    }
        //}
        ////public static string PostUrl = "https://106.ihuyi.com/webservice/sms.php?method=Submit";
        //public int Page_Load(string mobile/*,object sender, EventArgs e*/)
        //{
        //    //必须修改成自己的
        //    string account = "C66281108";//查看用户名 登录用户中心->验证码通知短信>产品总览->API接口信息->APIID
        //    //必须修改成自己的
        //    string password = "ee07813f1a433b55b4e5c3eea78c2c08"; //查看密码 登录用户中心->验证码通知短信>产品总览->API接口信息->APIKEY
        //                                                          // string mobile = HttpContext.Request.Query["mobile"];
        //    Random rad = new Random();
        //    int mobile_code = rad.Next(1000, 10000);
        //    string content = "您的验证码是：" + mobile_code + " 。请不要把验证码泄露给其他人。";

        //    //Session["mobile"] = mobile;
        //    //Session["mobile_code"] = mobile_code;

        //    string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

        //    UTF8Encoding encoding = new UTF8Encoding();
        //    byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

        //    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(PostUrl);
        //    myRequest.Method = "POST";
        //    myRequest.ContentType = "application/x-www-form-urlencoded";
        //    myRequest.ContentLength = postData.Length;

        //    Stream newStream = myRequest.GetRequestStream();
        //    // Send the data.
        //    newStream.Write(postData, 0, postData.Length);
        //    newStream.Flush();
        //    newStream.Close();

        //    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
        //    if (myResponse.StatusCode == HttpStatusCode.OK)
        //    {
        //        StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

        //        //Response.Write(reader.ReadToEnd());

        //        string res = reader.ReadToEnd();
        //        int len1 = res.IndexOf("</code>");
        //        int len2 = res.IndexOf("<code>");
        //        string code = res.Substring((len2 + 6), (len1 - len2 - 6));
        //        //Response.Write(code);
        //        int len3 = res.IndexOf("</msg>");
        //        int len4 = res.IndexOf("<msg>");
        //        string msg = res.Substring((len4 + 5), (len3 - len4 - 5));
        //        return mobile_code;

        //    }
        //    else
        //    {
        //        //访问失败
        //        return 0;
        //    }
        //}
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
