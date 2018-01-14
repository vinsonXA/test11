using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
namespace MvcApplication1.Controllers
{
    public class LoginController : Controller
    {
        //  
        // GET: /Login/  
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public void Index(string username, string password)
        {
            Models.Login_BS l_bs = new MvcApplication1.Models.Login_BS();
            if (l_bs.login(username, password))
            {
                Response.Write("登陆成功,用户名称为：" + username);
            }
            else
            {
                Response.Write("登陆失败");

            }
        }
    }
}