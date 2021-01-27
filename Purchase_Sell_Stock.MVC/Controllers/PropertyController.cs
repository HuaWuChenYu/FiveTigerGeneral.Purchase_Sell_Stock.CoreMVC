using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Purchase_Sell_Stock.MVC.Models.Property;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        string pirvateKey = "MIIEogIBAAKCAQEAp50oNH1g8/iyfdtiU/COyk+2xXU1qZVTDdC7W2VS9yeFpQcRGrpIN020FK7mXc1i76/oAvicXboT" +
                            "TeRQlxrx0wHRBy5/haMmv0bgujlm71zHoXumkLsWMJyWrPGqgnQ2XBTo7KsyzU8OamYVZy41gq8or72E13HaNbAJdUKFLLcUlONUUjmjyaWp" +
                            "zmgIKEDpiXKErNb+11aGUn9rLKMwQrLXBoIzgnIbqjXji1r1sDa7EuhCQIwiAWpIuqIUJ2v+nANupTU3p+B1uvtbEKm89tDPN9qdFgwOdPB+" +
                            "/YTUMlT2qUC4ulYZ8DE8BNdZ/0X5mKvpD4DOFOXrWs0X468GHQIDAQABAoIBAFOERDc7TebiwZVijfEDSTLXW1uyFmYEaJjWq7RTnW5XPAl" +
                            "JpyUpMriTuCoiJ9kPcL+7Z6CrXcZ55AqIu/s+ysX3/r5UVegxrina2DkSRw73rOTypsEw51Kbg5xy4iIUY82oAZODjlGslaNAcGO0K6eNPXm" +
                            "rthhfu3nK2DucRJ1NYbN3NNkqggDHMSaSlya0ja2sKxUFEtzccHeV4HSTSvcAI0vhyjwLWaGLCX6J87otGYJNeMLq6bXZWUoe8UpBbaBK44Np" +
                            "4qA9SCKfrAc1r2UcUoCn7mH/L8c8LGAnTdIZ02pTEP/IljgSdCJUJvTnQwRK+my5gmm4kpgPqB7dsUUCgYEA03QXrkCwr+WJPW2v/WjQGM7LS" +
                            "3ILI5yg66eihc/o+N12j5/S6WFcaj+Qb6xrpxp6G66zKkJdNhV6bKAgTuE45DJL6t4+zuGFw130jmUWHBWIiW5s2GFEXuzvelzEv7gHEco2SH" +
                            "StPpmB00HN8yA8xyDkXpBc//JXvHQwSJtEs68CgYEAyuy/4w6hrWFKizxuhmYCdIjPh01X6xzcpns+KydvrIIJf/qXsRBJsflaGUXNOfdHFECR" +
                            "q5e1GyAVx000D9mj1CpCdtTt8TiPtGkFxnZVMo5Lk3oO1NElluFmCJWW3iWHwuzFmNnIczl0QiFeGxQDh5/Y7GgrqMshB+jsWSMRufMCgYADQx" +
                            "A2dPME06KpWu7TFvHW4CHMuSao1vq4h+5+5/UtGaWBk7KaPRFC5lYhEuTaQBNQKALFjR6I/g3UbSfyb5EEHC6FogYQBPSeTe2+4JpVtpNTo2t0b" +
                            "xOx7y/GkHXMi1c4lAkAVyRxCccx7hryPDYT0FMVjl6Q6DkoRBaWmCaYKwKBgFme1eBhxeXc4h88QVP6GXt+MKmA7yNXS9v68in88MUvaSKsefIp" +
                            "T2LazX/74/eFzk6TdcJi7glc0kGDR0r4w/If99qjj7LJWC5Fc9eCy33YemhXr9UtyXwpb/a6mjbiPGNKTrqC9JRu+3l5YyZyYFy1rAg8uYuCqsP" +
                            "jiv6TDnEhAoGACfSHlqJ/n+WD61EGeYSvPSrTi5meY8/6UI+QlCXCIVjOiitHSgpghhwenXCsf1DNOvfiqfwmLWUNzcnzYwHNJE9+z09CgvqwNP" +
                            "IRgW0PC4mjGvjK20v53Kz2zK1MB51bUiMiF+w3joB3MLaSBFF/olT18pKQXojV/nSZ9fAijH8="; //这里是RSA2生成的商户私钥
        string appId = "2021000116698345";//这里是Appid 
        string publicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAkIyVL/CZiK4PBLK6PypE8Mh6BBK5oQN/KyJZ9ugRvb2svysauomItC0CXRu0zScJh3sVhfmp" +
                           "iH0KzRJZtTXiytzujKYFJSpKBKnlI2a/OEy2ocx8tMR1i62sXW/aZtzn34liZkvF2B0IYgj8b/4G8eZ8rMdolyvhXS0OMSpQyaEV2/V6dkemwq+e4G0IJBxKVOkMTDYCdEy" +
                           "Bv2dVqIYKnD4Lmtyzeyczc7R2Q0Dx9ILmp0zlhzNbGZlKzZGYRE9BVk+sX3iI8uPIWorkYJeMXPBdD62hzbx6/Vnukdqbu492fmvZ+bd7KRLlWF+Ywabn3kbuQn0q5CsD72" +
                           "K+OT9sIwIDAQAB"; //这里是支付宝公钥  

        //充值视图
        public IActionResult Recharge()
        {
            return View();
          
        }

        
        //支付宝充值方法接口调用
        [HttpPost]
        public IActionResult alipay(string Money)
        {

            Random random = new Random();
            //业务逻辑
            string radid = random.Next(13245, 12345642).ToString();
            string OutTradeNo= "JD_"+ radid;
            string productname = "烦死";

            IAopClient client = new DefaultAopClient("https://openapi.alipaydev.com/gateway.do", appId, pirvateKey, "json", "1.0", "RSA2", publicKey, "utf-8", false);
            System.Net.Http.HttpClient clients = new HttpClient();
            clients.BaseAddress = new Uri("http://localhost:49760/");
            clients.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var responses = clients.GetAsync("api/AddBilling_detailsInfos?UserId=" + 1 + "&Account_Type=" + "店铺收益" + "&Account_Money=" + Money + "&InorOut=" + 1 + "&Order_type=" + "支付宝充值" + "&Order_NUm=" + OutTradeNo).Result;
            if (responses.IsSuccessStatusCode)  //判断请求返回的是否为200
            {
                //请求成功将不再请求
                clients = null;
            }
            AlipayTradePagePayModel model = new AlipayTradePagePayModel();

            model.Body = "买不了吃亏"; //描述 //商品描述
            model.Subject = productname;//名称 //商品名称
            model.TotalAmount = Money;//价格 商品价格
            model.OutTradeNo =OutTradeNo;  //商户订单号  
            model.ProductCode = "FAST_INSTANT_TRADE_PAY";

            AlipayTradePagePayRequest request = new AlipayTradePagePayRequest();
            // 设置同步回调地址
            // 支付成功之后要跳转的页面
            request.SetReturnUrl(" http://localhost:57736/Property/Balance");

            // 设置异步通知接收地址
            request.SetNotifyUrl("");
            // 将业务model载入到request
            request.SetBizModel(model);
           
            AlipayTradePagePayResponse response = null;
            try
            {
                 response = client.pageExecute(request, null, "post");  //调用支付宝 它是以Post 方式
               
            }

            catch (Exception exp)
            {
                throw exp;

            }

            
            return Content(response.Body); //把支付宝反回来的数据 全部加载到页面上

        }

      
        public Query Query(string WIDout_trade_no = "3795556")
        {

            DefaultAopClient client = new DefaultAopClient("https://openapi.alipaydev.com/gateway.do", appId, pirvateKey, "json", "1.0", "RSA2", publicKey, "utf-8", false);

            // 商户订单号，和交易号不能同时为空
            string out_trade_no = WIDout_trade_no.Trim();

            //// 支付宝交易号，和商户订单号不能同时为空
            //string trade_no = WIDtrade_no.Text.Trim();

            AlipayTradeQueryModel model = new AlipayTradeQueryModel();
            model.OutTradeNo = out_trade_no;
            //model.TradeNo = trade_no;

            AlipayTradeQueryRequest request = new AlipayTradeQueryRequest();
            request.SetBizModel(model);

            AlipayTradeQueryResponse response = null;
            try
            {
                response = client.Execute(request);


                return Newtonsoft.Json.JsonConvert.DeserializeObject<Query>(response.Body);

            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        //资金管理视图
        public IActionResult Balance()
        {
            return View();

        }

        //对账详细视图
        public IActionResult Billing()
        {
            return View();
        }

        //提现接口（暂为拥有该能力）
        public IActionResult TransToaccount()
        {

            IAopClient client = new DefaultAopClient("https://openapi.alipaydev.com/gateway.do", appId, pirvateKey, "json", "1.0", "RSA2", publicKey, "utf-8", false);
            AlipayFundTransUniTransferRequest request = new AlipayFundTransUniTransferRequest();
            request.BizContent = "{" +
            "\"out_biz_no\":\"201806300001\"," +
            "\"trans_amount\":23.00," +
            "\"product_code\":\"TRANS_ACCOUNT_NO_PWD\"," +
            "\"biz_scene\":\"DIRECT_TRANSFER\"," +
            "\"order_title\":\"转账标题\"," +
            "\"original_order_id\":\"20190620110075000006640000063056\"," +
            "\"payee_info\":{" +
            "\"identity\":\"208812*****41234\"," +
            "\"identity_type\":\"ALIPAY_USER_ID\"," +
            "\"name\":\"黄龙国际有限公司\"" +
            "    }," +
            "\"remark\":\"单笔转账\"," +
            "\"business_params\":\"{\\\"sub_biz_scene\\\":\\\"REDPACKET\\\"}\"" +
            "  }";
            AlipayFundTransUniTransferResponse response = client.Execute(request);
            return Content(response.Body);
        }

        public IActionResult Amount_settled()
        {
            return View();
        }

       

    }
}
