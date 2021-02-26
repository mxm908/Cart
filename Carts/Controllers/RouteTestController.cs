using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carts.Controllers
{
    public class RouteTestController : Controller
    {
        // GET: RouteTest
        public ActionResult Index()
        {
            var result = Models.RouteTest.TempProducts.getAllproducts();
            return View(result);
        }

        public ActionResult Index2(string id)
        {
            return Content(
                string.Format("id的值為:{0}", id));
        }

        public ActionResult Index3(string name ,string id)
        {
            return Content(
                string.Format("使用者為{0},ID為{1}",name,id)
                );
        }
    }
}