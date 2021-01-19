using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult StoreInfo()
        {
            return View();
        }
        public IActionResult UpdateRolesPowers()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        //图片上传
        public object GetImg()
        {
            IFormFile imgFile= Request.Form.Files[0];
            string extName = Path.GetExtension(imgFile.FileName).ToUpper();
            string path= Directory.GetCurrentDirectory()+@"\wwwroot\Img\";
            if (Directory.Exists(path)==false)
            {
                Directory.CreateDirectory(path);
            }
            string fileNewName = Guid.NewGuid().ToString();
            string imgUrl = path + fileNewName+extName;
            string imgUrlDB = "/Img/"+ fileNewName + extName;
            using (FileStream fs=System.IO.File.Create(imgUrl))
            {
                imgFile.CopyTo(fs);
                fs.Flush();
            }
            var dataJson = new
            {
                result = imgUrlDB,
                code = 0
            };
            return dataJson;
        }
    }
}
