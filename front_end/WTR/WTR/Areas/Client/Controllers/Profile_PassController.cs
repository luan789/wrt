using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
namespace WTR.Areas.Client.Controllers
{
    public class Profile_PassController : Controller
    {
        // GET: Client/Profile_Pass
        public ActionResult Index(string token = null)
        {
            ViewBag.Token = token;
            return View();
        }
        public ActionResult GetData()
        {
            try
            {
                var dao = new PassengerDao();
                List<wrt_i_passenger> lst = dao.getAll().ToList();
                List<object> lstPassenger = new List<object>();
                foreach (wrt_i_passenger item in lst)
                {
                    lstPassenger.Add(new
                    {
                        id_passenger = item.id_passenger,
                        name = item.name,
                        phone = item.phone,
                        
                        e_mail = item.e_mail,
                        
                    });
                }
                return Json(new { success = true, content = lstPassenger }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác" }, JsonRequestBehavior.AllowGet);
            }

        }
       
    }
}