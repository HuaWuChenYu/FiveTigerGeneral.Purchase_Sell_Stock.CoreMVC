using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// config 的摘要说明
/// </summary>
public class config
{
    public config()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
   

    // 应用ID,您的APPID
    public static string app_id = "2021000116698345";

    // 支付宝网关
    public static string gatewayUrl = "https://openapi.alipay.com/gateway.do";

    // 商户私钥，您的原始格式RSA私钥
    public static string private_key = "MIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCE+MmX4R77ACkV1wAQbxBrhcBZ++NHgJpO++ls2BWQhPep8qaqBwG0sPukrUZa6Y36xsIJw1YLEjfksXTmRr6QKl6inE99kaRSKaKSuUXFJECTWynTkscXrJw5Jp3AI0JwVFGgSadr7qvZHpr5aqJmDNz/WIZhbczQpJGDikw7TIo94YyLZgC6BNRMooyOqc96a1M0kh0+5roPcIlYIMPJcsQgepn9P9U/h2KHfCA8PVJ3F8yyJD0YoR+uGrzu9yCFeumQ1OzzINKbxyyI4gf2Lqex/yD8X8Fj5ZDKLQd/h3QbzMBP1UQWdkJn+qGJX4dTdlBXws8/ddwYYYj5hIvJAgMBAAECggEASLGJ5BIaUbYAwAPN8S4GmAGC6q6dzdUshsmJDwwCngNTMgGJw6IY+KNYrupbcBAGonZOVfAH9f17uPaapdk/DKldGyDBBDC+2HwSeIv47JGpC+Xms9emJ/chYM0PqJ6eD7LI/QvHD2ZnZEcrCfeV2JxnpODMdi8ErXuKYZMVocSmk+n1HuoHNSzSc3PzWB0lFJPAGQoxHRRmQfFrN507spFmXrsmqByMdKL22OzNKurKBY4XdTBTf5yN1hP6KM8VEWv2QlbPcnMSfZHoxAR+Wi2/OqinBt1nPJahbQeMot1ppzOf7PLZaDDoVSB4DLfG6fsxFsCD3IxuXSbSQ5vaQQKBgQDT5Yj0BwV9HXzTCnhFGtq9v3oKOjyKtFWxddcu7QSO6tDOtyq0oI2c5wuN5laTLW3nnk7S3TXpkZJuJsrwmjDgPUVxLV+ubNYm2DssYffKIgEfLnAIsYlmjA0E8rYIb6E24FuNBkljxHmh6mHgHicPQqG7EaY9lKzgwWeCkBqNZQKBgQCgpek8n3pWDxy+O+rWf/PJjQkWlXvw+mSm7AdpC2OippPVOm2q3LAD62w6osc/Uc3sqMSnJu5viZJ4WQavr/euzRpoBhODVq+ytFbEHj73nWMrc4afdJAAg1GLNx5TgG/Lu4/Jym1HGrkkuGkhld1a/H6ISMIXaylkrZGQz+tAlQKBgALchaXt9lgDLu1WpdshCrUnQcmjka+50bJsyfQbRUV8zEcOWChKRr9Iq3JGGwMvyN0o2R2l2RWHXrfYFEN9gY11pltp5nHfjGDH6LynsgXrwaIfKWoko5tb5s0bTfP9Nescyn+0Bweu3omeNaYmIhblqnNxQJJyUIdUdUZhFcq1AoGAaBhZs6CbAty0AUiN+QPcEkPDGdEvCI0XX1odyyFIJILP1CESIt7xZvjLnosPlKYLS0hodO8zHS8Fq9n0DS92zNu2OqWFS1uGacOVXWtD3esr8WHgX76F+O8ejZjfm7fjuR4GI/l5KdPVGEguR0b2shheXSzYJ5iWr9gQNMelZqkCgYBR5v5umj+xa+fqUKTK+cyWPEgKC84honuaXSS+FBN02ot3HimZfTpw8F3aNZH6VAGfti+2b7oxaPYCFfShP+KsVeenYbi0pKHXOZzKSkv73SD1B6NBVLBiDe19B5HXil0OWCKtL2oOmeauMRiX78fkWccan3QPyUX4KNBKMLkRuQ=="; //这里是RSA2生成的商户私钥


    // 支付宝公钥,查看地址：https://openhome.alipay.com/platform/keyManage.htm 对应APPID下的支付宝公钥。
    public static string alipay_public_key = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAkIyVL/CZiK4PBLK6PypE8Mh6BBK5oQN/KyJZ9ugRvb2svysauomItC0CXRu0zScJh3sVhfmpiH0KzRJZtTXiytzujKYFJSpKBKnlI2a/OEy2ocx8tMR1i62sXW/aZtzn34liZkvF2B0IYgj8b/4G8eZ8rMdolyvhXS0OMSpQyaEV2/V6dkemwq+e4G0IJBxKVOkMTDYCdEyBv2dVqIYKnD4Lmtyzeyczc7R2Q0Dx9ILmp0zlhzNbGZlKzZGYRE9BVk+sX3iI8uPIWorkYJeMXPBdD62hzbx6/Vnukdqbu492fmvZ+bd7KRLlWF+Ywabn3kbuQn0q5CsD72K+OT9sIwIDAQAB";//这里是支付宝公钥  

    // 签名方式
    public static string sign_type = "RSA2";

    // 编码格式
    public static string charset = "UTF-8";
}