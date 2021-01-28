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
        public static string httpPart = "49.234.34.192:8022";
        //店铺信息
        public IActionResult StoreInfo()
        {
            ViewBag.Url = httpPart;
            var sid = HttpContext.Session.GetInt32("storeId");
            ViewBag.sid = sid;
            return View();
        }
        //店铺设置
        public IActionResult StoreSetAdd()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        //主体认证
        public IActionResult CompanyAdd()
        {
            ViewBag.Url = httpPart;
            var sid= HttpContext.Session.GetInt32("storeId");
            ViewBag.sid = sid;
            return View();
        }
        //角色权限
        public IActionResult UpdateRolesPowers()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        //显示员工
        public IActionResult EmployeeShow()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        //添加员工
        public IActionResult AddEmployee()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        //修改员工
        public IActionResult UpdateEmployee(int id)
        {
            ViewBag.Url = httpPart;
            ViewBag.id = id;
            return View();
        }
        //部门显示
        public IActionResult DepartmentShow()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        //创建部门
        public IActionResult AddDepartment(int id=-1)
        {
            ViewBag.Url = httpPart;
            ViewBag.adid = id;
            return View();
        }
        //修改员工
        public IActionResult UpdateDepartment(int id)
        {
            ViewBag.Url = httpPart;
            ViewBag.did = id;
            return View();
        }
        public IActionResult Test()
        {
            ViewBag.Url = httpPart;
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
