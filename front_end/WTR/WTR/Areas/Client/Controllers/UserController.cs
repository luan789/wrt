using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
namespace WTR.Areas.Client.Controllers
{
    public class UserController : Controller
    {
        // GET: Client/User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
   
        [HttpPost]
        public ActionResult Register(wrt_i_passenger passenger)
        {
            try
            {
                PassengerDao dao = new PassengerDao();
                string id = dao.Insert(passenger);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác", log = ex.ToString() });
            }
        }
    }
}