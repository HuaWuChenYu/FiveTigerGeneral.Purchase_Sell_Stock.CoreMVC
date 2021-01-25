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
        //店铺信息
        public IActionResult StoreInfo()
        {
            return View();
        }
        //店铺设置
        public IActionResult StoreSetAdd()
        {
            return View();
        }
        //主体认证
        public IActionResult CompanyAdd()
        {
            return View();
        }
        //角色权限
        public IActionResult UpdateRolesPowers()
        {
            return View();
        }
        //显示员工
        public IActionResult EmployeeShow()
        {
            return View();
        }
        //添加员工
        public IActionResult AddEmployee()
        {
            return View();
        }
        //修改员工
        public IActionResult UpdateEmployee(int id)
        {
            ViewBag.id = id;
            return View();
        }
        //部门显示
        public IActionResult DepartmentShow()
        {
            return View();
        }
        //创建部门
        public IActionResult AddDepartment(int id=-1)
        {
            ViewBag.adid = id;
            return View();
        }
        //修改员工
        public IActionResult UpdateDepartment(int id)
        {
            ViewBag.did = id;
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
