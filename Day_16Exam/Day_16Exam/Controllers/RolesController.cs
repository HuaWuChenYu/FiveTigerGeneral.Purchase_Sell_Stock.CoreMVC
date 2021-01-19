using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using DAL;
namespace Day_16Exam.Controllers
{
    public class RolesController : Controller
    {
        RolesDal rd = new RolesDal();
        // GET: Roles
        public ActionResult Index()
        {
            List<Roless> ro = rd.ShowRoles();
            return View(ro);
        }
        public ActionResult Add()
        {
           
            return View();
        }

        public ActionResult Update(int id)
        {
            Roless re = rd.ShowRoles().Where(x => x.RId.Equals(id)).FirstOrDefault();
            return View(re);
        }
        public void AddInfos(Roless ro) 
        {
            if (rd.AddInfos(ro) > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='/Roles/Index'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加成功')</script>");
            }
        }
        public void Del(int id)
        {
            if (rd.Del(id) > 0)
            {
                Response.Write("<script>alert('删除成功');location.href='/Roles/Index'</script>");
                
            }
            else
            {
                Response.Write("<script>alert('删除成功')</script>");
            }
        }
        public void UpdateInfos(Roless re)
        {
            if (rd.UpdateInfos(re) > 0)
            {
                Response.Write("<script>alert('修改成功');location.href='/Roles/Index'</script>");

            }
            else
            {
                Response.Write("<script>alert('修改成功')</script>");
            }
        }
    }
}